using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Configuration;
using System.Globalization;
using FreeBook.Models;

namespace FreeBook
{
    class DatabaseHelper
    {
        private static readonly string _connectionString = SqlDataAccess.GetConnectionStrings();
        private static readonly string _cartiString = SqlDataAccess.GetCartiStrings();
        private static readonly string _imprumuturiString = SqlDataAccess.GetImprumuturiStrings();
        private static readonly string _utilizatoriString = SqlDataAccess.GetUtilizatoriStrings();

        public static void Initialisation()
        {
            ClearDatabase();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                InserareCarti(con);
                InserareUtilizatori(con);
                InserareImprumuturi(con);
            }
        }

        public static void UserRegistration(UserModel user)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                string cmdText = "Insert into utilizatori (nume,prenume,email,parola) values (@nume,@prenume,@email,@parola);";
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("nume", user.Nume);
                    cmd.Parameters.AddWithValue("prenume", user.Prenume);
                    cmd.Parameters.AddWithValue("parola", user.Parola);
                    cmd.Parameters.AddWithValue("email", user.Email);
                }
            }
        }

        public static UserModel IsRegistered(string email)
        {
            UserModel utilizator = new UserModel();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                string cmdText = "Select nume,prenume,email,parola from utilizatori where email=@email;";
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("email", email);
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            utilizator = new UserModel
                            {
                                Email = (string)rdr["email"],
                                Nume = (string)rdr["nume"],
                                Prenume = (string)rdr["prenume"],
                                Parola = (string)rdr["parola"]
                            };
                        }
                    }
                }

            }

            return utilizator;
        }

        public static List<BookModel> GetTakenBooks(UserModel utilizator)
        {
            List<BookModel> imprumuturi = new List<BookModel>();
            int indexCarte = 0;
            using(SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                string cmdText = "Select c.id_carte, c.titlu, c.autor, i.data_imprumut FROM carti c, imprumut i WHERE c.id_carte = i.id_carte AND i.email = @email";
                using(SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("email", utilizator.Email);

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            indexCarte++;
                            DateTime date = (DateTime)reader[3];
                            BookModel imprumut = new BookModel
                            {
                                Index = indexCarte,
                                IDCarte = (int)reader[0],
                                Titlu = (string)reader[1],
                                Autor = (string)reader[2],
                                DataImprumut = date,
                                DataExpirare = date.AddDays(+30),
                                Expirat = date < DateTime.Now ? true : false
                            };
                            imprumuturi.Add(imprumut);
                        }
                    }
                }
                return imprumuturi;
            }
        }

        public static int NrCartiImprumutate(UserModel user)
        {
            int nrCartiImprumutate = 0;
            using(SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                DateTime date = DateTime.Now.AddDays(-30);
                string cmdText = "Select * from imprumut where email=@email and data_imprumut>@data;";
                using(SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("email", user.Email);
                    cmd.Parameters.AddWithValue("data", date);
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nrCartiImprumutate++;
                        }
                    }
                }
            }
            return nrCartiImprumutate;
        }

        public static int ImprumutaCarte(int idCarte, UserModel utilizator)
        {
            using(SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                string cmdText1 = "Select count(*) from imprumut where id_carte = @id_carte and email=@email;";
                using(SqlCommand cmd = new SqlCommand(cmdText1, con))
                {
                    cmd.Parameters.AddWithValue("id_carte", idCarte);
                    cmd.Parameters.AddWithValue("email", utilizator.Email);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count != 0)
                    {
                        return -1;
                    }

                    
                }
                string cmdText2 = "Insert into imprumut (id_carte, email, data_imprumut) values (@id_carte,@email,@data_imprumut;";
                using (SqlCommand cmd = new SqlCommand(cmdText2, con))
                {
                    DateTime date = DateTime.Now;
                    cmd.Parameters.AddWithValue("id_carte", idCarte);
                    cmd.Parameters.AddWithValue("email", utilizator.Email);
                    cmd.Parameters.AddWithValue("data_imprumut", date);
                    cmd.ExecuteNonQuery();
                }
                return 0;  
            }
        }

        private static void InserareCarti(SqlConnection con)
        {
            string cmdText = "Insert into carti (titlu,autor,gen) values (@titlu,@autor,@gen);";

            using (StreamReader reader = new StreamReader(_cartiString))
            {
                while (reader.Peek() >= 0)
                {
                    var line = reader.ReadLine().Split('*');
                    using (SqlCommand cmd = new SqlCommand(cmdText, con))
                    {
                        cmd.Parameters.AddWithValue("titlu", line[0]);
                        cmd.Parameters.AddWithValue("autor", line[1]);
                        cmd.Parameters.AddWithValue("gen", line[2]);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private static void InserareUtilizatori(SqlConnection con)
        {
            string cmdText = "Insert into utilizatori (email, parola, nume, prenume) values (@email, @parola, @nume, @prenume);";
            using (StreamReader reader = new StreamReader(_utilizatoriString))
            {
                while (reader.Peek() >= 0)
                {
                    string[] line = reader.ReadLine().Split('*');
                    using (SqlCommand cmd = new SqlCommand(cmdText, con))
                    {
                        cmd.Parameters.AddWithValue("email", line[0]);
                        cmd.Parameters.AddWithValue("parola", line[1]);
                        cmd.Parameters.AddWithValue("nume", line[2]);
                        cmd.Parameters.AddWithValue("prenume", line[3]);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private static void InserareImprumuturi(SqlConnection con)
        {
            string cmdText = "Insert into imprumut (id_carte, email, data_imprumut) values (@id_carte, @email, @data_imprumut);";
            using (StreamReader reader = new StreamReader(_imprumuturiString))
            {
                while (reader.Peek() >= 0)
                {
                    string[] line = reader.ReadLine().Split('*');
                    int idCarte = 0;
                    using (SqlCommand cmd = new SqlCommand("Select id_carte from carti where titlu = @titlu", con))
                    {
                        cmd.Parameters.AddWithValue("titlu", line[0]);
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            rdr.Read();
                            idCarte = (int)rdr[0];
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand(cmdText, con))
                    {
                        cmd.Parameters.AddWithValue("id_carte", idCarte);
                        cmd.Parameters.AddWithValue("email", line[1]);
                        string date = line[2].Trim();
                        try
                        { 
                            cmd.Parameters.AddWithValue("data_imprumut", DateTime.TryParse(date, out DateTime result));
                        }
                        catch
                        {
                            Console.WriteLine("Data de pe linia " + line + " a fost introdusa gresit.");
                            cmd.Parameters.AddWithValue("data_imprumut", DateTime.Now);
                        }
                       

                    }
                }
            }
        }

        private static void ClearDatabase()
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                string cmdText = "Delete from carti";
                ExecuteSqlQuery(con, cmdText);
                cmdText = "Delete from utilizatori";
                ExecuteSqlQuery(con, cmdText);
                cmdText = "Delete from imprumut";
                ExecuteSqlQuery(con, cmdText);
            }
        }

        private static void ExecuteSqlQuery(SqlConnection con, string cmdText)
        {
            using (SqlCommand cmd = new SqlCommand(cmdText, con))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Configuration;
using System.Globalization;
//using FreeBook.Models;

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

        private static void InserareCarti(SqlConnection con)
        {
            string cmdText = "Insert into carti (titlu, autor, gen) values (@titlu, @autor, @gen);";
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
                cmdText = "Delete from imprumuturi";
                ExecuteSqlQuery(con, cmdText);
            }
        }

        private static void ExecuteSqlQuery(SqlConnection con, string cmdText)
        {
            using (SqlCommand cmd = new SqlCommand(_connectionString))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}
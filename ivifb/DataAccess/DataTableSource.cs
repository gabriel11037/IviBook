using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using FreeBook;
using FreeBook.Models;

namespace ivifb.DataAccess
{
    class DataTableSource
    {
        private static readonly string _connectionString = SqlDataAccess.GetConnectionStrings();
        private static List<BookModel> cartiImprumutate;
        public static DataTable GetBooksInTable()
        {
            DataTable imprumuturiDataTable = new DataTable();
            imprumuturiDataTable.Columns.Add("Id_Carte");
            imprumuturiDataTable.Columns.Add("Titlu");
            imprumuturiDataTable.Columns.Add("Autor");
            imprumuturiDataTable.Columns.Add("Gen");

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                string cmdText = "Select * from carti;";
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(imprumuturiDataTable);
                    }
                }
            }
            return imprumuturiDataTable;
        }

        public static DataTable GetAllTakenBooksInTable(UserModel utilizator)
        {
            cartiImprumutate = DatabaseHelper.GetTakenBooks(utilizator);
            cartiImprumutate = cartiImprumutate.OrderByDescending(x => x.DataImprumut).ToList();

            DataTable takenBooksDataTable = new DataTable();
            takenBooksDataTable.Columns.Add("Index");
            takenBooksDataTable.Columns.Add("Titlu");
            takenBooksDataTable.Columns.Add("Autor");
            takenBooksDataTable.Columns.Add("Data_Imprumut");
            takenBooksDataTable.Columns.Add("Data_Expirare");
            takenBooksDataTable.Columns.Add("Expirat");

            for(int i=1; i<=cartiImprumutate.Count; i++)
            {
                DataRow newRow = takenBooksDataTable.NewRow();
                int index = i + 1;
                newRow[0] = index;
                newRow[1] = cartiImprumutate[i].Titlu;
                newRow[2] = cartiImprumutate[i].Autor;
                newRow[3] = cartiImprumutate[i].DataImprumut;
                newRow[4] = cartiImprumutate[i].DataExpirare;
                newRow[5] = cartiImprumutate[i].Expirat;
                takenBooksDataTable.Rows.Add(newRow);
            }
            return takenBooksDataTable;
        }
    }
}
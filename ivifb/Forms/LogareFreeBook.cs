﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FreeBook;
using FreeBook.Models;

namespace ivifb.Forms
{
    public partial class LogareFreeBook : Form
    {
        public LogareFreeBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserModel utilizator = DatabaseHelper.IsRegistered(emailLogin.Text);

            if (utilizator.Parola == parolaLogin.Text)
            {
                this.Close();
                this.Visible = false;
                var page = new MeniuFreeBook()
                {
                    Utilizator = utilizator
                };
                page.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Eroare autentificare");
            }
        }
    }
}

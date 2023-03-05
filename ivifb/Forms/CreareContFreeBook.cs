using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FreeBook.Models;
using FreeBook;

namespace ivifb.Forms
{
    public partial class CreareContFreeBook : Form
    {
        public CreareContFreeBook()
        {
            InitializeComponent();
        }

        private void inregCreate_Click(object sender, EventArgs e)
        {

        }

        private void InregCreate_Click_1(object sender, EventArgs e)
        {
            if(numeCreate.Text != null && prenumeCreate != null && emailCreate != null && passCreate != null)
            {
                if (passCreate.Text == conpassCreate.Text)
                {
                    UserModel utilizator = new UserModel
                    {
                        Email = emailCreate.Text,
                        Nume = numeCreate.Text,
                        Parola = passCreate.Text,
                        Prenume = prenumeCreate.Text,
                    };
                    try
                    {
                        DatabaseHelper.UserRegistration(utilizator);
                        utilizator = DatabaseHelper.IsRegistered(emailCreate.Text);
                        if (utilizator.Email == emailCreate.Text)
                        {
                            MessageBox.Show("Utilizatorul a fost inregistrat cu succes!");
                        }
                        this.Close();
                        this.Visible = false;
                        var page = new MeniuFreeBook()
                        {
                            Utilizator = utilizator
                        };
                        page.ShowDialog(this);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("A aparut o eroare la inregistrare: " + exc.Message);
                    }
                }
            }

            else
            {
                MessageBox.Show("Introduce toate credientialele!");
            }
        }
    }
}

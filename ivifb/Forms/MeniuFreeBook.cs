using System;
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
using ivifb.DataAccess;
using ivifb.Forms;

namespace ivifb.Forms
{
    public partial class MeniuFreeBook : Form
    {
        public UserModel Utilizator { get; set; }
        public MeniuFreeBook()
        {
            InitializeComponent();
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;

            dataGridView1.CellContentClick += new DataGridViewCellEventHandler(DataGridView1_CellContentClick);

            dataGridView2.CellContentClick += new DataGridViewCellEventHandler(DataGridView2_CellContentClick);
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

            SetCartiImprumutateProgressBar();
        }

        private void SetCartiImprumutateProgressBar()
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 3;
            progressBar1.Value = 3;
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            ShowCarti carte = new ShowCarti();
            carte.showTitluLbl.Text = this.dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            carte.showAutorLbl.Text = this.dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            carte.showIndexLbl.Text = this.dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            carte.ShowDialog();
            this.Show();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            if(dataGridView.Columns[e.RowIndex] is DataGridViewColumn)
            {
                if(DatabaseHelper.NrCartiImprumutate(Utilizator) < 3)
                {
                    int IdCarte = Int32.Parse((string)dataGridView.Rows[e.RowIndex].Cells["Id_Carte"].Value);
                    int Verifier = DatabaseHelper.ImprumutaCarte(IdCarte, Utilizator);
                    if (Verifier != 0)
                        MessageBox.Show("Utilizatorul " + Utilizator.Nume + " a imprumutat deja aceasta carte!");
                    dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen; 
                }else
                    {
                    MessageBox.Show("Ai imprumutat deja 3 carti!");
                    }
                
            }
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    {
                        break;
                    }

                case 1:
                    {
                        dataGridView2.DataSource = DataTableSource.GetAllTakenBooksInTable(Utilizator);
                        dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        for(int i=0; i<=dataGridView2.Rows.Count-1; i++)
                        {
                            if (bool.Parse((string)dataGridView2.Rows[i].Cells[5].Value))
                            {
                                dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                                progressBar1.Value--;
                            }
                            else
                            {
                                dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.IndianRed;
                                progressBar1.Value--;
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        break;
                    }
            }
        }

        private void LoadBooks()
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

            dataGridView1.DataSource = DataTableSource.GetBooksInTable();
            dataGridView1.Columns[0].Visible = false;

            DataGridViewButtonColumn loanBook = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(loanBook);
            loanBook.HeaderText = "Status Carte";
            loanBook.Name = "btn";
            loanBook.UseColumnTextForButtonValue = true;
        }

        private void MeniuFreeBook_Load(object sender, EventArgs e)
        {

            // cartiDisponibileTabPage este incarcat automat deoarece el este primul
            // mai jos -> incarcare explicita a TabPage-ului
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
            LoadBooks();
            
            emailSHOW.Text = Utilizator.Email;
        }
    }
}

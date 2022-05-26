using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using carte;
using bazadedatetxt;

namespace interfata
{
    public partial class Form1 : Form
    {
        Admin_books b;
        public Carte carte;
        public List<Carte> carti;
        public Form1()
        {
            b = new Admin_books("fisier.txt");
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.biblio1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carti = b.getbooks();
            afisarecarti(carti);
        }

        public void afisarecarti(List<Carte> carti)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = carti;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                label4.Text= row.Cells["idcarte"].Value.ToString();
                string aux=row.Cells["idcarte"].Value.ToString();
                int index = Int32.Parse(aux);
                carte = b.GetCarte(index);
            }      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adaugare_carte adauga = new adaugare_carte();
            adauga.Show();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (carte == null)
            {
                MessageBox.Show("nu este nici o carte selectata");
            }
            else
            {
                b.removecarte(carte);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(carte==null)
            {
                MessageBox.Show("Nu este selecatata nici o carte");
            }
            else
            {
                using (editbook edit=new editbook(carte))
                {
                    var dr = edit.ShowDialog(this);
                    if (dr == DialogResult.OK)
                    {
                        b.updateCarte(carte);
                        carti = b.getbooks();
                        afisarecarti(carti);
                    }
                   
                    edit.Close();
                }
               
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void baradecautare_TextChanged(object sender, EventArgs e)
        {
            List<Carte> aux=new List<Carte>();
            if(baradecautare.Text!=string.Empty)
            {
                foreach (Carte c in b.getbooks())
                {
                    if(numecarte.Checked)
                    {
                        if (c.nume.Contains(baradecautare.Text))
                        {
                            aux.Add(c);
                        }
                    }
                    else if(autorcarte.Checked)
                    {
                        if(c.autor.Contains(baradecautare.Text))
                        {
                            aux.Add(c);
                        }
                    }
                    else if(edituracarte.Checked)
                    {
                        if(c.editura.Contains(baradecautare.Text))
                        {
                            aux.Add(c);
                        }
                    }
                    

                }
                if(aux==null)
                {
                    Console.WriteLine("nu este");
                }
                afisarecarti(aux);
            }
            else
            {
                afisarecarti(carti);
            }
            
           
        }

        private void numecarte_CheckedChanged(object sender, EventArgs e)
        {
            if(numecarte.Checked)
            {
                baradecautare.Text = string.Empty;
            }
        }

        private void autorcarte_CheckedChanged(object sender, EventArgs e)
        {
            if (autorcarte.Checked)
            {
                baradecautare.Text = string.Empty;
            }
        }

        private void edituracarte_CheckedChanged(object sender, EventArgs e)
        {
            if (edituracarte.Checked)
            {
                baradecautare.Text = string.Empty;
            }
        }
    }
}

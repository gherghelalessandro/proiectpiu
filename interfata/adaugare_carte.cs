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
    public partial class adaugare_carte : Form
    {
        Admin_books b =new Admin_books("fisier.txt");
        public adaugare_carte()
        {
            InitializeComponent();
        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {
            Carte c = new Carte();
            c.nume = textBox1.Text;
            c.autor = textBox2.Text;
            c.editura = textBox3.Text;
            if (Int32.TryParse(textBox4.Text, out int result) == false)
            {
                MessageBox.Show("Nr gresit");
            }
            else
            {
                c.nr = int.Parse(textBox4.Text);
            }
            if (c.nume != string.Empty && c.autor != string.Empty && c.editura != string.Empty)
            {
                b.addcarte(c);
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Date incomplete");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using biblioteca;
using carte;

namespace proba2
{
    public partial class Form2 : Form
    {
        bool un = false;
        Biblioteca biblioteca,biblioteca1;
        Carte c;
        public Form2()
        {
            biblioteca = new Biblioteca(@"C:\\Users\\Kryss\\source\repos\\proba1\\proba1\\bin\\Debug\\proba.txt");
            c = new Carte();
            biblioteca1 = new Biblioteca();
            InitializeComponent();
             
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            biblioteca1.add_carte(c);
            biblioteca.addbooks_tofile(biblioteca1);
            
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            c.nume = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            c.autor = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            c.editura = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int var;
            if(int.TryParse(textBox4.Text,out var))
            {
                c.nr = int.Parse(textBox4.Text);
            }
            textBox4.ForeColor = Color.Red;
            
        }
    }
}

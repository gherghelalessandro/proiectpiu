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

namespace interfata
{
    public partial class editbook : Form
    {
        Carte c;
        public editbook()
        {
            InitializeComponent();
        }

        public editbook(Carte carte):this()
        {
            c = carte;
            textBox1.Text = c.nume;
            textBox2.Text = c.autor;
            textBox3.Text = c.editura;
            textBox4.Text = c.nr.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.nume = textBox1.Text;
            c.autor = textBox2.Text;
            c.editura = textBox3.Text;
            if(int.TryParse(textBox4.Text,out int result)==true)
            {
                c.nr = Int32.Parse(textBox4.Text);
            }
            else
            {
                MessageBox.Show("nr incorect");
            }
            DialogResult =DialogResult.OK;

          
        }
    }
}

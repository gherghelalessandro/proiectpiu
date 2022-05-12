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
using user;

namespace proba2
{
    public partial class Form1 : Form
    {
        
        int latime = 170;
        int sizey = 30;
        int sizex = 170;
        int offsetx = 150;
        Label[] numecarte;
        Label[] numeautor;
        Label[] numeeditura;
        Label[] nrdeexemplare;
        Label titlu1,nume,autor,editura,nr;
        Biblioteca b ;
        Carte c;
        int index = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            numecarte = new Label[20];
            numeautor = new Label[20];
            numeeditura = new Label[20];
            nrdeexemplare = new Label[20];

            c = new Carte();

            titlu1 = new Label();
            nume = new Label();
            autor = new Label();
            editura = new Label();
            nr = new Label();

           
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.LimeGreen;
            this.Text = "Biblioteca";
            this.BackColor = Color.AliceBlue;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            c.nume = textBox3.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            afiseaza(textBox3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void afiseaza(string numecarte1)
        {
           
            b = new Biblioteca(@"C:\\Users\\Kryss\\source\repos\\proba1\\proba1\\bin\\Debug\\proba.txt");
            index = 0;

            nume.Text = "CARTEA";
            autor.Text = "AUTOR";
            editura.Text = "EDITURA";
            nr.Text = "EXEMPLARE";

            nume.Width = latime;
            autor.Width = latime;
            editura.Width = latime;
            nr.Width = latime;

            nume.Top = sizey;
            autor.Top = sizey;
            editura.Top = sizey;
            nr.Top = sizey;

            nume.Left = offsetx;
            autor.Left = offsetx + sizex;
            editura.Left = offsetx + sizex * 2;
            nr.Left = offsetx + sizex * 3;

            textBox3.Visible = true;
            button3.Visible = true;
            button2.Visible = true;
            button4.Visible = true;
            label4.Visible = true;


            this.Controls.Add(nume);
            this.Controls.Add(autor);
            this.Controls.Add(editura);
            this.Controls.Add(nr);



            if(numecarte1==string.Empty)
            {
                foreach (Carte c in b.c1)
                {

                    numecarte[index] = new Label();
                    numeautor[index] = new Label();
                    numeeditura[index] = new Label();
                    nrdeexemplare[index] = new Label();

                    numecarte[index].Text = c.nume;
                    numeautor[index].Text = c.autor;
                    numeeditura[index].Text = c.editura;
                    nrdeexemplare[index].Text = Convert.ToString(c.nr);

                    numecarte[index].Width = latime;
                    numeautor[index].Width = latime;
                    numeeditura[index].Width = latime;
                    nrdeexemplare[index].Width = latime;

                    numecarte[index].Left = offsetx;
                    numeautor[index].Left = offsetx + sizex;
                    numeeditura[index].Left = offsetx + sizex * 2;
                    nrdeexemplare[index].Left = offsetx + sizex * 3;

                    numecarte[index].Top += sizey * (index + 2);
                    numeautor[index].Top += sizey * (index + 2);
                    numeeditura[index].Top += sizey * (index + 2);
                    nrdeexemplare[index].Top += sizey * (index + 2);

                    this.Controls.Add(numecarte[index]);
                    this.Controls.Add(numeautor[index]);
                    this.Controls.Add(numeeditura[index]);
                    this.Controls.Add(nrdeexemplare[index]);

                    index++;

                }
                
            }
            else
            {
                foreach (Carte c in b.c1)
                {

                    if(c.nume==numecarte1)
                    {
                        numecarte[index] = new Label();
                        numeautor[index] = new Label();
                        numeeditura[index] = new Label();
                        nrdeexemplare[index] = new Label();

                        numecarte[index].Text = c.nume;
                        numeautor[index].Text = c.autor;
                        numeeditura[index].Text = c.editura;
                        nrdeexemplare[index].Text = Convert.ToString(c.nr);

                        numecarte[index].Width = latime;
                        numeautor[index].Width = latime;
                        numeeditura[index].Width = latime;
                        nrdeexemplare[index].Width = latime;

                        numecarte[index].Left = offsetx;
                        numeautor[index].Left = offsetx + sizex;
                        numeeditura[index].Left = offsetx + sizex * 2;
                        nrdeexemplare[index].Left = offsetx + sizex * 3;

                        numecarte[index].Top += sizey * (index + 2);
                        numeautor[index].Top += sizey * (index + 2);
                        numeeditura[index].Top += sizey * (index + 2);
                        nrdeexemplare[index].Top += sizey * (index + 2);

                        this.Controls.Add(numecarte[index]);
                        this.Controls.Add(numeautor[index]);
                        this.Controls.Add(numeeditura[index]);
                        this.Controls.Add(nrdeexemplare[index]);
                        index++;
                    }
                    

                    

                }
            }
            if (index > 10)
            {
                vScrollBar1.Visible = true;
            }
        }

       
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            button1.Visible = false;
           
            afiseaza("");

        }
    }
    public partial class Form2:Form
    {
        Form1 f = new Form1();

    }
}

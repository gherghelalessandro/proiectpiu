
namespace interfata
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.afisare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adauga = new System.Windows.Forms.Button();
            this.elimina = new System.Windows.Forms.Button();
            this.editare = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.baradecautare = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchbar = new System.Windows.Forms.Label();
            this.numecarte = new System.Windows.Forms.RadioButton();
            this.autorcarte = new System.Windows.Forms.RadioButton();
            this.edituracarte = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(305, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 339);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // afisare
            // 
            this.afisare.BackColor = System.Drawing.Color.Transparent;
            this.afisare.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.afisare.Location = new System.Drawing.Point(183, 331);
            this.afisare.Name = "afisare";
            this.afisare.Size = new System.Drawing.Size(75, 23);
            this.afisare.TabIndex = 1;
            this.afisare.Text = "afiseaza";
            this.afisare.UseVisualStyleBackColor = false;
            this.afisare.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(95, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Optiuni Carte";
            // 
            // adauga
            // 
            this.adauga.BackColor = System.Drawing.Color.Transparent;
            this.adauga.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.adauga.Location = new System.Drawing.Point(48, 270);
            this.adauga.Name = "adauga";
            this.adauga.Size = new System.Drawing.Size(75, 23);
            this.adauga.TabIndex = 3;
            this.adauga.Text = "Adauga ";
            this.adauga.UseVisualStyleBackColor = false;
            this.adauga.Click += new System.EventHandler(this.button2_Click);
            // 
            // elimina
            // 
            this.elimina.BackColor = System.Drawing.Color.Transparent;
            this.elimina.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.elimina.Location = new System.Drawing.Point(183, 270);
            this.elimina.Name = "elimina";
            this.elimina.Size = new System.Drawing.Size(75, 23);
            this.elimina.TabIndex = 4;
            this.elimina.Text = "Elimina";
            this.elimina.UseVisualStyleBackColor = false;
            this.elimina.Click += new System.EventHandler(this.button3_Click);
            // 
            // editare
            // 
            this.editare.BackColor = System.Drawing.Color.Transparent;
            this.editare.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editare.Location = new System.Drawing.Point(48, 331);
            this.editare.Name = "editare";
            this.editare.Size = new System.Drawing.Size(75, 23);
            this.editare.TabIndex = 5;
            this.editare.Text = "Editeaza";
            this.editare.UseVisualStyleBackColor = false;
            this.editare.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(67, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Biblioteca";
            // 
            // baradecautare
            // 
            this.baradecautare.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.baradecautare.Location = new System.Drawing.Point(23, 114);
            this.baradecautare.Name = "baradecautare";
            this.baradecautare.Size = new System.Drawing.Size(100, 20);
            this.baradecautare.TabIndex = 7;
            this.baradecautare.TextChanged += new System.EventHandler(this.baradecautare_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(302, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "index";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(340, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "index";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // searchbar
            // 
            this.searchbar.AutoSize = true;
            this.searchbar.BackColor = System.Drawing.Color.Transparent;
            this.searchbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbar.ForeColor = System.Drawing.Color.Transparent;
            this.searchbar.Location = new System.Drawing.Point(19, 68);
            this.searchbar.Name = "searchbar";
            this.searchbar.Size = new System.Drawing.Size(94, 24);
            this.searchbar.TabIndex = 10;
            this.searchbar.Text = "searchbar";
            // 
            // numecarte
            // 
            this.numecarte.AutoSize = true;
            this.numecarte.Location = new System.Drawing.Point(23, 156);
            this.numecarte.Name = "numecarte";
            this.numecarte.Size = new System.Drawing.Size(53, 17);
            this.numecarte.TabIndex = 11;
            this.numecarte.TabStop = true;
            this.numecarte.Text = "Nume";
            this.numecarte.UseVisualStyleBackColor = true;
            this.numecarte.CheckedChanged += new System.EventHandler(this.numecarte_CheckedChanged);
            // 
            // autorcarte
            // 
            this.autorcarte.AutoSize = true;
            this.autorcarte.Location = new System.Drawing.Point(114, 156);
            this.autorcarte.Name = "autorcarte";
            this.autorcarte.Size = new System.Drawing.Size(49, 17);
            this.autorcarte.TabIndex = 12;
            this.autorcarte.TabStop = true;
            this.autorcarte.Text = "autor";
            this.autorcarte.UseVisualStyleBackColor = true;
            this.autorcarte.CheckedChanged += new System.EventHandler(this.autorcarte_CheckedChanged);
            // 
            // edituracarte
            // 
            this.edituracarte.AutoSize = true;
            this.edituracarte.Location = new System.Drawing.Point(205, 156);
            this.edituracarte.Name = "edituracarte";
            this.edituracarte.Size = new System.Drawing.Size(58, 17);
            this.edituracarte.TabIndex = 13;
            this.edituracarte.TabStop = true;
            this.edituracarte.Text = "Editura";
            this.edituracarte.UseVisualStyleBackColor = true;
            this.edituracarte.CheckedChanged += new System.EventHandler(this.edituracarte_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 446);
            this.Controls.Add(this.edituracarte);
            this.Controls.Add(this.autorcarte);
            this.Controls.Add(this.numecarte);
            this.Controls.Add(this.searchbar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.baradecautare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editare);
            this.Controls.Add(this.elimina);
            this.Controls.Add(this.adauga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.afisare);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button afisare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adauga;
        private System.Windows.Forms.Button elimina;
        private System.Windows.Forms.Button editare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox baradecautare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label searchbar;
        private System.Windows.Forms.RadioButton numecarte;
        private System.Windows.Forms.RadioButton autorcarte;
        private System.Windows.Forms.RadioButton edituracarte;
    }
}


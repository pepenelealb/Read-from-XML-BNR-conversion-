﻿namespace Aplicatie_Curs_Valutar
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
            this.cmb_alege_valuta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_afiseaza_rata_conv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_date = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_year = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.valideazaXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_alege_valuta
            // 
            this.cmb_alege_valuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_alege_valuta.FormattingEnabled = true;
            this.cmb_alege_valuta.Location = new System.Drawing.Point(132, 166);
            this.cmb_alege_valuta.Name = "cmb_alege_valuta";
            this.cmb_alege_valuta.Size = new System.Drawing.Size(200, 21);
            this.cmb_alege_valuta.TabIndex = 0;
            this.cmb_alege_valuta.DropDown += new System.EventHandler(this.cmb_alege_valuta_DropDown);
            this.cmb_alege_valuta.SelectedIndexChanged += new System.EventHandler(this.cmb_alege_valuta_SelectedIndexChanged);
            this.cmb_alege_valuta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_alege_valuta_MouseClick);
            this.cmb_alege_valuta.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cmb_alege_valuta_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alege data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alege Valuta";
            // 
            // txt_afiseaza_rata_conv
            // 
            this.txt_afiseaza_rata_conv.BackColor = System.Drawing.Color.GhostWhite;
            this.txt_afiseaza_rata_conv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_afiseaza_rata_conv.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_afiseaza_rata_conv.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_afiseaza_rata_conv.Location = new System.Drawing.Point(181, 213);
            this.txt_afiseaza_rata_conv.Name = "txt_afiseaza_rata_conv";
            this.txt_afiseaza_rata_conv.ReadOnly = true;
            this.txt_afiseaza_rata_conv.Size = new System.Drawing.Size(100, 18);
            this.txt_afiseaza_rata_conv.TabIndex = 6;
            this.txt_afiseaza_rata_conv.Tag = "";
            this.txt_afiseaza_rata_conv.Text = "RON";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rata Conversie";
            // 
            // cmb_date
            // 
            this.cmb_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_date.FormattingEnabled = true;
            this.cmb_date.Location = new System.Drawing.Point(132, 131);
            this.cmb_date.Name = "cmb_date";
            this.cmb_date.Size = new System.Drawing.Size(200, 21);
            this.cmb_date.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 40);
            this.label4.TabIndex = 10;
            this.label4.Text = "Conversie BNR";
            // 
            // cmb_year
            // 
            this.cmb_year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_year.FormattingEnabled = true;
            this.cmb_year.Location = new System.Drawing.Point(132, 87);
            this.cmb_year.Name = "cmb_year";
            this.cmb_year.Size = new System.Drawing.Size(200, 21);
            this.cmb_year.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Alege anul";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(221, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "RON";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valideazaXMLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // valideazaXMLToolStripMenuItem
            // 
            this.valideazaXMLToolStripMenuItem.Name = "valideazaXMLToolStripMenuItem";
            this.valideazaXMLToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.valideazaXMLToolStripMenuItem.Text = "Valideaza XML";
            this.valideazaXMLToolStripMenuItem.Click += new System.EventHandler(this.valideazaXMLToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(384, 244);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_year);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_afiseaza_rata_conv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_alege_valuta);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "prin Citire XML de la BNR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_alege_valuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_afiseaza_rata_conv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_year;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem valideazaXMLToolStripMenuItem;
    }
}


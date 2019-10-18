namespace Aplicatie_Curs_Valutar
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
            this.SuspendLayout();
            // 
            // cmb_alege_valuta
            // 
            this.cmb_alege_valuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_alege_valuta.FormattingEnabled = true;
            this.cmb_alege_valuta.Location = new System.Drawing.Point(141, 122);
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
            this.label1.Location = new System.Drawing.Point(61, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alege data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 121);
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
            this.txt_afiseaza_rata_conv.Location = new System.Drawing.Point(190, 169);
            this.txt_afiseaza_rata_conv.Name = "txt_afiseaza_rata_conv";
            this.txt_afiseaza_rata_conv.ReadOnly = true;
            this.txt_afiseaza_rata_conv.Size = new System.Drawing.Size(100, 18);
            this.txt_afiseaza_rata_conv.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rata Conversie";
            // 
            // cmb_date
            // 
            this.cmb_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_date.FormattingEnabled = true;
            this.cmb_date.Location = new System.Drawing.Point(141, 87);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(364, 199);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_afiseaza_rata_conv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_alege_valuta);
            this.Name = "Form1";
            this.Text = "prin Citire XML de la BNR";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}


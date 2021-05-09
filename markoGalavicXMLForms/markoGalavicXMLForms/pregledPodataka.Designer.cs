namespace markoGalavicXMLForms
{
    partial class pregledPodataka
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
            this.buttonUcitajDokument = new System.Windows.Forms.Button();
            this.buttonFiltriraj2 = new System.Windows.Forms.Button();
            this.buttonOdustani2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonUcitajDokument
            // 
            this.buttonUcitajDokument.Location = new System.Drawing.Point(53, 29);
            this.buttonUcitajDokument.Name = "buttonUcitajDokument";
            this.buttonUcitajDokument.Size = new System.Drawing.Size(104, 32);
            this.buttonUcitajDokument.TabIndex = 0;
            this.buttonUcitajDokument.Text = "Učitaj dokument";
            this.buttonUcitajDokument.UseVisualStyleBackColor = true;
            this.buttonUcitajDokument.Click += new System.EventHandler(this.buttonUcitajDokument_Click);
            // 
            // buttonFiltriraj2
            // 
            this.buttonFiltriraj2.Location = new System.Drawing.Point(163, 29);
            this.buttonFiltriraj2.Name = "buttonFiltriraj2";
            this.buttonFiltriraj2.Size = new System.Drawing.Size(107, 32);
            this.buttonFiltriraj2.TabIndex = 1;
            this.buttonFiltriraj2.Text = "Filtriraj";
            this.buttonFiltriraj2.UseVisualStyleBackColor = true;
            this.buttonFiltriraj2.Click += new System.EventHandler(this.buttonFiltriraj2_Click);
            // 
            // buttonOdustani2
            // 
            this.buttonOdustani2.Location = new System.Drawing.Point(276, 29);
            this.buttonOdustani2.Name = "buttonOdustani2";
            this.buttonOdustani2.Size = new System.Drawing.Size(99, 32);
            this.buttonOdustani2.TabIndex = 2;
            this.buttonOdustani2.Text = "Odustani";
            this.buttonOdustani2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(53, 99);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(343, 308);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // cetvrtaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonOdustani2);
            this.Controls.Add(this.buttonFiltriraj2);
            this.Controls.Add(this.buttonUcitajDokument);
            this.Name = "cetvrtaForma";
            this.Text = "Pregled podataka";
            this.Load += new System.EventHandler(this.cetvrtaForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUcitajDokument;
        private System.Windows.Forms.Button buttonFiltriraj2;
        private System.Windows.Forms.Button buttonOdustani2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
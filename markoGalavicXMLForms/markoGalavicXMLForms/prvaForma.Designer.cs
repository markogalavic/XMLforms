namespace markoGalavicXMLForms
{
    partial class pocetnaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pocetnaForma));
            this.buttonUnos1 = new System.Windows.Forms.Button();
            this.buttonPrikaz1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUnos1
            // 
            this.buttonUnos1.Location = new System.Drawing.Point(140, 246);
            this.buttonUnos1.Name = "buttonUnos1";
            this.buttonUnos1.Size = new System.Drawing.Size(104, 33);
            this.buttonUnos1.TabIndex = 0;
            this.buttonUnos1.Text = "Unos";
            this.buttonUnos1.UseVisualStyleBackColor = true;
            this.buttonUnos1.Click += new System.EventHandler(this.buttonUnos1_Click);
            // 
            // buttonPrikaz1
            // 
            this.buttonPrikaz1.Location = new System.Drawing.Point(140, 307);
            this.buttonPrikaz1.Name = "buttonPrikaz1";
            this.buttonPrikaz1.Size = new System.Drawing.Size(104, 36);
            this.buttonPrikaz1.TabIndex = 1;
            this.buttonPrikaz1.Text = "Prikaz";
            this.buttonPrikaz1.UseVisualStyleBackColor = true;
            this.buttonPrikaz1.Click += new System.EventHandler(this.buttonPrikaz1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(96, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 195);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonPrikaz1);
            this.Controls.Add(this.buttonUnos1);
            this.Name = "pocetnaForma";
            this.Text = "XML Transformer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUnos1;
        private System.Windows.Forms.Button buttonPrikaz1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


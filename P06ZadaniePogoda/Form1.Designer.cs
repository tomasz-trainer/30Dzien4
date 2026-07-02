namespace P06ZadaniePogoda
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
            this.cbMiasta = new System.Windows.Forms.ComboBox();
            this.btnPodajTemperature = new System.Windows.Forms.Button();
            this.lblRaport = new System.Windows.Forms.Label();
            this.pbPogoda = new System.Windows.Forms.PictureBox();
            this.rbKelvin = new System.Windows.Forms.RadioButton();
            this.rbFrenheit = new System.Windows.Forms.RadioButton();
            this.rbCelsjusz = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPogoda)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMiasta
            // 
            this.cbMiasta.FormattingEnabled = true;
            this.cbMiasta.Location = new System.Drawing.Point(12, 27);
            this.cbMiasta.Name = "cbMiasta";
            this.cbMiasta.Size = new System.Drawing.Size(127, 21);
            this.cbMiasta.TabIndex = 2;
            // 
            // btnPodajTemperature
            // 
            this.btnPodajTemperature.Location = new System.Drawing.Point(12, 54);
            this.btnPodajTemperature.Name = "btnPodajTemperature";
            this.btnPodajTemperature.Size = new System.Drawing.Size(127, 40);
            this.btnPodajTemperature.TabIndex = 3;
            this.btnPodajTemperature.Text = "Podaj temperature";
            this.btnPodajTemperature.UseVisualStyleBackColor = true;
            this.btnPodajTemperature.Click += new System.EventHandler(this.btnPodajTemperature_Click);
            // 
            // lblRaport
            // 
            this.lblRaport.Location = new System.Drawing.Point(12, 108);
            this.lblRaport.Name = "lblRaport";
            this.lblRaport.Size = new System.Drawing.Size(127, 84);
            this.lblRaport.TabIndex = 6;
            this.lblRaport.Text = "label1";
            // 
            // pbPogoda
            // 
            this.pbPogoda.Image = global::P06ZadaniePogoda.Properties.Resources.rain;
            this.pbPogoda.Location = new System.Drawing.Point(145, 27);
            this.pbPogoda.Name = "pbPogoda";
            this.pbPogoda.Size = new System.Drawing.Size(135, 129);
            this.pbPogoda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPogoda.TabIndex = 7;
            this.pbPogoda.TabStop = false;
            // 
            // rbKelvin
            // 
            this.rbKelvin.AutoSize = true;
            this.rbKelvin.Location = new System.Drawing.Point(295, 113);
            this.rbKelvin.Name = "rbKelvin";
            this.rbKelvin.Size = new System.Drawing.Size(54, 17);
            this.rbKelvin.TabIndex = 10;
            this.rbKelvin.Text = "Kelvin";
            this.rbKelvin.UseVisualStyleBackColor = true;
            // 
            // rbFrenheit
            // 
            this.rbFrenheit.AutoSize = true;
            this.rbFrenheit.Location = new System.Drawing.Point(295, 90);
            this.rbFrenheit.Name = "rbFrenheit";
            this.rbFrenheit.Size = new System.Drawing.Size(69, 17);
            this.rbFrenheit.TabIndex = 9;
            this.rbFrenheit.Text = "Farenheit";
            this.rbFrenheit.UseVisualStyleBackColor = true;
            // 
            // rbCelsjusz
            // 
            this.rbCelsjusz.AutoSize = true;
            this.rbCelsjusz.Checked = true;
            this.rbCelsjusz.Location = new System.Drawing.Point(296, 67);
            this.rbCelsjusz.Name = "rbCelsjusz";
            this.rbCelsjusz.Size = new System.Drawing.Size(63, 17);
            this.rbCelsjusz.TabIndex = 8;
            this.rbCelsjusz.TabStop = true;
            this.rbCelsjusz.Text = "Celsjusz";
            this.rbCelsjusz.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Jednostka";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 201);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbKelvin);
            this.Controls.Add(this.rbFrenheit);
            this.Controls.Add(this.rbCelsjusz);
            this.Controls.Add(this.pbPogoda);
            this.Controls.Add(this.lblRaport);
            this.Controls.Add(this.btnPodajTemperature);
            this.Controls.Add(this.cbMiasta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbPogoda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMiasta;
        private System.Windows.Forms.Button btnPodajTemperature;
        private System.Windows.Forms.Label lblRaport;
        private System.Windows.Forms.PictureBox pbPogoda;
        private System.Windows.Forms.RadioButton rbKelvin;
        private System.Windows.Forms.RadioButton rbFrenheit;
        private System.Windows.Forms.RadioButton rbCelsjusz;
        private System.Windows.Forms.Label label1;
    }
}


namespace P08ZadanieFiltrowanieDanych
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
            this.lbDane = new System.Windows.Forms.ListBox();
            this.cbKraje = new System.Windows.Forms.ComboBox();
            this.lblRaport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDane
            // 
            this.lbDane.FormattingEnabled = true;
            this.lbDane.Location = new System.Drawing.Point(12, 52);
            this.lbDane.Name = "lbDane";
            this.lbDane.Size = new System.Drawing.Size(243, 238);
            this.lbDane.TabIndex = 1;
            // 
            // cbKraje
            // 
            this.cbKraje.FormattingEnabled = true;
            this.cbKraje.Location = new System.Drawing.Point(14, 25);
            this.cbKraje.Name = "cbKraje";
            this.cbKraje.Size = new System.Drawing.Size(241, 21);
            this.cbKraje.TabIndex = 2;
            this.cbKraje.SelectedIndexChanged += new System.EventHandler(this.cbKraje_SelectedIndexChanged);
            // 
            // lblRaport
            // 
            this.lblRaport.AutoSize = true;
            this.lblRaport.Location = new System.Drawing.Point(12, 305);
            this.lblRaport.Name = "lblRaport";
            this.lblRaport.Size = new System.Drawing.Size(35, 13);
            this.lblRaport.TabIndex = 4;
            this.lblRaport.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 337);
            this.Controls.Add(this.lblRaport);
            this.Controls.Add(this.cbKraje);
            this.Controls.Add(this.lbDane);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDane;
        private System.Windows.Forms.ComboBox cbKraje;
        private System.Windows.Forms.Label lblRaport;
    }
}


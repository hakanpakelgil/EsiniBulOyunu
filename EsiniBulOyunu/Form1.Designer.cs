namespace EsiniBulOyunu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlKartlar = new Panel();
            SuspendLayout();
            // 
            // pnlKartlar
            // 
            pnlKartlar.BackColor = Color.Yellow;
            pnlKartlar.Location = new Point(17, 12);
            pnlKartlar.Name = "pnlKartlar";
            pnlKartlar.Size = new Size(600, 600);
            pnlKartlar.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(633, 638);
            Controls.Add(pnlKartlar);
            ForeColor = Color.Yellow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eşini Bul";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlKartlar;
    }
}
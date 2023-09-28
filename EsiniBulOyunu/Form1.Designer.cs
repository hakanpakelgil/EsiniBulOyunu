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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlKartlar = new Panel();
            groupBox1 = new GroupBox();
            button1 = new Button();
            rb5 = new RadioButton();
            radioButton4 = new RadioButton();
            rb3 = new RadioButton();
            rb2 = new RadioButton();
            rb1 = new RadioButton();
            menuStrip1 = new MenuStrip();
            oyunToolStripMenuItem = new ToolStripMenuItem();
            btnYeniOyun = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlKartlar
            // 
            pnlKartlar.Anchor = AnchorStyles.None;
            pnlKartlar.BackColor = Color.Transparent;
            pnlKartlar.Location = new Point(92, 70);
            pnlKartlar.Name = "pnlKartlar";
            pnlKartlar.Size = new Size(680, 602);
            pnlKartlar.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(rb5);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(rb3);
            groupBox1.Controls.Add(rb2);
            groupBox1.Controls.Add(rb1);
            groupBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(145, 119);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(582, 488);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Oyun";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(186, 354);
            button1.Name = "button1";
            button1.Size = new Size(202, 52);
            button1.TabIndex = 1;
            button1.Text = "Oyunu Başlat";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // rb5
            // 
            rb5.AutoSize = true;
            rb5.BackColor = Color.Transparent;
            rb5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rb5.ForeColor = Color.Black;
            rb5.Location = new Point(225, 287);
            rb5.Name = "rb5";
            rb5.Size = new Size(116, 36);
            rb5.TabIndex = 0;
            rb5.Text = "Çok Zor";
            rb5.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.BackColor = Color.Transparent;
            radioButton4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton4.ForeColor = Color.Black;
            radioButton4.Location = new Point(225, 245);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(68, 36);
            radioButton4.TabIndex = 0;
            radioButton4.Text = "Zor";
            radioButton4.UseVisualStyleBackColor = false;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.BackColor = Color.Transparent;
            rb3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rb3.ForeColor = Color.Black;
            rb3.Location = new Point(225, 203);
            rb3.Name = "rb3";
            rb3.Size = new Size(78, 36);
            rb3.TabIndex = 0;
            rb3.Text = "Orta";
            rb3.UseVisualStyleBackColor = false;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.BackColor = Color.Transparent;
            rb2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rb2.ForeColor = Color.Black;
            rb2.Location = new Point(225, 161);
            rb2.Name = "rb2";
            rb2.Size = new Size(89, 36);
            rb2.TabIndex = 0;
            rb2.Text = "Kolay";
            rb2.UseVisualStyleBackColor = false;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.BackColor = Color.Transparent;
            rb1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rb1.ForeColor = Color.Black;
            rb1.Location = new Point(225, 119);
            rb1.Name = "rb1";
            rb1.Size = new Size(137, 36);
            rb1.TabIndex = 0;
            rb1.Text = "Çok Kolay";
            rb1.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { oyunToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(855, 24);
            menuStrip1.TabIndex = 1;
            // 
            // oyunToolStripMenuItem
            // 
            oyunToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnYeniOyun });
            oyunToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            oyunToolStripMenuItem.Name = "oyunToolStripMenuItem";
            oyunToolStripMenuItem.Size = new Size(48, 20);
            oyunToolStripMenuItem.Text = "Oyun";
            // 
            // btnYeniOyun
            // 
            btnYeniOyun.Name = "btnYeniOyun";
            btnYeniOyun.ShortcutKeys = Keys.F2;
            btnYeniOyun.Size = new Size(147, 22);
            btnYeniOyun.Text = "Yeni Oyun";
            btnYeniOyun.Click += btnYeniOyun_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(855, 698);
            Controls.Add(groupBox1);
            Controls.Add(pnlKartlar);
            Controls.Add(menuStrip1);
            ForeColor = Color.Yellow;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eşini Bul";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlKartlar;
        private GroupBox groupBox1;
        private Button button1;
        private RadioButton rb5;
        private RadioButton radioButton4;
        private RadioButton rb3;
        private RadioButton rb2;
        private RadioButton rb1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem oyunToolStripMenuItem;
        private ToolStripMenuItem btnYeniOyun;
    }
}
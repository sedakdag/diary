
namespace WinFormsApp2
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
            textBoxkullanici = new TextBox();
            textBoxsifre = new TextBox();
            labelkullanıcı = new Label();
            labelsifre = new Label();
            panel1 = new Panel();
            buttongrs = new Button();
            buttonKyt = new Button();
            SuspendLayout();
            // 
            // textBoxkullanici
            // 
            textBoxkullanici.Location = new Point(175, 89);
            textBoxkullanici.Margin = new Padding(4, 3, 4, 3);
            textBoxkullanici.Name = "textBoxkullanici";
            textBoxkullanici.Size = new Size(127, 33);
            textBoxkullanici.TabIndex = 1;
            // 
            // textBoxsifre
            // 
            textBoxsifre.Location = new Point(175, 138);
            textBoxsifre.Margin = new Padding(4, 3, 4, 3);
            textBoxsifre.Name = "textBoxsifre";
            textBoxsifre.Size = new Size(127, 33);
            textBoxsifre.TabIndex = 2;
            // 
            // labelkullanıcı
            // 
            labelkullanıcı.AutoSize = true;
            labelkullanıcı.Location = new Point(58, 98);
            labelkullanıcı.Margin = new Padding(4, 0, 4, 0);
            labelkullanıcı.Name = "labelkullanıcı";
            labelkullanıcı.Size = new Size(143, 26);
            labelkullanıcı.TabIndex = 2;
            labelkullanıcı.Text = "Kullanıcı adı";
            // 
            // labelsifre
            // 
            labelsifre.AutoSize = true;
            labelsifre.Location = new Point(58, 147);
            labelsifre.Margin = new Padding(4, 0, 4, 0);
            labelsifre.Name = "labelsifre";
            labelsifre.Size = new Size(63, 26);
            labelsifre.TabIndex = 2;
            labelsifre.Text = "Şifre";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(615, 74);
            panel1.TabIndex = 3;
            // 
            // buttongrs
            // 
            buttongrs.Location = new Point(58, 188);
            buttongrs.Name = "buttongrs";
            buttongrs.Size = new Size(117, 32);
            buttongrs.TabIndex = 4;
            buttongrs.Text = "GİRİŞ YAP";
            buttongrs.UseVisualStyleBackColor = true;
            buttongrs.Click += buttongrs_Click_1;
            // 
            // buttonKyt
            // 
            buttonKyt.Location = new Point(185, 188);
            buttonKyt.Name = "buttonKyt";
            buttonKyt.Size = new Size(117, 32);
            buttonKyt.TabIndex = 5;
            buttonKyt.Text = "KAYIT OL";
            buttonKyt.UseVisualStyleBackColor = true;
            buttonKyt.Click += buttonKyt_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 271);
            Controls.Add(buttonKyt);
            Controls.Add(buttongrs);
            Controls.Add(panel1);
            Controls.Add(labelsifre);
            Controls.Add(labelkullanıcı);
            Controls.Add(textBoxsifre);
            Controls.Add(textBoxkullanici);
            Font = new Font("Arial", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GİRİŞ SAYFASI";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void buttonKyt_Click(object sender, EventArgs e)
        {
           
        }

        private void buttongrs_Click(object sender, EventArgs e)
        {
           
        }

#endregion
        private TextBox textBoxkullanici;
        private TextBox textBoxsifre;
        private Label labelkullanıcı;
        private Label labelsifre;
        private Panel panel1;
        private Button buttongrs;
        private Button buttonKyt;
    }
}

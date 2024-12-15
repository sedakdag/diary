
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
            textBoxkullanıcı = new TextBox();
            textBoxsifre = new TextBox();
            labelkullanıcı = new Label();
            labelsifre = new Label();
            panel1 = new Panel();
            buttongrs = new Button();
            buttonkyt = new Button();
            SuspendLayout();
            // 
            // textBoxkullanıcı
            // 
            textBoxkullanıcı.Location = new Point(175, 89);
            textBoxkullanıcı.Margin = new Padding(4, 3, 4, 3);
            textBoxkullanıcı.Name = "textBoxkullanıcı";
            textBoxkullanıcı.Size = new Size(127, 25);
            textBoxkullanıcı.TabIndex = 1;
            // 
            // textBoxsifre
            // 
            textBoxsifre.Location = new Point(175, 138);
            textBoxsifre.Margin = new Padding(4, 3, 4, 3);
            textBoxsifre.Name = "textBoxsifre";
            textBoxsifre.Size = new Size(127, 25);
            textBoxsifre.TabIndex = 2;
            // 
            // labelkullanıcı
            // 
            labelkullanıcı.AutoSize = true;
            labelkullanıcı.Location = new Point(58, 98);
            labelkullanıcı.Margin = new Padding(4, 0, 4, 0);
            labelkullanıcı.Name = "labelkullanıcı";
            labelkullanıcı.Size = new Size(94, 17);
            labelkullanıcı.TabIndex = 2;
            labelkullanıcı.Text = "Kullanıcı adı";
            // 
            // labelsifre
            // 
            labelsifre.AutoSize = true;
            labelsifre.Location = new Point(58, 147);
            labelsifre.Margin = new Padding(4, 0, 4, 0);
            labelsifre.Name = "labelsifre";
            labelsifre.Size = new Size(41, 17);
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
            // buttonkyt
            // 
            buttonkyt.Location = new Point(181, 188);
            buttonkyt.Name = "buttonkyt";
            buttonkyt.Size = new Size(117, 32);
            buttonkyt.TabIndex = 5;
            buttonkyt.Text = "KAYIT OL";
            buttonkyt.UseVisualStyleBackColor = true;
            buttonkyt.Click += buttonkyt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 271);
            Controls.Add(buttonkyt);
            Controls.Add(buttongrs);
            Controls.Add(panel1);
            Controls.Add(labelsifre);
            Controls.Add(labelkullanıcı);
            Controls.Add(textBoxsifre);
            Controls.Add(textBoxkullanıcı);
            Font = new Font("Arial", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GİRİŞ SAYFASI";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void buttongrs_Click(object sender, EventArgs e)
        {
           
        }

#endregion
        private TextBox textBoxkullanıcı;
        private TextBox textBoxsifre;
        private Label labelkullanıcı;
        private Label labelsifre;
        private Panel panel1;
        private Button buttongrs;
        private Button buttonkyt;
    }
}

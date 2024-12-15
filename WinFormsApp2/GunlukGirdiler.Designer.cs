namespace WinFormsApp2
{
    partial class GunlukGirdiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GunlukGirdiler));
            buttonGecmis = new Button();
            buttonKaydet = new Button();
            gunlukGirdi = new TextBox();
            checkMutlu = new CheckBox();
            datetime_Picker = new DateTimePicker();
            pictureMutlu = new PictureBox();
            checkNormal = new CheckBox();
            pictureNormal = new PictureBox();
            checkUykulu = new CheckBox();
            pictureUykulu = new PictureBox();
            checkHasta = new CheckBox();
            pictureHasta = new PictureBox();
            checkSaskin = new CheckBox();
            pictureSaskin = new PictureBox();
            checkKizgin = new CheckBox();
            pictureKizgin = new PictureBox();
            checkUzgun = new CheckBox();
            pictureUzgun = new PictureBox();
            labelMutlu = new Label();
            labelNormal = new Label();
            labelUykulu = new Label();
            labelHasta = new Label();
            labelSaskin = new Label();
            labelKizgin = new Label();
            labelUzgun = new Label();
            panel_gunlukGirdi = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureMutlu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureNormal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureUykulu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureHasta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureSaskin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureKizgin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureUzgun).BeginInit();
            panel_gunlukGirdi.SuspendLayout();
            SuspendLayout();
            // 
            // buttonGecmis
            // 
            buttonGecmis.BackColor = Color.FromArgb(255, 128, 128);
            buttonGecmis.Font = new Font("Constantia", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonGecmis.Location = new Point(773, 39);
            buttonGecmis.Name = "buttonGecmis";
            buttonGecmis.Size = new Size(170, 68);
            buttonGecmis.TabIndex = 5;
            buttonGecmis.Text = "Geçmiş";
            buttonGecmis.UseVisualStyleBackColor = false;
            buttonGecmis.Click += buttonGecmis_Click;
            // 
            // buttonKaydet
            // 
            buttonKaydet.BackColor = Color.FromArgb(255, 128, 128);
            buttonKaydet.Font = new Font("Constantia", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonKaydet.ForeColor = Color.Black;
            buttonKaydet.Location = new Point(773, 522);
            buttonKaydet.Name = "buttonKaydet";
            buttonKaydet.Size = new Size(170, 68);
            buttonKaydet.TabIndex = 4;
            buttonKaydet.Text = "Kaydet";
            buttonKaydet.UseVisualStyleBackColor = false;
            buttonKaydet.Click += buttonKaydet_Click;
            // 
            // gunlukGirdi
            // 
            gunlukGirdi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gunlukGirdi.Location = new Point(52, 115);
            gunlukGirdi.Multiline = true;
            gunlukGirdi.Name = "gunlukGirdi";
            gunlukGirdi.Size = new Size(634, 329);
            gunlukGirdi.TabIndex = 0;
            gunlukGirdi.TextChanged += gunlukGirdi_TextChanged;
            // 
            // checkMutlu
            // 
            checkMutlu.AutoSize = true;
            checkMutlu.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkMutlu.Location = new Point(74, 578);
            checkMutlu.Name = "checkMutlu";
            checkMutlu.Size = new Size(22, 21);
            checkMutlu.TabIndex = 7;
            checkMutlu.UseVisualStyleBackColor = true;
            checkMutlu.CheckedChanged += checkboxmutlu_CheckedChanged;
            // 
            // datetime_Picker
            // 
            datetime_Picker.Location = new Point(52, 58);
            datetime_Picker.Name = "datetime_Picker";
            datetime_Picker.Size = new Size(300, 31);
            datetime_Picker.TabIndex = 8;
            // 
            // pictureMutlu
            // 
            pictureMutlu.Image = (Image)resources.GetObject("pictureMutlu.Image");
            pictureMutlu.Location = new Point(54, 476);
            pictureMutlu.Name = "pictureMutlu";
            pictureMutlu.Size = new Size(65, 68);
            pictureMutlu.TabIndex = 9;
            pictureMutlu.TabStop = false;
            // 
            // checkNormal
            // 
            checkNormal.AutoSize = true;
            checkNormal.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkNormal.Location = new Point(168, 578);
            checkNormal.Name = "checkNormal";
            checkNormal.Size = new Size(22, 21);
            checkNormal.TabIndex = 10;
            checkNormal.UseVisualStyleBackColor = true;
            // 
            // pictureNormal
            // 
            pictureNormal.Image = (Image)resources.GetObject("pictureNormal.Image");
            pictureNormal.Location = new Point(148, 476);
            pictureNormal.Name = "pictureNormal";
            pictureNormal.Size = new Size(65, 68);
            pictureNormal.TabIndex = 11;
            pictureNormal.TabStop = false;
            // 
            // checkUykulu
            // 
            checkUykulu.AutoSize = true;
            checkUykulu.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkUykulu.Location = new Point(263, 578);
            checkUykulu.Name = "checkUykulu";
            checkUykulu.Size = new Size(22, 21);
            checkUykulu.TabIndex = 12;
            checkUykulu.UseVisualStyleBackColor = true;
            // 
            // pictureUykulu
            // 
            pictureUykulu.Image = (Image)resources.GetObject("pictureUykulu.Image");
            pictureUykulu.Location = new Point(243, 476);
            pictureUykulu.Name = "pictureUykulu";
            pictureUykulu.Size = new Size(65, 68);
            pictureUykulu.TabIndex = 13;
            pictureUykulu.TabStop = false;
            // 
            // checkHasta
            // 
            checkHasta.AutoSize = true;
            checkHasta.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkHasta.Location = new Point(355, 578);
            checkHasta.Name = "checkHasta";
            checkHasta.Size = new Size(22, 21);
            checkHasta.TabIndex = 14;
            checkHasta.UseVisualStyleBackColor = true;
            // 
            // pictureHasta
            // 
            pictureHasta.Image = (Image)resources.GetObject("pictureHasta.Image");
            pictureHasta.Location = new Point(335, 476);
            pictureHasta.Name = "pictureHasta";
            pictureHasta.Size = new Size(65, 68);
            pictureHasta.TabIndex = 15;
            pictureHasta.TabStop = false;
            // 
            // checkSaskin
            // 
            checkSaskin.AutoSize = true;
            checkSaskin.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkSaskin.Location = new Point(453, 578);
            checkSaskin.Name = "checkSaskin";
            checkSaskin.Size = new Size(22, 21);
            checkSaskin.TabIndex = 16;
            checkSaskin.UseVisualStyleBackColor = true;
            // 
            // pictureSaskin
            // 
            pictureSaskin.Image = (Image)resources.GetObject("pictureSaskin.Image");
            pictureSaskin.Location = new Point(433, 476);
            pictureSaskin.Name = "pictureSaskin";
            pictureSaskin.Size = new Size(65, 68);
            pictureSaskin.TabIndex = 17;
            pictureSaskin.TabStop = false;
            // 
            // checkKizgin
            // 
            checkKizgin.AutoSize = true;
            checkKizgin.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkKizgin.Location = new Point(548, 578);
            checkKizgin.Name = "checkKizgin";
            checkKizgin.Size = new Size(22, 21);
            checkKizgin.TabIndex = 18;
            checkKizgin.UseVisualStyleBackColor = true;
            // 
            // pictureKizgin
            // 
            pictureKizgin.Image = (Image)resources.GetObject("pictureKizgin.Image");
            pictureKizgin.Location = new Point(528, 476);
            pictureKizgin.Name = "pictureKizgin";
            pictureKizgin.Size = new Size(65, 68);
            pictureKizgin.TabIndex = 19;
            pictureKizgin.TabStop = false;
            // 
            // checkUzgun
            // 
            checkUzgun.AutoSize = true;
            checkUzgun.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkUzgun.Location = new Point(641, 578);
            checkUzgun.Name = "checkUzgun";
            checkUzgun.Size = new Size(22, 21);
            checkUzgun.TabIndex = 20;
            checkUzgun.UseVisualStyleBackColor = true;
            // 
            // pictureUzgun
            // 
            pictureUzgun.Image = (Image)resources.GetObject("pictureUzgun.Image");
            pictureUzgun.Location = new Point(621, 476);
            pictureUzgun.Name = "pictureUzgun";
            pictureUzgun.Size = new Size(65, 68);
            pictureUzgun.TabIndex = 21;
            pictureUzgun.TabStop = false;
            // 
            // labelMutlu
            // 
            labelMutlu.AutoSize = true;
            labelMutlu.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMutlu.Location = new Point(52, 551);
            labelMutlu.Name = "labelMutlu";
            labelMutlu.Size = new Size(66, 25);
            labelMutlu.TabIndex = 22;
            labelMutlu.Text = "Mutlu";
            // 
            // labelNormal
            // 
            labelNormal.AutoSize = true;
            labelNormal.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNormal.Location = new Point(140, 551);
            labelNormal.Name = "labelNormal";
            labelNormal.Size = new Size(82, 25);
            labelNormal.TabIndex = 23;
            labelNormal.Text = "Normal";
            // 
            // labelUykulu
            // 
            labelUykulu.AutoSize = true;
            labelUykulu.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUykulu.Location = new Point(236, 551);
            labelUykulu.Name = "labelUykulu";
            labelUykulu.Size = new Size(77, 25);
            labelUykulu.TabIndex = 24;
            labelUykulu.Text = "Uykulu";
            // 
            // labelHasta
            // 
            labelHasta.AutoSize = true;
            labelHasta.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHasta.Location = new Point(333, 551);
            labelHasta.Name = "labelHasta";
            labelHasta.Size = new Size(67, 25);
            labelHasta.TabIndex = 25;
            labelHasta.Text = "Hasta";
            // 
            // labelSaskin
            // 
            labelSaskin.AutoSize = true;
            labelSaskin.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSaskin.Location = new Point(429, 551);
            labelSaskin.Name = "labelSaskin";
            labelSaskin.Size = new Size(76, 25);
            labelSaskin.TabIndex = 26;
            labelSaskin.Text = "Şaşkın";
            // 
            // labelKizgin
            // 
            labelKizgin.AutoSize = true;
            labelKizgin.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelKizgin.Location = new Point(525, 550);
            labelKizgin.Name = "labelKizgin";
            labelKizgin.Size = new Size(69, 25);
            labelKizgin.TabIndex = 27;
            labelKizgin.Text = "Kızgın";
            // 
            // labelUzgun
            // 
            labelUzgun.AutoSize = true;
            labelUzgun.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUzgun.Location = new Point(618, 547);
            labelUzgun.Name = "labelUzgun";
            labelUzgun.Size = new Size(69, 25);
            labelUzgun.TabIndex = 28;
            labelUzgun.Text = "Üzgün";
            // 
            // panel_gunlukGirdi
            // 
            panel_gunlukGirdi.BackColor = Color.FromArgb(255, 192, 192);
            panel_gunlukGirdi.Controls.Add(labelUzgun);
            panel_gunlukGirdi.Controls.Add(labelKizgin);
            panel_gunlukGirdi.Controls.Add(labelSaskin);
            panel_gunlukGirdi.Controls.Add(labelHasta);
            panel_gunlukGirdi.Controls.Add(labelUykulu);
            panel_gunlukGirdi.Controls.Add(labelNormal);
            panel_gunlukGirdi.Controls.Add(labelMutlu);
            panel_gunlukGirdi.Controls.Add(pictureUzgun);
            panel_gunlukGirdi.Controls.Add(checkUzgun);
            panel_gunlukGirdi.Controls.Add(pictureKizgin);
            panel_gunlukGirdi.Controls.Add(checkKizgin);
            panel_gunlukGirdi.Controls.Add(pictureSaskin);
            panel_gunlukGirdi.Controls.Add(checkSaskin);
            panel_gunlukGirdi.Controls.Add(pictureHasta);
            panel_gunlukGirdi.Controls.Add(checkHasta);
            panel_gunlukGirdi.Controls.Add(pictureUykulu);
            panel_gunlukGirdi.Controls.Add(checkUykulu);
            panel_gunlukGirdi.Controls.Add(pictureNormal);
            panel_gunlukGirdi.Controls.Add(checkNormal);
            panel_gunlukGirdi.Controls.Add(pictureMutlu);
            panel_gunlukGirdi.Controls.Add(datetime_Picker);
            panel_gunlukGirdi.Controls.Add(checkMutlu);
            panel_gunlukGirdi.Controls.Add(gunlukGirdi);
            panel_gunlukGirdi.Controls.Add(buttonKaydet);
            panel_gunlukGirdi.Controls.Add(buttonGecmis);
            panel_gunlukGirdi.Location = new Point(-1, -6);
            panel_gunlukGirdi.Name = "panel_gunlukGirdi";
            panel_gunlukGirdi.Size = new Size(990, 631);
            panel_gunlukGirdi.TabIndex = 3;
            panel_gunlukGirdi.Paint += panel1_Paint;
            // 
            // GunlukGirdiler
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 622);
            Controls.Add(panel_gunlukGirdi);
            Name = "GunlukGirdiler";
            Text = "Günlük Girdiler";
            ((System.ComponentModel.ISupportInitialize)pictureMutlu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureNormal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureUykulu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureHasta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureSaskin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureKizgin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureUzgun).EndInit();
            panel_gunlukGirdi.ResumeLayout(false);
            panel_gunlukGirdi.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonGecmis;
        private Button buttonKaydet;
        private TextBox gunlukGirdi;
        private CheckBox checkMutlu;
        private DateTimePicker datetime_Picker;
        private PictureBox pictureMutlu;
        private CheckBox checkNormal;
        private PictureBox pictureNormal;
        private CheckBox checkUykulu;
        private PictureBox pictureUykulu;
        private CheckBox checkHasta;
        private PictureBox pictureHasta;
        private CheckBox checkSaskin;
        private PictureBox pictureSaskin;
        private CheckBox checkKizgin;
        private PictureBox pictureKizgin;
        private CheckBox checkUzgun;
        private PictureBox pictureUzgun;
        private Label labelMutlu;
        private Label labelNormal;
        private Label labelUykulu;
        private Label labelHasta;
        private Label labelSaskin;
        private Label labelKizgin;
        private Label labelUzgun;
        private Panel panel_gunlukGirdi;
    }
}
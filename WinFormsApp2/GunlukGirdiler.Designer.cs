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
            buttonGecmis.Location = new Point(541, 23);
            buttonGecmis.Margin = new Padding(2, 2, 2, 2);
            buttonGecmis.Name = "buttonGecmis";
            buttonGecmis.Size = new Size(119, 41);
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
            buttonKaydet.Location = new Point(541, 313);
            buttonKaydet.Margin = new Padding(2, 2, 2, 2);
            buttonKaydet.Name = "buttonKaydet";
            buttonKaydet.Size = new Size(119, 41);
            buttonKaydet.TabIndex = 4;
            buttonKaydet.Text = "Kaydet";
            buttonKaydet.UseVisualStyleBackColor = false;
            buttonKaydet.Click += buttonKaydet_Click;
            // 
            // gunlukGirdi
            // 
            gunlukGirdi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gunlukGirdi.Location = new Point(36, 69);
            gunlukGirdi.Margin = new Padding(2, 2, 2, 2);
            gunlukGirdi.Multiline = true;
            gunlukGirdi.Name = "gunlukGirdi";
            gunlukGirdi.Size = new Size(445, 199);
            gunlukGirdi.TabIndex = 0;
            gunlukGirdi.TextChanged += gunlukGirdi_TextChanged;
            // 
            // checkMutlu
            // 
            checkMutlu.AutoSize = true;
            checkMutlu.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkMutlu.Location = new Point(52, 347);
            checkMutlu.Margin = new Padding(2, 2, 2, 2);
            checkMutlu.Name = "checkMutlu";
            checkMutlu.Size = new Size(15, 14);
            checkMutlu.TabIndex = 7;
            checkMutlu.UseVisualStyleBackColor = true;
            checkMutlu.CheckedChanged += checkboxmutlu_CheckedChanged;
            // 
            // datetime_Picker
            // 
            datetime_Picker.Location = new Point(36, 35);
            datetime_Picker.Margin = new Padding(2, 2, 2, 2);
            datetime_Picker.Name = "datetime_Picker";
            datetime_Picker.Size = new Size(211, 23);
            datetime_Picker.TabIndex = 8;
            // 
            // pictureMutlu
            // 
            pictureMutlu.Image = (Image)resources.GetObject("pictureMutlu.Image");
            pictureMutlu.Location = new Point(38, 286);
            pictureMutlu.Margin = new Padding(2, 2, 2, 2);
            pictureMutlu.Name = "pictureMutlu";
            pictureMutlu.Size = new Size(46, 41);
            pictureMutlu.TabIndex = 9;
            pictureMutlu.TabStop = false;
            // 
            // checkNormal
            // 
            checkNormal.AutoSize = true;
            checkNormal.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkNormal.Location = new Point(118, 347);
            checkNormal.Margin = new Padding(2, 2, 2, 2);
            checkNormal.Name = "checkNormal";
            checkNormal.Size = new Size(15, 14);
            checkNormal.TabIndex = 10;
            checkNormal.UseVisualStyleBackColor = true;
            // 
            // pictureNormal
            // 
            pictureNormal.Image = (Image)resources.GetObject("pictureNormal.Image");
            pictureNormal.Location = new Point(104, 286);
            pictureNormal.Margin = new Padding(2, 2, 2, 2);
            pictureNormal.Name = "pictureNormal";
            pictureNormal.Size = new Size(46, 41);
            pictureNormal.TabIndex = 11;
            pictureNormal.TabStop = false;
            // 
            // checkUykulu
            // 
            checkUykulu.AutoSize = true;
            checkUykulu.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkUykulu.Location = new Point(184, 347);
            checkUykulu.Margin = new Padding(2, 2, 2, 2);
            checkUykulu.Name = "checkUykulu";
            checkUykulu.Size = new Size(15, 14);
            checkUykulu.TabIndex = 12;
            checkUykulu.UseVisualStyleBackColor = true;
            // 
            // pictureUykulu
            // 
            pictureUykulu.Image = (Image)resources.GetObject("pictureUykulu.Image");
            pictureUykulu.Location = new Point(170, 286);
            pictureUykulu.Margin = new Padding(2, 2, 2, 2);
            pictureUykulu.Name = "pictureUykulu";
            pictureUykulu.Size = new Size(46, 41);
            pictureUykulu.TabIndex = 13;
            pictureUykulu.TabStop = false;
            // 
            // checkHasta
            // 
            checkHasta.AutoSize = true;
            checkHasta.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkHasta.Location = new Point(248, 347);
            checkHasta.Margin = new Padding(2, 2, 2, 2);
            checkHasta.Name = "checkHasta";
            checkHasta.Size = new Size(15, 14);
            checkHasta.TabIndex = 14;
            checkHasta.UseVisualStyleBackColor = true;
            // 
            // pictureHasta
            // 
            pictureHasta.Image = (Image)resources.GetObject("pictureHasta.Image");
            pictureHasta.Location = new Point(234, 286);
            pictureHasta.Margin = new Padding(2, 2, 2, 2);
            pictureHasta.Name = "pictureHasta";
            pictureHasta.Size = new Size(46, 41);
            pictureHasta.TabIndex = 15;
            pictureHasta.TabStop = false;
            // 
            // checkSaskin
            // 
            checkSaskin.AutoSize = true;
            checkSaskin.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkSaskin.Location = new Point(317, 347);
            checkSaskin.Margin = new Padding(2, 2, 2, 2);
            checkSaskin.Name = "checkSaskin";
            checkSaskin.Size = new Size(15, 14);
            checkSaskin.TabIndex = 16;
            checkSaskin.UseVisualStyleBackColor = true;
            // 
            // pictureSaskin
            // 
            pictureSaskin.Image = (Image)resources.GetObject("pictureSaskin.Image");
            pictureSaskin.Location = new Point(303, 286);
            pictureSaskin.Margin = new Padding(2, 2, 2, 2);
            pictureSaskin.Name = "pictureSaskin";
            pictureSaskin.Size = new Size(46, 41);
            pictureSaskin.TabIndex = 17;
            pictureSaskin.TabStop = false;
            // 
            // checkKizgin
            // 
            checkKizgin.AutoSize = true;
            checkKizgin.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkKizgin.Location = new Point(384, 347);
            checkKizgin.Margin = new Padding(2, 2, 2, 2);
            checkKizgin.Name = "checkKizgin";
            checkKizgin.Size = new Size(15, 14);
            checkKizgin.TabIndex = 18;
            checkKizgin.UseVisualStyleBackColor = true;
            // 
            // pictureKizgin
            // 
            pictureKizgin.Image = (Image)resources.GetObject("pictureKizgin.Image");
            pictureKizgin.Location = new Point(370, 286);
            pictureKizgin.Margin = new Padding(2, 2, 2, 2);
            pictureKizgin.Name = "pictureKizgin";
            pictureKizgin.Size = new Size(46, 41);
            pictureKizgin.TabIndex = 19;
            pictureKizgin.TabStop = false;
            // 
            // checkUzgun
            // 
            checkUzgun.AutoSize = true;
            checkUzgun.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkUzgun.Location = new Point(449, 347);
            checkUzgun.Margin = new Padding(2, 2, 2, 2);
            checkUzgun.Name = "checkUzgun";
            checkUzgun.Size = new Size(15, 14);
            checkUzgun.TabIndex = 20;
            checkUzgun.UseVisualStyleBackColor = true;
            // 
            // pictureUzgun
            // 
            pictureUzgun.Image = (Image)resources.GetObject("pictureUzgun.Image");
            pictureUzgun.Location = new Point(435, 286);
            pictureUzgun.Margin = new Padding(2, 2, 2, 2);
            pictureUzgun.Name = "pictureUzgun";
            pictureUzgun.Size = new Size(46, 41);
            pictureUzgun.TabIndex = 21;
            pictureUzgun.TabStop = false;
            // 
            // labelMutlu
            // 
            labelMutlu.AutoSize = true;
            labelMutlu.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMutlu.Location = new Point(36, 331);
            labelMutlu.Margin = new Padding(2, 0, 2, 0);
            labelMutlu.Name = "labelMutlu";
            labelMutlu.Size = new Size(47, 18);
            labelMutlu.TabIndex = 22;
            labelMutlu.Text = "Mutlu";
            // 
            // labelNormal
            // 
            labelNormal.AutoSize = true;
            labelNormal.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNormal.Location = new Point(98, 331);
            labelNormal.Margin = new Padding(2, 0, 2, 0);
            labelNormal.Name = "labelNormal";
            labelNormal.Size = new Size(57, 18);
            labelNormal.TabIndex = 23;
            labelNormal.Text = "Normal";
            // 
            // labelUykulu
            // 
            labelUykulu.AutoSize = true;
            labelUykulu.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUykulu.Location = new Point(165, 331);
            labelUykulu.Margin = new Padding(2, 0, 2, 0);
            labelUykulu.Name = "labelUykulu";
            labelUykulu.Size = new Size(54, 18);
            labelUykulu.TabIndex = 24;
            labelUykulu.Text = "Uykulu";
            // 
            // labelHasta
            // 
            labelHasta.AutoSize = true;
            labelHasta.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHasta.Location = new Point(233, 331);
            labelHasta.Margin = new Padding(2, 0, 2, 0);
            labelHasta.Name = "labelHasta";
            labelHasta.Size = new Size(48, 18);
            labelHasta.TabIndex = 25;
            labelHasta.Text = "Hasta";
            // 
            // labelSaskin
            // 
            labelSaskin.AutoSize = true;
            labelSaskin.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSaskin.Location = new Point(300, 331);
            labelSaskin.Margin = new Padding(2, 0, 2, 0);
            labelSaskin.Name = "labelSaskin";
            labelSaskin.Size = new Size(54, 18);
            labelSaskin.TabIndex = 26;
            labelSaskin.Text = "Şaşkın";
            // 
            // labelKizgin
            // 
            labelKizgin.AutoSize = true;
            labelKizgin.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelKizgin.Location = new Point(368, 330);
            labelKizgin.Margin = new Padding(2, 0, 2, 0);
            labelKizgin.Name = "labelKizgin";
            labelKizgin.Size = new Size(50, 18);
            labelKizgin.TabIndex = 27;
            labelKizgin.Text = "Kızgın";
            // 
            // labelUzgun
            // 
            labelUzgun.AutoSize = true;
            labelUzgun.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUzgun.Location = new Point(433, 328);
            labelUzgun.Margin = new Padding(2, 0, 2, 0);
            labelUzgun.Name = "labelUzgun";
            labelUzgun.Size = new Size(50, 18);
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
            panel_gunlukGirdi.Location = new Point(-1, -4);
            panel_gunlukGirdi.Margin = new Padding(2, 2, 2, 2);
            panel_gunlukGirdi.Name = "panel_gunlukGirdi";
            panel_gunlukGirdi.Size = new Size(693, 379);
            panel_gunlukGirdi.TabIndex = 3;
            panel_gunlukGirdi.Paint += panel1_Paint;
            // 
            // GunlukGirdiler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 373);
            Controls.Add(panel_gunlukGirdi);
            Margin = new Padding(2, 2, 2, 2);
            Name = "GunlukGirdiler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Günlük Girdileri";
            Load += GunlukGirdiler_Load;
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
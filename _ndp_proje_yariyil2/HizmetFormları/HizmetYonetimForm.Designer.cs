namespace _ndp_proje_yariyil2.HizmetFormları
{
    partial class HizmetYonetimForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HizmetYonetimForm));
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            kisiCbx1 = new ComboBox();
            daireCbx1 = new ComboBox();
            SorgulaButton = new Button();
            fitnessRich = new RichTextBox();
            label1 = new Label();
            havuzKullanimLabel = new Label();
            havuzRich = new RichTextBox();
            havuzRadioButton = new RadioButton();
            fitnessRadioButton = new RadioButton();
            hizmetYeriDuzenleTab = new TabControl();
            tabPage2 = new TabPage();
            geriButton = new Button();
            label6 = new Label();
            tabPage1 = new TabPage();
            geriButton2 = new Button();
            fitnessTemizleButton = new Button();
            havuzTemizleButton = new Button();
            tabPage3 = new TabPage();
            geriButton3 = new Button();
            fitnessAlanText = new MaskedTextBox();
            havuzDerinlikText = new MaskedTextBox();
            havuzAlanText = new MaskedTextBox();
            fitnessDuzenleButton = new Button();
            fitnessKaydetButton = new Button();
            havuzDuzenleButton = new Button();
            havuzKaydetButton = new Button();
            label9 = new Label();
            label10 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            hizmetYeriDuzenleTab.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-3, -6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 464);
            pictureBox2.TabIndex = 62;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.Font = new Font("Verdana", 12F);
            label2.ForeColor = Color.FromArgb(25, 50, 90);
            label2.Location = new Point(343, 178);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 88;
            label2.Text = "Kişi Seçiniz:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Window;
            label3.Font = new Font("Verdana", 12F);
            label3.ForeColor = Color.FromArgb(25, 50, 90);
            label3.Location = new Point(60, 177);
            label3.Name = "label3";
            label3.Size = new Size(154, 25);
            label3.TabIndex = 87;
            label3.Text = "Daire Seçiniz:";
            // 
            // kisiCbx1
            // 
            kisiCbx1.Anchor = AnchorStyles.None;
            kisiCbx1.DropDownStyle = ComboBoxStyle.DropDownList;
            kisiCbx1.Enabled = false;
            kisiCbx1.FormattingEnabled = true;
            kisiCbx1.Location = new Point(343, 215);
            kisiCbx1.Name = "kisiCbx1";
            kisiCbx1.Size = new Size(262, 28);
            kisiCbx1.TabIndex = 86;
            kisiCbx1.SelectedIndexChanged += kisiCbx1_SelectedIndexChanged;
            // 
            // daireCbx1
            // 
            daireCbx1.Anchor = AnchorStyles.None;
            daireCbx1.DropDownStyle = ComboBoxStyle.DropDownList;
            daireCbx1.FormattingEnabled = true;
            daireCbx1.Location = new Point(60, 215);
            daireCbx1.Name = "daireCbx1";
            daireCbx1.Size = new Size(262, 28);
            daireCbx1.TabIndex = 85;
            daireCbx1.SelectedIndexChanged += daireCbx1_SelectedIndexChanged;
            // 
            // SorgulaButton
            // 
            SorgulaButton.Anchor = AnchorStyles.None;
            SorgulaButton.Cursor = Cursors.Hand;
            SorgulaButton.Enabled = false;
            SorgulaButton.FlatAppearance.BorderColor = Color.FromArgb(25, 50, 90);
            SorgulaButton.FlatAppearance.BorderSize = 2;
            SorgulaButton.Font = new Font("Segoe UI", 12F);
            SorgulaButton.ForeColor = Color.FromArgb(25, 50, 90);
            SorgulaButton.Location = new Point(343, 277);
            SorgulaButton.Name = "SorgulaButton";
            SorgulaButton.Size = new Size(262, 45);
            SorgulaButton.TabIndex = 84;
            SorgulaButton.Text = "Sorgula";
            SorgulaButton.UseVisualStyleBackColor = true;
            SorgulaButton.Click += sorgulaButton_Click;
            // 
            // fitnessRich
            // 
            fitnessRich.Anchor = AnchorStyles.None;
            fitnessRich.BackColor = Color.FromArgb(230, 240, 250);
            fitnessRich.Location = new Point(72, 253);
            fitnessRich.Name = "fitnessRich";
            fitnessRich.ReadOnly = true;
            fitnessRich.Size = new Size(517, 125);
            fitnessRich.TabIndex = 83;
            fitnessRich.Text = "";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(25, 50, 90);
            label1.Location = new Point(72, 208);
            label1.Name = "label1";
            label1.Size = new Size(280, 39);
            label1.TabIndex = 82;
            label1.Text = "Fitness Kullananlar";
            // 
            // havuzKullanimLabel
            // 
            havuzKullanimLabel.Anchor = AnchorStyles.None;
            havuzKullanimLabel.AutoSize = true;
            havuzKullanimLabel.BackColor = SystemColors.Window;
            havuzKullanimLabel.Font = new Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            havuzKullanimLabel.ForeColor = Color.FromArgb(25, 50, 90);
            havuzKullanimLabel.Location = new Point(72, 28);
            havuzKullanimLabel.Name = "havuzKullanimLabel";
            havuzKullanimLabel.Size = new Size(289, 39);
            havuzKullanimLabel.TabIndex = 80;
            havuzKullanimLabel.Text = "Havuzu Kullananlar";
            // 
            // havuzRich
            // 
            havuzRich.Anchor = AnchorStyles.None;
            havuzRich.BackColor = Color.FromArgb(230, 240, 250);
            havuzRich.Location = new Point(72, 73);
            havuzRich.Name = "havuzRich";
            havuzRich.ReadOnly = true;
            havuzRich.Size = new Size(517, 112);
            havuzRich.TabIndex = 79;
            havuzRich.Text = "";
            // 
            // havuzRadioButton
            // 
            havuzRadioButton.Anchor = AnchorStyles.None;
            havuzRadioButton.AutoSize = true;
            havuzRadioButton.Enabled = false;
            havuzRadioButton.Font = new Font("Segoe UI", 11F);
            havuzRadioButton.ForeColor = Color.FromArgb(25, 50, 90);
            havuzRadioButton.Location = new Point(60, 286);
            havuzRadioButton.Name = "havuzRadioButton";
            havuzRadioButton.Size = new Size(85, 29);
            havuzRadioButton.TabIndex = 0;
            havuzRadioButton.TabStop = true;
            havuzRadioButton.Text = "Havuz";
            havuzRadioButton.UseVisualStyleBackColor = true;
            havuzRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // fitnessRadioButton
            // 
            fitnessRadioButton.Anchor = AnchorStyles.None;
            fitnessRadioButton.AutoSize = true;
            fitnessRadioButton.Enabled = false;
            fitnessRadioButton.Font = new Font("Segoe UI", 11F);
            fitnessRadioButton.ForeColor = Color.FromArgb(25, 50, 90);
            fitnessRadioButton.Location = new Point(232, 286);
            fitnessRadioButton.Name = "fitnessRadioButton";
            fitnessRadioButton.Size = new Size(90, 29);
            fitnessRadioButton.TabIndex = 1;
            fitnessRadioButton.TabStop = true;
            fitnessRadioButton.Text = "Fitness";
            fitnessRadioButton.UseVisualStyleBackColor = true;
            fitnessRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // hizmetYeriDuzenleTab
            // 
            hizmetYeriDuzenleTab.Controls.Add(tabPage2);
            hizmetYeriDuzenleTab.Controls.Add(tabPage1);
            hizmetYeriDuzenleTab.Controls.Add(tabPage3);
            hizmetYeriDuzenleTab.Location = new Point(20, 3);
            hizmetYeriDuzenleTab.Name = "hizmetYeriDuzenleTab";
            hizmetYeriDuzenleTab.SelectedIndex = 0;
            hizmetYeriDuzenleTab.Size = new Size(685, 445);
            hizmetYeriDuzenleTab.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Window;
            tabPage2.Controls.Add(geriButton);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(SorgulaButton);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(fitnessRadioButton);
            tabPage2.Controls.Add(havuzRadioButton);
            tabPage2.Controls.Add(daireCbx1);
            tabPage2.Controls.Add(kisiCbx1);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(677, 412);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "    Hizmet Kullanım   ";
            // 
            // geriButton
            // 
            geriButton.BackColor = Color.Transparent;
            geriButton.BackgroundImage = (Image)resources.GetObject("geriButton.BackgroundImage");
            geriButton.BackgroundImageLayout = ImageLayout.Stretch;
            geriButton.Cursor = Cursors.Hand;
            geriButton.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            geriButton.FlatAppearance.BorderSize = 0;
            geriButton.FlatStyle = FlatStyle.Flat;
            geriButton.Location = new Point(8, 15);
            geriButton.Name = "geriButton";
            geriButton.Size = new Size(32, 32);
            geriButton.TabIndex = 108;
            geriButton.UseVisualStyleBackColor = false;
            geriButton.Click += geriButton1_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(25, 50, 90);
            label6.Location = new Point(60, 73);
            label6.Name = "label6";
            label6.Size = new Size(220, 35);
            label6.TabIndex = 89;
            label6.Text = "Hizmet Yönetim";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Window;
            tabPage1.Controls.Add(geriButton2);
            tabPage1.Controls.Add(fitnessTemizleButton);
            tabPage1.Controls.Add(havuzTemizleButton);
            tabPage1.Controls.Add(fitnessRich);
            tabPage1.Controls.Add(havuzKullanimLabel);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(havuzRich);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(677, 412);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "      Raporlar        ";
            // 
            // geriButton2
            // 
            geriButton2.BackColor = Color.Transparent;
            geriButton2.BackgroundImage = (Image)resources.GetObject("geriButton2.BackgroundImage");
            geriButton2.BackgroundImageLayout = ImageLayout.Stretch;
            geriButton2.Cursor = Cursors.Hand;
            geriButton2.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            geriButton2.FlatAppearance.BorderSize = 0;
            geriButton2.FlatStyle = FlatStyle.Flat;
            geriButton2.Location = new Point(10, 11);
            geriButton2.Name = "geriButton2";
            geriButton2.Size = new Size(32, 32);
            geriButton2.TabIndex = 87;
            geriButton2.UseVisualStyleBackColor = false;
            geriButton2.Click += geriButton1_Click;
            // 
            // fitnessTemizleButton
            // 
            fitnessTemizleButton.Cursor = Cursors.Hand;
            fitnessTemizleButton.FlatAppearance.BorderSize = 2;
            fitnessTemizleButton.FlatStyle = FlatStyle.Popup;
            fitnessTemizleButton.ForeColor = Color.FromArgb(25, 50, 90);
            fitnessTemizleButton.Location = new Point(495, 216);
            fitnessTemizleButton.Name = "fitnessTemizleButton";
            fitnessTemizleButton.Size = new Size(94, 31);
            fitnessTemizleButton.TabIndex = 86;
            fitnessTemizleButton.Text = "Temizle";
            fitnessTemizleButton.UseVisualStyleBackColor = true;
            fitnessTemizleButton.Click += fitnessTemizleButton_Click;
            // 
            // havuzTemizleButton
            // 
            havuzTemizleButton.Cursor = Cursors.Hand;
            havuzTemizleButton.FlatAppearance.BorderSize = 2;
            havuzTemizleButton.FlatStyle = FlatStyle.Popup;
            havuzTemizleButton.ForeColor = Color.FromArgb(25, 50, 90);
            havuzTemizleButton.Location = new Point(495, 34);
            havuzTemizleButton.Name = "havuzTemizleButton";
            havuzTemizleButton.Size = new Size(94, 33);
            havuzTemizleButton.TabIndex = 85;
            havuzTemizleButton.Text = "Temizle";
            havuzTemizleButton.UseVisualStyleBackColor = true;
            havuzTemizleButton.Click += havuzTemizleButton_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(geriButton3);
            tabPage3.Controls.Add(fitnessAlanText);
            tabPage3.Controls.Add(havuzDerinlikText);
            tabPage3.Controls.Add(havuzAlanText);
            tabPage3.Controls.Add(fitnessDuzenleButton);
            tabPage3.Controls.Add(fitnessKaydetButton);
            tabPage3.Controls.Add(havuzDuzenleButton);
            tabPage3.Controls.Add(havuzKaydetButton);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label4);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(677, 412);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "   Mekan Bilgileri    ";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // geriButton3
            // 
            geriButton3.BackColor = Color.Transparent;
            geriButton3.BackgroundImage = (Image)resources.GetObject("geriButton3.BackgroundImage");
            geriButton3.BackgroundImageLayout = ImageLayout.Stretch;
            geriButton3.Cursor = Cursors.Hand;
            geriButton3.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            geriButton3.FlatAppearance.BorderSize = 0;
            geriButton3.FlatStyle = FlatStyle.Flat;
            geriButton3.Location = new Point(8, 10);
            geriButton3.Name = "geriButton3";
            geriButton3.Size = new Size(32, 32);
            geriButton3.TabIndex = 107;
            geriButton3.UseVisualStyleBackColor = false;
            geriButton3.Click += geriButton1_Click;
            // 
            // fitnessAlanText
            // 
            fitnessAlanText.Enabled = false;
            fitnessAlanText.ForeColor = Color.FromArgb(15, 20, 40);
            fitnessAlanText.Location = new Point(420, 163);
            fitnessAlanText.Mask = "0000";
            fitnessAlanText.Name = "fitnessAlanText";
            fitnessAlanText.Size = new Size(178, 27);
            fitnessAlanText.TabIndex = 106;
            fitnessAlanText.MouseClick += havuzDerinlikText_MouseClick;
            // 
            // havuzDerinlikText
            // 
            havuzDerinlikText.Enabled = false;
            havuzDerinlikText.ForeColor = Color.FromArgb(15, 20, 40);
            havuzDerinlikText.Location = new Point(122, 211);
            havuzDerinlikText.Mask = "00";
            havuzDerinlikText.Name = "havuzDerinlikText";
            havuzDerinlikText.Size = new Size(178, 27);
            havuzDerinlikText.TabIndex = 105;
            havuzDerinlikText.MouseClick += havuzDerinlikText_MouseClick;
            // 
            // havuzAlanText
            // 
            havuzAlanText.Enabled = false;
            havuzAlanText.ForeColor = Color.FromArgb(15, 20, 40);
            havuzAlanText.Location = new Point(122, 160);
            havuzAlanText.Mask = "0000";
            havuzAlanText.Name = "havuzAlanText";
            havuzAlanText.Size = new Size(178, 27);
            havuzAlanText.TabIndex = 104;
            havuzAlanText.MouseClick += havuzDerinlikText_MouseClick;
            // 
            // fitnessDuzenleButton
            // 
            fitnessDuzenleButton.Cursor = Cursors.Hand;
            fitnessDuzenleButton.ForeColor = Color.FromArgb(25, 50, 90);
            fitnessDuzenleButton.Location = new Point(367, 274);
            fitnessDuzenleButton.Name = "fitnessDuzenleButton";
            fitnessDuzenleButton.Size = new Size(109, 29);
            fitnessDuzenleButton.TabIndex = 102;
            fitnessDuzenleButton.Text = "Düzenle";
            fitnessDuzenleButton.UseVisualStyleBackColor = true;
            fitnessDuzenleButton.Click += fitnessDuzenleButton_Click;
            // 
            // fitnessKaydetButton
            // 
            fitnessKaydetButton.Cursor = Cursors.Hand;
            fitnessKaydetButton.Enabled = false;
            fitnessKaydetButton.ForeColor = Color.FromArgb(25, 50, 90);
            fitnessKaydetButton.Location = new Point(516, 274);
            fitnessKaydetButton.Name = "fitnessKaydetButton";
            fitnessKaydetButton.Size = new Size(110, 29);
            fitnessKaydetButton.TabIndex = 101;
            fitnessKaydetButton.Text = "Kaydet";
            fitnessKaydetButton.UseVisualStyleBackColor = true;
            fitnessKaydetButton.Click += fitnessKaydetButton_Click;
            // 
            // havuzDuzenleButton
            // 
            havuzDuzenleButton.Cursor = Cursors.Hand;
            havuzDuzenleButton.ForeColor = Color.FromArgb(25, 50, 90);
            havuzDuzenleButton.Location = new Point(50, 274);
            havuzDuzenleButton.Name = "havuzDuzenleButton";
            havuzDuzenleButton.Size = new Size(109, 29);
            havuzDuzenleButton.TabIndex = 100;
            havuzDuzenleButton.Text = "Düzenle";
            havuzDuzenleButton.UseVisualStyleBackColor = true;
            havuzDuzenleButton.Click += havuzDuzenleButton_Click;
            // 
            // havuzKaydetButton
            // 
            havuzKaydetButton.Cursor = Cursors.Hand;
            havuzKaydetButton.Enabled = false;
            havuzKaydetButton.ForeColor = Color.FromArgb(25, 50, 90);
            havuzKaydetButton.Location = new Point(190, 274);
            havuzKaydetButton.Name = "havuzKaydetButton";
            havuzKaydetButton.Size = new Size(110, 29);
            havuzKaydetButton.TabIndex = 99;
            havuzKaydetButton.Text = "Kaydet";
            havuzKaydetButton.UseVisualStyleBackColor = true;
            havuzKaydetButton.Click += havuzKaydetButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(25, 50, 90);
            label9.Location = new Point(369, 166);
            label9.Name = "label9";
            label9.Size = new Size(42, 20);
            label9.TabIndex = 97;
            label9.Text = "Alan:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 13F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(25, 50, 90);
            label10.Location = new Point(420, 106);
            label10.Name = "label10";
            label10.Size = new Size(160, 25);
            label10.TabIndex = 95;
            label10.Text = "Fitness Bilgileri";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(25, 50, 90);
            label7.Location = new Point(50, 214);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 93;
            label7.Text = "Derinlik:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(25, 50, 90);
            label5.Location = new Point(52, 163);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 92;
            label5.Text = "Alan:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(25, 50, 90);
            label4.Location = new Point(93, 106);
            label4.Name = "label4";
            label4.Size = new Size(154, 25);
            label4.TabIndex = 90;
            label4.Text = "Havuz Bilgileri";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // HizmetYonetimForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(703, 450);
            Controls.Add(pictureBox2);
            Controls.Add(hizmetYeriDuzenleTab);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "HizmetYonetimForm";
            StartPosition = FormStartPosition.Manual;
            Text = "HizmetYonetim";
            Load += HizmetYonetimForm_Load;
            MouseDown += HizmetYonetimForm_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            hizmetYeriDuzenleTab.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private ComboBox kisiCbx1;
        private ComboBox daireCbx1;
        private Button SorgulaButton;
        private RichTextBox fitnessRich;
        private Label label1;
        private Button geriButton1;
        private Button geriButton2;
        private Button geriButton3;
        private Label havuzKullanimLabel;
        private RichTextBox havuzRich;
        private RadioButton havuzRadioButton;
        private RadioButton fitnessRadioButton;
        private TabControl hizmetYeriDuzenleTab;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private Label label6;
        private Button havuzTemizleButton;
        private Button fitnessTemizleButton;
        private TabPage tabPage3;
        private Label label5;
        private Label label4;
        private Button fitnessDuzenleButton;
        private Button fitnessKaydetButton;
        private Button havuzDuzenleButton;
        private Button havuzKaydetButton;
        private Label label9;
        private Label label10;
        private Label label7;
        private MaskedTextBox fitnessAlanText;
        private MaskedTextBox havuzDerinlikText;
        private MaskedTextBox havuzAlanText;
        private ErrorProvider errorProvider1;
        private Button geriButton;
    }
}
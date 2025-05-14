namespace _ndp_proje_yariyil2
{
    partial class DaireYonetimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DaireYonetimForm));
            daireDuzenleButton = new Button();
            daireSilButton = new Button();
            label1 = new Label();
            daireGörButton = new Button();
            dairelerListBox = new ListBox();
            daireYonTabControl = new TabControl();
            dairelerTab = new TabPage();
            geriButton = new Button();
            daireYokLabel = new Label();
            yeniDaireTab = new TabPage();
            geriButton2 = new Button();
            daireEkleLabel = new Label();
            label5 = new Label();
            daireNoTextBox = new MaskedTextBox();
            maxKisiSayisiTextBox = new MaskedTextBox();
            label3 = new Label();
            daireEkleButton = new Button();
            AlanTextBox = new MaskedTextBox();
            label4 = new Label();
            toolTip1 = new ToolTip(components);
            errorProvider1 = new ErrorProvider(components);
            pictureBox2 = new PictureBox();
            daireYonTabControl.SuspendLayout();
            dairelerTab.SuspendLayout();
            yeniDaireTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // daireDuzenleButton
            // 
            daireDuzenleButton.Anchor = AnchorStyles.None;
            daireDuzenleButton.Cursor = Cursors.Hand;
            daireDuzenleButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            daireDuzenleButton.ForeColor = Color.FromArgb(35, 70, 120);
            daireDuzenleButton.Location = new Point(401, 339);
            daireDuzenleButton.Name = "daireDuzenleButton";
            daireDuzenleButton.Size = new Size(92, 40);
            daireDuzenleButton.TabIndex = 19;
            daireDuzenleButton.Text = "Düzenle";
            daireDuzenleButton.UseVisualStyleBackColor = true;
            daireDuzenleButton.Click += daireDuzenleButton_Click;
            // 
            // daireSilButton
            // 
            daireSilButton.Anchor = AnchorStyles.None;
            daireSilButton.Cursor = Cursors.Hand;
            daireSilButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            daireSilButton.ForeColor = Color.FromArgb(35, 70, 120);
            daireSilButton.Location = new Point(501, 339);
            daireSilButton.Name = "daireSilButton";
            daireSilButton.Size = new Size(92, 40);
            daireSilButton.TabIndex = 18;
            daireSilButton.Text = "Sil";
            daireSilButton.UseVisualStyleBackColor = true;
            daireSilButton.Click += daireSilButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(25, 50, 90);
            label1.Location = new Point(93, 38);
            label1.Name = "label1";
            label1.Size = new Size(126, 35);
            label1.TabIndex = 17;
            label1.Text = "Daireler:";
            // 
            // daireGörButton
            // 
            daireGörButton.Anchor = AnchorStyles.None;
            daireGörButton.Cursor = Cursors.Hand;
            daireGörButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            daireGörButton.ForeColor = Color.FromArgb(35, 70, 120);
            daireGörButton.Location = new Point(93, 339);
            daireGörButton.Name = "daireGörButton";
            daireGörButton.Size = new Size(116, 40);
            daireGörButton.TabIndex = 16;
            daireGörButton.Text = "Daireyi Gör";
            daireGörButton.UseVisualStyleBackColor = true;
            daireGörButton.Click += daireGorButton_Click;
            // 
            // dairelerListBox
            // 
            dairelerListBox.Anchor = AnchorStyles.None;
            dairelerListBox.ForeColor = Color.FromArgb(15, 40, 70);
            dairelerListBox.FormattingEnabled = true;
            dairelerListBox.Location = new Point(93, 100);
            dairelerListBox.Name = "dairelerListBox";
            dairelerListBox.Size = new Size(500, 224);
            dairelerListBox.TabIndex = 21;
            dairelerListBox.SelectedIndexChanged += dairelerListBox_SelectedIndexChanged;
            dairelerListBox.MouseDoubleClick += dairelerListBox_MouseDoubleClick;
            // 
            // daireYonTabControl
            // 
            daireYonTabControl.Controls.Add(dairelerTab);
            daireYonTabControl.Controls.Add(yeniDaireTab);
            daireYonTabControl.Location = new Point(20, 0);
            daireYonTabControl.Name = "daireYonTabControl";
            daireYonTabControl.SelectedIndex = 0;
            daireYonTabControl.Size = new Size(706, 450);
            daireYonTabControl.TabIndex = 23;
            // 
            // dairelerTab
            // 
            dairelerTab.BackColor = SystemColors.Window;
            dairelerTab.Controls.Add(geriButton);
            dairelerTab.Controls.Add(daireYokLabel);
            dairelerTab.Controls.Add(label1);
            dairelerTab.Controls.Add(daireGörButton);
            dairelerTab.Controls.Add(dairelerListBox);
            dairelerTab.Controls.Add(daireSilButton);
            dairelerTab.Controls.Add(daireDuzenleButton);
            dairelerTab.Location = new Point(4, 29);
            dairelerTab.Name = "dairelerTab";
            dairelerTab.Padding = new Padding(3);
            dairelerTab.Size = new Size(698, 417);
            dairelerTab.TabIndex = 0;
            dairelerTab.Text = "    Daireler   ";
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
            geriButton.Location = new Point(6, 6);
            geriButton.Name = "geriButton";
            geriButton.Size = new Size(32, 32);
            geriButton.TabIndex = 71;
            geriButton.UseVisualStyleBackColor = false;
            geriButton.Click += geriButton_Click;
            // 
            // daireYokLabel
            // 
            daireYokLabel.Anchor = AnchorStyles.None;
            daireYokLabel.AutoSize = true;
            daireYokLabel.BackColor = Color.White;
            daireYokLabel.Font = new Font("Segoe UI Emoji", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            daireYokLabel.ForeColor = Color.FromArgb(65, 90, 140);
            daireYokLabel.Location = new Point(181, 188);
            daireYokLabel.Name = "daireYokLabel";
            daireYokLabel.Size = new Size(312, 38);
            daireYokLabel.TabIndex = 23;
            daireYokLabel.Text = "Hiç Daire Bulunamadı";
            daireYokLabel.Visible = false;
            // 
            // yeniDaireTab
            // 
            yeniDaireTab.Controls.Add(geriButton2);
            yeniDaireTab.Controls.Add(daireEkleLabel);
            yeniDaireTab.Controls.Add(label5);
            yeniDaireTab.Controls.Add(daireNoTextBox);
            yeniDaireTab.Controls.Add(maxKisiSayisiTextBox);
            yeniDaireTab.Controls.Add(label3);
            yeniDaireTab.Controls.Add(daireEkleButton);
            yeniDaireTab.Controls.Add(AlanTextBox);
            yeniDaireTab.Controls.Add(label4);
            yeniDaireTab.Location = new Point(4, 29);
            yeniDaireTab.Name = "yeniDaireTab";
            yeniDaireTab.Padding = new Padding(3);
            yeniDaireTab.Size = new Size(698, 417);
            yeniDaireTab.TabIndex = 1;
            yeniDaireTab.Text = "   Daire Ekle   ";
            yeniDaireTab.UseVisualStyleBackColor = true;
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
            geriButton2.Location = new Point(8, 6);
            geriButton2.Name = "geriButton2";
            geriButton2.Size = new Size(33, 34);
            geriButton2.TabIndex = 71;
            geriButton2.UseVisualStyleBackColor = false;
            geriButton2.Click += geriButton_Click;
            // 
            // daireEkleLabel
            // 
            daireEkleLabel.Anchor = AnchorStyles.None;
            daireEkleLabel.AutoSize = true;
            daireEkleLabel.Font = new Font("Times New Roman", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            daireEkleLabel.ForeColor = Color.FromArgb(25, 50, 90);
            daireEkleLabel.Location = new Point(190, 88);
            daireEkleLabel.Name = "daireEkleLabel";
            daireEkleLabel.Size = new Size(159, 36);
            daireEkleLabel.TabIndex = 26;
            daireEkleLabel.Text = "Daire Ekle";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Book", 13.8F);
            label5.ForeColor = Color.FromArgb(65, 90, 140);
            label5.Location = new Point(190, 229);
            label5.Name = "label5";
            label5.Size = new Size(116, 29);
            label5.TabIndex = 33;
            label5.Text = "Kişi Sayısı:";
            // 
            // daireNoTextBox
            // 
            daireNoTextBox.Anchor = AnchorStyles.None;
            daireNoTextBox.Font = new Font("Segoe UI", 10F);
            daireNoTextBox.ForeColor = Color.FromArgb(25, 50, 90);
            daireNoTextBox.Location = new Point(354, 150);
            daireNoTextBox.Mask = "0000";
            daireNoTextBox.Name = "daireNoTextBox";
            daireNoTextBox.Size = new Size(163, 30);
            daireNoTextBox.SkipLiterals = false;
            daireNoTextBox.TabIndex = 27;
            daireNoTextBox.ValidatingType = typeof(int);
            daireNoTextBox.MouseClick += textBoxMouseClickEvent;
            // 
            // maxKisiSayisiTextBox
            // 
            maxKisiSayisiTextBox.Anchor = AnchorStyles.None;
            maxKisiSayisiTextBox.Font = new Font("Segoe UI", 10F);
            maxKisiSayisiTextBox.ForeColor = Color.FromArgb(25, 50, 90);
            maxKisiSayisiTextBox.Location = new Point(354, 231);
            maxKisiSayisiTextBox.Mask = "00";
            maxKisiSayisiTextBox.Name = "maxKisiSayisiTextBox";
            maxKisiSayisiTextBox.Size = new Size(164, 30);
            maxKisiSayisiTextBox.SkipLiterals = false;
            maxKisiSayisiTextBox.TabIndex = 32;
            maxKisiSayisiTextBox.ValidatingType = typeof(int);
            maxKisiSayisiTextBox.MouseClick += textBoxMouseClickEvent;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Book", 13.8F);
            label3.ForeColor = Color.FromArgb(65, 90, 140);
            label3.Location = new Point(190, 152);
            label3.Name = "label3";
            label3.Size = new Size(104, 29);
            label3.TabIndex = 28;
            label3.Text = "Daire No:";
            // 
            // daireEkleButton
            // 
            daireEkleButton.Anchor = AnchorStyles.None;
            daireEkleButton.Cursor = Cursors.Hand;
            daireEkleButton.FlatStyle = FlatStyle.Flat;
            daireEkleButton.Font = new Font("Segoe UI", 12F);
            daireEkleButton.ForeColor = Color.FromArgb(35, 70, 120);
            daireEkleButton.Location = new Point(190, 284);
            daireEkleButton.Name = "daireEkleButton";
            daireEkleButton.Size = new Size(327, 44);
            daireEkleButton.TabIndex = 31;
            daireEkleButton.Text = "Ekle";
            daireEkleButton.UseVisualStyleBackColor = true;
            daireEkleButton.Click += daireEkleButton_Click;
            // 
            // AlanTextBox
            // 
            AlanTextBox.Anchor = AnchorStyles.None;
            AlanTextBox.Font = new Font("Segoe UI", 10F);
            AlanTextBox.ForeColor = Color.FromArgb(25, 50, 90);
            AlanTextBox.Location = new Point(354, 188);
            AlanTextBox.Mask = "00000";
            AlanTextBox.Name = "AlanTextBox";
            AlanTextBox.Size = new Size(163, 30);
            AlanTextBox.SkipLiterals = false;
            AlanTextBox.TabIndex = 29;
            AlanTextBox.ValidatingType = typeof(int);
            AlanTextBox.MouseClick += textBoxMouseClickEvent;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Book", 13.8F);
            label4.ForeColor = Color.FromArgb(65, 90, 140);
            label4.Location = new Point(190, 190);
            label4.Name = "label4";
            label4.Size = new Size(60, 29);
            label4.TabIndex = 30;
            label4.Text = "Alan:";
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-6, -14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 464);
            pictureBox2.TabIndex = 71;
            pictureBox2.TabStop = false;
            // 
            // DaireYonetimForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 450);
            Controls.Add(pictureBox2);
            Controls.Add(daireYonTabControl);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "DaireYonetimForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Daireler";
            Load += DaireYonetimForm_Load;
            MouseDown += DaireYonetimForm_MouseDown;
            daireYonTabControl.ResumeLayout(false);
            dairelerTab.ResumeLayout(false);
            dairelerTab.PerformLayout();
            yeniDaireTab.ResumeLayout(false);
            yeniDaireTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button daireDuzenleButton;
        private Button daireSilButton;
        private Label label1;
        private Button daireGörButton;
        private ListBox dairelerListBox;
        private TabControl daireYonTabControl;
        private TabPage dairelerTab;
        private TabPage yeniDaireTab;
        private ToolTip toolTip1;
        private Label daireEkleLabel;
        private Label label5;
        private MaskedTextBox daireNoTextBox;
        private MaskedTextBox maxKisiSayisiTextBox;
        private Label label3;
        private Button daireEkleButton;
        private MaskedTextBox AlanTextBox;
        private Label label4;
        private ErrorProvider errorProvider1;
        private Label daireYokLabel;
        private Button geriButton2;
        private PictureBox pictureBox2;
        private Button geriButton;
    }
}
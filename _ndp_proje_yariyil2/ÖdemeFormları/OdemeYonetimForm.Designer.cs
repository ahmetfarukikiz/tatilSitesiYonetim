namespace _ndp_proje_yariyil2.ÖdemeFormları
{
    partial class OdemeYonetimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdemeYonetimForm));
            odemeYonetimTab = new TabControl();
            odemeListesiTabPage = new TabPage();
            geriButton = new Button();
            yenileButton = new Button();
            odemeYokLabel = new Label();
            odemelerLabel = new Label();
            odemelerListBox = new ListBox();
            odemeSilButton = new Button();
            odemeDuzenleButton = new Button();
            odemeAlTab = new TabPage();
            button2 = new Button();
            tutarTextBox = new MaskedTextBox();
            kalanBorcTextBox = new TextBox();
            odemeDegerTextBox = new Label();
            label6 = new Label();
            tcsiTextBox = new TextBox();
            yasiTextBox = new TextBox();
            tcLabel = new Label();
            label1 = new Label();
            soyadiTextBox = new TextBox();
            adiTextBox = new TextBox();
            odemeAlButton = new Button();
            dairesiComboBox = new ComboBox();
            yasiLabel = new Label();
            adiLabel = new Label();
            yeniKayitLabel = new Label();
            soyadiLabel = new Label();
            toolTip1 = new ToolTip(components);
            errorProvider1 = new ErrorProvider(components);
            pictureBox2 = new PictureBox();
            odemeYonetimTab.SuspendLayout();
            odemeListesiTabPage.SuspendLayout();
            odemeAlTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // odemeYonetimTab
            // 
            odemeYonetimTab.Controls.Add(odemeListesiTabPage);
            odemeYonetimTab.Controls.Add(odemeAlTab);
            odemeYonetimTab.Location = new Point(24, 0);
            odemeYonetimTab.Name = "odemeYonetimTab";
            odemeYonetimTab.SelectedIndex = 0;
            odemeYonetimTab.Size = new Size(701, 450);
            odemeYonetimTab.TabIndex = 0;
            // 
            // odemeListesiTabPage
            // 
            odemeListesiTabPage.BackColor = SystemColors.Window;
            odemeListesiTabPage.Controls.Add(geriButton);
            odemeListesiTabPage.Controls.Add(yenileButton);
            odemeListesiTabPage.Controls.Add(odemeYokLabel);
            odemeListesiTabPage.Controls.Add(odemelerLabel);
            odemeListesiTabPage.Controls.Add(odemelerListBox);
            odemeListesiTabPage.Controls.Add(odemeSilButton);
            odemeListesiTabPage.Controls.Add(odemeDuzenleButton);
            odemeListesiTabPage.ForeColor = Color.FromArgb(25, 50, 90);
            odemeListesiTabPage.Location = new Point(4, 29);
            odemeListesiTabPage.Name = "odemeListesiTabPage";
            odemeListesiTabPage.Padding = new Padding(3);
            odemeListesiTabPage.Size = new Size(693, 417);
            odemeListesiTabPage.TabIndex = 0;
            odemeListesiTabPage.Text = "  Ödemeler  ";
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
            geriButton.Size = new Size(30, 30);
            geriButton.TabIndex = 69;
            geriButton.UseVisualStyleBackColor = false;
            geriButton.Click += geriButton_Click;
            // 
            // yenileButton
            // 
            yenileButton.Anchor = AnchorStyles.None;
            yenileButton.Cursor = Cursors.Hand;
            yenileButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            yenileButton.ForeColor = Color.FromArgb(25, 50, 90);
            yenileButton.Location = new Point(543, 46);
            yenileButton.Name = "yenileButton";
            yenileButton.Size = new Size(59, 37);
            yenileButton.TabIndex = 30;
            yenileButton.Text = "Yenile";
            yenileButton.UseVisualStyleBackColor = true;
            yenileButton.Click += yenileButton_Click;
            // 
            // odemeYokLabel
            // 
            odemeYokLabel.Anchor = AnchorStyles.None;
            odemeYokLabel.AutoSize = true;
            odemeYokLabel.BackColor = Color.White;
            odemeYokLabel.Font = new Font("Segoe UI Emoji", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            odemeYokLabel.ForeColor = Color.FromArgb(65, 90, 140);
            odemeYokLabel.Location = new Point(159, 214);
            odemeYokLabel.Name = "odemeYokLabel";
            odemeYokLabel.Size = new Size(339, 38);
            odemeYokLabel.TabIndex = 29;
            odemeYokLabel.Text = "Hiç Ödeme Bulunamadı";
            odemeYokLabel.Visible = false;
            // 
            // odemelerLabel
            // 
            odemelerLabel.Anchor = AnchorStyles.None;
            odemelerLabel.AutoSize = true;
            odemelerLabel.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            odemelerLabel.ForeColor = Color.FromArgb(25, 50, 90);
            odemelerLabel.Location = new Point(61, 54);
            odemelerLabel.Name = "odemelerLabel";
            odemelerLabel.Size = new Size(126, 29);
            odemelerLabel.TabIndex = 25;
            odemelerLabel.Text = "Ödemeler:";
            // 
            // odemelerListBox
            // 
            odemelerListBox.Anchor = AnchorStyles.None;
            odemelerListBox.ForeColor = Color.FromArgb(15, 40, 70);
            odemelerListBox.FormattingEnabled = true;
            odemelerListBox.Location = new Point(61, 108);
            odemelerListBox.Name = "odemelerListBox";
            odemelerListBox.Size = new Size(541, 244);
            odemelerListBox.TabIndex = 28;
            odemelerListBox.SelectedIndexChanged += odemelerListBox_SelectedIndexChanged;
            // 
            // odemeSilButton
            // 
            odemeSilButton.Anchor = AnchorStyles.None;
            odemeSilButton.Cursor = Cursors.Hand;
            odemeSilButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            odemeSilButton.ForeColor = Color.FromArgb(25, 50, 90);
            odemeSilButton.Location = new Point(518, 358);
            odemeSilButton.Name = "odemeSilButton";
            odemeSilButton.Size = new Size(85, 40);
            odemeSilButton.TabIndex = 26;
            odemeSilButton.Text = "Sil";
            odemeSilButton.UseVisualStyleBackColor = true;
            odemeSilButton.Click += odemeSilButton_Click;
            // 
            // odemeDuzenleButton
            // 
            odemeDuzenleButton.Anchor = AnchorStyles.None;
            odemeDuzenleButton.Cursor = Cursors.Hand;
            odemeDuzenleButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            odemeDuzenleButton.ForeColor = Color.FromArgb(25, 50, 90);
            odemeDuzenleButton.Location = new Point(427, 358);
            odemeDuzenleButton.Name = "odemeDuzenleButton";
            odemeDuzenleButton.Size = new Size(85, 40);
            odemeDuzenleButton.TabIndex = 27;
            odemeDuzenleButton.Text = "Düzenle";
            odemeDuzenleButton.UseVisualStyleBackColor = true;
            odemeDuzenleButton.Click += odemeDuzenleButton_Click;
            // 
            // odemeAlTab
            // 
            odemeAlTab.Controls.Add(button2);
            odemeAlTab.Controls.Add(tutarTextBox);
            odemeAlTab.Controls.Add(kalanBorcTextBox);
            odemeAlTab.Controls.Add(odemeDegerTextBox);
            odemeAlTab.Controls.Add(label6);
            odemeAlTab.Controls.Add(tcsiTextBox);
            odemeAlTab.Controls.Add(yasiTextBox);
            odemeAlTab.Controls.Add(tcLabel);
            odemeAlTab.Controls.Add(label1);
            odemeAlTab.Controls.Add(soyadiTextBox);
            odemeAlTab.Controls.Add(adiTextBox);
            odemeAlTab.Controls.Add(odemeAlButton);
            odemeAlTab.Controls.Add(dairesiComboBox);
            odemeAlTab.Controls.Add(yasiLabel);
            odemeAlTab.Controls.Add(adiLabel);
            odemeAlTab.Controls.Add(yeniKayitLabel);
            odemeAlTab.Controls.Add(soyadiLabel);
            odemeAlTab.ForeColor = Color.FromArgb(25, 50, 90);
            odemeAlTab.Location = new Point(4, 29);
            odemeAlTab.Name = "odemeAlTab";
            odemeAlTab.Padding = new Padding(3);
            odemeAlTab.Size = new Size(693, 417);
            odemeAlTab.TabIndex = 1;
            odemeAlTab.Text = "  Ödeme Al   ";
            odemeAlTab.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(6, 6);
            button2.Name = "button2";
            button2.Size = new Size(32, 32);
            button2.TabIndex = 108;
            button2.UseVisualStyleBackColor = false;
            button2.Click += geriButton_Click;
            // 
            // tutarTextBox
            // 
            tutarTextBox.Anchor = AnchorStyles.None;
            tutarTextBox.Enabled = false;
            tutarTextBox.Location = new Point(511, 256);
            tutarTextBox.Mask = "00000.00";
            tutarTextBox.Name = "tutarTextBox";
            tutarTextBox.Size = new Size(139, 27);
            tutarTextBox.TabIndex = 72;
            tutarTextBox.MouseClick += tutarTextBox_MouseClick;
            // 
            // kalanBorcTextBox
            // 
            kalanBorcTextBox.Anchor = AnchorStyles.None;
            kalanBorcTextBox.Font = new Font("Segoe UI", 9F);
            kalanBorcTextBox.Location = new Point(511, 222);
            kalanBorcTextBox.Name = "kalanBorcTextBox";
            kalanBorcTextBox.ReadOnly = true;
            kalanBorcTextBox.Size = new Size(139, 27);
            kalanBorcTextBox.TabIndex = 71;
            // 
            // odemeDegerTextBox
            // 
            odemeDegerTextBox.Anchor = AnchorStyles.None;
            odemeDegerTextBox.AutoSize = true;
            odemeDegerTextBox.Font = new Font("Verdana", 11F);
            odemeDegerTextBox.Location = new Point(377, 255);
            odemeDegerTextBox.Name = "odemeDegerTextBox";
            odemeDegerTextBox.Size = new Size(67, 23);
            odemeDegerTextBox.TabIndex = 68;
            odemeDegerTextBox.Text = "Tutar:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 11F);
            label6.Location = new Point(377, 222);
            label6.Name = "label6";
            label6.Size = new Size(121, 23);
            label6.TabIndex = 69;
            label6.Text = "Kalan Borç:";
            // 
            // tcsiTextBox
            // 
            tcsiTextBox.Anchor = AnchorStyles.None;
            tcsiTextBox.Font = new Font("Segoe UI", 8F);
            tcsiTextBox.Location = new Point(170, 316);
            tcsiTextBox.Name = "tcsiTextBox";
            tcsiTextBox.ReadOnly = true;
            tcsiTextBox.Size = new Size(150, 25);
            tcsiTextBox.TabIndex = 67;
            // 
            // yasiTextBox
            // 
            yasiTextBox.Anchor = AnchorStyles.None;
            yasiTextBox.Font = new Font("Segoe UI", 8F);
            yasiTextBox.Location = new Point(170, 285);
            yasiTextBox.Name = "yasiTextBox";
            yasiTextBox.ReadOnly = true;
            yasiTextBox.Size = new Size(150, 25);
            yasiTextBox.TabIndex = 66;
            // 
            // tcLabel
            // 
            tcLabel.Anchor = AnchorStyles.None;
            tcLabel.AutoSize = true;
            tcLabel.Font = new Font("Verdana", 11F);
            tcLabel.Location = new Point(77, 316);
            tcLabel.Name = "tcLabel";
            tcLabel.Size = new Size(77, 23);
            tcLabel.TabIndex = 65;
            tcLabel.Text = "TC No:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13F);
            label1.Location = new Point(182, 95);
            label1.Name = "label1";
            label1.Size = new Size(127, 26);
            label1.TabIndex = 60;
            label1.Text = "Daire Seç:";
            // 
            // soyadiTextBox
            // 
            soyadiTextBox.Anchor = AnchorStyles.None;
            soyadiTextBox.Font = new Font("Segoe UI", 8F);
            soyadiTextBox.Location = new Point(170, 253);
            soyadiTextBox.Name = "soyadiTextBox";
            soyadiTextBox.ReadOnly = true;
            soyadiTextBox.Size = new Size(150, 25);
            soyadiTextBox.TabIndex = 59;
            // 
            // adiTextBox
            // 
            adiTextBox.Anchor = AnchorStyles.None;
            adiTextBox.Font = new Font("Segoe UI", 8F);
            adiTextBox.Location = new Point(170, 220);
            adiTextBox.Name = "adiTextBox";
            adiTextBox.ReadOnly = true;
            adiTextBox.Size = new Size(150, 25);
            adiTextBox.TabIndex = 58;
            // 
            // odemeAlButton
            // 
            odemeAlButton.Anchor = AnchorStyles.None;
            odemeAlButton.Cursor = Cursors.Hand;
            odemeAlButton.Font = new Font("Segoe UI", 12F);
            odemeAlButton.Location = new Point(377, 307);
            odemeAlButton.Name = "odemeAlButton";
            odemeAlButton.Size = new Size(273, 37);
            odemeAlButton.TabIndex = 54;
            odemeAlButton.Text = "Ödeme Al";
            odemeAlButton.UseVisualStyleBackColor = true;
            odemeAlButton.Click += odemeEkleButton_Click;
            // 
            // dairesiComboBox
            // 
            dairesiComboBox.Anchor = AnchorStyles.None;
            dairesiComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            dairesiComboBox.FormattingEnabled = true;
            dairesiComboBox.Location = new Point(315, 95);
            dairesiComboBox.Name = "dairesiComboBox";
            dairesiComboBox.Size = new Size(172, 28);
            dairesiComboBox.TabIndex = 57;
            dairesiComboBox.SelectedIndexChanged += dairesiComboBox_SelectedIndexChanged;
            // 
            // yasiLabel
            // 
            yasiLabel.Anchor = AnchorStyles.None;
            yasiLabel.AutoSize = true;
            yasiLabel.Font = new Font("Verdana", 11F);
            yasiLabel.Location = new Point(77, 282);
            yasiLabel.Name = "yasiLabel";
            yasiLabel.Size = new Size(57, 23);
            yasiLabel.TabIndex = 56;
            yasiLabel.Text = "Yaşı:";
            // 
            // adiLabel
            // 
            adiLabel.Anchor = AnchorStyles.None;
            adiLabel.AutoSize = true;
            adiLabel.Font = new Font("Verdana", 11F);
            adiLabel.Location = new Point(77, 217);
            adiLabel.Name = "adiLabel";
            adiLabel.Size = new Size(50, 23);
            adiLabel.TabIndex = 52;
            adiLabel.Text = "Adı:";
            // 
            // yeniKayitLabel
            // 
            yeniKayitLabel.Anchor = AnchorStyles.None;
            yeniKayitLabel.AutoSize = true;
            yeniKayitLabel.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold);
            yeniKayitLabel.Location = new Point(278, 28);
            yeniKayitLabel.Name = "yeniKayitLabel";
            yeniKayitLabel.Size = new Size(158, 40);
            yeniKayitLabel.TabIndex = 51;
            yeniKayitLabel.Text = "Ödeme Al";
            // 
            // soyadiLabel
            // 
            soyadiLabel.Anchor = AnchorStyles.None;
            soyadiLabel.AutoSize = true;
            soyadiLabel.Font = new Font("Verdana", 11F);
            soyadiLabel.Location = new Point(77, 250);
            soyadiLabel.Name = "soyadiLabel";
            soyadiLabel.Size = new Size(84, 23);
            soyadiLabel.TabIndex = 53;
            soyadiLabel.Text = "Soyadı:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-4, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 452);
            pictureBox2.TabIndex = 70;
            pictureBox2.TabStop = false;
            // 
            // OdemeYonetimForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 450);
            Controls.Add(pictureBox2);
            Controls.Add(odemeYonetimTab);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "OdemeYonetimForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OdemeYonetimForm";
            Load += OdemeYonetimForm_Load;
            MouseDown += OdemeYonetimForm_MouseDown;
            odemeYonetimTab.ResumeLayout(false);
            odemeListesiTabPage.ResumeLayout(false);
            odemeListesiTabPage.PerformLayout();
            odemeAlTab.ResumeLayout(false);
            odemeAlTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl odemeYonetimTab;
        private TabPage odemeListesiTabPage;
        private TabPage odemeAlTab;
        private TextBox tcsiTextBox;
        private TextBox yasiTextBox;
        private Label tcLabel;
        private Label label1;
        private TextBox soyadiTextBox;
        private TextBox adiTextBox;
        private Button odemeAlButton;
        private ComboBox dairesiComboBox;
        private Label yasiLabel;
        private Label adiLabel;
        private Label yeniKayitLabel;
        private Label soyadiLabel;
        private Label odemeDegerTextBox;
        private Label label6;
        private TextBox kalanBorcTextBox;
        private ToolTip toolTip1;
        private MaskedTextBox tutarTextBox;
        private Label odemeYokLabel;
        private Label odemelerLabel;
        private ListBox odemelerListBox;
        private Button odemeSilButton;
        private Button odemeDuzenleButton;
        private ErrorProvider errorProvider1;
        private Button yenileButton;
        private Button geriButton;
        private PictureBox pictureBox2;
        private Button button2;
    }
}
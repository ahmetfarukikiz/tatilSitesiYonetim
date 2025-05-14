namespace _ndp_proje_yariyil2;

partial class KisiYonetimForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KisiYonetimForm));
        yeniKayitLabel = new Label();
        label5 = new Label();
        yasiTextBox = new MaskedTextBox();
        label3 = new Label();
        kisiEkleButton = new Button();
        label4 = new Label();
        dairesiComboBox = new ComboBox();
        tabControl1 = new TabControl();
        kisiTabPage = new TabPage();
        geriButton1 = new Button();
        tipButton = new Button();
        daireNoButton = new Button();
        tcButton = new Button();
        yasButton = new Button();
        adButton = new Button();
        kisiYokLabel = new Label();
        label6 = new Label();
        kisiGörButton = new Button();
        kisilerListBox = new ListBox();
        kisiSilButton = new Button();
        kisiDuzenleButton = new Button();
        kayitTabPage = new TabPage();
        tcLabel = new Label();
        tcsiTextBox = new MaskedTextBox();
        label2 = new Label();
        misafirRadioBtn = new RadioButton();
        aileReisiRadioBtn = new RadioButton();
        label1 = new Label();
        soyadiTextBox = new TextBox();
        adiTextBox = new TextBox();
        errorProvider1 = new ErrorProvider(components);
        pictureBox2 = new PictureBox();
        button2 = new Button();
        tabControl1.SuspendLayout();
        kisiTabPage.SuspendLayout();
        kayitTabPage.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        SuspendLayout();
        // 
        // yeniKayitLabel
        // 
        yeniKayitLabel.Anchor = AnchorStyles.None;
        yeniKayitLabel.AutoSize = true;
        yeniKayitLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        yeniKayitLabel.ForeColor = Color.FromArgb(25, 50, 90);
        yeniKayitLabel.Location = new Point(176, 24);
        yeniKayitLabel.Name = "yeniKayitLabel";
        yeniKayitLabel.Size = new Size(149, 35);
        yeniKayitLabel.TabIndex = 34;
        yeniKayitLabel.Text = "Yeni Kayıt";
        // 
        // label5
        // 
        label5.Anchor = AnchorStyles.None;
        label5.AutoSize = true;
        label5.Font = new Font("Franklin Gothic Book", 13F);
        label5.ForeColor = Color.FromArgb(25, 50, 90);
        label5.Location = new Point(176, 166);
        label5.Name = "label5";
        label5.Size = new Size(56, 28);
        label5.TabIndex = 41;
        label5.Text = "Yaşı:";
        // 
        // yasiTextBox
        // 
        yasiTextBox.Anchor = AnchorStyles.None;
        yasiTextBox.Location = new Point(309, 169);
        yasiTextBox.Mask = "000";
        yasiTextBox.Name = "yasiTextBox";
        yasiTextBox.Size = new Size(171, 27);
        yasiTextBox.SkipLiterals = false;
        yasiTextBox.TabIndex = 40;
        yasiTextBox.ValidatingType = typeof(int);
        yasiTextBox.MouseClick += textBoxMouseClickEvent;
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.None;
        label3.AutoSize = true;
        label3.Font = new Font("Franklin Gothic Book", 13F);
        label3.ForeColor = Color.FromArgb(25, 50, 90);
        label3.Location = new Point(176, 84);
        label3.Name = "label3";
        label3.Size = new Size(47, 28);
        label3.TabIndex = 36;
        label3.Text = "Adı:";
        // 
        // kisiEkleButton
        // 
        kisiEkleButton.Anchor = AnchorStyles.None;
        kisiEkleButton.Cursor = Cursors.Hand;
        kisiEkleButton.Font = new Font("Segoe UI", 12F);
        kisiEkleButton.ForeColor = Color.FromArgb(25, 50, 90);
        kisiEkleButton.Location = new Point(175, 341);
        kisiEkleButton.Name = "kisiEkleButton";
        kisiEkleButton.Size = new Size(305, 45);
        kisiEkleButton.TabIndex = 39;
        kisiEkleButton.Text = "Kayıt Et";
        kisiEkleButton.UseVisualStyleBackColor = true;
        kisiEkleButton.Click += kisiEkleButton_Click;
        // 
        // label4
        // 
        label4.Anchor = AnchorStyles.None;
        label4.AutoSize = true;
        label4.Font = new Font("Franklin Gothic Book", 13F);
        label4.ForeColor = Color.FromArgb(25, 50, 90);
        label4.Location = new Point(176, 126);
        label4.Name = "label4";
        label4.Size = new Size(80, 28);
        label4.TabIndex = 38;
        label4.Text = "Soyadı:";
        // 
        // dairesiComboBox
        // 
        dairesiComboBox.Anchor = AnchorStyles.None;
        dairesiComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        dairesiComboBox.FormattingEnabled = true;
        dairesiComboBox.Location = new Point(308, 253);
        dairesiComboBox.Name = "dairesiComboBox";
        dairesiComboBox.Size = new Size(172, 28);
        dairesiComboBox.TabIndex = 42;
        dairesiComboBox.SelectedIndexChanged += dairesiComboBox_SelectedIndexChanged;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(kisiTabPage);
        tabControl1.Controls.Add(kayitTabPage);
        tabControl1.Location = new Point(21, 0);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(703, 450);
        tabControl1.TabIndex = 43;
        // 
        // kisiTabPage
        // 
        kisiTabPage.BackColor = SystemColors.Window;
        kisiTabPage.Controls.Add(geriButton1);
        kisiTabPage.Controls.Add(tipButton);
        kisiTabPage.Controls.Add(daireNoButton);
        kisiTabPage.Controls.Add(tcButton);
        kisiTabPage.Controls.Add(yasButton);
        kisiTabPage.Controls.Add(adButton);
        kisiTabPage.Controls.Add(kisiYokLabel);
        kisiTabPage.Controls.Add(label6);
        kisiTabPage.Controls.Add(kisiGörButton);
        kisiTabPage.Controls.Add(kisilerListBox);
        kisiTabPage.Controls.Add(kisiSilButton);
        kisiTabPage.Controls.Add(kisiDuzenleButton);
        kisiTabPage.Location = new Point(4, 29);
        kisiTabPage.Name = "kisiTabPage";
        kisiTabPage.Padding = new Padding(3);
        kisiTabPage.Size = new Size(695, 417);
        kisiTabPage.TabIndex = 0;
        kisiTabPage.Text = "   Kişi Listesi   ";
        // 
        // geriButton1
        // 
        geriButton1.BackColor = Color.Transparent;
        geriButton1.BackgroundImage = (Image)resources.GetObject("geriButton1.BackgroundImage");
        geriButton1.BackgroundImageLayout = ImageLayout.Stretch;
        geriButton1.Cursor = Cursors.Hand;
        geriButton1.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
        geriButton1.FlatAppearance.BorderSize = 0;
        geriButton1.FlatStyle = FlatStyle.Flat;
        geriButton1.Location = new Point(10, 12);
        geriButton1.Name = "geriButton1";
        geriButton1.Size = new Size(32, 32);
        geriButton1.TabIndex = 69;
        geriButton1.UseVisualStyleBackColor = false;
        geriButton1.Click += geriButton_Click;
        // 
        // tipButton
        // 
        tipButton.Anchor = AnchorStyles.None;
        tipButton.FlatAppearance.BorderSize = 0;
        tipButton.FlatStyle = FlatStyle.Flat;
        tipButton.ForeColor = Color.FromArgb(45, 70, 120);
        tipButton.Location = new Point(504, 92);
        tipButton.Name = "tipButton";
        tipButton.Size = new Size(53, 29);
        tipButton.TabIndex = 34;
        tipButton.Text = "Tip";
        tipButton.UseVisualStyleBackColor = true;
        tipButton.Click += tipButton_Click;
        // 
        // daireNoButton
        // 
        daireNoButton.Anchor = AnchorStyles.None;
        daireNoButton.FlatAppearance.BorderSize = 0;
        daireNoButton.FlatStyle = FlatStyle.Flat;
        daireNoButton.ForeColor = Color.FromArgb(45, 70, 120);
        daireNoButton.Location = new Point(404, 92);
        daireNoButton.Name = "daireNoButton";
        daireNoButton.Size = new Size(85, 29);
        daireNoButton.TabIndex = 33;
        daireNoButton.Text = "Daire No";
        daireNoButton.UseVisualStyleBackColor = true;
        daireNoButton.Click += daireNoButton_Click;
        // 
        // tcButton
        // 
        tcButton.Anchor = AnchorStyles.None;
        tcButton.FlatAppearance.BorderSize = 0;
        tcButton.FlatStyle = FlatStyle.Flat;
        tcButton.ForeColor = Color.FromArgb(45, 70, 120);
        tcButton.Location = new Point(292, 92);
        tcButton.Name = "tcButton";
        tcButton.Size = new Size(78, 29);
        tcButton.TabIndex = 32;
        tcButton.Text = "TC No";
        tcButton.UseVisualStyleBackColor = true;
        tcButton.Click += tcButton_Click;
        // 
        // yasButton
        // 
        yasButton.Anchor = AnchorStyles.None;
        yasButton.FlatAppearance.BorderSize = 0;
        yasButton.FlatStyle = FlatStyle.Flat;
        yasButton.ForeColor = Color.FromArgb(45, 70, 120);
        yasButton.Location = new Point(230, 92);
        yasButton.Name = "yasButton";
        yasButton.Size = new Size(56, 29);
        yasButton.TabIndex = 31;
        yasButton.Text = "Yaş";
        yasButton.UseVisualStyleBackColor = true;
        yasButton.Click += yasButton_Click;
        // 
        // adButton
        // 
        adButton.Anchor = AnchorStyles.None;
        adButton.FlatAppearance.BorderSize = 0;
        adButton.FlatStyle = FlatStyle.Flat;
        adButton.ForeColor = Color.FromArgb(45, 70, 120);
        adButton.Location = new Point(85, 92);
        adButton.Name = "adButton";
        adButton.Size = new Size(94, 29);
        adButton.TabIndex = 30;
        adButton.Text = "Adı Soyadı";
        adButton.UseVisualStyleBackColor = true;
        adButton.Click += adButton_Click;
        // 
        // kisiYokLabel
        // 
        kisiYokLabel.Anchor = AnchorStyles.None;
        kisiYokLabel.AutoSize = true;
        kisiYokLabel.BackColor = Color.White;
        kisiYokLabel.Font = new Font("Segoe UI Emoji", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
        kisiYokLabel.ForeColor = Color.FromArgb(65, 90, 140);
        kisiYokLabel.Location = new Point(181, 212);
        kisiYokLabel.Name = "kisiYokLabel";
        kisiYokLabel.Size = new Size(308, 38);
        kisiYokLabel.TabIndex = 29;
        kisiYokLabel.Text = "Hiç Kayıt Bulunamadı";
        kisiYokLabel.Visible = false;
        // 
        // label6
        // 
        label6.Anchor = AnchorStyles.None;
        label6.AutoSize = true;
        label6.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
        label6.ForeColor = Color.FromArgb(25, 50, 90);
        label6.Location = new Point(85, 45);
        label6.Name = "label6";
        label6.Size = new Size(124, 29);
        label6.TabIndex = 25;
        label6.Text = "Kayıtlılar:";
        // 
        // kisiGörButton
        // 
        kisiGörButton.Anchor = AnchorStyles.None;
        kisiGörButton.Cursor = Cursors.Hand;
        kisiGörButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
        kisiGörButton.ForeColor = Color.FromArgb(25, 50, 90);
        kisiGörButton.Location = new Point(85, 360);
        kisiGörButton.Name = "kisiGörButton";
        kisiGörButton.Size = new Size(109, 40);
        kisiGörButton.TabIndex = 24;
        kisiGörButton.Text = "Görüntüle";
        kisiGörButton.UseVisualStyleBackColor = true;
        kisiGörButton.Visible = false;
        // 
        // kisilerListBox
        // 
        kisilerListBox.Anchor = AnchorStyles.None;
        kisilerListBox.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
        kisilerListBox.ForeColor = Color.FromArgb(15, 40, 70);
        kisilerListBox.FormattingEnabled = true;
        kisilerListBox.Location = new Point(85, 127);
        kisilerListBox.Name = "kisilerListBox";
        kisilerListBox.Size = new Size(517, 220);
        kisilerListBox.TabIndex = 28;
        kisilerListBox.SelectedIndexChanged += kisilerListBox_SelectedIndexChanged;
        // 
        // kisiSilButton
        // 
        kisiSilButton.Anchor = AnchorStyles.None;
        kisiSilButton.Cursor = Cursors.Hand;
        kisiSilButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
        kisiSilButton.ForeColor = Color.FromArgb(25, 50, 90);
        kisiSilButton.Location = new Point(518, 360);
        kisiSilButton.Name = "kisiSilButton";
        kisiSilButton.Size = new Size(85, 40);
        kisiSilButton.TabIndex = 26;
        kisiSilButton.Text = "Sil";
        kisiSilButton.UseVisualStyleBackColor = true;
        kisiSilButton.Click += kisiSilButton_Click;
        // 
        // kisiDuzenleButton
        // 
        kisiDuzenleButton.Anchor = AnchorStyles.None;
        kisiDuzenleButton.Cursor = Cursors.Hand;
        kisiDuzenleButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
        kisiDuzenleButton.ForeColor = Color.FromArgb(25, 50, 90);
        kisiDuzenleButton.Location = new Point(427, 360);
        kisiDuzenleButton.Name = "kisiDuzenleButton";
        kisiDuzenleButton.Size = new Size(85, 40);
        kisiDuzenleButton.TabIndex = 27;
        kisiDuzenleButton.Text = "Düzenle";
        kisiDuzenleButton.UseVisualStyleBackColor = true;
        kisiDuzenleButton.Click += kisiDuzenleButton_Click;
        // 
        // kayitTabPage
        // 
        kayitTabPage.Controls.Add(button2);
        kayitTabPage.Controls.Add(tcLabel);
        kayitTabPage.Controls.Add(tcsiTextBox);
        kayitTabPage.Controls.Add(label2);
        kayitTabPage.Controls.Add(misafirRadioBtn);
        kayitTabPage.Controls.Add(aileReisiRadioBtn);
        kayitTabPage.Controls.Add(label1);
        kayitTabPage.Controls.Add(soyadiTextBox);
        kayitTabPage.Controls.Add(adiTextBox);
        kayitTabPage.Controls.Add(kisiEkleButton);
        kayitTabPage.Controls.Add(dairesiComboBox);
        kayitTabPage.Controls.Add(label5);
        kayitTabPage.Controls.Add(label3);
        kayitTabPage.Controls.Add(yeniKayitLabel);
        kayitTabPage.Controls.Add(yasiTextBox);
        kayitTabPage.Controls.Add(label4);
        kayitTabPage.Location = new Point(4, 29);
        kayitTabPage.Name = "kayitTabPage";
        kayitTabPage.Padding = new Padding(3);
        kayitTabPage.Size = new Size(695, 417);
        kayitTabPage.TabIndex = 1;
        kayitTabPage.Text = "   Yeni Kayıt   ";
        kayitTabPage.UseVisualStyleBackColor = true;
        // 
        // tcLabel
        // 
        tcLabel.Anchor = AnchorStyles.None;
        tcLabel.AutoSize = true;
        tcLabel.Font = new Font("Franklin Gothic Book", 13F);
        tcLabel.ForeColor = Color.FromArgb(25, 50, 90);
        tcLabel.Location = new Point(176, 209);
        tcLabel.Name = "tcLabel";
        tcLabel.Size = new Size(73, 28);
        tcLabel.TabIndex = 50;
        tcLabel.Text = "TC No:";
        // 
        // tcsiTextBox
        // 
        tcsiTextBox.Anchor = AnchorStyles.None;
        tcsiTextBox.Location = new Point(309, 212);
        tcsiTextBox.Mask = "00000000000";
        tcsiTextBox.Name = "tcsiTextBox";
        tcsiTextBox.Size = new Size(171, 27);
        tcsiTextBox.SkipLiterals = false;
        tcsiTextBox.TabIndex = 49;
        tcsiTextBox.ValidatingType = typeof(int);
        tcsiTextBox.MouseClick += textBoxMouseClickEvent;
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.None;
        label2.AutoSize = true;
        label2.Font = new Font("Franklin Gothic Book", 13F);
        label2.ForeColor = Color.FromArgb(25, 50, 90);
        label2.Location = new Point(176, 296);
        label2.Name = "label2";
        label2.Size = new Size(121, 28);
        label2.TabIndex = 48;
        label2.Text = "Oturan Tipi:";
        // 
        // misafirRadioBtn
        // 
        misafirRadioBtn.Anchor = AnchorStyles.None;
        misafirRadioBtn.AutoSize = true;
        misafirRadioBtn.ForeColor = Color.FromArgb(25, 50, 90);
        misafirRadioBtn.Location = new Point(398, 300);
        misafirRadioBtn.Name = "misafirRadioBtn";
        misafirRadioBtn.Size = new Size(75, 24);
        misafirRadioBtn.TabIndex = 47;
        misafirRadioBtn.TabStop = true;
        misafirRadioBtn.Text = "Misafir";
        misafirRadioBtn.UseVisualStyleBackColor = true;
        misafirRadioBtn.CheckedChanged += misafirRadioBtn_CheckedChanged;
        // 
        // aileReisiRadioBtn
        // 
        aileReisiRadioBtn.Anchor = AnchorStyles.None;
        aileReisiRadioBtn.AutoSize = true;
        aileReisiRadioBtn.ForeColor = Color.FromArgb(25, 50, 90);
        aileReisiRadioBtn.Location = new Point(308, 300);
        aileReisiRadioBtn.Name = "aileReisiRadioBtn";
        aileReisiRadioBtn.Size = new Size(91, 24);
        aileReisiRadioBtn.TabIndex = 46;
        aileReisiRadioBtn.TabStop = true;
        aileReisiRadioBtn.Text = "Aile Reisi";
        aileReisiRadioBtn.UseVisualStyleBackColor = true;
        aileReisiRadioBtn.CheckedChanged += aileReisiRadioBtn_CheckedChanged;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.None;
        label1.AutoSize = true;
        label1.Font = new Font("Franklin Gothic Book", 13F);
        label1.ForeColor = Color.FromArgb(25, 50, 90);
        label1.Location = new Point(175, 250);
        label1.Name = "label1";
        label1.Size = new Size(82, 28);
        label1.TabIndex = 45;
        label1.Text = "Dairesi:";
        // 
        // soyadiTextBox
        // 
        soyadiTextBox.Anchor = AnchorStyles.None;
        soyadiTextBox.Location = new Point(309, 125);
        soyadiTextBox.Name = "soyadiTextBox";
        soyadiTextBox.Size = new Size(171, 27);
        soyadiTextBox.TabIndex = 44;
        // 
        // adiTextBox
        // 
        adiTextBox.Anchor = AnchorStyles.None;
        adiTextBox.Location = new Point(309, 83);
        adiTextBox.Name = "adiTextBox";
        adiTextBox.Size = new Size(171, 27);
        adiTextBox.TabIndex = 43;
        // 
        // errorProvider1
        // 
        errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        errorProvider1.ContainerControl = this;
        // 
        // pictureBox2
        // 
        pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
        pictureBox2.Location = new Point(-4, -7);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(29, 464);
        pictureBox2.TabIndex = 71;
        pictureBox2.TabStop = false;
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
        button2.Location = new Point(9, 10);
        button2.Name = "button2";
        button2.Size = new Size(32, 32);
        button2.TabIndex = 108;
        button2.UseVisualStyleBackColor = false;
        button2.Click += geriButton_Click;
        // 
        // KisiYonetimForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(723, 450);
        Controls.Add(pictureBox2);
        Controls.Add(tabControl1);
        FormBorderStyle = FormBorderStyle.None;
        MaximizeBox = false;
        Name = "KisiYonetimForm";
        StartPosition = FormStartPosition.CenterScreen;
        Load += KisiYonetimForm_Load;
        MouseDown += KisiYonetimForm_MouseDown;
        tabControl1.ResumeLayout(false);
        kisiTabPage.ResumeLayout(false);
        kisiTabPage.PerformLayout();
        kayitTabPage.ResumeLayout(false);
        kayitTabPage.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Label yeniKayitLabel;
    private Label label5;
    private MaskedTextBox NoTextBox;
    private MaskedTextBox yasiTextBox;
    private Label label3;
    private Button kisiEkleButton;
    private MaskedTextBox AlanTextBox;
    private Label label4;
    private ComboBox dairesiComboBox;
    private TabControl tabControl1;
    private TabPage kisiTabPage;
    private TabPage kayitTabPage;
    private Label label1;
    private TextBox soyadiTextBox;
    private TextBox adiTextBox;
    private RadioButton misafirRadioBtn;
    private RadioButton aileReisiRadioBtn;
    private Label label2;
    private Label kisiYokLabel;
    private Label label6;
    private ListBox kisilerListBox;
    private Button kisiSilButton;
    private Button kisiDuzenleButton;
    private Label tcLabel;
    private MaskedTextBox tcsiTextBox;
    private ErrorProvider errorProvider1;
    private Button tipButton;
    private Button daireNoButton;
    private Button tcButton;
    private Button yasButton;
    private Button adButton;
    private Button kisiGörButton;
    private Button geriButton1;
    private PictureBox pictureBox2;
    private Button button2;
}
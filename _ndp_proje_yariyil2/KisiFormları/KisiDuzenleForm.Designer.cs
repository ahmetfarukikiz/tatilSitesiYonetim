namespace _ndp_proje_yariyil2;

partial class KisiDuzenleForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KisiDuzenleForm));
        tcLabel = new Label();
        tcsiTextBox = new MaskedTextBox();
        label2 = new Label();
        misafirRadioBtn = new RadioButton();
        aileReisiRadioBtn = new RadioButton();
        label1 = new Label();
        soyadiTextBox = new TextBox();
        adiTextBox = new TextBox();
        kisiDuzenleButton = new Button();
        dairesiComboBox = new ComboBox();
        label5 = new Label();
        label3 = new Label();
        kisiDuzenleLabel = new Label();
        yasiTextBox = new MaskedTextBox();
        label4 = new Label();
        duzenleniyorLabel = new Label();
        geriButton = new Button();
        errorProvider1 = new ErrorProvider(components);
        toolTip1 = new ToolTip(components);
        ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
        SuspendLayout();
        // 
        // tcLabel
        // 
        tcLabel.AutoSize = true;
        tcLabel.Font = new Font("Verdana", 13F);
        tcLabel.ForeColor = Color.FromArgb(25, 50, 90);
        tcLabel.Location = new Point(98, 231);
        tcLabel.Name = "tcLabel";
        tcLabel.Size = new Size(88, 26);
        tcLabel.TabIndex = 65;
        tcLabel.Text = "TC No:";
        // 
        // tcsiTextBox
        // 
        tcsiTextBox.ForeColor = Color.FromArgb(25, 50, 90);
        tcsiTextBox.Location = new Point(267, 235);
        tcsiTextBox.Mask = "00000000000";
        tcsiTextBox.Name = "tcsiTextBox";
        tcsiTextBox.ReadOnly = true;
        tcsiTextBox.Size = new Size(171, 27);
        tcsiTextBox.SkipLiterals = false;
        tcsiTextBox.TabIndex = 64;
        toolTip1.SetToolTip(tcsiTextBox, "TC No değiştirilemez");
        tcsiTextBox.ValidatingType = typeof(int);
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Verdana", 11F);
        label2.ForeColor = Color.FromArgb(25, 50, 90);
        label2.Location = new Point(97, 322);
        label2.Name = "label2";
        label2.Size = new Size(127, 23);
        label2.TabIndex = 63;
        label2.Text = "Oturan Tipi:";
        // 
        // misafirRadioBtn
        // 
        misafirRadioBtn.AutoSize = true;
        misafirRadioBtn.ForeColor = Color.FromArgb(25, 50, 90);
        misafirRadioBtn.Location = new Point(363, 322);
        misafirRadioBtn.Name = "misafirRadioBtn";
        misafirRadioBtn.Size = new Size(75, 24);
        misafirRadioBtn.TabIndex = 62;
        misafirRadioBtn.TabStop = true;
        misafirRadioBtn.Text = "Misafir";
        misafirRadioBtn.UseVisualStyleBackColor = true;
        // 
        // aileReisiRadioBtn
        // 
        aileReisiRadioBtn.AutoSize = true;
        aileReisiRadioBtn.ForeColor = Color.FromArgb(25, 50, 90);
        aileReisiRadioBtn.Location = new Point(273, 322);
        aileReisiRadioBtn.Name = "aileReisiRadioBtn";
        aileReisiRadioBtn.Size = new Size(91, 24);
        aileReisiRadioBtn.TabIndex = 61;
        aileReisiRadioBtn.TabStop = true;
        aileReisiRadioBtn.Text = "Aile Reisi";
        aileReisiRadioBtn.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Verdana", 13F);
        label1.ForeColor = Color.FromArgb(25, 50, 90);
        label1.Location = new Point(97, 272);
        label1.Name = "label1";
        label1.Size = new Size(151, 26);
        label1.TabIndex = 60;
        label1.Text = "Yeni Dairesi:";
        // 
        // soyadiTextBox
        // 
        soyadiTextBox.ForeColor = Color.FromArgb(25, 50, 90);
        soyadiTextBox.Location = new Point(267, 148);
        soyadiTextBox.Name = "soyadiTextBox";
        soyadiTextBox.Size = new Size(171, 27);
        soyadiTextBox.TabIndex = 59;
        // 
        // adiTextBox
        // 
        adiTextBox.ForeColor = Color.FromArgb(25, 50, 90);
        adiTextBox.Location = new Point(267, 106);
        adiTextBox.Name = "adiTextBox";
        adiTextBox.Size = new Size(171, 27);
        adiTextBox.TabIndex = 58;
        // 
        // kisiDuzenleButton
        // 
        kisiDuzenleButton.Cursor = Cursors.Hand;
        kisiDuzenleButton.Font = new Font("Segoe UI", 12F);
        kisiDuzenleButton.ForeColor = Color.FromArgb(25, 50, 90);
        kisiDuzenleButton.Location = new Point(97, 352);
        kisiDuzenleButton.Name = "kisiDuzenleButton";
        kisiDuzenleButton.Size = new Size(341, 45);
        kisiDuzenleButton.TabIndex = 54;
        kisiDuzenleButton.Text = "Düzenle";
        kisiDuzenleButton.UseVisualStyleBackColor = true;
        kisiDuzenleButton.Click += kisiDuzenleButton_Click;
        // 
        // dairesiComboBox
        // 
        dairesiComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        dairesiComboBox.ForeColor = Color.FromArgb(25, 50, 90);
        dairesiComboBox.FormattingEnabled = true;
        dairesiComboBox.Location = new Point(266, 276);
        dairesiComboBox.Name = "dairesiComboBox";
        dairesiComboBox.Size = new Size(172, 28);
        dairesiComboBox.TabIndex = 57;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Verdana", 13F);
        label5.ForeColor = Color.FromArgb(25, 50, 90);
        label5.Location = new Point(98, 188);
        label5.Name = "label5";
        label5.Size = new Size(112, 26);
        label5.TabIndex = 56;
        label5.Text = "Yeni Yaş:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Verdana", 13F);
        label3.ForeColor = Color.FromArgb(25, 50, 90);
        label3.Location = new Point(98, 106);
        label3.Name = "label3";
        label3.Size = new Size(105, 26);
        label3.TabIndex = 52;
        label3.Text = "Yeni Ad:";
        // 
        // kisiDuzenleLabel
        // 
        kisiDuzenleLabel.AutoSize = true;
        kisiDuzenleLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
        kisiDuzenleLabel.ForeColor = Color.FromArgb(25, 50, 90);
        kisiDuzenleLabel.Location = new Point(97, 38);
        kisiDuzenleLabel.Name = "kisiDuzenleLabel";
        kisiDuzenleLabel.Size = new Size(176, 35);
        kisiDuzenleLabel.TabIndex = 51;
        kisiDuzenleLabel.Text = "Kişi Düzenle";
        // 
        // yasiTextBox
        // 
        yasiTextBox.ForeColor = Color.FromArgb(25, 50, 90);
        yasiTextBox.Location = new Point(267, 192);
        yasiTextBox.Mask = "000";
        yasiTextBox.Name = "yasiTextBox";
        yasiTextBox.Size = new Size(171, 27);
        yasiTextBox.SkipLiterals = false;
        yasiTextBox.TabIndex = 55;
        yasiTextBox.ValidatingType = typeof(int);
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Verdana", 13F);
        label4.ForeColor = Color.FromArgb(25, 50, 90);
        label4.Location = new Point(98, 148);
        label4.Name = "label4";
        label4.Size = new Size(144, 26);
        label4.TabIndex = 53;
        label4.Text = "Yeni Soyad:";
        // 
        // duzenleniyorLabel
        // 
        duzenleniyorLabel.AutoSize = true;
        duzenleniyorLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        duzenleniyorLabel.ForeColor = Color.DimGray;
        duzenleniyorLabel.Location = new Point(12, 413);
        duzenleniyorLabel.Name = "duzenleniyorLabel";
        duzenleniyorLabel.Size = new Size(136, 20);
        duzenleniyorLabel.TabIndex = 66;
        duzenleniyorLabel.Text = "Kişisi düzenleniyor";
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
        geriButton.ForeColor = Color.Black;
        geriButton.Location = new Point(12, 12);
        geriButton.Name = "geriButton";
        geriButton.Size = new Size(32, 32);
        geriButton.TabIndex = 67;
        geriButton.UseVisualStyleBackColor = false;
        geriButton.Click += geriButton_Click;
        // 
        // errorProvider1
        // 
        errorProvider1.ContainerControl = this;
        // 
        // KisiDuzenleForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(230, 240, 250);
        ClientSize = new Size(520, 447);
        Controls.Add(geriButton);
        Controls.Add(duzenleniyorLabel);
        Controls.Add(tcLabel);
        Controls.Add(tcsiTextBox);
        Controls.Add(label2);
        Controls.Add(misafirRadioBtn);
        Controls.Add(aileReisiRadioBtn);
        Controls.Add(label1);
        Controls.Add(soyadiTextBox);
        Controls.Add(adiTextBox);
        Controls.Add(kisiDuzenleButton);
        Controls.Add(dairesiComboBox);
        Controls.Add(label5);
        Controls.Add(label3);
        Controls.Add(kisiDuzenleLabel);
        Controls.Add(yasiTextBox);
        Controls.Add(label4);
        ForeColor = SystemColors.Window;
        FormBorderStyle = FormBorderStyle.None;
        MaximizeBox = false;
        Name = "KisiDuzenleForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label tcLabel;
    private MaskedTextBox tcsiTextBox;
    private Label label2;
    private RadioButton misafirRadioBtn;
    private RadioButton aileReisiRadioBtn;
    private Label label1;
    private TextBox soyadiTextBox;
    private TextBox adiTextBox;
    private Button kisiDuzenleButton;
    private ComboBox dairesiComboBox;
    private Label label5;
    private Label label3;
    private Label kisiDuzenleLabel;
    private MaskedTextBox yasiTextBox;
    private Label label4;
    private Label duzenleniyorLabel;
    private Button geriButton;
    private ErrorProvider errorProvider1;
    private ToolTip toolTip1;
}
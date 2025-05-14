namespace _ndp_proje_yariyil2;

partial class DaireDuzenleForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DaireDuzenleForm));
        daireDuzenleLabel = new Label();
        label5 = new Label();
        daireNoTextBox = new MaskedTextBox();
        kisiSayisiTextBox = new MaskedTextBox();
        label3 = new Label();
        daireDuzenleButton = new Button();
        AlanTextBox = new MaskedTextBox();
        label4 = new Label();
        errorProvider1 = new ErrorProvider(components);
        duzenleniyorLabel = new Label();
        geriButton = new Button();
        ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
        SuspendLayout();
        // 
        // daireDuzenleLabel
        // 
        daireDuzenleLabel.AutoSize = true;
        daireDuzenleLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
        daireDuzenleLabel.ForeColor = Color.FromArgb(25, 50, 90);
        daireDuzenleLabel.Location = new Point(55, 61);
        daireDuzenleLabel.Name = "daireDuzenleLabel";
        daireDuzenleLabel.Size = new Size(192, 35);
        daireDuzenleLabel.TabIndex = 34;
        daireDuzenleLabel.Text = "Daire Düzenle";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Verdana", 13F);
        label5.Location = new Point(55, 214);
        label5.Name = "label5";
        label5.Size = new Size(186, 26);
        label5.TabIndex = 41;
        label5.Text = "Yeni Kişi Sayısı:";
        // 
        // daireNoTextBox
        // 
        daireNoTextBox.Location = new Point(255, 136);
        daireNoTextBox.Mask = "0000";
        daireNoTextBox.Name = "daireNoTextBox";
        daireNoTextBox.Size = new Size(131, 27);
        daireNoTextBox.SkipLiterals = false;
        daireNoTextBox.TabIndex = 35;
        daireNoTextBox.ValidatingType = typeof(int);
        daireNoTextBox.MouseClick += textBoxMouseClickEvent;
        // 
        // kisiSayisiTextBox
        // 
        kisiSayisiTextBox.Location = new Point(255, 217);
        kisiSayisiTextBox.Mask = "00";
        kisiSayisiTextBox.Name = "kisiSayisiTextBox";
        kisiSayisiTextBox.Size = new Size(132, 27);
        kisiSayisiTextBox.SkipLiterals = false;
        kisiSayisiTextBox.TabIndex = 40;
        kisiSayisiTextBox.ValidatingType = typeof(int);
        kisiSayisiTextBox.MouseClick += textBoxMouseClickEvent;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Verdana", 13F);
        label3.Location = new Point(55, 137);
        label3.Name = "label3";
        label3.Size = new Size(171, 26);
        label3.TabIndex = 36;
        label3.Text = "Yeni Daire No:";
        // 
        // daireDuzenleButton
        // 
        daireDuzenleButton.Cursor = Cursors.Hand;
        daireDuzenleButton.Font = new Font("Segoe UI", 12F);
        daireDuzenleButton.Location = new Point(55, 273);
        daireDuzenleButton.Name = "daireDuzenleButton";
        daireDuzenleButton.Size = new Size(331, 41);
        daireDuzenleButton.TabIndex = 39;
        daireDuzenleButton.Text = "Düzenle";
        daireDuzenleButton.UseVisualStyleBackColor = true;
        daireDuzenleButton.Click += daireDuzenleButton_Click;
        // 
        // AlanTextBox
        // 
        AlanTextBox.Location = new Point(255, 174);
        AlanTextBox.Mask = "00000";
        AlanTextBox.Name = "AlanTextBox";
        AlanTextBox.Size = new Size(131, 27);
        AlanTextBox.SkipLiterals = false;
        AlanTextBox.TabIndex = 37;
        AlanTextBox.ValidatingType = typeof(int);
        AlanTextBox.MouseClick += textBoxMouseClickEvent;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Verdana", 13F);
        label4.Location = new Point(55, 175);
        label4.Name = "label4";
        label4.Size = new Size(124, 26);
        label4.TabIndex = 38;
        label4.Text = "Yeni Alan:";
        // 
        // errorProvider1
        // 
        errorProvider1.ContainerControl = this;
        // 
        // duzenleniyorLabel
        // 
        duzenleniyorLabel.AutoSize = true;
        duzenleniyorLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        duzenleniyorLabel.ForeColor = Color.DimGray;
        duzenleniyorLabel.Location = new Point(265, 345);
        duzenleniyorLabel.Name = "duzenleniyorLabel";
        duzenleniyorLabel.Size = new Size(164, 20);
        duzenleniyorLabel.TabIndex = 42;
        duzenleniyorLabel.Text = "Daire 101 düzenleniyor";
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
        geriButton.Location = new Point(12, 12);
        geriButton.Name = "geriButton";
        geriButton.Size = new Size(32, 32);
        geriButton.TabIndex = 70;
        geriButton.UseVisualStyleBackColor = false;
        geriButton.Click += geriButton_Click;
        // 
        // DaireDuzenleForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(235, 240, 250);
        ClientSize = new Size(439, 377);
        Controls.Add(geriButton);
        Controls.Add(duzenleniyorLabel);
        Controls.Add(daireDuzenleLabel);
        Controls.Add(label5);
        Controls.Add(daireNoTextBox);
        Controls.Add(kisiSayisiTextBox);
        Controls.Add(label3);
        Controls.Add(daireDuzenleButton);
        Controls.Add(AlanTextBox);
        Controls.Add(label4);
        FormBorderStyle = FormBorderStyle.None;
        MaximizeBox = false;
        Name = "DaireDuzenleForm";
        StartPosition = FormStartPosition.CenterScreen;
        Load += DaireDuzenleForm_Load;
        ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label daireDuzenleLabel;
    private Label label5;
    private MaskedTextBox daireNoTextBox;
    private MaskedTextBox kisiSayisiTextBox;
    private Label label3;
    private Button daireDuzenleButton;
    private MaskedTextBox AlanTextBox;
    private Label label4;
    private ErrorProvider errorProvider1;
    private Label duzenleniyorLabel;
    private Button geriButton;
}
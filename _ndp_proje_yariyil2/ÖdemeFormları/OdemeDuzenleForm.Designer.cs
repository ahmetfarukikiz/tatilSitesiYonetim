namespace _ndp_proje_yariyil2.ÖdemeFormları
{
    partial class OdemeDuzenleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdemeDuzenleForm));
            geriButton = new Button();
            odemeDuzenleLabel = new Label();
            duzenleniyorLabel = new Label();
            tutarTextBox = new MaskedTextBox();
            kalanBorcTextBox = new TextBox();
            odemeDegerTextBox = new Label();
            label6 = new Label();
            odemeDuzenleButton = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
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
            geriButton.Size = new Size(29, 28);
            geriButton.TabIndex = 68;
            geriButton.UseVisualStyleBackColor = false;
            geriButton.Click += geriButton_Click;
            // 
            // odemeDuzenleLabel
            // 
            odemeDuzenleLabel.AutoSize = true;
            odemeDuzenleLabel.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold);
            odemeDuzenleLabel.ForeColor = Color.FromArgb(20, 50, 90);
            odemeDuzenleLabel.Location = new Point(87, 52);
            odemeDuzenleLabel.Name = "odemeDuzenleLabel";
            odemeDuzenleLabel.Size = new Size(245, 40);
            odemeDuzenleLabel.TabIndex = 69;
            odemeDuzenleLabel.Text = "Ödeme Düzenle";
            // 
            // duzenleniyorLabel
            // 
            duzenleniyorLabel.AutoSize = true;
            duzenleniyorLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            duzenleniyorLabel.ForeColor = Color.DimGray;
            duzenleniyorLabel.Location = new Point(12, 292);
            duzenleniyorLabel.Name = "duzenleniyorLabel";
            duzenleniyorLabel.Size = new Size(152, 20);
            duzenleniyorLabel.TabIndex = 70;
            duzenleniyorLabel.Text = "Ödeme düzenleniyor";
            // 
            // tutarTextBox
            // 
            tutarTextBox.ForeColor = Color.FromArgb(20, 50, 90);
            tutarTextBox.Location = new Point(216, 163);
            tutarTextBox.Mask = "00000.00";
            tutarTextBox.Name = "tutarTextBox";
            tutarTextBox.Size = new Size(139, 27);
            tutarTextBox.TabIndex = 77;
            // 
            // kalanBorcTextBox
            // 
            kalanBorcTextBox.Font = new Font("Segoe UI", 9F);
            kalanBorcTextBox.ForeColor = Color.FromArgb(20, 50, 90);
            kalanBorcTextBox.Location = new Point(216, 121);
            kalanBorcTextBox.Name = "kalanBorcTextBox";
            kalanBorcTextBox.ReadOnly = true;
            kalanBorcTextBox.Size = new Size(139, 27);
            kalanBorcTextBox.TabIndex = 76;
            // 
            // odemeDegerTextBox
            // 
            odemeDegerTextBox.AutoSize = true;
            odemeDegerTextBox.Font = new Font("Verdana", 11F);
            odemeDegerTextBox.ForeColor = Color.FromArgb(20, 50, 90);
            odemeDegerTextBox.Location = new Point(68, 152);
            odemeDegerTextBox.Name = "odemeDegerTextBox";
            odemeDegerTextBox.Size = new Size(133, 69);
            odemeDegerTextBox.TabIndex = 74;
            odemeDegerTextBox.Text = "Düzenlenmiş\r\nTutar:\r\n\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 11F);
            label6.ForeColor = Color.FromArgb(20, 50, 90);
            label6.Location = new Point(68, 120);
            label6.Name = "label6";
            label6.Size = new Size(121, 23);
            label6.TabIndex = 75;
            label6.Text = "Kalan Borç:";
            // 
            // odemeDuzenleButton
            // 
            odemeDuzenleButton.Cursor = Cursors.Hand;
            odemeDuzenleButton.Font = new Font("Segoe UI", 12F);
            odemeDuzenleButton.ForeColor = Color.FromArgb(20, 50, 90);
            odemeDuzenleButton.Location = new Point(68, 224);
            odemeDuzenleButton.Name = "odemeDuzenleButton";
            odemeDuzenleButton.Size = new Size(287, 37);
            odemeDuzenleButton.TabIndex = 73;
            odemeDuzenleButton.Text = "Ödemeyi Düzenle";
            odemeDuzenleButton.UseVisualStyleBackColor = true;
            odemeDuzenleButton.Click += odemeDuzenleButton_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // OdemeDuzenleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 240, 250);
            ClientSize = new Size(432, 321);
            Controls.Add(tutarTextBox);
            Controls.Add(kalanBorcTextBox);
            Controls.Add(odemeDegerTextBox);
            Controls.Add(label6);
            Controls.Add(odemeDuzenleButton);
            Controls.Add(duzenleniyorLabel);
            Controls.Add(odemeDuzenleLabel);
            Controls.Add(geriButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OdemeDuzenleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OdemeDuzenleForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button geriButton;
        private Label odemeDuzenleLabel;
        private Label duzenleniyorLabel;
        private MaskedTextBox tutarTextBox;
        private TextBox kalanBorcTextBox;
        private Label odemeDegerTextBox;
        private Label label6;
        private Button odemeDuzenleButton;
        private ErrorProvider errorProvider1;
    }
}
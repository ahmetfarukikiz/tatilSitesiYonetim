namespace _ndp_proje_yariyil2
{
    partial class AyarlarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AyarlarForm));
            label1 = new Label();
            label2 = new Label();
            kaydetButton = new Button();
            daireUcretiTextBox = new MaskedTextBox();
            errorProvider1 = new ErrorProvider(components);
            geriButton = new Button();
            kisiUcretiTextBox = new MaskedTextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = Color.FromArgb(20, 50, 90);
            label1.Location = new Point(67, 92);
            label1.Name = "label1";
            label1.Size = new Size(132, 30);
            label1.TabIndex = 0;
            label1.Text = "Daire Ücreti:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(10, 40, 70);
            label2.Location = new Point(138, 37);
            label2.Name = "label2";
            label2.Size = new Size(150, 40);
            label2.TabIndex = 2;
            label2.Text = "Ayarlar";
            // 
            // kaydetButton
            // 
            kaydetButton.Cursor = Cursors.Hand;
            kaydetButton.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kaydetButton.ForeColor = Color.FromArgb(20, 50, 90);
            kaydetButton.Location = new Point(114, 171);
            kaydetButton.Name = "kaydetButton";
            kaydetButton.Size = new Size(199, 33);
            kaydetButton.TabIndex = 3;
            kaydetButton.Text = "Kaydet";
            kaydetButton.UseVisualStyleBackColor = true;
            kaydetButton.Click += kaydetButton_Click;
            // 
            // daireUcretiTextBox
            // 
            daireUcretiTextBox.ForeColor = Color.FromArgb(20, 50, 90);
            daireUcretiTextBox.Location = new Point(229, 95);
            daireUcretiTextBox.Mask = "00000.00";
            daireUcretiTextBox.Name = "daireUcretiTextBox";
            daireUcretiTextBox.Size = new Size(125, 27);
            daireUcretiTextBox.TabIndex = 4;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
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
            geriButton.TabIndex = 108;
            geriButton.UseVisualStyleBackColor = false;
            geriButton.Click += geriButton_Click;
            // 
            // kisiUcretiTextBox
            // 
            kisiUcretiTextBox.ForeColor = Color.FromArgb(20, 50, 90);
            kisiUcretiTextBox.Location = new Point(229, 128);
            kisiUcretiTextBox.Mask = "00000.00";
            kisiUcretiTextBox.Name = "kisiUcretiTextBox";
            kisiUcretiTextBox.Size = new Size(125, 27);
            kisiUcretiTextBox.TabIndex = 110;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.ForeColor = Color.FromArgb(20, 50, 90);
            label3.Location = new Point(67, 125);
            label3.Name = "label3";
            label3.Size = new Size(113, 30);
            label3.TabIndex = 109;
            label3.Text = "Kişi Ücreti:";
            // 
            // AyarlarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(442, 248);
            Controls.Add(kisiUcretiTextBox);
            Controls.Add(label3);
            Controls.Add(geriButton);
            Controls.Add(daireUcretiTextBox);
            Controls.Add(kaydetButton);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "AyarlarForm";
            StartPosition = FormStartPosition.Manual;
            Text = "AyarlarForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button kaydetButton;
        private MaskedTextBox daireUcretiTextBox;
        private ErrorProvider errorProvider1;
        private Button geriButton;
        private MaskedTextBox kisiUcretiTextBox;
        private Label label3;
    }
}
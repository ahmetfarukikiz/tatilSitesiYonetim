namespace _ndp_proje_yariyil2
{
    partial class DaireGorForm
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
            label2 = new Label();
            geriButton = new Button();
            daireBosLabel = new Label();
            dairedeOturanlarListBox = new ListBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(25, 50, 90);
            label2.Location = new Point(378, 29);
            label2.Name = "label2";
            label2.Size = new Size(101, 33);
            label2.TabIndex = 18;
            label2.Text = "Daire 1";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // geriButton
            // 
            geriButton.BackColor = Color.Transparent;
            geriButton.Cursor = Cursors.Hand;
            geriButton.FlatAppearance.BorderSize = 0;
            geriButton.FlatStyle = FlatStyle.Flat;
            geriButton.ForeColor = Color.FromArgb(25, 50, 90);
            geriButton.Location = new Point(23, 23);
            geriButton.Name = "geriButton";
            geriButton.Size = new Size(40, 39);
            geriButton.TabIndex = 19;
            geriButton.Text = "<--";
            geriButton.UseVisualStyleBackColor = false;
            geriButton.Click += geriButton_Click;
            // 
            // daireBosLabel
            // 
            daireBosLabel.AutoSize = true;
            daireBosLabel.BackColor = Color.Transparent;
            daireBosLabel.Font = new Font("Segoe UI Variable Text Semibold", 20F, FontStyle.Bold);
            daireBosLabel.ForeColor = Color.FromArgb(25, 50, 90);
            daireBosLabel.Location = new Point(175, 183);
            daireBosLabel.Name = "daireBosLabel";
            daireBosLabel.Size = new Size(167, 46);
            daireBosLabel.TabIndex = 20;
            daireBosLabel.Text = "Daire Boş";
            daireBosLabel.Visible = false;
            // 
            // dairedeOturanlarListBox
            // 
            dairedeOturanlarListBox.BackColor = Color.FromArgb(230, 240, 250);
            dairedeOturanlarListBox.BorderStyle = BorderStyle.None;
            dairedeOturanlarListBox.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dairedeOturanlarListBox.ForeColor = Color.FromArgb(17, 37, 40);
            dairedeOturanlarListBox.FormattingEnabled = true;
            dairedeOturanlarListBox.Location = new Point(23, 85);
            dairedeOturanlarListBox.Name = "dairedeOturanlarListBox";
            dairedeOturanlarListBox.Size = new Size(470, 252);
            dairedeOturanlarListBox.TabIndex = 21;
            // 
            // DaireGorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(526, 368);
            ControlBox = false;
            Controls.Add(daireBosLabel);
            Controls.Add(geriButton);
            Controls.Add(label2);
            Controls.Add(dairedeOturanlarListBox);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "DaireGorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DaireDuzenleForm";
            Load += DaireGorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button geriButton;
        private Label daireBosLabel;
        private ListBox dairedeOturanlarListBox;
    }
}
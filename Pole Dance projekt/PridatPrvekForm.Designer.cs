namespace Pole_Dance_projekt
{
    partial class PridatPrvekForm
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
            tbNazev = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbInverted = new ComboBox();
            btnOK = new Button();
            btnCancel = new Button();
            cbObtiznost = new ComboBox();
            SuspendLayout();
            // 
            // tbNazev
            // 
            tbNazev.Location = new Point(63, 99);
            tbNazev.Name = "tbNazev";
            tbNazev.Size = new Size(125, 27);
            tbNazev.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 76);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 3;
            label1.Text = "Název";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 76);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 4;
            label2.Text = "Obtížnost";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 76);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 5;
            label3.Text = "Inverted?";
            // 
            // cbInverted
            // 
            cbInverted.FormattingEnabled = true;
            cbInverted.Items.AddRange(new object[] { "Yes", "No" });
            cbInverted.Location = new Point(351, 99);
            cbInverted.Name = "cbInverted";
            cbInverted.Size = new Size(151, 28);
            cbInverted.TabIndex = 6;
            cbInverted.SelectedIndexChanged += cbInverted_SelectedIndexChanged;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(440, 145);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 7;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(540, 145);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cbObtiznost
            // 
            cbObtiznost.FormattingEnabled = true;
            cbObtiznost.Items.AddRange(new object[] { "", "Beginner", "Intermediate", "Advanced" });
            cbObtiznost.Location = new Point(194, 99);
            cbObtiznost.Name = "cbObtiznost";
            cbObtiznost.Size = new Size(151, 28);
            cbObtiznost.TabIndex = 9;
            cbObtiznost.SelectedIndexChanged += cbObtiznost_SelectedIndexChanged;
            // 
            // PridatPrvekForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbObtiznost);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(cbInverted);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbNazev);
            Name = "PridatPrvekForm";
            Text = "Přidej prvek";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNazev;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbInverted;
        private Button btnOK;
        private Button btnCancel;
        private ComboBox cbObtiznost;
    }
}
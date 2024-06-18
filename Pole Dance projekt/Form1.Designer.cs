namespace Pole_Dance_projekt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbPrvky = new ComboBox();
            cbInverted = new CheckBox();
            NumericUpDown = new NumericUpDown();
            btnPotvrdit = new Button();
            lbNahodnePrvky = new ListBox();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // cbPrvky
            // 
            cbPrvky.FormattingEnabled = true;
            cbPrvky.Location = new Point(104, 135);
            cbPrvky.Name = "cbPrvky";
            cbPrvky.Size = new Size(151, 28);
            cbPrvky.TabIndex = 0;
            cbPrvky.Text = "Výběr obtížnosti";
            cbPrvky.SelectedIndexChanged += Form1_Load;
            // 
            // cbInverted
            // 
            cbInverted.AutoSize = true;
            cbInverted.Location = new Point(104, 180);
            cbInverted.Name = "cbInverted";
            cbInverted.Size = new Size(188, 24);
            cbInverted.TabIndex = 1;
            cbInverted.Text = "Zahrnout inverted prvky";
            cbInverted.UseVisualStyleBackColor = true;
            cbInverted.CheckedChanged += cbInverted_CheckedChanged;
            // 
            // NumericUpDown
            // 
            NumericUpDown.Location = new Point(102, 226);
            NumericUpDown.Name = "NumericUpDown";
            NumericUpDown.Size = new Size(150, 27);
            NumericUpDown.TabIndex = 2;
            // 
            // btnPotvrdit
            // 
            btnPotvrdit.Location = new Point(102, 281);
            btnPotvrdit.Name = "btnPotvrdit";
            btnPotvrdit.Size = new Size(94, 29);
            btnPotvrdit.TabIndex = 3;
            btnPotvrdit.Text = "Potvrdit";
            btnPotvrdit.UseVisualStyleBackColor = true;
            btnPotvrdit.Click += btnPotvrdit_Click;
            // 
            // lbNahodnePrvky
            // 
            lbNahodnePrvky.FormattingEnabled = true;
            lbNahodnePrvky.ItemHeight = 20;
            lbNahodnePrvky.Location = new Point(461, 135);
            lbNahodnePrvky.Name = "lbNahodnePrvky";
            lbNahodnePrvky.Size = new Size(150, 104);
            lbNahodnePrvky.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbNahodnePrvky);
            Controls.Add(btnPotvrdit);
            Controls.Add(NumericUpDown);
            Controls.Add(cbInverted);
            Controls.Add(cbPrvky);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)NumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbPrvky;
        private CheckBox cbInverted;
        private NumericUpDown NumericUpDown;
        private Button btnPotvrdit;
        private ListBox lbNahodnePrvky;
    }
}
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
            chbinverted = new CheckBox();
            nudpocet = new NumericUpDown();
            btPotvrzeni = new Button();
            lbNahodnePrvky = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nudpocet).BeginInit();
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
            cbPrvky.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // chbinverted
            // 
            chbinverted.AutoSize = true;
            chbinverted.Location = new Point(104, 180);
            chbinverted.Name = "chbinverted";
            chbinverted.Size = new Size(156, 24);
            chbinverted.TabIndex = 1;
            chbinverted.Text = "Zahrnout inverted?";
            chbinverted.UseVisualStyleBackColor = true;
            // 
            // nudpocet
            // 
            nudpocet.Location = new Point(102, 226);
            nudpocet.Name = "nudpocet";
            nudpocet.Size = new Size(150, 27);
            nudpocet.TabIndex = 2;
            // 
            // btPotvrzeni
            // 
            btPotvrzeni.Location = new Point(102, 281);
            btPotvrzeni.Name = "btPotvrzeni";
            btPotvrzeni.Size = new Size(94, 29);
            btPotvrzeni.TabIndex = 3;
            btPotvrzeni.Text = "Potvrdit";
            btPotvrzeni.UseVisualStyleBackColor = true;
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
            Controls.Add(btPotvrzeni);
            Controls.Add(nudpocet);
            Controls.Add(chbinverted);
            Controls.Add(cbPrvky);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudpocet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbPrvky;
        private CheckBox chbinverted;
        private NumericUpDown nudpocet;
        private Button btPotvrzeni;
        private ListBox lbNahodnePrvky;
    }
}
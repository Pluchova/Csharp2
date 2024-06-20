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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAdd = new Button();
            btnRemove = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // cbPrvky
            // 
            cbPrvky.FormattingEnabled = true;
            cbPrvky.Location = new Point(45, 57);
            cbPrvky.Name = "cbPrvky";
            cbPrvky.Size = new Size(151, 28);
            cbPrvky.TabIndex = 0;
            cbPrvky.Text = "Výběr obtížnosti";
            cbPrvky.SelectedIndexChanged += Form1_Load;
            // 
            // cbInverted
            // 
            cbInverted.AutoSize = true;
            cbInverted.Location = new Point(45, 91);
            cbInverted.Name = "cbInverted";
            cbInverted.Size = new Size(188, 24);
            cbInverted.TabIndex = 1;
            cbInverted.Text = "Zahrnout inverted prvky";
            cbInverted.UseVisualStyleBackColor = true;
            cbInverted.CheckedChanged += cbInverted_CheckedChanged;
            // 
            // NumericUpDown
            // 
            NumericUpDown.Location = new Point(45, 141);
            NumericUpDown.Name = "NumericUpDown";
            NumericUpDown.Size = new Size(150, 27);
            NumericUpDown.TabIndex = 2;
            // 
            // btnPotvrdit
            // 
            btnPotvrdit.Location = new Point(45, 174);
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
            lbNahodnePrvky.Location = new Point(258, 34);
            lbNahodnePrvky.Name = "lbNahodnePrvky";
            lbNahodnePrvky.Size = new Size(208, 264);
            lbNahodnePrvky.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 34);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 5;
            label1.Text = "Obtížnost";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 118);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 6;
            label2.Text = "Počet prvků";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 11);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 7;
            label3.Text = "Výpis prvků";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(540, 79);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Přidat";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(540, 114);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "Odstranit";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(540, 56);
            label4.Name = "label4";
            label4.Size = new Size(156, 20);
            label4.TabIndex = 11;
            label4.Text = "Správa seznamu prvků";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbNahodnePrvky);
            Controls.Add(btnPotvrdit);
            Controls.Add(NumericUpDown);
            Controls.Add(cbInverted);
            Controls.Add(cbPrvky);
            Name = "Form1";
            Text = "Pole Dance";
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAdd;
        private Button btnRemove;
        private Label label4;
    }
}
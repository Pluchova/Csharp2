namespace Pole_Dance_projekt
{
    partial class OdstranPrvky
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
            btnOkOdstran = new Button();
            btnCancelOdstran = new Button();
            label1 = new Label();
            tbOdstran = new TextBox();
            SuspendLayout();
            // 
            // btnOkOdstran
            // 
            btnOkOdstran.Location = new Point(282, 128);
            btnOkOdstran.Name = "btnOkOdstran";
            btnOkOdstran.Size = new Size(94, 29);
            btnOkOdstran.TabIndex = 0;
            btnOkOdstran.Text = "OK";
            btnOkOdstran.UseVisualStyleBackColor = true;
            btnOkOdstran.Click += btnOkOdstran_Click;
            // 
            // btnCancelOdstran
            // 
            btnCancelOdstran.Location = new Point(382, 128);
            btnCancelOdstran.Name = "btnCancelOdstran";
            btnCancelOdstran.Size = new Size(94, 29);
            btnCancelOdstran.TabIndex = 1;
            btnCancelOdstran.Text = "Cancel";
            btnCancelOdstran.UseVisualStyleBackColor = true;
            btnCancelOdstran.Click += btnCancelOdstran_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 55);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "Název";
            // 
            // tbOdstran
            // 
            tbOdstran.Location = new Point(174, 78);
            tbOdstran.Name = "tbOdstran";
            tbOdstran.Size = new Size(125, 27);
            tbOdstran.TabIndex = 3;
            // 
            // OdstranPrvky
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbOdstran);
            Controls.Add(label1);
            Controls.Add(btnCancelOdstran);
            Controls.Add(btnOkOdstran);
            Name = "OdstranPrvky";
            Text = "OdstranPrvky";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOkOdstran;
        private Button btnCancelOdstran;
        private Label label1;
        private TextBox tbOdstran;
    }
}
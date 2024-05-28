namespace WinFormsApp2
{
    partial class Form6
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
            calc = new Button();
            txtbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // calc
            // 
            calc.Location = new Point(136, 174);
            calc.Name = "calc";
            calc.Size = new Size(75, 23);
            calc.TabIndex = 0;
            calc.Text = "Compute";
            calc.UseVisualStyleBackColor = true;
            calc.Click += calc_Click;
            // 
            // txtbox
            // 
            txtbox.Location = new Point(126, 78);
            txtbox.Name = "txtbox";
            txtbox.Size = new Size(100, 23);
            txtbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 45);
            label1.Name = "label1";
            label1.Size = new Size(171, 21);
            label1.TabIndex = 2;
            label1.Text = "Computation Verifier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 81);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Product";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(352, 251);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtbox);
            Controls.Add(calc);
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calc;
        private TextBox txtbox;
        private Label label1;
        private Label label2;
    }
}
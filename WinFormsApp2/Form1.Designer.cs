namespace WinFormsApp2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Lab1 = new Button();
            Lab2 = new Button();
            Lab3 = new Button();
            Lab4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, -1);
            label1.Name = "label1";
            label1.Size = new Size(128, 32);
            label1.TabIndex = 0;
            label1.Text = "Members:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(172, 21);
            label2.TabIndex = 1;
            label2.Text = "Caldoza, Joshua Miro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 62);
            label3.Name = "label3";
            label3.Size = new Size(141, 21);
            label3.TabIndex = 2;
            label3.Text = "Elwa, Klient Ryan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 83);
            label4.Name = "label4";
            label4.Size = new Size(111, 21);
            label4.TabIndex = 3;
            label4.Text = "Cases, Kaizen";
            // 
            // Lab1
            // 
            Lab1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lab1.Location = new Point(226, 139);
            Lab1.Name = "Lab1";
            Lab1.Size = new Size(109, 55);
            Lab1.TabIndex = 4;
            Lab1.Text = "Lab1";
            Lab1.UseVisualStyleBackColor = true;
            Lab1.Click += Lab1_Click;
            // 
            // Lab2
            // 
            Lab2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lab2.Location = new Point(226, 232);
            Lab2.Name = "Lab2";
            Lab2.Size = new Size(109, 55);
            Lab2.TabIndex = 5;
            Lab2.Text = "Lab2";
            Lab2.UseVisualStyleBackColor = true;
            Lab2.Click += button2_Click;
            // 
            // Lab3
            // 
            Lab3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lab3.Location = new Point(473, 139);
            Lab3.Name = "Lab3";
            Lab3.Size = new Size(109, 55);
            Lab3.TabIndex = 6;
            Lab3.Text = "Lab3";
            Lab3.UseVisualStyleBackColor = true;
            Lab3.Click += Lab3_Click;
            // 
            // Lab4
            // 
            Lab4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lab4.Location = new Point(473, 232);
            Lab4.Name = "Lab4";
            Lab4.Size = new Size(109, 55);
            Lab4.TabIndex = 7;
            Lab4.Text = "Lab4";
            Lab4.UseVisualStyleBackColor = true;
            Lab4.Click += Lab4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(Lab4);
            Controls.Add(Lab3);
            Controls.Add(Lab2);
            Controls.Add(Lab1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MIS ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Lab1;
        private Button Lab2;
        private Button Lab3;
        private Button Lab4;
    }
}

namespace WinFormsApp2
{
    partial class Form4
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
            label1 = new Label();
            backbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(244, 25);
            label1.TabIndex = 0;
            label1.Text = "nothing to be seen here :3";
            // 
            // backbutton
            // 
            backbutton.Location = new Point(99, 110);
            backbutton.Name = "backbutton";
            backbutton.Size = new Size(71, 30);
            backbutton.TabIndex = 1;
            backbutton.Text = "Go Back";
            backbutton.UseVisualStyleBackColor = true;
            backbutton.Click += backbutton_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(268, 171);
            Controls.Add(backbutton);
            Controls.Add(label1);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab2.5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button backbutton;
    }
}
namespace WinFormsApp2
{
    partial class Form3
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
            textBox1 = new TextBox();
            ProceedButton = new Button();
            Displaybutton = new Button();
            Exitbutton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(76, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // ProceedButton
            // 
            ProceedButton.Location = new Point(49, 184);
            ProceedButton.Name = "ProceedButton";
            ProceedButton.Size = new Size(75, 23);
            ProceedButton.TabIndex = 1;
            ProceedButton.Text = "click me";
            ProceedButton.UseVisualStyleBackColor = true;
            ProceedButton.Click += ProceedButton_Click;
            // 
            // Displaybutton
            // 
            Displaybutton.Location = new Point(90, 155);
            Displaybutton.Name = "Displaybutton";
            Displaybutton.Size = new Size(75, 23);
            Displaybutton.TabIndex = 2;
            Displaybutton.Text = "Display";
            Displaybutton.UseVisualStyleBackColor = true;
            Displaybutton.Click += Displaybutton_Click;
            // 
            // Exitbutton
            // 
            Exitbutton.Location = new Point(130, 184);
            Exitbutton.Name = "Exitbutton";
            Exitbutton.Size = new Size(75, 23);
            Exitbutton.TabIndex = 3;
            Exitbutton.Text = "Exit";
            Exitbutton.UseVisualStyleBackColor = true;
            Exitbutton.Click += Exitbutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 53);
            label1.Name = "label1";
            label1.Size = new Size(138, 21);
            label1.TabIndex = 4;
            label1.Text = "Write your name";
            label1.Click += label1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(255, 266);
            Controls.Add(label1);
            Controls.Add(Exitbutton);
            Controls.Add(Displaybutton);
            Controls.Add(ProceedButton);
            Controls.Add(textBox1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab2";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button ProceedButton;
        private Button Displaybutton;
        private Button Exitbutton;
        private Label label1;
    }
}
namespace WinFormsApp2
{
    partial class Form5
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
            ComputeButton = new Button();
            LeaveButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // ComputeButton
            // 
            ComputeButton.Location = new Point(107, 251);
            ComputeButton.Name = "ComputeButton";
            ComputeButton.Size = new Size(75, 23);
            ComputeButton.TabIndex = 0;
            ComputeButton.Text = "Compute";
            ComputeButton.UseVisualStyleBackColor = true;
            ComputeButton.Click += ComputeButton_Click;
            // 
            // LeaveButton
            // 
            LeaveButton.Location = new Point(188, 251);
            LeaveButton.Name = "LeaveButton";
            LeaveButton.Size = new Size(75, 23);
            LeaveButton.TabIndex = 1;
            LeaveButton.Text = "Exit";
            LeaveButton.UseVisualStyleBackColor = true;
            LeaveButton.Click += LeaveButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 21);
            label1.Name = "label1";
            label1.Size = new Size(171, 21);
            label1.TabIndex = 2;
            label1.Text = "Computation Verifier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 68);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "1st Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 119);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 4;
            label3.Text = "2nd Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 172);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 5;
            label4.Text = "Sum:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(178, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(178, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(178, 169);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 8;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(370, 354);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LeaveButton);
            Controls.Add(ComputeButton);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab3";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ComputeButton;
        private Button LeaveButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
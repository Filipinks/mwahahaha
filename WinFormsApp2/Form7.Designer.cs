namespace WinFormsApp2
{
    partial class Form7
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
            averagegetter = new Button();
            outie = new Button();
            nametextbox = new TextBox();
            IDtextbox = new TextBox();
            comboBox1 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // averagegetter
            // 
            averagegetter.Location = new Point(76, 347);
            averagegetter.Name = "averagegetter";
            averagegetter.Size = new Size(75, 23);
            averagegetter.TabIndex = 0;
            averagegetter.Text = "Send";
            averagegetter.UseVisualStyleBackColor = true;
            averagegetter.Click += averagegetter_Click;
            // 
            // outie
            // 
            outie.Location = new Point(275, 347);
            outie.Name = "outie";
            outie.Size = new Size(75, 23);
            outie.TabIndex = 1;
            outie.Text = "Exit";
            outie.UseVisualStyleBackColor = true;
            // 
            // nametextbox
            // 
            nametextbox.Location = new Point(199, 111);
            nametextbox.Name = "nametextbox";
            nametextbox.Size = new Size(121, 23);
            nametextbox.TabIndex = 2;
            // 
            // IDtextbox
            // 
            IDtextbox.Location = new Point(199, 155);
            IDtextbox.Name = "IDtextbox";
            IDtextbox.Size = new Size(121, 23);
            IDtextbox.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Computer Science", "Political Science", "Architecture", "Engineering" });
            comboBox1.Location = new Point(199, 202);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(199, 248);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(31, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(236, 248);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(31, 19);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(131, 64);
            label1.Name = "label1";
            label1.Size = new Size(166, 21);
            label1.TabIndex = 7;
            label1.Text = "Student Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 111);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 8;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 155);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 9;
            label3.Text = "Student ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 202);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 10;
            label4.Text = "Department";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(109, 245);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 11;
            label5.Text = "Semester";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(428, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(comboBox1);
            Controls.Add(IDtextbox);
            Controls.Add(nametextbox);
            Controls.Add(outie);
            Controls.Add(averagegetter);
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button averagegetter;
        private Button outie;
        private TextBox nametextbox;
        private TextBox IDtextbox;
        private ComboBox comboBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
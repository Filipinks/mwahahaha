namespace WinFormsApp2
{
    partial class Form9
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
            nstpcombobox = new ComboBox();
            artappcombobox = new ComboBox();
            valuecombobox = new ComboBox();
            pecombobox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            Getthataverage = new Button();
            getmeout = new Button();
            SuspendLayout();
            // 
            // nstpcombobox
            // 
            nstpcombobox.FormattingEnabled = true;
            nstpcombobox.Items.AddRange(new object[] { "100", "99", "98", "97", "96", "95", "94", "93", "92", "91", "90", "89", "88", "87", "86", "85", "84", "83", "82", "81", "80", "79", "78", "77", "76", "75", "74", "73", "72", "71", "70", "69", "68", "67", "66", "65", "64", "63", "62", "61", "60", "59", "58", "57", "56", "55", "54", "53", "52", "51", "50" });
            nstpcombobox.Location = new Point(201, 150);
            nstpcombobox.Name = "nstpcombobox";
            nstpcombobox.Size = new Size(60, 23);
            nstpcombobox.TabIndex = 0;
            // 
            // artappcombobox
            // 
            artappcombobox.FormattingEnabled = true;
            artappcombobox.Items.AddRange(new object[] { "100", "99", "98", "97", "96", "95", "94", "93", "92", "91", "90", "89", "88", "87", "86", "85", "84", "83", "82", "81", "80", "79", "78", "77", "76", "75", "74", "73", "72", "71", "70", "69", "68", "67", "66", "65", "64", "63", "62", "61", "60", "59", "58", "57", "56", "55", "54", "53", "52", "51", "50" });
            artappcombobox.Location = new Point(201, 179);
            artappcombobox.Name = "artappcombobox";
            artappcombobox.Size = new Size(60, 23);
            artappcombobox.TabIndex = 1;
            // 
            // valuecombobox
            // 
            valuecombobox.FormattingEnabled = true;
            valuecombobox.Items.AddRange(new object[] { "100", "99", "98", "97", "96", "95", "94", "93", "92", "91", "90", "89", "88", "87", "86", "85", "84", "83", "82", "81", "80", "79", "78", "77", "76", "75", "74", "73", "72", "71", "70", "69", "68", "67", "66", "65", "64", "63", "62", "61", "60", "59", "58", "57", "56", "55", "54", "53", "52", "51", "50" });
            valuecombobox.Location = new Point(201, 208);
            valuecombobox.Name = "valuecombobox";
            valuecombobox.Size = new Size(60, 23);
            valuecombobox.TabIndex = 2;
            // 
            // pecombobox
            // 
            pecombobox.FormattingEnabled = true;
            pecombobox.Items.AddRange(new object[] { "100", "99", "98", "97", "96", "95", "94", "93", "92", "91", "90", "89", "88", "87", "86", "85", "84", "83", "82", "81", "80", "79", "78", "77", "76", "75", "74", "73", "72", "71", "70", "69", "68", "67", "66", "65", "64", "63", "62", "61", "60", "59", "58", "57", "56", "55", "54", "53", "52", "51", "50" });
            pecombobox.Location = new Point(201, 237);
            pecombobox.Name = "pecombobox";
            pecombobox.Size = new Size(60, 23);
            pecombobox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(138, 100);
            label1.Name = "label1";
            label1.Size = new Size(137, 21);
            label1.TabIndex = 4;
            label1.Text = "Grade Calculator";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 150);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 5;
            label2.Text = "NSTP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 179);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 7;
            label3.Text = "Art App";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 208);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 9;
            label4.Text = "Values";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(138, 237);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 11;
            label5.Text = "PE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(117, 284);
            label6.Name = "label6";
            label6.Size = new Size(122, 21);
            label6.TabIndex = 12;
            label6.Text = "Grade Average";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(245, 284);
            label7.Name = "label7";
            label7.Size = new Size(50, 21);
            label7.TabIndex = 13;
            label7.Text = "00.00";
            // 
            // Getthataverage
            // 
            Getthataverage.Location = new Point(117, 350);
            Getthataverage.Name = "Getthataverage";
            Getthataverage.Size = new Size(75, 23);
            Getthataverage.TabIndex = 14;
            Getthataverage.Text = "Calculate";
            Getthataverage.UseVisualStyleBackColor = true;
            Getthataverage.Click += Getthataverage_Click;
            // 
            // getmeout
            // 
            getmeout.Location = new Point(220, 350);
            getmeout.Name = "getmeout";
            getmeout.Size = new Size(75, 23);
            getmeout.TabIndex = 15;
            getmeout.Text = "Exit";
            getmeout.UseVisualStyleBackColor = true;
            getmeout.Click += getmeout_Click;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(413, 450);
            Controls.Add(getmeout);
            Controls.Add(Getthataverage);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pecombobox);
            Controls.Add(valuecombobox);
            Controls.Add(artappcombobox);
            Controls.Add(nstpcombobox);
            Name = "Form9";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox nstpcombobox;
        private ComboBox artappcombobox;
        private ComboBox valuecombobox;
        private ComboBox pecombobox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button Getthataverage;
        private Button getmeout;
    }
}
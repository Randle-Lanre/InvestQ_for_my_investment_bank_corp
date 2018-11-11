namespace InvestQ_for_my_investment_bank_corp
{
    partial class InvestQForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvestQForm));
            this.InvestAmountTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Month12RadioButton = new System.Windows.Forms.RadioButton();
            this.Month6RadioButton = new System.Windows.Forms.RadioButton();
            this.Month3RadioButton = new System.Windows.Forms.RadioButton();
            this.Month1RadioButton = new System.Windows.Forms.RadioButton();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.UserDetailsGB = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TransactionNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.ProceedButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TextOut = new System.Windows.Forms.Label();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TextOut2 = new System.Windows.Forms.Label();
            this.TextOut3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.UserDetailsGB.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InvestAmountTextBox
            // 
            this.InvestAmountTextBox.Location = new System.Drawing.Point(331, 118);
            this.InvestAmountTextBox.Name = "InvestAmountTextBox";
            this.InvestAmountTextBox.Size = new System.Drawing.Size(167, 20);
            this.InvestAmountTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Month12RadioButton);
            this.groupBox1.Controls.Add(this.Month6RadioButton);
            this.groupBox1.Controls.Add(this.Month3RadioButton);
            this.groupBox1.Controls.Add(this.Month1RadioButton);
            this.groupBox1.Location = new System.Drawing.Point(27, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 198);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Investment terms";
            // 
            // Month12RadioButton
            // 
            this.Month12RadioButton.AutoSize = true;
            this.Month12RadioButton.Location = new System.Drawing.Point(6, 145);
            this.Month12RadioButton.Name = "Month12RadioButton";
            this.Month12RadioButton.Size = new System.Drawing.Size(75, 17);
            this.Month12RadioButton.TabIndex = 3;
            this.Month12RadioButton.TabStop = true;
            this.Month12RadioButton.Text = "12 Months";
            this.Month12RadioButton.UseVisualStyleBackColor = true;
            // 
            // Month6RadioButton
            // 
            this.Month6RadioButton.AutoSize = true;
            this.Month6RadioButton.Location = new System.Drawing.Point(6, 111);
            this.Month6RadioButton.Name = "Month6RadioButton";
            this.Month6RadioButton.Size = new System.Drawing.Size(69, 17);
            this.Month6RadioButton.TabIndex = 2;
            this.Month6RadioButton.TabStop = true;
            this.Month6RadioButton.Text = "6 Months";
            this.Month6RadioButton.UseVisualStyleBackColor = true;
            // 
            // Month3RadioButton
            // 
            this.Month3RadioButton.AutoSize = true;
            this.Month3RadioButton.Location = new System.Drawing.Point(6, 70);
            this.Month3RadioButton.Name = "Month3RadioButton";
            this.Month3RadioButton.Size = new System.Drawing.Size(72, 17);
            this.Month3RadioButton.TabIndex = 1;
            this.Month3RadioButton.TabStop = true;
            this.Month3RadioButton.Text = "3 Months ";
            this.Month3RadioButton.UseVisualStyleBackColor = true;
            // 
            // Month1RadioButton
            // 
            this.Month1RadioButton.AutoSize = true;
            this.Month1RadioButton.Location = new System.Drawing.Point(6, 31);
            this.Month1RadioButton.Name = "Month1RadioButton";
            this.Month1RadioButton.Size = new System.Drawing.Size(64, 17);
            this.Month1RadioButton.TabIndex = 0;
            this.Month1RadioButton.TabStop = true;
            this.Month1RadioButton.Text = "1 Month";
            this.Month1RadioButton.UseVisualStyleBackColor = true;
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(359, 144);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(94, 26);
            this.DisplayButton.TabIndex = 2;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // UserDetailsGB
            // 
            this.UserDetailsGB.Controls.Add(this.label7);
            this.UserDetailsGB.Controls.Add(this.TransactionNumberTextBox);
            this.UserDetailsGB.Controls.Add(this.label3);
            this.UserDetailsGB.Controls.Add(this.label2);
            this.UserDetailsGB.Controls.Add(this.label1);
            this.UserDetailsGB.Controls.Add(this.EmailTextBox);
            this.UserDetailsGB.Controls.Add(this.PhoneNumberTextBox);
            this.UserDetailsGB.Controls.Add(this.NameTextBox);
            this.UserDetailsGB.Location = new System.Drawing.Point(253, 220);
            this.UserDetailsGB.Name = "UserDetailsGB";
            this.UserDetailsGB.Size = new System.Drawing.Size(287, 197);
            this.UserDetailsGB.TabIndex = 3;
            this.UserDetailsGB.TabStop = false;
            this.UserDetailsGB.Text = "User Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Trans Number:";
            // 
            // TransactionNumberTextBox
            // 
            this.TransactionNumberTextBox.Location = new System.Drawing.Point(77, 35);
            this.TransactionNumberTextBox.Name = "TransactionNumberTextBox";
            this.TransactionNumberTextBox.Size = new System.Drawing.Size(180, 20);
            this.TransactionNumberTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tel Num:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(78, 144);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(181, 20);
            this.EmailTextBox.TabIndex = 2;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(78, 107);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(181, 20);
            this.PhoneNumberTextBox.TabIndex = 1;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(78, 69);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(181, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(287, 405);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 6;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ProceedButton
            // 
            this.ProceedButton.Location = new System.Drawing.Point(49, 405);
            this.ProceedButton.Name = "ProceedButton";
            this.ProceedButton.Size = new System.Drawing.Size(75, 23);
            this.ProceedButton.TabIndex = 7;
            this.ProceedButton.Text = "Proceed ";
            this.ProceedButton.UseVisualStyleBackColor = true;
            this.ProceedButton.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Location = new System.Drawing.Point(566, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 95);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Transaction History ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(78, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Find my transactions ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(65, 32);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(163, 20);
            this.textBox5.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TextOut3);
            this.groupBox4.Controls.Add(this.TextOut2);
            this.groupBox4.Controls.Add(this.TextOut);
            this.groupBox4.Location = new System.Drawing.Point(566, 230);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(283, 187);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Summary Details of all investment";
            // 
            // TextOut
            // 
            this.TextOut.Location = new System.Drawing.Point(21, 20);
            this.TextOut.Name = "TextOut";
            this.TextOut.Size = new System.Drawing.Size(110, 97);
            this.TextOut.TabIndex = 0;
            this.TextOut.Text = "Summary";
            // 
            // SummaryButton
            // 
            this.SummaryButton.Location = new System.Drawing.Point(608, 405);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(75, 23);
            this.SummaryButton.TabIndex = 10;
            this.SummaryButton.Text = "Summary";
            this.SummaryButton.UseVisualStyleBackColor = true;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bodoni MT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Invest Q";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Enter Investment Amount: ";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(345, 503);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(139, 30);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "Exit ";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // TextOut2
            // 
            this.TextOut2.Location = new System.Drawing.Point(147, 23);
            this.TextOut2.Name = "TextOut2";
            this.TextOut2.Size = new System.Drawing.Size(130, 94);
            this.TextOut2.TabIndex = 1;
            this.TextOut2.Text = "All Investment";
            // 
            // TextOut3
            // 
            this.TextOut3.Location = new System.Drawing.Point(53, 145);
            this.TextOut3.Name = "TextOut3";
            this.TextOut3.Size = new System.Drawing.Size(118, 30);
            this.TextOut3.TabIndex = 2;
            // 
            // InvestQForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 659);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SummaryButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ProceedButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.UserDetailsGB);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InvestAmountTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InvestQForm";
            this.Text = "Invest Q";
            this.Load += new System.EventHandler(this.InvestQForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.UserDetailsGB.ResumeLayout(false);
            this.UserDetailsGB.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InvestAmountTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Month12RadioButton;
        private System.Windows.Forms.RadioButton Month6RadioButton;
        private System.Windows.Forms.RadioButton Month3RadioButton;
        private System.Windows.Forms.RadioButton Month1RadioButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.GroupBox UserDetailsGB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button ProceedButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label TextOut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TransactionNumberTextBox;
        private System.Windows.Forms.Label TextOut2;
        private System.Windows.Forms.Label TextOut3;
    }
}


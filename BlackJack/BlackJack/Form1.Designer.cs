namespace BlackJack
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Bet_Button = new System.Windows.Forms.Button();
            this.Hit_Button = new System.Windows.Forms.Button();
            this.Stay_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CashDisplay = new System.Windows.Forms.Label();
            this.DealerTextbox = new System.Windows.Forms.RichTextBox();
            this.PlayerTextBox = new System.Windows.Forms.RichTextBox();
            this.HUDTextBox = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pointsDisplay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.userPointsDisplay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dealerPointsDisplay = new System.Windows.Forms.Label();
            this.Loan_Button = new System.Windows.Forms.Button();
            this.Cards_Shuffled_Indicator = new System.Windows.Forms.Label();
            this.Restart_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bet_Button
            // 
            this.Bet_Button.Location = new System.Drawing.Point(659, 320);
            this.Bet_Button.Name = "Bet_Button";
            this.Bet_Button.Size = new System.Drawing.Size(129, 42);
            this.Bet_Button.TabIndex = 0;
            this.Bet_Button.Text = "Bet";
            this.Bet_Button.UseVisualStyleBackColor = true;
            this.Bet_Button.Click += new System.EventHandler(this.betClicked);
            // 
            // Hit_Button
            // 
            this.Hit_Button.Location = new System.Drawing.Point(659, 244);
            this.Hit_Button.Name = "Hit_Button";
            this.Hit_Button.Size = new System.Drawing.Size(129, 42);
            this.Hit_Button.TabIndex = 1;
            this.Hit_Button.Text = "Hit";
            this.Hit_Button.UseVisualStyleBackColor = true;
            this.Hit_Button.Click += new System.EventHandler(this.Hit_Clicked);
            // 
            // Stay_Button
            // 
            this.Stay_Button.Location = new System.Drawing.Point(659, 192);
            this.Stay_Button.Name = "Stay_Button";
            this.Stay_Button.Size = new System.Drawing.Size(129, 46);
            this.Stay_Button.TabIndex = 2;
            this.Stay_Button.Text = "Stay";
            this.Stay_Button.UseVisualStyleBackColor = true;
            this.Stay_Button.Click += new System.EventHandler(this.Stay_Clicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(656, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Credit:";
            // 
            // CashDisplay
            // 
            this.CashDisplay.AutoSize = true;
            this.CashDisplay.Location = new System.Drawing.Point(712, 422);
            this.CashDisplay.Name = "CashDisplay";
            this.CashDisplay.Size = new System.Drawing.Size(28, 16);
            this.CashDisplay.TabIndex = 4;
            this.CashDisplay.Text = "200";
            // 
            // DealerTextbox
            // 
            this.DealerTextbox.Location = new System.Drawing.Point(12, 12);
            this.DealerTextbox.Name = "DealerTextbox";
            this.DealerTextbox.Size = new System.Drawing.Size(609, 194);
            this.DealerTextbox.TabIndex = 5;
            this.DealerTextbox.Text = "";
            // 
            // PlayerTextBox
            // 
            this.PlayerTextBox.Location = new System.Drawing.Point(12, 244);
            this.PlayerTextBox.Name = "PlayerTextBox";
            this.PlayerTextBox.Size = new System.Drawing.Size(609, 194);
            this.PlayerTextBox.TabIndex = 6;
            this.PlayerTextBox.Text = "";
            // 
            // HUDTextBox
            // 
            this.HUDTextBox.Location = new System.Drawing.Point(659, 45);
            this.HUDTextBox.Name = "HUDTextBox";
            this.HUDTextBox.Size = new System.Drawing.Size(129, 124);
            this.HUDTextBox.TabIndex = 7;
            this.HUDTextBox.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(718, 292);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 22);
            this.textBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(656, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Points:";
            // 
            // pointsDisplay
            // 
            this.pointsDisplay.AutoSize = true;
            this.pointsDisplay.Location = new System.Drawing.Point(724, 383);
            this.pointsDisplay.Name = "pointsDisplay";
            this.pointsDisplay.Size = new System.Drawing.Size(0, 16);
            this.pointsDisplay.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(659, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bet:";
            // 
            // userPointsDisplay
            // 
            this.userPointsDisplay.AutoSize = true;
            this.userPointsDisplay.Location = new System.Drawing.Point(724, 392);
            this.userPointsDisplay.Name = "userPointsDisplay";
            this.userPointsDisplay.Size = new System.Drawing.Size(16, 16);
            this.userPointsDisplay.TabIndex = 12;
            this.userPointsDisplay.Text = "   ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(656, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Dealer Points:";
            // 
            // dealerPointsDisplay
            // 
            this.dealerPointsDisplay.AutoSize = true;
            this.dealerPointsDisplay.Location = new System.Drawing.Point(753, 12);
            this.dealerPointsDisplay.Name = "dealerPointsDisplay";
            this.dealerPointsDisplay.Size = new System.Drawing.Size(0, 16);
            this.dealerPointsDisplay.TabIndex = 14;
            // 
            // Loan_Button
            // 
            this.Loan_Button.Location = new System.Drawing.Point(511, 214);
            this.Loan_Button.Name = "Loan_Button";
            this.Loan_Button.Size = new System.Drawing.Size(110, 24);
            this.Loan_Button.TabIndex = 15;
            this.Loan_Button.Text = "Take a Loan";
            this.Loan_Button.UseVisualStyleBackColor = true;
            this.Loan_Button.Click += new System.EventHandler(this.Loan_Button_Clicked);
            // 
            // Cards_Shuffled_Indicator
            // 
            this.Cards_Shuffled_Indicator.AutoSize = true;
            this.Cards_Shuffled_Indicator.Location = new System.Drawing.Point(12, 214);
            this.Cards_Shuffled_Indicator.Name = "Cards_Shuffled_Indicator";
            this.Cards_Shuffled_Indicator.Size = new System.Drawing.Size(0, 16);
            this.Cards_Shuffled_Indicator.TabIndex = 16;
            // 
            // Restart_Button
            // 
            this.Restart_Button.Location = new System.Drawing.Point(419, 215);
            this.Restart_Button.Name = "Restart_Button";
            this.Restart_Button.Size = new System.Drawing.Size(75, 23);
            this.Restart_Button.TabIndex = 17;
            this.Restart_Button.Text = "Restart";
            this.Restart_Button.UseVisualStyleBackColor = true;
            this.Restart_Button.Click += new System.EventHandler(this.Restart_Clicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.Restart_Button);
            this.Controls.Add(this.Cards_Shuffled_Indicator);
            this.Controls.Add(this.Loan_Button);
            this.Controls.Add(this.dealerPointsDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userPointsDisplay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pointsDisplay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.HUDTextBox);
            this.Controls.Add(this.PlayerTextBox);
            this.Controls.Add(this.DealerTextbox);
            this.Controls.Add(this.CashDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Stay_Button);
            this.Controls.Add(this.Hit_Button);
            this.Controls.Add(this.Bet_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackjack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bet_Button;
        private System.Windows.Forms.Button Hit_Button;
        private System.Windows.Forms.Button Stay_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CashDisplay;
        private System.Windows.Forms.RichTextBox DealerTextbox;
        private System.Windows.Forms.RichTextBox PlayerTextBox;
        private System.Windows.Forms.RichTextBox HUDTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pointsDisplay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label userPointsDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dealerPointsDisplay;
        private System.Windows.Forms.Button Loan_Button;
        private System.Windows.Forms.Label Cards_Shuffled_Indicator;
        private System.Windows.Forms.Button Restart_Button;
    }
}


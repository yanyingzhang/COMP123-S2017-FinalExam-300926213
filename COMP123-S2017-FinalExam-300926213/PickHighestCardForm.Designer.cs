namespace COMP123_S2017_FinalExam_300926213
{
    partial class PickHighestCardForm
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
            this.components = new System.ComponentModel.Container();
            this.DealButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CardShowTimer = new System.Windows.Forms.Timer(this.components);
            this.UserMessageTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.CardFlipTimer = new System.Windows.Forms.Timer(this.components);
            this.FifthCardPictureBox = new System.Windows.Forms.PictureBox();
            this.FourthCardPictureBox = new System.Windows.Forms.PictureBox();
            this.ThirdCardPictureBox = new System.Windows.Forms.PictureBox();
            this.SecondCardPictureBox = new System.Windows.Forms.PictureBox();
            this.FirstCardPictureBox = new System.Windows.Forms.PictureBox();
            this.ScoreTextBox = new System.Windows.Forms.TextBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.CountDownTimer = new System.Windows.Forms.Timer(this.components);
            this.ExitButton = new System.Windows.Forms.Button();
            this.FinalScoreTextBox = new System.Windows.Forms.TextBox();
            this.FinalScoreLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FifthCardPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthCardPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdCardPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondCardPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstCardPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DealButton
            // 
            this.DealButton.Location = new System.Drawing.Point(191, 245);
            this.DealButton.Name = "DealButton";
            this.DealButton.Size = new System.Drawing.Size(171, 52);
            this.DealButton.TabIndex = 0;
            this.DealButton.Text = "Deal";
            this.DealButton.UseVisualStyleBackColor = true;
            this.DealButton.Click += new System.EventHandler(this.DealButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.FifthCardPictureBox, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.FourthCardPictureBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.ThirdCardPictureBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.SecondCardPictureBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.FirstCardPictureBox, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 119);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(558, 108);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // CardShowTimer
            // 
            this.CardShowTimer.Interval = 350;
            this.CardShowTimer.Tick += new System.EventHandler(this.CardTimer_Tick);
            // 
            // UserMessageTextBox
            // 
            this.UserMessageTextBox.BackColor = System.Drawing.Color.Black;
            this.UserMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserMessageTextBox.ForeColor = System.Drawing.Color.White;
            this.UserMessageTextBox.Location = new System.Drawing.Point(12, 75);
            this.UserMessageTextBox.Name = "UserMessageTextBox";
            this.UserMessageTextBox.ReadOnly = true;
            this.UserMessageTextBox.Size = new System.Drawing.Size(558, 38);
            this.UserMessageTextBox.TabIndex = 3;
            this.UserMessageTextBox.TabStop = false;
            this.UserMessageTextBox.Text = "Click the Deal Button!";
            this.UserMessageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(12, 436);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(171, 52);
            this.ResetButton.TabIndex = 4;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CardFlipTimer
            // 
            this.CardFlipTimer.Interval = 16;
            this.CardFlipTimer.Tick += new System.EventHandler(this.CardFlipTimer_Tick);
            // 
            // FifthCardPictureBox
            // 
            this.FifthCardPictureBox.BackColor = System.Drawing.Color.Black;
            this.FifthCardPictureBox.Image = global::COMP123_S2017_FinalExam_300926213.Properties.Resources.cardback;
            this.FifthCardPictureBox.Location = new System.Drawing.Point(447, 3);
            this.FifthCardPictureBox.Name = "FifthCardPictureBox";
            this.FifthCardPictureBox.Size = new System.Drawing.Size(96, 102);
            this.FifthCardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FifthCardPictureBox.TabIndex = 5;
            this.FifthCardPictureBox.TabStop = false;
            this.FifthCardPictureBox.Visible = false;
            this.FifthCardPictureBox.Click += new System.EventHandler(this.CardPictureBox_Click);
            // 
            // FourthCardPictureBox
            // 
            this.FourthCardPictureBox.BackColor = System.Drawing.Color.Black;
            this.FourthCardPictureBox.Image = global::COMP123_S2017_FinalExam_300926213.Properties.Resources.cardback;
            this.FourthCardPictureBox.Location = new System.Drawing.Point(336, 3);
            this.FourthCardPictureBox.Name = "FourthCardPictureBox";
            this.FourthCardPictureBox.Size = new System.Drawing.Size(96, 102);
            this.FourthCardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FourthCardPictureBox.TabIndex = 4;
            this.FourthCardPictureBox.TabStop = false;
            this.FourthCardPictureBox.Visible = false;
            this.FourthCardPictureBox.Click += new System.EventHandler(this.CardPictureBox_Click);
            // 
            // ThirdCardPictureBox
            // 
            this.ThirdCardPictureBox.BackColor = System.Drawing.Color.Black;
            this.ThirdCardPictureBox.Image = global::COMP123_S2017_FinalExam_300926213.Properties.Resources.cardback;
            this.ThirdCardPictureBox.Location = new System.Drawing.Point(225, 3);
            this.ThirdCardPictureBox.Name = "ThirdCardPictureBox";
            this.ThirdCardPictureBox.Size = new System.Drawing.Size(96, 102);
            this.ThirdCardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ThirdCardPictureBox.TabIndex = 3;
            this.ThirdCardPictureBox.TabStop = false;
            this.ThirdCardPictureBox.Visible = false;
            this.ThirdCardPictureBox.Click += new System.EventHandler(this.CardPictureBox_Click);
            // 
            // SecondCardPictureBox
            // 
            this.SecondCardPictureBox.BackColor = System.Drawing.Color.Black;
            this.SecondCardPictureBox.Image = global::COMP123_S2017_FinalExam_300926213.Properties.Resources.cardback;
            this.SecondCardPictureBox.Location = new System.Drawing.Point(114, 3);
            this.SecondCardPictureBox.Name = "SecondCardPictureBox";
            this.SecondCardPictureBox.Size = new System.Drawing.Size(96, 102);
            this.SecondCardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SecondCardPictureBox.TabIndex = 2;
            this.SecondCardPictureBox.TabStop = false;
            this.SecondCardPictureBox.Visible = false;
            this.SecondCardPictureBox.Click += new System.EventHandler(this.CardPictureBox_Click);
            // 
            // FirstCardPictureBox
            // 
            this.FirstCardPictureBox.BackColor = System.Drawing.Color.Black;
            this.FirstCardPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FirstCardPictureBox.Image = global::COMP123_S2017_FinalExam_300926213.Properties.Resources.cardback;
            this.FirstCardPictureBox.Location = new System.Drawing.Point(3, 3);
            this.FirstCardPictureBox.Name = "FirstCardPictureBox";
            this.FirstCardPictureBox.Size = new System.Drawing.Size(96, 102);
            this.FirstCardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FirstCardPictureBox.TabIndex = 1;
            this.FirstCardPictureBox.TabStop = false;
            this.FirstCardPictureBox.Visible = false;
            this.FirstCardPictureBox.Click += new System.EventHandler(this.CardPictureBox_Click);
            // 
            // ScoreTextBox
            // 
            this.ScoreTextBox.BackColor = System.Drawing.Color.Black;
            this.ScoreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScoreTextBox.ForeColor = System.Drawing.Color.White;
            this.ScoreTextBox.Location = new System.Drawing.Point(139, 12);
            this.ScoreTextBox.Name = "ScoreTextBox";
            this.ScoreTextBox.ReadOnly = true;
            this.ScoreTextBox.Size = new System.Drawing.Size(151, 38);
            this.ScoreTextBox.TabIndex = 5;
            this.ScoreTextBox.TabStop = false;
            this.ScoreTextBox.Text = "0";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.ScoreLabel.Location = new System.Drawing.Point(12, 12);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(121, 39);
            this.ScoreLabel.TabIndex = 6;
            this.ScoreLabel.Text = "Score:";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.White;
            this.TimeLabel.Location = new System.Drawing.Point(296, 12);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(107, 39);
            this.TimeLabel.TabIndex = 8;
            this.TimeLabel.Text = "Time:";
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.BackColor = System.Drawing.Color.Black;
            this.TimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimeTextBox.ForeColor = System.Drawing.Color.White;
            this.TimeTextBox.Location = new System.Drawing.Point(423, 12);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.ReadOnly = true;
            this.TimeTextBox.Size = new System.Drawing.Size(151, 38);
            this.TimeTextBox.TabIndex = 7;
            this.TimeTextBox.TabStop = false;
            this.TimeTextBox.Text = "30";
            // 
            // CountDownTimer
            // 
            this.CountDownTimer.Interval = 1000;
            this.CountDownTimer.Tick += new System.EventHandler(this.CountDownTimer_Tick);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(399, 436);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(171, 52);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // FinalScoreTextBox
            // 
            this.FinalScoreTextBox.BackColor = System.Drawing.Color.Black;
            this.FinalScoreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FinalScoreTextBox.ForeColor = System.Drawing.Color.White;
            this.FinalScoreTextBox.Location = new System.Drawing.Point(229, 329);
            this.FinalScoreTextBox.Name = "FinalScoreTextBox";
            this.FinalScoreTextBox.ReadOnly = true;
            this.FinalScoreTextBox.Size = new System.Drawing.Size(171, 38);
            this.FinalScoreTextBox.TabIndex = 10;
            this.FinalScoreTextBox.TabStop = false;
            this.FinalScoreTextBox.Text = "0";
            this.FinalScoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FinalScoreTextBox.Visible = false;
            // 
            // FinalScoreLabel
            // 
            this.FinalScoreLabel.AutoSize = true;
            this.FinalScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalScoreLabel.ForeColor = System.Drawing.Color.White;
            this.FinalScoreLabel.Location = new System.Drawing.Point(12, 328);
            this.FinalScoreLabel.Name = "FinalScoreLabel";
            this.FinalScoreLabel.Size = new System.Drawing.Size(211, 39);
            this.FinalScoreLabel.TabIndex = 11;
            this.FinalScoreLabel.Text = "Final Score:";
            this.FinalScoreLabel.Visible = false;
            // 
            // PickHighestCardForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.FinalScoreLabel);
            this.Controls.Add(this.FinalScoreTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TimeTextBox);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.ScoreTextBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.UserMessageTextBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.DealButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "PickHighestCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pick The Highest Card";
            this.Load += new System.EventHandler(this.PickHighestCardForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FifthCardPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthCardPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdCardPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondCardPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstCardPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DealButton;
        private System.Windows.Forms.PictureBox FirstCardPictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox FifthCardPictureBox;
        private System.Windows.Forms.PictureBox FourthCardPictureBox;
        private System.Windows.Forms.PictureBox ThirdCardPictureBox;
        private System.Windows.Forms.PictureBox SecondCardPictureBox;
        private System.Windows.Forms.Timer CardShowTimer;
        private System.Windows.Forms.TextBox UserMessageTextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Timer CardFlipTimer;
        private System.Windows.Forms.TextBox ScoreTextBox;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.Timer CountDownTimer;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox FinalScoreTextBox;
        private System.Windows.Forms.Label FinalScoreLabel;
    }
}


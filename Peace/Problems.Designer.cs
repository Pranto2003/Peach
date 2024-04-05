namespace Peace
{
    partial class Problems
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
            OverThinking = new Button();
            Depression = new Button();
            Inconsistancy = new Button();
            Loneliness = new Button();
            Return = new Button();
            Exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(34, 47, 62);
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(35, 9);
            label1.Name = "label1";
            label1.Size = new Size(688, 46);
            label1.TabIndex = 0;
            label1.Text = "                   Choose Your Problem                 ";
            // 
            // OverThinking
            // 
            OverThinking.BackColor = Color.FromArgb(16, 172, 132);
            OverThinking.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OverThinking.Location = new Point(122, 94);
            OverThinking.Name = "OverThinking";
            OverThinking.Size = new Size(137, 71);
            OverThinking.TabIndex = 1;
            OverThinking.Text = "OverThinking";
            OverThinking.UseVisualStyleBackColor = false;
            OverThinking.Click += OverThinking_Click;
            // 
            // Depression
            // 
            Depression.BackColor = Color.FromArgb(16, 172, 132);
            Depression.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Depression.Location = new Point(513, 94);
            Depression.Name = "Depression";
            Depression.Size = new Size(137, 71);
            Depression.TabIndex = 2;
            Depression.Text = "Depression";
            Depression.UseVisualStyleBackColor = false;
            Depression.Click += Depression_Click;
            // 
            // Inconsistancy
            // 
            Inconsistancy.BackColor = Color.FromArgb(16, 172, 132);
            Inconsistancy.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Inconsistancy.Location = new Point(513, 306);
            Inconsistancy.Name = "Inconsistancy";
            Inconsistancy.Size = new Size(137, 71);
            Inconsistancy.TabIndex = 3;
            Inconsistancy.Text = "Inconsistancy";
            Inconsistancy.UseVisualStyleBackColor = false;
            Inconsistancy.Click += Inconsistancy_Click;
            // 
            // Loneliness
            // 
            Loneliness.BackColor = Color.FromArgb(16, 172, 132);
            Loneliness.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Loneliness.Location = new Point(122, 306);
            Loneliness.Name = "Loneliness";
            Loneliness.Size = new Size(137, 71);
            Loneliness.TabIndex = 4;
            Loneliness.Text = "Loneliness";
            Loneliness.UseVisualStyleBackColor = false;
            Loneliness.Click += Loneliness_Click;
            // 
            // Return
            // 
            Return.BackColor = Color.FromArgb(0, 192, 0);
            Return.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Return.Location = new Point(2, 393);
            Return.Name = "Return";
            Return.Size = new Size(96, 56);
            Return.TabIndex = 5;
            Return.Text = "Return";
            Return.UseVisualStyleBackColor = false;
            Return.Click += Return_Click;
            // 
            // Exit
            // 
            Exit.BackColor = Color.Red;
            Exit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit.Location = new Point(702, 402);
            Exit.Name = "Exit";
            Exit.Size = new Size(96, 47);
            Exit.TabIndex = 6;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // Problems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2;
            ClientSize = new Size(800, 450);
            Controls.Add(Exit);
            Controls.Add(Return);
            Controls.Add(Loneliness);
            Controls.Add(Inconsistancy);
            Controls.Add(Depression);
            Controls.Add(OverThinking);
            Controls.Add(label1);
            Name = "Problems";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Problems";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button OverThinking;
        private Button Depression;
        private Button Inconsistancy;
        private Button Loneliness;
        private Button Return;
        private Button Exit;
    }
}
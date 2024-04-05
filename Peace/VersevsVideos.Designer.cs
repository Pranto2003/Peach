namespace Peace
{
    partial class VersevsVideos
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
            Verses = new Button();
            Videos = new Button();
            Return = new Button();
            Exit = new Button();
            SuspendLayout();
            // 
            // Verses
            // 
            Verses.BackColor = SystemColors.ActiveCaption;
            Verses.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Verses.Location = new Point(103, 147);
            Verses.Name = "Verses";
            Verses.Size = new Size(149, 113);
            Verses.TabIndex = 0;
            Verses.Text = "Verses";
            Verses.UseVisualStyleBackColor = false;
            Verses.Click += Verses_Click;
            // 
            // Videos
            // 
            Videos.BackColor = SystemColors.ActiveCaption;
            Videos.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Videos.Location = new Point(553, 147);
            Videos.Name = "Videos";
            Videos.Size = new Size(149, 113);
            Videos.TabIndex = 1;
            Videos.Text = "Videos";
            Videos.UseVisualStyleBackColor = false;
            Videos.Click += Videos_Click;
            // 
            // Return
            // 
            Return.BackColor = Color.FromArgb(0, 192, 0);
            Return.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Return.Location = new Point(61, 383);
            Return.Name = "Return";
            Return.Size = new Size(110, 55);
            Return.TabIndex = 2;
            Return.Text = "Return";
            Return.UseVisualStyleBackColor = false;
            Return.Click += Return_Click;
            // 
            // Exit
            // 
            Exit.BackColor = Color.Red;
            Exit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit.Location = new Point(626, 383);
            Exit.Name = "Exit";
            Exit.Size = new Size(110, 55);
            Exit.TabIndex = 3;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // VersevsVideos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._21;
            ClientSize = new Size(800, 450);
            Controls.Add(Exit);
            Controls.Add(Return);
            Controls.Add(Videos);
            Controls.Add(Verses);
            Name = "VersevsVideos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VersevsVideos";
            ResumeLayout(false);
        }

        #endregion

        private Button Verses;
        private Button Videos;
        private Button Return;
        private Button Exit;
    }
}
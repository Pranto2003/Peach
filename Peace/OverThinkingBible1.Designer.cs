namespace Peace
{
    partial class OverThinkingBible1
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
            Return = new Button();
            Exit = new Button();
            More = new Button();
            SuspendLayout();
            // 
            // Return
            // 
            Return.BackColor = Color.FromArgb(0, 192, 0);
            Return.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Return.Location = new Point(336, 360);
            Return.Name = "Return";
            Return.Size = new Size(139, 49);
            Return.TabIndex = 1;
            Return.Text = "Return";
            Return.UseVisualStyleBackColor = false;
            Return.Click += Return_Click;
            // 
            // Exit
            // 
            Exit.BackColor = Color.Red;
            Exit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit.Location = new Point(588, 360);
            Exit.Name = "Exit";
            Exit.Size = new Size(139, 49);
            Exit.TabIndex = 2;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // More
            // 
            More.BackColor = SystemColors.ActiveCaption;
            More.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            More.Location = new Point(71, 360);
            More.Name = "More";
            More.Size = new Size(139, 49);
            More.TabIndex = 3;
            More.Text = "More";
            More.UseVisualStyleBackColor = false;
            More.Click += More_Click;
            // 
            // OverThinkingBible1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 80);
            BackgroundImage = Properties.Resources.OverthinkingBible1;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(More);
            Controls.Add(Exit);
            Controls.Add(Return);
            DoubleBuffered = true;
            Name = "OverThinkingBible1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OverThinkingBible1";
            ResumeLayout(false);
        }

        #endregion
        private Button Return;
        private Button Exit;
        private Button More;
    }
}
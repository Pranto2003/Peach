namespace Peace
{
    partial class InconsistancyBible2
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
            More = new Button();
            Return = new Button();
            Exit = new Button();
            SuspendLayout();
            // 
            // More
            // 
            More.BackColor = SystemColors.ActiveCaption;
            More.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            More.Location = new Point(75, 327);
            More.Name = "More";
            More.Size = new Size(115, 72);
            More.TabIndex = 0;
            More.Text = "More";
            More.UseVisualStyleBackColor = false;
            More.Click += More_Click;
            // 
            // Return
            // 
            Return.BackColor = Color.FromArgb(0, 192, 0);
            Return.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Return.Location = new Point(385, 327);
            Return.Name = "Return";
            Return.Size = new Size(115, 72);
            Return.TabIndex = 1;
            Return.Text = "Return";
            Return.UseVisualStyleBackColor = false;
            Return.Click += Return_Click;
            // 
            // Exit
            // 
            Exit.BackColor = Color.Red;
            Exit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit.Location = new Point(684, 327);
            Exit.Name = "Exit";
            Exit.Size = new Size(115, 72);
            Exit.TabIndex = 2;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // InconsistancyBible2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 80);
            BackgroundImage = Properties.Resources.ConsistancyBible2;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(900, 450);
            Controls.Add(Exit);
            Controls.Add(Return);
            Controls.Add(More);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "InconsistancyBible2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InconsistancyBible2";
            ResumeLayout(false);
        }

        #endregion

        private Button More;
        private Button Return;
        private Button Exit;
    }
}
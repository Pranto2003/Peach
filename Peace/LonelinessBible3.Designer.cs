namespace Peace
{
    partial class LonelinessBible3
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
            SuspendLayout();
            // 
            // Return
            // 
            Return.BackColor = Color.FromArgb(0, 192, 0);
            Return.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Return.Location = new Point(139, 346);
            Return.Name = "Return";
            Return.Size = new Size(117, 64);
            Return.TabIndex = 0;
            Return.Text = "Return";
            Return.UseVisualStyleBackColor = false;
            Return.Click += Return_Click;
            // 
            // Exit
            // 
            Exit.BackColor = Color.Red;
            Exit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit.Location = new Point(531, 346);
            Exit.Name = "Exit";
            Exit.Size = new Size(117, 64);
            Exit.TabIndex = 1;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // LonelinessBible3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 80);
            BackgroundImage = Properties.Resources.LonelinessBible3;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(Exit);
            Controls.Add(Return);
            DoubleBuffered = true;
            Name = "LonelinessBible3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LonelinessBible3";
            ResumeLayout(false);
        }

        #endregion

        private Button Return;
        private Button Exit;
    }
}
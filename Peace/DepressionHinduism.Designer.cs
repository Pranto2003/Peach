namespace Peace
{
    partial class DepressionHinduism
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepressionHinduism));
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer2).BeginInit();
            SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(105, 28);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(514, 288);
            axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // axWindowsMediaPlayer2
            // 
            axWindowsMediaPlayer2.Enabled = true;
            axWindowsMediaPlayer2.Location = new Point(105, 352);
            axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            axWindowsMediaPlayer2.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer2.OcxState");
            axWindowsMediaPlayer2.Size = new Size(514, 288);
            axWindowsMediaPlayer2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(653, 148);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Play";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(646, 499);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Play";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // DepressionHinduism
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources._1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(axWindowsMediaPlayer2);
            Controls.Add(axWindowsMediaPlayer1);
            DoubleBuffered = true;
            Name = "DepressionHinduism";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DepressionHinduism";
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private Button button1;
        private Button button2;
    }
}
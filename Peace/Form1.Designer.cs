
namespace Peace
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Hinduism = new Button();
            Islam = new Button();
            Buddhism = new Button();
            Christianity = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(147, 25);
            label1.Name = "label1";
            label1.Size = new Size(470, 31);
            label1.TabIndex = 0;
            label1.Text = "                       Choose your Religion               ";
            // 
            // Hinduism
            // 
            Hinduism.BackColor = Color.FromArgb(0, 184, 148);
            Hinduism.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Hinduism.Location = new Point(42, 84);
            Hinduism.Name = "Hinduism";
            Hinduism.Size = new Size(133, 45);
            Hinduism.TabIndex = 1;
            Hinduism.Text = "Hinduism";
            Hinduism.UseVisualStyleBackColor = false;
            Hinduism.Click += Hinduism_Click;
            // 
            // Islam
            // 
            Islam.BackColor = Color.FromArgb(0, 184, 148);
            Islam.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Islam.Location = new Point(242, 84);
            Islam.Name = "Islam";
            Islam.Size = new Size(133, 45);
            Islam.TabIndex = 2;
            Islam.Text = "Islam";
            Islam.UseVisualStyleBackColor = false;
            Islam.Click += Islam_Click;
            // 
            // Buddhism
            // 
            Buddhism.BackColor = Color.FromArgb(0, 184, 148);
            Buddhism.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Buddhism.Location = new Point(441, 84);
            Buddhism.Name = "Buddhism";
            Buddhism.Size = new Size(133, 45);
            Buddhism.TabIndex = 3;
            Buddhism.Text = "Buddhism";
            Buddhism.UseVisualStyleBackColor = false;
            Buddhism.Click += Buddhism_Click;
            // 
            // Christianity
            // 
            Christianity.BackColor = Color.FromArgb(0, 184, 148);
            Christianity.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Christianity.Location = new Point(631, 84);
            Christianity.Name = "Christianity";
            Christianity.Size = new Size(133, 45);
            Christianity.TabIndex = 4;
            Christianity.Text = "Christianity";
            Christianity.UseVisualStyleBackColor = false;
            Christianity.Click += Christianity_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._3150723;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(Christianity);
            Controls.Add(Buddhism);
            Controls.Add(Islam);
            Controls.Add(Hinduism);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private Button Hinduism;
        private Button Islam;
        private Button Buddhism;
        private Button Christianity;
    }
}

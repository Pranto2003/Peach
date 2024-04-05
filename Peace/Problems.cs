using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peace
{
    public partial class Problems : Form
    {
        Form1 form1;
        bool overthinking = false;
        bool depression = false;
        bool inconsistancy = false;
        bool loneliness = false;
        public Problems(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void OverThinking_Click(object sender, EventArgs e)
        {
            VersevsVideos versevsVideos = new VersevsVideos(form1, this);
            versevsVideos.Show();
            overthinking = true;
        }
        public bool OverThinkingbuttonClicked()
        {
            return overthinking;
        }

        private void Depression_Click(object sender, EventArgs e)
        {
            VersevsVideos versevsVideos = new VersevsVideos(form1, this);
            versevsVideos.Show();
            depression = true;
        }
        public bool DepressionbuttonClicked()
        {
            return depression;
        }

        private void Loneliness_Click(object sender, EventArgs e)
        {
            VersevsVideos versevsVideos = new VersevsVideos(form1, this);
            versevsVideos.Show();
            loneliness = true;
        }
        public bool LonelinessbuttonClicked()
        {
            return loneliness;
        }

        private void Inconsistancy_Click(object sender, EventArgs e)
        {
            VersevsVideos versevsVideos = new VersevsVideos(form1, this);
            versevsVideos.Show();
            inconsistancy = true;
        }
        public bool InconsistancybuttonClicked()
        {
            return inconsistancy;
        }

        private void Return_Click(object sender, EventArgs e)
        {
            Form1 form1= new Form1();
            form1.Show();
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

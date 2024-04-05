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
    public partial class DepressionHinduism : Form
    {
        private Form1 form1;
        public DepressionHinduism(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string f = "D:\\Projec\\वीर्यनाश से होता है Depression   HG amogh lila Prabhu   #iskcon#sanatandharma.mp4";
            axWindowsMediaPlayer1.URL = f;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string f = "D:\\Projec\\You Can Get Out of Your Depression.mp4";
            axWindowsMediaPlayer2.URL = f;
        }
    }
}

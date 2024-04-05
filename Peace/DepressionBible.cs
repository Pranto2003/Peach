using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Peace
{
    public partial class DepressionBible : Form
    {
        private Form1 form1;
        public DepressionBible(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void Play_Click(object sender, EventArgs e)
        {
            string f = "D:\\Projec\\God's #1 Remedy For Depression and Anxiety   Pastor Gregory Dickow.mp4";
            axWindowsMediaPlayer1.URL = f;
        }
    }
}

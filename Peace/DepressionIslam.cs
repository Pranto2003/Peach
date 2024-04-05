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
    public partial class DepressionIslam : Form
    {
        private Form1 form1;
        public DepressionIslam(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string f = "D:\\Projec\\Mental Illness is Real    Mohamed Hoblos.mp4";
            axWindowsMediaPlayer1.URL = f;
        }
    }
}

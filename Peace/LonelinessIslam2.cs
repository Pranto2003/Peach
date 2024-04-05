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
    public partial class LonelinessIslam2 : Form
    {
        private Form1 form1;
        public LonelinessIslam2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        private void More_Click(object sender, EventArgs e)
        {
            LonelinessIslam3 lonelinessIslam3 = new LonelinessIslam3(form1);
            lonelinessIslam3.Show();
            this.Close();
        }
        
        private void Return_Click(object sender, EventArgs e)
        {
            Problems problems = new Problems(form1);
            problems.Show();
            this.Close();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

﻿using System;
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
    public partial class OverthinkingHinduism : Form
    {
        private Form1 form1;
        public OverthinkingHinduism(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string f = "D:\\Projec\\How to Stop Overthinking   Jaya Kishori   Motivational.mp4";
            axWindowsMediaPlayer1.URL = f;
        }
    }
}

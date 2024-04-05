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
    public partial class VersevsVideos : Form
    {
        Form1 form1;
        Problems problems;
        public VersevsVideos(Form1 form1, Problems problems)
        {
            InitializeComponent();
            this.form1 = form1;
            this.problems = problems;
        }
        private void Verses_Click(object sender, EventArgs e)
        {
            if (form1.HinduismbuttonClicked() && problems.OverThinkingbuttonClicked())
            {
                OverthinkingHinduism1 overthinkingHinduism1 = new OverthinkingHinduism1(form1);
                overthinkingHinduism1.Show();
                this.Close();
            }
            else if (form1.IslambuttonClicked() && problems.OverThinkingbuttonClicked())
            {
                OverthinkingIslam1 overthinkingIslam1 = new OverthinkingIslam1(form1);
                overthinkingIslam1.Show();
                this.Close();
            }
            else if (form1.BuddhismbuttonClicked() && problems.OverThinkingbuttonClicked())
            {
                OverThinkingBuddhism1 overThinkingBuddhism1 = new OverThinkingBuddhism1(form1);
                overThinkingBuddhism1.Show();
                this.Close();
            }
            else if (form1.ChristianitybuttonClicked() && problems.OverThinkingbuttonClicked())
            {
                OverThinkingBible1 overThinkingBible1 = new OverThinkingBible1(form1);
                overThinkingBible1.Show();
                this.Close();
            }
            else if (form1.HinduismbuttonClicked() && problems.DepressionbuttonClicked())
            {
                DepressionHinduism1 depressionHinduism1 = new DepressionHinduism1(form1);
                depressionHinduism1.Show();
                this.Close();
            }
            else if (form1.IslambuttonClicked() && problems.DepressionbuttonClicked())
            {
                DepressionIslam1 depressionIslam1 = new DepressionIslam1(form1);
                depressionIslam1.Show();
                this.Close();
            }
            else if (form1.BuddhismbuttonClicked() && problems.DepressionbuttonClicked())
            {
                DepressionBuddhism1 depressionBuddhism1 = new DepressionBuddhism1(form1);
                depressionBuddhism1.Show();
                this.Close();
            }
            else if (form1.ChristianitybuttonClicked() && problems.DepressionbuttonClicked())
            {
                DepressionBible1 depressionBible1 = new DepressionBible1(form1);
                depressionBible1.Show();
                this.Close();
            }
            else if (form1.HinduismbuttonClicked() && problems.LonelinessbuttonClicked())
            {
                OverthinkingHinduism1 overthinkingHinduism1 = new OverthinkingHinduism1(form1);
                overthinkingHinduism1.Show();
                this.Close();
            }
            else if (form1.IslambuttonClicked() && problems.LonelinessbuttonClicked())
            {
                OverthinkingIslam1 overthinkingIslam1 = new OverthinkingIslam1(form1);
                overthinkingIslam1.Show();
                this.Close();
            }
            else if (form1.BuddhismbuttonClicked() && problems.LonelinessbuttonClicked())
            {
                OverThinkingBuddhism1 overThinkingBuddhism1 = new OverThinkingBuddhism1(form1);
                overThinkingBuddhism1.Show();
                this.Close();
            }
            else if (form1.ChristianitybuttonClicked() && problems.LonelinessbuttonClicked())
            {
                OverThinkingBible1 overThinkingBible1 = new OverThinkingBible1(form1);
                overThinkingBible1.Show();
                this.Close();
            }
            else if (form1.HinduismbuttonClicked() && problems.InconsistancybuttonClicked())
            {
                InconsistancyHinduism1 inconsistancyHinduism1 = new InconsistancyHinduism1(form1);
                inconsistancyHinduism1.Show();
                this.Close();
            }
            else if (form1.IslambuttonClicked() && problems.InconsistancybuttonClicked())
            {
                InconsistancyIslam1 inconsistancyIslam1 = new InconsistancyIslam1(form1);
                inconsistancyIslam1.Show();
                this.Close();
            }
            else if (form1.BuddhismbuttonClicked() && problems.InconsistancybuttonClicked())
            {
                InconsistancyBuddhism1 inconsistancyBuddhism1 = new InconsistancyBuddhism1(form1);
                inconsistancyBuddhism1.Show();
                this.Close();
            }
            else
            {
                InconsistancyBible1 inconsistancyBible1 = new InconsistancyBible1(form1);
                inconsistancyBible1.Show();
                this.Close();
            }

        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.problems.Show();
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Videos_Click(object sender, EventArgs e)
        {
            if (form1.ChristianitybuttonClicked() && problems.DepressionbuttonClicked())
            {
                DepressionBible depressionBible = new DepressionBible(form1);
                depressionBible.Show();
                this.Close();
            }
            else if (form1.HinduismbuttonClicked() && problems.DepressionbuttonClicked())
            {
                DepressionHinduism depressionHinduism = new DepressionHinduism(form1);
                depressionHinduism.Show();
                this.Close();
            }
            else if(form1.IslambuttonClicked() && problems.DepressionbuttonClicked())
            {
                DepressionIslam depressionIslam = new DepressionIslam(form1);
                depressionIslam.Show();
                this.Close();
            }
            else if(form1.HinduismbuttonClicked() && problems.OverThinkingbuttonClicked())
            {
                OverthinkingHinduism overthinkingHinduism = new OverthinkingHinduism(form1);
                overthinkingHinduism.Show();
                this.Close();
            }
            else
            {
                OverthinkingBuddhism overthinkingBuddhism = new OverthinkingBuddhism(form1);
                overthinkingBuddhism.Show();
                this.Close();
            }
            
        }
    }
}

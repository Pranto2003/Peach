namespace Peace
{
    public partial class Form1 : Form
    {
        bool hindu = false;
        bool islam = false;
        bool buddhist = false;
        bool christianity = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Hinduism_Click(object sender, EventArgs e)
        {
            Problems problems = new Problems(this);
            problems.Show();
            hindu = true;
        }
        public bool HinduismbuttonClicked()
        {
            return hindu;
        }

        private void Islam_Click(object sender, EventArgs e)
        {
            Problems problems = new Problems(this);
            problems.Show();
            islam = true;
        }
        public bool IslambuttonClicked()
        {
            return islam;
        }

        private void Buddhism_Click(object sender, EventArgs e)
        {
            Problems problems = new Problems(this);
            problems.Show();
            buddhist= true;
        }
        public bool BuddhismbuttonClicked()
        {
            return buddhist;
        }

        private void Christianity_Click(object sender, EventArgs e)
        {
            Problems problems = new Problems(this);
            problems.Show();
            christianity = true;
        }
        public bool ChristianitybuttonClicked()
        {
            return christianity;
        }
    }
}

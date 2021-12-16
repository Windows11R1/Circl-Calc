namespace Circl_Calc
{
    public partial class Form1 : Form
    {

        double PI = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PI = Math.PI;
        }
    }
}
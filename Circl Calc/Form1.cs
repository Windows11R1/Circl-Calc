using System;

namespace Circl_Calc
{
    public partial class Form1 : Form
    {

        private readonly double pi = 3.14;
        private double radius = 0;
        private double diameter = 0;
        private double circfer = 0;
        private double aria = 0;

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedItem = 0;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            #region user error handler not work
            /*
            if(comboBox1.SelectedIndex == null);

            if (textBox1.Text == "")
            {
                MessageBox.Show(
                "Enter valve",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button3,
                MessageBoxOptions.RightAlign);
            }
            */
            #endregion

            if (comboBox1.SelectedIndex == 0) // radius
            {
                radius = Convert.ToDouble(comboBox1.Text);
                diameter = 2 * radius;
                circfer = 2 * pi * radius;
                aria = pi * (radius * 2);
            }
            if (comboBox1.SelectedIndex == 1) //diameter
            {
                diameter = Convert.ToDouble(comboBox1.Text);
                radius = diameter / 2;
                circfer = 2 * pi * radius;
                aria = pi * radius;
            }
            if (comboBox1.SelectedIndex == 2) //Ñircum ference
            {
                circfer = Convert.ToDouble(comboBox1.Text);

            }
        }
    }
}
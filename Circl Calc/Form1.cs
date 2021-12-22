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
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {         
            if (comboBox1.SelectedIndex == 0) // radius
            {
                radius = Convert.ToDouble(textBox1.Text);
                diameter = 2 * radius;
                circfer = 2 * pi * radius;
                aria = pi * (radius * 2);
            }
            if (comboBox1.SelectedIndex == 1) //diameter
            {
                diameter = Convert.ToDouble(textBox1.Text);
                radius = diameter / 2;
                circfer = 2 * pi * radius;
                aria = pi * radius;
            }
            if (comboBox1.SelectedIndex == 2) //circum ference
            {
                circfer = Convert.ToDouble(textBox1.Text);
                radius  = circfer / (pi * 2);
                diameter = radius * 2;
                aria = pi * radius;
            }
            if(comboBox1.SelectedIndex == 3) //aria
            {
                aria = Convert.ToDouble(textBox1.Text);
                radius = Math.Sqrt(aria / pi);
                diameter = radius * 2;
                circfer = 2 * pi * radius;                
            }
            Radiuslabel.Text = "Radius: " + Convert.ToString(radius);
            Diameterlabel.Text = "Diameter: " + Convert.ToString(diameter);
            Arialabel.Text = "Aria: " + Convert.ToString(aria);
            ÑirculFerencelabel.Text = "Ñircul ference:" + Convert.ToString(circfer);
        }
    }
}
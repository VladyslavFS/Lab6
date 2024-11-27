
using System;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double sideA = double.Parse(txtSideA.Text);
                double sideB = double.Parse(txtSideB.Text);
                double sideC = double.Parse(txtSideC.Text);

                Triangle triangle = new Triangle(sideA, sideB, sideC);

                string type = triangle.DetermineType();
                double area = triangle.CalculateArea();
                double perimeter = triangle.CalculatePerimeter();

                lblResult.Text = $"Type: {type}\n" +
                                 $"Area: {area:F2}\n" +
                                 $"Perimeter: {perimeter:F2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for the sides.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}


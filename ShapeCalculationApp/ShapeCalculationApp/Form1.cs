using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeCalculationApp
{
    public partial class Form1 : Form
    {
        public int Area1;
        public int Area2;
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Area1 = int.Parse(WidthInput1.Text) * int.Parse(HeightInput1.Text);
            Area2 = int.Parse(WidthInput2.Text) * int.Parse(HeightInput2.Text);
            ResultCalculation resultPage = new ResultCalculation();
            resultPage.Area1.Text = Area1.ToString();
            resultPage.Area2.Text = Area2.ToString();
            resultPage.Show();
        }

        private void WidthInput1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

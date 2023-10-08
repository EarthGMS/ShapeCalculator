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
        public int SquareArea1;
        public int SqareArea2;
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            ResultCalculation resultPage = new ResultCalculation();
            resultPage.Area1.Text = SquareArea1.ToString();
            resultPage.Area2.Text = SqareArea2.ToString();
            resultPage.Show();
        }

        private void WidthInput1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Square1Button_Click(object sender, EventArgs e)
        {
            SquarePanel1.Visible = true;
            TrianglePanel1.Visible = false;
            //SquareArea1 = int.Parse(WidthInput1.Text) * int.Parse(HeightInput1.Text);
        }

        private void Triangle1Button_Click(object sender, EventArgs e)
        {
            SquarePanel1.Visible = false;
            TrianglePanel1.Visible = true;
        }

        private void Square2Button_Click(object sender, EventArgs e)
        {
            SquarePanel2.Visible = true;
            TrianglePanel2.Visible = false;
            //SqareArea2 = int.Parse(WidthInput2.Text) * int.Parse(HeightInput2.Text);
        }

        private void Triangle2Button_Click(object sender, EventArgs e)
        {
            SquarePanel2.Visible = false;
            TrianglePanel2.Visible = true;
        }
    }
}

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
        public double result1;
        public double result2;

        public string ShapeText1;
        public string ShapeText2;
        public ResultCalculation resultPage;

        //Shape Mode
        public enum ShapeMode1 { Square1, Triangle1, Circle1 }
        public enum ShapeMode2 { Square2, Triangle2, Circle2 }

        public ShapeMode1 ShapeChoose1;
        public ShapeMode2 ShapeChoose2;
        public Form1()
        {
            resultPage = new ResultCalculation();
            InitializeComponent();
            ShapeChoose1 = ShapeMode1.Triangle1;
            ShapeChoose2 = ShapeMode2.Triangle2;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                ShapeModeDefine(ShapeChoose1, ShapeChoose2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ShapeModeDefine(ShapeChoose1, ShapeChoose2);
            resultPage.Area1.Text = "Area result : " + result1.ToString();
            resultPage.Area2.Text = "Area result : " + result2.ToString();
            resultPage.TypeText1.Text = ShapeText1;
            resultPage.TypeText2.Text = ShapeText2;
            resultPage.Show();
        }

        public void ShapeModeDefine(ShapeMode1 Shape1, ShapeMode2 Shape2)
        {
            switch (Shape1)
            {
                case ShapeMode1.Square1:
                    resultPage.Square1Width.Visible = true;
                    resultPage.Square1Height.Visible = true;
                    resultPage.Square1Width.Text = "Width : " + WidthInput1.Text;
                    resultPage.Square1Height.Text = "Height : " + HeightInput1.Text;
                    result1 = Math.Round(double.Parse(WidthInput1.Text) * double.Parse(HeightInput1.Text),2);
                    ShapeText1 = "Squre";
                    resultPage.ShapePicture1.Image = Properties.Resources.square;
                    break;

                case ShapeMode1.Triangle1:
                    resultPage.Triangle1Base.Visible = true;
                    resultPage.Triangle1Height.Visible = true;
                    resultPage.Triangle1SideLength.Visible = true;
                    double SideLength = Math.Round(Math.Sqrt(Math.Pow(double.Parse(TriangleBase1.Text) / 2, 2) + Math.Pow(double.Parse(TriangleHeight1.Text), 2)),2);
                    resultPage.Triangle1SideLength.Text = "Side Length : " + SideLength.ToString();
                    resultPage.Triangle1Height.Text = "Height : " + TriangleHeight1.Text;
                    resultPage.Triangle1Base.Text = "Base : " + TriangleBase1.Text;
                    result1 = (double.Parse(TriangleBase1.Text) * double.Parse(TriangleHeight1.Text))/2;
                    ShapeText1 = "Triangle";
                    resultPage.ShapePicture1.Image = Properties.Resources.triangle;
                    break;

                case ShapeMode1.Circle1:
                    resultPage.Radius1.Visible = true;
                    resultPage.Radius1.Text = "Radius : " + CircleRadius1.Text;
                    resultPage.Circle1Circumference.Visible = true;
                    resultPage.Circle1Circumference.Text = "Circumference : " + Math.Round((2 * double.Parse(CircleRadius1.Text) * 22 / 7),2);
                    result1 = Math.Round((double.Parse(CircleRadius1.Text) * double.Parse(CircleRadius1.Text)) * 22/7,2);
                    ShapeText1 = "Circle";
                    resultPage.ShapePicture1.Image = Properties.Resources.circle1;
                    break;
            }
            switch (Shape2)
            {
                case ShapeMode2.Square2:
                    resultPage.Square2Width.Visible = true;
                    resultPage.Square2Height.Visible = true;
                    resultPage.Square2Width.Text = "Width : " + WidthInput2.Text;
                    resultPage.Square2Height.Text = "Height : " + HeightInput2.Text;
                    result2 = Math.Round(double.Parse(WidthInput2.Text) * double.Parse(HeightInput2.Text),2);
                    ShapeText2 = "Squre";
                    resultPage.ShapePicture2.Image = Properties.Resources.square;
                    break;

                case ShapeMode2.Triangle2:
                    resultPage.Triangle2Base.Visible = true;
                    resultPage.Triangle2Height.Visible = true;
                    resultPage.Triangle2SideLength.Visible = true;
                    double SideLength = Math.Round(Math.Sqrt(Math.Pow(double.Parse(TriangleBase2.Text) / 2, 2) + Math.Pow(double.Parse(TriangleHeight2.Text), 2)),2);
                    resultPage.Triangle2SideLength.Text = "Side Length : " + SideLength.ToString();
                    resultPage.Triangle2Height.Text = "Height : " + TriangleHeight2.Text;
                    resultPage.Triangle2Base.Text = "Base : "+TriangleBase2.Text;
                    result2 = (double.Parse(TriangleBase2.Text) * double.Parse(TriangleHeight2.Text)) / 2;
                    ShapeText2 = "Triangle";
                    resultPage.ShapePicture2.Image = Properties.Resources.triangle;
                    break;

                case ShapeMode2.Circle2:
                    resultPage.Radius2.Visible = true;
                    resultPage.Radius2.Text = "Radius : " + CircleRadius2.Text;
                    resultPage.Circle2Circumference.Visible = true;
                    resultPage.Circle2Circumference.Text = "Circumference : " + Math.Round((2 * double.Parse(CircleRadius2.Text) * 22/7),2);
                    result2 = Math.Round((double.Parse(CircleRadius2.Text) * double.Parse(CircleRadius2.Text)) * 22 / 7,2);
                    ShapeText2 = "Circle";
                    resultPage.ShapePicture2.Image = Properties.Resources.circle1;
                    break;
            }
        }

        private void WidthInput1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Square1Button_Click(object sender, EventArgs e)
        {
            SquarePanel1.Visible = true;
            TrianglePanel1.Visible = false;
            CirclePanel1.Visible = false;
            ShapeChoose1 = ShapeMode1.Square1;
            CurrentMode1.Text = "Mode : Square";
        }

        private void Triangle1Button_Click(object sender, EventArgs e)
        {
            TrianglePanel1.Visible = true;
            ShapeChoose1 = ShapeMode1.Triangle1;
            CurrentMode1.Text = "Mode : Triangle";
        }

        private void Square2Button_Click(object sender, EventArgs e)
        {
            SquarePanel2.Visible = true;
            TrianglePanel2.Visible = false;
            CirclePanel2.Visible = false;
            ShapeChoose2 = ShapeMode2.Square2;
            CurrentMode2.Text = "Mode : Square";
        }

        private void Triangle2Button_Click(object sender, EventArgs e)
        {
            SquarePanel2.Visible = false;
            TrianglePanel2.Visible = true;
            CirclePanel2.Visible = false;
            ShapeChoose2 = ShapeMode2.Triangle2;
            CurrentMode2.Text = "Mode : Triangle";
        }

        private void Circle2Button_Click(object sender, EventArgs e)
        {
            SquarePanel2.Visible = false;
            TrianglePanel2.Visible = false;
            CirclePanel2.Visible = true;
            ShapeChoose2 = ShapeMode2.Circle2;
            CurrentMode2.Text = "Mode : Circle";
        }

        private void Circle1Button_Click(object sender, EventArgs e)
        {
            CirclePanel1.Visible = true;
            ShapeChoose1 = ShapeMode1.Circle1;
            CurrentMode1.Text = "Mode : Circle";
        }

        private void CircleRadius2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

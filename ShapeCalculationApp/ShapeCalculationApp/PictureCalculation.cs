using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculationApp
{
    class PictureCalculation
    {
        public ResultCalculation resultPage;

        //Shape 1
        public void CalculateTriangle1(/*double Base, double Height*/)
        {
            resultPage.Triangle1Base.Visible = true;
            resultPage.Triangle1Height.Visible = true;
            resultPage.Triangle1SideLength.Visible = true;
            //double SideLength = Math.Sqrt(Math.Pow(Base/2, 2) + Math.Pow(Height,2));
            //resultPage.Triangle1SideLength.Text = "Side Length : " + SideLength.ToString();
        }
        public void CalculateSquare1()
        {

        }
        public void CalculateCircle1()
        {

        }
        //Shape 2
        public void CalculateTriangle2()
        {

        }
        public void CalculateSquare2()
        {

        }
        public void CalculateCircle2()
        {

        }
    }
}

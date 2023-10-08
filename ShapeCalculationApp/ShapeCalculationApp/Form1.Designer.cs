
namespace ShapeCalculationApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DescText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SquarePanel1 = new System.Windows.Forms.Panel();
            this.TrianglePanel1 = new System.Windows.Forms.Panel();
            this.CirclePanel1 = new System.Windows.Forms.Panel();
            this.CircleRadius1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TriangleHeight1 = new System.Windows.Forms.TextBox();
            this.TriangleBase1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WidthInput1 = new System.Windows.Forms.TextBox();
            this.HeightInput1 = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.Label();
            this.width1 = new System.Windows.Forms.Label();
            this.Square1Button = new System.Windows.Forms.Button();
            this.Circle1Button = new System.Windows.Forms.Button();
            this.Shape1 = new System.Windows.Forms.Label();
            this.Shape2Text = new System.Windows.Forms.Label();
            this.Circle2Button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CirclePanel2 = new System.Windows.Forms.Panel();
            this.CircleRadius2 = new System.Windows.Forms.TextBox();
            this.RadiusText = new System.Windows.Forms.Label();
            this.TrianglePanel2 = new System.Windows.Forms.Panel();
            this.TriangleHeight2 = new System.Windows.Forms.TextBox();
            this.TriangleBase2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SquarePanel2 = new System.Windows.Forms.Panel();
            this.HeightInput2 = new System.Windows.Forms.TextBox();
            this.WidthInput2 = new System.Windows.Forms.TextBox();
            this.height2 = new System.Windows.Forms.Label();
            this.width2 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.Triangle1Button = new System.Windows.Forms.Button();
            this.Triangle2Button = new System.Windows.Forms.Button();
            this.Square2Button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SquarePanel1.SuspendLayout();
            this.TrianglePanel1.SuspendLayout();
            this.CirclePanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.CirclePanel2.SuspendLayout();
            this.TrianglePanel2.SuspendLayout();
            this.SquarePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DescText
            // 
            this.DescText.AutoSize = true;
            this.DescText.Location = new System.Drawing.Point(14, 19);
            this.DescText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DescText.Name = "DescText";
            this.DescText.Size = new System.Drawing.Size(117, 13);
            this.DescText.TabIndex = 0;
            this.DescText.Text = "SHAPE CALCULATOR";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SquarePanel1);
            this.panel1.Location = new System.Drawing.Point(27, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 288);
            this.panel1.TabIndex = 2;
            // 
            // SquarePanel1
            // 
            this.SquarePanel1.Controls.Add(this.TrianglePanel1);
            this.SquarePanel1.Controls.Add(this.WidthInput1);
            this.SquarePanel1.Controls.Add(this.HeightInput1);
            this.SquarePanel1.Controls.Add(this.height);
            this.SquarePanel1.Controls.Add(this.width1);
            this.SquarePanel1.Location = new System.Drawing.Point(34, 16);
            this.SquarePanel1.Name = "SquarePanel1";
            this.SquarePanel1.Size = new System.Drawing.Size(243, 83);
            this.SquarePanel1.TabIndex = 3;
            // 
            // TrianglePanel1
            // 
            this.TrianglePanel1.Controls.Add(this.CirclePanel1);
            this.TrianglePanel1.Controls.Add(this.TriangleHeight1);
            this.TrianglePanel1.Controls.Add(this.TriangleBase1);
            this.TrianglePanel1.Controls.Add(this.label3);
            this.TrianglePanel1.Controls.Add(this.label4);
            this.TrianglePanel1.Location = new System.Drawing.Point(0, 0);
            this.TrianglePanel1.Name = "TrianglePanel1";
            this.TrianglePanel1.Size = new System.Drawing.Size(243, 82);
            this.TrianglePanel1.TabIndex = 5;
            // 
            // CirclePanel1
            // 
            this.CirclePanel1.Controls.Add(this.CircleRadius1);
            this.CirclePanel1.Controls.Add(this.label5);
            this.CirclePanel1.Location = new System.Drawing.Point(0, 0);
            this.CirclePanel1.Name = "CirclePanel1";
            this.CirclePanel1.Size = new System.Drawing.Size(243, 62);
            this.CirclePanel1.TabIndex = 5;
            this.CirclePanel1.Visible = false;
            // 
            // CircleRadius1
            // 
            this.CircleRadius1.Location = new System.Drawing.Point(80, 20);
            this.CircleRadius1.Name = "CircleRadius1";
            this.CircleRadius1.Size = new System.Drawing.Size(109, 20);
            this.CircleRadius1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "RADIUS :";
            // 
            // TriangleHeight1
            // 
            this.TriangleHeight1.Location = new System.Drawing.Point(80, 49);
            this.TriangleHeight1.Name = "TriangleHeight1";
            this.TriangleHeight1.Size = new System.Drawing.Size(109, 20);
            this.TriangleHeight1.TabIndex = 3;
            // 
            // TriangleBase1
            // 
            this.TriangleBase1.Location = new System.Drawing.Point(80, 20);
            this.TriangleBase1.Name = "TriangleBase1";
            this.TriangleBase1.Size = new System.Drawing.Size(109, 20);
            this.TriangleBase1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "HEIGHT :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "BASE :";
            // 
            // WidthInput1
            // 
            this.WidthInput1.Location = new System.Drawing.Point(85, 20);
            this.WidthInput1.Name = "WidthInput1";
            this.WidthInput1.Size = new System.Drawing.Size(109, 20);
            this.WidthInput1.TabIndex = 6;
            // 
            // HeightInput1
            // 
            this.HeightInput1.Location = new System.Drawing.Point(85, 49);
            this.HeightInput1.Name = "HeightInput1";
            this.HeightInput1.Size = new System.Drawing.Size(109, 20);
            this.HeightInput1.TabIndex = 5;
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Location = new System.Drawing.Point(25, 52);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(54, 13);
            this.height.TabIndex = 3;
            this.height.Text = "HEIGHT :";
            // 
            // width1
            // 
            this.width1.AutoSize = true;
            this.width1.Location = new System.Drawing.Point(25, 23);
            this.width1.Name = "width1";
            this.width1.Size = new System.Drawing.Size(50, 13);
            this.width1.TabIndex = 2;
            this.width1.Text = "WIDTH :";
            // 
            // Square1Button
            // 
            this.Square1Button.Location = new System.Drawing.Point(27, 66);
            this.Square1Button.Name = "Square1Button";
            this.Square1Button.Size = new System.Drawing.Size(74, 28);
            this.Square1Button.TabIndex = 3;
            this.Square1Button.Text = "SQUARE";
            this.Square1Button.UseVisualStyleBackColor = true;
            this.Square1Button.Click += new System.EventHandler(this.Square1Button_Click);
            // 
            // Circle1Button
            // 
            this.Circle1Button.Location = new System.Drawing.Point(187, 66);
            this.Circle1Button.Name = "Circle1Button";
            this.Circle1Button.Size = new System.Drawing.Size(74, 28);
            this.Circle1Button.TabIndex = 5;
            this.Circle1Button.Text = "CIRCLE";
            this.Circle1Button.UseVisualStyleBackColor = true;
            this.Circle1Button.Click += new System.EventHandler(this.Circle1Button_Click);
            // 
            // Shape1
            // 
            this.Shape1.AutoSize = true;
            this.Shape1.Location = new System.Drawing.Point(153, 39);
            this.Shape1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Shape1.Name = "Shape1";
            this.Shape1.Size = new System.Drawing.Size(52, 13);
            this.Shape1.TabIndex = 6;
            this.Shape1.Text = "SHAPE 1";
            // 
            // Shape2Text
            // 
            this.Shape2Text.AutoSize = true;
            this.Shape2Text.Location = new System.Drawing.Point(539, 39);
            this.Shape2Text.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Shape2Text.Name = "Shape2Text";
            this.Shape2Text.Size = new System.Drawing.Size(52, 13);
            this.Shape2Text.TabIndex = 11;
            this.Shape2Text.Text = "SHAPE 2";
            // 
            // Circle2Button
            // 
            this.Circle2Button.Location = new System.Drawing.Point(573, 66);
            this.Circle2Button.Name = "Circle2Button";
            this.Circle2Button.Size = new System.Drawing.Size(74, 28);
            this.Circle2Button.TabIndex = 10;
            this.Circle2Button.Text = "CIRCLE";
            this.Circle2Button.UseVisualStyleBackColor = true;
            this.Circle2Button.Click += new System.EventHandler(this.Circle2Button_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CirclePanel2);
            this.panel2.Controls.Add(this.TrianglePanel2);
            this.panel2.Controls.Add(this.SquarePanel2);
            this.panel2.Location = new System.Drawing.Point(413, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 288);
            this.panel2.TabIndex = 7;
            // 
            // CirclePanel2
            // 
            this.CirclePanel2.Controls.Add(this.CircleRadius2);
            this.CirclePanel2.Controls.Add(this.RadiusText);
            this.CirclePanel2.Location = new System.Drawing.Point(36, 16);
            this.CirclePanel2.Name = "CirclePanel2";
            this.CirclePanel2.Size = new System.Drawing.Size(243, 62);
            this.CirclePanel2.TabIndex = 4;
            this.CirclePanel2.Visible = false;
            // 
            // CircleRadius2
            // 
            this.CircleRadius2.Location = new System.Drawing.Point(80, 20);
            this.CircleRadius2.Name = "CircleRadius2";
            this.CircleRadius2.Size = new System.Drawing.Size(109, 20);
            this.CircleRadius2.TabIndex = 2;
            // 
            // RadiusText
            // 
            this.RadiusText.AutoSize = true;
            this.RadiusText.Location = new System.Drawing.Point(20, 23);
            this.RadiusText.Name = "RadiusText";
            this.RadiusText.Size = new System.Drawing.Size(54, 13);
            this.RadiusText.TabIndex = 0;
            this.RadiusText.Text = "RADIUS :";
            // 
            // TrianglePanel2
            // 
            this.TrianglePanel2.Controls.Add(this.TriangleHeight2);
            this.TrianglePanel2.Controls.Add(this.TriangleBase2);
            this.TrianglePanel2.Controls.Add(this.label1);
            this.TrianglePanel2.Controls.Add(this.label2);
            this.TrianglePanel2.Location = new System.Drawing.Point(36, 16);
            this.TrianglePanel2.Name = "TrianglePanel2";
            this.TrianglePanel2.Size = new System.Drawing.Size(243, 82);
            this.TrianglePanel2.TabIndex = 4;
            // 
            // TriangleHeight2
            // 
            this.TriangleHeight2.Location = new System.Drawing.Point(80, 49);
            this.TriangleHeight2.Name = "TriangleHeight2";
            this.TriangleHeight2.Size = new System.Drawing.Size(109, 20);
            this.TriangleHeight2.TabIndex = 3;
            // 
            // TriangleBase2
            // 
            this.TriangleBase2.Location = new System.Drawing.Point(80, 20);
            this.TriangleBase2.Name = "TriangleBase2";
            this.TriangleBase2.Size = new System.Drawing.Size(109, 20);
            this.TriangleBase2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "HEIGHT :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "BASE :";
            // 
            // SquarePanel2
            // 
            this.SquarePanel2.Controls.Add(this.HeightInput2);
            this.SquarePanel2.Controls.Add(this.WidthInput2);
            this.SquarePanel2.Controls.Add(this.height2);
            this.SquarePanel2.Controls.Add(this.width2);
            this.SquarePanel2.Location = new System.Drawing.Point(36, 16);
            this.SquarePanel2.Name = "SquarePanel2";
            this.SquarePanel2.Size = new System.Drawing.Size(243, 83);
            this.SquarePanel2.TabIndex = 2;
            // 
            // HeightInput2
            // 
            this.HeightInput2.Location = new System.Drawing.Point(80, 49);
            this.HeightInput2.Name = "HeightInput2";
            this.HeightInput2.Size = new System.Drawing.Size(109, 20);
            this.HeightInput2.TabIndex = 3;
            // 
            // WidthInput2
            // 
            this.WidthInput2.Location = new System.Drawing.Point(80, 20);
            this.WidthInput2.Name = "WidthInput2";
            this.WidthInput2.Size = new System.Drawing.Size(109, 20);
            this.WidthInput2.TabIndex = 2;
            // 
            // height2
            // 
            this.height2.AutoSize = true;
            this.height2.Location = new System.Drawing.Point(20, 52);
            this.height2.Name = "height2";
            this.height2.Size = new System.Drawing.Size(54, 13);
            this.height2.TabIndex = 1;
            this.height2.Text = "HEIGHT :";
            // 
            // width2
            // 
            this.width2.AutoSize = true;
            this.width2.Location = new System.Drawing.Point(20, 23);
            this.width2.Name = "width2";
            this.width2.Size = new System.Drawing.Size(50, 13);
            this.width2.TabIndex = 0;
            this.width2.Text = "WIDTH :";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(280, 406);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(207, 32);
            this.CalculateButton.TabIndex = 12;
            this.CalculateButton.Text = "CALCULATE!";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Triangle1Button
            // 
            this.Triangle1Button.Location = new System.Drawing.Point(107, 66);
            this.Triangle1Button.Name = "Triangle1Button";
            this.Triangle1Button.Size = new System.Drawing.Size(74, 28);
            this.Triangle1Button.TabIndex = 13;
            this.Triangle1Button.Text = "TRIANGLE";
            this.Triangle1Button.UseVisualStyleBackColor = true;
            this.Triangle1Button.Click += new System.EventHandler(this.Triangle1Button_Click);
            // 
            // Triangle2Button
            // 
            this.Triangle2Button.Location = new System.Drawing.Point(493, 66);
            this.Triangle2Button.Name = "Triangle2Button";
            this.Triangle2Button.Size = new System.Drawing.Size(74, 28);
            this.Triangle2Button.TabIndex = 15;
            this.Triangle2Button.Text = "TRIANGLE";
            this.Triangle2Button.UseVisualStyleBackColor = true;
            this.Triangle2Button.Click += new System.EventHandler(this.Triangle2Button_Click);
            // 
            // Square2Button
            // 
            this.Square2Button.Location = new System.Drawing.Point(413, 66);
            this.Square2Button.Name = "Square2Button";
            this.Square2Button.Size = new System.Drawing.Size(74, 28);
            this.Square2Button.TabIndex = 14;
            this.Square2Button.Text = "SQUARE";
            this.Square2Button.UseVisualStyleBackColor = true;
            this.Square2Button.Click += new System.EventHandler(this.Square2Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Triangle2Button);
            this.Controls.Add(this.Square2Button);
            this.Controls.Add(this.Triangle1Button);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.Shape2Text);
            this.Controls.Add(this.Shape1);
            this.Controls.Add(this.Circle2Button);
            this.Controls.Add(this.Circle1Button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Square1Button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DescText);
            this.Name = "Form1";
            this.Text = "Shape Calculator App";
            this.panel1.ResumeLayout(false);
            this.SquarePanel1.ResumeLayout(false);
            this.SquarePanel1.PerformLayout();
            this.TrianglePanel1.ResumeLayout(false);
            this.TrianglePanel1.PerformLayout();
            this.CirclePanel1.ResumeLayout(false);
            this.CirclePanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.CirclePanel2.ResumeLayout(false);
            this.CirclePanel2.PerformLayout();
            this.TrianglePanel2.ResumeLayout(false);
            this.TrianglePanel2.PerformLayout();
            this.SquarePanel2.ResumeLayout(false);
            this.SquarePanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DescText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Square1Button;
        private System.Windows.Forms.Button Circle1Button;
        private System.Windows.Forms.Label Shape1;
        private System.Windows.Forms.Label Shape2Text;
        private System.Windows.Forms.Button Circle2Button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button Triangle1Button;
        private System.Windows.Forms.Panel SquarePanel1;
        private System.Windows.Forms.Panel SquarePanel2;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label width1;
        private System.Windows.Forms.Label height2;
        private System.Windows.Forms.Label width2;
        public System.Windows.Forms.TextBox HeightInput1;
        public System.Windows.Forms.TextBox HeightInput2;
        public System.Windows.Forms.TextBox WidthInput2;
        public System.Windows.Forms.TextBox WidthInput1;
        private System.Windows.Forms.Panel TrianglePanel1;
        public System.Windows.Forms.TextBox TriangleHeight1;
        public System.Windows.Forms.TextBox TriangleBase1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel TrianglePanel2;
        public System.Windows.Forms.TextBox TriangleHeight2;
        public System.Windows.Forms.TextBox TriangleBase2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Triangle2Button;
        private System.Windows.Forms.Button Square2Button;
        private System.Windows.Forms.Panel CirclePanel2;
        public System.Windows.Forms.TextBox CircleRadius2;
        private System.Windows.Forms.Label RadiusText;
        private System.Windows.Forms.Panel CirclePanel1;
        public System.Windows.Forms.TextBox CircleRadius1;
        private System.Windows.Forms.Label label5;
    }
}


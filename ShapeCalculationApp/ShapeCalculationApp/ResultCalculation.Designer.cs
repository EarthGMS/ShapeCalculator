
namespace ShapeCalculationApp
{
    partial class ResultCalculation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.Area1 = new System.Windows.Forms.Label();
            this.Area2 = new System.Windows.Forms.Label();
            this.TypeText2 = new System.Windows.Forms.Label();
            this.TypeText1 = new System.Windows.Forms.Label();
            this.ShapePicture1 = new System.Windows.Forms.PictureBox();
            this.ShapePicture2 = new System.Windows.Forms.PictureBox();
            this.Triangle2Height = new System.Windows.Forms.Label();
            this.Triangle2Base = new System.Windows.Forms.Label();
            this.Triangle2SideLength = new System.Windows.Forms.Label();
            this.Triangle1Height = new System.Windows.Forms.Label();
            this.Triangle1SideLength = new System.Windows.Forms.Label();
            this.Triangle1Base = new System.Windows.Forms.Label();
            this.Radius2 = new System.Windows.Forms.Label();
            this.Radius1 = new System.Windows.Forms.Label();
            this.Circle1Circumference = new System.Windows.Forms.Label();
            this.Circle2Circumference = new System.Windows.Forms.Label();
            this.Square2Width = new System.Windows.Forms.Label();
            this.Square2Height = new System.Windows.Forms.Label();
            this.Square1Width = new System.Windows.Forms.Label();
            this.Square1Height = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ShapePicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShapePicture2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(265, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "AREA RESULTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SHAPE 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SHAPE 2";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(333, 403);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(118, 35);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "BACK";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Area1
            // 
            this.Area1.AutoSize = true;
            this.Area1.Location = new System.Drawing.Point(145, 154);
            this.Area1.Name = "Area1";
            this.Area1.Size = new System.Drawing.Size(35, 13);
            this.Area1.TabIndex = 5;
            this.Area1.Text = "label4";
            // 
            // Area2
            // 
            this.Area2.AutoSize = true;
            this.Area2.Location = new System.Drawing.Point(565, 154);
            this.Area2.Name = "Area2";
            this.Area2.Size = new System.Drawing.Size(35, 13);
            this.Area2.TabIndex = 6;
            this.Area2.Text = "label4";
            // 
            // TypeText2
            // 
            this.TypeText2.AutoSize = true;
            this.TypeText2.Location = new System.Drawing.Point(563, 126);
            this.TypeText2.Name = "TypeText2";
            this.TypeText2.Size = new System.Drawing.Size(37, 13);
            this.TypeText2.TabIndex = 7;
            this.TypeText2.Text = "Type :";
            // 
            // TypeText1
            // 
            this.TypeText1.AutoSize = true;
            this.TypeText1.Location = new System.Drawing.Point(143, 126);
            this.TypeText1.Name = "TypeText1";
            this.TypeText1.Size = new System.Drawing.Size(37, 13);
            this.TypeText1.TabIndex = 8;
            this.TypeText1.Text = "Type :";
            // 
            // ShapePicture1
            // 
            this.ShapePicture1.Image = global::ShapeCalculationApp.Properties.Resources.square;
            this.ShapePicture1.Location = new System.Drawing.Point(86, 193);
            this.ShapePicture1.Name = "ShapePicture1";
            this.ShapePicture1.Size = new System.Drawing.Size(170, 170);
            this.ShapePicture1.TabIndex = 10;
            this.ShapePicture1.TabStop = false;
            // 
            // ShapePicture2
            // 
            this.ShapePicture2.Image = global::ShapeCalculationApp.Properties.Resources.square;
            this.ShapePicture2.Location = new System.Drawing.Point(503, 193);
            this.ShapePicture2.Name = "ShapePicture2";
            this.ShapePicture2.Size = new System.Drawing.Size(170, 170);
            this.ShapePicture2.TabIndex = 9;
            this.ShapePicture2.TabStop = false;
            // 
            // Triangle2Height
            // 
            this.Triangle2Height.AutoSize = true;
            this.Triangle2Height.BackColor = System.Drawing.SystemColors.Menu;
            this.Triangle2Height.Location = new System.Drawing.Point(563, 291);
            this.Triangle2Height.Name = "Triangle2Height";
            this.Triangle2Height.Size = new System.Drawing.Size(35, 13);
            this.Triangle2Height.TabIndex = 11;
            this.Triangle2Height.Text = "label4";
            this.Triangle2Height.Visible = false;
            // 
            // Triangle2Base
            // 
            this.Triangle2Base.AutoSize = true;
            this.Triangle2Base.BackColor = System.Drawing.SystemColors.Menu;
            this.Triangle2Base.Location = new System.Drawing.Point(565, 366);
            this.Triangle2Base.Name = "Triangle2Base";
            this.Triangle2Base.Size = new System.Drawing.Size(35, 13);
            this.Triangle2Base.TabIndex = 12;
            this.Triangle2Base.Text = "label4";
            this.Triangle2Base.Visible = false;
            // 
            // Triangle2SideLength
            // 
            this.Triangle2SideLength.AutoSize = true;
            this.Triangle2SideLength.BackColor = System.Drawing.SystemColors.Menu;
            this.Triangle2SideLength.Location = new System.Drawing.Point(638, 261);
            this.Triangle2SideLength.Name = "Triangle2SideLength";
            this.Triangle2SideLength.Size = new System.Drawing.Size(35, 13);
            this.Triangle2SideLength.TabIndex = 13;
            this.Triangle2SideLength.Text = "label4";
            this.Triangle2SideLength.Visible = false;
            // 
            // Triangle1Height
            // 
            this.Triangle1Height.AutoSize = true;
            this.Triangle1Height.BackColor = System.Drawing.SystemColors.Menu;
            this.Triangle1Height.Location = new System.Drawing.Point(145, 291);
            this.Triangle1Height.Name = "Triangle1Height";
            this.Triangle1Height.Size = new System.Drawing.Size(35, 13);
            this.Triangle1Height.TabIndex = 14;
            this.Triangle1Height.Text = "label4";
            this.Triangle1Height.Visible = false;
            // 
            // Triangle1SideLength
            // 
            this.Triangle1SideLength.AutoSize = true;
            this.Triangle1SideLength.BackColor = System.Drawing.SystemColors.Menu;
            this.Triangle1SideLength.Location = new System.Drawing.Point(221, 261);
            this.Triangle1SideLength.Name = "Triangle1SideLength";
            this.Triangle1SideLength.Size = new System.Drawing.Size(35, 13);
            this.Triangle1SideLength.TabIndex = 15;
            this.Triangle1SideLength.Text = "label4";
            this.Triangle1SideLength.Visible = false;
            // 
            // Triangle1Base
            // 
            this.Triangle1Base.AutoSize = true;
            this.Triangle1Base.BackColor = System.Drawing.SystemColors.Menu;
            this.Triangle1Base.Location = new System.Drawing.Point(145, 366);
            this.Triangle1Base.Name = "Triangle1Base";
            this.Triangle1Base.Size = new System.Drawing.Size(35, 13);
            this.Triangle1Base.TabIndex = 16;
            this.Triangle1Base.Text = "label4";
            this.Triangle1Base.Visible = false;
            // 
            // Radius2
            // 
            this.Radius2.AutoSize = true;
            this.Radius2.BackColor = System.Drawing.SystemColors.Menu;
            this.Radius2.Location = new System.Drawing.Point(604, 291);
            this.Radius2.Name = "Radius2";
            this.Radius2.Size = new System.Drawing.Size(35, 13);
            this.Radius2.TabIndex = 17;
            this.Radius2.Text = "label4";
            this.Radius2.Visible = false;
            // 
            // Radius1
            // 
            this.Radius1.AutoSize = true;
            this.Radius1.BackColor = System.Drawing.SystemColors.Menu;
            this.Radius1.Location = new System.Drawing.Point(186, 291);
            this.Radius1.Name = "Radius1";
            this.Radius1.Size = new System.Drawing.Size(35, 13);
            this.Radius1.TabIndex = 18;
            this.Radius1.Text = "label4";
            this.Radius1.Visible = false;
            // 
            // Circle1Circumference
            // 
            this.Circle1Circumference.AutoSize = true;
            this.Circle1Circumference.BackColor = System.Drawing.SystemColors.Menu;
            this.Circle1Circumference.Location = new System.Drawing.Point(262, 274);
            this.Circle1Circumference.Name = "Circle1Circumference";
            this.Circle1Circumference.Size = new System.Drawing.Size(35, 13);
            this.Circle1Circumference.TabIndex = 19;
            this.Circle1Circumference.Text = "label4";
            this.Circle1Circumference.Visible = false;
            // 
            // Circle2Circumference
            // 
            this.Circle2Circumference.AutoSize = true;
            this.Circle2Circumference.BackColor = System.Drawing.SystemColors.Menu;
            this.Circle2Circumference.Location = new System.Drawing.Point(679, 274);
            this.Circle2Circumference.Name = "Circle2Circumference";
            this.Circle2Circumference.Size = new System.Drawing.Size(35, 13);
            this.Circle2Circumference.TabIndex = 20;
            this.Circle2Circumference.Text = "label4";
            this.Circle2Circumference.Visible = false;
            // 
            // Square2Width
            // 
            this.Square2Width.AutoSize = true;
            this.Square2Width.BackColor = System.Drawing.SystemColors.Menu;
            this.Square2Width.Location = new System.Drawing.Point(565, 177);
            this.Square2Width.Name = "Square2Width";
            this.Square2Width.Size = new System.Drawing.Size(35, 13);
            this.Square2Width.TabIndex = 21;
            this.Square2Width.Text = "label4";
            this.Square2Width.Visible = false;
            // 
            // Square2Height
            // 
            this.Square2Height.AutoSize = true;
            this.Square2Height.BackColor = System.Drawing.SystemColors.Menu;
            this.Square2Height.Location = new System.Drawing.Point(453, 274);
            this.Square2Height.Name = "Square2Height";
            this.Square2Height.Size = new System.Drawing.Size(35, 13);
            this.Square2Height.TabIndex = 22;
            this.Square2Height.Text = "label4";
            this.Square2Height.Visible = false;
            // 
            // Square1Width
            // 
            this.Square1Width.AutoSize = true;
            this.Square1Width.BackColor = System.Drawing.SystemColors.Menu;
            this.Square1Width.Location = new System.Drawing.Point(145, 177);
            this.Square1Width.Name = "Square1Width";
            this.Square1Width.Size = new System.Drawing.Size(35, 13);
            this.Square1Width.TabIndex = 23;
            this.Square1Width.Text = "label4";
            this.Square1Width.Visible = false;
            // 
            // Square1Height
            // 
            this.Square1Height.AutoSize = true;
            this.Square1Height.BackColor = System.Drawing.SystemColors.Menu;
            this.Square1Height.Location = new System.Drawing.Point(34, 274);
            this.Square1Height.Name = "Square1Height";
            this.Square1Height.Size = new System.Drawing.Size(35, 13);
            this.Square1Height.TabIndex = 24;
            this.Square1Height.Text = "label4";
            this.Square1Height.Visible = false;
            // 
            // ResultCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Square1Height);
            this.Controls.Add(this.Square1Width);
            this.Controls.Add(this.Square2Height);
            this.Controls.Add(this.Square2Width);
            this.Controls.Add(this.Circle2Circumference);
            this.Controls.Add(this.Circle1Circumference);
            this.Controls.Add(this.Radius1);
            this.Controls.Add(this.Radius2);
            this.Controls.Add(this.Triangle1Base);
            this.Controls.Add(this.Triangle1SideLength);
            this.Controls.Add(this.Triangle1Height);
            this.Controls.Add(this.Triangle2SideLength);
            this.Controls.Add(this.Triangle2Base);
            this.Controls.Add(this.Triangle2Height);
            this.Controls.Add(this.ShapePicture1);
            this.Controls.Add(this.ShapePicture2);
            this.Controls.Add(this.TypeText1);
            this.Controls.Add(this.TypeText2);
            this.Controls.Add(this.Area2);
            this.Controls.Add(this.Area1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ResultCalculation";
            this.Text = "ResultCalculation";
            ((System.ComponentModel.ISupportInitialize)(this.ShapePicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShapePicture2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BackButton;
        public System.Windows.Forms.Label Area2;
        public System.Windows.Forms.Label Area1;
        public System.Windows.Forms.Label TypeText2;
        public System.Windows.Forms.Label TypeText1;
        public System.Windows.Forms.PictureBox ShapePicture2;
        public System.Windows.Forms.PictureBox ShapePicture1;
        public System.Windows.Forms.Label Triangle2Height;
        public System.Windows.Forms.Label Triangle2Base;
        public System.Windows.Forms.Label Triangle2SideLength;
        public System.Windows.Forms.Label Triangle1Height;
        public System.Windows.Forms.Label Triangle1SideLength;
        public System.Windows.Forms.Label Triangle1Base;
        public System.Windows.Forms.Label Radius2;
        public System.Windows.Forms.Label Radius1;
        public System.Windows.Forms.Label Circle1Circumference;
        public System.Windows.Forms.Label Circle2Circumference;
        public System.Windows.Forms.Label Square2Width;
        public System.Windows.Forms.Label Square2Height;
        public System.Windows.Forms.Label Square1Width;
        public System.Windows.Forms.Label Square1Height;
    }
}
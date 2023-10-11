
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
            this.ShapePicture1.Image = global::ShapeCalculationApp.Properties.Resources.triangle;
            this.ShapePicture1.Location = new System.Drawing.Point(86, 193);
            this.ShapePicture1.Name = "ShapePicture1";
            this.ShapePicture1.Size = new System.Drawing.Size(170, 170);
            this.ShapePicture1.TabIndex = 10;
            this.ShapePicture1.TabStop = false;
            // 
            // ShapePicture2
            // 
            this.ShapePicture2.Image = global::ShapeCalculationApp.Properties.Resources.triangle;
            this.ShapePicture2.Location = new System.Drawing.Point(503, 193);
            this.ShapePicture2.Name = "ShapePicture2";
            this.ShapePicture2.Size = new System.Drawing.Size(170, 170);
            this.ShapePicture2.TabIndex = 9;
            this.ShapePicture2.TabStop = false;
            // 
            // ResultCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}
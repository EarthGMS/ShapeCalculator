
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RESULTS";
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
            // 
            // Area1
            // 
            this.Area1.AutoSize = true;
            this.Area1.Location = new System.Drawing.Point(143, 189);
            this.Area1.Name = "Area1";
            this.Area1.Size = new System.Drawing.Size(35, 13);
            this.Area1.TabIndex = 5;
            this.Area1.Text = "label4";
            // 
            // Area2
            // 
            this.Area2.AutoSize = true;
            this.Area2.Location = new System.Drawing.Point(563, 189);
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
            // ResultCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}
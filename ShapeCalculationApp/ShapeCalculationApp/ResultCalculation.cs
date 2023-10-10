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
    public partial class ResultCalculation : Form
    {
        public Form1 ModeForm;
        public ResultCalculation()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ModeForm = new Form1();
            ModeForm.Show();
            Hide();
        }
    }
}

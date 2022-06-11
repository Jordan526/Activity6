using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        String weight;
        private void SelfWeightBox_TextChanged(object sender, EventArgs e)
        {


            weight = SelfWeightBox.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                 int userWeight = int.Parse(weight);
                double weightOnMars = (double)(userWeight * 0.38);
                double roundedNumber = (double)Math.Round(weightOnMars, 3);

                MessageBox.Show("Your Weight On Mars Is " + roundedNumber.ToString("#.000") + " Pounds!");
            }
            catch (System.FormatException exception)
            {
                MessageBox.Show("Not a valid format, please try again.");
            }
        }

        private void clearWeight_Click(object sender, EventArgs e)
        {
            SelfWeightBox.Text = "";
        }
    }
}




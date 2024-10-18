using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//in the name of god
//Mahyar Davtalab
namespace calcualate_distance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //import data
            double point1X;
            double point1Y;
            double point2X;
            double point2Y;
            double distance;


            point1X = Convert.ToDouble(textpoint1X.Text);
            point1Y = Convert.ToDouble(textpoint1Y.Text);
            point2X = Convert.ToDouble(textpoint2X.Text);
            point2Y = Convert.ToDouble(textpoint2Y.Text);

            //calculate
            distance = Math.Sqrt(Math.Pow(point2X - point1X, 2) + Math.Pow(point2Y - point1Y, 2));


            //result
            lblresult.Text = Convert.ToString(distance); 

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textpointX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblresult_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

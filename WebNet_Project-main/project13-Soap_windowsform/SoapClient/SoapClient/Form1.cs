using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoapClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateClosestPositionButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the X and Y coordinates entered by the user
                double x = double.Parse(XTextBox.Text);
                double y = double.Parse(YTextBox.Text);

                // Instantiate the web service proxy
                localhost.Geo client = new localhost.Geo();

                // Call the GetClosestPosition method
                localhost.GeoPoint closestPosition = client.GetClosestPosition(x, y);

                // Display the result in a message box or update the UI as needed
                result.Text = $"the Closest point to your interest point is ID={closestPosition.ID} ";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            double DegText, CelText;
            DegText = double.Parse(textBox1.Text);
            CelText = (5.0 / 9.0) * (DegText - 32.0);
            label2.Text = "It is " + CelText.ToString() + " degrees in Celsius.";
            
            if (DegText > 100)
            {
                label3.Text = "It's Hot! Better Hydrate";
                
            }
            else if (DegText <= 32)
            {
                label3.Text = "It's Cold! Better pack long underwear";
                
            }
            
        }

    }
}

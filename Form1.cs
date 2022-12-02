using System;/* Grading ID: S0287, Lab 2, 2/7/2021, CIS 199-02, Program calculates tips using % based off of meal prices*/
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            double price, Tip15, Tip18, Tip20; //Price determination for 3 tip amounts

            const double TIPRATE1 = 0.15; //Refers to variable tip rate of .15
            const double TIPRATE2 = 0.18; //Refers to variable tip rate of .18 
            const double TIPRATE3 = 0.20; //Refers to variable tip rate of .20

            price = double.Parse(Price.Text); //Numbers added from texts
            

            Tip15 = price * TIPRATE1; //Formula for 15% tip
            Tip18 = price * TIPRATE2; //Formula for 18% tip
            Tip20 = price * TIPRATE3;//Formula for 20% tp

            Tip15 = $"{TIPRATE1:C2}"; //Tip rate to 15% ouput
            Tip18 = $"{TIPRATE2:C2}";//Tip rate to 18% output
            Tip20 = $"{TIPRATE3:C2}";//Tip rate to 20% output


        }
    }
}


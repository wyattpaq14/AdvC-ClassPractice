using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string val1 = txtVal1.Text;
            string val2 = txtVal2.Text;
            string debugMsg = "val 1:" + val1 + "      Val2: " + val2;
            MessageBox.Show(debugMsg);
            ValueInput value1 = new ValueInput(val1, val2);
            lblFinalOutput.Text = value1.getValues();



        }
    }
}

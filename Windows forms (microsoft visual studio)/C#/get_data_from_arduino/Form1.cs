using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace get_data_from_arduino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            serialPort1.PortName = "com2";
            serialPort1.Close();

        }

        private void btnOn_Click(object sender, EventArgs e)
        {

            serialPort1.Open();
            serialPort1.WriteLine("1");
            serialPort1.Close();

        }

        private void btnOff_Click(object sender, EventArgs e)
        {

            serialPort1.Open();
            serialPort1.WriteLine("2");
            serialPort1.Close();

        }

        private void btnMonitoring_Click(object sender, EventArgs e)
        {

            serialPort1.Open();
            serialPort1.WriteLine("3");
            txtMonitoring.Text = serialPort1.ReadLine();
            serialPort1.Close();

        }
    }

}

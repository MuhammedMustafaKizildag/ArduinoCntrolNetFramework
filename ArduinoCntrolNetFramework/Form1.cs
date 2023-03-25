using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoCntrolNetFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
        }

        private void ledOn1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1");
        }

        private void ledOff1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("0");
        }

        private void ledOn2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("2");
        }

        private void ledOff2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("3");
        }
    }
}

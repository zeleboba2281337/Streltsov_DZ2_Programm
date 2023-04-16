using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Streltsov_DZ2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, result = 0;
            string operation = comboBox1.SelectedItem.ToString();
            double.TryParse(textBox1.Text, out a);
            double.TryParse(textBox2.Text, out b);
            switch (operation)
            {
                case "+":
                    {
                        result = a + b;
                        break;
                    }
                case "-":
                    {
                        result = a - b;
                        break;
                    }
                case "*":
                    {
                        result = a * b;
                        break;
                    }
                case "/":
                    {
                        result = a / b;
                        break;
                    }
                case "%":
                    {
                        result = a % b;
                        break;
                    }
                case "^":
                    {
                        result = Math.Pow(a,b);
                        break;
                    }
                case "√":
                    {
                        result = Math.Pow(a,1/b);
                        break;
                    }
            }
            label1.Text = result.ToString();
        }
    }
}

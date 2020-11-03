using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCalculatorClone
{
    public partial class Calculator : Form
    {

        String number1 = "0";
        bool change = false;
        bool use_answer = false;
        bool extrafunction = false;
        String number2 = "0";
        String symbol = "";
        String result = "";
        public Calculator()
        {
            InitializeComponent();
        }
        public void number_clicked( String number)
        {
           
            if (!this.change)
            {
                this.number1 += number;              
                
                this.label2.Text = this.number1;
                this.label1.Text = this.number1;

            }
            else
            {  
                    this.number2 += number;
                    this.label2.Text = this.number2;
                    this.label1.Text = this.number1 + this.symbol + this.number2;              
                
            }
            if (this.use_answer == true)
            {
                this.number1 = this.result;
            }


        }

        public void clear()
        {
            this.number1 = "0";
            this.number2 = "0";
            this.symbol = "";
            this.change = false;
            this.extrafunction = false;
        }

        public void symbol_clicked(String sym)
        {
            this.change = true;
            
                if (this.number2 != "0" )
                {
                    this.result_calculator();
                    this.number1 = this.result;
                    this.number2 = "0";
                }

            if (sym == "sqrt")
            {
                this.change = true;
                this.extrafunction = true;
                this.number2 = this.number1;
                this.label1.Text = "sqrt(" + this.number1 + ")"; ;
                this.symbol = "sqrt";
                this.result_calculator();
            }
            else if (sym == "sq")
            {
                this.change = true;
                this.extrafunction = true;
                this.number2 = this.number1;
                this.label1.Text = "sq(" + this.number1 + ")"; ;
                this.symbol = "sq";
                this.result_calculator();
            }
            
            else
            {
                this.change = true;
                this.label1.Text += symbol;
            }
         }

        public void result_calculator() {

            double results =0;

            

           switch(this.symbol)
            {
                case "+":
                    {
                        results = double.Parse(this.number1) + double.Parse(this.number2);
                        break;
                    }
                case "-":
                    {
                        results = double.Parse(this.number1) - double.Parse(this.number2);
                        break;
                    }
                case "*":
                    {
                        results = double.Parse(this.number1) * double.Parse(this.number2);
                        break;
                    }
                case "/":
                    {
                        results = double.Parse(this.number1) / double.Parse(this.number2);
                        break;
                    }
                case "sqrt":
                    {
                        results = Math.Sqrt(double.Parse(this.number1));
                        break;
                    }
                case "sq":
                    {
                        results =double.Parse(this.number1) * double.Parse(this.number1);
                        break;
                    }

            }
            this.label2.Text = results.ToString();

            this.result = results.ToString();
            this.number1 = "0";
            this.number2 = "0";
        }


        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.number_clicked(this.button4.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.number_clicked(this.button15.Text);
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.number_clicked(this.button3.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.number_clicked(this.button6.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.number_clicked(this.button1.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.number_clicked(this.button11.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.number_clicked(this.button13.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.number_clicked(this.button12.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.number_clicked(this.button14.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.number_clicked(this.button16.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String sym = "+";
            this.symbol = sym;
            this.symbol_clicked(sym);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String sym = "-";
            this.symbol = sym;
            this.symbol_clicked(sym);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String sym = "*";
            this.symbol = sym;
            this.symbol_clicked(sym);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            String sym = "/";
            this.symbol = sym;
            this.symbol_clicked(sym);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.result_calculator();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.number_clicked(this.button5.Text);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //sqrt
            this.symbol_clicked("sqrt");
            this.clear();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.number_clicked(this.result);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //sqrt
            this.symbol_clicked("sq");
            this.clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil
{
    public partial class Form1 : Form
    {
        private double PriceOfOil { set; get; }
        private double LitersOfOil { set; get; }
        private double TotalPriceOfOil { set; get; }
        private double TotalPriceOfHotDogs { set; get; }
        private double TotalPriceOfHamburgers { set; get; }
        private double TotalPriceOfFri { set; get; }
        private double TotalPriceOfCola { set; get; }


        public Form1()
        {
            InitializeComponent();
            string[] oil = { "A-80", "A-92", "A-95", "A-98", "A-100" };
            this.comboBox1.DataSource = oil;
            this.textBox4.Text = "20,99";
            this.textBox5.Text = "25,00";
            this.textBox6.Text = "15,00";
            this.textBox7.Text = "9,99";
            TotalPriceOfCola = 0.0;
            TotalPriceOfFri = 0.0;
            TotalPriceOfHamburgers = 0.0;
            TotalPriceOfHotDogs = 0.0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.Text == "A-80")
            {
                this.textBox1.Text = "20,33";
            }
            else if (cb.Text == "A-92")
            {
                this.textBox1.Text = "24,57";
            }
            else if (cb.Text == "A-95")
            {
                this.textBox1.Text = "25,32";
            }
            else if (cb.Text == "A-98")
            {
                this.textBox1.Text = "11,69";
            }
            else if (cb.Text == "A-100")
            {
                this.textBox1.Text = "31,99";
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                this.textBox2.Enabled = false;
                this.textBox3.Enabled = true;

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                this.textBox3.Enabled = false;
                this.textBox2.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            TextBox tb = sender as TextBox;
            if (tb.Enabled == true)
            {
                TextBox tb1 = this.textBox1;
                if (tb.Text != "")
                {
                    LitersOfOil = double.Parse(tb.Text);
                    PriceOfOil = double.Parse(tb1.Text);
                    TotalPriceOfOil = LitersOfOil * PriceOfOil;
                    //print total price
                    this.textBox3.Text = TotalPriceOfOil.ToString();
                    //print to label total price
                    this.label6.Text = $"{TotalPriceOfOil}";
                    this.label6.Font = new Font(this.label6.Font.Name, 20, this.label6.Font.Style);
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Enabled == true)
            {
                TextBox tb1 = this.textBox1;
                if (tb.Text != "")
                {
                    double CashOfOilWantBuy = double.Parse(tb.Text);          //input cash want to buy
                    TotalPriceOfOil = CashOfOilWantBuy;
                    PriceOfOil = double.Parse(tb1.Text);                      //price of oil
                    double result = CashOfOilWantBuy / PriceOfOil;
                    //print total liters
                    this.textBox2.Text = result.ToString();
                    //print to label total price
                    this.label6.Text = $"{CashOfOilWantBuy}";
                    this.label6.Font = new Font(this.label6.Font.Name, 20, this.label6.Font.Style);

                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            TotalPriceOfHotDogs = 0;
            if (this.checkBox1.Checked == true)
            {
                TextBox tb = sender as TextBox;
                if (tb.Enabled == true)
                {
                    if (tb.Text != "")
                    {
                        double price = double.Parse(this.textBox4.Text);
                        double count = double.Parse(tb.Text);
                        TotalPriceOfHotDogs = price * count;
                    }
                }
            }

            this.label10.Text = $"{TotalPriceOfCola + TotalPriceOfFri + TotalPriceOfHamburgers + TotalPriceOfHotDogs}";
            this.label10.Font = new Font(this.label10.Font.Name, 20, this.label10.Font.Style);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            TotalPriceOfHamburgers = 0;
            if (this.checkBox2.Checked == true)
            {
                TextBox tb = sender as TextBox;
                if (tb.Enabled == true)
                {
                    if (tb.Text != "")
                    {
                        double price = double.Parse(this.textBox4.Text);
                        double count = double.Parse(tb.Text);
                        TotalPriceOfHamburgers = price * count;
                    }
                }
            }
            this.label10.Text = $"{TotalPriceOfCola + TotalPriceOfFri + TotalPriceOfHamburgers + TotalPriceOfHotDogs}";
            this.label10.Font = new Font(this.label10.Font.Name, 20, this.label10.Font.Style);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            TotalPriceOfFri = 0;
            if (this.checkBox3.Checked == true)
            {
                TextBox tb = sender as TextBox;
                if (tb.Enabled == true)
                {
                    if (tb.Text != "")
                    {
                        double price = double.Parse(this.textBox4.Text);
                        double count = double.Parse(tb.Text);
                        TotalPriceOfFri = price * count;
                    }
                }
            }
            this.label10.Text = $"{TotalPriceOfCola + TotalPriceOfFri + TotalPriceOfHamburgers + TotalPriceOfHotDogs}";
            this.label10.Font = new Font(this.label10.Font.Name, 20, this.label10.Font.Style);

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            TotalPriceOfCola = 0;
            if (this.checkBox4.Checked == true)
            {
                TextBox tb = sender as TextBox;
                if (tb.Enabled == true)
                {
                    if (tb.Text != "")
                    {
                        double price = double.Parse(this.textBox4.Text);
                        double count = double.Parse(tb.Text);
                        TotalPriceOfCola = price * count;
                    }
                }
            }
            this.label10.Font = new Font(this.label10.Font.Name, 20, this.label10.Font.Style);
            this.label10.Text = $"{TotalPriceOfCola + TotalPriceOfFri + TotalPriceOfHamburgers + TotalPriceOfHotDogs}";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double priceOil = double.Parse(this.label6.Text);
            double priceEat = double.Parse(this.label10.Text);
            this.label12.Text = $"{priceEat + PriceOfOil}";
            this.label12.Font = new Font(this.label12.Font.Name, 20, this.label12.Font.Style);
        }
    }
}

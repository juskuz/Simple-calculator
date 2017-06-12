using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        string liczba1 = "";
        string liczba2 = "";
        string znak = "";
        double wynik;
        bool przecinek1 = false;
        bool przecinek2 = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_number_Click(sender, e);
        }

        private void button_number_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
            if (znak=="")
            {
                liczba1 = liczba1 + b.Text;
            }
            if (znak!="")
            {
                liczba2 = liczba2 + b.Text;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_number_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_number_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button_number_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button_number_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button_number_Click(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button_number_Click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button_number_Click(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button_number_Click(sender, e);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            button_number_Click(sender, e);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            znak = "+";
            textBox1.Text = textBox1.Text + "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            znak = "-";
            textBox1.Text = textBox1.Text + "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            znak = "*";
            textBox1.Text = textBox1.Text + "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            znak = "/";
            textBox1.Text = textBox1.Text + "/";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(liczba2=="" || liczba1=="")
            { 
                //nic 
            }
            else { 
                if (znak=="")
                {
                    //nic
                }
                if (znak=="+")
                {
                    wynik = Double.Parse(liczba1) + Double.Parse(liczba2);
                    textBox1.Text = wynik.ToString();
                    znak = "";
                    liczba1 = wynik.ToString();
                    liczba2 = "";
                    przecinek1 = false;
                    przecinek2 = false;

                }
                if (znak=="-")
                {
                    wynik = Double.Parse(liczba1) - Double.Parse(liczba2);
                    textBox1.Text = wynik.ToString();
                    znak = "";
                    liczba1 = wynik.ToString();
                    liczba2 = "";
                    przecinek1 = false;
                    przecinek2 = false;
                }
                if (znak=="*")
                {
                    wynik = Double.Parse(liczba1) * Double.Parse(liczba2);
                    textBox1.Text = wynik.ToString();
                    znak = "";
                    liczba1 = wynik.ToString();
                    liczba2 = "";
                    przecinek1 = false;
                    przecinek2 = false;
                }

                if (znak=="/")
                {
                    if(Double.Parse(liczba2)==0)
                    {
                        //textBox1.Text = liczba1;
                        liczba2 = "";
                        znak = "";
                        liczba1 = "";
                        przecinek1 = false;
                        wynik = 0;
                        przecinek2 = false;
                        MessageBox.Show("Nie bądź głupi! Nie dziel przez 0!");
                        textBox1.Text = "";

                    }
                    else
                    {
                        wynik = Double.Parse(liczba1) / Double.Parse(liczba2);
                        textBox1.Text = wynik.ToString();
                        znak = "";
                        liczba1 = wynik.ToString();
                        liczba2 = "";
                        przecinek1 = false;
                        przecinek2 = false;
                    }
                }
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            liczba1 = "";
            liczba2 = "";
            znak = "";
            textBox1.Text = "";
            wynik = 0;
            przecinek1 = false;
            przecinek2 = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (znak == "")
            {
                if (przecinek1 == false)
                {
                    textBox1.Text = textBox1.Text + ",";
                    liczba1 = liczba1 + ",";
                    przecinek1 = true;
                }
            }
            else
            {
                if (przecinek2== false)
                {
                    textBox1.Text = textBox1.Text + ",";
                    liczba2 = liczba2 + ",";
                    przecinek2 = true;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string liczba1;
        string liczba2;




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string c = textBox1.Text;
            string d = textBox2.Text;
            string dd = textBox3.Text;
            string ddd = textBox4.Text;




            //rejestr AX
            if (comboBox1.Text == "AX" && comboBox2.Text == "BX")
            {
                textBox1.Text = c;
                textBox2.Text = textBox1.Text;
                MessageBox.Show("Nowa wartość rejestru BX to " + c);
                richTextBox1.Text = ("BX przyjął wartość " + c);
             
            }


            else if (comboBox1.Text == "AX" && comboBox2.Text == "CX")
            {
                textBox1.Text = c;
                textBox3.Text = textBox1.Text;
                MessageBox.Show("Nowa wartość rejestru CX to " + c);
                richTextBox1.Text = ("CX przyjął wartość " + c);

            }

            else if (comboBox1.Text == "AX" && comboBox2.Text == "DX")
            {
                textBox1.Text = c;
                textBox4.Text = textBox1.Text;
                MessageBox.Show("Nowa wartość rejestru DX to " + c);
                richTextBox1.Text = ("DX przyjął wartość " + c);

            }


            //rejestr BX
            else if (comboBox1.Text == "BX" && comboBox2.Text == "AX")
            {
                textBox2.Text = d;
                textBox1.Text = textBox2.Text;
                MessageBox.Show("Nowa wartość rejestru AX to " + d);
                richTextBox1.Text = ("AX przyjął wartość " + d);

            }

            else if (comboBox1.Text == "BX" && comboBox2.Text == "CX")
            {
                textBox2.Text = d;
                textBox3.Text = textBox2.Text;

                MessageBox.Show("Nowa wartość rejestru CX to " + d);
                richTextBox1.Text = ("CX przyjął wartość " + d);
            }

            else if (comboBox1.Text == "BX" && comboBox2.Text == "DX")
            {
                textBox2.Text = d;
                textBox4.Text = textBox2.Text;

                MessageBox.Show("Nowa wartość rejestru DX to " + d);
                richTextBox1.Text = ("DX przyjął wartość " + d);
            }

            //rejestr CX
            else if (comboBox1.Text == "CX" && comboBox2.Text == "AX")
            {
                textBox3.Text = dd;
                textBox1.Text = textBox3.Text;
                MessageBox.Show("Nowa wartość rejestru AX to " + dd);
                richTextBox1.Text = ("AX przyjął wartość " + dd);

            }

            else if (comboBox1.Text == "CX" && comboBox2.Text == "BX")
            {
                textBox3.Text = dd;
                textBox2.Text = textBox3.Text;
                MessageBox.Show("Nowa wartość rejestru BX to " + dd);
                richTextBox1.Text = ("BX przyjął wartość " + dd);

            }

            else if (comboBox1.Text == "CX" && comboBox2.Text == "DX")
            {
                textBox3.Text = dd;
                textBox4.Text = textBox3.Text;
                MessageBox.Show("Nowa wartość rejestru DX to " + dd);
                richTextBox1.Text = ("DX przyjął wartość " + dd);

            }

            //rejestr D
            else if (comboBox1.Text == "DX" && comboBox2.Text == "AX")
            {
                textBox4.Text = ddd;
                textBox1.Text = textBox4.Text;
                MessageBox.Show("Nowa wartość rejestru AX to " + ddd);
                richTextBox1.Text = ("AX przyjął wartość " + ddd);

            }
            else if (comboBox1.Text == "DX" && comboBox2.Text == "BX")
            {
                textBox4.Text = ddd;
                textBox2.Text = textBox4.Text;
                MessageBox.Show("Nowa wartość rejestru BX to " + ddd);
                richTextBox1.Text = ("BX przyjął wartość " + ddd);

            }

            else if (comboBox1.Text == "DX" && comboBox2.Text == "CX")
            {

                textBox3.Text = textBox4.Text;
                MessageBox.Show("Nowa wartość rejestru CX to " + ddd);
                richTextBox1.Text = ("CX przyjął wartość " + ddd);
            }



            //podwojne wartosci
            else if (comboBox1.Text == "AX" && comboBox2.Text == "AX")
            {
                MessageBox.Show("Rejestr i źródło muszą być różne");
            }

            else if (comboBox1.Text == "BX" && comboBox2.Text == "BX")
            {
                MessageBox.Show("Rejestr i źródło muszą być różne");
            }

            else if (comboBox1.Text == "CX" && comboBox2.Text == "DX")
            {
                MessageBox.Show("Rejestr i źródło muszą być różne");
            }

            else if (comboBox1.Text == "DX" && comboBox2.Text == "DX")
            {
                MessageBox.Show("Rejestr i źródło muszą być różne");
            }


            else

            {
                MessageBox.Show("Wybierz źródło oraz rejestr");
            }



        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class x_o : Form
    {
        public x_o()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;


        }

        private void x_o_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;

            textBox2.BackColor = Color.White;
            textBox2.ForeColor = Color.Black;
            textBox3.BackColor = Color.White;
            textBox3.ForeColor = Color.Black;
            textBox4.BackColor = Color.White;
            textBox4.ForeColor = Color.Black;

            textBox5.BackColor = Color.White;
            textBox5.ForeColor = Color.Black;
            textBox6.BackColor = Color.White;
            textBox6.ForeColor = Color.Black;
            textBox7.BackColor = Color.White;
            textBox7.ForeColor = Color.Black;
            textBox8.BackColor = Color.White;
            textBox8.ForeColor = Color.Black;

            textBox9.BackColor = Color.White;
            textBox9.ForeColor = Color.Black;

            label2.Text = Convert.ToString(0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "x" || textBox1.Text == "X")
            {
                textBox1.BackColor = Color.RoyalBlue;
                textBox1.ForeColor = Color.White;

            }
            else if (textBox1.Text == "o" || textBox1.Text == "O")
            {
                textBox1.BackColor = Color.RosyBrown;
                textBox1.ForeColor = Color.White;

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "x" || textBox2.Text == "X")
            {
                textBox2.BackColor = Color.RoyalBlue;
                textBox2.ForeColor = Color.White;

            }
            else if (textBox2.Text == "o" || textBox2.Text == "O")
            {
                textBox2.BackColor = Color.RosyBrown;
                textBox2.ForeColor = Color.White;

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "x" || textBox3.Text == "X")
            {
                textBox3.BackColor = Color.RoyalBlue;
                textBox3.ForeColor = Color.White;

            }
            else if (textBox3.Text == "o" || textBox3.Text == "O")
            {
                textBox3.BackColor = Color.RosyBrown;
                textBox3.ForeColor = Color.White;

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "x" || textBox4.Text == "X")
            {
                textBox4.BackColor = Color.RoyalBlue;
                textBox4.ForeColor = Color.White;

            }
            else if (textBox4.Text == "o" || textBox4.Text == "O")
            {
                textBox4.BackColor = Color.RosyBrown;
                textBox4.ForeColor = Color.White;

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "x" || textBox5.Text == "X")
            {
                textBox5.BackColor = Color.RoyalBlue;
                textBox5.ForeColor = Color.White;

            }
            else if (textBox5.Text == "o" || textBox5.Text == "O")
            {
                textBox5.BackColor = Color.RosyBrown;
                textBox5.ForeColor = Color.White;

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == "x" || textBox6.Text == "X")
            {
                textBox6.BackColor = Color.RoyalBlue;
                textBox6.ForeColor = Color.White;

            }
            else if (textBox6.Text == "o" || textBox6.Text == "O")
            {
                textBox6.BackColor = Color.RosyBrown;
                textBox6.ForeColor = Color.White;

            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "x" || textBox7.Text == "X")
            {
                textBox7.BackColor = Color.RoyalBlue;
                textBox7.ForeColor = Color.White;

            }
            else if (textBox7.Text == "o" || textBox7.Text == "O")
            {
                textBox7.BackColor = Color.RosyBrown;
                textBox7.ForeColor = Color.White;

            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text == "x" || textBox8.Text == "X")
            {
                textBox8.BackColor = Color.RoyalBlue;
                textBox8.ForeColor = Color.White;

            }
            else if (textBox8.Text == "o" || textBox8.Text == "O")
            {
                textBox8.BackColor = Color.RosyBrown;
                textBox8.ForeColor = Color.White;

            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text == "x" || textBox9.Text == "X")
            {
                textBox9.BackColor = Color.RoyalBlue;
                textBox9.ForeColor = Color.White;

            }
            else if (textBox9.Text == "o" || textBox9.Text == "O")
            {
                textBox9.BackColor = Color.RosyBrown;
                textBox9.ForeColor = Color.White;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = 0;
            string data1 = textBox1.Text;
            string data2 = textBox2.Text;
            string data3 = textBox3.Text;
            string data4 = textBox4.Text;
            string data5 = textBox5.Text;
            string data6 = textBox6.Text;
            string data7 = textBox7.Text;
            string data8 = textBox8.Text;
            string data9 = textBox9.Text;
            if (data1 == "x" && data2 == "x" && data3 == "x")
            {
                MessageBox.Show($"player x win");
                count += 1;
                label2.Text = Convert.ToString(count);

            }
            else if (data1 == "o" && data2 == "o" && data3 == "o")
            {
                MessageBox.Show($"player o win");
                count += 1;
                label2.Text = Convert.ToString(count);

            }
            if (data4 == "x" && data5 == "x" && data6 == "x")
            {
                MessageBox.Show($"player x win");
                count += 1;
                label2.Text = Convert.ToString(count);

            }
            else if (data4 == "o" && data5 == "o" && data6 == "o")
            {
                MessageBox.Show($"player o win");
                count += 1;
                label2.Text = Convert.ToString(count);

            }
            if (data7 == "x" && data8 == "x" && data9 == "x")
            {
                MessageBox.Show($"player x win");
                count += 1;
                label2.Text = Convert.ToString(count);

            }
            else if (data7 == "o" && data8 == "o" && data9 == "o")
            {
                MessageBox.Show($"player o win");
                count += 1;
                label2.Text = Convert.ToString(count);

            }

            //this for check the win column
            if (data1 == "x" && data4 == "x" && data7 == "x")
            {
                MessageBox.Show($"player x win");
                count += 1;
                label2.Text = Convert.ToString(count);

            }
            else if (data1 == "o" && data4 == "o" && data7 == "o")
            {
                MessageBox.Show($"player o win");
                count += 1;
                label2.Text = Convert.ToString(count);

            }

            if (data2 == "x" && data5 == "x" && data8 == "x")
            {
                MessageBox.Show($"player x win");
                count += 1;
                label2.Text = Convert.ToString(count);

            }
            else if (data2 == "o" && data5 == "o" && data8 == "o")
            {
                MessageBox.Show($"player o win");
                count += 1;
                label2.Text = Convert.ToString(count);

            }
            if (data3 == "x" && data6 == "x" && data9 == "x")
            {
                MessageBox.Show($"player x win");
                count += 1;
                label2.Text = Convert.ToString(count);

            }
            else if (data3 == "o" && data6 == "o" && data9 == "o")
            {
                MessageBox.Show($"player o win");
                count += 1;
                label2.Text = Convert.ToString(count);

            }

            if (data1 == "x" && data5 == "x" && data9 == "x")
            {
                MessageBox.Show($"player x win");
                count += 1;
                label2.Text = Convert.ToString(count);

            }
            else if (data1 == "o" && data5 == "o" && data9 == "o")
            {
                MessageBox.Show($"player o win");
                count += 1;
                label2.Text = Convert.ToString(count);

            }
            if (data3 == "x" && data5 == "x" && data7 == "x")
            {
                MessageBox.Show($"player x win");
                count += 1;
                label2.Text = Convert.ToString(count);

            }
            else if (data3 == "o" && data5 == "o" && data7 == "o")
            {
                MessageBox.Show($"player o win");
                count += 1;
                label2.Text = Convert.ToString(count);

            }

          
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form1 f = new Form1();
            f.Show();
        }
    }
}

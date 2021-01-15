using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week15
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }
        public string[] makanan = new string[4]{"Nasi Goreng", "Nasi Goreng Spesial" , "Nasi Goreng pete", "Ayam Bakar" };
        public string[] minuman = new string[4] { "Es Teh", "Teh Hangat", "Nutrisari", "Aqua" };
        public int[] hargamakanan = new int[4] { 10000, 12000, 15000, 15000 };
        public int[] hargaminumanjumbo = new int[4] {7000,5000,10000,5000 };
        public int[] hargaminumannormal = new int[4] {5000,3000,6000,2000};
        public int[] hargapilihan = new int[100];
        public int pesanan = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 formbaru = new Form2();
            formbaru.Show();
        }

        private void radioButtonMAKANAN_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonMAKANAN.Checked==true)
            {
                labelHARGA.Text = "";
                radioButtonminumannormal.Visible = false;
                radioButtonminumanJumbo.Visible = false;
                comboBox1.Text = "";
                comboBox1.Items.Clear();
                for (int i = 0; i < 4; i++)
                {
                    comboBox1.Items.Add(makanan[i]);
                }
            }
        }

        private void radioButtonMINUMAN_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMINUMAN.Checked == true)
            {
                comboBox1.Text = "";
                labelHARGA.Text = "";
                radioButtonminumannormal.Visible = true;
                radioButtonminumanJumbo.Visible = true;
                comboBox1.Items.Clear();
                for (int i = 0; i < 4; i++)
                {
                    comboBox1.Items.Add(minuman[i]);
                }
            }
        }

        private void labelHARGA_Click(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (radioButtonMAKANAN.Checked == true)
            {

                if (comboBox1.SelectedIndex == 0)
                {
                    labelHARGA.Text = Convert.ToString(hargamakanan[0]);
                    hargapilihan[pesanan] = hargamakanan[0];
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    labelHARGA.Text = Convert.ToString(hargamakanan[1]);
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    labelHARGA.Text = Convert.ToString(hargamakanan[2]);
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    labelHARGA.Text = Convert.ToString(hargamakanan[3]);
                }
            }
            if  (radioButtonMINUMAN.Checked == true)
            {

                if (radioButtonminumanJumbo.Checked == true)
                {

                }

               
            }
        }

        private void buttonBUY_Click(object sender, EventArgs e)
        {
            pesanan++;
            listBoxITEM.Items.Add(comboBox1.Text);
            listBoxHarga.Items.Add(labelHARGA.Text);
            if (comboBox1.Text == "")
            { MessageBox.Show("Belum ada yang dipilih", "Error"); }

        }

        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            listBoxITEM.Items.Clear();
            listBoxHarga.Items.Clear();
        }
    }
}

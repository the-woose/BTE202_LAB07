using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTE202_LAB07
{
    public partial class Form2 : Form
    {
        public Random rnd_01 = new Random();
        public Random rnd_02 = new Random();
        public int result;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int cevap = soru_Sor();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            kontrol_Et();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int soru_Sor()
        {
            int operand_01 = rnd_01.Next(0, 200);
            int operand_02 = rnd_02.Next(0, 200);
            result = operand_01 + operand_02;
            label1.Text = operand_01.ToString() + " + " + operand_02.ToString() + " işleminin sonucu nedir?";
            return result;
        }

        public void kontrol_Et()
        {

            if (int.TryParse(textBox1.Text, out int kull_girisi))
            {
                if (result == kull_girisi)
                {
                    MessageBox.Show("Doğru Cevap!", "Tebrikler!",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Yanlış Cevap :(\nİşlemin sonucu = " + result.ToString(), "Hata!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen tam sayı değeri girin", "Hata!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void cmdGetlnfo_Click(object sender, EventArgs e)
        {
            isimAnalizi();
        }
        private void isimAnalizi()
        {
            string[] nameArray = txtName.Text.Split(' ');
            string adi = adiGetir(nameArray);
            string soyadi = soyadiGetir(nameArray);
            int adUzunlugu = karakterSay(nameArray);
            yazdir(adi, soyadi, adUzunlugu);
        }

        private string adiGetir(string[] Array)
        {
            var firstName = new List<string>(Array);
            firstName.RemoveAt(firstName.Count - 1);
            string adiGetir = String.Join(" ", firstName.ToArray());
            return adiGetir;
        }

        private string soyadiGetir(string[] Array)
        {
            string soyadiGetir = Array[Array.Length - 1];
            return soyadiGetir;
        }

        private int karakterSay(string[] Array)
        {
            int isimUzunlugu = 0;
            foreach (string s in Array) { isimUzunlugu = isimUzunlugu + s.Length; }
            return isimUzunlugu;
        }

        private void yazdir(string ad, string soyad, int uzunluk)
        {
            txtInfo.Text = "Adınız " + ad + System.Environment.NewLine
                + "Soyadınız " + soyad + System.Environment.NewLine
                + "Adınızda toplamda " + uzunluk + " karakter bulunuyor.";
        }
    }
}

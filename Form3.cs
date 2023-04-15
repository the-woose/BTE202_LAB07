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
            string[] nameArray = txtName.Text.Split(' ');
            var firstName = new List<string>(nameArray);
            firstName.RemoveAt(firstName.Count - 1);
            string adi = String.Join(" ", firstName.ToArray());
            string soyadi = nameArray[nameArray.Length - 1];
            int adUzunlugu = 0;
            foreach (string s in nameArray) { adUzunlugu = adUzunlugu + s.Length; }
            txtInfo.Text = "Adınız " + adi + System.Environment.NewLine
                + "Soyadınız " + soyadi + System.Environment.NewLine
                + "Adınızda toplamda " + adUzunlugu + " karakter bulunuyor.";
        }
    }
}

namespace BTE202_LAB07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm_soru = new Form2();
            frm_soru.ShowDialog();
        }
    }
}
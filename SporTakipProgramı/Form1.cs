using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SporTakipProgramı
{
    public partial class SporSalonuUyelikProgrami : Form
    {
        public SporSalonuUyelikProgrami()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal ucret = 0;

            if (string.IsNullOrWhiteSpace(textBox1.Text) || 
                string.IsNullOrWhiteSpace(textBox2.Text) || 
                string.IsNullOrWhiteSpace(textBoxAdres.Text) ||
                comboBox1.SelectedIndex == -1 || 
                numericUpDownGun.Value == 0) 
            {
                
                MessageBox.Show("Lütfen tüm alanları eksiksiz doldurun!",
                    "Eksik Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return; 
            }


            if (comboBox1.Text == "1 Aylık Üyelik")
            {
                ucret = 1000;
            }
            else if (comboBox1.Text == "3 Aylık Üyelik")
            {
                ucret = 2700;
            }
            else if (comboBox1.Text == "6 Aylık Üyelik")
            {
                ucret = 5000;
            }
            else if (comboBox1.Text == "1 Aylık VİP Üyelik")
            {
                ucret = 4000;
            }
            else if (comboBox1.Text == "3 Aylık VİP Üyelik")
            {
                ucret = 5700;
            }
            else if (comboBox1.Text == "6 Aylık VİP Üyelik")
            {
                ucret = 8000;
            }

            int kisiSayisi = (int)numericUpDownGun.Value;
            decimal ekstraUcret = kisiSayisi * 50;
            ucret += ekstraUcret;
            
            listBoxAdSoyad.Items.Add(textBox1.Text);
            listBoxTelefon.Items.Add(textBox2.Text);
            listBoxAdres.Items.Add(textBoxAdres.Text);
            listBoxUyeSayisi.Items.Add(numericUpDownGun.Value);
            listBoxUyelikturu.Items.Add(comboBox1.Text);
            listBoxUcret.Items.Add(ucret+"TL");
            textBox1.Clear();
            textBox2.Clear();
            textBoxAdres.Clear();
            numericUpDownGun.Value = 0;
            comboBox1.SelectedIndex = -1;   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int seciliIndex = listBoxAdSoyad.SelectedIndex;

            if (seciliIndex != -1)
            {
                
                listBoxAdSoyad.Items.RemoveAt(seciliIndex);
                listBoxTelefon.Items.RemoveAt(seciliIndex);
                listBoxAdres.Items.RemoveAt(seciliIndex);
                listBoxUyeSayisi.Items.RemoveAt(seciliIndex);
                listBoxUyelikturu.Items.RemoveAt(seciliIndex);
                listBoxUcret.Items.RemoveAt(seciliIndex);
            }
            else
            {
                MessageBox.Show("Üyelik Seçilmedi!",
                    "Seçilmeyen Üyelik",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void SporSalonuUyelikProgrami_Load(object sender, EventArgs e)
        {
            textBoxAdres.MaxLength = 50;
        }

    }
}

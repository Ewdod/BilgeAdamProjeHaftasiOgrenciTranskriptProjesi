using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veriler.Class;

namespace BilgeAdamProjeHaftasiOgrenciTranskriptProjesi
{
    public partial class Form3 : Form
    {
        public List<Ogrenci> OgrenciListesi  = new List<Ogrenci>();
        public List<Dersler> dersler = new List<Dersler>();
        public Form3()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(Enum.GetNames(typeof(Donem)));

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            Enum.TryParse(comboBox1.SelectedItem.ToString(), out Donem donemi);
            Dersler ders = new Dersler(textBox1.Text, Convert.ToInt32(textBox2.Text), donemi);
            dersler.Add(ders);
            listBox1.Items.Add(ders);
            foreach (Dersler item in dersler)
            {

                item.OgrenciDersleri.Add(item);
            }

            Ogrenci ogrenci = new Ogrenci(textBox3.Text, textBox4.Text, dersler, Convert.ToInt32(textBox5.Text));
            OgrenciListesi.Add(ogrenci);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Ogrenci item in OgrenciListesi)
            {
                Ogrenci.OgrenciListesi.Add(item);
            }           
            
        }
    }
}

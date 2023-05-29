using Veriler.Class;

namespace BilgeAdamProjeHaftasiOgrenciTranskriptProjesi
{
    public partial class Form1 : Form
    {
        public List<Dersler> TumDersler = new List<Dersler>();
        public Form1()
        {
            InitializeComponent();

            // donem ortalamasi kendi doneminde hesaplanacak
            // genel ortalama genellerin toplaminin ortalamasi

            // donem ortalamasi o donemde alinan her dersin (kredisi X harf notunun katsayisi) / toplam kredi

        }


        public void DersEkle(Dersler ders)
        {
            TumDersler.Add(ders);
        }
        public void DersGoster()
        {
            foreach (Dersler item in TumDersler)
            {
                Console.WriteLine($"{item.DersAdi} {item.Kredi} {item.Donemi}");


            }
        }

        private void btnDers_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
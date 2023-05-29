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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            listBox1.Items.AddRange(Ogrenci.OgrenciListesi.Cast<object>().ToArray());

        }
    }
}

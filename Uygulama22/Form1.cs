using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama22
{
    public partial class Form1 : Form
    {
        ArrayList kaynakVeri=new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            Kitaplar kitap= new Kitaplar();
            kitap.KitapAdi = textKitapAdi.Text;
            kitap.KitapYazari = textKitapYazari.Text;
            kitap.KitapTuru = textKitapTuru.Text;
            kaynakVeri.Add(kitap);
        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            listeVeri.DataSource = null;
            listeVeri.DataSource = kaynakVeri;
            listeVeri.DisplayMember= "KitapAdi";
        }
    }
}

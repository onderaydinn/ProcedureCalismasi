using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    
namespace DataBaseKomut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hareketsDataSet.Proje6' table. You can move, or remove it, as needed.
            this.proje6TableAdapter.Fill(this.hareketsDataSet.Proje6);

            /*
            * Create procedure Proje6
            as
            select URUNLER.Ad as 'Ürün Ad',ADSOYAD as 'Müşteri',PERSONELLER.AD as 'Personel',fiyat as ' Fiyat' from HAREKETLER inner join URUNLER
            on
            hareketler.Urun = urunler.ID
            inner join MUSTERILER
            on 
            hareketler.musteri = MUSTERILER.ID
            inner join PERSONELLER
            on
            HAREKETLER.PERSONEL = PERSONELLER.ID
             */
        }
    }
}

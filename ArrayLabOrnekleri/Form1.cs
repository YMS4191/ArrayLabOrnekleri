using System;
using System.Windows.Forms;

namespace ArrayLabOrnekleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            //Icerigine sizin karar vereceginiz bir sayisal dizi olusturun ve bu dizinin en kucuk - en buyuk elemanını MessageBox'la gosterin..
            int[] dizi = { 53, 765, 2165, 8, 321, 65, 851, 876, 98, 34276, 453 };
            Array.Sort(dizi);
            MessageBox.Show($"Dizinin ilk elemanı : {dizi[0]}\nDizinin son elemanı : {dizi[dizi.Length - 1]}");
        }


        string[] kayitlar = new string[0];
        //int adet = 1;
        //int index = 0;
        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            //Textbox'tan girilen veri "kayitlar" adli diziye eklesin. Her yeni kayıtta dizinin boyutu bir arttırılsın... Eleman ekledikten hemen sonra ise asagidaki formatta kayit listbox'ta gosterilsin..
            //FORMAT => Eleman - ElemaninIndex

            //string veri = txtGelenDeger.Text;
            //Array.Resize(ref kayitlar, adet);

            //kayitlar[index] = veri;
            //adet++;
            //index++;

            //lstElemanlar.Items.Add($"{veri} - {index}");

            Array.Resize(ref kayitlar, kayitlar.Length + 1);
            kayitlar[kayitlar.Length - 1] = txtGelenDeger.Text;
            lstElemanlar.Items.Add($"{kayitlar[kayitlar.Length - 1]} - {kayitlar.Length - 1}");
        }
    }
}

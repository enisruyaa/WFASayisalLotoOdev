using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFASayisalLotoOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is ListBox)
                {
                    ListBox yakalananEleman = item as ListBox;
                    yakalananEleman.Items.Clear();
                    int rastgeleSayi = r.Next(1 , 51);
                    for (int i = 0; i < 6;)
                    {
                        if (yakalananEleman.Items.Contains(rastgeleSayi)) // Bu kısımda dedik ki  listboxın içerisinde aynı değişken var mı eğer varsa yeni bir sayı oluştur.
                        {
                            rastgeleSayi = r.Next( 1, 50);
                        }
                        else
                        {
                            yakalananEleman.Items.Add(rastgeleSayi); // Yoksa ekrana yazdır ve i yi bir arttır.
                            i++;
                        }
                    }
                }
            }
        }
    }
}

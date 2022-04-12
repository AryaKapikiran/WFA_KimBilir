using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_KimBilir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < Sinif.SinifList.Count; i++)
            {
                listBox1.Items.Add(Sinif.SinifList[i]);
            }
            listBox2.DataSource=Konu.konuListesi.ToList();



        }
        Random rnd = new Random();
        Random rnd2 = new Random();

        private void btnBilirKisi_Click(object sender, EventArgs e)
        {
            int rastgelekisi = rnd.Next(0,listBox1.Items.Count);
            int rastgelekonu = rnd.Next(0,listBox2.Items.Count);

                if (listBox1.Items.Count>0)
            {
                Sinif secilenkisi = (Sinif)listBox1.Items[rastgelekisi];

                foreach (Sinif sinifkisi in Sinif.SinifList)
                {
                    if (secilenkisi.Ad == sinifkisi.Ad)
                    {
                        DialogResult dr = MessageBox.Show(sinifkisi.Ad + " " + sinifkisi.Soyad + " adlı kişi " + Konu.konuListesi[rastgelekonu] + " adlı konu ile eşleşti ", "Konu alındı mı?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (dr == DialogResult.Yes)
                        {
                            sinifkisi.Puan = 5;

                        }
                        else
                        {
                            sinifkisi.Puan = 0;
                        }

                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = sinifkisi.Ad;
                        lvi.SubItems.Add(sinifkisi.Soyad);
                        lvi.SubItems.Add(Konu.konuListesi[rastgelekonu].ToString());
                        lvi.SubItems.Add(sinifkisi.Puan.ToString());
                        listBox1.Items.RemoveAt(rastgelekisi);
                        listView1.Items.Add(lvi);

                    }
                }


            } 

                else
            {
                MessageBox.Show("Konularla eşleşecek kişi kalmadı");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace NKatmanlıMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> personellistesi = LogicLayer.LogicPersonel.LogicLayerPersonelListesi();
            dataGridView1.DataSource = personellistesi;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = txtad.Text;
            ent.Soyad = txtsoyad.Text;
            ent.Sehir = txtsehir.Text;
            ent.Gorev = txtgorev.Text;
            ent.Maaş = short.Parse(txtmaas.Text);
            int result = LogicPersonel.LogicLayerPersonelEkle(ent);
            MessageBox.Show(result + " Personel Kaydedildi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = int.Parse(txtıd.Text);
            int result = LogicLayer.LogicPersonel.LogicLayerPersonelSil(ent);
            MessageBox.Show(result + " Personel Silindi");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = int.Parse(txtıd.Text);
            ent.Ad = txtad.Text;
            ent.Soyad = txtsoyad.Text;
            ent.Gorev = txtgorev.Text;
            ent.Maaş = short.Parse(txtmaas.Text);
            ent.Sehir = txtsehir.Text;
            int result = LogicPersonel.LogicLayerPersonelGüncelle(ent);
            MessageBox.Show(result + "Personel Güncellendi");
        }
    }
}

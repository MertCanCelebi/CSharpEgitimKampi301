using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            var values = db.TblGuide.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TblGuide guide = new TblGuide();
            guide.GuideName=txtAd.Text;
            guide.GuideSurname=txtSoyad.Text;
            db.TblGuide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Rehber Eklendi.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int silinecekId= int.Parse(txtId.Text);
            var silinecekSutun= db.TblGuide.Find(silinecekId);
            db.TblGuide.Remove(silinecekSutun);
            db.SaveChanges();
            MessageBox.Show("Rehber Silindi.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int guncellenecekId= int.Parse(txtId.Text);
            var guncellenecekSutun = db.TblGuide.Find(guncellenecekId);
            guncellenecekSutun.GuideName = txtAd.Text;
            guncellenecekSutun.GuideSurname = txtSoyad.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber Güncellendi.");

        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values = db.TblGuide.Where(x=> x.GuideId==id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}

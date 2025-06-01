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
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void btnListele_Click(object sender, EventArgs e)
        {
            var values = db.TblLocation.ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.TblGuide.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname,
                x.GuideId
            }).ToList();
            comboBox1.ValueMember = "GuideId";
            comboBox1.DisplayMember = "FullName";
            comboBox1.DataSource = values;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TblLocation location = new TblLocation();
            location.City = txtSehir.Text;
            location.Country = txtUlke.Text;
            location.Capacity = byte.Parse(txtKapasite.Text);
            location.Price = int.Parse(txtFiyat.Text);
            location.DayNight = txtGunGece.Text;
            location.GuideId = int.Parse(comboBox1.SelectedValue.ToString());
            db.TblLocation.Add(location);
            db.SaveChanges();
            MessageBox.Show("Lokasyon Eklendi.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int silinecekId = int.Parse(txtId.Text);
            var silinecekSutun = db.TblLocation.Find(silinecekId);
            db.TblLocation.Remove(silinecekSutun);
            db.SaveChanges();
            MessageBox.Show("Lokasyon Silindi.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int guncellenecekId = int.Parse(txtId.Text);
            var guncellenecekSutun = db.TblLocation.Find(guncellenecekId);
            guncellenecekSutun.City = txtSehir.Text;
            guncellenecekSutun.Country = txtUlke.Text;
            guncellenecekSutun.Capacity = byte.Parse(txtKapasite.Text);
            guncellenecekSutun.Price = int.Parse(txtFiyat.Text);
            guncellenecekSutun.DayNight = txtGunGece.Text;
            guncellenecekSutun.GuideId = int.Parse(comboBox1.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Lokasyon Güncellendi.");
        }
    }
}

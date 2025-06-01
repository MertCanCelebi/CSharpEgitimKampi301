using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatictics : Form
    {
        public FrmStatictics()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void FrmStatictics_Load(object sender, EventArgs e)
        {
            lblLokasyonSayisi.Text = db.TblLocation.Count().ToString();

            lblToplamKapasiteSayisi.Text = db.TblLocation.Sum(x => x.Capacity).ToString();

            lblRehberSayisi.Text = db.TblGuide.Count().ToString();

            lblOrtalamaKapasite.Text = db.TblLocation.Average(x => x.Capacity).ToString();

            lblOrtalamaTurFiyati.Text = Math.Round(double.Parse(db.TblLocation.Average(x => x.Price).ToString()),2).ToString()+ " TL";

            int id = db.TblLocation.Max(x => x.LocationId);
            lblEklenenSonUlke.Text = db.TblLocation.Where(x => x.LocationId == id).Select(y => y.Country).FirstOrDefault().ToString();

            lblKapadokyaTurKapasitesi.Text = db.TblLocation.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();

            lblTurkiyeOrtalamaKapasite.Text= db.TblLocation.Where(x => x.Country=="Türkiye").Average(y => y.Capacity).ToString();

            int rehberId= int.Parse(db.TblLocation.Where(x => x.City == "Roma").Select(y=>y.GuideId).FirstOrDefault().ToString());
            lblRomaGeziRehberi.Text = db.TblGuide.Where(x => x.GuideId == rehberId).Select(y => y.GuideName + " "+ y.GuideSurname).FirstOrDefault().ToString();

            int enYuksekKapasite= int.Parse(db.TblLocation.Max(x => x.Capacity).ToString());
            lblEnYuksekKapasiteliTur.Text = db.TblLocation.Where(x => x.Capacity == enYuksekKapasite).Select(y => y.City).FirstOrDefault().ToString();

            decimal enPahaliFiyat = decimal.Parse(db.TblLocation.Max(x => x.Price).ToString());
            lblEnPahaliTur.Text= db.TblLocation.Where(x => x.Price==enPahaliFiyat).Select(y => y.City).FirstOrDefault().ToString();

            int aysegulCinarId = int.Parse(db.TblGuide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y => y.GuideId).FirstOrDefault().ToString());
            lblAysegulCinarTurSayisi.Text= db.TblLocation.Where(x=>x.GuideId==aysegulCinarId).Count().ToString();
        }

    }
}

using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.BusinessLayer.Concreate;
using CSharpEgitimKampi301.DataAccesLayer.EntityFramework;
using CSharpEgitimKampi301.EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PresentationLayer
{
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;
        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtAd.Text;
            category.CategoryStatus = true;
            _categoryService.TInsert(category);
            MessageBox.Show("Kategori Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
            int CategoryId = int.Parse(txtId.Text);
            var deletedValues= _categoryService.TGetById(CategoryId);
           
            _categoryService.TDelete(deletedValues);
            MessageBox.Show("Kategori Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int CategoryId = int.Parse(txtId.Text);
            var updatedValues = _categoryService.TGetById(CategoryId);
            updatedValues.CategoryName = txtAd.Text;
            updatedValues.CategoryStatus = true;
            _categoryService.TUpdate(updatedValues);
            MessageBox.Show("Kategori Güncellendi");

        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            int CategoryId = int.Parse(txtId.Text);
            var values = _categoryService.TGetById(CategoryId);
            dataGridView1.DataSource = new List<Category> { values };
        }
    }
}

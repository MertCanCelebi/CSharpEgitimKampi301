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
    public partial class FrmProduct : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public FrmProduct()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }
        
        private void btnListele_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetAll();
            dataGridView1.DataSource = values;
        }

        private void btnListele2_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetProductsWithCategory();
            dataGridView1.DataSource = values;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductName = txtAd.Text;
            product.ProductStock = int.Parse(txtStok.Text);
            product.ProductPrice = int.Parse(txtFiyat.Text);
            product.CategoryId = int.Parse(cmbKategori.SelectedValue.ToString());
            product.ProductDescription = rtbAciklama.Text;
            _productService.TInsert(product);
            MessageBox.Show("Ürün Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(txtId.Text);
            var deletedValues = _productService.TGetById(productId);

            _productService.TDelete(deletedValues);
            MessageBox.Show("Ürün Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(txtId.Text);
            var updatedValues = _productService.TGetById(productId);

            updatedValues.ProductName = txtAd.Text;
            updatedValues.ProductStock = int.Parse(txtStok.Text);
            updatedValues.ProductPrice = int.Parse(txtFiyat.Text);
            updatedValues.CategoryId = int.Parse(cmbKategori.SelectedValue.ToString());
            updatedValues.ProductDescription = rtbAciklama.Text;
            _productService.TUpdate(updatedValues);
            MessageBox.Show("Ürün Güncellendi");
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(txtId.Text);
            var values = _productService.TGetById(productId);
            dataGridView1.DataSource = new List<Product> { values };
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values = _categoryService.TGetAll();
            cmbKategori.DataSource = values;
            cmbKategori.DisplayMember = "CategoryName";
            cmbKategori.ValueMember = "CategoryId";
            
        }
    }
}

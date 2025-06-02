using CSharpEgitimKampi301.DataAccesLayer.Abstract;
using CSharpEgitimKampi301.DataAccesLayer.Context;
using CSharpEgitimKampi301.DataAccesLayer.Repositories;
using CSharpEgitimKampi301.EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccesLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<object> GetProductsWithCategory()
        {
            var context= new KampContext();
            var values = context.Products
                .Select(x => new
                {
                    ProductId = x.ProductId,
                    ProductName = x.ProductName,
                    ProductStock = x.ProductStock,
                    ProductPrice = x.ProductPrice,
                    ProductDescription = x.ProductDescription,
                    CategoryName = x.Category.CategoryName
                }).ToList();

            return values.Cast<object>().ToList();
        }
    }
}

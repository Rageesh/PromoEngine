using System;
using System.Collections.Generic;


namespace PreSetData
{
    public class ProductCatalogue : PromotionData
    {
        public string ProdID { get; set; }
        public int ProdPrice { get; set; }

        public List<ProductCatalogue> Products()
        {
            // Add or Delete Products 
            List<ProductCatalogue> lstProducts = new List<ProductCatalogue>();
            lstProducts.Add(new ProductCatalogue() { ProdID = "A", ProdPrice = 50 });
            lstProducts.Add(new ProductCatalogue() { ProdID = "B", ProdPrice = 30 });
            lstProducts.Add(new ProductCatalogue() { ProdID = "C", ProdPrice = 20 });
            lstProducts.Add(new ProductCatalogue() { ProdID = "D", ProdPrice = 15 });

            return lstProducts;
        }
    }
}







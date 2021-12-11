using System;
using System.Collections.Generic;
using System.Linq;
using PreSetData;
namespace PromotionalEngine
{
    public class PromoEngine
    {
        OrderData ObjOrderData = new OrderData();
        public int GetCartTotal(int dataScenario)
        {
            int promoPrice, totalPriceMultiProd = 0;
            int cTotal = 0;


            var productList = new List<ProductCatalogue>(ObjOrderData.Products());
            var multiOfferList = new List<PromotionData>(ObjOrderData.MultiProductOffer());
            var combinedOfferList = new List<PromotionData>(ObjOrderData.CombinedProductOffer());
            var custOrder = new List<OrderData>(ObjOrderData.Order(dataScenario));

            List<int> ordQtySKU = new List<int>();
            List<int> OrdQtySKU1 = new List<int>();
            List<int> actualSKU1Price = new List<int>();

            List<PromotionData> mProd = new List<PromotionData>();
            List<PromotionData> cProd = new List<PromotionData>();
            ISubmitCart objSubmit = new ProcessCart();

            foreach (var item in productList)
            {
                ordQtySKU = custOrder.Where(x => x.OrdSKUID.Contains(item.ProdID)).Select(x => x.OrdSKUQty).ToList();
                mProd = multiOfferList.Where(x => x.PromSKU.Equals(item.ProdID)).ToList();
                cProd = combinedOfferList.Where(x => x.PromSKU.Equals(item.ProdID)).ToList();


                if (mProd.Count > 0)
                {
                    int ctTotal = objSubmit.ApplyMultiProductPromo(ordQtySKU, mProd, item.ProdPrice);
                    totalPriceMultiProd += ctTotal;
                }

                if (cProd.Count > 0)
                {
                    // Calculating Combined product purchase promotion

                    OrdQtySKU1 = (custOrder.Where(x => cProd[0].PromSKU1.Equals(x.OrdSKUID)).Select(x => x.OrdSKUQty)).ToList();
                    actualSKU1Price = (productList.Where(x => cProd[0].PromSKU1.Contains(x.ProdID)).Select(x => x.ProdPrice)).ToList();
                    promoPrice = cProd[0].PromPrice;

                    int ctcmbTotal = objSubmit.ApplyCombinedProductPromo(ordQtySKU, OrdQtySKU1, actualSKU1Price, item.ProdPrice, promoPrice);
                    cTotal += ctcmbTotal;

                }
            }

            return cTotal + totalPriceMultiProd;

        }

    }

}




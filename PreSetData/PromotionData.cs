using System;
using System.Collections.Generic;

namespace PreSetData
{
    public class PromotionData
    {
        public string PromSKU { get; set; }
        public string PromSKU1 { get; set; }
        public int PromPrice { get; set; }
        public int PromCount { get; set; }
        public List<PromotionData> MultiProductOffer()
        {
            // Define Multiple purchase promotional Offers
            List<PromotionData> mutliPurchaseOffers = new List<PromotionData>();
            mutliPurchaseOffers.Add(new PromotionData() { PromSKU = "A", PromCount = 3, PromPrice = 130 });
            mutliPurchaseOffers.Add(new PromotionData() { PromSKU = "B", PromCount = 2, PromPrice = 45 });
            return mutliPurchaseOffers;
        }

        public List<PromotionData> CombinedProductOffer()
        {
            // Define Combined purchase promotional Offers
            List<PromotionData> combinedPurchaseOffers = new List<PromotionData>
            {
                new PromotionData() { PromSKU = "C", PromSKU1 = "D", PromPrice = 30 }
            };
            return combinedPurchaseOffers;
        }
    }
}


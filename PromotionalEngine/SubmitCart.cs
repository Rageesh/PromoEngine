using PreSetData;
using System;
using System.Collections.Generic;

namespace PromotionalEngine
{
    interface ISubmitCart
    {
        int ApplyCombinedProductPromo(List<int> OrdQtySKU, List<int> OrdQtySKU1, List<int> actualSKU1Price, int price, int promoPrice);
        int ApplyMultiProductPromo(List<int> orderQty, List<PromotionData> mProd, int price);
    }

    class ProcessCart : ISubmitCart
    {
        int promoQty, promoPrice = 0;
        int cDiff, cSum, cBal = 0;
        int curMitemTotal, curCitemTotal = 0;

        List<int> ordQtySKU = new List<int>();
        public int ApplyCombinedProductPromo(List<int> ordQtySKU, List<int> ordQtySKU1, List<int> actualSKU1Price, int price, int promoPrice)
        {


            // Calculating Combined product purchase promotion

            cDiff = Math.Abs(ordQtySKU[0] - ordQtySKU1[0]);
            cSum = ordQtySKU[0] + ordQtySKU1[0];

            if (ordQtySKU[0] > ordQtySKU1[0])
                cBal = cDiff * price;
            else
                cBal = cDiff * actualSKU1Price[0];

            curCitemTotal = (((cSum - cDiff) / 2) * promoPrice) + cBal;

            return curCitemTotal;
        }
        public int ApplyMultiProductPromo(List<int> orderQty, List<PromotionData> mProd, int price)
        {

            if (mProd[0].PromCount > 0)
            {
                if (mProd[0].PromPrice > 0)
                {
                    promoQty = mProd[0].PromCount;
                    promoPrice = mProd[0].PromPrice;

                    //Current item promotion applied total
                    curMitemTotal = (orderQty[0] / promoQty) * promoPrice + (orderQty[0] % promoQty * price);
                }
            }

            return curMitemTotal;
        }
    }
}

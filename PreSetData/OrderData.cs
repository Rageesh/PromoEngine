using System;
using System.Collections.Generic;

namespace PreSetData
{
    public class OrderData : ProductCatalogue
    {


        public string OrdSKUID { get; set; }
        public int OrdSKUQty { get; set; }

        public List<OrderData> Order(int dataScenario)
        {
            // Add or Delete Order Scenario 
            List<OrderData> lstOrders = new List<OrderData>();

            switch (dataScenario)
            {
                case 1:
                    lstOrders.Add(new OrderData() { OrdSKUID = "A", OrdSKUQty = 1 });
                    lstOrders.Add(new OrderData() { OrdSKUID = "B", OrdSKUQty = 1 });
                    lstOrders.Add(new OrderData() { OrdSKUID = "C", OrdSKUQty = 1 });
                    lstOrders.Add(new OrderData() { OrdSKUID = "D", OrdSKUQty = 0 });
                    break;
                case 2:
                    lstOrders.Add(new OrderData() { OrdSKUID = "A", OrdSKUQty = 5 });
                    lstOrders.Add(new OrderData() { OrdSKUID = "B", OrdSKUQty = 5 });
                    lstOrders.Add(new OrderData() { OrdSKUID = "C", OrdSKUQty = 1 });
                    lstOrders.Add(new OrderData() { OrdSKUID = "D", OrdSKUQty = 0 });
                    break;
                case 3:
                    lstOrders.Add(new OrderData() { OrdSKUID = "A", OrdSKUQty = 3 });
                    lstOrders.Add(new OrderData() { OrdSKUID = "B", OrdSKUQty = 5 });
                    lstOrders.Add(new OrderData() { OrdSKUID = "C", OrdSKUQty = 1 });
                    lstOrders.Add(new OrderData() { OrdSKUID = "D", OrdSKUQty = 1 });
                    break;
                case 4:
                    lstOrders.Add(new OrderData() { OrdSKUID = "A", OrdSKUQty = 5 });
                    lstOrders.Add(new OrderData() { OrdSKUID = "B", OrdSKUQty = 5 });
                    lstOrders.Add(new OrderData() { OrdSKUID = "C", OrdSKUQty = 6 });
                    lstOrders.Add(new OrderData() { OrdSKUID = "D", OrdSKUQty = 4 });
                    break;
            }
            return lstOrders;
        }
    }
}

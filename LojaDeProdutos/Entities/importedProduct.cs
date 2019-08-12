using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace LojaDeProdutos.Entities
{
    class importedProduct : Product
    {
        public double CustomsFee { get; set; }


        public importedProduct()
        {
        }

        public importedProduct(string name, double price, double customsFee)
            :base (name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return Name
                + " $ "
                +TotalPrice().ToString("F2",CultureInfo.InvariantCulture)
                +"(Customs fee: $ "
                + CustomsFee.ToString("F2",CultureInfo.InvariantCulture)
                + ")";

        }
    }

    
}

using System;

namespace Store
{
    public class Seller
    {
        float _moneyEarned=0;



        public void SellNewspaper(NewsCompany.newspaper newspaper)
        {
            _moneyEarned+=newspaper.GetPrice();
        }
        public override string ToString()
        {
            return base.ToString()+ $"_moneyEarned: {_moneyEarned}";
        }

    }
}

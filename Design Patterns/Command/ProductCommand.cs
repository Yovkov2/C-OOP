using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class ProductCommand : ICommand
    {
        private readonly Product _product;
        private readonly PriceAction _priceAction;
        private readonly int _amount;

        public ProductCommand(Product product, PriceAction priceAction, int amount)
        {
            _product = product;
            _priceAction = priceAction;
            _amount = amount;
        }

        public void ExecuteAction()
        {
            if(_priceAction == PriceAction.Increase)
            {
                _product.IncreassePrice(_amount);
            }
            else
            {
                _product.DecreassePrice(_amount);
            }
        }
    }
}

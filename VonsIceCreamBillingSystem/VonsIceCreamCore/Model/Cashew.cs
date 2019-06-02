using System;
using System.Collections.Generic;
using System.Text;
using VonsIceCreamCore.Model.Base;

namespace VonsIceCreamCore.Model
{
    /// <summary>
    /// Cashew toppings
    /// </summary>
    public class Cashew : ToppingsBase
    {
        IceCreamBase _icecream;
        double cost = 1.0;

        public Cashew(IceCreamBase icecream)
        {
            _icecream = icecream;
        }
        public override string Description() => _icecream.Description() + " with Cashew";

        public override double Cost()
        {
            return _icecream.Cost() + cost;
        }
    }
}

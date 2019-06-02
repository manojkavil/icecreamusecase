using System;
using System.Collections.Generic;
using System.Text;
using VonsIceCreamCore.Model.Base;

namespace VonsIceCreamCore.Model
{
    /// <summary>
    /// Cookies toppings
    /// </summary>
    public class Cookies : ToppingsBase
    {
        IceCreamBase _icecream;
        double cost = 0.6;

        public Cookies(IceCreamBase icecream)
        {
            _icecream = icecream;
        }
        public override string Description() => _icecream.Description() + " with Cookies";

        public override double Cost()
        {
            return _icecream.Cost() + cost;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using VonsIceCreamCore.Model.Base;

namespace VonsIceCreamCore.Model
{
    /// <summary>
    /// Fruits toppings
    /// </summary>
    public class Fruits : ToppingsBase
    {
        IceCreamBase _icecream;
        double cost = 0.8;

        public Fruits(IceCreamBase icecream)
        {
            _icecream = icecream;
        }
        public override string Description() => _icecream.Description() + " with Fruits";

        public override double Cost()
        {
            return _icecream.Cost() + cost;
        }
    }
}

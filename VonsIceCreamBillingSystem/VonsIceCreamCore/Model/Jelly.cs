using System;
using System.Collections.Generic;
using System.Text;
using VonsIceCreamCore.Model.Base;

namespace VonsIceCreamCore.Model
{
    /// <summary>
    /// Jelly toppings
    /// </summary>
    public class Jelly : ToppingsBase
    {
        IceCreamBase _icecream;
        double cost = 0.7;

        public Jelly(IceCreamBase icecream)
        {
            _icecream = icecream;
        }
        public override string Description() => _icecream.Description() + " with Jelly";

        public override double Cost()
        {
            return _icecream.Cost() + cost;
        }
    }
}

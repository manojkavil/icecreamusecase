using System;
using System.Collections.Generic;
using System.Text;
using VonsIceCreamCore.Model.Base;

namespace VonsIceCreamCore.Model
{
    /// <summary>
    /// Almond toppings
    /// </summary>
    public class Almond : ToppingsBase
    {
        IceCreamBase _icecream;
        double cost = 0.9;

        public Almond(IceCreamBase icecream)
        {
            _icecream = icecream;
        }
        public override string Description() => _icecream.Description() + " with Almond";

        public override double Cost()
        {
            return _icecream.Cost() + cost;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using VonsIceCreamCore.Model.Base;

namespace VonsIceCreamCore.Model
{
    /// <summary>
    /// Pistachio toppings
    /// </summary>
    public class Pistachio : ToppingsBase
    {
        IceCreamBase _icecream;
        double cost = 1.1;

        public Pistachio(IceCreamBase icecream)
        {
            _icecream = icecream;
        }
        public override string Description() => _icecream.Description() + " with Pistachio";

        public override double Cost()
        {
            return _icecream.Cost() + cost;
        }
    }
}

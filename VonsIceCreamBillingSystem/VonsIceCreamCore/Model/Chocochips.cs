using System;
using System.Collections.Generic;
using System.Text;
using VonsIceCreamCore.Model.Base;

namespace VonsIceCreamCore.Model
{
    /// <summary>
    /// Chocochips toppings
    /// </summary>
    public class Chocochips : ToppingsBase
    {
        IceCreamBase _icecream;
        double cost = 0.5;

        public Chocochips(IceCreamBase icecream)
        {
            _icecream = icecream;
        }
        public override  string Description()
        {
            return _icecream.Description() + " with Chocochips";
        }

        public override double Cost()
        {
          return  _icecream.Cost() + cost;
        }
    }
}

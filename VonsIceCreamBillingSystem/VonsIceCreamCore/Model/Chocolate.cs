using System;
using System.Collections.Generic;
using System.Text;
using VonsIceCreamCore.Model.Base;

namespace VonsIceCreamCore.Model
{
    /// <summary>
    /// Chocolate ice cream
    /// </summary>
    public class Chocolate : IceCreamBase
    {
        private double cost = 2.0;

        public Chocolate()
        {
            descripton = "Chocolate flavour";
        }
        public override double Cost()
        {
            return cost * NoOfScoops;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using VonsIceCreamCore.Model.Base;

namespace VonsIceCreamCore.Model
{
    /// <summary>
    /// Hazelnut icecream
    /// </summary>
    public class Hazelnut : IceCreamBase
    {
        private double cost = 3.0;

        public Hazelnut()
        {
            descripton = "Hazelnut flavour";
        }
        public override double Cost()
        {
            return cost * NoOfScoops;
        }
    }
}

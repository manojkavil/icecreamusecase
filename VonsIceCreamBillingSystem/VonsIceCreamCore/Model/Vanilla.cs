using System;
using System.Collections.Generic;
using System.Text;
using VonsIceCreamCore.Model.Base;

namespace VonsIceCreamCore.Model
{
    /// <summary>
    /// Vanilla flavour
    /// </summary>
    public class Vanilla : IceCreamBase
    {
        private double cost = 1.0;

        public Vanilla()
        {
            descripton = "Vanilla flavour";
        }
        public override double Cost()
        {
            return cost * NoOfScoops;
        }
    }
}

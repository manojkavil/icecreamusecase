using System;
using System.Collections.Generic;
using System.Text;
using VonsIceCreamCore.Model.Base;

namespace VonsIceCreamCore.Model
{
    /// <summary>
    /// CookiesAndCream flavour
    /// </summary>
    public class CookiesAndCream : IceCreamBase
    {
        private double cost = 1.4;

        public CookiesAndCream()
        {
            descripton = "Cookies & Cream flavour";
        }
        public override double Cost()
        {
            return cost * NoOfScoops;
        }
    }
}

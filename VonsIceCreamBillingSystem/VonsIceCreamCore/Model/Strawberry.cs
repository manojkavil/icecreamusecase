using System;
using System.Collections.Generic;
using System.Text;
using VonsIceCreamCore.Model.Base;

namespace VonsIceCreamCore.Model
{
    public class Strawberry : IceCreamBase
    {
        private double cost = 1.5;

        public Strawberry()
        {
            descripton = "Strawberry flavour";
        }
        public override double Cost()
        {
            return cost * NoOfScoops;
        }
    }
}

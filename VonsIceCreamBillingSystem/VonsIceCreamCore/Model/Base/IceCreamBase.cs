using System;
using System.Collections.Generic;
using System.Text;

namespace VonsIceCreamCore.Model.Base
{
    public abstract class IceCreamBase
    {
        protected string descripton = "unknown flavour";

        public virtual string Description()
        {
            return descripton;
        }

        public virtual int NoOfScoops { get; set; } = 1;

        public abstract double Cost();

    }
}

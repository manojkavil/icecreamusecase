using System;
using VonsIceCreamCore.Model;
using VonsIceCreamCore.Model.Base;

namespace VonsIceCreamFacotryLib
{
    public class VonsIceCreamFacotry
    {
        IceCreamBase _icecream;
        public IceCreamBase Create(int flavourOption, int noOfScoops = 1)
        {
            switch (flavourOption)
            {
                case (int)Flavour.Vanilla:
                    _icecream = new Vanilla();
                    break;
                case (int)Flavour.Chocolate:
                    _icecream = new Chocolate();
                    break;
                case (int)Flavour.Strawberry:
                    _icecream = new Strawberry();
                    break;
                case (int)Flavour.CookiesAndCream:
                    _icecream = new CookiesAndCream();
                    break;
                case (int)Flavour.Hazelnut:
                    _icecream = new Hazelnut();
                    break;
            }
            _icecream.NoOfScoops = noOfScoops;
            return _icecream;
        }
        public IceCreamBase Addon(int toppings, IceCreamBase icecream)
        {
            switch (toppings)
            {
                case (int)Toppings.Chocochips:
                    icecream = new Chocochips(icecream);
                    break;
                case (int)Toppings.Cookies:
                    icecream = new Cookies(icecream);
                    break;
                case (int)Toppings.Jelly:
                    icecream = new Jelly(icecream);
                    break;
                case (int)Toppings.Fruits:
                    icecream = new Fruits(icecream);
                    break;
                case (int)Toppings.Almonnd:
                    icecream = new Almond(icecream);
                    break;
                case (int)Toppings.Cashew:
                    icecream = new Cashew(icecream);
                    break;
                case (int)Toppings.Pistachio:
                    icecream = new Pistachio(icecream);
                    break;
                default:
                    break;
            }

            return icecream;

        }
    }
}

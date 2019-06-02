using System;
using VonsIceCreamCore.Model;
using VonsIceCreamCore.Model.Base;
using VonsIceCreamFacotryLib;

namespace VonsIceCreamBillingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            IceCreamBase iceCream;
            VonsIceCreamFacotry vonsIceCreamFacotry;
            int menuSelection = 0;
            bool blnSelected = false;
            int flavourSelection = 0;

            Console.WriteLine("**************************************************");
            Console.WriteLine("Von’s IceCream House!");
            Console.WriteLine("-----------------------Menu------------------------");

            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Icecream");
            Console.WriteLine("2. Icecream with chocochips");
            Console.WriteLine("3. Icecream with cookies");
            Console.WriteLine("4. Icecream with nuts (almonds / cashew/ pistachio");
            Console.WriteLine("5. Icecream with jelly");
            Console.WriteLine("6. Icecream with fruits");
            Console.WriteLine("7. Customize your dessert");
            Console.WriteLine("---------------------------------------------------");


            while (!blnSelected)
            {
                try
                {
                    Console.Write("Please Select your menu option: ");
                    menuSelection = Convert.ToInt32(Console.ReadLine());
                    blnSelected = menuSelection > 0 && menuSelection < 8;
                    if (menuSelection == 0) return;
                }
                catch
                {
                    blnSelected = false;
                }
                finally
                {
                    if (!blnSelected)
                    {
                        Console.WriteLine("Menu selection is wrong...");
                    }

                }
            }
            blnSelected = false;
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Vanilla");
            Console.WriteLine("2. Chocolate");
            Console.WriteLine("3. Strawberry");
            Console.WriteLine("4. CookiesAndCream");
            Console.WriteLine("5. Hazelnut");

            while (!blnSelected)
            {
                try
                {
                    Console.Write("Select your flavour: ");
                    flavourSelection = Convert.ToInt32(Console.ReadLine());
                    blnSelected = flavourSelection > 0 && flavourSelection < 6;
                    if (flavourSelection == 0) return;
                }
                catch
                {
                    blnSelected = false;
                }
                finally
                {
                    if (!blnSelected)
                    {
                        Console.WriteLine("Flavour selection is wrong...");
                    }

                }
            }
            blnSelected = false;

            vonsIceCreamFacotry = new VonsIceCreamFacotry();

            if (menuSelection == ((int)MenuConstants.IceCreamFlavour))
            {                
                iceCream = vonsIceCreamFacotry.Create(flavourSelection);
            }
            else 
            {
                var blnIteration = false;               
                if (menuSelection == ((int)MenuConstants.CustomizedIceCream))
                {

                    blnIteration = true;
                    int noOfScoops = 1;
                    try
                    {
                        Console.Write("How many scoops you want to add...? ");
                         noOfScoops = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {

                    }

                    iceCream = vonsIceCreamFacotry.Create(flavourSelection, noOfScoops);
                }
                else
                {                    
                    iceCream = vonsIceCreamFacotry.Create(flavourSelection);
                }
               

                int toppings = 0;

                
                switch (menuSelection)
                {
                    case (int)MenuConstants.IceCreamWithChocochips:
                        toppings = (int)Toppings.Chocochips;
                        break;
                    case (int)MenuConstants.IceCreamWithCokkies:
                        toppings = (int)Toppings.Cookies;
                        break;
                    case (int)MenuConstants.IceCreamWithJelly:
                        toppings = (int)Toppings.Jelly;
                        break;
                    case (int)MenuConstants.IceCreamWithFruits:
                        toppings = (int)Toppings.Fruits;
                        break;
                    case (int)MenuConstants.IceCreamWithNuts:
                        try
                        {
                            Console.Write("Select nuts option, 1. Almond, 2. Cashew, 3. Pistachio: ");
                            toppings = Convert.ToInt32(Console.ReadLine());
                            switch (toppings)
                            {
                                case 1:
                                    toppings = (int)Toppings.Almonnd;
                                    break;
                                case 2:
                                    toppings = (int)Toppings.Cashew;
                                    break;
                                case 3:
                                    toppings = (int)Toppings.Pistachio;
                                    break;
                                default:
                                    toppings = 0;
                                    break;
                            }
                        }
                        catch
                        {
                            toppings = 0;
                        }

                        break;
                }
                
                iceCream = vonsIceCreamFacotry.Addon(toppings, iceCream);


                while (blnIteration)
                {
                    Console.Write("Do you want to  add more toppings?...Y/N: ");
                    var ans = Console.ReadLine();
                    blnIteration = ans.ToLower().Equals("y");

                    if (blnIteration)
                    {
                        Console.WriteLine("Select Toppings: ");
                        Console.WriteLine("0. Exit");
                        Console.WriteLine("1. Chocochips");
                        Console.WriteLine("2. Cookies");
                        Console.WriteLine("3. Jelly");
                        Console.WriteLine("4. Fruits");
                        Console.WriteLine("5. Almonnd");
                        Console.WriteLine("6. Cashew");
                        Console.WriteLine("7. Pistachio");
                        
                        int tpng = 0;
                        try
                        {
                            
                            tpng = Convert.ToInt32(Console.ReadLine());
                            blnIteration = tpng > 0 && tpng < 8;                            
                        }
                        catch
                        {
                            blnIteration = false;
                        }
                        
                        switch (tpng)
                        {
                            case 1:
                                toppings = (int)Toppings.Chocochips;
                                break;
                            case 2:
                                toppings = (int)Toppings.Cookies;
                                break;
                            case 3:
                                toppings = (int)Toppings.Jelly;
                                break;
                            case 4:
                                toppings = (int)Toppings.Fruits;
                                break;
                            case 5:
                                toppings = (int)Toppings.Almonnd;
                                break;
                            case 6:
                                toppings = (int)Toppings.Cashew;
                                break;
                            case 7:
                                toppings = (int)Toppings.Pistachio;
                                break;
                        }

                        iceCream = vonsIceCreamFacotry.Addon(toppings, iceCream);
                    }
                }

            }


            Print(iceCream);



            Console.ReadLine();


        }

        private static void Print(IceCreamBase iceCream)
        {
          
            Console.WriteLine("***************************************************");
            Console.WriteLine("-----------Billing---------");
            Console.WriteLine($"{iceCream.Description()} : {iceCream.Cost()} $");

        }
    }
   
}

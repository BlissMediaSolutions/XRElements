using System;
using System.Collections;
using System.Collections.Generic;

namespace xrelements
{
    //Public Enumerator of all valid Product Codes
    public enum ProductCode
    { SH3, YT2, TR }
        
    class Program
    {
        static void Main(string[] args)
        {
            string input;                                                        //value which is inputted in console
            bool valid = true;                                                   //Are the inputs valid?
            List<Product> prodList = new List<Product>();                        //Create a List of Product Object

            Console.WriteLine("Please Enter the Order (type '-1' to end order)");

            while ((input = Console.ReadLine()) != "-1")
            {
                //set a temp default value for qty and code
                int qty = 0;
                ProductCode code = ProductCode.SH3;

                string[] command = input.Split(' ');

                //Validation check of the first input value entered (Qty)
                if (!int.TryParse(command[0], out qty) || (qty <= 2))
                    valid = false;

                //Validation check of the second input value entered (Code)
                if (!Enum.TryParse<ProductCode>(command[1], out code))
                    valid = false;
                
                //If values aren't valid output error msg, otherwise add it to the ProductList
                if (!valid)
                    Console.WriteLine("Error: Invalid Qty or Product Code");
                else
                {
                    switch (code)
                    {
                        case ProductCode.SH3:
                            prodList.Add(new SH3(qty, code));
                            break;
                        case ProductCode.YT2:
                            prodList.Add(new YT2(qty, code));
                            break;
                        case ProductCode.TR:
                            prodList.Add(new TR(qty, code));
                            break;  
                    }
                }
                valid = true;
            }

            Console.WriteLine(" ");
            foreach (var product in prodList)
            {
                product.Order(product.Qty);
                Console.WriteLine(product.Output());
            }           
        }
    }
}

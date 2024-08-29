using System;

namespace ARP_Project
{
    class Project
    {
        static void Main(string[] args)
        {
            decimal length, width, area, materialCost = 0M, laborCost = 0M, totalCost, tax;
            int floorMaterialNum;
            string floorMaterial = "";

            while (true)
            {
                Console.Write("Enter room length in feet: ");
                string inputLength = (Console.ReadLine()).Replace(" ", "");
                Console.WriteLine();

                if (decimal.TryParse(inputLength, out length))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid length! Enter a number.");
                    Console.WriteLine();
                }
            }

            while (true)
            {
                Console.Write("Enter room width in feet: ");
                string inputWidth = (Console.ReadLine()).Replace(" ", "");
                Console.WriteLine();

                if (decimal.TryParse(inputWidth, out width))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid width! Enter a number.");
                    Console.WriteLine();
                }
            }

            while (true)
            {
                Console.WriteLine("*******************************");
                Console.WriteLine("* Commercial carpet = key '1' *");
                Console.WriteLine("*  Quality carpet = key '2'   *");
                Console.WriteLine("*  Hardwood floor = key '3'   *");
                Console.WriteLine("*  Floating floor = key '4'   *");
                Console.WriteLine("*   Ceramic tiles = key '5'   *");
                Console.WriteLine("*******************************");
                Console.WriteLine();
                Console.Write("Enter number for the floor material: ");
                string inputFlootMaterial = (Console.ReadLine()).Replace(" ", "");
                Console.WriteLine();

                if (int.TryParse(inputFlootMaterial, out floorMaterialNum) && floorMaterialNum < 6 && floorMaterialNum > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid floor material!");
                    Console.WriteLine();
                }
            }

            switch (floorMaterialNum)
            {
                case 1:
                    materialCost = 1.29M;
                    laborCost = 2M;
                    floorMaterial = "Commercial carpet";
                    break;

                case 2:
                    materialCost = 3.99M;
                    laborCost = 2.25M;
                    floorMaterial = "Quality carpet";
                    break;
                case 3:
                    materialCost = 3.49M;
                    laborCost = 3.25M;
                    floorMaterial = "Hardwood floors";
                    break;
                case 4:
                    materialCost = 1.99M;
                    laborCost = 2.25M;
                    floorMaterial = "Floating floors";
                    break;
                case 5:
                    materialCost = 1.49M;
                    laborCost = 3.25M;
                    floorMaterial = "Ceramic tiles";
                    break;
            }

            area = length * width;
            area = Math.Round(area, 3);

            materialCost = area * materialCost;
            materialCost = Math.Round(materialCost, 2);

            laborCost = area * laborCost;
            laborCost = Math.Round(laborCost, 2);

            tax = (materialCost + laborCost) * 0.15M;
            tax = Math.Round(tax, 2);

            totalCost = materialCost + laborCost + tax;
            totalCost = Math.Round(totalCost, 2);

            Console.WriteLine($"A room that is {area} ft2 with {floorMaterial} that costs ${materialCost} and costs ${laborCost} to install. The total tax is ${tax} this makes a total cost of ${totalCost}.");
        }
    }
}
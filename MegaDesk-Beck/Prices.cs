using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Beck
{
    static internal class Prices
    {
        private static int baseCost = 200;
        private static int sqInCostOverThreshhold = 1;
        private static int sqInCostThreshold = 1000;
        private static int pricePerDrawer = 50;
        private static int rushOrderPrices = 0;

        public static double CalculatePrice(MaterialType material, double surfaceArea, int drawerCount, int rushDays)
        {
            double subTotal = 0.0;
            subTotal += baseCost;

            if (surfaceArea - sqInCostThreshold > 0)
            {
                subTotal += (surfaceArea - sqInCostThreshold) * sqInCostOverThreshhold;
            }

            subTotal += pricePerDrawer * drawerCount;

            switch (material)
            {
                case MaterialType.Oak:
                    subTotal += 200;
                    break;
                case MaterialType.Laminate:
                    subTotal += 100;
                    break;
                case MaterialType.Pine:
                    subTotal += 50;
                    break;
                case MaterialType.Rosewood:
                    subTotal += 300;
                    break;
                case MaterialType.Veneer:
                    subTotal += 125;
                    break;
            }

            if (rushDays != 0)
            {
                subTotal += rushOrderPrices;
            }
            return subTotal;
        }

    }
}

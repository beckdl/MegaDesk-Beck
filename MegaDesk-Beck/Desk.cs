using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Beck
{

    internal class Desk
    {
        public double deskDepth;
        public double deskWidth;
        public int deskDrawerCount;
        public MaterialType material;
    }
    public enum MaterialType
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }

}

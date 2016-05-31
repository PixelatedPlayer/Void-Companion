using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Companion_v2._0
{

    public class Tower
    {
        public string Name;

        public Item_PieceC[] Drops;

        public Tower(string name, Item_Piece[] drops, double[] dropC)
        {
            this.Name = name;
            this.Drops = new Item_PieceC[drops.Length];

            for (int i = 0; i < drops.Length; i++)
            {
                this.Drops[i] = new Item_PieceC(drops[i], dropC[i], this);
            }
        }
    }
}

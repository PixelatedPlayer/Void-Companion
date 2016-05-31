using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Companion_v2._0
{
    public class Rotation
    {
        public string Name;

        public Item_PieceC[] RotA, RotB, RotC;

        public Rotation(string name, Item_Piece[] rotA, double[] rotAchance, Item_Piece[] rotB, double[] rotBchance, Item_Piece[] rotC, double[] rotCchance)
        {
            this.Name = name;

            this.RotA = new Item_PieceC[rotA.Length];
            this.RotB = new Item_PieceC[rotB.Length];
            this.RotC = new Item_PieceC[rotC.Length];

            for (int i = 0; i < rotA.Length; i++)
                this.RotA[i] = new Item_PieceC(rotA[i], rotAchance[i], this, "A");

            for (int i = 0; i < rotB.Length; i++)
                this.RotB[i] = new Item_PieceC(rotB[i], rotBchance[i], this, "B");

            for (int i = 0; i < rotC.Length; i++)
                this.RotC[i] = new Item_PieceC(rotC[i], rotCchance[i], this, "C");

        }
    }
}

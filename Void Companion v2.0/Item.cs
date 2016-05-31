using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Companion_v2._0
{
    public class Item //only name, each piece will direct to parent item
    {
        public string Name;

        //public Item_Piece[] Pieces;

        public Item(string name)//, Item_Piece[] pieces)
        {
            this.Name = name;
            //this.Pieces = pieces;
        }
    }

    public class Item_Piece
    {
        public string Name;
        public int Count;
        public Item Parent;
        public int Ducats_U;
        public int Ducats_C;

        public Item_Piece(string name, Item parent, int ducats_u = 0, int ducats_c = 0, int count = 1)
        {
            this.Name = name;
            this.Parent = parent;
            this.Ducats_U = ducats_u;
            this.Ducats_C = ducats_c;
            this.Count = count;
        }
    }

    public class Item_PieceC
    {
        public Item_Piece Piece;
        public Tower ParentTower;
        public Rotation ParentRotation;
        public string Rot;
        public double Chance;

        public Item_PieceC(Item_Piece piece, double chance, Tower parent)
        {
            this.Piece = piece;
            this.Chance = chance;
            this.ParentTower = parent;
        }

        public Item_PieceC(Item_Piece piece, double chance, Rotation parent, string rot)
        {
            this.Piece = piece;
            this.Chance = chance;
            this.ParentRotation = parent;
            this.Rot = rot;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frani_Voxel_Map_Editor {
    public enum TileTypes {
        VOID = 0,
        SOIL = 1,
        GRASS = 2,
        SAND = 3,
        WATER = 4
    }

    public class Tile {
        public int posX;
        public int posY;
        public int posZ;

        public TileTypes type;

        public Tile(int posX, int posY, int posZ, TileTypes type = TileTypes.VOID) {
            this.posX = posX;
            this.posY = posY;
            this.posZ = posZ;
            this.type = type;
        }
    }
}

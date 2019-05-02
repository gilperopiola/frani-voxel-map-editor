using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace Frani_Voxel_Map_Editor {
    public class Map {
        public int width;
        public int height;
        public int depth;

        public List<List<List<Tile>>> tiles;

        public Map(int width, int height, int depth) {
            this.width = width;
            this.height = height;
            this.depth = depth;

            tiles = new List<List<List<Tile>>>();
            for (int z = 0; z < depth; z++) { //traverses depth
                tiles.Add(new List<List<Tile>>());
                for (int y = 0; y < height; y++) { //traverses height
                    tiles[z].Add(new List<Tile>());
                    for (int x = 0; x < width; x++) { //traverses width
                        tiles[z][y].Add(new Tile(x, y, z));
                    }
                }
            }
        }

        public void CopyLayer(int from, int to) {
            for (int y = 0; y < tiles[from].Count; y++) {
                for (int x = 0; x < tiles[from][y].Count; x++) {
                    tiles[to][y][x] = new Tile(x, y, to, tiles[from][y][x].type);
                }
            }
        }

        public List<Tile> GetTilesToPaint(Tile tile) {
            List<Tile> openList = new List<Tile>();
            List<Tile> closedList = new List<Tile>();

            openList.Add(tile);

            while (openList.Count > 0) {
                Tile currTile = openList[0];
                int x = currTile.posX;
                int y = currTile.posY;
                int z = currTile.posZ;

                //up
                if (y > 0 && tiles[z][y - 1][x].type == tile.type && !closedList.Contains(tiles[z][y - 1][x]) && !openList.Contains(tiles[z][y - 1][x])) {
                    openList.Add(tiles[z][y - 1][x]);
                }

                //right
                if (x < width - 1 && tiles[z][y][x+1].type == tile.type && !closedList.Contains(tiles[z][y][x+1]) && !openList.Contains(tiles[z][y][x + 1])) {
                    openList.Add(tiles[z][y][x+1]);
                }

                //down
                if (y < height - 1 && tiles[z][y + 1][x].type == tile.type && !closedList.Contains(tiles[z][y + 1][x]) && !openList.Contains(tiles[z][y + 1][x])) {
                    openList.Add(tiles[z][y + 1][x]);
                }

                //left
                if (x > 0 && tiles[z][y][x-1].type == tile.type && !closedList.Contains(tiles[z][y][x - 1]) && !openList.Contains(tiles[z][y][x - 1])) {
                    openList.Add(tiles[z][y][x - 1]);
                }

                openList.Remove(currTile);
                closedList.Add(currTile);
            }

            return closedList;
        }

        public void Resize(int width, int height, int depth) {
            this.width = width;
            this.height = height;
            this.depth = depth;

            #region Minimize
            if (depth < tiles.Count) {
                tiles.RemoveRange(depth, tiles.Count - depth);
            }

            for (int z = 0; z < tiles.Count; z++) {
                if (height < tiles[z].Count) {
                    tiles[z].RemoveRange(height, tiles[z].Count - height);
                }

                for (int y = 0; y < tiles[z].Count; y++) {
                    if (width < tiles[z][y].Count) {
                        tiles[z][y].RemoveRange(width, tiles[z][y].Count - width);
                    }
                }
            }
            #endregion

            #region Maximize
            for (int z = 0; z < depth; z++) {
                if (z > tiles.Count -1) {
                    tiles.Add(new List<List<Tile>>());
                }

                for (int y = 0; y < height; y++) {
                    if (y > tiles[z].Count -1) {
                        tiles[z].Add(new List<Tile>());
                    }

                    for (int x = 0; x < width; x++) {
                        if (x > tiles[z][y].Count -1) {
                            tiles[z][y].Add(new Tile(x, y, z));
                        }
                    }
                }
            }
            #endregion
        }

        public void Save() {
            string json = JsonConvert.SerializeObject(this, new JsonSerializerSettings() {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });

            FileHandler.Write("vmap.json", json);
        }
    }
}

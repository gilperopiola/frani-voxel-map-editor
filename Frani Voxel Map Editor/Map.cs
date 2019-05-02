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

        public List<Tile> tiles;

        public Map(int width, int height, int depth) {
            this.width = width;
            this.height = height;
            this.depth = depth;

            tiles = new List<Tile>();
            for (int z = 0; z < depth; z++) {
                for (int y = 0; y < height; y++) {
                    for (int x = 0; x < width; x++) {
                        tiles.Add(new Tile(x, y, z));
                    }
                }
            }
        }

        public void Resize(int width, int height, int depth) {
            this.width = width;
            this.height = height;
            this.depth = depth;

            List<Tile> oldTiles = new List<Tile>(tiles);
            tiles = new List<Tile>();
            for (int z = 0; z < depth; z++) {
                for (int y = 0; y < height; y++) {
                    for (int x = 0; x < width; x++) {
                        int index = x + y * width + depth * width * height;

                        if (index < oldTiles.Count - 1) {
                            tiles.Add(oldTiles[x + y * width + depth * width * height]);
                        } else {
                            tiles.Add(new Tile(x, y, z));
                        }
                    }
                }
            }
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

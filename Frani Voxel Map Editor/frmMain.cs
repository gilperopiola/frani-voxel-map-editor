using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frani_Voxel_Map_Editor {

    public enum DrawTypes {
        PENCIL = 0,
        BUCKET = 1
    }

    public partial class frmMain : Form {
        private Map map;

        private List<PictureBox> grid;
        private int currentLayer = 0;

        private DrawTypes drawType;
        private TileTypes tileType;

        public frmMain(Map loadedMap = null) {
            InitializeComponent();

            map = loadedMap != null ? loadedMap : new Map(20, 20, 6);

            drawType = DrawTypes.PENCIL;
            tileType = TileTypes.VOID;

            CreateGrid(map, currentLayer);
        }

        #region Grid
        private void grid_Click(object sender, EventArgs e) {
            PictureBox gridTile = (PictureBox)sender;
            string[] tileCoords = gridTile.Name.Substring(4).Split('-');
            int x = Convert.ToInt32(tileCoords[0]);
            int y = Convert.ToInt32(tileCoords[1]);
            int z = Convert.ToInt32(tileCoords[2]);

            Tile tile = map.tiles[z][y][x];

            if (drawType == DrawTypes.PENCIL) {
                tile.type = tileType;
                gridTile.Image = GetImageFromTileType(tileType);
            }

            if (drawType == DrawTypes.BUCKET) {
                List<Tile> tilesToPaint = map.GetTilesToPaint(tile);

                foreach (Tile tileToPaint in tilesToPaint) {
                    tileToPaint.type = tileType;
                }
                tile.type = tileType;

                CreateGrid(map, currentLayer);
            }
        }

        private void CreateGrid(Map map, int currentLayer) {
            ClearGrid();

            for (int y = 0; y < map.height; y++) {
                for (int x = 0; x < map.width; x++) {

                    PictureBox tile = new PictureBox();
                    tile.Name = "tile" + x + "-" + y + "-" + currentLayer;
                    tile.Location = new Point(32 * x, 32 * y);
                    tile.Size = new Size(32, 32);
                    tile.Click += new EventHandler(grid_Click);
                    tile.Image = GetImageFromTileType(map.tiles[currentLayer][y][x].type);

                    grid.Add(tile);
                }
            }

            foreach (PictureBox tile in grid) {
                this.Controls.Add(tile);
            }
        }

        private void ClearGrid() {
            if (grid == null) {
                grid = new List<PictureBox>();
                return;
            }

            foreach (PictureBox tile in grid) {
                this.Controls.Remove(tile);
            }

            grid = new List<PictureBox>();
        }

        #endregion

        #region Helper Functions
        private Image GetImageFromTileType(TileTypes type) {
            switch (type) {
                case TileTypes.SOIL:
                    return imgSoil.Image;
                case TileTypes.GRASS:
                    return imgGrass.Image;
                case TileTypes.SAND:
                    return imgSand.Image;
                case TileTypes.WATER:
                    return imgWater.Image;
                default:
                    return imgVoid.Image;
            }
        }
        #endregion

        #region Buttons
        private void btnSave_Click(object sender, EventArgs e) {
            map.Save();
        }

        private void btnPencil_Click(object sender, EventArgs e) {
            drawType = DrawTypes.PENCIL;
        }

        private void btnBucket_Click(object sender, EventArgs e) {
            drawType = DrawTypes.BUCKET;
        }

        private void imgVoid_Click(object sender, EventArgs e) {
            tileType = TileTypes.VOID;
        }

        private void imgSoil_Click(object sender, EventArgs e) {
            tileType = TileTypes.SOIL;
        }

        private void imgGrass_Click(object sender, EventArgs e) {
            tileType = TileTypes.GRASS;
        }

        private void imgSand_Click(object sender, EventArgs e) {
            tileType = TileTypes.SAND;
        }

        private void imgWater_Click(object sender, EventArgs e) {
            tileType = TileTypes.WATER;
        }

        private void btnCopyUp_Click(object sender, EventArgs e) {
            map.CopyLayer(currentLayer + 1, currentLayer);
            CreateGrid(map, currentLayer);
        }

        private void btnCopyDown_Click(object sender, EventArgs e) {
            map.CopyLayer(currentLayer - 1, currentLayer);
            CreateGrid(map, currentLayer);
        }

        private void btnUp_Click(object sender, EventArgs e) {
            if (currentLayer >= map.depth - 1) {
                return;
            }

            currentLayer++;
            lblLayer.Text = currentLayer.ToString();
            CreateGrid(map, currentLayer);
        }

        private void btnDown_Click(object sender, EventArgs e) {
            if (currentLayer <= 0) {
                return;
            }

            currentLayer--;
            lblLayer.Text = currentLayer.ToString();
            CreateGrid(map, currentLayer);
        }

        private void btnSaveDimensions_Click(object sender, EventArgs e) {
            map.Resize(Convert.ToInt32(txtWidth.Text), Convert.ToInt32(txtHeight.Text), Convert.ToInt32(txtLayers.Text));
            CreateGrid(map, currentLayer);
        }

        #endregion
    }
}

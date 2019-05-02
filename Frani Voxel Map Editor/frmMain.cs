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
        private Image drawImage;

        public frmMain(Map loadedMap = null) {
            InitializeComponent();

            map = loadedMap != null ? loadedMap : new Map(20, 20, 6);

            drawType = DrawTypes.PENCIL;
            drawImage = imgVoid.Image;

            CreateGrid(map, currentLayer);
        }

        private void tile_Click(object sender, EventArgs e) {
            PictureBox tile = (PictureBox)sender;

            if (drawType == DrawTypes.PENCIL) {
                tile.Image = drawImage;
            }
        }

        private void CreateGrid(Map map, int currentLayer) {
            grid = new List<PictureBox>();

            for (int y = 0; y < map.height; y++) {
                for (int x = 0; x < map.width; x++) {
                    int localIndex = x + y * map.width; //index in 2D space, just x & y coordinates
                    int globalIndex = x + y * map.width + currentLayer * map.width * map.height; //index in 3D space, x & y & z coordinates

                    PictureBox tile = new PictureBox();
                    tile.Name = "tile" + localIndex.ToString();
                    tile.Location = new Point(32 * x, 32 * y);
                    tile.Size = new Size(32, 32);
                    tile.Click += new EventHandler(tile_Click);

                    switch (map.tiles[globalIndex].type) {
                        case TileTypes.SOIL:
                            tile.Image = imgSoil.Image;
                            break;
                        case TileTypes.GRASS:
                            tile.Image = imgGrass.Image;
                            break;
                        case TileTypes.SAND:
                            tile.Image = imgSand.Image;
                            break;
                        case TileTypes.WATER:
                            tile.Image = imgWater.Image;
                            break;
                        default:
                            tile.Image = imgVoid.Image;
                            break;
                    }

                    grid.Add(tile);
                }
            }

            foreach (PictureBox tile in grid) {
                this.Controls.Add(tile);
            }
        }

        private void RefreshGrid(Map map, int currentLayer) {
            foreach (PictureBox tile in grid) {
                this.Controls.Remove(tile);
            }

            CreateGrid(map, currentLayer);
        }

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

        private void btnCopyUp_Click(object sender, EventArgs e) {

        }

        private void btnCopyDown_Click(object sender, EventArgs e) {

        }

        private void imgVoid_Click(object sender, EventArgs e) {
            drawImage = imgVoid.Image;
        }

        private void imgSoil_Click(object sender, EventArgs e) {
            drawImage = imgSoil.Image;
        }

        private void imgGrass_Click(object sender, EventArgs e) {
            drawImage = imgGrass.Image;
        }

        private void imgSand_Click(object sender, EventArgs e) {
            drawImage = imgSand.Image;
        }

        private void imgWater_Click(object sender, EventArgs e) {
            drawImage = imgWater.Image;
        }

        private void btnUp_Click(object sender, EventArgs e) {
            if (currentLayer >= map.depth - 1) {
                return;
            }

            currentLayer++;
            lblLayer.Text = currentLayer.ToString();
            RefreshGrid(map, currentLayer);
        }

        private void btnDown_Click(object sender, EventArgs e) {
            if (currentLayer <= 0) {
                return;
            }

            currentLayer--;
            lblLayer.Text = currentLayer.ToString();
            RefreshGrid(map, currentLayer);
        }

        private void btnSaveDimensions_Click(object sender, EventArgs e) {
            map.Resize(Convert.ToInt32(txtWidth.Text), Convert.ToInt32(txtHeight.Text), Convert.ToInt32(txtLayers.Text));
            RefreshGrid(map, currentLayer);
        }

        #endregion
    }
}

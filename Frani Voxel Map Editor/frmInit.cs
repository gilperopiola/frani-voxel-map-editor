using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace Frani_Voxel_Map_Editor {
    public partial class frmInit : Form {
        public frmInit() {
            InitializeComponent();
        }

        private void btnNewMap_Click(object sender, EventArgs e) {
            frmMain main = new frmMain();
            main.ShowDialog();
        }

        private void btnOpenMap_Click(object sender, EventArgs e) {
            string json = FileHandler.Read("vmap.json");
            if (json == "") {
                btnNewMap.PerformClick();
                return;
            }

            frmMain main = new frmMain(JsonConvert.DeserializeObject<Map>(json));
            main.ShowDialog();
        }
    }
}

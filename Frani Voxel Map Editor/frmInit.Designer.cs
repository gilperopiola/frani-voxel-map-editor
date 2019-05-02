namespace Frani_Voxel_Map_Editor {
    partial class frmInit {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnNewMap = new System.Windows.Forms.Button();
            this.btnOpenMap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewMap
            // 
            this.btnNewMap.Location = new System.Drawing.Point(12, 12);
            this.btnNewMap.Name = "btnNewMap";
            this.btnNewMap.Size = new System.Drawing.Size(137, 47);
            this.btnNewMap.TabIndex = 0;
            this.btnNewMap.Text = "New Map";
            this.btnNewMap.UseVisualStyleBackColor = true;
            this.btnNewMap.Click += new System.EventHandler(this.btnNewMap_Click);
            // 
            // btnOpenMap
            // 
            this.btnOpenMap.Location = new System.Drawing.Point(165, 12);
            this.btnOpenMap.Name = "btnOpenMap";
            this.btnOpenMap.Size = new System.Drawing.Size(137, 47);
            this.btnOpenMap.TabIndex = 1;
            this.btnOpenMap.Text = "Open Map";
            this.btnOpenMap.UseVisualStyleBackColor = true;
            this.btnOpenMap.Click += new System.EventHandler(this.btnOpenMap_Click);
            // 
            // frmInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 72);
            this.Controls.Add(this.btnOpenMap);
            this.Controls.Add(this.btnNewMap);
            this.Name = "frmInit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frani Voxel Map Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewMap;
        private System.Windows.Forms.Button btnOpenMap;
    }
}


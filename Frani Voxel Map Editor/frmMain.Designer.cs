namespace Frani_Voxel_Map_Editor {
    partial class frmMain {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.sidebar = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCopyDown = new System.Windows.Forms.Button();
            this.btnCopyUp = new System.Windows.Forms.Button();
            this.btnBucket = new System.Windows.Forms.Button();
            this.btnPencil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imgWater = new System.Windows.Forms.PictureBox();
            this.imgSand = new System.Windows.Forms.PictureBox();
            this.imgGrass = new System.Windows.Forms.PictureBox();
            this.imgSoil = new System.Windows.Forms.PictureBox();
            this.imgVoid = new System.Windows.Forms.PictureBox();
            this.lblLayer = new System.Windows.Forms.Label();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnSaveDimensions = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLayers = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.sidebar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGrass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSoil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVoid)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.Controls.Add(this.btnSave);
            this.sidebar.Controls.Add(this.btnCopyDown);
            this.sidebar.Controls.Add(this.btnCopyUp);
            this.sidebar.Controls.Add(this.btnBucket);
            this.sidebar.Controls.Add(this.btnPencil);
            this.sidebar.Controls.Add(this.groupBox1);
            this.sidebar.Controls.Add(this.lblLayer);
            this.sidebar.Controls.Add(this.btnDown);
            this.sidebar.Controls.Add(this.btnUp);
            this.sidebar.Controls.Add(this.btnSaveDimensions);
            this.sidebar.Controls.Add(this.label2);
            this.sidebar.Controls.Add(this.label1);
            this.sidebar.Controls.Add(this.txtLayers);
            this.sidebar.Controls.Add(this.txtHeight);
            this.sidebar.Controls.Add(this.txtWidth);
            this.sidebar.Location = new System.Drawing.Point(1174, 9);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(240, 775);
            this.sidebar.TabIndex = 0;
            this.sidebar.TabStop = false;
            this.sidebar.Text = "Actions";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 737);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(220, 30);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCopyDown
            // 
            this.btnCopyDown.Location = new System.Drawing.Point(180, 545);
            this.btnCopyDown.Name = "btnCopyDown";
            this.btnCopyDown.Size = new System.Drawing.Size(51, 49);
            this.btnCopyDown.TabIndex = 13;
            this.btnCopyDown.Text = "Copy ▼";
            this.btnCopyDown.UseVisualStyleBackColor = true;
            this.btnCopyDown.Click += new System.EventHandler(this.btnCopyDown_Click);
            // 
            // btnCopyUp
            // 
            this.btnCopyUp.Location = new System.Drawing.Point(123, 545);
            this.btnCopyUp.Name = "btnCopyUp";
            this.btnCopyUp.Size = new System.Drawing.Size(51, 49);
            this.btnCopyUp.TabIndex = 12;
            this.btnCopyUp.Text = "Copy ▲";
            this.btnCopyUp.UseVisualStyleBackColor = true;
            this.btnCopyUp.Click += new System.EventHandler(this.btnCopyUp_Click);
            // 
            // btnBucket
            // 
            this.btnBucket.Location = new System.Drawing.Point(66, 545);
            this.btnBucket.Name = "btnBucket";
            this.btnBucket.Size = new System.Drawing.Size(51, 49);
            this.btnBucket.TabIndex = 11;
            this.btnBucket.Text = "Bucket";
            this.btnBucket.UseVisualStyleBackColor = true;
            this.btnBucket.Click += new System.EventHandler(this.btnBucket_Click);
            // 
            // btnPencil
            // 
            this.btnPencil.Location = new System.Drawing.Point(8, 545);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(51, 49);
            this.btnPencil.TabIndex = 10;
            this.btnPencil.Text = "Pencil";
            this.btnPencil.UseVisualStyleBackColor = true;
            this.btnPencil.Click += new System.EventHandler(this.btnPencil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imgWater);
            this.groupBox1.Controls.Add(this.imgSand);
            this.groupBox1.Controls.Add(this.imgGrass);
            this.groupBox1.Controls.Add(this.imgSoil);
            this.groupBox1.Controls.Add(this.imgVoid);
            this.groupBox1.Location = new System.Drawing.Point(9, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 258);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voxel Types";
            // 
            // imgWater
            // 
            this.imgWater.Image = ((System.Drawing.Image)(resources.GetObject("imgWater.Image")));
            this.imgWater.Location = new System.Drawing.Point(171, 26);
            this.imgWater.Name = "imgWater";
            this.imgWater.Size = new System.Drawing.Size(32, 32);
            this.imgWater.TabIndex = 4;
            this.imgWater.TabStop = false;
            this.imgWater.Click += new System.EventHandler(this.imgWater_Click);
            // 
            // imgSand
            // 
            this.imgSand.Image = ((System.Drawing.Image)(resources.GetObject("imgSand.Image")));
            this.imgSand.Location = new System.Drawing.Point(133, 26);
            this.imgSand.Name = "imgSand";
            this.imgSand.Size = new System.Drawing.Size(32, 32);
            this.imgSand.TabIndex = 3;
            this.imgSand.TabStop = false;
            this.imgSand.Click += new System.EventHandler(this.imgSand_Click);
            // 
            // imgGrass
            // 
            this.imgGrass.Image = ((System.Drawing.Image)(resources.GetObject("imgGrass.Image")));
            this.imgGrass.Location = new System.Drawing.Point(95, 26);
            this.imgGrass.Name = "imgGrass";
            this.imgGrass.Size = new System.Drawing.Size(32, 32);
            this.imgGrass.TabIndex = 2;
            this.imgGrass.TabStop = false;
            this.imgGrass.Click += new System.EventHandler(this.imgGrass_Click);
            // 
            // imgSoil
            // 
            this.imgSoil.Image = ((System.Drawing.Image)(resources.GetObject("imgSoil.Image")));
            this.imgSoil.Location = new System.Drawing.Point(57, 26);
            this.imgSoil.Name = "imgSoil";
            this.imgSoil.Size = new System.Drawing.Size(32, 32);
            this.imgSoil.TabIndex = 1;
            this.imgSoil.TabStop = false;
            this.imgSoil.Click += new System.EventHandler(this.imgSoil_Click);
            // 
            // imgVoid
            // 
            this.imgVoid.Image = ((System.Drawing.Image)(resources.GetObject("imgVoid.Image")));
            this.imgVoid.Location = new System.Drawing.Point(19, 26);
            this.imgVoid.Name = "imgVoid";
            this.imgVoid.Size = new System.Drawing.Size(32, 32);
            this.imgVoid.TabIndex = 0;
            this.imgVoid.TabStop = false;
            this.imgVoid.Click += new System.EventHandler(this.imgVoid_Click);
            // 
            // lblLayer
            // 
            this.lblLayer.AutoSize = true;
            this.lblLayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLayer.Location = new System.Drawing.Point(103, 169);
            this.lblLayer.Name = "lblLayer";
            this.lblLayer.Size = new System.Drawing.Size(52, 55);
            this.lblLayer.TabIndex = 8;
            this.lblLayer.Text = "0";
            this.lblLayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(75, 230);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(104, 36);
            this.btnDown.TabIndex = 7;
            this.btnDown.Text = "▼";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(75, 126);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(104, 36);
            this.btnUp.TabIndex = 6;
            this.btnUp.Text = "▲";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnSaveDimensions
            // 
            this.btnSaveDimensions.Location = new System.Drawing.Point(10, 47);
            this.btnSaveDimensions.Name = "btnSaveDimensions";
            this.btnSaveDimensions.Size = new System.Drawing.Size(220, 30);
            this.btnSaveDimensions.TabIndex = 5;
            this.btnSaveDimensions.Text = "Save Dimensions";
            this.btnSaveDimensions.UseVisualStyleBackColor = true;
            this.btnSaveDimensions.Click += new System.EventHandler(this.btnSaveDimensions_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "x";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "x";
            // 
            // txtLayers
            // 
            this.txtLayers.Location = new System.Drawing.Point(179, 19);
            this.txtLayers.Name = "txtLayers";
            this.txtLayers.Size = new System.Drawing.Size(52, 20);
            this.txtLayers.TabIndex = 2;
            this.txtLayers.Text = "6";
            this.txtLayers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(90, 19);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(55, 20);
            this.txtHeight.TabIndex = 1;
            this.txtHeight.Text = "20";
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(9, 19);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(52, 20);
            this.txtWidth.TabIndex = 0;
            this.txtWidth.Text = "20";
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 788);
            this.Controls.Add(this.sidebar);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGrass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSoil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVoid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sidebar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCopyDown;
        private System.Windows.Forms.Button btnCopyUp;
        private System.Windows.Forms.Button btnBucket;
        private System.Windows.Forms.Button btnPencil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox imgWater;
        private System.Windows.Forms.PictureBox imgSand;
        private System.Windows.Forms.PictureBox imgGrass;
        private System.Windows.Forms.PictureBox imgSoil;
        private System.Windows.Forms.PictureBox imgVoid;
        private System.Windows.Forms.Label lblLayer;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnSaveDimensions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLayers;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
    }
}
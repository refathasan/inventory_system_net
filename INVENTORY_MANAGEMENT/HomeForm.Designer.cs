namespace INVENTORY_MANAGEMENT
{
    partial class home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.allProductNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentStockGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentStockGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "SONGSARI INVENTORY SYSTEM";
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.White;
            this.btnAddStock.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStock.Image")));
            this.btnAddStock.Location = new System.Drawing.Point(172, 340);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(100, 94);
            this.btnAddStock.TabIndex = 3;
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.White;
            this.btnSell.Image = ((System.Drawing.Image)(resources.GetObject("btnSell.Image")));
            this.btnSell.Location = new System.Drawing.Point(315, 340);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(100, 94);
            this.btnSell.TabIndex = 4;
            this.btnSell.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(463, 340);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 94);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(661, 344);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 94);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.White;
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.Location = new System.Drawing.Point(27, 340);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(100, 94);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(661, 27);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(100, 100);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(25, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.stockToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allProductNameToolStripMenuItem,
            this.currentStockToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
            this.toolStripMenuItem1.Text = "Inventory";
            // 
            // allProductNameToolStripMenuItem
            // 
            this.allProductNameToolStripMenuItem.Name = "allProductNameToolStripMenuItem";
            this.allProductNameToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.allProductNameToolStripMenuItem.Text = "All Product Name";
            // 
            // currentStockToolStripMenuItem
            // 
            this.currentStockToolStripMenuItem.Name = "currentStockToolStripMenuItem";
            this.currentStockToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.currentStockToolStripMenuItem.Text = "Current Stock";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // currentStockGridView
            // 
            this.currentStockGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentStockGridView.Location = new System.Drawing.Point(27, 105);
            this.currentStockGridView.Name = "currentStockGridView";
            this.currentStockGridView.Size = new System.Drawing.Size(734, 219);
            this.currentStockGridView.TabIndex = 8;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.currentStockGridView);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "home";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentStockGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem allProductNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.DataGridView currentStockGridView;
    }
}


namespace hayaaFinal
{
    partial class getborrowing
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.borrowGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.borrowGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // borrowGrid
            // 
            this.borrowGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borrowGrid.Location = new System.Drawing.Point(0, 0);
            this.borrowGrid.MainView = this.gridView1;
            this.borrowGrid.Name = "borrowGrid";
            this.borrowGrid.Size = new System.Drawing.Size(849, 445);
            this.borrowGrid.TabIndex = 0;
            this.borrowGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.borrowGrid;
            this.gridView1.Name = "gridView1";
            // 
            // getborrowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.borrowGrid);
            this.Name = "getborrowing";
            this.Size = new System.Drawing.Size(849, 445);
            this.Load += new System.EventHandler(this.getborrowing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.borrowGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl borrowGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}

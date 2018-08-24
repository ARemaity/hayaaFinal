namespace hayaaFinal
{
    partial class transUser
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
            this.officeNavigationBar1 = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.it1 = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.it2 = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.Item3 = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // officeNavigationBar1
            // 
            this.officeNavigationBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.officeNavigationBar1.Items.AddRange(new DevExpress.XtraBars.Navigation.NavigationBarItem[] {
            this.it1,
            this.it2,
            this.Item3});
            this.officeNavigationBar1.Location = new System.Drawing.Point(0, 291);
            this.officeNavigationBar1.Name = "officeNavigationBar1";
            this.officeNavigationBar1.Size = new System.Drawing.Size(912, 44);
            this.officeNavigationBar1.TabIndex = 0;
            this.officeNavigationBar1.Text = "officeNavigationBar1";
            this.officeNavigationBar1.Click += new System.EventHandler(this.officeNavigationBar1_Click);
            // 
            // it1
            // 
            this.it1.Name = "it1";
            this.it1.Text = "جديد";
            // 
            // it2
            // 
            this.it2.Name = "it2";
            this.it2.Text = "تعديل";
            // 
            // Item3
            // 
            this.Item3.Name = "Item3";
            this.Item3.Text = "مشاهدة";
            // 
            // transUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 335);
            this.Controls.Add(this.officeNavigationBar1);
            this.Name = "transUser";
            this.Text = "transUser";
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.OfficeNavigationBar officeNavigationBar1;
        private DevExpress.XtraBars.Navigation.NavigationBarItem it1;
        private DevExpress.XtraBars.Navigation.NavigationBarItem it2;
        private DevExpress.XtraBars.Navigation.NavigationBarItem Item3;
    }
}
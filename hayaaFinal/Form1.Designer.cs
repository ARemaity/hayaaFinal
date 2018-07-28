namespace hayaaFinal
{
    partial class Form1
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::hayaaFinal.SplashScreen1), true, true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.exit = new DevExpress.XtraEditors.SimpleButton();
            this.minimize = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.xtraUserControl1 = new DevExpress.XtraEditors.XtraUserControl();
            this.editFormUserControl1 = new DevExpress.XtraGrid.Views.Grid.EditFormUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // accordionControl1
            // 
            this.editFormUserControl1.SetBoundPropertyName(this.accordionControl1, "");
            resources.ApplyResources(this.accordionControl1, "accordionControl1");
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1});
            this.accordionControl1.Name = "accordionControl1";
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Name = "accordionControlElement1";
            resources.ApplyResources(this.accordionControlElement1, "accordionControlElement1");
            // 
            // exit
            // 
            this.editFormUserControl1.SetBoundPropertyName(this.exit, "");
            this.exit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("exit.ImageOptions.Image")));
            resources.ApplyResources(this.exit, "exit");
            this.exit.Name = "exit";
            this.exit.Click += new System.EventHandler(this.simpleButton1_Click);
            this.exit.StyleChanged += new System.EventHandler(this.exit_StyleChanged);
            // 
            // minimize
            // 
            this.editFormUserControl1.SetBoundPropertyName(this.minimize, "");
            this.minimize.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.minimize.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("minimize.ImageOptions.Image")));
            resources.ApplyResources(this.minimize, "minimize");
            this.minimize.Name = "minimize";
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // sidePanel2
            // 
            this.sidePanel2.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("sidePanel2.Appearance.BackColor")));
            this.sidePanel2.Appearance.Options.UseBackColor = true;
            this.editFormUserControl1.SetBoundPropertyName(this.sidePanel2, "");
            this.sidePanel2.Controls.Add(this.pictureBox1);
            this.sidePanel2.Controls.Add(this.minimize);
            this.sidePanel2.Controls.Add(this.exit);
            resources.ApplyResources(this.sidePanel2, "sidePanel2");
            this.sidePanel2.Name = "sidePanel2";
            // 
            // pictureBox1
            // 
            this.editFormUserControl1.SetBoundPropertyName(this.pictureBox1, "");
            this.pictureBox1.Image = global::hayaaFinal.Properties.Resources.header;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("sidePanel1.Appearance.BackColor")));
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.editFormUserControl1.SetBoundPropertyName(this.sidePanel1, "");
            resources.ApplyResources(this.sidePanel1, "sidePanel1");
            this.sidePanel1.Name = "sidePanel1";
            // 
            // xtraUserControl1
            // 
            this.editFormUserControl1.SetBoundPropertyName(this.xtraUserControl1, "");
            resources.ApplyResources(this.xtraUserControl1, "xtraUserControl1");
            this.xtraUserControl1.Name = "xtraUserControl1";
            // 
            // editFormUserControl1
            // 
            resources.ApplyResources(this.editFormUserControl1, "editFormUserControl1");
            this.editFormUserControl1.Name = "editFormUserControl1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editFormUserControl1.SetBoundPropertyName(this, "");
            this.Controls.Add(this.editFormUserControl1);
            this.Controls.Add(this.xtraUserControl1);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.sidePanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.sidePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraEditors.SimpleButton minimize;
        private DevExpress.XtraEditors.SimpleButton exit;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraGrid.Views.Grid.EditFormUserControl editFormUserControl1;
        private DevExpress.XtraEditors.XtraUserControl xtraUserControl1;
    }
}


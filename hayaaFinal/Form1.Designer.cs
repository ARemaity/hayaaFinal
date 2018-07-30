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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::hayaaFinal.SplashScreen1), true, false, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.Utils.Controls.SnapOptions snapOptions1 = new DevExpress.Utils.Controls.SnapOptions();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.الادوات = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem1 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem2 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.ا = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem7 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.exit = new DevExpress.XtraEditors.SimpleButton();
            this.minimize = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tool1 = new DevExpress.XtraGrid.Views.Grid.EditFormUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.sidePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.tool1.SetBoundPropertyName(this.accordionControl1, "");
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
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tool1.SetBoundPropertyName(this.pictureBox1, "");
            this.pictureBox1.Image = global::hayaaFinal.Properties.Resources.header;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.الادوات;
            this.tool1.SetBoundPropertyName(this.navBarControl1, "");
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.الادوات,
            this.navBarGroup2,
            this.ا,
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1,
            this.navBarItem4,
            this.navBarItem5,
            this.navBarItem2,
            this.navBarSeparatorItem1,
            this.navBarSeparatorItem2,
            this.navBarItem7,
            this.navBarItem3});
            resources.ApplyResources(this.navBarControl1, "navBarControl1");
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = ((int)(resources.GetObject("resource.ExpandedWidth")));
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("Office 2013");
            this.navBarControl1.Click += new System.EventHandler(this.navBarControl1_Click);
            // 
            // الادوات
            // 
            resources.ApplyResources(this.الادوات, "الادوات");
            this.الادوات.Expanded = true;
            this.الادوات.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.الادوات.ImageOptions.SmallImage = global::hayaaFinal.Properties.Resources.ide_32x322;
            this.الادوات.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem1)});
            this.الادوات.Name = "الادوات";
            // 
            // navBarItem1
            // 
            resources.ApplyResources(this.navBarItem1, "navBarItem1");
            this.navBarItem1.ImageOptions.SmallImage = global::hayaaFinal.Properties.Resources.add_32x32;
            this.navBarItem1.Name = "navBarItem1";
            // 
            // navBarItem5
            // 
            resources.ApplyResources(this.navBarItem5, "navBarItem5");
            this.navBarItem5.ImageOptions.SmallImage = global::hayaaFinal.Properties.Resources.stackedbar_32x32;
            this.navBarItem5.Name = "navBarItem5";
            // 
            // navBarSeparatorItem1
            // 
            this.navBarSeparatorItem1.CanDrag = false;
            this.navBarSeparatorItem1.Enabled = false;
            resources.ApplyResources(this.navBarSeparatorItem1, "navBarSeparatorItem1");
            this.navBarSeparatorItem1.Name = "navBarSeparatorItem1";
            // 
            // navBarGroup2
            // 
            resources.ApplyResources(this.navBarGroup2, "navBarGroup2");
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.navBarGroup2.ImageOptions.SmallImage = global::hayaaFinal.Properties.Resources.team_32x321;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem2)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItem4
            // 
            resources.ApplyResources(this.navBarItem4, "navBarItem4");
            this.navBarItem4.ImageOptions.SmallImage = global::hayaaFinal.Properties.Resources.newemployee_32x32;
            this.navBarItem4.Name = "navBarItem4";
            // 
            // navBarItem2
            // 
            resources.ApplyResources(this.navBarItem2, "navBarItem2");
            this.navBarItem2.ImageOptions.SmallImage = global::hayaaFinal.Properties.Resources.show_32x32;
            this.navBarItem2.Name = "navBarItem2";
            // 
            // navBarSeparatorItem2
            // 
            this.navBarSeparatorItem2.CanDrag = false;
            this.navBarSeparatorItem2.Enabled = false;
            resources.ApplyResources(this.navBarSeparatorItem2, "navBarSeparatorItem2");
            this.navBarSeparatorItem2.Name = "navBarSeparatorItem2";
            // 
            // ا
            // 
            resources.ApplyResources(this.ا, "ا");
            this.ا.Expanded = true;
            this.ا.ImageOptions.SmallImage = global::hayaaFinal.Properties.Resources.reset_32x32;
            this.ا.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem7),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3)});
            this.ا.Name = "ا";
            // 
            // navBarItem7
            // 
            resources.ApplyResources(this.navBarItem7, "navBarItem7");
            this.navBarItem7.ImageOptions.SmallImage = global::hayaaFinal.Properties.Resources.emptytablerowseparator_32x32;
            this.navBarItem7.Name = "navBarItem7";
            // 
            // navBarItem3
            // 
            resources.ApplyResources(this.navBarItem3, "navBarItem3");
            this.navBarItem3.ImageOptions.SmallImage = global::hayaaFinal.Properties.Resources.tableproperties_32x32;
            this.navBarItem3.Name = "navBarItem3";
            // 
            // navBarGroup1
            // 
            resources.ApplyResources(this.navBarGroup1, "navBarGroup1");
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // exit
            // 
            this.tool1.SetBoundPropertyName(this.exit, "");
            this.exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("exit.ImageOptions.Image")));
            resources.ApplyResources(this.exit, "exit");
            this.exit.Name = "exit";
            this.exit.Click += new System.EventHandler(this.simpleButton1_Click);
            this.exit.StyleChanged += new System.EventHandler(this.exit_StyleChanged);
            // 
            // minimize
            // 
            this.tool1.SetBoundPropertyName(this.minimize, "");
            this.minimize.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("minimize.ImageOptions.Image")));
            resources.ApplyResources(this.minimize, "minimize");
            this.minimize.Name = "minimize";
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // sidePanel2
            // 
            this.sidePanel2.AllowSnap = false;
            this.sidePanel2.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("sidePanel2.Appearance.BackColor")));
            this.sidePanel2.Appearance.Options.UseBackColor = true;
            this.tool1.SetBoundPropertyName(this.sidePanel2, "");
            this.sidePanel2.Controls.Add(this.simpleButton1);
            this.sidePanel2.Controls.Add(this.minimize);
            this.sidePanel2.Controls.Add(this.exit);
            resources.ApplyResources(this.sidePanel2, "sidePanel2");
            this.sidePanel2.Name = "sidePanel2";
            // 
            // simpleButton1
            // 
            this.tool1.SetBoundPropertyName(this.simpleButton1, "");
            this.simpleButton1.ImageOptions.Image = global::hayaaFinal.Properties.Resources.info_32x323;
            resources.ApplyResources(this.simpleButton1, "simpleButton1");
            this.simpleButton1.Name = "simpleButton1";
            // 
            // tool1
            // 
            resources.ApplyResources(this.tool1, "tool1");
            this.tool1.Name = "tool1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            snapOptions1.SnapOnMoving = DevExpress.Utils.DefaultBoolean.True;
            this.behaviorManager1.SetBehaviors(this, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.SnapWindowBehavior.Create(typeof(DevExpress.Utils.BehaviorSource.SnapWindowBehaviorSourceForForm), snapOptions1)))});
            this.tool1.SetBoundPropertyName(this, "");
            this.Controls.Add(this.tool1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.sidePanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.sidePanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup الادوات;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarGroup ا;
        private DevExpress.XtraEditors.SimpleButton exit;
        private DevExpress.XtraEditors.SimpleButton minimize;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem1;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem7;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraGrid.Views.Grid.EditFormUserControl tool1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}


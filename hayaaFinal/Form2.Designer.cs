namespace hayaaFinal
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            DevExpress.Utils.Controls.SnapOptions snapOptions1 = new DevExpress.Utils.Controls.SnapOptions();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar2 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.patient1 = new hayaaFinal.patient();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            resources.ApplyResources(this.ribbonPage2, "ribbonPage2");
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.patient1);
            this.panel1.Name = "panel1";
            // 
            // ribbonStatusBar1
            // 
            resources.ApplyResources(this.ribbonStatusBar1, "ribbonStatusBar1");
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = null;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            resources.ApplyResources(this.ribbonControl1, "ribbonControl1");
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.StatusBar = this.ribbonStatusBar2;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            resources.ApplyResources(this.ribbonPage1, "ribbonPage1");
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            resources.ApplyResources(this.ribbonPageGroup1, "ribbonPageGroup1");
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            resources.ApplyResources(this.ribbonPageGroup2, "ribbonPageGroup2");
            // 
            // ribbonStatusBar2
            // 
            resources.ApplyResources(this.ribbonStatusBar2, "ribbonStatusBar2");
            this.ribbonStatusBar2.Name = "ribbonStatusBar2";
            this.ribbonStatusBar2.Ribbon = this.ribbonControl1;
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            resources.ApplyResources(this.ribbonPage3, "ribbonPage3");
            // 
            // patient1
            // 
            resources.ApplyResources(this.patient1, "patient1");
            this.patient1.Name = "patient1";
            // 
            // Form2
            // 
            this.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("Form2.Appearance.BackColor")));
            this.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            snapOptions1.SnapOnResizing = DevExpress.Utils.DefaultBoolean.True;
            this.behaviorManager1.SetBehaviors(this, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.SnapWindowBehavior.Create(typeof(DevExpress.Utils.BehaviorSource.SnapWindowBehaviorSourceForForm), snapOptions1))),
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.PersistenceBehavior.Create(typeof(DevExpress.Utils.BehaviorSource.PersistenceBehaviorSourceForForm), null, DevExpress.Utils.Behaviors.Common.Storage.File, DevExpress.Utils.DefaultBoolean.True)))});
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonStatusBar2);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Name = "Form2";
            this.Ribbon = this.ribbonControl1;
            this.ShowIcon = false;
            this.StatusBar = this.ribbonStatusBar1;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private patient patient1;
    }
}
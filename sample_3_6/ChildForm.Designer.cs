namespace sample_3_6 {
  partial class ChildForm {
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
      this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
      this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
      this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
      this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 158);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(507, 221);
      this.panel1.TabIndex = 0;
      // 
      // barButtonItem2
      // 
      this.barButtonItem2.Caption = "Child Form Toolbar Button";
      this.barButtonItem2.Id = 2;
      this.barButtonItem2.Name = "barButtonItem2";
      // 
      // barSubItem1
      // 
      this.barSubItem1.Caption = "&View";
      this.barSubItem1.Id = 0;
      this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
      this.barSubItem1.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
      this.barSubItem1.Name = "barSubItem1";
      // 
      // barButtonItem1
      // 
      this.barButtonItem1.Caption = "Child Form View Menu Item";
      this.barButtonItem1.Id = 1;
      this.barButtonItem1.MergeOrder = 50;
      this.barButtonItem1.Name = "barButtonItem1";
      // 
      // ribbonControl1
      // 
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barSubItem1,
            this.barButtonItem1,
            this.barButtonItem2});
      this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
      this.ribbonControl1.MaxItemId = 1;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
      this.ribbonControl1.Size = new System.Drawing.Size(507, 158);
      // 
      // ribbonPage1
      // 
      this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "MainMenu";
      // 
      // ribbonPageGroup1
      // 
      this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup1.Text = "View";
      // 
      // ribbonPageGroup2
      // 
      this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup2.Text = "Tools";
      // 
      // ChildForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(507, 379);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.ribbonControl1);
      this.Name = "ChildForm";
      this.Ribbon = this.ribbonControl1;
      this.Text = "ChildForm";
      ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    private DevExpress.XtraBars.BarSubItem barSubItem1;
    private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
  }
}
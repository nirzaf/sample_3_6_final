using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sample_3_6 {
  public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm {
    public Form1() {
      InitializeComponent();
      // Handling the QueryControl event that will populate all automatically generated Documents
      this.tabbedView1.QueryControl += tabbedView1_QueryControl;
    }

    private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
      var child = new ChildForm();
      var doc = tabbedView1.AddDocument(child);
      doc.Caption = $"Child Form number {tabbedView1.Documents.Count}";
      doc.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.False;
    }

    private void barManager1_Merge(object sender, DevExpress.XtraBars.BarManagerMergeEventArgs e) {
      /*      if (e.ChildManager != null) {
              var mainFormChildBar = barManager1.Bars["Child Bar"];
              var childBar = e.ChildManager.Bars["Tools"];
              mainFormChildBar.Merge(childBar);
              childBar.Visible = false;
              mainFormChildBar.Visible = true;
            }*/
    }

    private void barManager1_UnMerge(object sender, DevExpress.XtraBars.BarManagerMergeEventArgs e) {
      /*      var mainFormChildBar = barManager1.Bars["Child Bar"];
            mainFormChildBar.UnMerge();
            mainFormChildBar.Visible = false;*/
    }

    private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
      var child = new SecondMDIChild();
      child.MdiParent = this;
      child.Show();
    }

    // Assigning a required content for each auto generated Document
    void tabbedView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e) {

      if (e.Document == childFormDocument)
        e.Control = new sample_3_6.ChildForm();
      if (e.Document == secondMDIChildDocument)
        e.Control = new sample_3_6.SecondMDIChild();
      if (e.Control == null)
        e.Control = new System.Windows.Forms.Control();
    }
  }
}

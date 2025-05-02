using System;
using System.Drawing;
using DevExpress.XtraReports.UI;

namespace ParameterEditorAspNetCoreExample.PredefinedReports {
    public partial class TestReport : DevExpress.XtraReports.UI.XtraReport {
        public TestReport() {
            InitializeComponent();
        }

        private void tableCell4_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e) {
            (sender as XRTableCell).Text += " Customized";
        }
    }
}

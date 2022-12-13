using System;
using System.Drawing;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;

namespace ParameterEditorAspNetCoreExample.PredefinedReports
{
    public partial class TestReport
    {
        public TestReport()
        {
            InitializeComponent();
        }

        private void tableCell4_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e)
        {
            (sender as XRTableCell).Text += " Customized";
        }
    }
}

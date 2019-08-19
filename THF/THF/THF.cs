using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Worksheet = Microsoft.Office.Interop.Excel.Worksheet;

namespace THF
{
    public partial class THF
    {
        private void THF_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnSelectEvent_Click(object sender, RibbonControlEventArgs e)
        {
            SelectEvent se = new SelectEvent();
            se.ShowDialog();
        }

        private void btnManageEvent_Click(object sender, RibbonControlEventArgs e)
        {
            ManageEvent ma = new ManageEvent();
            ma.ShowDialog();
        }
    }
}

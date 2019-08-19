using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using Microsoft.Office.Interop.Excel;
using Worksheet = Microsoft.Office.Interop.Excel.Worksheet;

namespace THF
{
    public partial class SelectEvent : Form
    {
        public SelectEvent()
        {
            InitializeComponent();
        }

        private void SelectEvent_Load(object sender, EventArgs e)
        {

        }

    private void btnValidate_Click(object sender, EventArgs e)
        {
            /* Worksheet wsCurrent = Globals.ThisAddIn.Application.ActiveWorkbook.ActiveSheet;

            wsCurrent.Range["BQ1"].Value = "OK";*/
        }
    }
}

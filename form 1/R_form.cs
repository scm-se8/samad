using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_1
{
    public partial class R_form : Form
    {
        public R_form()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            rep rp = new rep();
            crystalReportViewer1.ReportSource = rp;
            rp.Refresh();
        }
    }
}

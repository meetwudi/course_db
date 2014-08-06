using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dbProjectGoolib
{
    public partial class Log : dbProjectGoolib.AdminBasic
    {
        public Log()
        {
            InitializeComponent();
        }

        private void Log_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataSet2.DELETELOGS”中。您可以根据需要移动或删除它。
            this.dELETELOGSTableAdapter.FillBy(this.dataSet2.DELETELOGS);
            // TODO: 这行代码将数据加载到表“dataSet2.RESETLOGS”中。您可以根据需要移动或删除它。
            this.rESETLOGSTableAdapter.FillBy(this.dataSet2.RESETLOGS);

        }
    }
}

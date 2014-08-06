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
    public partial class HandleRecommend : Form
    {
        public HandleRecommend()
        {
            InitializeComponent();
        }

        private void HandleRecommend_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataSet1.RECOMMENDATIONS”中。您可以根据需要移动或删除它。

            this.rECOMMENDATIONSTableAdapter.Fill(this.dataSet2.RECOMMENDATIONS);

        }

        private void btn_handle_Click(object sender, EventArgs e)
        {
            Recommendation reco = new Recommendation();
            for (int i = 0; i < dataGridView1.SelectedRows.Count; ++i)
            {
                if (!reco.handleReco((int)dataGridView1.SelectedRows[i].Cells[0].Value))
                {
                    MessageBox.Show("update error!");
                    this.DialogResult = DialogResult.Abort;
                    return;
                }
            }
            this.rECOMMENDATIONSTableAdapter.Fill(this.dataSet2.RECOMMENDATIONS);
            MessageBox.Show("update successful!");
            this.DialogResult = DialogResult.OK;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

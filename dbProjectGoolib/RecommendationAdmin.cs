using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dbProjectGoolib
{
    public partial class RecommendationAdmin : dbProjectGoolib.AdminBasic
    {
        public RecommendationAdmin()
        {
            InitializeComponent();
            base.RecommendationAdmin.Visible = false;
            base.pictureBox1.Visible = false;
        }

        private void RecommendationAdmin_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataSet2.RECOMMENDATIONS”中。您可以根据需要移动或删除它。
            
            this.rECOMMENDATIONSTableAdapter.FillBy(this.dataSet2.RECOMMENDATIONS);
            RecommendationList_dataGridView.Columns[0].Visible = false;
            RecommendationList_dataGridView.Columns[6].Visible = false;
        }

        private void Handle_btn_Click(object sender, EventArgs e)
        {
            //处理荐购
            Recommendation reco = new Recommendation();
            for (int i = 0; i < RecommendationList_dataGridView.SelectedRows.Count; ++i)
            {
                if (!reco.handleReco((int)RecommendationList_dataGridView.SelectedRows[i].Cells[0].Value))
                {
                    MessageBox.Show("处理失败!");
                    this.DialogResult = DialogResult.Abort;
                    return;
                }
            }
            this.rECOMMENDATIONSTableAdapter.FillBy(this.dataSet2.RECOMMENDATIONS);
            MessageBox.Show("处理成功!");
            this.DialogResult = DialogResult.OK;
        }

    }
}

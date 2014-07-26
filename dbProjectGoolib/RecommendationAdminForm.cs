using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dbProjectGoolib
{
    public partial class RecommendationAdminForm : dbProjectGoolib.AdminBasic
    {
        public RecommendationAdminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = RecommendationList_dataGridView.CurrentCell.Value.ToString();
            label1.Text = str;
        }
    }
}

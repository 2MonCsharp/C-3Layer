﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatHachB2
{
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ThiB2DataSet.view_BcKetQuanamDat' table. You can move, or remove it, as needed.
            this.view_BcKetQuanamDatTableAdapter.Fill(this.ThiB2DataSet.view_BcKetQuanamDat);
            // TODO: This line of code loads data into the 'ThiB2DataSet.ThiSinh' table. You can move, or remove it, as needed.
            this.ThiSinhTableAdapter.Fill(this.ThiB2DataSet.ThiSinh);

            this.reportViewer1.RefreshReport();
            load_dotthi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }
        private void load_dotthi()
        {
            cbb_dotthi.DataSource = BLL.Thi.DsDotthi();
            cbb_dotthi.DisplayMember = "ngaygiothi";
            cbb_dotthi.ValueMember = "MaDotThi";
        }
    }
}

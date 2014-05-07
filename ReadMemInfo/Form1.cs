
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace ReadMemInfo
{


    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }


        private void btnMemInfo_Click(object sender, EventArgs e)
        {
            // Last login: Tue May  6 12:01:03 2014 from cust.static.46-14-227-129.swisscomdata.ch
            // cat /proc/meminfo
            System.Data.DataTable dt = Linux.ProcFS.GetMemInfo();
            this.dgvData.DataSource = dt.DefaultView;

            
            this.dgvData.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }


    }


}

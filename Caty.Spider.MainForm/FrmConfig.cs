using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Caty.Spider.Utilities.Code;

namespace Caty.Spider.MainForm
{
    public partial class FrmConfig : Form
    {
        static string constring = "";
        public FrmConfig()
        {
            InitializeComponent();
        }

        private void FrmComfig_Load(object sender, EventArgs e)
        {
            string conn = ConnectionStrings.GetConnectionValue("KindleDb");
            string[] str = conn.Split(';');
            for(var i = 0; i < str.Count() - 1; i++)
            {
                str[i] = GetValue(str[i]);
            }
            txtAddress.Text = str[0];
            txtName.Text = str[1];
            txtUser.Text = str[2];
            txtPwd.Text = str[3];
            SetControlEnable(false);
        }

        private string GetValue(string str)
        {
            if (!String.IsNullOrEmpty(str))
            {
                string[] valuestr = str.Split('=');
                return valuestr[valuestr.Count() - 1];
            }
            return "";
        }

        private void SetControlEnable(bool flag)
        {
            txtAddress.Enabled = flag;
            txtName.Enabled = flag;
            txtPwd.Enabled = flag;
            txtUser.Enabled = flag;
            btnClose.Enabled = flag;
            btnSave.Enabled = flag;
        }

        private void checkModified_CheckedChanged(object sender, EventArgs e)
        {
            SetControlEnable(checkModified.Checked);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            constring = "Data Source=" + txtAddress.Text.Trim() + ";Initial Catalog =" + txtName.Text.Trim() + "; User ID=" + txtUser.Text.Trim() + "; Password=" + txtPwd.Text.Trim() + ";";
            ConnectionStrings.UpdateConnectionStringsConfig("KindleDb", constring);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

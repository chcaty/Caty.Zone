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
using Caty.Spider.Dal.Implements;
using Caty.Spider.Model;
using System.Threading;

namespace Caty.Spider.MainForm
{
    public partial class FrmConfig : Form
    {
        SpiderArgsDal ArgsDal = new SpiderArgsDal();
        static string constring = "";
        public FrmConfig()
        {
            InitializeComponent();
        }

        private void FrmComfig_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                GetSetArgs();
            });
            GetConStr();
        }

        private void GetSetArgs()
        {
            SpiderArgs args;
            bool IsSpl;
            if (Convert.ToBoolean(ConnectionStrings.GetArgsValue("IsSql")))
            {
                args = ArgsDal.LoadEntities(b => true).First();
                IsSpl = true;
            }
            else
            {
                IsSpl = false;
                args = new SpiderArgs
                {
                    Hour = ConnectionStrings.GetArgsValue("Hour"),
                    Minute = ConnectionStrings.GetArgsValue("Minute"),
                    SpiderType = Convert.ToInt32(ConnectionStrings.GetArgsValue("SpiderType"))
                };
            }                
            this.BeginInvoke(new MethodInvoker(() =>
            {
                checkIsSql.Checked = IsSpl;
                if (args.SpiderType == 1)
                {
                    rbtnDay.Checked = true;
                    numHour.Value = Convert.ToDecimal(args.Hour.Trim());
                    numMinute.Value = Convert.ToDecimal(args.Minute.Trim());
                }
                else
                {
                    rbtnHour.Checked = true;
                    numMinute2.Value = Convert.ToDecimal(args.Minute.Trim());

                }
                SetSetControlEnable(false);
            }));
        }

        private void GetConStr()
        {
            string conn = ConnectionStrings.GetConnectionValue("KindleDb");
            string[] str = conn.Split(';');
            for (var i = 0; i < str.Count() - 1; i++)
            {
                str[i] = GetValue(str[i]);
            }
            this.BeginInvoke(new MethodInvoker(() =>
            {
                txtAddress.Text = str[0];
                txtName.Text = str[1];
                txtUser.Text = str[2];
                txtPwd.Text = str[3];
                SetSqlControlEnable(false);
            }));
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

        private void SetSqlControlEnable(bool flag)
        {
            txtAddress.Enabled = flag;
            txtName.Enabled = flag;
            txtPwd.Enabled = flag;
            txtUser.Enabled = flag;
        }

        private void SetSetControlEnable(bool flag)
        {
            rbtnDay.Enabled = flag;
            rbtnHour.Enabled = flag;
            numHour.Enabled = flag;
            numMinute.Enabled = flag;
            numMinute2.Enabled = flag;
            checkIsSql.Enabled = flag;
        }

        private void btnSqlSave_Click(object sender, EventArgs e)
        {
            constring = "Data Source=" + txtAddress.Text.Trim() + ";Initial Catalog =" + txtName.Text.Trim() + "; User ID=" + txtUser.Text.Trim() + "; Password=" + txtPwd.Text.Trim() + ";";
            ConnectionStrings.UpdateConnectionStringsConfig("KindleDb", constring);
        }

        private void btnSetSave_Click(object sender,EventArgs e)
        {
            //ArgsDal.LoadEntities(null).First();
            //SpiderArgs args = ArgsDal.LoadEntities(b=>true).First();
            SpiderArgs args = new SpiderArgs();
            args.SpiderArgsId = 1;
            if (rbtnDay.Checked)
            {
                args.SpiderType = 1;
                args.Hour = numHour.Value.ToString();
                args.Minute = numMinute.Value.ToString();
            }
            else
            {
                args.SpiderType = 2;
                args.Hour = String.Empty;
                args.Minute = numMinute2.Value.ToString();
            }
            if (checkIsSql.Checked)
            {
                ArgsDal.EditEntity(args);
                ArgsDal.SaveChange();

            }
            else
            {
                ConnectionStrings.UpdateArgsValue("SpiderType", args.SpiderType.ToString());
                ConnectionStrings.UpdateArgsValue("Hour", args.Hour.ToString());
                ConnectionStrings.UpdateArgsValue("Minute", args.Minute.ToString());
            }
            ConnectionStrings.UpdateArgsValue("IsSql", checkIsSql.Checked.ToString());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkSqlModified_CheckedChanged(object sender, EventArgs e)
        {
            SetSqlControlEnable(checkSqlModified.Checked);
        }

        private void checkSetModified_CheckedChanged(object sender, EventArgs e)
        {
            SetSetControlEnable(checkSetModified.Checked);
        }
    }
}

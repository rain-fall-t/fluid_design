using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace solidworks_fluid_design_v0._1
{
    public partial class setting : Form
    {
        public Data mydata;
        public setting(Data mydata)
        {
            InitializeComponent();
            this.mydata = mydata;        }

        private void textBoxEx1_TextChanged(object sender, EventArgs e)
        {

        }

        private void skinLabel1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEx1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboxVer_Load(object sender, EventArgs e)
        {
            List<KeyValuePair<string, string>> lstCom = new List<KeyValuePair<string, string>>();
            for (int i = 0; i < 8; i++)
            {
                lstCom.Add(new KeyValuePair<string, string>(i.ToString(), (i+2014).ToString()));
            }
            comboxVer.Source = lstCom;
        }

        private void btnOk_BtnClick(object sender, EventArgs e)
        {
            if (comboxVer.TextValue != "")
            {
                mydata.ver = comboxVer.TextValue;
                mydata.ver_path = "C:\\ProgramData\\SolidWorks\\SOLIDWORKS " + mydata.ver + "\\templates\\gb_part.prtdot";
            }
            mydata.save_path = textSavePath.InputText;
            if (mydata.save_path == "")
            {
                mydata.save_path="D:\\fluid_design\\";
            }
            //创建用于保存的文件夹
            // 检查文件夹
            string folderPath = @"C:\Logs";
            if (false == System.IO.Directory.Exists(mydata.save_path))
            {
                //创建文件夹
                Directory.CreateDirectory(mydata.save_path);
            }
            Form1 form1 = new Form1(mydata);
            this.Hide();
            form1.ShowDialog();
            this.Dispose();
        }
    }
}

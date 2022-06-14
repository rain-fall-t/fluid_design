using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using CSharpAndSolidWorks;
namespace solidworks_fluid_design_v0._1
{
    public partial class Form1 : Form
    {
        public Data mydata;
        public Form1()
        {
            mydata = new Data();
            InitializeComponent();
        }
        public Form1(Data mydata=null)
        {
            InitializeComponent();
            if(mydata!=null)
            {
                this.mydata = mydata;
                testStatus.Text = "已连接";
                btnLink.BtnText = "重新连接";
            }
            else
            {
                mydata = new Data();
                ISldWorks swApp = Utility.ConnectToSolidWorks();
                if (swApp != null)
                {
                    //string msg = "This message from C#. solidworks version is " + swApp.RevisionNumber();

                    //swApp.SendMsgToUser(msg);
                    mydata.swApp = swApp;
                    testStatus.Text = "已连接";
                    btnLink.BtnText = "重新连接";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = Application.StartupPath + @"/ssk/EmeraldColor1.ssk";
        }
        
        private void btnStart_BtnClick(object sender, EventArgs e)
        {
            ISldWorks swApp = Utility.ConnectToSolidWorks();

            if (swApp != null)
            {
                //string msg = "This message from C#. solidworks version is " + swApp.RevisionNumber();

                //swApp.SendMsgToUser(msg);
                testStatus.Text = "已连接";
                btnLink.BtnText = "重新连接";
                this.mydata.swApp = swApp;
            }
        }

        private void btnDesign1_BtnClick(object sender, EventArgs e)
        {
            zhusai design1 = new zhusai(this.mydata);
            this.Hide();
            design1.ShowDialog();
            this.Dispose();
        }

        private void ucBtnExt2_BtnClick(object sender, EventArgs e)
        {
            huaxue design2 = new huaxue(this.mydata);
            this.Hide();
            design2.ShowDialog();
            this.Dispose();
        }
        private void setting_BtnClick(object sender, EventArgs e)
        {
            setting design1 = new setting(this.mydata);
            this.Hide();
            design1.ShowDialog();
            this.Dispose();
        }

        private void exit_BtnClick(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnPeiYouPan_BtnClick(object sender, EventArgs e)
        {
            peiyoupan design = new peiyoupan(this.mydata);
            this.Hide();
            design.ShowDialog();
            this.Dispose();
        }

        private void btnGangti_BtnClick(object sender, EventArgs e)
        {
            gangti design = new _1.gangti(this.mydata);
            this.Hide();
            design.ShowDialog();
            this.Dispose();
        }

        private void ucBtnExt5_BtnClick(object sender, EventArgs e)
        {
            peihe design = new peihe(this.mydata);
            this.Hide();
            design.ShowDialog();
            this.Dispose();
        }
    }
}

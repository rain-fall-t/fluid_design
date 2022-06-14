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

namespace solidworks_fluid_design_v0._1
{
    public partial class demo : Form
    {
        public Data mydata;
        public demo(Data mydata)
        {
            InitializeComponent();
            this.mydata = mydata;
            if (mydata.ver_path == null)
            {
                mydata.ver_path = "C:\\ProgramData\\SolidWorks\\SOLIDWORKS 2020\\templates\\gb_part.prtdot";
            }
            if (mydata.save_path == null)
            {
                mydata.save_path = "D:\\fluid_design\\";
            }
        }

        private void btnBegin_BtnClick(object sender, EventArgs e)
        {
            btnBegin.BtnText = "工作中";
            this.WindowState = FormWindowState.Minimized;
            mydata.swApp.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swInputDimValOnCreate, false);
            double swSheetWidth;
            swSheetWidth = 0;
            double swSheetHeight;
            bool boolstatus = false;
            int longstatus = 0;
            swSheetHeight = 0;
            ModelDoc2 swDoc = null;
            swDoc = ((ModelDoc2)(mydata.swApp.NewDocument(mydata.ver_path, 0, swSheetWidth, swSheetHeight)));
            object swPart = null;
            swPart = swDoc;
            mydata.swApp.ActivateDoc2("零件1", false, ref longstatus);
            swDoc = ((ModelDoc2)(mydata.swApp.ActiveDoc));
            // coding here

            //
            mydata.swApp.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swInputDimValOnCreate, true);
            String save_part = mydata.save_path + "_partname.SLDPRT";
            if (checkSave.Checked)
            {
                longstatus = swDoc.SaveAs3(save_part, 0, 0);
            }
            mydata.swApp.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swInputDimValOnCreate, true);
            btnBegin.BtnText = "开始";
            this.WindowState = FormWindowState.Normal;
        }

        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(mydata);
            this.Hide();
            form1.ShowDialog();
            this.Dispose();
        }
    }
}

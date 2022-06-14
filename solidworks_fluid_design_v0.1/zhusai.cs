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
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
namespace solidworks_fluid_design_v0._1
{
    public partial class zhusai : Form
    {
        public Data mydata;
        public zhusai(Data mydata)
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
        /*
        public Cliyder(Form1 form1)
        {
            this.form1 = form1;
        }*/
        private void btnBack_BtnClick(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(mydata);
            this.Hide();
            form1.ShowDialog();
            this.Dispose();
        }

        private void btnBegin_BtnClick(object sender, EventArgs e)
        {
            // New Document
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
            mydata.swApp.ActivateDoc2("零件5", false, ref longstatus);
            swDoc = ((ModelDoc2)(mydata.swApp.ActiveDoc));
            ModelView myModelView = null;
            myModelView = ((ModelView)(swDoc.ActiveView));
            myModelView.FrameState = ((int)(swWindowState_e.swWindowMaximized));
            swDoc.SketchManager.InsertSketch(true);
            boolstatus = swDoc.Extension.SelectByID2("上视基准面", "PLANE", 0.018497937670061526, -0.010618324637972687, -0.0023822325002946232, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            SketchSegment skSegment = null;
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0, 0, 0, 0, 0.051358, 0)));
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0, 0.051358, 0, 0.094057, 0.051358, 0)));
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0.094057, 0.051358, 0, 0.094057, 0.033442, 0)));
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0.094057, 0.033442, 0, 0.119736, 0.033442, 0)));
            swDoc.SetPickMode();
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateArc(0.142429, 0, 0, 0.119736, 0.033442, 0, 0.182844, 0, 0, -1)));
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0.182844, 0, 0, 0.114361, 0, 0)));
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0.114361, 0, 0, 0.114361, 0.014631, 0)));
            swDoc.SetPickMode();
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateArc(0.104806, 0.014631, 0, 0.114361, 0.014631, 0, 0.104806, 0.024186, 0, 1)));
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0.104806, 0.024186, 0, 0, 0.024186, 0)));
            swDoc.SetPickMode();
            swDoc.ClearSelection2(true);
            swDoc.SetPickMode();
            boolstatus = swDoc.Extension.SelectByID2("直线1", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            boolstatus = swDoc.SketchManager.SketchTrim(1, -0.0014929629027009561, 0.017318369671330949, 0);
            swDoc.SketchManager.InsertSketch(true);
            //step 2
            myModelView = ((ModelView)(swDoc.ActiveView));
            myModelView.FrameState = ((int)(swWindowState_e.swWindowMaximized));
            boolstatus = swDoc.Extension.SelectByID2("草图1", "SKETCH", 0, 0, 0, false, 0, null, 0);
            swDoc.EditSketch();
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("草图1", "SKETCH", 0, 0, 0, false, 0, null, 0);
            myModelView = ((ModelView)(swDoc.ActiveView));
            myModelView.FrameState = ((int)(swWindowState_e.swWindowMaximized));
            myModelView = ((ModelView)(swDoc.ActiveView));
            myModelView.FrameState = ((int)(swWindowState_e.swWindowMaximized));
            swDoc.ClearSelection2(true);
            swDoc.SetPickMode();
            boolstatus = swDoc.Extension.SelectByID2("直线1", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            boolstatus = swDoc.SketchManager.SketchTrim(1, 0.00029382593078911, 0.014910927210231628, 0);
            boolstatus = swDoc.Extension.SelectByID2("Line2", "SKETCHSEGMENT", 0.02228336404884243, 0.05140902656081496, 0, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Line5", "SKETCHSEGMENT", 0.13381792852391697, 0.00017566970844333507, 0, true, 0, null, 0);
            DisplayDimension myDisplayDim = null;
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(-0.015574912917290573, 0.022165207826496641, 0)));
            swDoc.ClearSelection2(true);
            Dimension myDimension = null;
            myDimension = ((Dimension)(swDoc.Parameter("D1@草图1")));
            myDimension.SystemValue = textOuterR.InputText==""? 0.015:Convert.ToDouble(textOuterR.InputText)/1000;
            boolstatus = swDoc.Extension.SelectByID2("Line1", "SKETCHSEGMENT", 8.581698979393676E-05, 0.010777424742479735, 0, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Point8", "SKETCHPOINT", 0.041598874566766628, 0, 0, true, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.019882786646388685, -0.0058414360729225415, 0)));
            boolstatus = swDoc.Extension.SelectByID2("D1@草图1@零件6.SLDPRT", "DIMENSION", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D2@草图1")));
            myDimension.SystemValue = 0.105;
            boolstatus = swDoc.Extension.SelectByID2("Line7", "SKETCHSEGMENT", 0.0064420346721788743, 0.00753310530042909, 0, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Line5", "SKETCHSEGMENT", 0.040474283513281542, 0.00018372860517151118, 0, true, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.011275408534825754, 0.0030969950429312713, 0)));
            boolstatus = swDoc.Extension.SelectByID2("D2@草图1@零件6.SLDPRT", "DIMENSION", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D3@草图1")));
            myDimension.SystemValue = 0.1745329251994;
            swDoc.ClearSelection2(true);
            swDoc.EditUndo2(1);
            swDoc.SetPickMode();
            boolstatus = swDoc.Extension.SelectByID2("D3@草图1@零件6.SLDPRT", "DIMENSION", 0.011341619135683927, 0.0034942586480803325, 0, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("D3@草图1@零件6.SLDPRT", "DIMENSION", 0.010613302526243984, 0.0026335208369240373, 0, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("D3@草图1@零件6.SLDPRT", "DIMENSION", 0.010679513127102164, 0.0026335208369240373, 0, false, 0, null, 0);
            swDoc.EditDelete();
            boolstatus = swDoc.Extension.SelectByID2("Line7", "SKETCHSEGMENT", 0.021339419865268563, 0.0070696310944218556, 0, false, 0, null, 0);
            swDoc.SketchAddConstraints("sgHORIZONTAL2D");
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Line7", "SKETCHSEGMENT", 0.016042571796614453, 0.007400684098712737, 0, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Line5", "SKETCHSEGMENT", 0.043586181753615838, 0.00018372860517151118, 0, true, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.020611103255828628, 0.0032956268455058, 0)));
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D3@草图1")));
            myDimension.SystemValue = 0.01;
            boolstatus = swDoc.Extension.SelectByID2("Arc2", "SKETCHSEGMENT", 0.032131747805151323, 0.0096518445278907378, 0, false, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.032926275015449438, 0.013161006373374085, 0)));
            boolstatus = swDoc.Extension.SelectByID2("D3@草图1@零件6.SLDPRT", "DIMENSION", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D4@草图1")));
            myDimension.SystemValue = 0.003;
            // step 3
            boolstatus = swDoc.Extension.SelectByID2("草图1", "SKETCH", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Arc2", "SKETCHSEGMENT", 0.10668896005472661, 0.0069534755210386989, 5.0000000000124144E-05, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Line7", "SKETCHSEGMENT", 0.09838443444293965, 0.007414838055026865, 5.0000000000120925E-05, true, 0, null, 0);
            swDoc.SketchAddConstraints("sgTANGENT");
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Arc2", "SKETCHSEGMENT", 0.10691964132172066, 0.007184156788032775, 5.0000000000122531E-05, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Line6", "SKETCHSEGMENT", 0.10830372892368517, 0.002570531448151156, 5.0000000000154752E-05, true, 0, null, 0);
            swDoc.SelectMidpoint();
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Line6", "SKETCHSEGMENT", 0.10830372892368517, 0.003031893982139322, 5.0000000000151526E-05, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Arc2", "SKETCHSEGMENT", 0.10715032258871476, 0.0060307504530623668, 5.0000000000130588E-05, true, 0, null, 0);
            swDoc.SketchAddConstraints("sgTANGENT");
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Line6", "SKETCHSEGMENT", 0.10738100385570881, 0.002570531448151156, 5.0000000000154752E-05, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Line1", "SKETCHSEGMENT", -0.00011646656353303531, 0.012951188462884802, 5.0000000000082259E-05, true, 0, null, 0);
            // step 4
            swDoc = ((ModelDoc2)(mydata.swApp.ActiveDoc));
            boolstatus = swDoc.Extension.SelectByID2("草图1", "SKETCH", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 0.15305589472053693, 0.038095446565239666, 4.999999999990668E-05, false, 0, null, 0);
            //DisplayDimension myDisplayDim = null;
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.1978080605173887, 0.040171577968186392, 0)));
            swDoc.ClearSelection2(true);
            //Dimension myDimension = null;
            myDimension = ((Dimension)(swDoc.Parameter("D5@草图1")));
            myDimension.SystemValue = textBallR.InputText == "" ? 0.0105 : Convert.ToDouble(textBallR.InputText) / 1000;
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Point11", "SKETCHPOINT", 0.10485936539481794, 0.0075000000000000023, 0, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Arc2", "SKETCHSEGMENT", 0.10761168512270292, 0.0064921129870505329, 5.0000000000127369E-05, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Line6", "SKETCHSEGMENT", 0.10807304765669107, 0.0028012127151452321, 5.0000000000153139E-05, false, 0, null, 0);
            swDoc.SelectMidpoint();
            boolstatus = swDoc.Extension.SelectByID2("Line1", "SKETCHSEGMENT", -0.0005778290975211875, 0.01248982592889665, 5.0000000000085485E-05, true, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.046942511903259543, -0.018652145115304331, 0)));
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D6@草图1")));
            myDimension.SystemValue = 0.087;
            boolstatus = swDoc.Extension.SelectByID2("Point8", "SKETCHPOINT", 0.142429, 0, 0, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Line1", "SKETCHSEGMENT", 0.0010369397714373729, 0.011105738326932152, 5.0000000000095148E-05, true, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.0621674755248689, -0.031570296066972869, 0)));
            boolstatus = swDoc.Extension.SelectByID2("D6@草图1@零件10.SLDPRT", "DIMENSION", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D7@草图1")));
            myDimension.SystemValue = 0.105;
            boolstatus = swDoc.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0.08823445869520008, 0.0097216507249676676, 5.0000000000104811E-05, false, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.091233315166123152, 0.017334132535772359, 0)));
            boolstatus = swDoc.Extension.SelectByID2("D7@草图1@零件10.SLDPRT", "DIMENSION", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D8@草图1")));
            myDimension.SystemValue = 0.004;
            boolstatus = swDoc.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0.096538984306986986, 0.0083375631230031833, 5.0000000000114481E-05, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Line5", "SKETCHSEGMENT", 0.0990764782439219, 0.00049440004520441561, 5.0000000000169246E-05, true, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.13160253689008738, 0.00395461905011564, 0)));
            boolstatus = swDoc.Extension.SelectByID2("D8@草图1@零件10.SLDPRT", "DIMENSION", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D9@草图1")));
            myDimension.SystemValue = textInnerR.InputText == "" ? 0.0075 : Convert.ToDouble(textInnerR.InputText) / 1000;
            swDoc.ClearSelection2(true);
            swDoc.SketchManager.InsertSketch(true);
            // step 5
            swDoc = ((ModelDoc2)(mydata.swApp.ActiveDoc));
            boolstatus = swDoc.Extension.SelectByID2("草图1", "SKETCH", 0, 0, 0, false, 0, null, 0);
            swDoc.EditSketch();
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("草图1", "SKETCH", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Line1", "SKETCHSEGMENT", -0.00092327477184517281, 0.011708476485119884, 4.9999999999914757E-05, false, 0, null, 0);
            swDoc.EditDelete();
            //SketchSegment skSegment = null;
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0, textInnerR.InputText == "" ? 0.0075 : Convert.ToDouble(textInnerR.InputText) / 1000, 0, 0, textOuterR.InputText == "" ? 0.015 : Convert.ToDouble(textOuterR.InputText) / 1000, 0)));
            swDoc.ClearSelection2(true);
            swDoc.SketchManager.InsertSketch(true);
            boolstatus = swDoc.Extension.SelectByID2("Line5@草图1", "EXTSKETCHSEGMENT", 0.10212387476450055, 0, 0, true, 0, null, 0);
            boolstatus = swDoc.InsertAxis2(true);
            boolstatus = swDoc.Extension.SelectByID2("草图1", "SKETCH", 0, 0, 0, false, 0, null, 0);
            // 
            // Named View
            swDoc.ShowNamedView2("*上下二等角轴测", 8);
            swDoc.ViewZoomtofit2();
            boolstatus = swDoc.Extension.SelectByID2("基准轴1", "AXIS", 0, 0, 0, true, 0, null, 0);
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("草图1", "SKETCH", 0, 0, 0, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("基准轴1", "AXIS", 0, 0, 0, true, 16, null, 0);
            Feature myFeature = null;
            myFeature = ((Feature)(swDoc.FeatureManager.FeatureRevolve2(true, true, false, false, false, false, 0, 0, 6.2831853071796, 0, false, false, 0.01, 0.01, 0, 0, 0, true, true, true)));
            swDoc.ISelectionManager.EnableContourSelection = false;
            boolstatus = swDoc.Extension.SelectByID2("基准轴1", "AXIS", 0, 0, 0, false, 0, null, 0);
            swDoc.BlankRefGeom();
            mydata.swApp.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swInputDimValOnCreate, true);
            String save_part = mydata.save_path + "柱塞.SLDPRT";
            if (checkSave.Checked)
            {
                longstatus = swDoc.SaveAs3(save_part, 0, 0);
            }
            mydata.swApp.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swInputDimValOnCreate, true);
            btnBegin.BtnText = "开始";
            this.WindowState = FormWindowState.Normal;
        }

        private void checkSave_CheckedChangeEvent(object sender, EventArgs e)
        {

        }
    }
    }



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
    public partial class peiyoupan : Form
    {
        public Data mydata;
        public peiyoupan(Data mydata)
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
            double R1 = textR1.InputText == "" ? 0.114 : Convert.ToDouble(textR1.InputText) * 2 / 1000;
            double R2 = textR1.InputText == "" ? 0.106 : Convert.ToDouble(textR1.InputText) * 2 / 1000;
            double R3 = textR1.InputText == "" ? 0.070 : Convert.ToDouble(textR1.InputText) * 2 / 1000;
            double R4 = textR1.InputText == "" ? 0.064 : Convert.ToDouble(textR1.InputText) * 2 / 1000;
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
            SketchSegment skSegment = null;
            // coding here
            swDoc.SketchManager.InsertSketch(true);
            boolstatus = swDoc.Extension.SelectByID2("上视基准面", "PLANE", 0.17209963794965688, 0.10088655260574342, 0.044097342621284952, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateCircle(0, 0, 0, 0.042718, -0.02188, 0)));
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 0.036987421041991486, 0.0109999999999998, -0.028131277975599139, false, 0, null, 0);
            DisplayDimension myDisplayDim = null;
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.089082380256063964, 0, -0.033861723489147046)));
            swDoc.ClearSelection2(true);
            Dimension myDimension = null;
            myDimension = ((Dimension)(swDoc.Parameter("D1@草图1")));
            myDimension.SystemValue = R1;
            swDoc.ClearSelection2(true);
            swDoc.SketchManager.InsertSketch(true);
            // 
            // Named View
            swDoc.ShowNamedView2("*上下二等角轴测", 8);
            swDoc.ViewZoomtofit2();
            Feature myFeature = null;
            myFeature = ((Feature)(swDoc.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0, 0.01, 0.01, false, false, false, false, 0.017453292519943334, 0.017453292519943334, false, false, false, false, true, true, true, 0, 0, false)));
            swDoc.ISelectionManager.EnableContourSelection = false;
            //
            swDoc.SketchManager.InsertSketch(true);
            boolstatus = swDoc.Extension.SelectByRay(-0.02422100870057875, 0.0174006733313945, 0.0099999999999340616, -0.49999999999999661, -0.70710678118655368, -0.49999999999999484, 0.00070961686442319778, 2, false, 0, 0);
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("草图2", "SKETCH", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateCircle(0, 0, 0, 0.015349, -0.013514, 0)));
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 0.018018685746815921, 0.0081751444592035247, 0.0049999999999999437, false, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.03670473022499543, 0.0050051904852266857, 0.01)));
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D1@草图2")));
            myDimension.SystemValue = R4;
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Arc1@草图2", "EXTSKETCHSEGMENT", 0.013544633371653056, 0.028992118012099468, 0, false, 0, null, 0);
            myFeature = ((Feature)(swDoc.FeatureManager.FeatureCut4(true, false, true, 0, 0, 0.01, 0.01, false, false, false, false, 0.017453292519943334, 0.017453292519943334, false, false, false, false, false, true, true, true, true, false, 0, 0, false, false)));
            swDoc.ISelectionManager.EnableContourSelection = false;
            swDoc.ClearSelection2(true);
            //step 7
            swDoc.SketchManager.InsertSketch(true);
            boolstatus = swDoc.Extension.SelectByRay(0.037467787444882106, 0.02058408595473793, 0.0099999999998772182, -0.49999999999999661, -0.70710678118655368, -0.49999999999999484, 0.00070961686442319778, 2, false, 0, 0);
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("草图3", "SKETCH", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(-0.068905, 0, 0, 0.067737, 0, 0)));
            swDoc.SetPickMode();
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0, 0.034703, 0, 0, -0.035871, 0)));
            swDoc.SetPickMode();
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateCircle(0.0322, 0.030532, 0, 0.036037, 0.026861, 0)));
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 0.036871569907836327, 0.031699539739768787, 0.0049999999999997789, false, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.054556576288970482, 0.036871569907836362, 0.01)));
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D1@草图3")));
            myDimension.SystemValue = 0.005;
            boolstatus = swDoc.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 0.033367936568177659, 0.029363784179996355, 0.0049999999999997954, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Line1", "SKETCHSEGMENT", 0.039541004833290538, 0.00033367936568177992, 0.0049999999999999984, true, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.07591205569260423, 0.012346136530225774, 0.01)));
            boolstatus = swDoc.Extension.SelectByID2("D1@草图3@零件38.SLDPRT", "DIMENSION", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D2@草图3")));
            myDimension.SystemValue = 0.037;
            boolstatus = swDoc.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 0.033534776251018555, 0.036204211176472781, 0.0049999999999997477, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Point1@原点", "EXTSKETCHPOINT", 0, 0, 0, true, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.024859112743292361, 0.0078414650935217864, 0.01)));
            boolstatus = swDoc.Extension.SelectByID2("D2@草图3@零件38.SLDPRT", "DIMENSION", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D3@草图3")));
            myDimension.SystemValue = 0.037;
            swDoc.ClearSelection2(true);
            swDoc.EditUndo2(1);
            boolstatus = swDoc.Extension.SelectByID2("D3@草图3@零件38.SLDPRT", "DIMENSION", 0.0241917540119288, 0.0090093428734079675, 0.0049999999999999377, false, 0, null, 0);
            myDimension = ((Dimension)(swDoc.Parameter("D3@草图3")));
            myDimension.SystemValue = 0.044;
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 0.025526471474655921, 0.036537890542154589, 0.0099999999999909051, true, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Line1", "SKETCHSEGMENT", 0.051553461997834504, -0.00083419841420440794, 0.0099999999999909051, true, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 0.024024914329087904, 0.03453581434806393, 0.0099999999999909051, true, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Line1", "SKETCHSEGMENT", -0.023357555597724372, -0.00066735873136355983, 0.0050000000000000053, true, 0, null, 0);
            swDoc.SketchMirror();
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 0.021355479403633693, 0.038206287370563467, 0.0099999999999909051, true, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Arc2", "SKETCHSEGMENT", 0.025860150840337687, -0.037372088956358969, 0.0099999999999909051, true, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Line2", "SKETCHSEGMENT", -0.00033367936568179379, 0.01017722065329419, 0.00499999999999993, true, 0, null, 0);
            swDoc.SketchMirror();
            swDoc.ClearSelection2(true);
            swDoc.SketchManager.InsertSketch(true);
            boolstatus = swDoc.DeSelectByID("草图3", "SKETCH", 0, 0, 0);
            boolstatus = swDoc.Extension.SelectByID2("草图3", "SKETCHCONTOUR", -0.022857036549201709, 0.038206287370563433, 0.0049999999999997338, true, 4, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("草图3", "SKETCHCONTOUR", 0.025860150840337687, 0.035870531810791, 0.00499999999999975, true, 4, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("草图3", "SKETCHCONTOUR", 0.025359631791815024, -0.036371050859313678, 0.0050000000000002542, true, 4, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("草图3", "SKETCHCONTOUR", -0.022356517500679046, -0.035036333396586558, 0.0050000000000002456, true, 4, null, 0);
            myFeature = ((Feature)(swDoc.FeatureManager.FeatureCut4(true, false, false, 0, 0, 0.01, 0.01, false, false, false, false, 0.017453292519943334, 0.017453292519943334, false, false, false, false, false, true, true, true, true, false, 0, 0, false, false)));
            swDoc.ISelectionManager.EnableContourSelection = false;
            //step 8
            myFeature = ((Feature)(swDoc.FeatureManager.FeatureCut4(true, false, true, 0, 0, 0.01, 0.01, false, false, false, false, 0.017453292519943334, 0.017453292519943334, false, false, false, false, false, true, true, true, true, false, 0, 0, false, false)));
            swDoc.ISelectionManager.EnableContourSelection = false;
            swDoc.ClearSelection2(true);
            //step 9
            boolstatus = swDoc.Extension.SelectByID2("上视基准面", "PLANE", 0, 0, 0, true, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("切除-拉伸3", "BODYFEATURE", 0, 0, 0, true, 0, null, 0);
            // 
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("上视基准面", "PLANE", 0, 0, 0, false, 2, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("切除-拉伸3", "BODYFEATURE", 0, 0, 0, true, 1, null, 0);
            // 
            myFeature = ((Feature)(swDoc.FeatureManager.InsertMirrorFeature(false, false, false, false)));
            boolstatus = swDoc.Extension.SelectByID2("右视基准面", "PLANE", 0, 0, 0, true, 0, null, 0);
            // 
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("镜向1", "BODYFEATURE", 0, 0, 0, false, 1, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("右视基准面", "PLANE", 0, 0, 0, true, 2, null, 0);
            // 
            myFeature = ((Feature)(swDoc.FeatureManager.InsertMirrorFeature(false, false, false, false)));
            //step 10
            swDoc.SketchManager.InsertSketch(true);
            boolstatus = swDoc.Extension.SelectByRay(0.041895213005602727, 0.020763131551404967, 0.0099999999998772182, -0.49999999999999661, -0.70710678118655368, -0.49999999999999484, 0.00070961686442319778, 2, false, 0, 0);
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("草图4", "SKETCH", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateCircle(0, 0, 0, 0.002669, 0.038373, 0)));
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateCircle(0, 0, 0, 0.008843, 0.046215, 0)));
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 0.031365860374087007, 0.022690196866360819, 0.0049999999999998422, false, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.08925923031987526, 0.014515052407157322, 0.01)));
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D1@草图4")));
            myDimension.SystemValue = R3;
            boolstatus = swDoc.Extension.SelectByID2("Arc2", "SKETCHSEGMENT", 0.047882988975334967, 0.000667358731363546, 0.0049999999999999958, false, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.1042748017755552, 0.0036704730224995721, 0.01)));
            boolstatus = swDoc.Extension.SelectByID2("D1@草图4@零件46.SLDPRT", "DIMENSION", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D2@草图4")));
            myDimension.SystemValue = R2;
            boolstatus = swDoc.Extension.SelectByID2("Point2", "SKETCHPOINT", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0, 0, 0, -0.022857, 0.039541, 0)));
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Line1", "SKETCHSEGMENT", -0.0091761825562488852, 0.015682930187043503, 0.0049999999999998908, false, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(-0.018185525429656846, 0.013847693675793769, 0.01)));
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D3@草图4")));
            myDimension.SystemValue = 0.044;
            boolstatus = swDoc.Extension.SelectByID2("D3@草图4@零件46.SLDPRT", "DIMENSION", -0.02202283813499728, 0.03803944768772255, 0.0049999999999997347, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("D3@草图4@零件46.SLDPRT", "DIMENSION", -0.022523357183519943, 0.03787260800488166, 0.0049999999999997364, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("D3@草图4@零件46.SLDPRT", "DIMENSION", -0.021855998452156383, 0.038539966736245213, 0.0049999999999997312, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Point2", "SKETCHPOINT", 0, 0, 0, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Point5", "SKETCHPOINT", -0.022020247428340998, 0.038093420733699423, 0, true, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(-0.0116787777988622, 0.041709920710222129, 0.01)));
            boolstatus = swDoc.Extension.SelectByID2("D3@草图4@零件46.SLDPRT", "DIMENSION", -0.021855998452156383, 0.038539966736245213, 0.0049999999999997312, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D4@草图4")));
            myDimension.SystemValue = 0.0193;
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(-0.0193, 0.039541, 0, -0.023248, 0.047629, 0)));
            swDoc.SetPickMode();
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateArc(-0.0193, 0.039541, 0, -0.023248, 0.047629, 0, -0.015352, 0.031453, 0, 1)));
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0, -0.010845, 0, 0, 0.017184, 0)));
            swDoc.SetPickMode();
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Arc3", "SKETCHSEGMENT", -0.023858074646247063, 0.032366898471132381, 0.0099999999999909051, true, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Line3", "SKETCHSEGMENT", 0.00050051904852266293, 0.00967670160477152, 0.0049999999999999333, true, 0, null, 0);
            swDoc.SketchMirror();
            swDoc.ClearSelection2(true);
            swDoc.SetPickMode();
            boolstatus = swDoc.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 0.029697463545678121, 0.019186563526702193, 0.0099999999999909051, false, 0, null, 0);
            swDoc.EditDelete();
            boolstatus = swDoc.Extension.SelectByID2("Arc2", "SKETCHSEGMENT", 0.049718225486584722, 0.01851920479533864, 0.0099999999999909051, false, 0, null, 0);
            swDoc.EditDelete();
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateArc(0, 0, 0, -0.015352, 0.031453, 0, 0.015352, 0.031453, 0, -1)));
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateArc(0, 0, 0, 0.023248, 0.047629, 0, -0.023248, 0.047629, 0, 1)));
            swDoc.SetPickMode();
            swDoc.ClearSelection2(true);
            swDoc.SetPickMode();
            boolstatus = swDoc.Extension.SelectByID2("Arc3", "SKETCHSEGMENT", -0.02068812067227016, 0.031199020691246158, 0.0099999999999909051, false, 0, null, 0);
            swDoc.EditDelete();
            boolstatus = swDoc.Extension.SelectByID2("Arc4", "SKETCHSEGMENT", 0.027194868303064806, 0.035536852445109256, 0.0099999999999909051, false, 0, null, 0);
            swDoc.EditDelete();
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0, 0, 0, 0.015352, 0.031453, 0)));
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0.015352, 0.031453, 0, 0.023248, 0.047629, 0)));
            swDoc.SetPickMode();
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Line1", "SKETCHSEGMENT", -0.0091761825562488852, 0.020187601623747491, 0.00499999999999986, false, 0, null, 0);
            swDoc.EditDelete();
            boolstatus = swDoc.Extension.SelectByID2("Line2", "SKETCHSEGMENT", -0.021021800037951954, 0.043878836587153677, 0.0099999999999909051, false, 0, null, 0);
            swDoc.EditDelete();
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(-0.023248, 0.047629, 0, -0.015352, 0.031453, 0)));
            swDoc.SetPickMode();
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateArc(-0.0193, 0.039541, 0, -0.023248, 0.047629, 0, -0.015352, 0.031453, 0, 1)));
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateArc(0.0193, 0.039541, 0, 0.023248, 0.047629, 0, 0.015352, 0.031453, 0, -1)));
            boolstatus = swDoc.Extension.SelectByID2("Line5", "SKETCHSEGMENT", 0.02068812067227016, 0.0420436000759039, 0.0099999999999909051, false, 0, null, 0);
            swDoc.EditDelete();
            boolstatus = swDoc.Extension.SelectByID2("Line6", "SKETCHSEGMENT", -0.018686044478179509, 0.036704730224995478, 0.0099999999999909051, false, 0, null, 0);
            swDoc.EditDelete();
            boolstatus = swDoc.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0.012012457164543938, 0.025359631791815031, 0.0049999999999998232, false, 0, null, 0);
            swDoc.EditDelete();
            boolstatus = swDoc.Extension.SelectByID2("Line3", "SKETCHSEGMENT", 0.00033367936568176604, 0.012179296847384849, 0.004999999999999916, false, 0, null, 0);
            swDoc.EditDelete();
            swDoc.SketchManager.InsertSketch(true);
            myFeature = ((Feature)(swDoc.FeatureManager.FeatureCut4(true, false, false, 0, 0, 0.01, 0.01, false, false, false, false, 0.017453292519943334, 0.017453292519943334, false, false, false, false, false, true, true, true, true, false, 0, 0, false, false)));
            swDoc.ISelectionManager.EnableContourSelection = false;
            swDoc.ClearSelection2(true);
            //step 13
            boolstatus = swDoc.Extension.SelectByID2("草图4", "SKETCH", 0, 0, 0, false, 0, null, 0);
            swDoc.EditSketch();
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("草图4", "SKETCH", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Arc5", "SKETCHSEGMENT", 0.006006228582271983, 0.035036333396586593, 0.0099999999999909051, false, 0, null, 0);
            swDoc.EditDelete();
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(-0.015352, 0.031453, 0, -0.0193, 0.039541, 0)));
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(-0.0193, 0.039541, 0, 0.0193, 0.039541, 0)));
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0.0193, 0.039541, 0, 0.015352, 0.031453, 0)));
            swDoc.ClearSelection2(true);
            swDoc.SketchManager.InsertSketch(true);
            boolstatus = swDoc.Extension.SelectByID2("草图4", "SKETCH", 0, 0, 0, false, 0, null, 0);
            myFeature = ((Feature)(swDoc.FeatureManager.FeatureCut4(true, false, true, 0, 0, 0.01, 0.01, false, false, false, false, 0.017453292519943334, 0.017453292519943334, false, false, false, false, false, true, true, true, true, false, 0, 0, false, false)));
            swDoc.ISelectionManager.EnableContourSelection = false;
            //step 14
            swDoc.SketchManager.InsertSketch(true);
            boolstatus = swDoc.Extension.SelectByRay(0.035696817220639332, 0.0066398676258359046, 0.0099999999998772182, -0.49999999999999661, -0.70710678118655368, -0.49999999999999484, 0.00070961686442319778, 2, false, 0, 0);
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("草图5", "SKETCH", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SketchBoxSelect(0.073576, 0.023858, 0.000000, 0.073076, 0.023858, 0.000000);
            boolstatus = swDoc.Extension.SelectByRay(-0.015351963356794819, 0.031452924927769285, 0.01, 0, 0, -1, 0.00056725492165902048, 3, false, 0, 0);
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateArc(0, 0, 0, 0.015352, 0.031453, 0, -0.015352, 0.031453, 0, 1)));
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(-0.015352, 0.031453, 0, -0.0193, 0.039541, 0)));
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(-0.0193, 0.039541, 0, 0.0193, 0.039541, 0)));
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0.0193, 0.039541, 0, 0.015352, 0.031453, 0)));
            swDoc.ClearSelection2(true);
            //step 15
            boolstatus = swDoc.Extension.SelectByID2("草图5", "SKETCH", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Line1", "SKETCHSEGMENT", -0.01651712860124796, 0.035203173079427483, 0.0099999999999909051, false, 0, null, 0);
            swDoc.EditDelete();
            boolstatus = swDoc.Extension.SelectByID2("Line3", "SKETCHSEGMENT", 0.017851846063975052, 0.035536852445109256, 0.0099999999999340616, false, 0, null, 0);
            swDoc.EditDelete();
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(-0.015352, 0.031453, 0, -0.021689, 0.039541, 0)));
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(-0.021689, 0.039541, 0, -0.0193, 0.039541, 0)));
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0.015352, 0.031453, 0, 0.021689, 0.039541, 0)));
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0.021689, 0.039541, 0, 0.0193, 0.039541, 0)));
            swDoc.SetPickMode();
            swDoc.ClearSelection2(true);
            swDoc.SketchManager.InsertSketch(true);
            boolstatus = swDoc.Extension.SelectByID2("草图5", "SKETCH", 0, 0, 0, false, 0, null, 0);
            myFeature = ((Feature)(swDoc.FeatureManager.FeatureCut4(true, false, true, 0, 0, 0.01, 0.01, false, false, false, false, 0.017453292519943334, 0.017453292519943334, false, false, false, false, false, true, true, true, true, false, 0, 0, false, false)));
            swDoc.ISelectionManager.EnableContourSelection = false;
            swDoc.ClearSelection2(true);
            //step 16
            boolstatus = swDoc.Extension.SelectByID2("上视基准面", "PLANE", 0, 0, 0, true, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("切除-拉伸4", "BODYFEATURE", 0, 0, 0, true, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("切除-拉伸5", "BODYFEATURE", 0, 0, 0, true, 0, null, 0);
            // 
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("上视基准面", "PLANE", 0, 0, 0, false, 2, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("切除-拉伸4", "BODYFEATURE", 0, 0, 0, true, 1, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("切除-拉伸5", "BODYFEATURE", 0, 0, 0, true, 1, null, 0);
            // 
            myFeature = ((Feature)(swDoc.FeatureManager.InsertMirrorFeature(false, false, false, false)));

            //end
            mydata.swApp.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swInputDimValOnCreate, true);
            String save_part = mydata.save_path + "配油盘.SLDPRT";
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

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
    public partial class huaxue : Form
    {
        public Data mydata;
        public huaxue(Data mydata)
        {
            InitializeComponent();
            this.mydata = mydata;
            if(mydata.ver_path==null)
            {
                mydata.ver_path = "C:\\ProgramData\\SolidWorks\\SOLIDWORKS 2020\\templates\\gb_part.prtdot";
            }
            if(mydata.save_path==null)
            {
                mydata.save_path = "D:\\fluid_design\\";
            }
        }

        private void btnBegin_BtnClick(object sender, EventArgs e)
        {
            // Load para
            Double InnerR = textInnerR.InputText == "" ? 0.0126 : Convert.ToDouble(textInnerR.InputText) / 1000;
            Double OuterR = textOuterR.InputText == "" ? 0.01098 : Convert.ToDouble(textOuterR.InputText) / 1000 - InnerR;
            Double OilD = textOilD.InputText == "" ? 0.001 : Convert.ToDouble(textOilD.InputText) / 1000;
            btnBegin.BtnText = "工作中";
            this.WindowState = FormWindowState.Minimized;
            mydata.swApp.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swInputDimValOnCreate, false);
            ModelDoc2 swDoc = null;
            PartDoc swPart = null;
            DrawingDoc swDrawing = null;
            AssemblyDoc swAssembly = null;
            bool boolstatus = false;
            int longstatus = 0;
            int longwarnings = 0;
            swDoc = ((ModelDoc2)(mydata.swApp.NewDocument(mydata.ver_path, 0, 0, 0)));
            mydata.swApp.ActivateDoc2("零件1", false, ref longstatus);
            swDoc = ((ModelDoc2)(mydata.swApp.ActiveDoc));
            ModelView myModelView = null;
            myModelView = ((ModelView)(swDoc.ActiveView));
            myModelView.FrameState = ((int)(swWindowState_e.swWindowMaximized));
            swDoc.SketchManager.InsertSketch(true);
            boolstatus = swDoc.Extension.SelectByID2("上视基准面", "PLANE", 0.010140721926363394, 0.059352511353137336, -0.063984481443038116, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            SketchSegment skSegment = null;
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0.043425, 0, 0, 0.043425, 0.032569, 0)));
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0.043425, 0.032569, 0, 0.05273, 0.032569, 0)));
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0.05273, 0.032569, 0, 0.05273, 0.072892, 0)));
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0.05273, 0.072892, 0, 0.034402, 0.072892, 0)));
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0.034402, 0.072892, 0, 0.034402, 0.05273, 0)));
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0.034402, 0.05273, 0, -0.02707, 0.05273, 0)));
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(-0.02707, 0.05273, 0, -0.02707, 0, 0)));
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(-0.02707, 0, 0, 0.043425, 0, 0)));
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateArc(0.014945, 0, 0, 0.038913, 0, 0, -0.002574, 0.016357, 0, 1)));
            boolstatus = swDoc.Extension.SelectByID2("Line7", "SKETCHSEGMENT", -0.02678813792237178, 0.010999999999999748, -0.0353885400974491, false, 0, null, 0);
            swDoc.EditDelete();
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0, 0.05273, 0, -0.002574, 0.016357, 0)));
            swDoc.SetPickMode();
            swDoc.ClearSelection2(true);
            swDoc.SetPickMode();
            boolstatus = swDoc.Extension.SelectByID2("直线6", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            boolstatus = swDoc.SketchManager.SketchTrim(1, -0.012971098362411615, 0.053153305245969278, 0);
            swDoc.SetPickMode();
            //step 2
            swDoc = ((ModelDoc2)(mydata.swApp.ActiveDoc));
            boolstatus = swDoc.Extension.SelectByID2("草图1", "SKETCH", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            swDoc.SetPickMode();
            boolstatus = swDoc.Extension.SelectByID2("直线8", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            boolstatus = swDoc.SketchManager.SketchTrim(1, 0.011656543335280545, 0.00017552127230760495, 0);
            swDoc.SetPickMode();
            boolstatus = swDoc.Extension.SelectByID2("直线9", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            boolstatus = swDoc.SketchManager.SketchTrim(1, -0.00039805694774662503, 0.046473720589420828, 0);
            swDoc.SetPickMode();
            boolstatus = swDoc.Extension.SelectByID2("直线6", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            boolstatus = swDoc.SketchManager.SketchTrim(1, -0.0010381242194117957, 0.052661037548850709, 0);
            //step 3
            swDoc = ((ModelDoc2)(mydata.swApp.ActiveDoc));
            boolstatus = swDoc.Extension.SelectByID2("草图1", "SKETCH", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Line8", "SKETCHSEGMENT", 0.022004297560533959, 0.00028219915091846903, 0, false, 0, null, 0);
            swDoc.EditDelete();
            boolstatus = swDoc.Extension.SelectByID2("Line9", "SKETCHSEGMENT", -0.00125147997663351, 0.042953350595262452, 0, false, 0, null, 0);
            swDoc.EditDelete();
            boolstatus = swDoc.Extension.SelectByID2("Line6", "SKETCHSEGMENT", 0.0020555342603031518, 0.053087749063294144, 0, false, 0, null, 0);
            swDoc.EditDelete();
            //SketchSegment skSegment = null;
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0.043425, 0, 0, 0.038913, 0, 0)));
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(-0.002574, 0.016357, 0, -0.002574, 0.035059, 0)));
            swDoc.SetPickMode();
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateArc(0.003549, 0.035059, 0, -0.002574, 0.035059, 0, 0.003549, 0.041182, 0, -1)));
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0.003549, 0.041182, 0, 0.034402, 0.041182, 0)));
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0.034402, 0.041182, 0, 0.034402, 0.05273, 0)));
            //step 4
            swDoc = ((ModelDoc2)(mydata.swApp.ActiveDoc));
            boolstatus = swDoc.Extension.SelectByID2("草图1", "SKETCH", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Arc2", "SKETCHSEGMENT", -0.0012714226608552537, 0.03879291479902891, 0, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Line11", "SKETCHSEGMENT", -0.0021248457220723188, 0.032285563957248818, 0, true, 0, null, 0);
            swDoc.SketchAddConstraints("sgTANGENT");
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Arc2", "SKETCHSEGMENT", 8.7119309703370673E-06, 0.040819794569419435, 0, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Line12", "SKETCHSEGMENT", 0.0061960291247940419, 0.040819794569419435, 0, true, 0, null, 0);
            swDoc.SketchAddConstraints("sgTANGENT");
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Arc2", "SKETCHSEGMENT", -0.0010580668955509909, 0.038686236916376779, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Arc2", "SKETCHSEGMENT", 8.7119309703370673E-06, 0.040499760921463034, 0, false, 0, null, 0);
            DisplayDimension myDisplayDim = null;
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(-0.013326023400546255, 0.043166707987766353, 0)));
            swDoc.ClearSelection2(true);
            Dimension myDimension = null;
            myDimension = ((Dimension)(swDoc.Parameter("D1@草图1")));
            myDimension.SystemValue = 0.003;
            swDoc.ClearSelection2(true);
            // step 5
            swDoc = ((ModelDoc2)(mydata.swApp.ActiveDoc));
            boolstatus = swDoc.Extension.SelectByID2("Line12", "SKETCHSEGMENT", 0.015595032115893748, 0.037939491737811852, 5.0000000000017058E-05, false, 0, null, 0);
            // DisplayDimension myDisplayDim = null;
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.015061642702633091, 0.04412680893163555, 0)));
            swDoc.ClearSelection2(true);
            // Dimension myDimension = null;
            myDimension = ((Dimension)(swDoc.Parameter("D2@草图1")));
            myDimension.SystemValue = 0.0142;
            boolstatus = swDoc.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0.036290541350407504, 0.070156212298755932, 4.9999999999792093E-05, false, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.039170844182015066, 0.074209971839536967, 0)));
            boolstatus = swDoc.Extension.SelectByID2("D2@草图1@零件16.SLDPRT", "DIMENSION", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D3@草图1")));
            myDimension.SystemValue = 0.004;
            boolstatus = swDoc.Extension.SelectByID2("Line10", "SKETCHSEGMENT", 0.04162443548301413, -0.0001445123689995248, 5.0000000000283E-05, false, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.040771012421797079, -0.0034515267312156405, 0)));
            boolstatus = swDoc.Extension.SelectByID2("D3@草图1@零件16.SLDPRT", "DIMENSION", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D4@草图1")));
            myDimension.SystemValue = 0.001;
            boolstatus = swDoc.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 0.035970507702451096, 0.011056665309474412, 5.0000000000204781E-05, false, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.034263661580016966, 0.021937809339991947, 0)));
            boolstatus = swDoc.Extension.SelectByID2("D4@草图1@零件16.SLDPRT", "DIMENSION", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D5@草图1")));
            myDimension.SystemValue = 0.0142;
            boolstatus = swDoc.Extension.SelectByID2("D4@草图1@零件16.SLDPRT", "DIMENSION", 0.021889027192369584, 0.0032691798758687218, 5.0000000000259161E-05, false, 0, null, 0);
            myDimension = ((Dimension)(swDoc.Parameter("D4@草图1")));
            myDimension.SystemValue = 0.00287;
            boolstatus = swDoc.Extension.SelectByID2("D5@草图1@零件16.SLDPRT", "DIMENSION", 0.018155301299544929, 0.018737472860427963, 5.0000000000151147E-05, false, 0, null, 0);
            myDimension = ((Dimension)(swDoc.Parameter("D5@草图1")));
            myDimension.SystemValue = 0.0105;
            swDoc.SetPickMode();
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Line3", "SKETCHSEGMENT", 0.018582012830153469, 0.0527677174264583, 4.9999999999913517E-05, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Line2", "SKETCHSEGMENT", 0.022209060840325978, 0.032605597605205219, 5.0000000000054307E-05, false, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.022102382957673847, 0.025778213115468726, 0)));
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D6@草图1")));
            myDimension.SystemValue = 0.001;
            boolstatus = swDoc.Extension.SelectByID2("Line1", "SKETCHSEGMENT", 0.023062483901543043, 0.021937809339991947, 5.00000000001288E-05, false, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.037570675942233081, 0.021511097809383414, 0)));
            boolstatus = swDoc.Extension.SelectByID2("D6@草图1@零件16.SLDPRT", "DIMENSION", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D7@草图1")));
            myDimension.SystemValue = InnerR;
            swDoc.ClearSelection2(true);
            swDoc.EditUndo2(1);
            boolstatus = swDoc.Extension.SelectByID2("Line2", "SKETCHSEGMENT", 0.023657264004876215, 0.032551600576009088, 4.9999999999931271E-05, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            swDoc.EditUndo2(1);
            boolstatus = swDoc.Extension.SelectByID2("Line10", "SKETCHSEGMENT", 0.020886925454654141, 0.0093682411294138818, 5.0000000000093162E-05, false, 0, null, 0);
            swDoc.SketchAddConstraints("sgHORIZONTAL2D");
            swDoc.ClearSelection2(true);
            // step 10
            swDoc = ((ModelDoc2)(mydata.swApp.ActiveDoc));
            boolstatus = swDoc.Extension.SelectByID2("Line13", "SKETCHSEGMENT", 0.015058474080987344, 0.047531200119009576, 4.999999999996873E-05, false, 0, null, 0);
            swDoc.EditDelete();
            boolstatus = swDoc.Extension.SelectByID2("Line5", "SKETCHSEGMENT", 0.014143632591648317, 0.053248959427378464, 4.9999999999928804E-05, false, 0, null, 0);
            swDoc.EditDelete();
            boolstatus = swDoc.Extension.SelectByID2("Line3", "SKETCHSEGMENT", 0.0192896159691803, 0.044443610092490378, 4.9999999999990292E-05, false, 0, null, 0);
            //DisplayDimension myDisplayDim = null;
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.030039003468913805, 0.045587161954164158, 0)));
            swDoc.ClearSelection2(true);
            //Dimension myDimension = null;
            myDimension = ((Dimension)(swDoc.Parameter("D7@草图1")));
            myDimension.SystemValue = OuterR;
            swDoc.ClearSelection2(true);
            //SketchSegment skSegment = null;
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0.014626, 0.037354, 0, 0.014626, 0.043549, 0)));
            swDoc.SetPickMode();
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Line14", "SKETCHSEGMENT", 0.014452524374073794, 0.039057833644131394, 5.0000000000015994E-05, false, 0, null, 0);
            swDoc.EditDelete();
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0.014626, 0.038059, 0, 0.014626, 0.043549, 0)));
            swDoc.SetPickMode();
            swDoc.ClearSelection2(true);
            // step 12
            swDoc = ((ModelDoc2)(mydata.swApp.ActiveDoc));
            boolstatus = swDoc.Extension.SelectByID2("Line1", "SKETCHSEGMENT", 0.018105450192991271, 0.014973572710756097, 5.0000000000166861E-05, false, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.033727880749822456, 0.016811505717442117, 0)));
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D8@草图1")));
            myDimension.SystemValue = OuterR;
            boolstatus = swDoc.Extension.SelectByID2("D4@草图1@零件36.SLDPRT", "DIMENSION", 0.016063302407784572, 0.016913613106702453, 5.0000000000153315E-05, false, 0, null, 0);
            myDimension = ((Dimension)(swDoc.Parameter("D4@草图1")));
            myDimension.SystemValue = 0.00487;
            boolstatus = swDoc.Extension.SelectByID2("Line11", "SKETCHSEGMENT", -0.0028265646053773352, 0.033148687999095656, 5.0000000000039942E-05, false, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(-0.010484618799902437, 0.033148687999095656, 0)));
            boolstatus = swDoc.Extension.SelectByID2("D4@草图1@零件36.SLDPRT", "DIMENSION", 0.016063302407784572, 0.016913613106702453, 5.0000000000153315E-05, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D9@草图1")));
            myDimension.SystemValue = 0.00118;
            boolstatus = swDoc.Extension.SelectByID2("Point11", "SKETCHPOINT", 0.0035420283637595429, 0.025344099287685291, 0, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Line10", "SKETCHSEGMENT", 0.014735906347400227, 0.020793693898595172, 5.0000000000126217E-05, true, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(-0.011607800081766109, 0.022631626905281192, 0)));
            boolstatus = swDoc.Extension.SelectByID2("D9@草图1@零件36.SLDPRT", "DIMENSION", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D10@草图1")));
            myDimension.SystemValue = 0;
            //
            boolstatus = swDoc.Extension.SelectByID2("Line10", "SKETCHSEGMENT", 0.015006125729472797, 0.021796655903268965, 0, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Point11", "SKETCHPOINT", 0.0027808414415259712, 0.024847058636559605, 0, true, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.006511702262077923, 0.023829509382645518, 0)));
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D11@草图1")));
            myDimension.SystemValue = 0;
            //step 15
            swDoc.ShowNamedView2("*上下二等角轴测", 8);
            swDoc.ViewZoomtofit2();
            boolstatus = swDoc.Extension.SelectByID2("Line10@草图1", "EXTSKETCHSEGMENT", 0.016123734678046731, 0.020308999999999994, 0, true, 0, null, 0);
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("草图1", "SKETCH", 0, 0, 0, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Line10@草图1", "EXTSKETCHSEGMENT", 0.016123734678046731, 0.020308999999999994, 0, true, 16, null, 0);
            Feature myFeature = null;
            myFeature = ((Feature)(swDoc.FeatureManager.FeatureRevolve2(true, true, false, false, false, false, 0, 0, 6.2831853071796, 0, false, false, 0.01, 0.01, 0, 0, 0, true, true, true)));
            swDoc.ISelectionManager.EnableContourSelection = false;
            swDoc.ClearSelection2(true);
            //step 14
            swDoc = ((ModelDoc2)(mydata.swApp.ActiveDoc));
            swDoc.SketchManager.InsertSketch(true);
            boolstatus = swDoc.Extension.SelectByRay(0.01762602723300688, 0.018265297926575386, -0.0078648865318768912, -0.40003602677931227, -0.51503807491002407, -0.75809429405028361, 0.00040026647650534216, 2, false, 0, 0);
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("草图2", "SKETCH", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateCircle(0, 0.020309, 0, 0.001633, 0.017316, 0)));
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 0.0080260272330426822, 0.020717142550444441, -0.0034692116787777977, false, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.017626027233042685, 0.025002639330111202, -0.0074145896664074562)));
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D1@草图2")));
            myDimension.SystemValue = 0.0025;
            swDoc.ClearSelection2(true);
            swDoc.SketchManager.InsertSketch(true);
            myFeature = ((Feature)(swDoc.FeatureManager.FeatureCut4(true, false, false, 1, 0, 0.01, 0.01, false, false, false, false, 0.017453292519943334, 0.017453292519943334, false, false, false, false, false, true, true, true, true, false, 3, 0.003, false, false)));
            swDoc.ISelectionManager.EnableContourSelection = false;
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("切除-拉伸1", "BODYFEATURE", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            swDoc.ISelectionManager.EnableContourSelection = false;
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByRay(0.017626027233063724, 0.023846235437185268, -0.0038093304708148312, -1, 0, 0, 0.00023128077858518671, 2, false, 0, 0);
            swDoc.SketchManager.InsertSketch(true);
            boolstatus = swDoc.Extension.SelectByID2("草图3", "SKETCH", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateCircle(0, 0.020309, 0, -0.001497, 0.018472, 0)));
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 0.00802602723304269, 0.020989237584074078, 0.0023128077858518697, false, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.017626027233042685, 0.022145641476999947, 0.004965734363740773)));
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D1@草图3")));
            myDimension.SystemValue = OilD;
            swDoc.ClearSelection2(true);
            swDoc.SketchManager.InsertSketch(true);
            myFeature = ((Feature)(swDoc.FeatureManager.FeatureCut4(false, false, false, 9, 1, 0.01, 0.01, false, false, false, false, 0.017453292519943334, 0.017453292519943334, false, false, false, false, false, true, true, true, true, false, 0, 0, false, false)));
            swDoc.ISelectionManager.EnableContourSelection = false;
            swDoc.ClearSelection2(true);
            //step 16
            swDoc = ((ModelDoc2)(mydata.swApp.ActiveDoc));
            boolstatus = swDoc.Extension.SelectByID2("草图2", "SKETCH", 0, 0, 0, false, 0, null, 0);
            swDoc.BlankSketch();
            swDoc.SketchManager.InsertSketch(true);
            boolstatus = swDoc.Extension.SelectByRay(0.01762602723300688, 0.018268589934280044, -0.0081171397940238421, -0.40003602677931227, -0.51503807491002407, -0.75809429405028361, 0.00040026647650534216, 2, false, 0, 0);
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("草图4", "SKETCH", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateCircle(0, 0.020309, 0, 0.001837, 0.018608, 0)));
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 0.0080260272330426787, 0.021193308859296295, -0.0023808315442592765, false, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.017626027233042685, 0.024526473021259345, -0.0087750648345556181)));
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D1@草图4")));
            myDimension.SystemValue = 0.0025;
            swDoc.ClearSelection2(true);
            swDoc.SketchManager.InsertSketch(true);
            myFeature = ((Feature)(swDoc.FeatureManager.FeatureCut4(true, false, false, 1, 0, 0.01, 0.01, false, false, false, false, 0.017453292519943334, 0.017453292519943334, false, false, false, false, false, true, true, true, true, false, 3, 0.003, true, false)));
            swDoc.ISelectionManager.EnableContourSelection = false;
            boolstatus = swDoc.Extension.SelectByID2("草图4", "SKETCH", 0, 0, 0, false, 0, null, 0);
            swDoc.BlankSketch();
            //end
            mydata.swApp.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swInputDimValOnCreate, true);
            String save_part = mydata.save_path + "滑靴.SLDPRT";
            if(checkSave.Checked)
            { 
            longstatus = swDoc.SaveAs3(save_part, 0, 0);
                }

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

        private void btnSaveAndClose_BtnClick(object sender, EventArgs e)
        {
        }

        private void textOilD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

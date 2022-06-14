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
    public partial class gangti : Form
    {
        public Data mydata;
        public gangti(Data mydata)
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
            mydata.swApp.ActivateDoc2("零件5", false, ref longstatus);
            swDoc = ((ModelDoc2)(mydata.swApp.ActiveDoc));
            // coding here
            swDoc.SketchManager.InsertSketch(true);
            boolstatus = swDoc.Extension.SelectByID2("上视基准面", "PLANE", 0.18826700090630766, 0.10070686511880922, 0.0689515144691768, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            SketchSegment skSegment = null;
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateCircle(0, 0, 0, 0.027089, -0.019015, 0)));
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateCircle(0, 0, 0, 0.06017, -0.046625, 0)));
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 0.033340773897006404, 0.010999999999999963, -0.0049490211253368915, false, 0, null, 0);
            DisplayDimension myDisplayDim = null;
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.046885463292665241, 0, -0.0078142438821107926)));
            swDoc.ClearSelection2(true);
            Dimension myDimension = null;
            myDimension = ((Dimension)(swDoc.Parameter("D1@草图1")));
            myDimension.SystemValue = 0.036;
            boolstatus = swDoc.Extension.SelectByID2("Arc2", "SKETCHSEGMENT", 0.03966537018387814, 0.005982469028058923, -0.010907976800566488, false, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.066722819130737882, 0, -0.020257671201052013)));
            boolstatus = swDoc.Extension.SelectByID2("D1@草图1@零件14.SLDPRT", "DIMENSION", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D2@草图1")));
            myDimension.SystemValue = 0.144;
            swDoc.ClearSelection2(true);
            swDoc.SketchManager.InsertSketch(true);
            // 
            // Named View
            swDoc.ShowNamedView2("*上下二等角轴测", 8);
            swDoc.ViewZoomtofit2();
            Feature myFeature = null;
            myFeature = ((Feature)(swDoc.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0, 0.124, 0.01, false, false, false, false, 0.017453292519943334, 0.017453292519943334, false, false, false, false, true, true, true, 0, 0, false)));
            swDoc.ISelectionManager.EnableContourSelection = false;
            //step 2
            swDoc.SketchManager.InsertSketch(true);
            boolstatus = swDoc.Extension.SelectByRay(-0.011700986776247646, 0.029221655270589508, 0.12399999999990996, -0.49999999999999661, -0.70710678118655368, -0.49999999999999484, 0.0011734383417253522, 2, false, 0, 0);
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("草图2", "SKETCH", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateCircle(0, 0.040674, 0, 0.004426, 0.031612, 0)));
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 0.009905008539185356, 0.037723330393918765, 0.061999999999999722, false, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.0292935358924844, 0.047417594070568711, 0.124)));
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D1@草图2")));
            myDimension.SystemValue = 0.03;
            boolstatus = swDoc.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 0.014330650652438409, 0.045942380032817268, 0.06199999999999966, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Point1@原点", "EXTSKETCHPOINT", 0, 0, 0, true, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.089355821715204176, 0.01580586469018987, 0.124)));
            boolstatus = swDoc.Extension.SelectByID2("D1@草图2@零件33.SLDPRT", "DIMENSION", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D2@草图2")));
            myDimension.SystemValue = 0.045;
            boolstatus = swDoc.SketchManager.CreateCircularSketchStepAndRepeat(0.045, 4.7123889803847323, 7, 0.89759790102565717, true, "", true, true, true);
            swDoc.ClearSelection2(true);
            swDoc.SketchManager.InsertSketch(true);
            swDoc.ClearSelection2(true);
            //step 3
            boolstatus = swDoc.Extension.SelectByID2("草图2", "SKETCH", 0, 0, 0, false, 0, null, 0);
            swDoc.EditSketch();
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("草图2", "SKETCH", 0, 0, 0, false, 0, null, 0);

            //
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateCircle(0, 0, 0, 0.000361, 0.044995, 0)));
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateCircle(0.03451, 0.028881, 0, 0.049478, 0.033241, 0)));
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateCircle(0.04356, -0.011294, 0, 0.056615, -0.024272, 0)));
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateCircle(0.016652, -0.041806, 0, 0.02471, -0.057857, 0)));
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateCircle(-0.019295, -0.040653, 0, -0.036162, -0.044213, 0)));
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateCircle(-0.041177, -0.018151, 0, -0.048756, -0.017975, 0)));
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateCircle(-0.039319, 0.021887, 0, -0.053584, 0.025894, 0)));
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Arc3", "SKETCHSEGMENT", 0.048848424814199654, 0.035549602509292649, 0.061999999999999743, false, 0, null, 0);
            //DisplayDimension myDisplayDim = null;
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.079284197861628436, 0.033660485561520778, 0)));
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D3@草图2")));
            myDimension.SystemValue = 0.03;
            boolstatus = swDoc.Extension.SelectByID2("Arc4", "SKETCHSEGMENT", 0.062492047214771196, -0.012517928717336216, 0.062000000000000083, false, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.091458507080599938, -0.014616947548193805, 0)));
            boolstatus = swDoc.Extension.SelectByID2("D3@草图2@零件1.SLDPRT", "DIMENSION", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D4@草图2")));
            myDimension.SystemValue = 0.03;
            boolstatus = swDoc.Extension.SelectByID2("Arc5", "SKETCHSEGMENT", 0.034575096764371011, -0.044423014946364969, 0.062000000000000305, false, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.063961360396371181, -0.05449830533447976, 0)));
            boolstatus = swDoc.Extension.SelectByID2("D4@草图2@零件1.SLDPRT", "DIMENSION", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D5@草图2")));
            myDimension.SystemValue = 0.03;
            boolstatus = swDoc.Extension.SelectByID2("Arc6", "SKETCHSEGMENT", -0.034692524653915119, -0.047361641309564995, 0.062000000000000326, false, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(-0.040569777380315142, -0.0565973241653369, 0)));
            boolstatus = swDoc.Extension.SelectByID2("D5@草图2@零件1.SLDPRT", "DIMENSION", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D6@草图2")));
            myDimension.SystemValue = 0.03;
            boolstatus = swDoc.Extension.SelectByID2("Arc7", "SKETCHSEGMENT", -0.047496539522143777, -0.013147634366593358, 0.062000000000000083, false, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(-0.063658984519743861, -0.013147634366593792, 0)));
            boolstatus = swDoc.Extension.SelectByID2("D6@草图2@零件1.SLDPRT", "DIMENSION", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D7@草图2")));
            myDimension.SystemValue = 0.03;
            boolstatus = swDoc.Extension.SelectByID2("Arc8", "SKETCHSEGMENT", -0.050854969651515231, 0.013929708551463943, 0.061999999999999895, false, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(-0.076043195621801091, 0.033030779912263629, 0)));
            boolstatus = swDoc.Extension.SelectByID2("D7@草图2@零件1.SLDPRT", "DIMENSION", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D8@草图2")));
            myDimension.SystemValue = 0.03;
            boolstatus = swDoc.Extension.SelectByID2("Point5", "SKETCHPOINT", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0, 0, 0, 0, 0.045, 0)));
            swDoc.SetPickMode();
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0, 0, 0, 0.03451, 0.028881, 0)));
            swDoc.SetPickMode();
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0, 0, 0, 0.04356, -0.011294, 0)));
            swDoc.SetPickMode();
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0, 0, 0, 0.016652, -0.041806, 0)));
            swDoc.SetPickMode();
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0, 0, 0, -0.019295, -0.040653, 0)));
            swDoc.SetPickMode();
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0, 0, 0, -0.041177, -0.018151, 0)));
            swDoc.SetPickMode();
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(0, 0, 0, -0.039319, 0.021887, 0)));
            swDoc.SetPickMode();
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Line1", "SKETCHSEGMENT", 0.00057099170448510206, 0.026313919653521159, 0.061999999999999812, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Line2", "SKETCHSEGMENT", 0.019462161182199483, 0.017498040563921111, 0.061999999999999875, true, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.01358490845579946, 0.024004998939577856, 0)));
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D9@草图2")));
            myDimension.SystemValue = 0.8976228343007;
            boolstatus = swDoc.Extension.SelectByID2("Line3", "SKETCHSEGMENT", 0.022820591311570937, -0.0047515590431647381, 0.062000000000000027, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Line2", "SKETCHSEGMENT", 0.015264123520485173, 0.01246039536986393, 0.061999999999999909, true, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.025339413908599534, 0.0078425539419777583, 0)));
            boolstatus = swDoc.Extension.SelectByID2("D9@草图2@零件1.SLDPRT", "DIMENSION", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D10@草图2")));
            myDimension.SystemValue = 0.8976228343007;
            boolstatus = swDoc.Extension.SelectByID2("Line3", "SKETCHSEGMENT", 0.019672063065285211, -0.0039119515108218816, 0.06200000000000002, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0.0074977538463137094, -0.017345672028307668, 0.062000000000000118, true, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.014424515988142317, -0.017345672028308102, 0)));
            boolstatus = swDoc.Extension.SelectByID2("D10@草图2@零件1.SLDPRT", "DIMENSION", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D11@草图2")));
            myDimension.SystemValue = 0.8976228343007;
            boolstatus = swDoc.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0.0056086368985422685, -0.010418909886479061, 0.062000000000000069, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Line5", "SKETCHSEGMENT", -0.0050963591388292206, -0.011258517418821917, 0.062000000000000076, true, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(-0.0025775365418006513, -0.024272434170136723, 0)));
            boolstatus = swDoc.Extension.SelectByID2("D11@草图2@零件1.SLDPRT", "DIMENSION", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D12@草图2")));
            myDimension.SystemValue = 0.8976228343007;
            boolstatus = swDoc.Extension.SelectByID2("Line5", "SKETCHSEGMENT", -0.0088745930343721025, -0.017975377677564824, 0.062000000000000118, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Line6", "SKETCHSEGMENT", -0.022098411668772189, -0.0097892042372219185, 0.062000000000000062, true, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(-0.020839000370257904, -0.019444690859165257, 0)));
            boolstatus = swDoc.Extension.SelectByID2("D12@草图2@零件1.SLDPRT", "DIMENSION", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D13@草图2")));
            myDimension.SystemValue = 0.8976228343007;
            boolstatus = swDoc.Extension.SelectByID2("Line6", "SKETCHSEGMENT", -0.014961747643857853, -0.0039119515108218816, 0.06200000000000002, false, 0, null, 0);
            boolstatus = swDoc.Extension.SelectByID2("Line7", "SKETCHSEGMENT", -0.0095042986836292587, 0.0044841238126067384, 0.061999999999999965, true, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(-0.021048902253343604, 0.0046940256956920336, 0)));
            boolstatus = swDoc.Extension.SelectByID2("D13@草图2@零件1.SLDPRT", "DIMENSION", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D14@草图2")));
            myDimension.SystemValue = 0.8976228343007;
            swDoc.SetPickMode();
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Arc2", "SKETCHSEGMENT", 0.042971172087799658, 0.014769316083807245, 0.12400000000002365, false, 0, null, 0);
            swDoc.EditDelete();
            boolstatus = swDoc.Extension.SelectByID2("Line2", "SKETCHSEGMENT", 0.019252259299113783, 0.014979217966892959, 0.12400000000002365, false, 0, null, 0);
            swDoc.EditDelete();
            boolstatus = swDoc.Extension.SelectByID2("Line1", "SKETCHSEGMENT", 0.00015118793831367383, 0.019387157511692985, 0.12400000000002365, false, 0, null, 0);
            swDoc.EditDelete();
            boolstatus = swDoc.Extension.SelectByID2("Line7", "SKETCHSEGMENT", -0.017480570240886451, 0.014139610434550089, 0.12400000000002365, false, 0, null, 0);
            swDoc.EditDelete();
            boolstatus = swDoc.Extension.SelectByID2("Line6", "SKETCHSEGMENT", -0.019369687188657891, -0.0039119515108214488, 0.12400000000002365, false, 0, null, 0);
            swDoc.EditDelete();
            boolstatus = swDoc.Extension.SelectByID2("Line5", "SKETCHSEGMENT", -0.0027874384248863515, -0.0032822458615647254, 0.06200000000000002, false, 0, null, 0);
            swDoc.EditDelete();
            boolstatus = swDoc.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 0.0045591274831136841, -0.0081099891725361917, 0.062000000000000048, false, 0, null, 0);
            swDoc.EditDelete();
            boolstatus = swDoc.Extension.SelectByID2("Line3", "SKETCHSEGMENT", 0.015264123520485173, -0.0026525402123075831, 0.062000000000000013, false, 0, null, 0);
            swDoc.EditDelete();
            swDoc.SketchManager.InsertSketch(true);
            //step 18
            boolstatus = swDoc.Extension.SelectByID2("草图2", "SKETCH", 0, 0, 0, false, 0, null, 0);
            swDoc.EditSketch();
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("草图2", "SKETCH", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Arc8", "SKETCHSEGMENT", 0.0339390687692378, 0.03814482011899091, 0.12400000000002365, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Arc8", "SKETCHSEGMENT", 0.029513426655984748, 0.028661301304877259, 0.12400000000002365, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Arc8", "SKETCHSEGMENT", 0.034149813631773662, 0.039409289294206069, 0.12400000000002365, false, 0, null, 0);
            swDoc.EditDelete();
            boolstatus = swDoc.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 0.012232347928044313, 0.052896960496501041, 0.12400000000002365, false, 0, null, 0);
            swDoc.EditDelete();
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateCircle(0, 0, 0, 0.035204, -0.028029, 0)));
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateCircle(0.043871, 0.010016, 0, 0.057542, 0.008219, 0)));
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateCircle(0.019522, 0.040545, 0, 0.029092, 0.046575, 0)));
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SelectByID2("Arc10", "SKETCHSEGMENT", 0.056910258785646428, 0.0092727739515778, 0.061999999999999916, false, 0, null, 0);
            //DisplayDimension myDisplayDim = null;
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.07882772448937575, 0.016859589002868294, 0)));
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D1@草图2")));
            myDimension.SystemValue = 0.03;
            boolstatus = swDoc.Extension.SelectByID2("Arc11", "SKETCHSEGMENT", 0.02993491638105647, 0.039198544431669778, 0.061999999999999708, false, 0, null, 0);
            myDisplayDim = ((DisplayDimension)(swDoc.AddDimension2(0.048058974559140322, 0.049314297833390579, 0)));
            boolstatus = swDoc.Extension.SelectByID2("D1@草图2@零件6.SLDPRT", "DIMENSION", 0, 0, 0, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            myDimension = ((Dimension)(swDoc.Parameter("D2@草图2")));
            myDimension.SystemValue = 0.03;
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(-0.043871, 0.010016, 0, 0.043871, 0.010016, 0)));
            swDoc.SetPickMode();
            swDoc.ClearSelection2(true);
            skSegment = ((SketchSegment)(swDoc.SketchManager.CreateLine(-0.019522, 0.040545, 0, 0.019522, 0.040545, 0)));
            swDoc.SetPickMode();
            swDoc.ClearSelection2(true);
            swDoc.SetPickMode();
            boolstatus = swDoc.Extension.SelectByID2("Line8", "SKETCHSEGMENT", 0.027616722893162027, 0.010958732851865107, 0.12400000000002365, false, 0, null, 0);
            swDoc.EditDelete();
            boolstatus = swDoc.Extension.SelectByID2("Line9", "SKETCHSEGMENT", 0.0021165945263230956, 0.041095248194492937, 0.12400000000002365, false, 0, null, 0);
            swDoc.EditDelete();
            boolstatus = swDoc.Extension.SelectByID2("Arc9", "SKETCHSEGMENT", 0.017500969491440782, 0.041516737919564659, 0.12400000000002365, false, 0, null, 0);
            swDoc.EditDelete();
            swDoc.SketchManager.InsertSketch(true);
            //step 19
            boolstatus = swDoc.Extension.SelectByID2("草图2", "SKETCH", 0, 0, 0, false, 0, null, 0);
            //Feature myFeature = null;
            myFeature = ((Feature)(swDoc.FeatureManager.FeatureCut4(true, false, true, 0, 0, 0.104, 0.01, false, false, false, false, 0.017453292519943334, 0.017453292519943334, false, false, false, false, false, true, true, true, true, false, 0, 0, false, false)));
            swDoc.ISelectionManager.EnableContourSelection = false;
            swDoc.ClearSelection2(true);

            //
            mydata.swApp.SetUserPreferenceToggle((int)swUserPreferenceToggle_e.swInputDimValOnCreate, true);
            String save_part = mydata.save_path + "缸体.SLDPRT";
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

using System;
using System.Collections.Generic;
using System.Xml;
using SAPbouiCOM.Framework;
using System.Windows.Forms;
using System.Threading;

namespace FanSpecV1
{
    [FormAttribute("FanSpecV1.Form1", "Form/Form1.b1f")]
    class Form1 : UserFormBase
    {
        public static SAPbouiCOM.Application sboapp = null;
        public static SAPbouiCOM.Form objform;
        public static SAPbouiCOM.Company ocompany;
        public static SAPbobsCOM.Company dcompany;
        public string ItemCode;
        public int rowNo;
        public int NewDocEntry;
        public SAPbouiCOM.ItemEvent PValtype;

        public Form1()
        {
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.StaticText0 = ((SAPbouiCOM.StaticText)(this.GetItem("stfand").Specific));
            objform.Items.Item("stfand").FontSize = 10;
            objform.Items.Item("stfand").TextStyle = 1;
            objform.Items.Item("stfand").ForeColor = 255;

            this.StaticText1 = ((SAPbouiCOM.StaticText)(this.GetItem("stser").Specific));
            this.StaticText2 = ((SAPbouiCOM.StaticText)(this.GetItem("sttype").Specific));
            this.StaticText3 = ((SAPbouiCOM.StaticText)(this.GetItem("stmod").Specific));
            this.EditText0 = ((SAPbouiCOM.EditText)(this.GetItem("etfaser").Specific));
            this.EditText1 = ((SAPbouiCOM.EditText)(this.GetItem("etQty").Specific));
            this.EditText2 = ((SAPbouiCOM.EditText)(this.GetItem("etpric").Specific));
            this.StaticText4 = ((SAPbouiCOM.StaticText)(this.GetItem("stQty").Specific));
            this.ComboBox0 = ((SAPbouiCOM.ComboBox)(this.GetItem("cftype").Specific));
            this.ComboBox1 = ((SAPbouiCOM.ComboBox)(this.GetItem("cmodel").Specific));
            this.StaticText5 = ((SAPbouiCOM.StaticText)(this.GetItem("stpric").Specific));
            this.StaticText6 = ((SAPbouiCOM.StaticText)(this.GetItem("stval").Specific));
            this.EditText3 = ((SAPbouiCOM.EditText)(this.GetItem("etVal").Specific));
            this.Button0 = ((SAPbouiCOM.Button)(this.GetItem("1").Specific));
            this.Button0.PressedAfter += new SAPbouiCOM._IButtonEvents_PressedAfterEventHandler(this.Button0_PressedAfter);
            this.Button0.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button0_ClickAfter);
            this.Button0.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button0_ClickBefore);
            this.Button1 = ((SAPbouiCOM.Button)(this.GetItem("2").Specific));
            this.Button1.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button1_ClickAfter);
            this.Button1.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button1_ClickBefore);
            this.StaticText7 = ((SAPbouiCOM.StaticText)(this.GetItem("stfspe").Specific));
            objform.Items.Item("stfspe").FontSize = 10;
            objform.Items.Item("stfspe").TextStyle = 1;
            objform.Items.Item("stfspe").ForeColor = 255;
            this.StaticText8 = ((SAPbouiCOM.StaticText)(this.GetItem("stvol").Specific));
            this.StaticText9 = ((SAPbouiCOM.StaticText)(this.GetItem("stdri").Specific));
            this.StaticText10 = ((SAPbouiCOM.StaticText)(this.GetItem("stMOC").Specific));
            this.StaticText11 = ((SAPbouiCOM.StaticText)(this.GetItem("stmout").Specific));
            this.StaticText12 = ((SAPbouiCOM.StaticText)(this.GetItem("stSite").Specific));
            this.StaticText13 = ((SAPbouiCOM.StaticText)(this.GetItem("stNois").Specific));
            this.StaticText14 = ((SAPbouiCOM.StaticText)(this.GetItem("stIntPr").Specific));
            this.StaticText15 = ((SAPbouiCOM.StaticText)(this.GetItem("stOPres").Specific));
            this.StaticText16 = ((SAPbouiCOM.StaticText)(this.GetItem("stItemp").Specific));
            this.StaticText17 = ((SAPbouiCOM.StaticText)(this.GetItem("stmspec").Specific));
            objform.Items.Item("stmspec").FontSize = 10;
            objform.Items.Item("stmspec").TextStyle = 1;
            objform.Items.Item("stmspec").ForeColor = 255;

            this.StaticText18 = ((SAPbouiCOM.StaticText)(this.GetItem("stGtyp").Specific));
            this.StaticText19 = ((SAPbouiCOM.StaticText)(this.GetItem("stden").Specific));
            this.StaticText20 = ((SAPbouiCOM.StaticText)(this.GetItem("stPspee").Specific));
            this.StaticText21 = ((SAPbouiCOM.StaticText)(this.GetItem("stAtt").Specific));
            this.ComboBox2 = ((SAPbouiCOM.ComboBox)(this.GetItem("cmout").Specific));
            this.ComboBox3 = ((SAPbouiCOM.ComboBox)(this.GetItem("cdri").Specific));
            this.ComboBox4 = ((SAPbouiCOM.ComboBox)(this.GetItem("cattch").Specific));
            this.EditText4 = ((SAPbouiCOM.EditText)(this.GetItem("etPrefa").Specific));
            this.EditText5 = ((SAPbouiCOM.EditText)(this.GetItem("etItemp").Specific));
            this.EditText6 = ((SAPbouiCOM.EditText)(this.GetItem("etNois").Specific));
            this.EditText7 = ((SAPbouiCOM.EditText)(this.GetItem("etSite").Specific));
            this.EditText7.KeyDownAfter += new SAPbouiCOM._IEditTextEvents_KeyDownAfterEventHandler(this.EditText7_KeyDownAfter);
            this.EditText8 = ((SAPbouiCOM.EditText)(this.GetItem("etVol").Specific));
            this.EditText9 = ((SAPbouiCOM.EditText)(this.GetItem("etMoc").Specific));
            this.EditText10 = ((SAPbouiCOM.EditText)(this.GetItem("etGTyp").Specific));
            this.EditText11 = ((SAPbouiCOM.EditText)(this.GetItem("etOPres").Specific));
            this.EditText12 = ((SAPbouiCOM.EditText)(this.GetItem("etpres").Specific));
            this.EditText13 = ((SAPbouiCOM.EditText)(this.GetItem("etden").Specific));
            this.StaticText22 = ((SAPbouiCOM.StaticText)(this.GetItem("stmfre").Specific));
            this.StaticText23 = ((SAPbouiCOM.StaticText)(this.GetItem("stmvol").Specific));
            this.StaticText24 = ((SAPbouiCOM.StaticText)(this.GetItem("stclinsu").Specific));
            this.StaticText25 = ((SAPbouiCOM.StaticText)(this.GetItem("stmeff").Specific));
            this.StaticText26 = ((SAPbouiCOM.StaticText)(this.GetItem("stMCate").Specific));
            this.StaticText27 = ((SAPbouiCOM.StaticText)(this.GetItem("stMmout").Specific));
            this.ComboBox5 = ((SAPbouiCOM.ComboBox)(this.GetItem("CMCate").Specific));
            this.ComboBox6 = ((SAPbouiCOM.ComboBox)(this.GetItem("CmMout").Specific));
            this.EditText14 = ((SAPbouiCOM.EditText)(this.GetItem("etmeff").Specific));
            this.ComboBox7 = ((SAPbouiCOM.ComboBox)(this.GetItem("Cclsins").Specific));
            this.EditText15 = ((SAPbouiCOM.EditText)(this.GetItem("etmfre").Specific));
            this.EditText16 = ((SAPbouiCOM.EditText)(this.GetItem("etmvol").Specific));
            this.StaticText28 = ((SAPbouiCOM.StaticText)(this.GetItem("Stospe").Specific));
            objform.Items.Item("Stospe").FontSize = 10;
            objform.Items.Item("Stospe").TextStyle = 1;
            objform.Items.Item("Stospe").ForeColor = 255;
            this.StaticText29 = ((SAPbouiCOM.StaticText)(this.GetItem("stdusco").Specific));
            this.StaticText30 = ((SAPbouiCOM.StaticText)(this.GetItem("stDuty").Specific));
            this.StaticText31 = ((SAPbouiCOM.StaticText)(this.GetItem("stbtyp").Specific));
            this.StaticText32 = ((SAPbouiCOM.StaticText)(this.GetItem("stpmake").Specific));
            this.StaticText33 = ((SAPbouiCOM.StaticText)(this.GetItem("stshaty").Specific));
            this.StaticText34 = ((SAPbouiCOM.StaticText)(this.GetItem("stshdet").Specific));
            this.ComboBox8 = ((SAPbouiCOM.ComboBox)(this.GetItem("cduty").Specific));
            this.EditText17 = ((SAPbouiCOM.EditText)(this.GetItem("etdusco").Specific));
            this.ComboBox9 = ((SAPbouiCOM.ComboBox)(this.GetItem("Cbtype").Specific));
            this.EditText18 = ((SAPbouiCOM.EditText)(this.GetItem("etpmake").Specific));
            this.EditText19 = ((SAPbouiCOM.EditText)(this.GetItem("etshdet").Specific));
            this.ComboBox10 = ((SAPbouiCOM.ComboBox)(this.GetItem("cstype").Specific));
            this.StaticText35 = ((SAPbouiCOM.StaticText)(this.GetItem("stPspec").Specific));
            objform.Items.Item("stPspec").FontSize = 10;
            objform.Items.Item("stPspec").TextStyle = 1;
            objform.Items.Item("stPspec").ForeColor = 255;
            this.StaticText36 = ((SAPbouiCOM.StaticText)(this.GetItem("stpSpe").Specific));

            this.EditText20 = ((SAPbouiCOM.EditText)(this.GetItem("etexpsp").Specific));
            this.StaticText37 = ((SAPbouiCOM.StaticText)(this.GetItem("stPSpe").Specific));
            objform.Items.Item("stPSpe").FontSize = 10;
            objform.Items.Item("stPSpe").TextStyle = 1;
            objform.Items.Item("stPSpe").ForeColor = 255;
            this.StaticText38 = ((SAPbouiCOM.StaticText)(this.GetItem("stpksp").Specific));
            this.EditText21 = ((SAPbouiCOM.EditText)(this.GetItem("etpsp").Specific));
            this.StaticText39 = ((SAPbouiCOM.StaticText)(this.GetItem("stappb").Specific));
            objform.Items.Item("stappb").FontSize = 10;
            objform.Items.Item("stappb").TextStyle = 1;
            objform.Items.Item("stappb").ForeColor = 255;

            this.StaticText40 = ((SAPbouiCOM.StaticText)(this.GetItem("stappbr").Specific));
            this.EditText22 = ((SAPbouiCOM.EditText)(this.GetItem("etappbr").Specific));
            this.StaticText41 = ((SAPbouiCOM.StaticText)(this.GetItem("stAcc").Specific));
            this.StaticText42 = ((SAPbouiCOM.StaticText)(this.GetItem("stmoc").Specific));
            this.EditText23 = ((SAPbouiCOM.EditText)(this.GetItem("etacc").Specific));
            this.EditText24 = ((SAPbouiCOM.EditText)(this.GetItem("etMOC").Specific));
            this.StaticText43 = ((SAPbouiCOM.StaticText)(this.GetItem("stMOC1").Specific));
            objform.Items.Item("stMOC1").FontSize = 10;
            objform.Items.Item("stMOC1").TextStyle = 1;
            objform.Items.Item("stMOC1").ForeColor = 255;

            this.StaticText44 = ((SAPbouiCOM.StaticText)(this.GetItem("stcMOC").Specific));
            this.StaticText45 = ((SAPbouiCOM.StaticText)(this.GetItem("stIMOC").Specific));
            this.StaticText46 = ((SAPbouiCOM.StaticText)(this.GetItem("stHMOC").Specific));
            this.StaticText47 = ((SAPbouiCOM.StaticText)(this.GetItem("stSMOC").Specific));
            this.StaticText48 = ((SAPbouiCOM.StaticText)(this.GetItem("stPMOC").Specific));
            this.StaticText49 = ((SAPbouiCOM.StaticText)(this.GetItem("stFMOC").Specific));
            this.StaticText50 = ((SAPbouiCOM.StaticText)(this.GetItem("stBGMOC").Specific));
            this.StaticText51 = ((SAPbouiCOM.StaticText)(this.GetItem("stSGMOC").Specific));
            this.StaticText52 = ((SAPbouiCOM.StaticText)(this.GetItem("stICMOC").Specific));
            this.ComboBox11 = ((SAPbouiCOM.ComboBox)(this.GetItem("ccMOC").Specific));
            this.ComboBox12 = ((SAPbouiCOM.ComboBox)(this.GetItem("cIMOC").Specific));
            this.ComboBox13 = ((SAPbouiCOM.ComboBox)(this.GetItem("cHMOC").Specific));
            this.ComboBox14 = ((SAPbouiCOM.ComboBox)(this.GetItem("csMOC").Specific));
            this.ComboBox15 = ((SAPbouiCOM.ComboBox)(this.GetItem("cpMOC").Specific));
            this.ComboBox16 = ((SAPbouiCOM.ComboBox)(this.GetItem("CBMOC").Specific));
            this.ComboBox17 = ((SAPbouiCOM.ComboBox)(this.GetItem("cBGMOC").Specific));
            this.ComboBox18 = ((SAPbouiCOM.ComboBox)(this.GetItem("cSGMOC").Specific));
            this.ComboBox19 = ((SAPbouiCOM.ComboBox)(this.GetItem("cICMOC").Specific));
            this.StaticText53 = ((SAPbouiCOM.StaticText)(this.GetItem("stacces").Specific));
            objform.Items.Item("stacces").FontSize = 10;
            objform.Items.Item("stacces").TextStyle = 1;
            objform.Items.Item("stacces").ForeColor = 255;
            this.CheckBox0 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkhou").Specific));
            this.CheckBox0.ClickBefore += new SAPbouiCOM._ICheckBoxEvents_ClickBeforeEventHandler(this.CheckBox0_ClickBefore);
            this.CheckBox1 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkimp").Specific));
            this.CheckBox2 = ((SAPbouiCOM.CheckBox)(this.GetItem("ChkHub").Specific));
            this.CheckBox3 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkped").Specific));
            this.CheckBox4 = ((SAPbouiCOM.CheckBox)(this.GetItem("ChkSha").Specific));
            this.CheckBox5 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkBF").Specific));
            this.CheckBox6 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkABF").Specific));
            this.CheckBox7 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkshs").Specific));
            this.CheckBox8 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkSli").Specific));
            this.CheckBox9 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkbear").Specific));
            this.CheckBox10 = ((SAPbouiCOM.CheckBox)(this.GetItem("ChkbG").Specific));
            this.CheckBox11 = ((SAPbouiCOM.CheckBox)(this.GetItem("Item_102").Specific));
            this.CheckBox11.ClickBefore += new SAPbouiCOM._ICheckBoxEvents_ClickBeforeEventHandler(this.CheckBox11_ClickBefore);
            this.CheckBox12 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkom").Specific));
            this.CheckBox13 = ((SAPbouiCOM.CheckBox)(this.GetItem("Item_104").Specific));
            this.CheckBox14 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkocon").Specific));
            this.CheckBox15 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkIcon").Specific));
            this.CheckBox16 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkmeb").Specific));
            this.CheckBox17 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkibox").Specific));
            this.CheckBox18 = ((SAPbouiCOM.CheckBox)(this.GetItem("ChkIdam").Specific));
            this.CheckBox19 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkIS").Specific));
            this.CheckBox20 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkIfil").Specific));
            this.CheckBox21 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkITra").Specific));
            this.CheckBox21.ClickBefore += new SAPbouiCOM._ICheckBoxEvents_ClickBeforeEventHandler(this.CheckBox21_ClickBefore);
            this.CheckBox22 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkoeva").Specific));
            this.CheckBox23 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkosil").Specific));
            this.CheckBox24 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkIelb").Specific));
            //             this.CheckBox25 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkIng").Specific));
            this.CheckBox26 = ((SAPbouiCOM.CheckBox)(this.GetItem("Item_117").Specific));
            this.CheckBox27 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkIvan").Specific));
            this.CheckBox28 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkoamp").Specific));
            this.CheckBox29 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkocwl").Specific));
            this.CheckBox29.ClickBefore += new SAPbouiCOM._ICheckBoxEvents_ClickBeforeEventHandler(this.CheckBox29_ClickBefore);
            this.CheckBox30 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkmes").Specific));
            this.CheckBox31 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkLseal").Specific));
            this.CheckBox32 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkgtub").Specific));
            this.CheckBox33 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkhslg").Specific));
            this.CheckBox34 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkmseal").Specific));
            this.CheckBox34.ClickBefore += new SAPbouiCOM._ICheckBoxEvents_ClickBeforeEventHandler(this.CheckBox34_ClickBefore);
            this.CheckBox35 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkhsli").Specific));
            this.CheckBox36 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkalub").Specific));
            this.CheckBox37 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkrtd").Specific));
            this.CheckBox38 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkvso").Specific));
            this.CheckBox39 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkvsen").Specific));
            this.CheckBox40 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkpsen").Specific));
            this.CheckBox41 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkebush").Specific));
            this.CheckBox42 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkbra").Specific));
            this.CheckBox43 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkaco").Specific));
            this.CheckBox44 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkbras").Specific));
            this.CheckBox45 = ((SAPbouiCOM.CheckBox)(this.GetItem("Item_136").Specific));
            this.CheckBox46 = ((SAPbouiCOM.CheckBox)(this.GetItem("chklim").Specific));
            this.CheckBox47 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkpreg").Specific));
            this.CheckBox48 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkfap").Specific));
            this.CheckBox48.ClickBefore += new SAPbouiCOM._ICheckBoxEvents_ClickBeforeEventHandler(this.CheckBox48_ClickBefore);
            this.CheckBox49 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkAct").Specific));
            this.CheckBox50 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkMo").Specific));
            this.CheckBox51 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkmpul").Specific));
            this.CheckBox52 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkbel").Specific));
            this.CheckBox53 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkspkp").Specific));
            this.CheckBox54 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkIcone").Specific));
            this.CheckBox55 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkBdisc").Specific));
            this.CheckBox56 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkant").Specific));
            this.CheckBox57 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkIpip").Specific));
            this.CheckBox58 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkouttr").Specific));
            this.CheckBox59 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkIntra").Specific));
            this.CheckBox60 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkadoor").Specific));
            this.CheckBox61 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkhoin").Specific));
            this.CheckBox62 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkcgua").Specific));
            this.CheckBox63 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkCoup").Specific));
            this.StaticText54 = ((SAPbouiCOM.StaticText)(this.GetItem("stattc").Specific));
            objform.Items.Item("stattc").FontSize = 10;
            objform.Items.Item("stattc").TextStyle = 1;
            objform.Items.Item("stattc").ForeColor = 255;
            this.StaticText55 = ((SAPbouiCOM.StaticText)(this.GetItem("stcr").Specific));
            this.StaticText56 = ((SAPbouiCOM.StaticText)(this.GetItem("stmspf").Specific));
            this.StaticText57 = ((SAPbouiCOM.StaticText)(this.GetItem("stsef").Specific));
            this.EditText25 = ((SAPbouiCOM.EditText)(this.GetItem("etsef").Specific));
            this.Button2 = ((SAPbouiCOM.Button)(this.GetItem("bbsf").Specific));
            this.Button2.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button2_ClickBefore);
            this.EditText26 = ((SAPbouiCOM.EditText)(this.GetItem("etcrf").Specific));
            this.Button3 = ((SAPbouiCOM.Button)(this.GetItem("bcrf").Specific));
            this.Button3.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button3_ClickBefore);
            this.EditText27 = ((SAPbouiCOM.EditText)(this.GetItem("etmsf").Specific));
            this.Button4 = ((SAPbouiCOM.Button)(this.GetItem("bmspf").Specific));
            this.Button4.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button4_ClickBefore);
            this.StaticText58 = ((SAPbouiCOM.StaticText)(this.GetItem("stMocf").Specific));
            this.EditText28 = ((SAPbouiCOM.EditText)(this.GetItem("Item_11").Specific));
            this.Button5 = ((SAPbouiCOM.Button)(this.GetItem("bmocf").Specific));
            this.Button5.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button5_ClickBefore);
            this.StaticText59 = ((SAPbouiCOM.StaticText)(this.GetItem("stot1").Specific));
            this.StaticText60 = ((SAPbouiCOM.StaticText)(this.GetItem("stot2").Specific));
            this.EditText29 = ((SAPbouiCOM.EditText)(this.GetItem("etot1").Specific));
            this.EditText30 = ((SAPbouiCOM.EditText)(this.GetItem("etot2").Specific));
            this.Button6 = ((SAPbouiCOM.Button)(this.GetItem("bot1").Specific));
            this.Button6.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button6_ClickBefore);
            this.Button7 = ((SAPbouiCOM.Button)(this.GetItem("bot2").Specific));
            this.Button7.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button7_ClickBefore);
            objform.ClientHeight = objform.Items.Item("1").Top + 25;
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
            this.LoadAfter += new SAPbouiCOM.Framework.FormBase.LoadAfterHandler(this.Form_LoadAfter);
            this.DataAddAfter += new DataAddAfterHandler(this.Form_DataAddAfter);

        }

        private void Form_LoadAfter(SAPbouiCOM.SBOItemEventArg pVal)
        {

            //throw new System.NotImplementedException();
            objform = clsModule.objaddon.objapplication.Forms.GetForm("FanSpecV1.Form1", pVal.FormTypeCount);
            
        }

        private void OnCustomInitialize()
        {
            
           // objform = clsModule.objaddon.objapplication.Forms.ActiveForm;
        }

        private SAPbouiCOM.StaticText StaticText0;
        private SAPbouiCOM.StaticText StaticText1;
        private SAPbouiCOM.StaticText StaticText2;
        private SAPbouiCOM.StaticText StaticText3;
        private SAPbouiCOM.EditText EditText0;
        private SAPbouiCOM.EditText EditText1;
        private SAPbouiCOM.EditText EditText2;
        private SAPbouiCOM.StaticText StaticText4;
        private SAPbouiCOM.ComboBox ComboBox0;
        private SAPbouiCOM.ComboBox ComboBox1;
        private SAPbouiCOM.StaticText StaticText5;
        private SAPbouiCOM.StaticText StaticText6;
        private SAPbouiCOM.EditText EditText3;
        private SAPbouiCOM.Button Button0;
        private SAPbouiCOM.Button Button1;
        private SAPbouiCOM.StaticText StaticText7;
        private SAPbouiCOM.StaticText StaticText8;
        private SAPbouiCOM.StaticText StaticText9;
        private SAPbouiCOM.StaticText StaticText10;
        private SAPbouiCOM.StaticText StaticText11;
        private SAPbouiCOM.StaticText StaticText12;
        private SAPbouiCOM.StaticText StaticText13;
        private SAPbouiCOM.StaticText StaticText14;
        private SAPbouiCOM.StaticText StaticText15;
        private SAPbouiCOM.StaticText StaticText16;
        private SAPbouiCOM.StaticText StaticText17;
        private SAPbouiCOM.StaticText StaticText18;
        private SAPbouiCOM.StaticText StaticText19;
        private SAPbouiCOM.StaticText StaticText20;
        private SAPbouiCOM.StaticText StaticText21;
        private SAPbouiCOM.ComboBox ComboBox2;
        private SAPbouiCOM.ComboBox ComboBox3;
        private SAPbouiCOM.ComboBox ComboBox4;
        private SAPbouiCOM.EditText EditText4;
        private SAPbouiCOM.EditText EditText5;
        private SAPbouiCOM.EditText EditText6;
        private SAPbouiCOM.EditText EditText7;
        private SAPbouiCOM.EditText EditText8;
        private SAPbouiCOM.EditText EditText9;

        private void EditText7_KeyDownAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private SAPbouiCOM.EditText EditText10;
        private SAPbouiCOM.EditText EditText11;
        private SAPbouiCOM.EditText EditText12;
        private SAPbouiCOM.EditText EditText13;
        private SAPbouiCOM.StaticText StaticText22;
        private SAPbouiCOM.StaticText StaticText23;
        private SAPbouiCOM.StaticText StaticText24;
        private SAPbouiCOM.StaticText StaticText25;
        private SAPbouiCOM.StaticText StaticText26;
        private SAPbouiCOM.StaticText StaticText27;
        private SAPbouiCOM.ComboBox ComboBox5;
        private SAPbouiCOM.ComboBox ComboBox6;
        private SAPbouiCOM.EditText EditText14;
        private SAPbouiCOM.ComboBox ComboBox7;
        private SAPbouiCOM.EditText EditText15;
        private SAPbouiCOM.EditText EditText16;
        private SAPbouiCOM.StaticText StaticText28;
        private SAPbouiCOM.StaticText StaticText29;
        private SAPbouiCOM.StaticText StaticText30;
        private SAPbouiCOM.StaticText StaticText31;
        private SAPbouiCOM.StaticText StaticText32;
        private SAPbouiCOM.StaticText StaticText33;
        private SAPbouiCOM.StaticText StaticText34;
        private SAPbouiCOM.ComboBox ComboBox8;
        private SAPbouiCOM.EditText EditText17;
        private SAPbouiCOM.ComboBox ComboBox9;
        private SAPbouiCOM.EditText EditText18;
        private SAPbouiCOM.EditText EditText19;
        private SAPbouiCOM.ComboBox ComboBox10;
        private SAPbouiCOM.StaticText StaticText35;
        private SAPbouiCOM.StaticText StaticText36;
        private SAPbouiCOM.EditText EditText20;
        private SAPbouiCOM.StaticText StaticText37;
        private SAPbouiCOM.StaticText StaticText38;
        private SAPbouiCOM.EditText EditText21;
        private SAPbouiCOM.StaticText StaticText39;
        private SAPbouiCOM.StaticText StaticText40;
        private SAPbouiCOM.EditText EditText22;
        private SAPbouiCOM.StaticText StaticText41;
        private SAPbouiCOM.StaticText StaticText42;
        private SAPbouiCOM.EditText EditText23;
        private SAPbouiCOM.EditText EditText24;
        private SAPbouiCOM.StaticText StaticText43;
        private SAPbouiCOM.StaticText StaticText44;
        private SAPbouiCOM.StaticText StaticText45;
        private SAPbouiCOM.StaticText StaticText46;
        private SAPbouiCOM.StaticText StaticText47;
        private SAPbouiCOM.StaticText StaticText48;
        private SAPbouiCOM.StaticText StaticText49;
        private SAPbouiCOM.StaticText StaticText50;
        private SAPbouiCOM.StaticText StaticText51;
        private SAPbouiCOM.StaticText StaticText52;
        private SAPbouiCOM.ComboBox ComboBox11;
        private SAPbouiCOM.ComboBox ComboBox12;
        private SAPbouiCOM.ComboBox ComboBox13;
        private SAPbouiCOM.ComboBox ComboBox14;
        private SAPbouiCOM.ComboBox ComboBox15;
        private SAPbouiCOM.ComboBox ComboBox16;
        private SAPbouiCOM.ComboBox ComboBox17;
        private SAPbouiCOM.ComboBox ComboBox18;
        private SAPbouiCOM.ComboBox ComboBox19;
        private SAPbouiCOM.StaticText StaticText53;
        private SAPbouiCOM.CheckBox CheckBox0;

        private void CheckBox0_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
           // throw new System.NotImplementedException();

        }

        private SAPbouiCOM.CheckBox CheckBox1;
        private SAPbouiCOM.CheckBox CheckBox2;
        private SAPbouiCOM.CheckBox CheckBox3;
        private SAPbouiCOM.CheckBox CheckBox4;
        private SAPbouiCOM.CheckBox CheckBox5;
        private SAPbouiCOM.CheckBox CheckBox6;
        private SAPbouiCOM.CheckBox CheckBox7;
        private SAPbouiCOM.CheckBox CheckBox8;
        private SAPbouiCOM.CheckBox CheckBox9;
        private SAPbouiCOM.CheckBox CheckBox10;
        private SAPbouiCOM.CheckBox CheckBox11;

        private void CheckBox11_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
           // throw new System.NotImplementedException();

        }

        private SAPbouiCOM.CheckBox CheckBox12;
        private SAPbouiCOM.CheckBox CheckBox13;
        private SAPbouiCOM.CheckBox CheckBox14;
        private SAPbouiCOM.CheckBox CheckBox15;
        private SAPbouiCOM.CheckBox CheckBox16;
        private SAPbouiCOM.CheckBox CheckBox17;
        private SAPbouiCOM.CheckBox CheckBox18;
        private SAPbouiCOM.CheckBox CheckBox19;
        private SAPbouiCOM.CheckBox CheckBox20;
        private SAPbouiCOM.CheckBox CheckBox21;
        private SAPbouiCOM.CheckBox CheckBox22;
        private SAPbouiCOM.CheckBox CheckBox23;
        private SAPbouiCOM.CheckBox CheckBox24;
        //private SAPbouiCOM.CheckBox CheckBox25;
        private SAPbouiCOM.CheckBox CheckBox26;
        private SAPbouiCOM.CheckBox CheckBox27;
        private SAPbouiCOM.CheckBox CheckBox28;
        private SAPbouiCOM.CheckBox CheckBox29;
        private SAPbouiCOM.CheckBox CheckBox30;
        private SAPbouiCOM.CheckBox CheckBox31;
        private SAPbouiCOM.CheckBox CheckBox32;
        private SAPbouiCOM.CheckBox CheckBox33;
        private SAPbouiCOM.CheckBox CheckBox34;
        private SAPbouiCOM.CheckBox CheckBox35;
        private SAPbouiCOM.CheckBox CheckBox36;

        private void CheckBox34_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            //throw new System.NotImplementedException();

        }

        private SAPbouiCOM.CheckBox CheckBox37;
        private SAPbouiCOM.CheckBox CheckBox38;
        private SAPbouiCOM.CheckBox CheckBox39;
        private SAPbouiCOM.CheckBox CheckBox40;
        private SAPbouiCOM.CheckBox CheckBox41;
        private SAPbouiCOM.CheckBox CheckBox42;
        private SAPbouiCOM.CheckBox CheckBox43;
        private SAPbouiCOM.CheckBox CheckBox44;
        private SAPbouiCOM.CheckBox CheckBox45;
        private SAPbouiCOM.CheckBox CheckBox46;
        private SAPbouiCOM.CheckBox CheckBox47;
        private SAPbouiCOM.CheckBox CheckBox48;
        private SAPbouiCOM.CheckBox CheckBox49;
        private SAPbouiCOM.CheckBox CheckBox50;
        private SAPbouiCOM.CheckBox CheckBox51;
        private SAPbouiCOM.CheckBox CheckBox52;
        private SAPbouiCOM.CheckBox CheckBox53;
        private SAPbouiCOM.CheckBox CheckBox54;
        private SAPbouiCOM.CheckBox CheckBox55;
        private SAPbouiCOM.CheckBox CheckBox56;
        private SAPbouiCOM.CheckBox CheckBox57;
        private SAPbouiCOM.CheckBox CheckBox58;
        private SAPbouiCOM.CheckBox CheckBox59;
        private SAPbouiCOM.CheckBox CheckBox60;
        private SAPbouiCOM.CheckBox CheckBox61;
        private SAPbouiCOM.CheckBox CheckBox62;
        private SAPbouiCOM.CheckBox CheckBox63;

        private void CheckBox21_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            //throw new System.NotImplementedException();

        }

        private void CheckBox29_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            //throw new System.NotImplementedException();

        }

        private SAPbouiCOM.StaticText StaticText54;
        private SAPbouiCOM.StaticText StaticText55;
        private SAPbouiCOM.StaticText StaticText56;
        private SAPbouiCOM.StaticText StaticText57;
        private SAPbouiCOM.EditText EditText25;
        private SAPbouiCOM.Button Button2;
        private SAPbouiCOM.EditText EditText26;
        private SAPbouiCOM.Button Button3;
        private SAPbouiCOM.EditText EditText27;
        private SAPbouiCOM.Button Button4;
        private SAPbouiCOM.StaticText StaticText58;
        private SAPbouiCOM.EditText EditText28;
        private SAPbouiCOM.Button Button5;
        private SAPbouiCOM.StaticText StaticText59;
        private SAPbouiCOM.StaticText StaticText60;
        private SAPbouiCOM.EditText EditText29;
        private SAPbouiCOM.EditText EditText30;
        private SAPbouiCOM.Button Button6;
        private SAPbouiCOM.Button Button7;

        private void Button2_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            Thread t = new Thread(() =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                DialogResult dr = openFileDialog.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string filename = openFileDialog.FileName;
                    this.EditText25.Value = filename;
                }
            });
            t.IsBackground = true;
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            //throw new System.NotImplementedException();

        }

        private void Button3_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            Thread t = new Thread(() =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                DialogResult dr = openFileDialog.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string filename = openFileDialog.FileName;
                    this.EditText26.Value = filename;
                }
            });
            t.IsBackground = true;
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

        }

        private void Button4_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            Thread t = new Thread(() =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                DialogResult dr = openFileDialog.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string filename = openFileDialog.FileName;
                    this.EditText27.Value = filename;
                }
            });
            t.IsBackground = true;
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

        }

        private void Button5_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            Thread t = new Thread(() =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                DialogResult dr = openFileDialog.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string filename = openFileDialog.FileName;
                    this.EditText28.Value = filename;
                }
            });
            t.IsBackground = true;
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

        }

        private void Button6_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            Thread t = new Thread(() =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                DialogResult dr = openFileDialog.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string filename = openFileDialog.FileName;
                    this.EditText29.Value = filename;
                }
            });
            t.IsBackground = true;
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

        }

        private void Button7_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            Thread t = new Thread(() =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                DialogResult dr = openFileDialog.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string filename = openFileDialog.FileName;
                    this.EditText30.Value = filename;
                }
            });
            t.IsBackground = true;
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

        }

        private void CheckBox48_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            //throw new System.NotImplementedException();

        }

        private void Button0_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            //throw new System.NotImplementedException();

        }

        private void Button0_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            try
            {
                if (pVal.ActionSuccess && pVal.InnerEvent)
                {
                   
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            //throw new System.NotImplementedException();

        }

        private void Form_DataAddAfter(ref SAPbouiCOM.BusinessObjectInfo pVal)
        {
            if (pVal.ActionSuccess)
            {
                SAPbouiCOM.Matrix Matrix3 = (SAPbouiCOM.Matrix)clsModule.objaddon.ActualForm.Items.Item("38").Specific;
                ((SAPbouiCOM.EditText)Matrix3.Columns.Item("U_udtNum").Cells.Item(rowNo).Specific).Value = objform.DataSources.DBDataSources.Item("@FANDETAIL").GetValue("DocEntry", 0);

               // ((SAPbouiCOM.EditText)Matrix3.Columns.Item("U_udtNum").Cells.Item(rowNo).Specific).Value = objform.DataSources.DBDataSources.Item("@FANDETAIL").GetValue("DocEntry", 0);
                //objform.Mode = SAPbouiCOM.BoFormMode.fm_OK_MODE;
                //objform.Close();

              //  objform.Items.Item("2").Click();
                
            }

        }

        private void Button1_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
         

        }

        private void Button1_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
          //  objform.Close();

        }

        private void Button0_PressedAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            objform.Close();
            //throw new System.NotImplementedException();

        }
    }
}
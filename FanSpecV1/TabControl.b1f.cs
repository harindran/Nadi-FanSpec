using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbouiCOM.Framework;

namespace FanSpecV1
{
    [FormAttribute("149", "TabControl.b1f")]
    class TabControl : SystemFormBase
    {
        public static SAPbouiCOM.Form objform;
        public TabControl()
        {
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.Folder0 = ((SAPbouiCOM.Folder)(this.GetItem("Item_0").Specific));
            this.Folder0.PressedAfter += new SAPbouiCOM._IFolderEvents_PressedAfterEventHandler(this.Folder0_PressedAfter);
            this.EditText1 = ((SAPbouiCOM.EditText)(this.GetItem("Item_2").Specific));
            this.EditText2 = ((SAPbouiCOM.EditText)(this.GetItem("46").Specific));
            this.EditText2.KeyDownAfter += new SAPbouiCOM._IEditTextEvents_KeyDownAfterEventHandler(this.EditText2_KeyDownAfter);
            this.StaticText1 = ((SAPbouiCOM.StaticText)(this.GetItem("stopphd").Specific));
            this.StaticText2 = ((SAPbouiCOM.StaticText)(this.GetItem("stopid").Specific));
            this.StaticText3 = ((SAPbouiCOM.StaticText)(this.GetItem("stlcno").Specific));
            this.StaticText4 = ((SAPbouiCOM.StaticText)(this.GetItem("stlrd").Specific));
            this.StaticText5 = ((SAPbouiCOM.StaticText)(this.GetItem("stoppno").Specific));
            this.StaticText6 = ((SAPbouiCOM.StaticText)(this.GetItem("stctype").Specific));
            this.StaticText7 = ((SAPbouiCOM.StaticText)(this.GetItem("sthaby").Specific));
            this.StaticText8 = ((SAPbouiCOM.StaticText)(this.GetItem("stdoex").Specific));
            this.StaticText9 = ((SAPbouiCOM.StaticText)(this.GetItem("stepv").Specific));
            this.StaticText10 = ((SAPbouiCOM.StaticText)(this.GetItem("stedm").Specific));
            this.StaticText11 = ((SAPbouiCOM.StaticText)(this.GetItem("stccat").Specific));
            this.StaticText12 = ((SAPbouiCOM.StaticText)(this.GetItem("stlcda").Specific));
            this.StaticText13 = ((SAPbouiCOM.StaticText)(this.GetItem("stopda").Specific));
            this.StaticText14 = ((SAPbouiCOM.StaticText)(this.GetItem("stsp").Specific));
            this.StaticText15 = ((SAPbouiCOM.StaticText)(this.GetItem("stlnat").Specific));
            this.StaticText16 = ((SAPbouiCOM.StaticText)(this.GetItem("stlsmod").Specific));
            this.StaticText17 = ((SAPbouiCOM.StaticText)(this.GetItem("stopsta").Specific));
            this.EditText4 = ((SAPbouiCOM.EditText)(this.GetItem("etopid").Specific));
            this.EditText5 = ((SAPbouiCOM.EditText)(this.GetItem("et").Specific));
            this.EditText5.KeyDownAfter += new SAPbouiCOM._IEditTextEvents_KeyDownAfterEventHandler(this.EditText5_KeyDownAfter);
            this.EditText6 = ((SAPbouiCOM.EditText)(this.GetItem("etlcda").Specific));
            this.EditText6.KeyDownAfter += new SAPbouiCOM._IEditTextEvents_KeyDownAfterEventHandler(this.EditText6_KeyDownAfter);
            this.EditText8 = ((SAPbouiCOM.EditText)(this.GetItem("Item_11").Specific));
            this.EditText9 = ((SAPbouiCOM.EditText)(this.GetItem("etopno").Specific));
            this.EditText10 = ((SAPbouiCOM.EditText)(this.GetItem("Item_6").Specific));
            this.ComboBox0 = ((SAPbouiCOM.ComboBox)(this.GetItem("cctype").Specific));
            this.ComboBox1 = ((SAPbouiCOM.ComboBox)(this.GetItem("clsmod").Specific));
            this.EditText11 = ((SAPbouiCOM.EditText)(this.GetItem("etsp").Specific));
            this.EditText12 = ((SAPbouiCOM.EditText)(this.GetItem("ethaby").Specific));
            this.ComboBox2 = ((SAPbouiCOM.ComboBox)(this.GetItem("clnat").Specific));
            this.ComboBox3 = ((SAPbouiCOM.ComboBox)(this.GetItem("copsta").Specific));
            this.ComboBox4 = ((SAPbouiCOM.ComboBox)(this.GetItem("cdomex").Specific));
            this.StaticText18 = ((SAPbouiCOM.StaticText)(this.GetItem("stvaldat").Specific));
            this.EditText13 = ((SAPbouiCOM.EditText)(this.GetItem("etvalda").Specific));
            this.EditText14 = ((SAPbouiCOM.EditText)(this.GetItem("etepv").Specific));
            this.StaticText19 = ((SAPbouiCOM.StaticText)(this.GetItem("stetype").Specific));
            this.ComboBox5 = ((SAPbouiCOM.ComboBox)(this.GetItem("cetype").Specific));
            this.StaticText20 = ((SAPbouiCOM.StaticText)(this.GetItem("stempo").Specific));
            this.StaticText21 = ((SAPbouiCOM.StaticText)(this.GetItem("strtype").Specific));
            this.ComboBox6 = ((SAPbouiCOM.ComboBox)(this.GetItem("crtype").Specific));
            this.ComboBox7 = ((SAPbouiCOM.ComboBox)(this.GetItem("cccat").Specific));
            this.EditText15 = ((SAPbouiCOM.EditText)(this.GetItem("etedm").Specific));
            this.EditText16 = ((SAPbouiCOM.EditText)(this.GetItem("etempo").Specific));
            this.EditText16.KeyDownAfter += new SAPbouiCOM._IEditTextEvents_KeyDownAfterEventHandler(this.EditText16_KeyDownAfter);
            this.StaticText22 = ((SAPbouiCOM.StaticText)(this.GetItem("stcdet").Specific));
            this.StaticText23 = ((SAPbouiCOM.StaticText)(this.GetItem("stcnam").Specific));
            this.EditText17 = ((SAPbouiCOM.EditText)(this.GetItem("etcnam").Specific));
            this.StaticText24 = ((SAPbouiCOM.StaticText)(this.GetItem("stccod").Specific));
            this.EditText18 = ((SAPbouiCOM.EditText)(this.GetItem("etccod").Specific));
            this.StaticText26 = ((SAPbouiCOM.StaticText)(this.GetItem("stcper").Specific));
            this.StaticText27 = ((SAPbouiCOM.StaticText)(this.GetItem("stcpph").Specific));
            this.StaticText28 = ((SAPbouiCOM.StaticText)(this.GetItem("stcprol").Specific));
            this.StaticText29 = ((SAPbouiCOM.StaticText)(this.GetItem("stapp").Specific));
            this.StaticText30 = ((SAPbouiCOM.StaticText)(this.GetItem("stecus").Specific));
            this.StaticText31 = ((SAPbouiCOM.StaticText)(this.GetItem("sQsu").Specific));
            this.StaticText33 = ((SAPbouiCOM.StaticText)(this.GetItem("stqid").Specific));
            this.StaticText34 = ((SAPbouiCOM.StaticText)(this.GetItem("stdes").Specific));
            this.EditText19 = ((SAPbouiCOM.EditText)(this.GetItem("etedesc").Specific));
            this.EditText20 = ((SAPbouiCOM.EditText)(this.GetItem("etqid").Specific));
            this.StaticText35 = ((SAPbouiCOM.StaticText)(this.GetItem("stdat").Specific));
            this.EditText21 = ((SAPbouiCOM.EditText)(this.GetItem("etqdat").Specific));
            this.StaticText36 = ((SAPbouiCOM.StaticText)(this.GetItem("ststot").Specific));
            this.EditText22 = ((SAPbouiCOM.EditText)(this.GetItem("etstot").Specific));
            this.StaticText37 = ((SAPbouiCOM.StaticText)(this.GetItem("stdtot").Specific));
            this.EditText23 = ((SAPbouiCOM.EditText)(this.GetItem("etditot").Specific));
            this.StaticText38 = ((SAPbouiCOM.StaticText)(this.GetItem("sttato").Specific));
            this.EditText24 = ((SAPbouiCOM.EditText)(this.GetItem("ettatot").Specific));
            this.EditText24.KeyDownAfter += new SAPbouiCOM._IEditTextEvents_KeyDownAfterEventHandler(this.EditText24_KeyDownAfter);
            this.StaticText39 = ((SAPbouiCOM.StaticText)(this.GetItem("stntot").Specific));
            this.StaticText40 = ((SAPbouiCOM.StaticText)(this.GetItem("stcter").Specific));
            this.EditText25 = ((SAPbouiCOM.EditText)(this.GetItem("etntot").Specific));
            this.EditText26 = ((SAPbouiCOM.EditText)(this.GetItem("etcpp").Specific));
            this.EditText27 = ((SAPbouiCOM.EditText)(this.GetItem("etcprol").Specific));
            this.EditText28 = ((SAPbouiCOM.EditText)(this.GetItem("etapp").Specific));
            this.EditText29 = ((SAPbouiCOM.EditText)(this.GetItem("etecus").Specific));
            this.EditText30 = ((SAPbouiCOM.EditText)(this.GetItem("etqsub").Specific));
            this.StaticText41 = ((SAPbouiCOM.StaticText)(this.GetItem("stcpma").Specific));
            this.EditText31 = ((SAPbouiCOM.EditText)(this.GetItem("etcpma").Specific));
            this.StaticText42 = ((SAPbouiCOM.StaticText)(this.GetItem("stapno").Specific));
            this.EditText32 = ((SAPbouiCOM.EditText)(this.GetItem("etapno").Specific));
            this.EditText33 = ((SAPbouiCOM.EditText)(this.GetItem("etcter").Specific));
            this.CheckBox0 = ((SAPbouiCOM.CheckBox)(this.GetItem("chkequ").Specific));
            this.StaticText43 = ((SAPbouiCOM.StaticText)(this.GetItem("stcpdes").Specific));
            this.StaticText44 = ((SAPbouiCOM.StaticText)(this.GetItem("sttind").Specific));
            this.EditText34 = ((SAPbouiCOM.EditText)(this.GetItem("etcp").Specific));
            this.StaticText45 = ((SAPbouiCOM.StaticText)(this.GetItem("stcpna").Specific));
            this.EditText35 = ((SAPbouiCOM.EditText)(this.GetItem("etcpdes").Specific));
            this.EditText36 = ((SAPbouiCOM.EditText)(this.GetItem("etcpna").Specific));
            this.ComboBox8 = ((SAPbouiCOM.ComboBox)(this.GetItem("ctind").Specific));
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
            this.LoadAfter += new LoadAfterHandler(this.Form_LoadAfter);

        }

        private SAPbouiCOM.Folder Folder0;

        private void OnCustomInitialize()
        {
            try
            {
                objform = clsModule.objaddon.objapplication.Forms.GetForm("149", 1);
                //objform = clsModule.objaddon.objapplication.Forms.ActiveForm;
                Folder0.GroupWith("256000695");
                //Folder0.Item.Left = objform.Items.Item("256000695").Left + objform.Items.Item("256000695").Width;
                objform.Items.Item("Item_0").Left = objform.Items.Item("1320002137").Left;
            }
            catch (Exception ex)
            {

            }
           
        }

        private void Form_LoadAfter(SAPbouiCOM.SBOItemEventArg pVal)
        {
            //objform.Items.Item("stopphd").Top = objform.Items.Item("62").Top;
            //objform.Items.Item("stopphd").Top = objform.Items.Item("62").Top + objform.Items.Item("62").Height + 5;
            //objform = clsModule.objaddon.objapplication.Forms.GetForm("149",pVal.FormTypeCount);
            //objform.PaneLevel = 26;
            //throw new System.NotImplementedException();

            
            
        }

        private SAPbouiCOM.EditText EditText1;
        private SAPbouiCOM.EditText EditText2;

        private void EditText2_KeyDownAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
           // throw new System.NotImplementedException();

        }

        private void Folder0_PressedAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            try
            {
                objform.PaneLevel = 26;
            }
            catch (Exception ex)
            {

                //throw;
            }

        }
        private SAPbouiCOM.StaticText StaticText1;
        private SAPbouiCOM.StaticText StaticText2;
        private SAPbouiCOM.StaticText StaticText3;
        private SAPbouiCOM.StaticText StaticText4;
        private SAPbouiCOM.StaticText StaticText5;
        private SAPbouiCOM.StaticText StaticText6;
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
        private SAPbouiCOM.EditText EditText4;
        private SAPbouiCOM.EditText EditText5;
        private SAPbouiCOM.EditText EditText6;
        private SAPbouiCOM.EditText EditText8;
        private SAPbouiCOM.EditText EditText9;
        private SAPbouiCOM.EditText EditText10;
        private SAPbouiCOM.ComboBox ComboBox0;
        private SAPbouiCOM.ComboBox ComboBox1;
        private SAPbouiCOM.EditText EditText11;
        private SAPbouiCOM.EditText EditText12;
        private SAPbouiCOM.ComboBox ComboBox2;
        private SAPbouiCOM.ComboBox ComboBox3;
        private SAPbouiCOM.ComboBox ComboBox4;
        private SAPbouiCOM.StaticText StaticText18;
        private SAPbouiCOM.EditText EditText13;
        private SAPbouiCOM.EditText EditText14;
        private SAPbouiCOM.StaticText StaticText19;
        private SAPbouiCOM.ComboBox ComboBox5;
        private SAPbouiCOM.StaticText StaticText20;
        private SAPbouiCOM.StaticText StaticText21;
        private SAPbouiCOM.ComboBox ComboBox6;
        private SAPbouiCOM.ComboBox ComboBox7;
        private SAPbouiCOM.EditText EditText15;
        private SAPbouiCOM.EditText EditText16;

        private void EditText16_KeyDownAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private SAPbouiCOM.StaticText StaticText22;
        private SAPbouiCOM.StaticText StaticText23;
        private SAPbouiCOM.EditText EditText17;
        private SAPbouiCOM.StaticText StaticText24;
        private SAPbouiCOM.EditText EditText18;
        private SAPbouiCOM.StaticText StaticText26;
        private SAPbouiCOM.StaticText StaticText27;
        private SAPbouiCOM.StaticText StaticText28;
        private SAPbouiCOM.StaticText StaticText29;
        private SAPbouiCOM.StaticText StaticText30;
        private SAPbouiCOM.StaticText StaticText31;
        private SAPbouiCOM.StaticText StaticText33;
        private SAPbouiCOM.StaticText StaticText34;
        private SAPbouiCOM.EditText EditText19;
        private SAPbouiCOM.EditText EditText20;
        private SAPbouiCOM.StaticText StaticText35;
        private SAPbouiCOM.EditText EditText21;
        private SAPbouiCOM.StaticText StaticText36;
        private SAPbouiCOM.EditText EditText22;
        private SAPbouiCOM.StaticText StaticText37;
        private SAPbouiCOM.EditText EditText23;
        private SAPbouiCOM.StaticText StaticText38;
        private SAPbouiCOM.EditText EditText24;
        private SAPbouiCOM.StaticText StaticText39;
        private SAPbouiCOM.StaticText StaticText40;
        private SAPbouiCOM.EditText EditText25;
        private SAPbouiCOM.EditText EditText26;
        private SAPbouiCOM.EditText EditText27;
        private SAPbouiCOM.EditText EditText28;
        private SAPbouiCOM.EditText EditText29;
        private SAPbouiCOM.EditText EditText30;
        private SAPbouiCOM.StaticText StaticText41;
        private SAPbouiCOM.EditText EditText31;
        private SAPbouiCOM.StaticText StaticText42;
        private SAPbouiCOM.EditText EditText32;
        private SAPbouiCOM.EditText EditText33;
        private SAPbouiCOM.CheckBox CheckBox0;
        private SAPbouiCOM.StaticText StaticText43;
        private SAPbouiCOM.StaticText StaticText44;
        private SAPbouiCOM.EditText EditText34;
        private SAPbouiCOM.StaticText StaticText45;
        private SAPbouiCOM.EditText EditText35;
        private SAPbouiCOM.EditText EditText36;
        private SAPbouiCOM.ComboBox ComboBox8;

        private void EditText6_KeyDownAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText5_KeyDownAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText24_KeyDownAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }
    }
}

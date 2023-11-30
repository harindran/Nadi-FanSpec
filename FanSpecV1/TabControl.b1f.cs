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
            this.EditText0 = ((SAPbouiCOM.EditText)(this.GetItem("Item_1").Specific));
            this.EditText1 = ((SAPbouiCOM.EditText)(this.GetItem("Item_2").Specific));
            this.EditText2 = ((SAPbouiCOM.EditText)(this.GetItem("46").Specific));
            this.EditText2.KeyDownAfter += new SAPbouiCOM._IEditTextEvents_KeyDownAfterEventHandler(this.EditText2_KeyDownAfter);
            this.StaticText0 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_3").Specific));
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
            this.StaticText11 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_14").Specific));
            this.StaticText12 = ((SAPbouiCOM.StaticText)(this.GetItem("stlcda").Specific));
            this.StaticText13 = ((SAPbouiCOM.StaticText)(this.GetItem("stopda").Specific));
            this.StaticText14 = ((SAPbouiCOM.StaticText)(this.GetItem("stsp").Specific));
            this.StaticText15 = ((SAPbouiCOM.StaticText)(this.GetItem("stlnat").Specific));
            this.StaticText16 = ((SAPbouiCOM.StaticText)(this.GetItem("stlsmod").Specific));
            this.StaticText17 = ((SAPbouiCOM.StaticText)(this.GetItem("stopsta").Specific));
            this.EditText3 = ((SAPbouiCOM.EditText)(this.GetItem("Item_4").Specific));
            this.EditText4 = ((SAPbouiCOM.EditText)(this.GetItem("etopid").Specific));
            this.EditText5 = ((SAPbouiCOM.EditText)(this.GetItem("et").Specific));
            this.EditText6 = ((SAPbouiCOM.EditText)(this.GetItem("etlcda").Specific));
            this.EditText7 = ((SAPbouiCOM.EditText)(this.GetItem("Item_10").Specific));
            this.EditText8 = ((SAPbouiCOM.EditText)(this.GetItem("Item_11").Specific));
            this.EditText9 = ((SAPbouiCOM.EditText)(this.GetItem("etopno").Specific));
            this.EditText10 = ((SAPbouiCOM.EditText)(this.GetItem("Item_6").Specific));
            this.ComboBox0 = ((SAPbouiCOM.ComboBox)(this.GetItem("cctype").Specific));
            this.ComboBox1 = ((SAPbouiCOM.ComboBox)(this.GetItem("clsmod").Specific));
            this.EditText11 = ((SAPbouiCOM.EditText)(this.GetItem("etsp").Specific));
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
                Folder0.Item.Left = objform.Items.Item("256000695").Left + objform.Items.Item("256000695").Width;
            }
            catch (Exception ex)
            {

            }
           
        }

        private void Form_LoadAfter(SAPbouiCOM.SBOItemEventArg pVal)
        {
            //objform = clsModule.objaddon.objapplication.Forms.GetForm("149",pVal.FormTypeCount);
            //objform.PaneLevel = 26;
            //throw new System.NotImplementedException();

        }


        private SAPbouiCOM.EditText EditText0;
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

        private SAPbouiCOM.StaticText StaticText0;
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
        private SAPbouiCOM.EditText EditText3;
        private SAPbouiCOM.EditText EditText4;
        private SAPbouiCOM.EditText EditText5;
        private SAPbouiCOM.EditText EditText6;
        private SAPbouiCOM.EditText EditText7;
        private SAPbouiCOM.EditText EditText8;
        private SAPbouiCOM.EditText EditText9;
        private SAPbouiCOM.EditText EditText10;
        private SAPbouiCOM.ComboBox ComboBox0;
        private SAPbouiCOM.ComboBox ComboBox1;
        private SAPbouiCOM.EditText EditText11;
    }
}

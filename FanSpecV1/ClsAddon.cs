﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAPbouiCOM.Framework;
namespace FanSpecV1
{
    class ClsAddon
    {
        public SAPbouiCOM.Application objapplication;
        public SAPbobsCOM.Company objcompany;
        public clsMenuEvent objmenuevent;
        public clsRightClickEvent objrightclickevent;
        //public clsGlobalMethods objglobalmethods;
        public SAPbouiCOM.Form objform;
        public SAPbouiCOM.Form ActualForm;
        string strsql = "";
        private SAPbobsCOM.Recordset objrs;
        bool print_close = false;
        public bool HANA = true;
        public string[] HWKEY = { "L1653539483", "X1211807750", "A0459115566" };
        public ClsAddon()
        {

        }
    public void Intialize(string[] args)
    {
        try
        {
            Application oapplication;
            if ((args.Length < 1))
                oapplication = new Application();
            else
                oapplication = new Application(args[0]);
            objapplication = Application.SBO_Application;
            if (isValidLicense())
            {
                objapplication.StatusBar.SetText("Establishing Company Connection Please Wait...", SAPbouiCOM.BoMessageTime.bmt_Long, SAPbouiCOM.BoStatusBarMessageType.smt_Warning);
                objcompany = (SAPbobsCOM.Company)Application.SBO_Application.Company.GetDICompany();

                Create_DatabaseFields(); // UDF & UDO Creation Part
                Menu(); // Menu Creation Part
                Create_Objects(); // Object Creation Part

                objapplication.AppEvent += new SAPbouiCOM._IApplicationEvents_AppEventEventHandler(objapplication_AppEvent);
                objapplication.MenuEvent += new SAPbouiCOM._IApplicationEvents_MenuEventEventHandler(objapplication_MenuEvent);
                objapplication.ItemEvent += new SAPbouiCOM._IApplicationEvents_ItemEventEventHandler(objapplication_ItemEvent);
                objapplication.FormDataEvent += new SAPbouiCOM._IApplicationEvents_FormDataEventEventHandler(ref FormDataEvent);
                //objapplication.ProgressBarEvent += new SAPbouiCOM._IApplicationEvents_ProgressBarEventEventHandler(objapplication_ProgressBarEvent);
                //objapplication.StatusBarEvent += new SAPbouiCOM._IApplicationEvents_StatusBarEventEventHandler(objapplication_StatusBarEvent);
                objapplication.RightClickEvent += new SAPbouiCOM._IApplicationEvents_RightClickEventEventHandler(objapplication_RightClickEvent);

                objapplication.StatusBar.SetText("Addon Connected Successfully..!!!", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success);
                oapplication.Run();
            }
            else
            {
                objapplication.StatusBar.SetText("Addon Disconnected due to license mismatch..!!!", SAPbouiCOM.BoMessageTime.bmt_Medium, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
                return;
                //throw new Exception(objcompany.GetLastErrorDescription());
            }
        }
        // System.Windows.Forms.Application.Run()
        catch (Exception ex)
        {
            objapplication.SetStatusBarMessage(ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, true);
        }
    }
    public bool isValidLicense()
    {
        try
        {
            if (HANA)
            {
                try
                {
                    if (objapplication.Forms.ActiveForm.TypeCount > 0)
                    {
                        for (int i = 0; i <= objapplication.Forms.ActiveForm.TypeCount - 1; i++)
                            objapplication.Forms.ActiveForm.Close();
                    }
                }
                catch (Exception ex)
                {
                }
            }
            // If Not HANA Then
            // objapplication.Menus.Item("1030").Activate()
            // End If
            objapplication.Menus.Item("257").Activate();
            SAPbouiCOM.EditText objedit = (SAPbouiCOM.EditText)objapplication.Forms.ActiveForm.Items.Item("79").Specific;

            string CrrHWKEY = objedit.Value.ToString();
            objapplication.Forms.ActiveForm.Close();

            for (int i = 0; i <= HWKEY.Length - 1; i++)
            {
                //string key = HWKEY[i];
                if (HWKEY[i] == CrrHWKEY)
                {
                    return true;
                }

            }

            System.Windows.Forms.MessageBox.Show("Installing Add-On failed due to License mismatch");
            //objapplication.MessageBox("Installing Add-On failed due to License mismatch", 1, "Ok", "", "");
            //Interaction.MsgBox("Installing Add-On failed due to License mismatch", MsgBoxStyle.OkOnly, "License Management");

            return false;
        }
        catch (Exception ex)
        {
            objapplication.StatusBar.SetText(ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Warning);
        }
        return true;
    }
    public void Create_Objects()
    {
        objmenuevent = new clsMenuEvent();
        objrightclickevent = new clsRightClickEvent();
        //objglobalmethods = new clsGlobalMethods();

    }
    private void Create_DatabaseFields()
    {
        // If objapplication.Company.UserName.ToString.ToUpper <> "MANAGER" Then

        // If objapplication.MessageBox("Do you want to execute the field Creations?", 2, "Yes", "No") <> 1 Then Exit Sub
        objapplication.StatusBar.SetText("Creating Database Fields.Please Wait...", SAPbouiCOM.BoMessageTime.bmt_Long, SAPbouiCOM.BoStatusBarMessageType.smt_Warning);

        var objtable = new clsTable();
        objtable.FieldCreation();
        // End If

    }
    private void Menu()
    {
        int Menucount = 1;
        if (objapplication.Menus.Item("2048").SubMenus.Exists("FanSpecV1"))
            return;
        Menucount = 10;// objapplication.Menus.Item("8448").SubMenus.Count;
                       // CreateMenu("", Menucount, "Check Print", SAPbouiCOM.BoMenuType.mt_POPUP, "CHKPRT", "43520")
        //CreateMenu("", Menucount, " FanSpecV1", SAPbouiCOM.BoMenuType.mt_STRING, "FanSpecV1", "2048");
        //Menucount += 1; // "43537"

        // CreateMenu("", Menucount, "Tank Master", SAPbouiCOM.BoMenuType.mt_STRING, "TNKMSTR", "4352") : Menucount += 1

    }

    private void CreateMenu(string ImagePath, int Position, string DisplayName, SAPbouiCOM.BoMenuType MenuType, string UniqueID, string ParentMenuID)
    {
        try
        {
            SAPbouiCOM.MenuCreationParams oMenuPackage;
            SAPbouiCOM.MenuItem parentmenu;
            parentmenu = objapplication.Menus.Item(ParentMenuID);
            if (parentmenu.SubMenus.Exists(UniqueID.ToString()))
                return;
            oMenuPackage = (SAPbouiCOM.MenuCreationParams)objapplication.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_MenuCreationParams);
            oMenuPackage.Image = ImagePath;
            oMenuPackage.Position = Position;
            oMenuPackage.Type = MenuType;
            oMenuPackage.UniqueID = UniqueID;
            oMenuPackage.String = DisplayName;
            parentmenu.SubMenus.AddEx(oMenuPackage);
        }
        catch (Exception ex)
        {
            objapplication.StatusBar.SetText("Menu Already Exists", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_None);
        }
        // Return ParentMenu.SubMenus.Item(UniqueID)
    }



    public bool FormExist(string FormID)
    {
        bool FormExistRet = false;
        try
        {
            FormExistRet = false;
            foreach (SAPbouiCOM.Form uid in clsModule.objaddon.objapplication.Forms)
            {
                if (uid.TypeEx == FormID)
                {
                    FormExistRet = true;
                    break;
                }
            }
            if (FormExistRet)
            {
                clsModule.objaddon.objapplication.Forms.Item(FormID).Visible = true;
                clsModule.objaddon.objapplication.Forms.Item(FormID).Select();
            }
        }
        catch (Exception ex)
        {
            clsModule.objaddon.objapplication.StatusBar.SetText(ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error);
        }

        return FormExistRet;

    }
    private void objapplication_ItemEvent(string FormUID, ref SAPbouiCOM.ItemEvent pVal, out bool BubbleEvent)
    {
        BubbleEvent = true;
        try
        {
            switch (pVal.FormTypeEx)
            {
                case "":
                    //objInvoice.Item_Event(FormUID, ref pVal,ref BubbleEvent);
                    break;

            }

            if (pVal.BeforeAction)
            {
                {
                        switch (pVal.EventType)
                        {
                            case SAPbouiCOM.BoEventTypes.et_FORM_CLOSE:
                                {
                                    SAPbouiCOM.BoEventTypes EventEnum;
                                    EventEnum = pVal.EventType;
                                    if (FormUID == "UDEV000005" & EventEnum == SAPbouiCOM.BoEventTypes.et_FORM_CLOSE)
                                    {
                                        //bModal = false;
                                    }
                                    break;
                                }
                            case SAPbouiCOM.BoEventTypes.et_FORM_LOAD:
                                {
                                    break;
                                }
                            case SAPbouiCOM.BoEventTypes.et_COMBO_SELECT:
                                {
                                    break;
                                }
                            
                        }
               }

            }
            else
            {
                switch (pVal.EventType)
                {
                    case SAPbouiCOM.BoEventTypes.et_FORM_LOAD:
                        {
                            break;
                        }
                }
            }

        }
        catch (Exception ex)
        {
            //objapplication.StatusBar.SetText("objapplication_ItemEvent" + ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Warning);
        }


    }
    private void FormDataEvent(ref SAPbouiCOM.BusinessObjectInfo BusinessObjectInfo, out bool BubbleEvent)
    {
        BubbleEvent = true;
        try
        {
            switch (BusinessObjectInfo.FormTypeEx)
            {
                case ""://ClsARInvoice.Formtype:                    
                        //objInvoice.FormData_Event(ref BusinessObjectInfo, ref BubbleEvent);
                    break;


            }
        }
        catch (Exception)
        {

            //throw;
        }


    }


    #region MenuEvent

    private void objapplication_MenuEvent(ref SAPbouiCOM.MenuEvent pVal, out bool BubbleEvent)
    {

        BubbleEvent = true;
        switch (pVal.MenuUID)
        {
            case "1281":
            case "1282":
            case "1283":
            case "1284":
            case "1285":
            case "1286":
            case "1287":
            case "1300":
            case "1288":
            case "1289":
            case "1290":
            case "1291":
            case "1304":
            case "1292":
            case "1293":
                objmenuevent.MenuEvent_For_StandardMenu(ref pVal, ref BubbleEvent);
                break;
            case "FanSpec":

                MenuEvent_For_FormOpening(ref pVal, ref BubbleEvent);//open for menu
                break;

        }


    }


    public void MenuEvent_For_FormOpening(ref SAPbouiCOM.MenuEvent pVal, ref bool BubbleEvent)
    {
        try
        {
            if (pVal.BeforeAction == false)
            {
                switch (pVal.MenuUID)
                {
                    case "FanSpec":
                        {
                                clsModule.objaddon.ActualForm = clsModule.objaddon.objapplication.Forms.ActiveForm;

                              
                                Form1 activeform = new Form1();
                                SAPbouiCOM.Form objform = clsModule.objaddon.ActualForm;
                                SAPbouiCOM.Matrix Matrix3 = (SAPbouiCOM.Matrix)objform.Items.Item("38").Specific;
                                int selectrow = Matrix3.GetNextSelectedRow(0, SAPbouiCOM.BoOrderType.ot_RowOrder);
                                activeform.rowNo = selectrow;
                             

                                // Form1 activeform = new Form1();
                                //activeform.Show();
                                break;
                        }
                }

            }
        }
        catch (Exception ex)
        {
            // objaddon.objapplication.SetStatusBarMessage("Error in Form Opening MenuEvent" + ex.ToString, SAPbouiCOM.BoMessageTime.bmt_Medium, True)
        }
    }

    #endregion

    #region RightClickEvent

    private void objapplication_RightClickEvent(ref SAPbouiCOM.ContextMenuInfo eventInfo, out bool BubbleEvent)
    {
        BubbleEvent = true;
        try
        {
            switch (objapplication.Forms.ActiveForm.TypeEx)
            {
                case "149":
                    objrightclickevent.RightClickEvent(ref eventInfo, ref BubbleEvent);
                    break;
            }

        }
        catch (Exception ex) { }

    }

    #endregion

    #region AppEvent

    private void objapplication_AppEvent(SAPbouiCOM.BoAppEventTypes EventType)
    {
        switch (EventType)
        {
            case SAPbouiCOM.BoAppEventTypes.aet_ShutDown:
            case SAPbouiCOM.BoAppEventTypes.aet_CompanyChanged:
            case SAPbouiCOM.BoAppEventTypes.aet_LanguageChanged:
                //objapplication.MessageBox("A Shut Down Event has been caught" + Environment.NewLine + "Terminating Add On...", 1, "Ok", "", "");
                try
                {
                    System.Windows.Forms.Application.Exit();
                    if (objapplication != null)
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(objapplication);
                    if (objcompany != null)
                    {
                        if (objcompany.Connected)
                            objcompany.Disconnect();
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(objcompany);
                    }
                    GC.Collect();
                    //Environment.Exit(0);
                }
                catch (Exception ex)
                {
                }
                break;

        }
    }

    #endregion

}
}

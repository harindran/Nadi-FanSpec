using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanSpecV1
{
    class clsRightClickEvent
    {
        SAPbouiCOM.Form objform;
        //clsGlobalMethods objglobalMethods = new clsGlobalMethods();
        

        public void RightClickEvent(ref SAPbouiCOM.ContextMenuInfo eventInfo, ref bool BubbleEvent)
        {
            try
            {
                switch (clsModule.objaddon.objapplication.Forms.ActiveForm.TypeEx)
                {
                    case "149":
                        if (eventInfo.ItemUID == "38")
                        {

                            RightClickMenu_Add("1280", "FanSpec", "Fan Spec", 2);
                            
                        }
                        else
                        {

                            RightClickMenu_Delete("1280", "FanSpec");
                        }
                        break;
                    default:

                        RightClickMenu_Delete("1280", "FanSpec");
                        break;
                }
            }
            catch (Exception ex)
            {
            }

        }

        private void RightClickMenu_Add(string MainMenu, string NewMenuID, string NewMenuName, int position)
        {
            SAPbouiCOM.Menus omenus;
            SAPbouiCOM.MenuItem omenuitem;
            SAPbouiCOM.MenuCreationParams oCreationPackage;
            oCreationPackage = (SAPbouiCOM.MenuCreationParams)clsModule.objaddon.objapplication.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_MenuCreationParams);
            oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_STRING;
            omenuitem = clsModule.objaddon.objapplication.Menus.Item(MainMenu); // Data'
            if (!omenuitem.SubMenus.Exists(NewMenuID))
            {
                oCreationPackage.UniqueID = NewMenuID;
                oCreationPackage.String = NewMenuName;
                oCreationPackage.Position = position;
                oCreationPackage.Enabled = true;
                omenus = omenuitem.SubMenus;
                omenus.AddEx(oCreationPackage);
            }
        }

        private void RightClickMenu_Delete(string MainMenu, string NewMenuID)
        {
            SAPbouiCOM.MenuItem omenuitem;
            omenuitem = clsModule.objaddon.objapplication.Menus.Item(MainMenu); // Data'
            if (omenuitem.SubMenus.Exists(NewMenuID))
            {
                clsModule.objaddon.objapplication.Menus.RemoveEx(NewMenuID);
            }
        }
        private void FanSpecV1_RightClickEvent(ref SAPbouiCOM.ContextMenuInfo eventInfo, ref bool BubbleEvent)
        {
            try
            {
                SAPbouiCOM.Matrix Matrix0;
                objform = clsModule.objaddon.objapplication.Forms.ActiveForm;
                Matrix0 = (SAPbouiCOM.Matrix)objform.Items.Item("38").Specific;
            }
            catch (Exception ex)
            {
            }
        }

    }
}

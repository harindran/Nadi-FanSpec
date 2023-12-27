using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanSpecV1
{
    class clsTable
    {
        Dictionary<string, string> keyvaltbl = new Dictionary<string, string>();
        public void FieldCreation()
        {

            
            AddFields("@FANDETAIL", "FanSer", "Fan Series", SAPbobsCOM.BoFieldTypes.db_Alpha, 10);
            AddFields("@FANDETAIL", "FanType", "Fan Type", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "FanModel", "Fan Model", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "Qty", "Quantity", SAPbobsCOM.BoFieldTypes.db_Numeric, 10, SAPbobsCOM.BoFldSubTypes.st_Sum);
            AddFields("@FANDETAIL", "Price", "Price", SAPbobsCOM.BoFieldTypes.db_Numeric, 10, SAPbobsCOM.BoFldSubTypes.st_Sum);
            AddFields("@FANDETAIL", "Val", "Value", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "Vol", "Volume", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "dri", "Drive", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "Moc", "MOC", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "fmount", "Fan Mount", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "selev", "Site Elevation", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "Nlevel", "Noise Level", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "ispress", "Inlet Static Pressure", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "ospress", "Outlet Static Pressure", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "itemp", "Inlet temperature", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "dtype", "Density Type", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "gtype", "Gas Type", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "pfspeed", "prefer fan speed", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "arrang", "Arrangement", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "mcat", "Motor Category", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "mmount", "Motor Mount", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "meff", "Motor Efficiency", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "cinsul", "Class of Insulation", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "mvolt", "Motor Voltage", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "mfreq", "Motor Frequency", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "dcon", "Dust Concentration", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "dtype", "Dust Type", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "btype", "Bolts Type", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "pmake", "Preferred Make", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "sstype", "Shaft Seal Type", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "ssdet", "Shaft Seal Detail", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "paspec", "Painting specifications", SAPbobsCOM.BoFieldTypes.db_Alpha, 200);
            AddFields("@FANDETAIL", "pakspec", "Packing Specifications", SAPbobsCOM.BoFieldTypes.db_Alpha, 200);
            AddFields("@FANDETAIL", "abrif", "Application Brief", SAPbobsCOM.BoFieldTypes.db_Alpha, 200);
            AddFields("@FANDETAIL", "acces", "Accessories", SAPbobsCOM.BoFieldTypes.db_Alpha, 200);
            AddFields("@FANDETAIL", "emoc", "EMOC", SAPbobsCOM.BoFieldTypes.db_Alpha, 200);

            AddFields("@FANDETAIL", "cmoc", "Casing MOC", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "Imoc", "Impeller MOC", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "hmoc", "Hub of MOC", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "smoc", "Shaft MOC", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "pmoc", "Pedestal MOC", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "bfmoc", "Base Frame MOC", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "bgmoc", "Belt Guard MOC", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "sgmoc", "Shaft Guard MOC", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "Icmoc", "Inlet Cone MOC", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "chkHou", "Housing", SAPbobsCOM.BoFieldTypes.db_Alpha, 2,SAPbobsCOM.BoFldSubTypes.st_None,SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone,SAPbobsCOM.BoYesNoEnum.tNO,"N",true);
            AddFields("@FANDETAIL", "chkimp", "Impeller", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkhub", "Hub", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chksha", "Shaft", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkped", "Pedestal", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkbfra", "BaseFrame", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkabfr", "Additional Base Frame", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chksra", "Slide rail", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkbgu", "Belt Guard", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkssea", "Shaft Seal", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkbeg", "Bearing Guard", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkmcan", "Motor Canopy", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkomf", "Outlet Matching Flanges", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkimf", "Inlet Matching Flanges", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkofc", "Outlet Flexible Connections", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkifc", "Inlet Flexible Connections", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkmbel", "Metallic Bellows", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkibox", "Inlet Box", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkidam", "Inlet Damper", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkisil", "Inlet Silencer", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkifil", "Inlet Filter", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkitfi", "Inlet Transition Filter box", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkigua", "Inlet Guard", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkigva", "Inlet Guide Vane", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkielb", "Inlet elbow bend", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkicwl", "Inlet cowl", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkodam", "Outlet Damper", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkoevas", "Outlet Evase", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkosile", "Outlet Silencer", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkocwl", "Outlet Cowl", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkomgua", "Outlet Mesh Guard", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chklsea", "Labyrinth", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkmsea", "Mechanical Seal", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkhsli", "Heat Slinger", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkhslig", "Heat Slinger Guard", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkegtub", "Extended Grease Tube", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkalub", "Auto Lubricator", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkrtd", "RTD", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkviso", "Vibration Isolator", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkvsen", "Vibration Sensor", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkpsen", "Proximity sensor", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkebu", "Earthing Bush", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkaen", "Acoustic enclosure", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkbrin", "Brass ring", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkbseal", "Brass Seal", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkpgau", "Pressure Gauge", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkldsw", "Limit Switch", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkbear", "Bearings", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkfpul", "Fan Pulleys", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkmpul", "Motor Pulleys", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkbelt", "Belts", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkmot", "Motor", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkactu", "Actuator", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkard", "Anti Rotation Device", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkbdis", "Break disc", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkspcon", "Spark Proof Construction", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkIcone", "Inlet Cone", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkIpipe", "Inlet Pipe", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkotran", "Outlet Transition", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkitran", "Inlet Transition", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkacdo", "Access Door", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkhinsu", "Housing Insulation", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkcoug", "Coupling Guard", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "chkcoup", "Coupling", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("@FANDETAIL", "saeq", "Sales Enquiry", SAPbobsCOM.BoFieldTypes.db_Alpha, 200);
            AddFields("@FANDETAIL", "CenRep", "Centrix Report", SAPbobsCOM.BoFieldTypes.db_Alpha, 200);
            AddFields("@FANDETAIL", "motspec", "Motor Specs", SAPbobsCOM.BoFieldTypes.db_Alpha, 200);
            AddFields("@FANDETAIL", "mocdet", "Moc Details", SAPbobsCOM.BoFieldTypes.db_Alpha, 200);
            AddFields("@FANDETAIL", "ot1", "Other1", SAPbobsCOM.BoFieldTypes.db_Alpha, 200);
            AddFields("@FANDETAIL", "ot2", "Other2", SAPbobsCOM.BoFieldTypes.db_Alpha, 200);
            AddFields("OQUT", "opid", "Opportunity ID", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("OQUT", "lcno", "Lead Case No", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("OQUT", "lcdat", "Lead Case Date", SAPbobsCOM.BoFieldTypes.db_Date);
            AddFields("OQUT", "lrdat", "Lead Received Date", SAPbobsCOM.BoFieldTypes.db_Date);
            AddFields("OQUT", "opno", "Opportunity No", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("OQUT", "opdat", "Opportunity Date", SAPbobsCOM.BoFieldTypes.db_Date);
            AddFields("OQUT", "catyp", "Call Type", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("OQUT", "lsmod", "Lead Source Mode", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("OQUT", "sp", "Sales Person", SAPbobsCOM.BoFieldTypes.db_Alpha, 100);
            AddFields("OQUT", "hby", "Handled By", SAPbobsCOM.BoFieldTypes.db_Alpha, 100);
            AddFields("OQUT", "lnat", "Lead Nature", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("OQUT", "opsta", "Opportunity Status", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("OQUT", "doex", "Domestic/Export", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("OQUT", "cdes", "Country of Destination", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("OQUT", "vdat", "Validity Date", SAPbobsCOM.BoFieldTypes.db_Date);
            AddFields("OQUT", "expva", "Expected Pipeline Value", SAPbobsCOM.BoFieldTypes.db_Float,40,SAPbobsCOM.BoFldSubTypes.st_Price);
            AddFields("OQUT", "rloss", "Reason for Loss", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("OQUT", "eqtyp", "Enquiry Type", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("OQUT", "edmon", "Expected Delivery Month", SAPbobsCOM.BoFieldTypes.db_Date);
            AddFields("OQUT", "emonpo", "Expected Month of PO", SAPbobsCOM.BoFieldTypes.db_Date);
            AddFields("OQUT", "rtyp", "Requirement Type", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("OQUT", "cucat", "Customer Category", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("OQUT", "conam", "Company Name", SAPbobsCOM.BoFieldTypes.db_Alpha, 200);
            AddFields("OQUT", "cocod", "Company Code", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("OQUT", "cpers", "Contact Person", SAPbobsCOM.BoFieldTypes.db_Alpha, 200);
            AddFields("OQUT", "cppho", "Contact Person Phone", SAPbobsCOM.BoFieldTypes.db_Alpha,200,SAPbobsCOM.BoFldSubTypes.st_Phone);
            AddFields("OQUT", "cpeml", "Contact Person Email", SAPbobsCOM.BoFieldTypes.db_Alpha,150);
            AddFields("OQUT", "cpdes", "Contact Person Designation", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("OQUT", "cprol", "Contact Person Role", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("OQUT", "alpno", "Alternate Phone No", SAPbobsCOM.BoFieldTypes.db_Alpha, 40,SAPbobsCOM.BoFldSubTypes.st_Phone);
            AddFields("OQUT", "tyind", "Type of Industry", SAPbobsCOM.BoFieldTypes.db_Alpha,40);
            AddFields("OQUT", "appl", "Application", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("OQUT", "terr", "Territory", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("OQUT", "cpname", "Customer Project Name", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("OQUT", "ecus", "End Customer", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("OQUT", "Chkequo", "Enable Quote", SAPbobsCOM.BoFieldTypes.db_Alpha, 2, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, SAPbobsCOM.BoYesNoEnum.tNO, "N", true);
            AddFields("OQUT", "qsub", "Quote Subject", SAPbobsCOM.BoFieldTypes.db_Alpha, 200);
            AddFields("OQUT", "qid", "Quote Id", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("OQUT", "qdat", "Quote Date", SAPbobsCOM.BoFieldTypes.db_Date);
            AddFields("OQUT", "sutot", "Sub Total", SAPbobsCOM.BoFieldTypes.db_Float, 40,SAPbobsCOM.BoFldSubTypes.st_Sum);
            AddFields("OQUT", "distot", "Discount Total", SAPbobsCOM.BoFieldTypes.db_Float, 40, SAPbobsCOM.BoFldSubTypes.st_Sum);
            AddFields("OQUT", "taxtot", "Tax Total", SAPbobsCOM.BoFieldTypes.db_Float, 40, SAPbobsCOM.BoFldSubTypes.st_Sum);
            AddFields("OQUT", "Nttot", "Net Total", SAPbobsCOM.BoFieldTypes.db_Float, 40, SAPbobsCOM.BoFldSubTypes.st_Sum);
            AddFields("OQUT", "desc", "Description", SAPbobsCOM.BoFieldTypes.db_Memo, 1000);
            AddFields("QUT1", "udtNum", "udt num", SAPbobsCOM.BoFieldTypes.db_Numeric, 10);

          //  AddUDO("FANDETAIL", "FANDETAIL", SAPbobsCOM.BoUDOObjType.boud_Document, "FANDETAIL", new[] { "" }, new[] { "DocEntry" }, true, false);

          //  AddFieldsNew("QUT1", "UdtNum1", "UdtNum1", SAPbobsCOM.BoFieldTypes.db_Alpha, 50, SAPbobsCOM.BoFldSubTypes.st_None, SAPbobsCOM.BoYesNoEnum.tNO
          //, null,null, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone, "FANDETAIL");



        }
        private void AddUDO(string strUDO, string strUDODesc, SAPbobsCOM.BoUDOObjType nObjectType, string strTable, string[] childTable, string[] sFind, bool canlog = false, bool Manageseries = false)
        {

            SAPbobsCOM.UserObjectsMD oUserObjectMD = null;
            int tablecount = 0;
            try
            {
                oUserObjectMD = (SAPbobsCOM.UserObjectsMD)clsModule.objaddon.objcompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserObjectsMD);

                if (!oUserObjectMD.GetByKey(strUDO)) //(oUserObjectMD.GetByKey(strUDO) == 0)
                {
                    oUserObjectMD.Code = strUDO;
                    oUserObjectMD.Name = strUDODesc;
                    oUserObjectMD.ObjectType = nObjectType;
                    oUserObjectMD.TableName = strTable;


                    oUserObjectMD.CanCancel = SAPbobsCOM.BoYesNoEnum.tYES;
                    oUserObjectMD.CanClose = SAPbobsCOM.BoYesNoEnum.tYES;
                    oUserObjectMD.CanCreateDefaultForm = SAPbobsCOM.BoYesNoEnum.tYES;
                    oUserObjectMD.CanDelete = SAPbobsCOM.BoYesNoEnum.tYES;

                    if (Manageseries)
                        oUserObjectMD.ManageSeries = SAPbobsCOM.BoYesNoEnum.tYES;
                    else
                        oUserObjectMD.ManageSeries = SAPbobsCOM.BoYesNoEnum.tNO;

                    if (canlog)
                    {
                        oUserObjectMD.CanLog = SAPbobsCOM.BoYesNoEnum.tYES;
                        oUserObjectMD.LogTableName = "A" + strTable.ToString();
                    }
                    else
                    {
                        oUserObjectMD.CanLog = SAPbobsCOM.BoYesNoEnum.tNO;
                        oUserObjectMD.LogTableName = "";
                    }

                    oUserObjectMD.CanYearTransfer = SAPbobsCOM.BoYesNoEnum.tNO;


                    oUserObjectMD.CanFind = SAPbobsCOM.BoYesNoEnum.tYES;
                    tablecount = 1;
                    if (sFind.Length > 0)
                    {
                        for (int i = 0, loopTo = sFind.Length - 1; i <= loopTo; i++)
                        {
                            if (string.IsNullOrEmpty(sFind[i]))
                                continue;
                            oUserObjectMD.FindColumns.ColumnAlias = sFind[i];
                            oUserObjectMD.FindColumns.Add();
                            oUserObjectMD.FindColumns.SetCurrentLine(tablecount);

                            oUserObjectMD.FormColumns.FormColumnDescription = sFind[i].Replace("U_", "");
                            if (sFind[i].StartsWith("U_"))
                                oUserObjectMD.FormColumns.Editable = SAPbobsCOM.BoYesNoEnum.tYES;
                            oUserObjectMD.FormColumns.FormColumnAlias = sFind[i];
                            oUserObjectMD.FormColumns.Add();
                            oUserObjectMD.FormColumns.SetCurrentLine(tablecount);

                            tablecount = tablecount + 1;
                        }
                    }

                    tablecount = 0;
                    if (childTable != null)
                    {
                        if (childTable.Length > 0)
                        {
                            for (int i = 0, loopTo1 = childTable.Length - 1; i <= loopTo1; i++)
                            {
                                if (string.IsNullOrEmpty(childTable[i]))
                                    continue;
                                oUserObjectMD.ChildTables.SetCurrentLine(tablecount);
                                oUserObjectMD.ChildTables.TableName = childTable[i];
                                oUserObjectMD.ChildTables.Add();
                                tablecount = tablecount + 1;
                            }
                        }
                    }



                    if (oUserObjectMD.Add() != 0)
                    {
                        throw new Exception(clsModule.objaddon.objcompany.GetLastErrorDescription());
                    }
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserObjectMD);
                oUserObjectMD = null;
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }

        }


        private void AddFieldsNew(string strTab, string strCol, string strDesc, SAPbobsCOM.BoFieldTypes nType, int nEditSize = 10,
     SAPbobsCOM.BoFldSubTypes nSubType = 0, SAPbobsCOM.BoYesNoEnum Mandatory = SAPbobsCOM.BoYesNoEnum.tNO, string defaultvalue = "",
     Dictionary<string, string> keyVal = null, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum linkob = SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone,
     string setlinktable = null,string setLinkUDO =null)
        {

            SAPbobsCOM.UserFieldsMD oUserFieldMD1;
            oUserFieldMD1 = (SAPbobsCOM.UserFieldsMD)clsModule.objaddon.objcompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields);
            try
            {

                if (!IsColumnExists(strTab, strCol))
                {
                    oUserFieldMD1.Description = strDesc;
                    oUserFieldMD1.Name = strCol;
                    oUserFieldMD1.Type = nType;
                    oUserFieldMD1.SubType = nSubType;
                    oUserFieldMD1.TableName = strTab;
                    oUserFieldMD1.EditSize = nEditSize;
                    oUserFieldMD1.Mandatory = Mandatory;
                    oUserFieldMD1.DefaultValue = defaultvalue;

                    foreach (var item in keyvaltbl)
                    {
                        oUserFieldMD1.ValidValues.Value = item.Key;
                        oUserFieldMD1.ValidValues.Description = item.Value;
                        oUserFieldMD1.ValidValues.Add();
                    }

                    if (setlinktable != null)
                    {
                        oUserFieldMD1.LinkedTable = setlinktable;
                        
                    }
                  else  if (setLinkUDO != null)
                    {
                        SAPbobsCOM.UserObjectsMD  oUserObjectMD1 = (SAPbobsCOM.UserObjectsMD)clsModule.objaddon.objcompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserObjectsMD);
                        oUserObjectMD1.GetByKey(setLinkUDO);
                        oUserFieldMD1.LinkedUDO = oUserObjectMD1.Code ;
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserObjectMD1);
                        oUserObjectMD1 = null;

                        GC.Collect();

                    }
                    else if (linkob != SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulNone)
                    {
                        oUserFieldMD1.LinkedSystemObject = linkob;
                    }
                    int val;
                    val = oUserFieldMD1.Add();

                    if (val != 0)
                    {
                        clsModule.objaddon.objapplication.SetStatusBarMessage(clsModule.objaddon.objcompany.GetLastErrorDescription() + " " + strTab + " " + strCol, SAPbouiCOM.BoMessageTime.bmt_Short, true);
                    }
                    // System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserFieldMD1)
                }
                keyvaltbl.Clear();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserFieldMD1);
                oUserFieldMD1 = null;
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }
        }

        private void AddFields(string strTab, string strCol, string strDesc, SAPbobsCOM.BoFieldTypes nType, int nEditSize = 10, SAPbobsCOM.BoFldSubTypes nSubType = 0, SAPbobsCOM.UDFLinkedSystemObjectTypesEnum LinkedSysObject = 0, SAPbobsCOM.BoYesNoEnum Mandatory = SAPbobsCOM.BoYesNoEnum.tNO, string defaultvalue = "", bool Yesno = false, string[] Validvalues = null)
        {
            SAPbobsCOM.UserFieldsMD oUserFieldMD1;
            oUserFieldMD1 = (SAPbobsCOM.UserFieldsMD)clsModule.objaddon.objcompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields);
            try
            {
                // oUserFieldMD1 = objaddon.objcompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields)
                // If Not (strTab = "OPDN" Or strTab = "OQUT" Or strTab = "OADM" Or strTab = "OPOR" Or strTab = "OWST" Or strTab = "OUSR" Or strTab = "OSRN" Or strTab = "OSPP" Or strTab = "WTR1" Or strTab = "OEDG" Or strTab = "OHEM" Or strTab = "OLCT" Or strTab = "ITM1" Or strTab = "OCRD" Or strTab = "SPP1" Or strTab = "SPP2" Or strTab = "RDR1" Or strTab = "ORDR" Or strTab = "OWHS" Or strTab = "OITM" Or strTab = "INV1" Or strTab = "OWTR" Or strTab = "OWDD" Or strTab = "OWOR" Or strTab = "OWTQ" Or strTab = "OMRV" Or strTab = "JDT1" Or strTab = "OIGN" Or strTab = "OCQG") Then
                // strTab = "@" + strTab
                // End If
                if (!IsColumnExists(strTab, strCol))
                {
                    // If Not oUserFieldMD1 Is Nothing Then
                    // System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserFieldMD1)
                    // End If
                    // oUserFieldMD1 = Nothing
                    // oUserFieldMD1 = objaddon.objcompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields)
                    oUserFieldMD1.Description = strDesc;
                    oUserFieldMD1.Name = strCol;
                    oUserFieldMD1.Type = nType;
                    oUserFieldMD1.SubType = nSubType;
                    oUserFieldMD1.TableName = strTab;
                    oUserFieldMD1.EditSize = nEditSize;
                    oUserFieldMD1.Mandatory = Mandatory;
                    oUserFieldMD1.DefaultValue = defaultvalue;

                    if (Yesno == true)
                    {
                        oUserFieldMD1.ValidValues.Value = "Y";
                        oUserFieldMD1.ValidValues.Description = "Yes";
                        oUserFieldMD1.ValidValues.Add();
                        oUserFieldMD1.ValidValues.Value = "N";
                        oUserFieldMD1.ValidValues.Description = "No";
                        oUserFieldMD1.ValidValues.Add();
                    }
                    if (LinkedSysObject != 0)
                        oUserFieldMD1.LinkedSystemObject = LinkedSysObject;// SAPbobsCOM.UDFLinkedSystemObjectTypesEnum.ulInvoices ;

                    string[] split_char;
                    if (Validvalues != null)
                    {
                        if (Validvalues.Length > 0)
                        {
                            for (int i = 0, loopTo = Validvalues.Length - 1; i <= loopTo; i++)
                            {
                                if (string.IsNullOrEmpty(Validvalues[i]))
                                    continue;
                                split_char = Validvalues[i].Split(Convert.ToChar(","));
                                if (split_char.Length != 2)
                                    continue;
                                oUserFieldMD1.ValidValues.Value = split_char[0];
                                oUserFieldMD1.ValidValues.Description = split_char[1];
                                oUserFieldMD1.ValidValues.Add();
                            }
                        }
                    }
                    int val;
                    val = oUserFieldMD1.Add();
                    if (val != 0)
                    {
                        clsModule.objaddon.objapplication.SetStatusBarMessage(clsModule.objaddon.objcompany.GetLastErrorDescription() + " " + strTab + " " + strCol, SAPbouiCOM.BoMessageTime.bmt_Short, true);
                    }
                    // System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserFieldMD1)
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserFieldMD1);
                oUserFieldMD1 = null;
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }
        }
        private bool IsColumnExists(string Table, string Column)
        {
            SAPbobsCOM.Recordset oRecordSet = null;
            string strSQL;
            try
            {
                if (clsModule.objaddon.HANA)
                {
                    strSQL = "SELECT COUNT(*) FROM CUFD WHERE \"TableID\" = '" + Table + "' AND \"AliasID\" = '" + Column + "'";
                }
                else
                {
                    strSQL = "SELECT COUNT(*) FROM CUFD WHERE TableID = '" + Table + "' AND AliasID = '" + Column + "'";
                }

                oRecordSet = (SAPbobsCOM.Recordset)clsModule.objaddon.objcompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
                oRecordSet.DoQuery(strSQL);

                if (Convert.ToInt32(oRecordSet.Fields.Item(0).Value) == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(oRecordSet);
                oRecordSet = null;
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanSpecV1
{
    class clsTable
    {
        public void FieldCreation()
        {

            
            AddFields("@FANDETAIL", "FanSer", "Fan Series", SAPbobsCOM.BoFieldTypes.db_Alpha, 10);
            AddFields("@FANDETAIL", "FanType", "Fan Type", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "FanModel", "Fan Model", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "Qty", "Quantity", SAPbobsCOM.BoFieldTypes.db_Numeric, 40, SAPbobsCOM.BoFldSubTypes.st_Sum);
            AddFields("@FANDETAIL", "Price", "Price", SAPbobsCOM.BoFieldTypes.db_Numeric, 40, SAPbobsCOM.BoFldSubTypes.st_Sum);
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
            AddFields("@FANDETAIL", "saeq", "Sales Enquiry", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "CenRep", "Centrix Report", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "motspec", "Motor Specs", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "mocdet", "Moc Details", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "ot1", "Other1", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
            AddFields("@FANDETAIL", "ot2", "Other2", SAPbobsCOM.BoFieldTypes.db_Alpha, 40);
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

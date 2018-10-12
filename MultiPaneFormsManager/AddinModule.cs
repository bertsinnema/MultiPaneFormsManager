using System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Windows.Forms;
using AddinExpress.MSO;
using Outlook = Microsoft.Office.Interop.Outlook;
using MultiPaneFormsManager.Forms;

namespace MultiPaneFormsManager
{
    /// <summary>
    ///   Add-in Express Add-in Module
    /// </summary>
    [GuidAttribute("5518A05B-44E2-4A60-8867-9AD2AEF03511"), ProgId("MultiPaneFormsManager.AddinModule")]
    public partial class AddinModule : AddinExpress.MSO.ADXAddinModule
    {
        public AddinModule()
        {
            Application.EnableVisualStyles();
            InitializeComponent();
            // Please add any initialization code to the AddinInitialize event handler
        }

        #region Add-in Express automatic code

        // Required by Add-in Express - do not modify
        // the methods within this region

        public override System.ComponentModel.IContainer GetContainer()
        {
            if (components == null)
                components = new System.ComponentModel.Container();
            return components;
        }

        [ComRegisterFunctionAttribute]
        public static void AddinRegister(Type t)
        {
            AddinExpress.MSO.ADXAddinModule.ADXRegister(t);
        }

        [ComUnregisterFunctionAttribute]
        public static void AddinUnregister(Type t)
        {
            AddinExpress.MSO.ADXAddinModule.ADXUnregister(t);
        }

        public override void UninstallControls()
        {
            base.UninstallControls();
        }

        #endregion

        public static new AddinModule CurrentInstance
        {
            get
            {
                return AddinExpress.MSO.ADXAddinModule.CurrentInstance as AddinModule;
            }
        }

        public Outlook._Application OutlookApp
        {
            get
            {
                return (HostApplication as Outlook._Application);
            }
        }

        private void adxRibbonButton1_OnClick(object sender, IRibbonControl control, bool pressed)
        {
            Outlook.Inspector inspector = OutlookApp.ActiveInspector();

            if (adxOlFormsCollectionItem1.GetForm(inspector) is ADXOlForm1 form)
            {
                form.AllowShow = !form.AllowShow;
                form.Visible = form.AllowShow;
                adxRibbonButton1.Caption = form.AllowShow ? "Hide" : "Show";

                if (adxOlFormsCollectionItem2.GetForm(inspector) is ADXOlForm2 form2)
                {
                    form2.AllowShow = false;
                    form2.Visible = false;
                    adxRibbonButton3.Caption = form2.AllowShow ? "Hide" : "Show";


                }
            }

            if (inspector != null)
                Marshal.ReleaseComObject(inspector);
        }

        private void adxRibbonButton2_OnClick(object sender, IRibbonControl control, bool pressed)
        {
            Outlook.Inspector inspector = OutlookApp.ActiveInspector();


            if (adxOlFormsCollectionItem1.GetForm(inspector) is ADXOlForm1 form)
            {
                form.SayClicked();
            }

            if (inspector != null)
                Marshal.ReleaseComObject(inspector);
        }

        private void adxRibbonButton3_OnClick(object sender, IRibbonControl control, bool pressed)
        {
            Outlook.Inspector inspector = OutlookApp.ActiveInspector();


            if (adxOlFormsCollectionItem2.GetForm(inspector) is ADXOlForm2 form)
            {
                form.AllowShow = !form.AllowShow;
                form.Visible = form.AllowShow;
                adxRibbonButton3.Caption = form.AllowShow ? "Hide" : "Show";

                if (adxOlFormsCollectionItem1.GetForm(inspector) is ADXOlForm1 form1)
                {
                    form1.AllowShow = false;
                    form1.Visible = false;
                    adxRibbonButton1.Caption = form1.AllowShow ? "Hide" : "Show";

                }
            }

            if (inspector != null)
                Marshal.ReleaseComObject(inspector);
        }

        private void adxRibbonButton4_OnClick(object sender, IRibbonControl control, bool pressed)
        {
            Outlook.Inspector inspector = OutlookApp.ActiveInspector();


            if (adxOlFormsCollectionItem2.GetForm(inspector) is ADXOlForm2 form)
            {
                form.SayClicked();
            }

            if (inspector != null)
                Marshal.ReleaseComObject(inspector);
        }
    }
}


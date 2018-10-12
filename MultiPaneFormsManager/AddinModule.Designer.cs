namespace MultiPaneFormsManager
{
    partial class AddinModule
    {
        /// <summary>
        /// Required by designer
        /// </summary>
        private System.ComponentModel.IContainer components;
 
        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        /// <summary>
        /// Required by designer support - do not modify
        /// the following method
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.adxOlFormsManager1 = new AddinExpress.OL.ADXOlFormsManager(this.components);
            this.adxOlFormsCollectionItem1 = new AddinExpress.OL.ADXOlFormsCollectionItem(this.components);
            this.adxOlFormsCollectionItem2 = new AddinExpress.OL.ADXOlFormsCollectionItem(this.components);
            this.adxRibbonTab1 = new AddinExpress.MSO.ADXRibbonTab(this.components);
            this.adxRibbonGroup1 = new AddinExpress.MSO.ADXRibbonGroup(this.components);
            this.adxRibbonButton1 = new AddinExpress.MSO.ADXRibbonButton(this.components);
            this.adxRibbonButton2 = new AddinExpress.MSO.ADXRibbonButton(this.components);
            this.adxRibbonButton3 = new AddinExpress.MSO.ADXRibbonButton(this.components);
            this.adxRibbonButton4 = new AddinExpress.MSO.ADXRibbonButton(this.components);
            this.adxRibbonGroup2 = new AddinExpress.MSO.ADXRibbonGroup(this.components);
            // 
            // adxOlFormsManager1
            // 
            this.adxOlFormsManager1.Items.Add(this.adxOlFormsCollectionItem1);
            this.adxOlFormsManager1.Items.Add(this.adxOlFormsCollectionItem2);
            this.adxOlFormsManager1.SetOwner(this);
            // 
            // adxOlFormsCollectionItem1
            // 
            this.adxOlFormsCollectionItem1.FormClassName = "MultiPaneFormsManager.Forms.ADXOlForm1";
            this.adxOlFormsCollectionItem1.InspectorAllowedDropRegions = AddinExpress.OL.ADXOlInspectorAllowedDropRegions.LeftSubpane;
            this.adxOlFormsCollectionItem1.InspectorItemTypes = AddinExpress.OL.ADXOlInspectorItemTypes.olMail;
            this.adxOlFormsCollectionItem1.InspectorLayout = AddinExpress.OL.ADXOlInspectorLayout.LeftSubpane;
            this.adxOlFormsCollectionItem1.InspectorMode = AddinExpress.OL.ADXOlInspectorMode.Compose;
            // 
            // adxOlFormsCollectionItem2
            // 
            this.adxOlFormsCollectionItem2.FormClassName = "MultiPaneFormsManager.Forms.ADXOlForm2";
            this.adxOlFormsCollectionItem2.InspectorAllowedDropRegions = AddinExpress.OL.ADXOlInspectorAllowedDropRegions.LeftSubpane;
            this.adxOlFormsCollectionItem2.InspectorItemTypes = AddinExpress.OL.ADXOlInspectorItemTypes.olMail;
            this.adxOlFormsCollectionItem2.InspectorLayout = AddinExpress.OL.ADXOlInspectorLayout.LeftSubpane;
            this.adxOlFormsCollectionItem2.InspectorMode = AddinExpress.OL.ADXOlInspectorMode.Compose;
            // 
            // adxRibbonTab1
            // 
            this.adxRibbonTab1.Caption = "MultiPaneFormsManager";
            this.adxRibbonTab1.Controls.Add(this.adxRibbonGroup1);
            this.adxRibbonTab1.Controls.Add(this.adxRibbonGroup2);
            this.adxRibbonTab1.Id = "adxRibbonTab_229b2779cfff4b32af5da0d8c1f1f4dc";
            this.adxRibbonTab1.Ribbons = ((AddinExpress.MSO.ADXRibbons)((AddinExpress.MSO.ADXRibbons.msrOutlookMailRead | AddinExpress.MSO.ADXRibbons.msrOutlookMailCompose)));
            // 
            // adxRibbonGroup1
            // 
            this.adxRibbonGroup1.Caption = "Form 1";
            this.adxRibbonGroup1.Controls.Add(this.adxRibbonButton1);
            this.adxRibbonGroup1.Controls.Add(this.adxRibbonButton2);
            this.adxRibbonGroup1.Id = "adxRibbonGroup_bea18ecfb1f84f1ab2754289667210f5";
            this.adxRibbonGroup1.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxRibbonGroup1.Ribbons = ((AddinExpress.MSO.ADXRibbons)((AddinExpress.MSO.ADXRibbons.msrOutlookMailRead | AddinExpress.MSO.ADXRibbons.msrOutlookMailCompose)));
            // 
            // adxRibbonButton1
            // 
            this.adxRibbonButton1.Caption = "Show";
            this.adxRibbonButton1.Id = "adxRibbonButton_88a03de3882447daa75e284e1b05a834";
            this.adxRibbonButton1.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxRibbonButton1.Ribbons = ((AddinExpress.MSO.ADXRibbons)((AddinExpress.MSO.ADXRibbons.msrOutlookMailRead | AddinExpress.MSO.ADXRibbons.msrOutlookMailCompose)));
            this.adxRibbonButton1.OnClick += new AddinExpress.MSO.ADXRibbonOnAction_EventHandler(this.adxRibbonButton1_OnClick);
            // 
            // adxRibbonButton2
            // 
            this.adxRibbonButton2.Caption = "Say Hi";
            this.adxRibbonButton2.Id = "adxRibbonButton_966d448f25c0456eba9004a63ed1ee9c";
            this.adxRibbonButton2.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxRibbonButton2.Ribbons = ((AddinExpress.MSO.ADXRibbons)((AddinExpress.MSO.ADXRibbons.msrOutlookMailRead | AddinExpress.MSO.ADXRibbons.msrOutlookMailCompose)));
            this.adxRibbonButton2.OnClick += new AddinExpress.MSO.ADXRibbonOnAction_EventHandler(this.adxRibbonButton2_OnClick);
            // 
            // adxRibbonButton3
            // 
            this.adxRibbonButton3.Caption = "Show";
            this.adxRibbonButton3.Id = "adxRibbonButton_95451720e5c84b69a25e30be6492c06b";
            this.adxRibbonButton3.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxRibbonButton3.Ribbons = ((AddinExpress.MSO.ADXRibbons)((AddinExpress.MSO.ADXRibbons.msrOutlookMailRead | AddinExpress.MSO.ADXRibbons.msrOutlookMailCompose)));
            this.adxRibbonButton3.OnClick += new AddinExpress.MSO.ADXRibbonOnAction_EventHandler(this.adxRibbonButton3_OnClick);
            // 
            // adxRibbonButton4
            // 
            this.adxRibbonButton4.Caption = "Sai Hi";
            this.adxRibbonButton4.Id = "adxRibbonButton_5383ff5190dd41778173645a9f43eefd";
            this.adxRibbonButton4.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxRibbonButton4.Ribbons = ((AddinExpress.MSO.ADXRibbons)((AddinExpress.MSO.ADXRibbons.msrOutlookMailRead | AddinExpress.MSO.ADXRibbons.msrOutlookMailCompose)));
            this.adxRibbonButton4.OnClick += new AddinExpress.MSO.ADXRibbonOnAction_EventHandler(this.adxRibbonButton4_OnClick);
            // 
            // adxRibbonGroup2
            // 
            this.adxRibbonGroup2.Caption = "Form 2";
            this.adxRibbonGroup2.Controls.Add(this.adxRibbonButton3);
            this.adxRibbonGroup2.Controls.Add(this.adxRibbonButton4);
            this.adxRibbonGroup2.Id = "adxRibbonGroup_74763e3b36e04cbebcc289235cae6f8e";
            this.adxRibbonGroup2.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.adxRibbonGroup2.Ribbons = ((AddinExpress.MSO.ADXRibbons)((AddinExpress.MSO.ADXRibbons.msrOutlookMailRead | AddinExpress.MSO.ADXRibbons.msrOutlookMailCompose)));
            // 
            // AddinModule
            // 
            this.AddinName = "FolderSwitchMadness";
            this.SupportedApps = AddinExpress.MSO.ADXOfficeHostApp.ohaOutlook;

        }
        #endregion

        private AddinExpress.OL.ADXOlFormsManager adxOlFormsManager1;
        private AddinExpress.MSO.ADXRibbonTab adxRibbonTab1;
        private AddinExpress.MSO.ADXRibbonGroup adxRibbonGroup1;
        private AddinExpress.OL.ADXOlFormsCollectionItem adxOlFormsCollectionItem1;
        private AddinExpress.MSO.ADXRibbonButton adxRibbonButton2;
        private AddinExpress.OL.ADXOlFormsCollectionItem adxOlFormsCollectionItem2;
        private AddinExpress.MSO.ADXRibbonButton adxRibbonButton3;
        private AddinExpress.MSO.ADXRibbonButton adxRibbonButton4;
        private AddinExpress.MSO.ADXRibbonGroup adxRibbonGroup2;
        private AddinExpress.MSO.ADXRibbonButton adxRibbonButton1;
    }
}


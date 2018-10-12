using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AddinExpress.OL;

namespace MultiPaneFormsManager.Forms
{
    public partial class ADXOlForm1 : AddinExpress.OL.ADXOlForm
    {
        public ADXOlForm1()
        {
            InitializeComponent();
        }

        public bool AllowShow { get; set; }


        private void ADXOlForm1_ADXBeforeFormShow()
        {
            Visible = AllowShow;
        }


        public void SayClicked()
        {
            MessageBox.Show("HI THIS IS FORM 1");
        }
    }
}

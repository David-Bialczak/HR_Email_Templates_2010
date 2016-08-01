namespace HR_Email_Templates_2010
{
    partial class HrRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public HrRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Templates = this.Factory.CreateRibbonTab();
            this.ChangeButtons = this.Factory.CreateRibbonGroup();
            this.ChangeMenu = this.Factory.CreateRibbonMenu();
            this.ChangeButton1 = this.Factory.CreateRibbonButton();
            this.ChangeButton2 = this.Factory.CreateRibbonButton();
            this.ChangeButton3 = this.Factory.CreateRibbonButton();
            this.ChangeButton4 = this.Factory.CreateRibbonButton();
            this.ChangeButton5 = this.Factory.CreateRibbonButton();
            this.ChangeButton6 = this.Factory.CreateRibbonButton();
            this.ChangeButton7 = this.Factory.CreateRibbonButton();
            this.LeaveRequests = this.Factory.CreateRibbonGroup();
            this.LeaveMenu = this.Factory.CreateRibbonMenu();
            this.LeaveButton1 = this.Factory.CreateRibbonButton();
            this.LeaveButton2 = this.Factory.CreateRibbonButton();
            this.LeaveButton3 = this.Factory.CreateRibbonButton();
            this.LeaveButton4 = this.Factory.CreateRibbonButton();
            this.LeaveButton5 = this.Factory.CreateRibbonButton();
            this.LeaveButton6 = this.Factory.CreateRibbonButton();
            this.FMLAADA = this.Factory.CreateRibbonGroup();
            this.FMLAMenu = this.Factory.CreateRibbonMenu();
            this.button14 = this.Factory.CreateRibbonButton();
            this.button15 = this.Factory.CreateRibbonButton();
            this.button16 = this.Factory.CreateRibbonButton();
            this.button17 = this.Factory.CreateRibbonButton();
            this.button18 = this.Factory.CreateRibbonButton();
            this.button19 = this.Factory.CreateRibbonButton();
            this.button20 = this.Factory.CreateRibbonButton();
            this.button21 = this.Factory.CreateRibbonButton();
            this.button22 = this.Factory.CreateRibbonButton();
            this.InfoRequests = this.Factory.CreateRibbonGroup();
            this.InfoMenu = this.Factory.CreateRibbonMenu();
            this.button23 = this.Factory.CreateRibbonButton();
            this.button24 = this.Factory.CreateRibbonButton();
            this.button25 = this.Factory.CreateRibbonButton();
            this.Notices = this.Factory.CreateRibbonGroup();
            this.NoticeMenu = this.Factory.CreateRibbonMenu();
            this.button26 = this.Factory.CreateRibbonButton();
            this.button27 = this.Factory.CreateRibbonButton();
            this.Templates.SuspendLayout();
            this.ChangeButtons.SuspendLayout();
            this.LeaveRequests.SuspendLayout();
            this.FMLAADA.SuspendLayout();
            this.InfoRequests.SuspendLayout();
            this.Notices.SuspendLayout();
            this.SuspendLayout();
            // 
            // Templates
            // 
            this.Templates.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.Templates.Groups.Add(this.ChangeButtons);
            this.Templates.Groups.Add(this.LeaveRequests);
            this.Templates.Groups.Add(this.FMLAADA);
            this.Templates.Groups.Add(this.InfoRequests);
            this.Templates.Groups.Add(this.Notices);
            this.Templates.Label = "Templates";
            this.Templates.Name = "Templates";
            // 
            // ChangeButtons
            // 
            this.ChangeButtons.Items.Add(this.ChangeMenu);
            this.ChangeButtons.Label = "Change Requests";
            this.ChangeButtons.Name = "ChangeButtons";
            // 
            // ChangeMenu
            // 
            this.ChangeMenu.Items.Add(this.ChangeButton1);
            this.ChangeMenu.Items.Add(this.ChangeButton2);
            this.ChangeMenu.Items.Add(this.ChangeButton3);
            this.ChangeMenu.Items.Add(this.ChangeButton4);
            this.ChangeMenu.Items.Add(this.ChangeButton5);
            this.ChangeMenu.Items.Add(this.ChangeButton6);
            this.ChangeMenu.Items.Add(this.ChangeButton7);
            this.ChangeMenu.Label = "Changes";
            this.ChangeMenu.Name = "ChangeMenu";
            // 
            // ChangeButton1
            // 
            this.ChangeButton1.Label = "New Hire";
            this.ChangeButton1.Name = "ChangeButton1";
            this.ChangeButton1.ShowImage = true;
            // 
            // ChangeButton2
            // 
            this.ChangeButton2.Label = "Position Change";
            this.ChangeButton2.Name = "ChangeButton2";
            this.ChangeButton2.ShowImage = true;
            // 
            // ChangeButton3
            // 
            this.ChangeButton3.Label = "Conversion";
            this.ChangeButton3.Name = "ChangeButton3";
            this.ChangeButton3.ShowImage = true;
            // 
            // ChangeButton4
            // 
            this.ChangeButton4.Label = "Name Change";
            this.ChangeButton4.Name = "ChangeButton4";
            this.ChangeButton4.ShowImage = true;
            // 
            // ChangeButton5
            // 
            this.ChangeButton5.Label = "Position Change";
            this.ChangeButton5.Name = "ChangeButton5";
            this.ChangeButton5.ShowImage = true;
            // 
            // ChangeButton6
            // 
            this.ChangeButton6.Label = "Separation";
            this.ChangeButton6.Name = "ChangeButton6";
            this.ChangeButton6.ShowImage = true;
            // 
            // ChangeButton7
            // 
            this.ChangeButton7.Label = "Separation - Temp";
            this.ChangeButton7.Name = "ChangeButton7";
            this.ChangeButton7.ShowImage = true;
            // 
            // LeaveRequests
            // 
            this.LeaveRequests.Items.Add(this.LeaveMenu);
            this.LeaveRequests.Label = "Leave Requests";
            this.LeaveRequests.Name = "LeaveRequests";
            // 
            // LeaveMenu
            // 
            this.LeaveMenu.Items.Add(this.LeaveButton1);
            this.LeaveMenu.Items.Add(this.LeaveButton2);
            this.LeaveMenu.Items.Add(this.LeaveButton3);
            this.LeaveMenu.Items.Add(this.LeaveButton4);
            this.LeaveMenu.Items.Add(this.LeaveButton5);
            this.LeaveMenu.Items.Add(this.LeaveButton6);
            this.LeaveMenu.Label = "Leave";
            this.LeaveMenu.Name = "LeaveMenu";
            // 
            // LeaveButton1
            // 
            this.LeaveButton1.Label = "LoA Departure";
            this.LeaveButton1.Name = "LeaveButton1";
            this.LeaveButton1.ShowImage = true;
            // 
            // LeaveButton2
            // 
            this.LeaveButton2.Label = "LoA Return";
            this.LeaveButton2.Name = "LeaveButton2";
            this.LeaveButton2.ShowImage = true;
            // 
            // LeaveButton3
            // 
            this.LeaveButton3.Label = "Intermittent Leave";
            this.LeaveButton3.Name = "LeaveButton3";
            this.LeaveButton3.ShowImage = true;
            // 
            // LeaveButton4
            // 
            this.LeaveButton4.Label = "Bereavement";
            this.LeaveButton4.Name = "LeaveButton4";
            this.LeaveButton4.ShowImage = true;
            // 
            // LeaveButton5
            // 
            this.LeaveButton5.Label = "Pregnancy Leave - CA";
            this.LeaveButton5.Name = "LeaveButton5";
            this.LeaveButton5.ShowImage = true;
            // 
            // LeaveButton6
            // 
            this.LeaveButton6.Label = "Return to Work";
            this.LeaveButton6.Name = "LeaveButton6";
            this.LeaveButton6.ShowImage = true;
            // 
            // FMLAADA
            // 
            this.FMLAADA.Items.Add(this.FMLAMenu);
            this.FMLAADA.Label = "FMLA and ADA Requests";
            this.FMLAADA.Name = "FMLAADA";
            // 
            // FMLAMenu
            // 
            this.FMLAMenu.Items.Add(this.button14);
            this.FMLAMenu.Items.Add(this.button15);
            this.FMLAMenu.Items.Add(this.button16);
            this.FMLAMenu.Items.Add(this.button17);
            this.FMLAMenu.Items.Add(this.button18);
            this.FMLAMenu.Items.Add(this.button19);
            this.FMLAMenu.Items.Add(this.button20);
            this.FMLAMenu.Items.Add(this.button21);
            this.FMLAMenu.Items.Add(this.button22);
            this.FMLAMenu.Label = "FMLA and ADA";
            this.FMLAMenu.Name = "FMLAMenu";
            // 
            // button14
            // 
            this.button14.Label = "button14";
            this.button14.Name = "button14";
            this.button14.ShowImage = true;
            // 
            // button15
            // 
            this.button15.Label = "button15";
            this.button15.Name = "button15";
            this.button15.ShowImage = true;
            // 
            // button16
            // 
            this.button16.Label = "button16";
            this.button16.Name = "button16";
            this.button16.ShowImage = true;
            // 
            // button17
            // 
            this.button17.Label = "button17";
            this.button17.Name = "button17";
            this.button17.ShowImage = true;
            // 
            // button18
            // 
            this.button18.Label = "button18";
            this.button18.Name = "button18";
            this.button18.ShowImage = true;
            // 
            // button19
            // 
            this.button19.Label = "button19";
            this.button19.Name = "button19";
            this.button19.ShowImage = true;
            // 
            // button20
            // 
            this.button20.Label = "button20";
            this.button20.Name = "button20";
            this.button20.ShowImage = true;
            // 
            // button21
            // 
            this.button21.Label = "button21";
            this.button21.Name = "button21";
            this.button21.ShowImage = true;
            // 
            // button22
            // 
            this.button22.Label = "button22";
            this.button22.Name = "button22";
            this.button22.ShowImage = true;
            // 
            // InfoRequests
            // 
            this.InfoRequests.Items.Add(this.InfoMenu);
            this.InfoRequests.Label = "Requesting Information";
            this.InfoRequests.Name = "InfoRequests";
            // 
            // InfoMenu
            // 
            this.InfoMenu.Items.Add(this.button23);
            this.InfoMenu.Items.Add(this.button24);
            this.InfoMenu.Items.Add(this.button25);
            this.InfoMenu.Label = "Requests";
            this.InfoMenu.Name = "InfoMenu";
            // 
            // button23
            // 
            this.button23.Label = "button23";
            this.button23.Name = "button23";
            this.button23.ShowImage = true;
            // 
            // button24
            // 
            this.button24.Label = "button24";
            this.button24.Name = "button24";
            this.button24.ShowImage = true;
            // 
            // button25
            // 
            this.button25.Label = "button25";
            this.button25.Name = "button25";
            this.button25.ShowImage = true;
            // 
            // Notices
            // 
            this.Notices.Items.Add(this.NoticeMenu);
            this.Notices.Label = "Notices";
            this.Notices.Name = "Notices";
            // 
            // NoticeMenu
            // 
            this.NoticeMenu.Items.Add(this.button26);
            this.NoticeMenu.Items.Add(this.button27);
            this.NoticeMenu.Label = "Notices";
            this.NoticeMenu.Name = "NoticeMenu";
            // 
            // button26
            // 
            this.button26.Label = "button26";
            this.button26.Name = "button26";
            this.button26.ShowImage = true;
            // 
            // button27
            // 
            this.button27.Label = "button27";
            this.button27.Name = "button27";
            this.button27.ShowImage = true;
            // 
            // HrRibbon
            // 
            this.Name = "HrRibbon";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.Templates);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.Templates.ResumeLayout(false);
            this.Templates.PerformLayout();
            this.ChangeButtons.ResumeLayout(false);
            this.ChangeButtons.PerformLayout();
            this.LeaveRequests.ResumeLayout(false);
            this.LeaveRequests.PerformLayout();
            this.FMLAADA.ResumeLayout(false);
            this.FMLAADA.PerformLayout();
            this.InfoRequests.ResumeLayout(false);
            this.InfoRequests.PerformLayout();
            this.Notices.ResumeLayout(false);
            this.Notices.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab Templates;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup ChangeButtons;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup FMLAADA;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup InfoRequests;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup LeaveRequests;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Notices;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu ChangeMenu;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ChangeButton1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ChangeButton2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ChangeButton3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ChangeButton4;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ChangeButton5;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ChangeButton6;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ChangeButton7;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu LeaveMenu;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton LeaveButton1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton LeaveButton2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton LeaveButton3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton LeaveButton4;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton LeaveButton5;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton LeaveButton6;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu FMLAMenu;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button14;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button15;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button16;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button17;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button18;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button19;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button20;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button21;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button22;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu InfoMenu;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button23;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button24;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button25;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu NoticeMenu;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button26;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button27;
    }

    partial class ThisRibbonCollection
    {
        internal HrRibbon Ribbon1
        {
            get { return this.GetRibbon<HrRibbon>(); }
        }
    }
}

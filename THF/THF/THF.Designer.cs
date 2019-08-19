namespace THF
{
    partial class THF : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public THF()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(THF));
            this.tbTDTools = this.Factory.CreateRibbonTab();
            this.grpEvent = this.Factory.CreateRibbonGroup();
            this.btnSelectEvent = this.Factory.CreateRibbonButton();
            this.btnManageEvent = this.Factory.CreateRibbonButton();
            this.tbTDTools.SuspendLayout();
            this.grpEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTDTools
            // 
            this.tbTDTools.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tbTDTools.Groups.Add(this.grpEvent);
            this.tbTDTools.Label = "THF Tools";
            this.tbTDTools.Name = "tbTDTools";
            // 
            // grpEvent
            // 
            this.grpEvent.Items.Add(this.btnSelectEvent);
            this.grpEvent.Items.Add(this.btnManageEvent);
            this.grpEvent.Label = "Evénements";
            this.grpEvent.Name = "grpEvent";
            // 
            // btnSelectEvent
            // 
            this.btnSelectEvent.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnSelectEvent.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectEvent.Image")));
            this.btnSelectEvent.Label = "Sélectionner Evénement";
            this.btnSelectEvent.Name = "btnSelectEvent";
            this.btnSelectEvent.ShowImage = true;
            this.btnSelectEvent.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSelectEvent_Click);
            // 
            // btnManageEvent
            // 
            this.btnManageEvent.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnManageEvent.Image = ((System.Drawing.Image)(resources.GetObject("btnManageEvent.Image")));
            this.btnManageEvent.Label = "Gérer Evénements";
            this.btnManageEvent.Name = "btnManageEvent";
            this.btnManageEvent.ShowImage = true;
            this.btnManageEvent.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnManageEvent_Click);
            // 
            // THF
            // 
            this.Name = "THF";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tbTDTools);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.THF_Load);
            this.tbTDTools.ResumeLayout(false);
            this.tbTDTools.PerformLayout();
            this.grpEvent.ResumeLayout(false);
            this.grpEvent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpEvent;
        internal Microsoft.Office.Tools.Ribbon.RibbonTab tbTDTools;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSelectEvent;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnManageEvent;
    }

    partial class ThisRibbonCollection
    {
        internal THF THF
        {
            get { return this.GetRibbon<THF>(); }
        }
    }
}

namespace THF
{
    partial class ManageEvent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxCreateEvent = new System.Windows.Forms.GroupBox();
            this.lblEventName = new System.Windows.Forms.Label();
            this.tbxEventName = new System.Windows.Forms.TextBox();
            this.llblLocationEvent = new System.Windows.Forms.Label();
            this.tbxLocationEvent = new System.Windows.Forms.TextBox();
            this.lblStartDateEvent = new System.Windows.Forms.Label();
            this.lblEndDateEvent = new System.Windows.Forms.Label();
            this.dtpStartDateEvent = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDateEvent = new System.Windows.Forms.DateTimePicker();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.gbxCreateEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCreateEvent
            // 
            this.gbxCreateEvent.Controls.Add(this.btnAddEvent);
            this.gbxCreateEvent.Controls.Add(this.dtpEndDateEvent);
            this.gbxCreateEvent.Controls.Add(this.dtpStartDateEvent);
            this.gbxCreateEvent.Controls.Add(this.lblEndDateEvent);
            this.gbxCreateEvent.Controls.Add(this.lblStartDateEvent);
            this.gbxCreateEvent.Controls.Add(this.tbxLocationEvent);
            this.gbxCreateEvent.Controls.Add(this.llblLocationEvent);
            this.gbxCreateEvent.Controls.Add(this.tbxEventName);
            this.gbxCreateEvent.Controls.Add(this.lblEventName);
            this.gbxCreateEvent.Location = new System.Drawing.Point(13, 13);
            this.gbxCreateEvent.Name = "gbxCreateEvent";
            this.gbxCreateEvent.Size = new System.Drawing.Size(760, 201);
            this.gbxCreateEvent.TabIndex = 0;
            this.gbxCreateEvent.TabStop = false;
            this.gbxCreateEvent.Text = "Créer un événement";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(27, 50);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(50, 20);
            this.lblEventName.TabIndex = 0;
            this.lblEventName.Text = "Nom :";
            // 
            // tbxEventName
            // 
            this.tbxEventName.Location = new System.Drawing.Point(110, 47);
            this.tbxEventName.Name = "tbxEventName";
            this.tbxEventName.Size = new System.Drawing.Size(282, 26);
            this.tbxEventName.TabIndex = 1;
            // 
            // llblLocationEvent
            // 
            this.llblLocationEvent.AutoSize = true;
            this.llblLocationEvent.Location = new System.Drawing.Point(27, 102);
            this.llblLocationEvent.Name = "llblLocationEvent";
            this.llblLocationEvent.Size = new System.Drawing.Size(47, 20);
            this.llblLocationEvent.TabIndex = 2;
            this.llblLocationEvent.Text = "Lieu :";
            // 
            // tbxLocationEvent
            // 
            this.tbxLocationEvent.Location = new System.Drawing.Point(110, 99);
            this.tbxLocationEvent.Name = "tbxLocationEvent";
            this.tbxLocationEvent.Size = new System.Drawing.Size(282, 26);
            this.tbxLocationEvent.TabIndex = 3;
            // 
            // lblStartDateEvent
            // 
            this.lblStartDateEvent.AutoSize = true;
            this.lblStartDateEvent.Location = new System.Drawing.Point(498, 50);
            this.lblStartDateEvent.Name = "lblStartDateEvent";
            this.lblStartDateEvent.Size = new System.Drawing.Size(65, 20);
            this.lblStartDateEvent.TabIndex = 4;
            this.lblStartDateEvent.Text = "Début : ";
            // 
            // lblEndDateEvent
            // 
            this.lblEndDateEvent.AutoSize = true;
            this.lblEndDateEvent.Location = new System.Drawing.Point(498, 102);
            this.lblEndDateEvent.Name = "lblEndDateEvent";
            this.lblEndDateEvent.Size = new System.Drawing.Size(39, 20);
            this.lblEndDateEvent.TabIndex = 5;
            this.lblEndDateEvent.Text = "Fin :";
            // 
            // dtpStartDateEvent
            // 
            this.dtpStartDateEvent.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDateEvent.Location = new System.Drawing.Point(589, 47);
            this.dtpStartDateEvent.Name = "dtpStartDateEvent";
            this.dtpStartDateEvent.Size = new System.Drawing.Size(140, 26);
            this.dtpStartDateEvent.TabIndex = 6;
            // 
            // dtpEndDateEvent
            // 
            this.dtpEndDateEvent.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDateEvent.Location = new System.Drawing.Point(589, 97);
            this.dtpEndDateEvent.Name = "dtpEndDateEvent";
            this.dtpEndDateEvent.Size = new System.Drawing.Size(140, 26);
            this.dtpEndDateEvent.TabIndex = 7;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(31, 142);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(698, 33);
            this.btnAddEvent.TabIndex = 8;
            this.btnAddEvent.Text = "Ajouter";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            // 
            // ManageEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 392);
            this.Controls.Add(this.gbxCreateEvent);
            this.Name = "ManageEvent";
            this.Text = "THF | Gérer les événements";
            this.gbxCreateEvent.ResumeLayout(false);
            this.gbxCreateEvent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCreateEvent;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.DateTimePicker dtpEndDateEvent;
        private System.Windows.Forms.DateTimePicker dtpStartDateEvent;
        private System.Windows.Forms.Label lblEndDateEvent;
        private System.Windows.Forms.Label lblStartDateEvent;
        private System.Windows.Forms.TextBox tbxLocationEvent;
        private System.Windows.Forms.Label llblLocationEvent;
        private System.Windows.Forms.TextBox tbxEventName;
        private System.Windows.Forms.Label lblEventName;
    }
}
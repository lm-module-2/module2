namespace THF
{
    partial class SelectEvent
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
            this.lblSelectEvent = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectEvent
            // 
            this.lblSelectEvent.AutoSize = true;
            this.lblSelectEvent.Location = new System.Drawing.Point(44, 47);
            this.lblSelectEvent.Name = "lblSelectEvent";
            this.lblSelectEvent.Size = new System.Drawing.Size(211, 20);
            this.lblSelectEvent.TabIndex = 0;
            this.lblSelectEvent.Text = "Sélectionner un événement :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(291, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(316, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(48, 101);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(559, 31);
            this.btnValidate.TabIndex = 2;
            this.btnValidate.Text = "Valider";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // SelectEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 175);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblSelectEvent);
            this.Name = "SelectEvent";
            this.Text = "THF | Sélectionner un événement";
            this.Load += new System.EventHandler(this.SelectEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectEvent;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnValidate;
    }
}
namespace M2_Flexibilite_Chariot
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRecettes = new System.Windows.Forms.Button();
            this.btnLots = new System.Windows.Forms.Button();
            this.btnTracabilité = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRecettes
            // 
            this.btnRecettes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecettes.Location = new System.Drawing.Point(65, 54);
            this.btnRecettes.Name = "btnRecettes";
            this.btnRecettes.Size = new System.Drawing.Size(142, 142);
            this.btnRecettes.TabIndex = 0;
            this.btnRecettes.Text = "Gestion des recettes";
            this.btnRecettes.UseVisualStyleBackColor = true;
            // 
            // btnLots
            // 
            this.btnLots.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLots.Location = new System.Drawing.Point(329, 54);
            this.btnLots.Name = "btnLots";
            this.btnLots.Size = new System.Drawing.Size(142, 142);
            this.btnLots.TabIndex = 1;
            this.btnLots.Text = "Gestion des lots";
            this.btnLots.UseVisualStyleBackColor = true;
            // 
            // btnTracabilité
            // 
            this.btnTracabilité.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTracabilité.Location = new System.Drawing.Point(583, 54);
            this.btnTracabilité.Name = "btnTracabilité";
            this.btnTracabilité.Size = new System.Drawing.Size(142, 142);
            this.btnTracabilité.TabIndex = 2;
            this.btnTracabilité.Text = "Afficher la traçabilité";
            this.btnTracabilité.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 250);
            this.Controls.Add(this.btnTracabilité);
            this.Controls.Add(this.btnLots);
            this.Controls.Add(this.btnRecettes);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRecettes;
        private System.Windows.Forms.Button btnLots;
        private System.Windows.Forms.Button btnTracabilité;
    }
}


namespace EFTItems
{
    partial class Hauptmenü
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelÜberschrift = new System.Windows.Forms.Label();
            this.buttonItems = new System.Windows.Forms.Button();
            this.buttonHideout = new System.Windows.Forms.Button();
            this.buttonTrades = new System.Windows.Forms.Button();
            this.buttonEinstellungen = new System.Windows.Forms.Button();
            this.buttonKappa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelÜberschrift
            // 
            this.labelÜberschrift.AutoSize = true;
            this.labelÜberschrift.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelÜberschrift.Location = new System.Drawing.Point(181, 84);
            this.labelÜberschrift.Name = "labelÜberschrift";
            this.labelÜberschrift.Size = new System.Drawing.Size(224, 54);
            this.labelÜberschrift.TabIndex = 0;
            this.labelÜberschrift.Text = "EFTitems";
            // 
            // buttonItems
            // 
            this.buttonItems.Location = new System.Drawing.Point(57, 212);
            this.buttonItems.Name = "buttonItems";
            this.buttonItems.Size = new System.Drawing.Size(462, 23);
            this.buttonItems.TabIndex = 2;
            this.buttonItems.Text = "Items";
            this.buttonItems.UseVisualStyleBackColor = true;
            this.buttonItems.Click += new System.EventHandler(this.buttonItems_Click);
            // 
            // buttonHideout
            // 
            this.buttonHideout.Location = new System.Drawing.Point(57, 241);
            this.buttonHideout.Name = "buttonHideout";
            this.buttonHideout.Size = new System.Drawing.Size(462, 23);
            this.buttonHideout.TabIndex = 3;
            this.buttonHideout.Text = "Hideout";
            this.buttonHideout.UseVisualStyleBackColor = true;
            this.buttonHideout.Click += new System.EventHandler(this.buttonHideout_Click);
            // 
            // buttonTrades
            // 
            this.buttonTrades.Location = new System.Drawing.Point(57, 270);
            this.buttonTrades.Name = "buttonTrades";
            this.buttonTrades.Size = new System.Drawing.Size(462, 23);
            this.buttonTrades.TabIndex = 4;
            this.buttonTrades.Text = "Trades";
            this.buttonTrades.UseVisualStyleBackColor = true;
            this.buttonTrades.Click += new System.EventHandler(this.buttonTrades_Click);
            // 
            // buttonEinstellungen
            // 
            this.buttonEinstellungen.Location = new System.Drawing.Point(517, 349);
            this.buttonEinstellungen.Name = "buttonEinstellungen";
            this.buttonEinstellungen.Size = new System.Drawing.Size(81, 23);
            this.buttonEinstellungen.TabIndex = 5;
            this.buttonEinstellungen.Text = "Einstellungen";
            this.buttonEinstellungen.UseVisualStyleBackColor = true;
            // 
            // buttonKappa
            // 
            this.buttonKappa.Location = new System.Drawing.Point(0, 349);
            this.buttonKappa.Name = "buttonKappa";
            this.buttonKappa.Size = new System.Drawing.Size(56, 23);
            this.buttonKappa.TabIndex = 6;
            this.buttonKappa.Text = "Kappa";
            this.buttonKappa.UseVisualStyleBackColor = true;
            // 
            // Hauptmenü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonKappa);
            this.Controls.Add(this.buttonEinstellungen);
            this.Controls.Add(this.buttonTrades);
            this.Controls.Add(this.buttonHideout);
            this.Controls.Add(this.buttonItems);
            this.Controls.Add(this.labelÜberschrift);
            this.Name = "Hauptmenü";
            this.Size = new System.Drawing.Size(598, 371);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelÜberschrift;
        private System.Windows.Forms.Button buttonItems;
        private System.Windows.Forms.Button buttonHideout;
        private System.Windows.Forms.Button buttonTrades;
        private System.Windows.Forms.Button buttonEinstellungen;
        private System.Windows.Forms.Button buttonKappa;
    }
}

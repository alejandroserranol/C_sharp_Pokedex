namespace C_sharp_Pokedex
{
    partial class Portada
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Portada));
            this.open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.BackColor = System.Drawing.Color.Transparent;
            this.open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.open.FlatAppearance.BorderSize = 0;
            this.open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open.ForeColor = System.Drawing.Color.Transparent;
            this.open.Location = new System.Drawing.Point(12, 382);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(103, 117);
            this.open.TabIndex = 1;
            this.open.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.open.UseVisualStyleBackColor = false;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // Portada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::C_sharp_Pokedex.Properties.Resources.pokedexCerrada;
            this.ClientSize = new System.Drawing.Size(634, 861);
            this.Controls.Add(this.open);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Portada";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button open;
    }
}


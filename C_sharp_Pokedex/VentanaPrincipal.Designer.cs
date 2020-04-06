namespace C_sharp_Pokedex
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.imagenPkmn = new System.Windows.Forms.PictureBox();
            this.off = new System.Windows.Forms.Button();
            this.res5 = new System.Windows.Forms.Button();
            this.sum5 = new System.Windows.Forms.Button();
            this.numPkmn = new System.Windows.Forms.Label();
            this.nombrePkmn = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.izq = new System.Windows.Forms.Button();
            this.der = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.alturaPkmn = new System.Windows.Forms.Label();
            this.pesoPkmn = new System.Windows.Forms.Label();
            this.tipo1 = new System.Windows.Forms.Label();
            this.tipo2 = new System.Windows.Forms.Label();
            this.especiePkmn = new System.Windows.Forms.Label();
            this.alturaLabel = new System.Windows.Forms.Label();
            this.pesoLael = new System.Windows.Forms.Label();
            this.tipo1Label = new System.Windows.Forms.Label();
            this.tipo2Label = new System.Windows.Forms.Label();
            this.especieLabel = new System.Windows.Forms.Label();
            this.movimientosLabel = new System.Windows.Forms.Label();
            this.movimiento1 = new System.Windows.Forms.Label();
            this.movimiento2 = new System.Windows.Forms.Label();
            this.movimiento3 = new System.Windows.Forms.Label();
            this.movimiento4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPkmn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // imagenPkmn
            // 
            this.imagenPkmn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(217)))), ((int)(((byte)(223)))));
            this.imagenPkmn.Image = global::C_sharp_Pokedex.Properties.Resources.pokemon_logo;
            this.imagenPkmn.Location = new System.Drawing.Point(177, 298);
            this.imagenPkmn.Name = "imagenPkmn";
            this.imagenPkmn.Size = new System.Drawing.Size(272, 272);
            this.imagenPkmn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imagenPkmn.TabIndex = 6;
            this.imagenPkmn.TabStop = false;
            // 
            // off
            // 
            this.off.BackColor = System.Drawing.Color.Transparent;
            this.off.BackgroundImage = global::C_sharp_Pokedex.Properties.Resources.off;
            this.off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.off.FlatAppearance.BorderSize = 0;
            this.off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.off.Location = new System.Drawing.Point(466, 257);
            this.off.Name = "off";
            this.off.Size = new System.Drawing.Size(44, 44);
            this.off.TabIndex = 8;
            this.off.UseVisualStyleBackColor = false;
            this.off.Click += new System.EventHandler(this.off_Click);
            // 
            // res5
            // 
            this.res5.BackColor = System.Drawing.Color.Transparent;
            this.res5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.res5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.res5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res5.Location = new System.Drawing.Point(259, 629);
            this.res5.Name = "res5";
            this.res5.Size = new System.Drawing.Size(66, 30);
            this.res5.TabIndex = 15;
            this.res5.Text = "- 5";
            this.res5.UseVisualStyleBackColor = false;
            this.res5.Click += new System.EventHandler(this.res5_Click);
            // 
            // sum5
            // 
            this.sum5.BackColor = System.Drawing.Color.Transparent;
            this.sum5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sum5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sum5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum5.Location = new System.Drawing.Point(177, 629);
            this.sum5.Name = "sum5";
            this.sum5.Size = new System.Drawing.Size(66, 30);
            this.sum5.TabIndex = 14;
            this.sum5.Text = "+ 5";
            this.sum5.UseVisualStyleBackColor = false;
            this.sum5.Click += new System.EventHandler(this.sum5_Click);
            // 
            // numPkmn
            // 
            this.numPkmn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(231)))));
            this.numPkmn.Font = new System.Drawing.Font("Showcard Gothic", 14.25F);
            this.numPkmn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(100)))), ((int)(((byte)(174)))));
            this.numPkmn.Location = new System.Drawing.Point(164, 574);
            this.numPkmn.Name = "numPkmn";
            this.numPkmn.Size = new System.Drawing.Size(51, 42);
            this.numPkmn.TabIndex = 13;
            this.numPkmn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombrePkmn
            // 
            this.nombrePkmn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(231)))));
            this.nombrePkmn.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePkmn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(100)))), ((int)(((byte)(174)))));
            this.nombrePkmn.Location = new System.Drawing.Point(221, 574);
            this.nombrePkmn.Name = "nombrePkmn";
            this.nombrePkmn.Size = new System.Drawing.Size(141, 42);
            this.nombrePkmn.TabIndex = 12;
            this.nombrePkmn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::C_sharp_Pokedex.Properties.Resources.pokeball;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(77, 617);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 83);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // izq
            // 
            this.izq.BackColor = System.Drawing.Color.Transparent;
            this.izq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.izq.FlatAppearance.BorderSize = 0;
            this.izq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izq.Location = new System.Drawing.Point(365, 674);
            this.izq.Name = "izq";
            this.izq.Size = new System.Drawing.Size(44, 47);
            this.izq.TabIndex = 17;
            this.izq.UseVisualStyleBackColor = false;
            this.izq.Click += new System.EventHandler(this.izq_Click);
            // 
            // der
            // 
            this.der.BackColor = System.Drawing.Color.Transparent;
            this.der.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.der.FlatAppearance.BorderSize = 0;
            this.der.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.der.Location = new System.Drawing.Point(450, 674);
            this.der.Name = "der";
            this.der.Size = new System.Drawing.Size(44, 47);
            this.der.TabIndex = 18;
            this.der.UseVisualStyleBackColor = false;
            this.der.Click += new System.EventHandler(this.der_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(365, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(194, 49);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // alturaPkmn
            // 
            this.alturaPkmn.BackColor = System.Drawing.Color.Transparent;
            this.alturaPkmn.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alturaPkmn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(100)))), ((int)(((byte)(174)))));
            this.alturaPkmn.Location = new System.Drawing.Point(717, 574);
            this.alturaPkmn.Name = "alturaPkmn";
            this.alturaPkmn.Size = new System.Drawing.Size(127, 42);
            this.alturaPkmn.TabIndex = 22;
            this.alturaPkmn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pesoPkmn
            // 
            this.pesoPkmn.BackColor = System.Drawing.Color.Transparent;
            this.pesoPkmn.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesoPkmn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(100)))), ((int)(((byte)(174)))));
            this.pesoPkmn.Location = new System.Drawing.Point(861, 574);
            this.pesoPkmn.Name = "pesoPkmn";
            this.pesoPkmn.Size = new System.Drawing.Size(127, 42);
            this.pesoPkmn.TabIndex = 23;
            this.pesoPkmn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipo1
            // 
            this.tipo1.BackColor = System.Drawing.Color.Transparent;
            this.tipo1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(96)))));
            this.tipo1.Location = new System.Drawing.Point(717, 674);
            this.tipo1.Name = "tipo1";
            this.tipo1.Size = new System.Drawing.Size(182, 61);
            this.tipo1.TabIndex = 24;
            this.tipo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipo2
            // 
            this.tipo2.BackColor = System.Drawing.Color.Transparent;
            this.tipo2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(96)))));
            this.tipo2.Location = new System.Drawing.Point(937, 674);
            this.tipo2.Name = "tipo2";
            this.tipo2.Size = new System.Drawing.Size(182, 61);
            this.tipo2.TabIndex = 25;
            this.tipo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // especiePkmn
            // 
            this.especiePkmn.BackColor = System.Drawing.Color.Transparent;
            this.especiePkmn.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especiePkmn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(100)))), ((int)(((byte)(174)))));
            this.especiePkmn.Location = new System.Drawing.Point(101, 703);
            this.especiePkmn.Name = "especiePkmn";
            this.especiePkmn.Size = new System.Drawing.Size(182, 54);
            this.especiePkmn.TabIndex = 26;
            this.especiePkmn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alturaLabel
            // 
            this.alturaLabel.BackColor = System.Drawing.Color.Transparent;
            this.alturaLabel.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alturaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(96)))));
            this.alturaLabel.Location = new System.Drawing.Point(717, 535);
            this.alturaLabel.Name = "alturaLabel";
            this.alturaLabel.Size = new System.Drawing.Size(127, 35);
            this.alturaLabel.TabIndex = 27;
            this.alturaLabel.Text = "ALTURA";
            this.alturaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pesoLael
            // 
            this.pesoLael.BackColor = System.Drawing.Color.Transparent;
            this.pesoLael.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesoLael.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(96)))));
            this.pesoLael.Location = new System.Drawing.Point(861, 535);
            this.pesoLael.Name = "pesoLael";
            this.pesoLael.Size = new System.Drawing.Size(127, 35);
            this.pesoLael.TabIndex = 28;
            this.pesoLael.Text = "PESO";
            this.pesoLael.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipo1Label
            // 
            this.tipo1Label.BackColor = System.Drawing.Color.Transparent;
            this.tipo1Label.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(96)))));
            this.tipo1Label.Location = new System.Drawing.Point(743, 629);
            this.tipo1Label.Name = "tipo1Label";
            this.tipo1Label.Size = new System.Drawing.Size(127, 35);
            this.tipo1Label.TabIndex = 29;
            this.tipo1Label.Text = "TIPO 1";
            this.tipo1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipo2Label
            // 
            this.tipo2Label.BackColor = System.Drawing.Color.Transparent;
            this.tipo2Label.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(96)))));
            this.tipo2Label.Location = new System.Drawing.Point(968, 629);
            this.tipo2Label.Name = "tipo2Label";
            this.tipo2Label.Size = new System.Drawing.Size(127, 35);
            this.tipo2Label.TabIndex = 30;
            this.tipo2Label.Text = "TIPO 2";
            this.tipo2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // especieLabel
            // 
            this.especieLabel.BackColor = System.Drawing.Color.Transparent;
            this.especieLabel.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especieLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(96)))));
            this.especieLabel.Location = new System.Drawing.Point(164, 662);
            this.especieLabel.Name = "especieLabel";
            this.especieLabel.Size = new System.Drawing.Size(138, 35);
            this.especieLabel.TabIndex = 31;
            this.especieLabel.Text = "ESPECIE";
            this.especieLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movimientosLabel
            // 
            this.movimientosLabel.BackColor = System.Drawing.Color.Transparent;
            this.movimientosLabel.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimientosLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(96)))));
            this.movimientosLabel.Location = new System.Drawing.Point(717, 241);
            this.movimientosLabel.Name = "movimientosLabel";
            this.movimientosLabel.Size = new System.Drawing.Size(247, 35);
            this.movimientosLabel.TabIndex = 32;
            this.movimientosLabel.Text = "MOVIMIENTOS";
            this.movimientosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movimiento1
            // 
            this.movimiento1.BackColor = System.Drawing.Color.Transparent;
            this.movimiento1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimiento1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(96)))));
            this.movimiento1.Location = new System.Drawing.Point(717, 298);
            this.movimiento1.Name = "movimiento1";
            this.movimiento1.Size = new System.Drawing.Size(195, 42);
            this.movimiento1.TabIndex = 33;
            this.movimiento1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movimiento2
            // 
            this.movimiento2.BackColor = System.Drawing.Color.Transparent;
            this.movimiento2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimiento2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(96)))));
            this.movimiento2.Location = new System.Drawing.Point(937, 298);
            this.movimiento2.Name = "movimiento2";
            this.movimiento2.Size = new System.Drawing.Size(195, 42);
            this.movimiento2.TabIndex = 34;
            this.movimiento2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movimiento3
            // 
            this.movimiento3.BackColor = System.Drawing.Color.Transparent;
            this.movimiento3.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimiento3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(96)))));
            this.movimiento3.Location = new System.Drawing.Point(717, 353);
            this.movimiento3.Name = "movimiento3";
            this.movimiento3.Size = new System.Drawing.Size(195, 42);
            this.movimiento3.TabIndex = 35;
            this.movimiento3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movimiento4
            // 
            this.movimiento4.BackColor = System.Drawing.Color.Transparent;
            this.movimiento4.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimiento4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(96)))));
            this.movimiento4.Location = new System.Drawing.Point(937, 353);
            this.movimiento4.Name = "movimiento4";
            this.movimiento4.Size = new System.Drawing.Size(195, 42);
            this.movimiento4.TabIndex = 36;
            this.movimiento4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C_sharp_Pokedex.Properties.Resources.pokedex;
            this.ClientSize = new System.Drawing.Size(1244, 861);
            this.Controls.Add(this.movimiento4);
            this.Controls.Add(this.movimiento3);
            this.Controls.Add(this.movimiento2);
            this.Controls.Add(this.movimiento1);
            this.Controls.Add(this.movimientosLabel);
            this.Controls.Add(this.especieLabel);
            this.Controls.Add(this.tipo2Label);
            this.Controls.Add(this.tipo1Label);
            this.Controls.Add(this.pesoLael);
            this.Controls.Add(this.alturaLabel);
            this.Controls.Add(this.especiePkmn);
            this.Controls.Add(this.tipo2);
            this.Controls.Add(this.tipo1);
            this.Controls.Add(this.pesoPkmn);
            this.Controls.Add(this.alturaPkmn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.der);
            this.Controls.Add(this.izq);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.res5);
            this.Controls.Add(this.sum5);
            this.Controls.Add(this.numPkmn);
            this.Controls.Add(this.nombrePkmn);
            this.Controls.Add(this.imagenPkmn);
            this.Controls.Add(this.off);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaPrincipal";
            this.Text = "VentanaPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.imagenPkmn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagenPkmn;
        private System.Windows.Forms.Button off;
        private System.Windows.Forms.Button res5;
        private System.Windows.Forms.Button sum5;
        private System.Windows.Forms.Label numPkmn;
        private System.Windows.Forms.Label nombrePkmn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button izq;
        private System.Windows.Forms.Button der;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label alturaPkmn;
        private System.Windows.Forms.Label pesoPkmn;
        private System.Windows.Forms.Label tipo1;
        private System.Windows.Forms.Label tipo2;
        private System.Windows.Forms.Label especiePkmn;
        private System.Windows.Forms.Label alturaLabel;
        private System.Windows.Forms.Label pesoLael;
        private System.Windows.Forms.Label tipo1Label;
        private System.Windows.Forms.Label tipo2Label;
        private System.Windows.Forms.Label especieLabel;
        private System.Windows.Forms.Label movimientosLabel;
        private System.Windows.Forms.Label movimiento1;
        private System.Windows.Forms.Label movimiento2;
        private System.Windows.Forms.Label movimiento3;
        private System.Windows.Forms.Label movimiento4;
    }
}
namespace Mundial
{
    partial class octavos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(octavos));
            this.dgvOctavos = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCuartos = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPenales2 = new System.Windows.Forms.Label();
            this.cantPenales2 = new System.Windows.Forms.TextBox();
            this.txtPenales1 = new System.Windows.Forms.Label();
            this.cantPenales1 = new System.Windows.Forms.TextBox();
            this.btnCargarPenales = new System.Windows.Forms.Button();
            this.txtGoles1 = new System.Windows.Forms.Label();
            this.cantGoles1 = new System.Windows.Forms.TextBox();
            this.btnCargaPartido = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lbFecha = new System.Windows.Forms.Label();
            this.txtPais2 = new System.Windows.Forms.TextBox();
            this.txtPais1 = new System.Windows.Forms.TextBox();
            this.txtGoles2 = new System.Windows.Forms.Label();
            this.cantGoles2 = new System.Windows.Forms.TextBox();
            this.ElegirPartido = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOctavos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOctavos
            // 
            this.dgvOctavos.AllowUserToAddRows = false;
            this.dgvOctavos.AllowUserToDeleteRows = false;
            this.dgvOctavos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOctavos.Location = new System.Drawing.Point(80, 35);
            this.dgvOctavos.Name = "dgvOctavos";
            this.dgvOctavos.ReadOnly = true;
            this.dgvOctavos.Size = new System.Drawing.Size(775, 425);
            this.dgvOctavos.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(929, 559);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Mundial.Properties.Resources.FondoPasto;
            this.tabPage2.Controls.Add(this.dgvOctavos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(921, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::Mundial.Properties.Resources.FondoPasto;
            this.tabPage3.Controls.Add(this.btnCuartos);
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.txtPenales2);
            this.tabPage3.Controls.Add(this.cantPenales2);
            this.tabPage3.Controls.Add(this.txtPenales1);
            this.tabPage3.Controls.Add(this.cantPenales1);
            this.tabPage3.Controls.Add(this.btnCargarPenales);
            this.tabPage3.Controls.Add(this.txtGoles1);
            this.tabPage3.Controls.Add(this.cantGoles1);
            this.tabPage3.Controls.Add(this.btnCargaPartido);
            this.tabPage3.Controls.Add(this.txtFecha);
            this.tabPage3.Controls.Add(this.lbFecha);
            this.tabPage3.Controls.Add(this.txtPais2);
            this.tabPage3.Controls.Add(this.txtPais1);
            this.tabPage3.Controls.Add(this.txtGoles2);
            this.tabPage3.Controls.Add(this.cantGoles2);
            this.tabPage3.Controls.Add(this.ElegirPartido);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(921, 533);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Partidos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCuartos
            // 
            this.btnCuartos.BackColor = System.Drawing.Color.Transparent;
            this.btnCuartos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuartos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuartos.Location = new System.Drawing.Point(367, 350);
            this.btnCuartos.Name = "btnCuartos";
            this.btnCuartos.Size = new System.Drawing.Size(208, 31);
            this.btnCuartos.TabIndex = 101;
            this.btnCuartos.Text = "PASE A CUARTOS";
            this.btnCuartos.UseVisualStyleBackColor = false;
            this.btnCuartos.Visible = false;
            this.btnCuartos.Click += new System.EventHandler(this.btnCuartos_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Silver;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Mundial.Properties.Resources.bandera_blanca;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(635, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(261, 182);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 100;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Mundial.Properties.Resources.bandera_blanca;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtPenales2
            // 
            this.txtPenales2.AutoSize = true;
            this.txtPenales2.BackColor = System.Drawing.Color.Transparent;
            this.txtPenales2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenales2.Location = new System.Drawing.Point(724, 425);
            this.txtPenales2.Name = "txtPenales2";
            this.txtPenales2.Size = new System.Drawing.Size(90, 20);
            this.txtPenales2.TabIndex = 97;
            this.txtPenales2.Text = "PENALES";
            this.txtPenales2.Visible = false;
            // 
            // cantPenales2
            // 
            this.cantPenales2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantPenales2.Location = new System.Drawing.Point(621, 448);
            this.cantPenales2.Name = "cantPenales2";
            this.cantPenales2.Size = new System.Drawing.Size(275, 22);
            this.cantPenales2.TabIndex = 96;
            this.cantPenales2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cantPenales2.Visible = false;
            // 
            // txtPenales1
            // 
            this.txtPenales1.AutoSize = true;
            this.txtPenales1.BackColor = System.Drawing.Color.Transparent;
            this.txtPenales1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenales1.Location = new System.Drawing.Point(115, 425);
            this.txtPenales1.Name = "txtPenales1";
            this.txtPenales1.Size = new System.Drawing.Size(90, 20);
            this.txtPenales1.TabIndex = 95;
            this.txtPenales1.Text = "PENALES";
            this.txtPenales1.Visible = false;
            // 
            // cantPenales1
            // 
            this.cantPenales1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantPenales1.Location = new System.Drawing.Point(22, 448);
            this.cantPenales1.Name = "cantPenales1";
            this.cantPenales1.Size = new System.Drawing.Size(275, 22);
            this.cantPenales1.TabIndex = 94;
            this.cantPenales1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cantPenales1.Visible = false;
            // 
            // btnCargarPenales
            // 
            this.btnCargarPenales.BackColor = System.Drawing.Color.Transparent;
            this.btnCargarPenales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarPenales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarPenales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarPenales.Location = new System.Drawing.Point(348, 468);
            this.btnCargarPenales.Name = "btnCargarPenales";
            this.btnCargarPenales.Size = new System.Drawing.Size(227, 35);
            this.btnCargarPenales.TabIndex = 93;
            this.btnCargarPenales.Text = "CARGAR PENALES";
            this.btnCargarPenales.UseVisualStyleBackColor = false;
            this.btnCargarPenales.Visible = false;
            this.btnCargarPenales.Click += new System.EventHandler(this.btnCargarPenales_Click);
            // 
            // txtGoles1
            // 
            this.txtGoles1.AutoSize = true;
            this.txtGoles1.BackColor = System.Drawing.Color.Transparent;
            this.txtGoles1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoles1.Location = new System.Drawing.Point(125, 361);
            this.txtGoles1.Name = "txtGoles1";
            this.txtGoles1.Size = new System.Drawing.Size(70, 20);
            this.txtGoles1.TabIndex = 92;
            this.txtGoles1.Text = "GOLES";
            this.txtGoles1.Visible = false;
            // 
            // cantGoles1
            // 
            this.cantGoles1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantGoles1.Location = new System.Drawing.Point(22, 384);
            this.cantGoles1.Name = "cantGoles1";
            this.cantGoles1.Size = new System.Drawing.Size(275, 22);
            this.cantGoles1.TabIndex = 91;
            this.cantGoles1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cantGoles1.Visible = false;
            // 
            // btnCargaPartido
            // 
            this.btnCargaPartido.BackColor = System.Drawing.Color.Transparent;
            this.btnCargaPartido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargaPartido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargaPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaPartido.Location = new System.Drawing.Point(348, 401);
            this.btnCargaPartido.Name = "btnCargaPartido";
            this.btnCargaPartido.Size = new System.Drawing.Size(227, 35);
            this.btnCargaPartido.TabIndex = 88;
            this.btnCargaPartido.Text = "CARGAR PARTIDO";
            this.btnCargaPartido.UseVisualStyleBackColor = false;
            this.btnCargaPartido.Visible = false;
            this.btnCargaPartido.Click += new System.EventHandler(this.btnCargaEqUno_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(492, 136);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(64, 22);
            this.txtFecha.TabIndex = 87;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFecha.Visible = false;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.BackColor = System.Drawing.Color.Transparent;
            this.lbFecha.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(386, 133);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(100, 24);
            this.lbFecha.TabIndex = 86;
            this.lbFecha.Text = "FECHA:";
            this.lbFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbFecha.Visible = false;
            // 
            // txtPais2
            // 
            this.txtPais2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPais2.BackColor = System.Drawing.SystemColors.Control;
            this.txtPais2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPais2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPais2.Location = new System.Drawing.Point(620, 303);
            this.txtPais2.Name = "txtPais2";
            this.txtPais2.Size = new System.Drawing.Size(275, 31);
            this.txtPais2.TabIndex = 85;
            this.txtPais2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPais2.Visible = false;
            // 
            // txtPais1
            // 
            this.txtPais1.BackColor = System.Drawing.SystemColors.Control;
            this.txtPais1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPais1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPais1.Location = new System.Drawing.Point(22, 303);
            this.txtPais1.Name = "txtPais1";
            this.txtPais1.Size = new System.Drawing.Size(275, 31);
            this.txtPais1.TabIndex = 82;
            this.txtPais1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPais1.Visible = false;
            // 
            // txtGoles2
            // 
            this.txtGoles2.AutoSize = true;
            this.txtGoles2.BackColor = System.Drawing.Color.Transparent;
            this.txtGoles2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoles2.Location = new System.Drawing.Point(733, 361);
            this.txtGoles2.Name = "txtGoles2";
            this.txtGoles2.Size = new System.Drawing.Size(70, 20);
            this.txtGoles2.TabIndex = 79;
            this.txtGoles2.Text = "GOLES";
            this.txtGoles2.Visible = false;
            // 
            // cantGoles2
            // 
            this.cantGoles2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantGoles2.Location = new System.Drawing.Point(621, 384);
            this.cantGoles2.Name = "cantGoles2";
            this.cantGoles2.Size = new System.Drawing.Size(275, 22);
            this.cantGoles2.TabIndex = 76;
            this.cantGoles2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cantGoles2.Visible = false;
            // 
            // ElegirPartido
            // 
            this.ElegirPartido.FormattingEnabled = true;
            this.ElegirPartido.Items.AddRange(new object[] {
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56"});
            this.ElegirPartido.Location = new System.Drawing.Point(492, 94);
            this.ElegirPartido.Name = "ElegirPartido";
            this.ElegirPartido.Size = new System.Drawing.Size(86, 21);
            this.ElegirPartido.TabIndex = 69;
            this.ElegirPartido.SelectedIndexChanged += new System.EventHandler(this.ElegirPartido_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(363, 94);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(123, 24);
            this.label20.TabIndex = 68;
            this.label20.Text = "PARTIDO:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // octavos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mundial.Properties.Resources.FondoForm;
            this.ClientSize = new System.Drawing.Size(955, 582);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "octavos";
            this.Text = "octavos";
            this.Load += new System.EventHandler(this.octavos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOctavos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvOctavos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnCargaPartido;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.TextBox txtPais2;
        private System.Windows.Forms.TextBox txtPais1;
        private System.Windows.Forms.Label txtGoles2;
        private System.Windows.Forms.TextBox cantGoles2;
        private System.Windows.Forms.ComboBox ElegirPartido;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label txtPenales2;
        private System.Windows.Forms.TextBox cantPenales2;
        private System.Windows.Forms.Label txtPenales1;
        private System.Windows.Forms.TextBox cantPenales1;
        private System.Windows.Forms.Button btnCargarPenales;
        private System.Windows.Forms.Label txtGoles1;
        private System.Windows.Forms.TextBox cantGoles1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCuartos;
    }
}
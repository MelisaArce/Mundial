/*
 * Created by SharpDevelop.
 * User: Alumno
 * Date: 14/11/2022
 * Time: 10:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Mundial
{
	partial class Menu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnOctavos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCuartos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSemi = new System.Windows.Forms.Button();
            this.btnFinal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOctavos
            // 
            this.btnOctavos.BackColor = System.Drawing.Color.Transparent;
            this.btnOctavos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOctavos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOctavos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOctavos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOctavos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOctavos.Location = new System.Drawing.Point(31, 165);
            this.btnOctavos.Name = "btnOctavos";
            this.btnOctavos.Size = new System.Drawing.Size(356, 63);
            this.btnOctavos.TabIndex = 0;
            this.btnOctavos.Text = "OCTAVOS";
            this.btnOctavos.UseVisualStyleBackColor = false;
            this.btnOctavos.Click += new System.EventHandler(this.btnOctavosClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(31, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(356, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "FASE DE GRUPOS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2Click);
            // 
            // btnCuartos
            // 
            this.btnCuartos.BackColor = System.Drawing.Color.Transparent;
            this.btnCuartos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCuartos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuartos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCuartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuartos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCuartos.Location = new System.Drawing.Point(31, 243);
            this.btnCuartos.Name = "btnCuartos";
            this.btnCuartos.Size = new System.Drawing.Size(356, 63);
            this.btnCuartos.TabIndex = 2;
            this.btnCuartos.Text = "CUARTOS";
            this.btnCuartos.UseVisualStyleBackColor = false;
            this.btnCuartos.Click += new System.EventHandler(this.btnCuartosClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "MENU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSemi
            // 
            this.btnSemi.BackColor = System.Drawing.Color.Transparent;
            this.btnSemi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSemi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSemi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSemi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSemi.Location = new System.Drawing.Point(31, 326);
            this.btnSemi.Name = "btnSemi";
            this.btnSemi.Size = new System.Drawing.Size(356, 63);
            this.btnSemi.TabIndex = 4;
            this.btnSemi.Text = "SEMI";
            this.btnSemi.UseVisualStyleBackColor = false;
            this.btnSemi.Click += new System.EventHandler(this.btnSemi_Click);
            // 
            // btnFinal
            // 
            this.btnFinal.BackColor = System.Drawing.Color.Transparent;
            this.btnFinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinal.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFinal.Location = new System.Drawing.Point(31, 411);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(356, 63);
            this.btnFinal.TabIndex = 5;
            this.btnFinal.Text = "FINAL";
            this.btnFinal.UseVisualStyleBackColor = false;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(411, 512);
            this.Controls.Add(this.btnFinal);
            this.Controls.Add(this.btnSemi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCuartos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOctavos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuLoad);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCuartos;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnOctavos;
        private System.Windows.Forms.Button btnSemi;
        private System.Windows.Forms.Button btnFinal;
    }
}

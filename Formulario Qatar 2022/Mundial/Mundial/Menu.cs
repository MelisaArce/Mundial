/*
 * Created by SharpDevelop.
 * User: Alumno
 * Date: 14/11/2022
 * Time: 10:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mundial
{
	/// <summary>
	/// Description of Menu.
	/// </summary>
	public partial class Menu : Form
	{
		
		faseDeGrupos faseDeGrupos = new faseDeGrupos();
		octavos octavos = new octavos();
		cuartos cuartos = new cuartos();
		semi semi = new semi();
		final final = new final();
		
		public Menu()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}		
		
		void MenuLoad(object sender, EventArgs e)
		{
			
		}
		void Button2Click(object sender, EventArgs e) // fase de grupos
		{
            faseDeGrupos.ControlSection.SelectedIndex = 0;
            faseDeGrupos.ShowDialog();
		}

		void btnOctavosClick(object sender, EventArgs e) // octavos
		{
			//octavos.ControlSection.SelectedIndex = 1;

			octavos.ShowDialog();
		}		
		
		void btnCuartosClick(object sender, EventArgs e) // Cuartos
		{
			//cuartos.ControlSection.SelectedIndex = 2;
			cuartos.ShowDialog();
		}

		private void btnSemi_Click(object sender, EventArgs e) // SEMI
		{
			semi.ShowDialog();
		}

		private void btnFinal_Click(object sender, EventArgs e) //FINAL
		{
			final.ShowDialog();
		}
	}
}

using Mundial.DATOS;
using Mundial.PARTIDOS;
using Mundial.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mundial
{
    public partial class final : Form
    {
        public final()
        {
            InitializeComponent();
        }

        private void final_Load(object sender, EventArgs e)
        {
            LlenarGridFinal();
        }

        int ganador1 = 1;
        int ganador2 = 2;
        int id_partido;

        public void GanaOpierde() //sin penales
        {
            //EN EL PARTIDO 63

            if (id_partido == 63)
            {
                if (Convert.ToInt32(cantGoles1.Text) > Convert.ToInt32(cantGoles2.Text)) //SI GANA
                {
                    Partido partido = crudPartidos.DevuelveGanadorF(ganador1);
                    crudPartidos.InsertarFinal(partido);
                }
                else
                {
                    Partido partido = crudPartidos.DevuelveGanadorF(ganador2);
                    crudPartidos.InsertarFinal(partido);
                }

            }


        }
        public void GanaOpierdePenales()
        {
            //EN EL PARTIDO 63

            if (id_partido == 63)
            {
                if (Convert.ToInt32(cantPenales1.Text) > Convert.ToInt32(cantPenales2.Text)) //SI GANA
                {
                    Partido partido = crudPartidos.DevuelveGanadorF(ganador1);
                    crudPartidos.InsertarFinal(partido);
                }
                else
                {
                    Partido partido = crudPartidos.DevuelveGanadorF(ganador2);
                    crudPartidos.InsertarFinal(partido);
                }

            }
        }
        private void LlenarGridFinal()
        {


            DataTable datos = crudPartidos.posicionesSemi();

            if (datos == null)
            {
                MessageBox.Show("No se logro generar la tabla de octavos");
            }
            else
            {
                dataGridView1.DataSource = datos.DefaultView; //retorna a una lista el default es la vista por defecto de la base
            }

        }

        private void btnCargaPartido_Click(object sender, EventArgs e)
        {
            if (cantGoles1.Text == "" || cantGoles2.Text == "" ||
                Convert.ToInt32(cantGoles1.Text.Trim()) < 0 || Convert.ToInt32(cantGoles1.Text.Trim()) >= 20 ||
                Convert.ToInt32(cantGoles2.Text.Trim()) < 0 || Convert.ToInt32(cantGoles2.Text.Trim()) >= 20
                )
            {
                MessageBox.Show("ERROR: Verifique que los campos no esten vacios o el rango de goles no es aceptado.");
            }
            if (Convert.ToInt32(cantGoles1.Text.Trim()) == Convert.ToInt32(cantGoles2.Text.Trim()))
            {
                btnCargarPenales.Visible = true;
                btnCargaPartido.Visible = false;
                cantPenales1.Visible = true;
                cantPenales2.Visible = true;
                cantPenales1.Visible = true;
                cantPenales2.Visible = true;
            }
            else
            {
                GanaOpierde();
                MostrarGanador();

            }

            cantGoles1.Enabled = false;
            cantGoles2.Enabled = false;
        }


        private void btnCargarPenales_Click(object sender, EventArgs e)
        {
            btnCargarPenales.Visible = false;
            cantPenales1.Visible = false;
            cantPenales2.Visible = false;
            //Penales1.Visible = false;
            // txtPenales2.Visible = false;
            if (cantPenales1.Text == "" || cantPenales2.Text == "" ||
                   Convert.ToInt32(cantPenales1.Text.Trim()) < 0 || Convert.ToInt32(cantPenales1.Text.Trim()) >= 20 ||
                   Convert.ToInt32(cantPenales2.Text.Trim()) < 0 || Convert.ToInt32(cantPenales2.Text.Trim()) >= 20
                   )
            {
                MessageBox.Show("ERROR: Verifique que los campos no esten vacios o el rango de goles no es aceptado.");
            }
            if (Convert.ToInt32(cantGoles1.Text) == Convert.ToInt32(cantGoles2.Text))
            {

                GanaOpierdePenales();
                MostrarGanador();

            }
            else
            {
                MessageBox.Show("El partido no fue a Penales, utilice carga directa");
            }



        }

        private void ElegirPartido_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCargaPartido.Visible = true;
           // btnOctavos.Visible = true;

            pictureBox1.Visible = true;
            pictureBox21.Visible = true;

            txtPais1.Visible = true;
            txtPais1.Enabled = false;

            txtPais3.Visible = true;
            txtPais3.Enabled = false;

            lbFecha.Visible = true;
            txtFecha.Visible = true;

            cantGoles1.Visible = true;
            cantGoles2.Visible = true;

            txtpais2.Visible = true;
            txtpais2.Enabled = false;

            if (ElegirPartido.SelectedIndex == 0) // PARTIDO [63]
            {
                //MOSTRAR PAISES
                string equipoAleatorio = "";
                string equipoAleatorio2 = "";

                equipoAleatorio = crudPartidos.DevuelveIDGanadorF(ganador1); //GANADOR 1

                if (equipoAleatorio == "A1")
                {
                    pictureBox1.Image = Resources.BanQatar;
                    txtPais1.Text = "Qatar";
                }
                if (equipoAleatorio == "A2")
                {
                    pictureBox1.Image = Resources.BanEcuador;
                    txtPais1.Text = "Ecuador";
                }
                if (equipoAleatorio == "A3")
                {
                    pictureBox1.Image = Resources.BanSenegal;
                    txtPais1.Text = "Senegal";
                }
                if (equipoAleatorio == "A4")
                {
                    pictureBox1.Image = Resources.BanPaisesBajos;
                    txtPais1.Text = "Paises Bajos";
                }
                if (equipoAleatorio == "B1")
                {
                    pictureBox1.Image = Resources.BanInglaterra;
                    txtPais1.Text = "Inglaterra";
                }
                if (equipoAleatorio == "B2")
                {
                    pictureBox1.Image = Resources.BanIràn;
                    txtPais1.Text = "Iran";
                }
                if (equipoAleatorio == "B3")
                {
                    pictureBox1.Image = Resources.BanEEUU;
                    txtPais1.Text = "EE.UU";
                }
                if (equipoAleatorio == "B4")
                {
                    pictureBox1.Image = Resources.BanGales;
                    txtPais1.Text = "Gales";
                }
                if (equipoAleatorio == "C1")
                {
                    pictureBox1.Image = Resources.BanArgentina;
                    txtPais1.Text = "Argentina";
                }
                if (equipoAleatorio == "C2")
                {
                    pictureBox1.Image = Resources.BanArabiaSaudita;
                    txtPais1.Text = "Arabia Saudita";
                }
                if (equipoAleatorio == "C3")
                {
                    pictureBox1.Image = Resources.BanMex;
                    txtPais1.Text = "México";
                }
                if (equipoAleatorio == "C4")
                {
                    pictureBox1.Image = Resources.BanPolonia;
                    txtPais1.Text = "Polonia";
                }
                if (equipoAleatorio == "D1")
                {
                    pictureBox1.Image = Resources.BanFrancia;
                    txtPais1.Text = "Francia";
                }
                if (equipoAleatorio == "D2")
                {
                    pictureBox1.Image = Resources.BanAustralia;
                    txtPais1.Text = "Australia";
                }
                if (equipoAleatorio == "D3")
                {
                    pictureBox1.Image = Resources.BanDinamarca;
                    txtPais1.Text = "Dinamarca";
                }
                if (equipoAleatorio == "D4")
                {
                    pictureBox1.Image = Resources.BanTunez;
                    txtPais1.Text = "Túnez";
                }
                if (equipoAleatorio == "E1")
                {
                    pictureBox1.Image = Resources.BanEspaña;
                    txtPais1.Text = "España";
                }
                if (equipoAleatorio == "E2")
                {
                    pictureBox1.Image = Resources.BanCostaRica;
                    txtPais1.Text = "Costa Rica";
                }
                if (equipoAleatorio == "E3")
                {
                    pictureBox1.Image = Resources.BanAlemania;
                    txtPais1.Text = "Alemania";
                }
                if (equipoAleatorio == "E4")
                {
                    pictureBox1.Image = Resources.BanJapon;
                    txtPais1.Text = "Japón";
                }
                if (equipoAleatorio == "F1")
                {
                    pictureBox1.Image = Resources.BanBelgica;
                    txtPais1.Text = "Bélgica";
                }
                if (equipoAleatorio == "F2")
                {
                    pictureBox1.Image = Resources.BanCanada;
                    txtPais1.Text = "Canadá";
                }
                if (equipoAleatorio == "F3")
                {
                    pictureBox1.Image = Resources.BanMarruecos;
                    txtPais1.Text = "Marruecos";
                }
                if (equipoAleatorio == "F4")
                {
                    pictureBox1.Image = Resources.BanCroacia;
                    txtPais1.Text = "Croacia";
                }
                if (equipoAleatorio == "G1")
                {
                    pictureBox1.Image = Resources.BanBrasil;
                    txtPais1.Text = "Brasil";
                }
                if (equipoAleatorio == "G2")
                {
                    pictureBox1.Image = Resources.BanSerbia;
                    txtPais1.Text = "Serbia";
                }
                if (equipoAleatorio == "G3")
                {
                    pictureBox1.Image = Resources.BanSuiza;
                    txtPais1.Text = "Suiza";
                }
                if (equipoAleatorio == "G4")
                {
                    pictureBox1.Image = Resources.BanCamerun;
                    txtPais1.Text = "Camerún";
                }
                if (equipoAleatorio == "H1")
                {
                    pictureBox1.Image = Resources.BanPortugal;
                    txtPais1.Text = "Portugal";
                }
                if (equipoAleatorio == "H2")
                {
                    pictureBox1.Image = Resources.BanGhana;
                    txtPais1.Text = "Ghana";
                }
                if (equipoAleatorio == "H3")
                {
                    pictureBox1.Image = Resources.BanUruguay;
                    txtPais1.Text = "Uruguay";
                }
                if (equipoAleatorio == "H4")
                {
                    pictureBox1.Image = Resources.BanCoreaDelSur;
                    txtPais1.Text = "Republica de Corea";
                }
                equipoAleatorio2 = crudPartidos.DevuelveIDGanadorF(ganador2); //GANADOR 2

                if (equipoAleatorio2 == "A1")
                {
                    pictureBox21.Image = Resources.BanQatar;
                    txtpais2.Text = "Qatar";
                }
                if (equipoAleatorio2 == "A2")
                {
                    pictureBox21.Image = Resources.BanEcuador;
                    txtpais2.Text = "Ecuador";
                }
                if (equipoAleatorio2 == "A3")
                {
                    pictureBox21.Image = Resources.BanSenegal;
                    txtpais2.Text = "Senegal";
                }
                if (equipoAleatorio2 == "A4")
                {
                    pictureBox21.Image = Resources.BanPaisesBajos;
                    txtpais2.Text = "Paises Bajos";
                }
                if (equipoAleatorio2 == "B1")
                {
                    pictureBox21.Image = Resources.BanInglaterra;
                    txtpais2.Text = "Inglaterra";
                }
                if (equipoAleatorio2 == "B2")
                {
                    pictureBox21.Image = Resources.BanIràn;
                    txtpais2.Text = "Iran";
                }
                if (equipoAleatorio2 == "B3")
                {
                    pictureBox21.Image = Resources.BanEEUU;
                    txtpais2.Text = "EE.UU";
                }
                if (equipoAleatorio2 == "B4")
                {
                    pictureBox21.Image = Resources.BanGales;
                    txtpais2.Text = "Gales";
                }
                if (equipoAleatorio2 == "C1")
                {
                    pictureBox21.Image = Resources.BanArgentina;
                    txtpais2.Text = "Argentina";
                }
                if (equipoAleatorio2 == "C2")
                {
                    pictureBox21.Image = Resources.BanArabiaSaudita;
                    txtpais2.Text = "Arabia Saudita";
                }
                if (equipoAleatorio2 == "C3")
                {
                    pictureBox21.Image = Resources.BanMex;
                    txtpais2.Text = "México";
                }
                if (equipoAleatorio2 == "C4")
                {
                    pictureBox21.Image = Resources.BanPolonia;
                    txtpais2.Text = "Polonia";
                }
                if (equipoAleatorio2 == "D1")
                {
                    pictureBox21.Image = Resources.BanFrancia;
                    txtpais2.Text = "Francia";
                }
                if (equipoAleatorio2 == "D2")
                {
                    pictureBox21.Image = Resources.BanAustralia;
                    txtpais2.Text = "Australia";
                }
                if (equipoAleatorio2 == "D3")
                {
                    pictureBox21.Image = Resources.BanDinamarca;
                    txtpais2.Text = "Dinamarca";
                }
                if (equipoAleatorio2 == "D4")
                {
                    pictureBox21.Image = Resources.BanTunez;
                    txtpais2.Text = "Túnez";
                }
                if (equipoAleatorio2 == "E1")
                {
                    pictureBox21.Image = Resources.BanEspaña;
                    txtpais2.Text = "España";
                }
                if (equipoAleatorio2 == "E2")
                {
                    pictureBox21.Image = Resources.BanCostaRica;
                    txtpais2.Text = "Costa Rica";
                }
                if (equipoAleatorio2 == "E3")
                {
                    pictureBox21.Image = Resources.BanAlemania;
                    txtpais2.Text = "Alemania";
                }
                if (equipoAleatorio2 == "E4")
                {
                    pictureBox21.Image = Resources.BanJapon;
                    txtpais2.Text = "Japón";
                }
                if (equipoAleatorio2 == "F1")
                {
                    pictureBox21.Image = Resources.BanBelgica;
                    txtpais2.Text = "Bélgica";
                }
                if (equipoAleatorio2 == "F2")
                {
                    pictureBox21.Image = Resources.BanCanada;
                    txtpais2.Text = "Canadá";
                }
                if (equipoAleatorio2 == "F3")
                {
                    pictureBox21.Image = Resources.BanMarruecos;
                    txtpais2.Text = "Marruecos";
                }
                if (equipoAleatorio2 == "F4")
                {
                    pictureBox21.Image = Resources.BanCroacia;
                    txtpais2.Text = "Croacia";
                }
                if (equipoAleatorio2 == "G1")
                {
                    pictureBox21.Image = Resources.BanBrasil;
                    txtpais2.Text = "Brasil";
                }
                if (equipoAleatorio2 == "G2")
                {
                    pictureBox21.Image = Resources.BanSerbia;
                    txtpais2.Text = "Serbia";
                }
                if (equipoAleatorio2 == "G3")
                {
                    pictureBox21.Image = Resources.BanSuiza;
                    txtpais2.Text = "Suiza";
                }
                if (equipoAleatorio2 == "G4")
                {
                    pictureBox21.Image = Resources.BanCamerun;
                    txtpais2.Text = "Camerún";
                }
                if (equipoAleatorio2 == "H1")
                {
                    pictureBox21.Image = Resources.BanPortugal;
                    txtpais2.Text = "Portugal";
                }
                if (equipoAleatorio2 == "H2")
                {
                    pictureBox21.Image = Resources.BanGhana;
                    txtpais2.Text = "Ghana";
                }
                if (equipoAleatorio2 == "H3")
                {
                    pictureBox21.Image = Resources.BanUruguay;
                    txtpais2.Text = "Uruguay";
                }
                if (equipoAleatorio2 == "H4")
                {
                    pictureBox21.Image = Resources.BanCoreaDelSur;
                    txtpais2.Text = "Republica de Corea";
                }

                txtFecha.Text = "18/12";
                id_partido = 63;
                
            }

        }

        private void cantPenales2_TextChanged(object sender, EventArgs e)
        {

        }
        public void MostrarGanador()
        {
            string equipoAleatorio3;
            equipoAleatorio3 = crudPartidos.DevuelveIDGanadorFinal(ganador1); //GANADOR 1

            if (equipoAleatorio3 == "A1")
            {
                pictureBox3.Image = Resources.BanQatar;
                txtPais3.Text = "Qatar";
            }
            if (equipoAleatorio3== "A2")
            {
                pictureBox3.Image = Resources.BanEcuador;
                txtPais3.Text = "Ecuador";
            }
            if (equipoAleatorio3 == "A3")
            {
                pictureBox3.Image = Resources.BanSenegal;
                txtPais3.Text = "Senegal";
            }
            if (equipoAleatorio3== "A4")
            {
                pictureBox3.Image = Resources.BanPaisesBajos;
                txtPais3.Text = "Paises Bajos";
            }
            if (equipoAleatorio3 == "B1")
            {
                pictureBox3.Image = Resources.BanInglaterra;
                txtPais3.Text = "Inglaterra";
            }
            if (equipoAleatorio3 == "B2")
            {
                pictureBox3.Image = Resources.BanIràn;
                txtPais3.Text = "Iran";
            }
            if (equipoAleatorio3 == "B3")
            {
                pictureBox3.Image = Resources.BanEEUU;
                txtPais3.Text = "EE.UU";
            }
            if (equipoAleatorio3 == "B4")
            {
                pictureBox3.Image = Resources.BanGales;
                txtPais3.Text = "Gales";
            }
            if (equipoAleatorio3 == "C1")
            {
                pictureBox3.Image = Resources.BanArgentina;
                txtPais3.Text = "Argentina";
            }
            if (equipoAleatorio3 == "C2")
            {
                pictureBox3.Image = Resources.BanArabiaSaudita;
                txtPais3.Text = "Arabia Saudita";
            }
            if (equipoAleatorio3 == "C3")
            {
                pictureBox3.Image = Resources.BanMex;
                txtPais3.Text = "México";
            }
            if (equipoAleatorio3 == "C4")
            {
                pictureBox3.Image = Resources.BanPolonia;
                txtPais3.Text = "Polonia";
            }
            if (equipoAleatorio3 == "D1")
            {
                pictureBox3.Image = Resources.BanFrancia;
                txtPais3.Text = "Francia";
            }
            if (equipoAleatorio3 == "D2")
            {
                pictureBox3.Image = Resources.BanAustralia;
                txtPais3.Text = "Australia";
            }
            if (equipoAleatorio3 == "D3")
            {
                pictureBox3.Image = Resources.BanDinamarca;
                txtPais3.Text = "Dinamarca";
            }
            if (equipoAleatorio3 == "D4")
            {
                pictureBox3.Image = Resources.BanTunez;
                txtPais3.Text = "Túnez";
            }
            if (equipoAleatorio3 == "E1")
            {
                pictureBox3.Image = Resources.BanEspaña;
                txtPais3.Text = "España";
            }
            if (equipoAleatorio3 == "E2")
            {
                pictureBox3.Image = Resources.BanCostaRica;
                txtPais3.Text = "Costa Rica";
            }
            if (equipoAleatorio3 == "E3")
            {
                pictureBox3.Image = Resources.BanAlemania;
                txtPais3.Text = "Alemania";
            }
            if (equipoAleatorio3 == "E4")
            {
                pictureBox3.Image = Resources.BanJapon;
                txtPais3.Text = "Japón";
            }
            if (equipoAleatorio3 == "F1")
            {
                pictureBox3.Image = Resources.BanBelgica;
                txtPais3.Text = "Bélgica";
            }
            if (equipoAleatorio3 == "F2")
            {
                pictureBox3.Image = Resources.BanCanada;
                txtPais3.Text = "Canadá";
            }
            if (equipoAleatorio3 == "F3")
            {
                pictureBox3.Image = Resources.BanMarruecos;
                txtPais3.Text = "Marruecos";
            }
            if (equipoAleatorio3 == "F4")
            {
                pictureBox3.Image = Resources.BanCroacia;
                txtPais3.Text = "Croacia";
            }
            if (equipoAleatorio3 == "G1")
            {
                pictureBox3.Image = Resources.BanBrasil;
                txtPais3.Text = "Brasil";
            }
            if (equipoAleatorio3 == "G2")
            {
                pictureBox3.Image = Resources.BanSerbia;
                txtPais3.Text = "Serbia";
            }
            if (equipoAleatorio3 == "G3")
            {
                pictureBox3.Image = Resources.BanSuiza;
                txtPais3.Text = "Suiza";
            }
            if (equipoAleatorio3 == "G4")
            {
                pictureBox3.Image = Resources.BanCamerun;
                txtPais3.Text = "Camerún";
            }
            if (equipoAleatorio3 == "H1")
            {
                pictureBox3.Image = Resources.BanPortugal;
                txtPais3.Text = "Portugal";
            }
            if (equipoAleatorio3 == "H2")
            {
                pictureBox3.Image = Resources.BanGhana;
                txtPais3.Text = "Ghana";
            }
            if (equipoAleatorio3 == "H3")
            {
                pictureBox3.Image = Resources.BanUruguay;
                txtPais3.Text = "Uruguay";
            }
            if (equipoAleatorio3 == "H4")
            {
                pictureBox3.Image = Resources.BanCoreaDelSur;
                txtPais3.Text = "Republica de Corea";
            }


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }
    }
}

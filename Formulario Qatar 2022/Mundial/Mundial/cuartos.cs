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
    public partial class cuartos : Form
    {
        semi ven_semi = new semi();
        public cuartos()
        {
            InitializeComponent();
        }
        int ganador1 = 1;
        int ganador2 = 2;
        int ganador3 = 3;
        int ganador4 = 4;
        int ganador5 = 5;
        int ganador6 = 6;
        int ganador7 = 7;
        int ganador8 = 8;
        int id_partido;
        private void cuartos_Load(object sender, EventArgs e)
        {
            LlenarGridCuartos();
        }
        private void LlenarGridCuartos()
        {


            DataTable datos = crudPartidos.posicionesCuartos();

            if (datos == null)
            {
                MessageBox.Show("No se logro generar la tabla de octavos");
            }
            else
            {
                dgvCuartos.DataSource = datos.DefaultView; //retorna a una lista el default es la vista por defecto de la base
            }

        }

        private void dgvCuartos_CellContentClick(object sender, DataGridViewCellEventArgs e)//borrar
        {}







        public void GanaOpierdePenales()
        {
            //EN EL PARTIDO 49
           
                if (id_partido == 58)
                {
                if (Convert.ToInt32(cantPenales1.Text) > Convert.ToInt32(cantPenales2.Text)) //SI GANA
                {
                    Partido partido = crudPartidos.DevuelveGanador(ganador1);
                    crudPartidos.InsertarSemi(partido);
                }
                else
                {
                    Partido partido = crudPartidos.DevuelveGanador(ganador3);
                    crudPartidos.InsertarSemi(partido);
                }

            }

            //EN EL 50
            if (id_partido == 59)
            {

                if (Convert.ToInt32(cantPenales1.Text) > Convert.ToInt32(cantPenales2.Text)) //SI GANA
                {
                    Partido partido = crudPartidos.DevuelveGanador(ganador5);
                    crudPartidos.InsertarSemi(partido);
                }
                else
                {
                    Partido partido = crudPartidos.DevuelveGanador(ganador7);
                    crudPartidos.InsertarSemi(partido);

                }

            }
            //ES EL 51
            if (id_partido == 60)
            {

                if (Convert.ToInt32(cantPenales1.Text) > Convert.ToInt32(cantPenales2.Text)) //SI GANA
                {
                    Partido partido = crudPartidos.DevuelveGanador(ganador6);
                    crudPartidos.InsertarSemi(partido);
                }
                else
                {
                    Partido partido = crudPartidos.DevuelveGanador(ganador8);
                    crudPartidos.InsertarSemi(partido);

                }

            }
           
        }

        public void GanaOpierde() //sin penales
            {
                //EN EL PARTIDO 49

                if (id_partido == 57)
                {
                    if (Convert.ToInt32(cantGoles1.Text) > Convert.ToInt32(cantGoles2.Text)) //SI GANA
                    {
                        Partido partido = crudPartidos.DevuelveGanador(ganador1);
                    crudPartidos.InsertarSemi(partido);
                    }
                    else
                    {
                        Partido partido = crudPartidos.DevuelveGanador(ganador3);
                    crudPartidos.InsertarSemi(partido);
                    }

                }

                //EN EL 50
                if (id_partido == 58)
                {

                    if (Convert.ToInt32(cantGoles1.Text) > Convert.ToInt32(cantGoles2.Text)) //SI GANA
                    {
                        Partido partido = crudPartidos.DevuelveGanador(ganador5);
                        crudPartidos.InsertarSemi(partido);
                    }
                    else
                    {
                        Partido partido = crudPartidos.DevuelveGanador(ganador7);
                        crudPartidos.InsertarSemi(partido);

                    }

                }
                //ES EL 51
                if (id_partido == 59)
                {

                    if (Convert.ToInt32(cantGoles1.Text) > Convert.ToInt32(cantGoles2.Text)) //SI GANA
                    {
                        Partido partido = crudPartidos.DevuelveGanador(ganador2);
                        crudPartidos.InsertarSemi(partido);


                    }
                    else
                    {
                        Partido partido = crudPartidos.DevuelveGanador(ganador4);
                        crudPartidos.InsertarSemi(partido);

                    }
                }
                
                //EN EL 52
                if (id_partido == 60)
                {

                    if (Convert.ToInt32(cantGoles1.Text) > Convert.ToInt32(cantGoles2.Text)) //SI GANA
                    {
                        Partido partido = crudPartidos.DevuelveGanador(ganador6);
                        crudPartidos.InsertarSemi(partido);
                    }
                    else
                    {
                        Partido partido = crudPartidos.DevuelveGanador(ganador8);
                       crudPartidos.InsertarSemi(partido);

                    }

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
                txtPenales1.Visible = true;
                txtPenales2.Visible = true;
            }
            else
            {
                GanaOpierde();

            }

        }

        private void btnCargarPenales_Click(object sender, EventArgs e)
        {
            btnCargarPenales.Visible = false;
            cantPenales1.Visible = false;
            cantPenales2.Visible = false;
            txtPenales1.Visible = false;
            txtPenales2.Visible = false;
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

            }
            else
            {
                MessageBox.Show("El partido no fue a Penales, utilice carga directa");
            }
        }

        private void ElegirPartido_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCargaPartido.Visible = true;
            btnSemifinal.Visible = true;

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;

            txtPais1.Visible = true;
            txtPais1.Enabled = false;

            txtPais2.Visible = true;
            txtPais2.Enabled = false;

            lbFecha.Visible = true;
            txtFecha.Visible = true;

            cantGoles1.Visible = true;
            cantGoles2.Visible = true;

            txtGoles1.Visible = true;
            txtGoles2.Visible = true;

            if (ElegirPartido.SelectedIndex == 0) // PARTIDO [57]
            {
                //MOSTRAR PAISES
                string equipoAleatorio = "";
                string equipoAleatorio2 = "";

                equipoAleatorio = crudPartidos.DevuelveIDGanador(ganador1); //GANADOR 1

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
                equipoAleatorio2 = crudPartidos.DevuelveIDGanador(ganador3); //GANADOR 3

                if (equipoAleatorio2 == "A1")
                {
                    pictureBox2.Image = Resources.BanQatar;
                    txtPais2.Text = "Qatar";
                }
                if (equipoAleatorio2 == "A2")
                {
                    pictureBox2.Image = Resources.BanEcuador;
                    txtPais2.Text = "Ecuador";
                }
                if (equipoAleatorio2 == "A3")
                {
                    pictureBox2.Image = Resources.BanSenegal;
                    txtPais2.Text = "Senegal";
                }
                if (equipoAleatorio2 == "A4")
                {
                    pictureBox2.Image = Resources.BanPaisesBajos;
                    txtPais2.Text = "Paises Bajos";
                }
                if (equipoAleatorio2 == "B1")
                {
                    pictureBox2.Image = Resources.BanInglaterra;
                    txtPais2.Text = "Inglaterra";
                }
                if (equipoAleatorio2 == "B2")
                {
                    pictureBox2.Image = Resources.BanIràn;
                    txtPais2.Text = "Iran";
                }
                if (equipoAleatorio2 == "B3")
                {
                    pictureBox2.Image = Resources.BanEEUU;
                    txtPais2.Text = "EE.UU";
                }
                if (equipoAleatorio2 == "B4")
                {
                    pictureBox2.Image = Resources.BanGales;
                    txtPais2.Text = "Gales";
                }
                if (equipoAleatorio2 == "C1")
                {
                    pictureBox2.Image = Resources.BanArgentina;
                    txtPais2.Text = "Argentina";
                }
                if (equipoAleatorio2 == "C2")
                {
                    pictureBox2.Image = Resources.BanArabiaSaudita;
                    txtPais2.Text = "Arabia Saudita";
                }
                if (equipoAleatorio2 == "C3")
                {
                    pictureBox2.Image = Resources.BanMex;
                    txtPais2.Text = "México";
                }
                if (equipoAleatorio2 == "C4")
                {
                    pictureBox2.Image = Resources.BanPolonia;
                    txtPais2.Text = "Polonia";
                }
                if (equipoAleatorio2 == "D1")
                {
                    pictureBox2.Image = Resources.BanFrancia;
                    txtPais2.Text = "Francia";
                }
                if (equipoAleatorio2 == "D2")
                {
                    pictureBox2.Image = Resources.BanAustralia;
                    txtPais2.Text = "Australia";
                }
                if (equipoAleatorio2 == "D3")
                {
                    pictureBox2.Image = Resources.BanDinamarca;
                    txtPais2.Text = "Dinamarca";
                }
                if (equipoAleatorio2 == "D4")
                {
                    pictureBox2.Image = Resources.BanTunez;
                    txtPais2.Text = "Túnez";
                }
                if (equipoAleatorio2 == "E1")
                {
                    pictureBox2.Image = Resources.BanEspaña;
                    txtPais2.Text = "España";
                }
                if (equipoAleatorio2 == "E2")
                {
                    pictureBox2.Image = Resources.BanCostaRica;
                    txtPais2.Text = "Costa Rica";
                }
                if (equipoAleatorio2 == "E3")
                {
                    pictureBox2.Image = Resources.BanAlemania;
                    txtPais2.Text = "Alemania";
                }
                if (equipoAleatorio2 == "E4")
                {
                    pictureBox2.Image = Resources.BanJapon;
                    txtPais2.Text = "Japón";
                }
                if (equipoAleatorio2 == "F1")
                {
                    pictureBox2.Image = Resources.BanBelgica;
                    txtPais2.Text = "Bélgica";
                }
                if (equipoAleatorio2 == "F2")
                {
                    pictureBox2.Image = Resources.BanCanada;
                    txtPais2.Text = "Canadá";
                }
                if (equipoAleatorio2 == "F3")
                {
                    pictureBox2.Image = Resources.BanMarruecos;
                    txtPais2.Text = "Marruecos";
                }
                if (equipoAleatorio2 == "F4")
                {
                    pictureBox2.Image = Resources.BanCroacia;
                    txtPais2.Text = "Croacia";
                }
                if (equipoAleatorio2 == "G1")
                {
                    pictureBox2.Image = Resources.BanBrasil;
                    txtPais2.Text = "Brasil";
                }
                if (equipoAleatorio2 == "G2")
                {
                    pictureBox2.Image = Resources.BanSerbia;
                    txtPais2.Text = "Serbia";
                }
                if (equipoAleatorio2 == "G3")
                {
                    pictureBox2.Image = Resources.BanSuiza;
                    txtPais2.Text = "Suiza";
                }
                if (equipoAleatorio2 == "G4")
                {
                    pictureBox2.Image = Resources.BanCamerun;
                    txtPais2.Text = "Camerún";
                }
                if (equipoAleatorio2 == "H1")
                {
                    pictureBox2.Image = Resources.BanPortugal;
                    txtPais2.Text = "Portugal";
                }
                if (equipoAleatorio2 == "H2")
                {
                    pictureBox2.Image = Resources.BanGhana;
                    txtPais2.Text = "Ghana";
                }
                if (equipoAleatorio2 == "H3")
                {
                    pictureBox2.Image = Resources.BanUruguay;
                    txtPais2.Text = "Uruguay";
                }
                if (equipoAleatorio2 == "H4")
                {
                    pictureBox2.Image = Resources.BanCoreaDelSur;
                    txtPais2.Text = "Republica de Corea";
                }

                txtFecha.Text = "09/12";
                id_partido = 57;
            }

            if (ElegirPartido.SelectedIndex == 1) // PARTIDO [58]
            {
                string equipoAleatorio = "";
                string equipoAleatorio2 = "";


                equipoAleatorio = crudPartidos.DevuelveIDGanador(ganador5); //GANADOR 1

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
                equipoAleatorio2 = crudPartidos.DevuelveIDGanador(ganador7); //GANADOR 3

                if (equipoAleatorio2 == "A1")
                {
                    pictureBox2.Image = Resources.BanQatar;
                    txtPais2.Text = "Qatar";
                }
                if (equipoAleatorio2 == "A2")
                {
                    pictureBox2.Image = Resources.BanEcuador;
                    txtPais2.Text = "Ecuador";
                }
                if (equipoAleatorio2 == "A3")
                {
                    pictureBox2.Image = Resources.BanSenegal;
                    txtPais2.Text = "Senegal";
                }
                if (equipoAleatorio2 == "A4")
                {
                    pictureBox2.Image = Resources.BanPaisesBajos;
                    txtPais2.Text = "Paises Bajos";
                }
                if (equipoAleatorio2 == "B1")
                {
                    pictureBox2.Image = Resources.BanInglaterra;
                    txtPais2.Text = "Inglaterra";
                }
                if (equipoAleatorio2 == "B2")
                {
                    pictureBox2.Image = Resources.BanIràn;
                    txtPais2.Text = "Iran";
                }
                if (equipoAleatorio2 == "B3")
                {
                    pictureBox2.Image = Resources.BanEEUU;
                    txtPais2.Text = "EE.UU";
                }
                if (equipoAleatorio2 == "B4")
                {
                    pictureBox2.Image = Resources.BanGales;
                    txtPais2.Text = "Gales";
                }
                if (equipoAleatorio2 == "C1")
                {
                    pictureBox2.Image = Resources.BanArgentina;
                    txtPais2.Text = "Argentina";
                }
                if (equipoAleatorio2 == "C2")
                {
                    pictureBox2.Image = Resources.BanArabiaSaudita;
                    txtPais2.Text = "Arabia Saudita";
                }
                if (equipoAleatorio2 == "C3")
                {
                    pictureBox2.Image = Resources.BanMex;
                    txtPais2.Text = "México";
                }
                if (equipoAleatorio2 == "C4")
                {
                    pictureBox2.Image = Resources.BanPolonia;
                    txtPais2.Text = "Polonia";
                }
                if (equipoAleatorio2 == "D1")
                {
                    pictureBox2.Image = Resources.BanFrancia;
                    txtPais2.Text = "Francia";
                }
                if (equipoAleatorio2 == "D2")
                {
                    pictureBox2.Image = Resources.BanAustralia;
                    txtPais2.Text = "Australia";
                }
                if (equipoAleatorio2 == "D3")
                {
                    pictureBox2.Image = Resources.BanDinamarca;
                    txtPais2.Text = "Dinamarca";
                }
                if (equipoAleatorio2 == "D4")
                {
                    pictureBox2.Image = Resources.BanTunez;
                    txtPais2.Text = "Túnez";
                }
                if (equipoAleatorio2 == "E1")
                {
                    pictureBox2.Image = Resources.BanEspaña;
                    txtPais2.Text = "España";
                }
                if (equipoAleatorio2 == "E2")
                {
                    pictureBox2.Image = Resources.BanCostaRica;
                    txtPais2.Text = "Costa Rica";
                }
                if (equipoAleatorio2 == "E3")
                {
                    pictureBox2.Image = Resources.BanAlemania;
                    txtPais2.Text = "Alemania";
                }
                if (equipoAleatorio2 == "E4")
                {
                    pictureBox2.Image = Resources.BanJapon;
                    txtPais2.Text = "Japón";
                }
                if (equipoAleatorio2 == "F1")
                {
                    pictureBox2.Image = Resources.BanBelgica;
                    txtPais2.Text = "Bélgica";
                }
                if (equipoAleatorio2 == "F2")
                {
                    pictureBox2.Image = Resources.BanCanada;
                    txtPais2.Text = "Canadá";
                }
                if (equipoAleatorio2 == "F3")
                {
                    pictureBox2.Image = Resources.BanMarruecos;
                    txtPais2.Text = "Marruecos";
                }
                if (equipoAleatorio2 == "F4")
                {
                    pictureBox2.Image = Resources.BanCroacia;
                    txtPais2.Text = "Croacia";
                }
                if (equipoAleatorio2 == "G1")
                {
                    pictureBox2.Image = Resources.BanBrasil;
                    txtPais2.Text = "Brasil";
                }
                if (equipoAleatorio2 == "G2")
                {
                    pictureBox2.Image = Resources.BanSerbia;
                    txtPais2.Text = "Serbia";
                }
                if (equipoAleatorio2 == "G3")
                {
                    pictureBox2.Image = Resources.BanSuiza;
                    txtPais2.Text = "Suiza";
                }
                if (equipoAleatorio2 == "G4")
                {
                    pictureBox2.Image = Resources.BanCamerun;
                    txtPais2.Text = "Camerún";
                }
                if (equipoAleatorio2 == "H1")
                {
                    pictureBox2.Image = Resources.BanPortugal;
                    txtPais2.Text = "Portugal";
                }
                if (equipoAleatorio2 == "H2")
                {
                    pictureBox2.Image = Resources.BanGhana;
                    txtPais2.Text = "Ghana";
                }
                if (equipoAleatorio2 == "H3")
                {
                    pictureBox2.Image = Resources.BanUruguay;
                    txtPais2.Text = "Uruguay";
                }
                if (equipoAleatorio2 == "H4")
                {
                    pictureBox2.Image = Resources.BanCoreaDelSur;
                    txtPais2.Text = "Republica de Corea";
                }

                txtFecha.Text = "09/12";
                id_partido = 57;
            }

            if (ElegirPartido.SelectedIndex == 2) // PARTIDO [59]
            {
                //MOSTRAR PAISES
                string equipoAleatorio = "";
                string equipoAleatorio2 = "";

                equipoAleatorio = crudPartidos.DevuelveIDGanador(ganador2); //GANADOR 1

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
                equipoAleatorio2 = crudPartidos.DevuelveIDGanador(ganador4); //GANADOR 3

                if (equipoAleatorio2 == "A1")
                {
                    pictureBox2.Image = Resources.BanQatar;
                    txtPais2.Text = "Qatar";
                }
                if (equipoAleatorio2 == "A2")
                {
                    pictureBox2.Image = Resources.BanEcuador;
                    txtPais2.Text = "Ecuador";
                }
                if (equipoAleatorio2 == "A3")
                {
                    pictureBox2.Image = Resources.BanSenegal;
                    txtPais2.Text = "Senegal";
                }
                if (equipoAleatorio2 == "A4")
                {
                    pictureBox2.Image = Resources.BanPaisesBajos;
                    txtPais2.Text = "Paises Bajos";
                }
                if (equipoAleatorio2 == "B1")
                {
                    pictureBox2.Image = Resources.BanInglaterra;
                    txtPais2.Text = "Inglaterra";
                }
                if (equipoAleatorio2 == "B2")
                {
                    pictureBox2.Image = Resources.BanIràn;
                    txtPais2.Text = "Iran";
                }
                if (equipoAleatorio2 == "B3")
                {
                    pictureBox2.Image = Resources.BanEEUU;
                    txtPais2.Text = "EE.UU";
                }
                if (equipoAleatorio2 == "B4")
                {
                    pictureBox2.Image = Resources.BanGales;
                    txtPais2.Text = "Gales";
                }
                if (equipoAleatorio2 == "C1")
                {
                    pictureBox2.Image = Resources.BanArgentina;
                    txtPais2.Text = "Argentina";
                }
                if (equipoAleatorio2 == "C2")
                {
                    pictureBox2.Image = Resources.BanArabiaSaudita;
                    txtPais2.Text = "Arabia Saudita";
                }
                if (equipoAleatorio2 == "C3")
                {
                    pictureBox2.Image = Resources.BanMex;
                    txtPais2.Text = "México";
                }
                if (equipoAleatorio2 == "C4")
                {
                    pictureBox2.Image = Resources.BanPolonia;
                    txtPais2.Text = "Polonia";
                }
                if (equipoAleatorio2 == "D1")
                {
                    pictureBox2.Image = Resources.BanFrancia;
                    txtPais2.Text = "Francia";
                }
                if (equipoAleatorio2 == "D2")
                {
                    pictureBox2.Image = Resources.BanAustralia;
                    txtPais2.Text = "Australia";
                }
                if (equipoAleatorio2 == "D3")
                {
                    pictureBox2.Image = Resources.BanDinamarca;
                    txtPais2.Text = "Dinamarca";
                }
                if (equipoAleatorio2 == "D4")
                {
                    pictureBox2.Image = Resources.BanTunez;
                    txtPais2.Text = "Túnez";
                }
                if (equipoAleatorio2 == "E1")
                {
                    pictureBox2.Image = Resources.BanEspaña;
                    txtPais2.Text = "España";
                }
                if (equipoAleatorio2 == "E2")
                {
                    pictureBox2.Image = Resources.BanCostaRica;
                    txtPais2.Text = "Costa Rica";
                }
                if (equipoAleatorio2 == "E3")
                {
                    pictureBox2.Image = Resources.BanAlemania;
                    txtPais2.Text = "Alemania";
                }
                if (equipoAleatorio2 == "E4")
                {
                    pictureBox2.Image = Resources.BanJapon;
                    txtPais2.Text = "Japón";
                }
                if (equipoAleatorio2 == "F1")
                {
                    pictureBox2.Image = Resources.BanBelgica;
                    txtPais2.Text = "Bélgica";
                }
                if (equipoAleatorio2 == "F2")
                {
                    pictureBox2.Image = Resources.BanCanada;
                    txtPais2.Text = "Canadá";
                }
                if (equipoAleatorio2 == "F3")
                {
                    pictureBox2.Image = Resources.BanMarruecos;
                    txtPais2.Text = "Marruecos";
                }
                if (equipoAleatorio2 == "F4")
                {
                    pictureBox2.Image = Resources.BanCroacia;
                    txtPais2.Text = "Croacia";
                }
                if (equipoAleatorio2 == "G1")
                {
                    pictureBox2.Image = Resources.BanBrasil;
                    txtPais2.Text = "Brasil";
                }
                if (equipoAleatorio2 == "G2")
                {
                    pictureBox2.Image = Resources.BanSerbia;
                    txtPais2.Text = "Serbia";
                }
                if (equipoAleatorio2 == "G3")
                {
                    pictureBox2.Image = Resources.BanSuiza;
                    txtPais2.Text = "Suiza";
                }
                if (equipoAleatorio2 == "G4")
                {
                    pictureBox2.Image = Resources.BanCamerun;
                    txtPais2.Text = "Camerún";
                }
                if (equipoAleatorio2 == "H1")
                {
                    pictureBox2.Image = Resources.BanPortugal;
                    txtPais2.Text = "Portugal";
                }
                if (equipoAleatorio2 == "H2")
                {
                    pictureBox2.Image = Resources.BanGhana;
                    txtPais2.Text = "Ghana";
                }
                if (equipoAleatorio2 == "H3")
                {
                    pictureBox2.Image = Resources.BanUruguay;
                    txtPais2.Text = "Uruguay";
                }
                if (equipoAleatorio2 == "H4")
                {
                    pictureBox2.Image = Resources.BanCoreaDelSur;
                    txtPais2.Text = "Republica de Corea";
                }

                txtFecha.Text = "10/12";
                id_partido = 59;
            }

            if (ElegirPartido.SelectedIndex == 3) // PARTIDO [57]
            {
                //MOSTRAR PAISES
                string equipoAleatorio = "";
                string equipoAleatorio2 = "";

                equipoAleatorio = crudPartidos.DevuelveIDGanador(ganador6); //GANADOR 1

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
                equipoAleatorio2 = crudPartidos.DevuelveIDGanador(ganador8); //GANADOR 3

                if (equipoAleatorio2 == "A1")
                {
                    pictureBox2.Image = Resources.BanQatar;
                    txtPais2.Text = "Qatar";
                }
                if (equipoAleatorio2 == "A2")
                {
                    pictureBox2.Image = Resources.BanEcuador;
                    txtPais2.Text = "Ecuador";
                }
                if (equipoAleatorio2 == "A3")
                {
                    pictureBox2.Image = Resources.BanSenegal;
                    txtPais2.Text = "Senegal";
                }
                if (equipoAleatorio2 == "A4")
                {
                    pictureBox2.Image = Resources.BanPaisesBajos;
                    txtPais2.Text = "Paises Bajos";
                }
                if (equipoAleatorio2 == "B1")
                {
                    pictureBox2.Image = Resources.BanInglaterra;
                    txtPais2.Text = "Inglaterra";
                }
                if (equipoAleatorio2 == "B2")
                {
                    pictureBox2.Image = Resources.BanIràn;
                    txtPais2.Text = "Iran";
                }
                if (equipoAleatorio2 == "B3")
                {
                    pictureBox2.Image = Resources.BanEEUU;
                    txtPais2.Text = "EE.UU";
                }
                if (equipoAleatorio2 == "B4")
                {
                    pictureBox2.Image = Resources.BanGales;
                    txtPais2.Text = "Gales";
                }
                if (equipoAleatorio2 == "C1")
                {
                    pictureBox2.Image = Resources.BanArgentina;
                    txtPais2.Text = "Argentina";
                }
                if (equipoAleatorio2 == "C2")
                {
                    pictureBox2.Image = Resources.BanArabiaSaudita;
                    txtPais2.Text = "Arabia Saudita";
                }
                if (equipoAleatorio2 == "C3")
                {
                    pictureBox2.Image = Resources.BanMex;
                    txtPais2.Text = "México";
                }
                if (equipoAleatorio2 == "C4")
                {
                    pictureBox2.Image = Resources.BanPolonia;
                    txtPais2.Text = "Polonia";
                }
                if (equipoAleatorio2 == "D1")
                {
                    pictureBox2.Image = Resources.BanFrancia;
                    txtPais2.Text = "Francia";
                }
                if (equipoAleatorio2 == "D2")
                {
                    pictureBox2.Image = Resources.BanAustralia;
                    txtPais2.Text = "Australia";
                }
                if (equipoAleatorio2 == "D3")
                {
                    pictureBox2.Image = Resources.BanDinamarca;
                    txtPais2.Text = "Dinamarca";
                }
                if (equipoAleatorio2 == "D4")
                {
                    pictureBox2.Image = Resources.BanTunez;
                    txtPais2.Text = "Túnez";
                }
                if (equipoAleatorio2 == "E1")
                {
                    pictureBox2.Image = Resources.BanEspaña;
                    txtPais2.Text = "España";
                }
                if (equipoAleatorio2 == "E2")
                {
                    pictureBox2.Image = Resources.BanCostaRica;
                    txtPais2.Text = "Costa Rica";
                }
                if (equipoAleatorio2 == "E3")
                {
                    pictureBox2.Image = Resources.BanAlemania;
                    txtPais2.Text = "Alemania";
                }
                if (equipoAleatorio2 == "E4")
                {
                    pictureBox2.Image = Resources.BanJapon;
                    txtPais2.Text = "Japón";
                }
                if (equipoAleatorio2 == "F1")
                {
                    pictureBox2.Image = Resources.BanBelgica;
                    txtPais2.Text = "Bélgica";
                }
                if (equipoAleatorio2 == "F2")
                {
                    pictureBox2.Image = Resources.BanCanada;
                    txtPais2.Text = "Canadá";
                }
                if (equipoAleatorio2 == "F3")
                {
                    pictureBox2.Image = Resources.BanMarruecos;
                    txtPais2.Text = "Marruecos";
                }
                if (equipoAleatorio2 == "F4")
                {
                    pictureBox2.Image = Resources.BanCroacia;
                    txtPais2.Text = "Croacia";
                }
                if (equipoAleatorio2 == "G1")
                {
                    pictureBox2.Image = Resources.BanBrasil;
                    txtPais2.Text = "Brasil";
                }
                if (equipoAleatorio2 == "G2")
                {
                    pictureBox2.Image = Resources.BanSerbia;
                    txtPais2.Text = "Serbia";
                }
                if (equipoAleatorio2 == "G3")
                {
                    pictureBox2.Image = Resources.BanSuiza;
                    txtPais2.Text = "Suiza";
                }
                if (equipoAleatorio2 == "G4")
                {
                    pictureBox2.Image = Resources.BanCamerun;
                    txtPais2.Text = "Camerún";
                }
                if (equipoAleatorio2 == "H1")
                {
                    pictureBox2.Image = Resources.BanPortugal;
                    txtPais2.Text = "Portugal";
                }
                if (equipoAleatorio2 == "H2")
                {
                    pictureBox2.Image = Resources.BanGhana;
                    txtPais2.Text = "Ghana";
                }
                if (equipoAleatorio2 == "H3")
                {
                    pictureBox2.Image = Resources.BanUruguay;
                    txtPais2.Text = "Uruguay";
                }
                if (equipoAleatorio2 == "H4")
                {
                    pictureBox2.Image = Resources.BanCoreaDelSur;
                    txtPais2.Text = "Republica de Corea";
                }

                txtFecha.Text = "10/12";
                id_partido = 60;
            }

        }

        private void btnSemifinal_Click(object sender, EventArgs e)
        {
            ven_semi.ShowDialog();
        }
    }
}


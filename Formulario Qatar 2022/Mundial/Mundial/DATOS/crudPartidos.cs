using Mundial.PARTIDOS;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

namespace Mundial.DATOS
{
    internal class crudPartidos
    {
        //...................CRUD EQUIPOS FASE DE GRUPOS.....................//

        public static bool actualizar(Partido p) //ACTUALIZA EQUIPOS
        {

            try
            {

                conexion_Class con = new conexion_Class();
                string sql = "update equipos set cant_partidos = " + p.Cant_partidos + ", T_amarilla = " + p.T_amarilla1 + ", T_rojas = " + p.T_rojas1 + ", partidos_ganados = " + p.Partidos_ganados + ", partidos_perdidos = " + p.Partidos_perdidos + ", partidos_empatados = " + p.Partidos_empatados + "," +
                "puntos = " + p.Puntos + ", dif_goles = " + p.Dif_goles + ", cant_goles_a_favor = " + p.Cant_goles_a_favor + ", cant_goles_en_contra = " + p.Cant_goles_en_contra + "   where id_equipos = '" + p.Id_equipos + "'";

                SqlCommand comando = new SqlCommand(sql, con.Conectar());

                int cantidad = comando.ExecuteNonQuery();



                if (cantidad == 1)
                {
                    con.desconectar();
                    return true;

                }
                else
                {
                    con.desconectar();
                    return false;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
                return false;
            }


        }
        public static Partido consultar_equipo(string id_equipos) //CONSULTA POR PAIS
        {
            try
            {

                conexion_Class con = new conexion_Class();

                string sql = "select * from equipos where id_equipos = '" + id_equipos + "'";

                SqlCommand comando = new SqlCommand(sql, con.Conectar());

                SqlDataReader leer = comando.ExecuteReader();

                Partido partido = new Partido();




                if (leer.Read())
                {
                    partido.Id_equipos = leer["id_equipos"].ToString();
                    partido.Cant_partidos = Convert.ToInt32(leer["cant_partidos"].ToString());
                    partido.T_amarilla1 = Convert.ToInt32(leer["T_amarilla"].ToString());
                    partido.T_rojas1 = Convert.ToInt32(leer["T_rojas"].ToString());
                    partido.Partidos_ganados = Convert.ToInt32(leer["partidos_ganados"].ToString());
                    partido.Partidos_perdidos = Convert.ToInt32(leer["partidos_perdidos"].ToString());
                    partido.Partidos_empatados = Convert.ToInt32(leer["partidos_empatados"].ToString());
                    partido.Puntos = Convert.ToInt32(leer["puntos"].ToString());
                    partido.Dif_goles = Convert.ToInt32(leer["dif_goles"].ToString());
                    partido.Cant_goles_a_favor = Convert.ToInt32(leer["cant_goles_a_favor"].ToString());
                    partido.Cant_goles_en_contra = Convert.ToInt32(leer["cant_goles_en_contra"].ToString());
                    con.desconectar();
                    return partido;


                }
                else
                {
                    con.desconectar();
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
                return null;
            }




        }
        public static DataTable posiciones()
        {

            try
            {
                Partido p = new Partido();
                conexion_Class con = new conexion_Class();
                string sql = "SELECT * FROM equipos order BY puntos DESC, dif_goles DESC";

                SqlCommand comando = new SqlCommand(sql, con.Conectar());

                SqlDataReader leer = comando.ExecuteReader(CommandBehavior.CloseConnection);//se cierre la connecion luego de la lectura

                DataTable dt = new DataTable();

                dt.Load(leer);
                con.desconectar();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
                return null;
            }
        }

        //........................CRUD PASA A OCTAVOS.......................//

        public static bool InsertarOctavos(Partido p) //INSERTA EN LA NUEVA TABLA DE OCTAVOS
        {
            try
            {

                conexion_Class con = new conexion_Class();

                string sql = "insert into equipos_octavos(id_equipos, nombre_de_grupo, pais, cant_partidos, T_amarilla, T_rojas, partidos_ganados, partidos_perdidos, partidos_empatados, puntos, dif_goles, cant_goles_a_favor, cant_goles_en_contra) values ('" + p.Id_equipos + "','" + p.Nombre_de_grupo + "','" + p.Pais + "'," + p.Cant_partidos + "," + p.T_amarilla1 + "," + p.T_rojas1 + "," + p.Partidos_ganados + "," + p.Partidos_perdidos + ", " + p.Partidos_empatados + "," + p.Puntos + "," + p.Dif_goles + "," + p.Cant_goles_a_favor + "," + p.Cant_goles_en_contra + ")";

                SqlCommand comando = new SqlCommand(sql, con.Conectar());

                int cantidad = comando.ExecuteNonQuery();

                if (cantidad == 1)
                {
                    con.desconectar();
                    return true;

                }
                else
                {
                    con.desconectar();
                    return false;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
                return false;
            }


        }
        public static void PasaOctavos()
        {
            try
            {

                conexion_Class con = new conexion_Class();

                string sql = "SELECT * FROM equipos ORDER BY puntos DESC,T_amarilla ASC, T_rojas ASC";

                SqlCommand comando = new SqlCommand(sql, con.Conectar());

                SqlDataReader leer = comando.ExecuteReader();

                Partido partido = new Partido();

                for (int i = 0; i < 16; i++)
                {
                    leer.Read();
                    partido.Id_equipos = leer["id_equipos"].ToString();
                    partido.Nombre_de_grupo = leer["nombre_de_grupo"].ToString();
                    partido.Pais = leer["pais"].ToString();
                    partido.Cant_partidos = Convert.ToInt32(leer["cant_partidos"].ToString());
                    partido.T_amarilla1 = Convert.ToInt32(leer["T_amarilla"].ToString());
                    partido.T_rojas1 = Convert.ToInt32(leer["T_rojas"].ToString());
                    partido.Partidos_ganados = Convert.ToInt32(leer["partidos_ganados"].ToString());
                    partido.Partidos_perdidos = Convert.ToInt32(leer["partidos_perdidos"].ToString());
                    partido.Partidos_empatados = Convert.ToInt32(leer["partidos_empatados"].ToString());
                    partido.Puntos = Convert.ToInt32(leer["puntos"].ToString());
                    partido.Dif_goles = Convert.ToInt32(leer["dif_goles"].ToString());
                    partido.Cant_goles_a_favor = Convert.ToInt32(leer["cant_goles_a_favor"].ToString());
                    partido.Cant_goles_en_contra = Convert.ToInt32(leer["cant_goles_en_contra"].ToString());
                    InsertarOctavos(partido);
                }

                con.desconectar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);

            }
        }
        public static DataTable posicionesOctavo() //probar aca DEVOLVERIA LA TABLA ORDENADA POR PUNTAJE
        {
            try
            {
                Partido p = new Partido();
                conexion_Class con = new conexion_Class();
                string sql = "SELECT * FROM equipos_octavos order BY puntos DESC, dif_goles DESC,T_amarilla ASC, T_rojas ASC";

                SqlCommand comando = new SqlCommand(sql, con.Conectar());

                SqlDataReader leer = comando.ExecuteReader(CommandBehavior.CloseConnection);//se cierre la connecion luego de la lectura

                DataTable dt = new DataTable();

                dt.Load(leer);
                con.desconectar();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
                return null;
            }
        }

        //...................CRUD PARTIDOS....................//
        public static bool InsertarPartidos(Partido p) //tabla de partidos modificar
        {

            try
            {

                conexion_Class con = new conexion_Class();
                string sql = "update partidos set res_eq_uno= " + p.Res_eq_uno + ", res_eq_dos  = " + p.Res_eq_dos + ", tar_amarilla_eq_uno = " + p.Tar_amarilla_eq_uno + ", tar_amarilla_eq_dos = " + p.Tar_amarilla_eq_dos + ", tar_roja_eq_uno = " + p.Tar_roja_eq_uno + ", tar_roja_eq_dos = " + p.Tar_roja_eq_dos + " WHERE id_partido = " + p.Id_partido;

                SqlCommand comando = new SqlCommand(sql, con.Conectar());

                int cantidad = comando.ExecuteNonQuery();

                if (cantidad == 1)
                {
                    MessageBox.Show("Guardado");
                    con.desconectar();
                    return true;

                }
                else
                {
                    MessageBox.Show("No Guardado");
                    con.desconectar();
                    return false;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
                return false;
            }


        }
        public static Partido consultar_partido(int id_partido)
        {
            MessageBox.Show("" + id_partido);
            try
            {

                conexion_Class con = new conexion_Class();

                string sql = "select * from partidos where id_partido = " + id_partido + "";

                SqlCommand comando = new SqlCommand(sql, con.Conectar());

                SqlDataReader leer = comando.ExecuteReader();

                Partido partido = new Partido();




                if (leer.Read())
                {
                    partido.Id_partido = Convert.ToInt32(leer["id_partido"].ToString());
                    con.desconectar();
                    return partido;
                }
                else
                {
                    con.desconectar();
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
                return null;
            }




        }
   

        //...............................CRUD PASA  A CUARTOS.....................................//
        public static string DevuelveIDGrupoMAYOR(string nombreGrupo) //PEDIR EL NOMBRE DEL GRUPO
        {
            try
            {

                conexion_Class con = new conexion_Class();

                string sql = "SELECT * FROM equipos_octavos WHERE nombre_de_grupo = '" + nombreGrupo + "'ORDER BY puntos DESC";

                SqlCommand comando = new SqlCommand(sql, con.Conectar());

                SqlDataReader leer = comando.ExecuteReader();

                Partido partido = new Partido();
                if (leer.Read())
                {
                    string id_equipoMAYOR = "";
                    id_equipoMAYOR = leer["id_equipos"].ToString();
                    con.desconectar();
                    return id_equipoMAYOR;


                }
                else
                {
                    con.desconectar();
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
                return null;
            }


        }
        public static string DevuelveIDGrupoMENOR(string nombreGrupo) //PEDIR EL NOMBRE DEL GRUPO
        {

            try
            {
                string id_equipoMENOR = "";
                conexion_Class con = new conexion_Class();

                string sql = "SELECT * FROM equipos_octavos WHERE nombre_de_grupo = '" + nombreGrupo + "'ORDER BY puntos ASC";

                SqlCommand comando = new SqlCommand(sql, con.Conectar());

                SqlDataReader leer = comando.ExecuteReader();

                Partido partido = new Partido();
                if (leer.Read())
                {
                    id_equipoMENOR = leer["id_equipos"].ToString();
                    con.desconectar();
                    return id_equipoMENOR;
                }
                else
                {
                    con.desconectar();
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
                return null;
            }


        }
        public static Partido DevuelveGrupoMAYOR(string nombreGrupo) //PEDIR EL NOMBRE DEL GRUPO
        {

            try
            {
                conexion_Class con = new conexion_Class();

                string sql = "SELECT * FROM equipos_octavos WHERE nombre_de_grupo = '" + nombreGrupo + "'ORDER BY puntos DESC";

                SqlCommand comando = new SqlCommand(sql, con.Conectar());

                SqlDataReader leer = comando.ExecuteReader();

                Partido partido = new Partido();
                if (leer.Read())
                {
                    partido.Id_equipos = leer["id_equipos"].ToString();
                    partido.Nombre_de_grupo = leer["nombre_de_grupo"].ToString();
                    partido.Pais = leer["pais"].ToString();
                    con.desconectar();
                    return partido;


                }
                else
                {
                    con.desconectar();
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
                return null;
            }


        }

        public static Partido DevuelveGrupoMENOR(string nombreGrupo) //PEDIR EL NOMBRE DEL GRUPO
        {

            try
            {
                conexion_Class con = new conexion_Class();

                string sql = "SELECT * FROM equipos_octavos WHERE nombre_de_grupo = '" + nombreGrupo + "'ORDER BY puntos ASC";

                SqlCommand comando = new SqlCommand(sql, con.Conectar());

                SqlDataReader leer = comando.ExecuteReader();

                Partido partido = new Partido();
                if (leer.Read())
                {
                    partido.Id_equipos = leer["id_equipos"].ToString();
                    partido.Id_equipos = leer["id_equipos"].ToString();
                    partido.Nombre_de_grupo = leer["nombre_de_grupo"].ToString();
                    partido.Pais = leer["pais"].ToString();

                    con.desconectar();
                    return partido;


                }
                else
                {
                    con.desconectar();
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
                return null;
            }


        }


        public static DataTable posicionesCuartos() //probar aca DEVOLVERIA LA TABLA ORDENADA POR PUNTAJE
        {
            try
            {
                Partido p = new Partido();
                conexion_Class con = new conexion_Class();
                string sql = "SELECT * FROM equipos_cuartos order BY ganador";

                SqlCommand comando = new SqlCommand(sql, con.Conectar());

                SqlDataReader leer = comando.ExecuteReader(CommandBehavior.CloseConnection);//se cierre la connecion luego de la lectura

                DataTable dt = new DataTable();

                dt.Load(leer);
                con.desconectar();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
                return null;
            }
        }

        public static bool InsertarCuartos(Partido p) //INSERTA EN LA NUEVA TABLA DE CUARTOS
        {
            try
            {

                conexion_Class con = new conexion_Class();

                string sql = "insert into equipos_cuartos(id_equipos, nombre_de_grupo, pais) values ('" + p.Id_equipos + "','" + p.Nombre_de_grupo + "','" + p.Pais + "')";

                SqlCommand comando = new SqlCommand(sql, con.Conectar());

                int cantidad = comando.ExecuteNonQuery();

                if (cantidad == 1)
                {
                    con.desconectar();
                    return true;

                }
                else
                {
                    con.desconectar();
                    return false;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
                return false;
            }


        }

        //.............................CRUD PASA A SEMI.........................................//
        public static Partido DevuelveGanador(int ganador) //PEDIR EL NOMBRE DEL GRUPO
        {
            try
            {

                conexion_Class con = new conexion_Class();

                string sql = "SELECT * FROM equipos_cuartos WHERE ganador = " + ganador; 

                SqlCommand comando = new SqlCommand(sql, con.Conectar());

                SqlDataReader leer = comando.ExecuteReader();

                Partido partido = new Partido();
                if (leer.Read())
                {
                    partido.Id_equipos = leer["id_equipos"].ToString();
                    partido.Nombre_de_grupo = leer["nombre_de_grupo"].ToString();
                    partido.Pais = leer["pais"].ToString();

                    con.desconectar();
                    return partido;


                }
                else
                {
                    con.desconectar();
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
                return null;
            }


        }

        public static bool InsertarSemi(Partido p) //INSERTA EN LA NUEVA TABLA DE CUARTOS
        {
            try
            {

                conexion_Class con = new conexion_Class();

                string sql = "insert into equipos_semiFinal(id_equipos, nombre_de_grupo, pais) values ('" + p.Id_equipos + "','" + p.Nombre_de_grupo + "','" + p.Pais + "')";

                SqlCommand comando = new SqlCommand(sql, con.Conectar());

                int cantidad = comando.ExecuteNonQuery();

                if (cantidad == 1)
                {
                    con.desconectar();
                    return true;

                }
                else
                {
                    con.desconectar();
                    return false;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
                return false;
            }


        }

        public static string DevuelveIDGanador(int ganador) //PEDIR EL NOMBRE DEL GRUPO
        {

            try
            {
                string id_equipoGanador = "";
                conexion_Class con = new conexion_Class();

                string sql = "SELECT * FROM equipos_cuartos WHERE ganador = " +ganador;

                SqlCommand comando = new SqlCommand(sql, con.Conectar());

                SqlDataReader leer = comando.ExecuteReader();

                Partido partido = new Partido();
                if (leer.Read())
                {
                    id_equipoGanador = leer["id_equipos"].ToString();
                    con.desconectar();
                    return id_equipoGanador;
                }
                else
                {
                    con.desconectar();
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
                return null;
            }


        }

        public static DataTable posicionesSemi() //probar aca DEVOLVERIA LA TABLA ORDENADA POR PUNTAJE
        {
            try
            {
                Partido p = new Partido();
                conexion_Class con = new conexion_Class();
                string sql = "SELECT * FROM equipos_semiFinal order BY ganador";

                SqlCommand comando = new SqlCommand(sql, con.Conectar());

                SqlDataReader leer = comando.ExecuteReader(CommandBehavior.CloseConnection);//se cierre la connecion luego de la lectura

                DataTable dt = new DataTable();

                dt.Load(leer);
                con.desconectar();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
                return null;
            }
        }
        //............................CRUD PASA A FINAL..................................//

        public static string DevuelveIDGanadorF(int ganador) //PEDIR EL NOMBRE DEL GRUPO
        {

            try
            {
                string id_equipoGanador = "";
                conexion_Class con = new conexion_Class();

                string sql = "SELECT * FROM equipos_semiFinal WHERE ganador = " + ganador;

                SqlCommand comando = new SqlCommand(sql, con.Conectar());

                SqlDataReader leer = comando.ExecuteReader();

                Partido partido = new Partido();
                if (leer.Read())
                {
                    id_equipoGanador = leer["id_equipos"].ToString();
                    con.desconectar();
                    return id_equipoGanador;
                }
                else
                {
                    con.desconectar();
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
                return null;
            }


        }

        public static Partido DevuelveGanadorF(int ganador) //PEDIR EL NOMBRE DEL GRUPO
        {
            try
            {
              
                conexion_Class con = new conexion_Class();

                string sql = "SELECT * FROM equipos_semiFinal WHERE ganador = " + ganador;

                SqlCommand comando = new SqlCommand(sql, con.Conectar());

                SqlDataReader leer = comando.ExecuteReader();

                Partido partido = new Partido();
                if (leer.Read())
                {
                    partido.Id_equipos = leer["id_equipos"].ToString();
                    partido.Nombre_de_grupo = leer["nombre_de_grupo"].ToString();
                    partido.Pais = leer["pais"].ToString();

                    con.desconectar();
                    return partido;


                }
                else
                {
                    con.desconectar();
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
                return null;
            }


        }


        public static bool InsertarFinal(Partido p) //INSERTA EN LA NUEVA TABLA DE CUARTOS
        {
            try
            {

                conexion_Class con = new conexion_Class();

                string sql = "insert into equipos_Final(id_equipos, nombre_de_grupo, pais) values ('" + p.Id_equipos + "','" + p.Nombre_de_grupo + "','" + p.Pais + "')";

                SqlCommand comando = new SqlCommand(sql, con.Conectar());

                int cantidad = comando.ExecuteNonQuery();

                if (cantidad == 1)
                {
                    
                    con.desconectar();
                    return true;

                }
                else
                {
                    
                    con.desconectar();
                    return false;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
                return false;
            }


        }

        //.............................CRUD DE LA FINAL...................................//
       
        public static string DevuelveIDGanadorFinal(int ganador) //para el ganador
        {

            try
            {
                string id_equipoGanador = "";
                conexion_Class con = new conexion_Class();

                string sql = "SELECT * FROM equipos_Final WHERE ganador = " + ganador;

                SqlCommand comando = new SqlCommand(sql, con.Conectar());

                SqlDataReader leer = comando.ExecuteReader();

                Partido partido = new Partido();
                if (leer.Read())
                {
                    id_equipoGanador = leer["id_equipos"].ToString();
                    con.desconectar();
                    return id_equipoGanador;
                }
                else
                {
                    con.desconectar();
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
                return null;
            }


        }
        public static DataTable posicionesFinal() //probar aca DEVOLVERIA LA TABLA ORDENADA POR PUNTAJE
        {
            try
            {
                Partido p = new Partido();
                conexion_Class con = new conexion_Class();
                string sql = "SELECT * FROM equipos_Final order BY ganador";

                SqlCommand comando = new SqlCommand(sql, con.Conectar());

                SqlDataReader leer = comando.ExecuteReader(CommandBehavior.CloseConnection);//se cierre la connecion luego de la lectura

                DataTable dt = new DataTable();

                dt.Load(leer);
                con.desconectar();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
                return null;
            }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mundial.PARTIDOS
{
    internal class Partido
    {   //tabla equipos
        private string id_equipos;
        private string nombre_de_grupo;
        private string pais;
        private int cant_partidos;
        private int T_amarilla;
        private int T_rojas;
        private int partidos_ganados;
        private int partidos_perdidos;
        private int partidos_empatados;
        private int puntos;
        private int dif_goles;
        private int cant_goles_a_favor;
        private int cant_goles_en_contra;
        //tabla partidos
        private int id_partido;
        private int res_eq_dos;
        private int res_eq_uno;
        private string id_equipos1;
        private string id_equipos2;
        private int tar_amarilla_eq_uno;
        private int tar_amarilla_eq_dos;
        private int tar_roja_eq_uno;
        private int tar_roja_eq_dos;
        private int penales1;
        private int penales2;

        public Partido()
        {   
            //tabla equipos
            Id_equipos = "";
            Nombre_de_grupo = "";
            Pais = "";
            Cant_partidos = 0;
            T_amarilla1 = 0;
            T_rojas1 = 0;
            Partidos_ganados = 0;
            Partidos_perdidos = 0;
            Partidos_empatados = 0;
            Puntos = 0;
            Dif_goles = 0;
            Cant_goles_a_favor = 0;
            Cant_goles_en_contra = 0;
            //tabla partidos
            Id_partido = 0;
            res_eq_uno= 0;
            Res_eq_dos =0;
            Id_equipos1 = "";
            Id_equipos2 = "";
            Tar_amarilla_eq_uno = 0;
            Tar_roja_eq_uno = 0;
            Tar_roja_eq_dos = 0;

    }
        //tabla equipos
        public string Id_equipos { get => id_equipos; set => id_equipos = value; }
        public string Nombre_de_grupo { get => nombre_de_grupo; set => nombre_de_grupo = value; }
        public string Pais { get => pais; set => pais = value; }
        public int Cant_partidos { get => cant_partidos; set => cant_partidos = value; }
        public int T_amarilla1 { get => T_amarilla; set => T_amarilla = value; }
        public int T_rojas1 { get => T_rojas; set => T_rojas = value; }
        public int Partidos_ganados { get => partidos_ganados; set => partidos_ganados = value; }
        public int Partidos_perdidos { get => partidos_perdidos; set => partidos_perdidos = value; }
        public int Partidos_empatados { get => partidos_empatados; set => partidos_empatados = value; }
        public int Puntos { get => puntos; set => puntos = value; }
        public int Dif_goles { get => dif_goles; set => dif_goles = value; }
        public int Cant_goles_a_favor { get => cant_goles_a_favor; set => cant_goles_a_favor = value; }
        public int Cant_goles_en_contra { get => cant_goles_en_contra; set => cant_goles_en_contra = value; }
        //tabla partidos
        public int Id_partido { get => id_partido; set => id_partido = value; }
        public int Res_eq_dos { get => res_eq_dos; set => res_eq_dos = value; }
        public string Id_equipos1 { get => id_equipos1; set => id_equipos1 = value; }
        public string Id_equipos2 { get => id_equipos2; set => id_equipos2 = value; }
        public int Tar_amarilla_eq_uno { get => tar_amarilla_eq_uno; set => tar_amarilla_eq_uno = value; }
        public int Tar_roja_eq_uno { get => tar_roja_eq_uno; set => tar_roja_eq_uno = value; }
        public int Tar_amarilla_eq_dos { get => tar_amarilla_eq_dos; set => tar_amarilla_eq_dos = value; }
        public int Tar_roja_eq_dos { get => tar_roja_eq_dos; set => tar_roja_eq_dos = value; }
        public int Res_eq_uno { get => res_eq_uno; set => res_eq_uno = value; }
        public int Penales1 { get => penales1; set => penales1 = value; }
        public int Penales2 { get => penales2; set => penales2 = value; }
    }
}

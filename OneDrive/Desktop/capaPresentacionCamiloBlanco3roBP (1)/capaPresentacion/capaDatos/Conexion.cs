﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    class Conexion
    {
        private static MySqlConnection conn = new MySqlConnection("server=192.168.2.53;database=cblanco;user=cblanco;password=56384284;");

        public static MySqlConnection Conectarse()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                return conn;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar a la base de datos: " + ex.Message);
            }
        }

        public static void Desconectarse()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
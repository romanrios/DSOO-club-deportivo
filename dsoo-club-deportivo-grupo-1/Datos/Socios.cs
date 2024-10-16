﻿using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClubDeportivo.Datos
{
    internal class Socios
    {
        public string Nuevo_Socio(E_Socio socio)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevoSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = socio.Nombre;
                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = socio.Apellido;
                comando.Parameters.Add("Tip", MySqlDbType.VarChar).Value = socio.Estado;
                comando.Parameters.Add("Doc", MySqlDbType.Int32).Value = socio.DNI;
                comando.Parameters.Add("Fec", MySqlDbType.DateTime).Value = socio.FechaNac;
                comando.Parameters.Add("FecI", MySqlDbType.DateTime).Value = socio.FechaInsc;
                comando.Parameters.Add("EAF", MySqlDbType.Bit).Value = socio.EntregoAptoFisico;

                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            // como proceso final
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
            return salida;
        }
    }
}


﻿using System;
using System.Data;
using MySql.Data;
using Gtk;
using System.Text;
using System.Collections.Generic;
using ScapProject0.Entidades;

namespace ScapProject0.Datos
{
    public class Dt_tbl_registroES
    {
        Conexion con = new Conexion();
        MessageDialog ms = null;
        StringBuilder sb = new StringBuilder();

        public ListStore ListarRegistros(int idEmpleado)
        {
            ListStore datos = new ListStore(
            typeof(string), typeof(string), typeof(string), typeof(string), typeof(string)
            );
            IDataReader idr = null;
            sb.Clear();
            sb.Append("SELECT * From LMBA.VwRegistro ");
            sb.Append("WHERE idEmpleado = " + idEmpleado + ";");

            try
            {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    var fecha = idr["fecha"].ToString().Split(' ')[0];
                    TimeSpan horaEntrada = TimeSpan.Parse(idr["horaEntrada"].ToString());
                    TimeSpan horaSalida = TimeSpan.Parse(idr["horaSalida"].ToString());
                    TimeSpan entradaH = TimeSpan.Parse(idr["entradaH"].ToString());
                    TimeSpan salidaH = TimeSpan.Parse(idr["salidaH"].ToString());
                    TimeSpan almuerzo = TimeSpan.Parse(idr["almuerzo"].ToString());
                    TimeSpan horasNecesitadas = salidaH.Subtract(entradaH).Subtract(almuerzo);
                    TimeSpan horasTrabajadas = horaSalida.Subtract(horaEntrada).Subtract(almuerzo);
                    TimeSpan horasExtra = horasTrabajadas.Subtract(horasNecesitadas);

                    datos.AppendValues(fecha, horaEntrada.ToString(),
                    horaSalida.ToString(), horasTrabajadas.ToString(),
                        horasExtra.ToString());
                }
            }
            catch (Exception e)
            {
                ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Error,
                    ButtonsType.Ok, e.Message);
                ms.Run();
                ms.Destroy();
                throw;
            }
            finally
            {
                idr.Close();
            }

            return datos;
        }
    }
}

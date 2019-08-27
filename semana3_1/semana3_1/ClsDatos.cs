﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana3_1
{
    class ClsDatos
    {
        public SqlConnection LeerCadena()
        {
            SqlConnection connection =
                new SqlConnection("Data Source=DESKTOP-Q02Q4RT;" + "Initial Catalog=Neptuno;Integrated Security=true");
            return connection;
        }
        public DataTable ListaPedidoFecha(DateTime x, DateTime y)
        {
            SqlConnection connection = LeerCadena();
            connection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("Usp_fecha", connection);
            sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlData.SelectCommand.Parameters.AddWithValue("@fec1", x);
            sqlData.SelectCommand.Parameters.AddWithValue("@fec2", y);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            connection.Close();
            return dataTable;
        }
        public DataTable ListaDetalle(int x)
        {
            SqlConnection connection = LeerCadena();
            connection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("Usp_detalle", connection);
            sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlData.SelectCommand.Parameters.AddWithValue("@IdPedido", x);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            connection.Close();
            return dataTable;
        }
        public double PedidoTotal(Int32 idpedido)
        {
            SqlConnection connection = LeerCadena();
            connection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("usp_Total", connection);
            sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlData.SelectCommand.Parameters.AddWithValue("@IdPedido", idpedido);
            sqlData.SelectCommand.Parameters.Add(
                "@Total", SqlDbType.Money).Direction =
                ParameterDirection.Output;
            sqlData.SelectCommand.ExecuteScalar();
            Int32 total = Convert.ToInt32(sqlData.SelectCommand.Parameters["@Total"].Value);
            connection.Close();
            return total;
        }
    }
}

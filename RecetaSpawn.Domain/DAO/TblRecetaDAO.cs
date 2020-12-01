using RecetaSpawn.Domain.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetaSpawn.Domain.DAO
{
    public class TblRecetaDAO
    {
		SqlConnection con = new SqlConnection();
		SqlCommand cmd = new SqlCommand();
		Conexion con2 = new Conexion();
		string sql;

		public List<TblReceta> ListarTablaReceta()
		{
			List<TblReceta> lista = new List<TblReceta>();
			sql = "select * from TblReceta";
			SqlDataAdapter da = new SqlDataAdapter(sql, con2.establecerconexion());
			DataTable tabla = new DataTable();
			da.Fill(tabla);
			if (tabla.Rows.Count > 0)
			{
				foreach (DataRow row in tabla.Rows)
				{
					TblReceta obj = new TblReceta();
					obj.ID_RECETA = int.Parse(row["ID_Recetas"].ToString());
					obj.RECETA = (row["Receta"]).ToString();
					obj.TIEMPO = (row["Tiempo"]).ToString();
					obj.INGREDIENTES = (row["Ingredientes"]).ToString();
					obj.PREPARACION = (row["Preparacion"]).ToString();
					lista.Add(obj);
				}
			}
			return lista;
		}


		public int Eliminar(int id, int status)
		{
			cmd.Connection = con2.establecerconexion();
			con2.AbrirConexion();
			sql = "UPDATE Recetw SET Estatus = @Estatus WHERE IDAdmin = @IDAdmin;";
			cmd.Parameters.AddWithValue("@Estatus", status);
			cmd.Parameters.AddWithValue("@IDAdmin", id);
			cmd.CommandText = sql;

			int i = cmd.ExecuteNonQuery();
			cmd.Parameters.Clear();

			if (i <= 0)
			{
				return 0;
			}
			return 1;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecetaSpawn.Domain.BO;
using RecetaSpawn.Domain.DAO;

namespace RecetaSpawn.Domain.Service
{
	public class TblRecetaCTRL
    {
		TblRecetaDAO metodo = new TblRecetaDAO();
		public List<TblReceta> TraerReceta()
        {
			List<TblReceta> data = new List<TblReceta>();
			data = metodo.ListarTablaReceta();
			return data;
        }
		public int Baja(int id, int status)
		{
			int resultado = 0;
			resultado = metodo.Eliminar(id, status);
			return resultado;
		}
	}
}

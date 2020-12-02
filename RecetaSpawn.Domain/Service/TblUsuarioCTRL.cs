using RecetaSpawn.Domain.BO;
using RecetaSpawn.Domain.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetaSpawn.Domain.Service
{
    public class TblUsuarioCTRL
    {

		//int
		TblUsuarioDAO Metodo = new TblUsuarioDAO();
		public int Agregar2(TblUsuariosBO obj)
		{
			int final = 0;
			final = Metodo.Agregar2(obj);
			return final;
		}
		//tranquilo, asi se genera uno mas rapido

		public int editar2(object obj)
		{
			int final;
			final = Metodo.Editar2(obj);
			return final;
		}




		public bool Agregar(object obj)
        {
			//int final = 0;
			bool final;
			final = Metodo.Agregar(obj);
			return final;
        }
		//tranquilo, asi se genera uno mas rapido

		public bool editar(object obj)
        {
			bool final;
			final = Metodo.Editar(obj);
			return final;
        }
		public bool eliminar(object obj)
        {
			bool final;
			final = Metodo.Eliminar(obj);
			return final;
        }

		public bool buscar()
        {
			bool final;
			final = Metodo.BuscarUsuarios();
			return final;
        }
	}
}

	
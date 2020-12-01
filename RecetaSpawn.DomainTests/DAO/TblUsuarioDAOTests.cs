using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecetaSpawn.Domain.BO;
using RecetaSpawn.Domain.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetaSpawn.Domain.DAO.Tests
{
    [TestClass()]
    public class TblUsuarioDAOTests
    {
        //quien llama? xD

        [TestMethod()] //ureil
        public void Agregar_LlenandoTodosLosCampos()
        {
            TblUsuariosBO data = new TblUsuariosBO();
            TblUsuarioDAO metodo = new TblUsuarioDAO();

            bool res;

            data.Nombre = "Usuario";
            data.Apellido = "Apellido";
            data.Correo = "usuario@gmail.com";
            data.Contraseña = "123";
            data.Genero = "Hombre";
            data.Rol = "Usuario";

            res = metodo.Agregar(data);

            Assert.IsTrue(res);
        }

        [TestMethod()]
        public void Editar_editandoxd()
        {
            TblUsuariosBO data = new TblUsuariosBO();
            TblUsuarioDAO metodo = new TblUsuarioDAO();

            bool res;
            data.Nombre = "Andrew";
            data.Apellido = "dobabes";
            data.Correo = "golosa@gmail.com";
            data.Contraseña = "987654";
            data.Genero = "Hombre";
            data.Rol = "Usuario";
            data.IDUsuario = 9;

            res = metodo.Editar(data);

            Assert.IsTrue(res);
        }

        [TestMethod()]
        public void Eliminar_datos()
        {
            TblUsuariosBO data = new TblUsuariosBO();
            TblUsuarioDAO metodo = new TblUsuarioDAO();

            bool res;
            data.IDUsuario = 9;
            res = metodo.Eliminar(data);

            Assert.IsTrue(res);
        }

        [TestMethod()]
        public void Buscar_Usuario()
        {
            TblUsuarioDAO metodo = new TblUsuarioDAO();
            TblUsuariosBO data = new TblUsuariosBO();

            bool res;
            res = metodo.BuscarUsuarios();
            Assert.IsTrue(res);
        }

    }
}
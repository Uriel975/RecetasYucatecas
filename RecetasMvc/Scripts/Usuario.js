var Usuario = {
    Objects: {
        IDUsuario: 0
    },
    init: function () {
        $("#formulario").on("submit", function (e) {
            e.preventDefault()

            var Nombre = $("#nombre").val();
            var Apellido = $("#apellido").val();
            var Genero = $("#genero").val();
            var Correo = $("#correo").val();
            var Contraseña = $("#contraseña").val();

            if (Usuario.Objects.IDUsuario == 0) {
                var Rol = $("#rol").val();

                if (Nombre.trim() == "") {
                    Dialog.show("El campo 'Nombre' es obligatorio", Dialog.type.error);
                    return;
                }
                if (Apellido.trim() == "") {
                    Dialog.show("El campo 'Apellido' es obligatorio", Dialog.type.error);
                    return;
                }
                if (Genero.trim() == "") {
                    Dialog.show("El campo 'Genero' es obligatorio", Dialog.type.error);
                    return;
                }
                if (Correo.trim() == "") {
                    Dialog.show("El campo 'Correo' es obligatorio", Dialog.type.error);
                    return;
                }
                if (Contraseña.trim() == "") {
                    Dialog.show("El campo 'Contraseña' es obligatorio", Dialog.type.error);
                    return;
                }
                if (Rol.trim() == "") {
                    Dialog.show("El campo 'Rol' es obligatorio", Dialog.type.error);
                    return;
                }
                /* [O-O] */
                $.ajax({
                    url: Root + "Usuarios/New",
                    type: "POST",
                    data: { nombre: Nombre, apellido: Apellido, genero: Genero, correo: Correo, contraseña: Contraseña, rol: Rol },
                    beforeSend: function () {
                        Dialog.show("Enviando Datos...", Dialog.type.progress);
                    },
                    success: function (response) {
                        if (response > 0) {
                            Dialog.show("Nuevo Administrador Creado Con Exito", Dialog.type.success);
                            $(".sem-dialog").on("done", function () {
                                location.reload(true);

                            });
                        }
                        else {
                            Dialog.show("Ocurrió un error al guardar, inténtelo de nuevo", Dialog.type.error);
                        }
                    }
                });
            }
            else {
                $.ajax({
                    url: Root + "Administrador/Update",
                    type: "POST",
                    data: { nombre: A_NAMEADM, correo: A_EMAIL, usuario: A_UNAME, id: Administrador.Objects.IDAdministrador },
                    beforeSend: function () {
                        Dialog.show("Actualizando datos", Dialog.type.progress);
                    },
                    success: function (response) {
                        if (response > 0) {
                            Dialog.show("Empleado actualizado correctamente", Dialog.type.success);
                            $(".sem-dialog").on("done", function () {
                                location.reload(true);
                            });
                        }
                        else {
                            Dialog.show("Ocurrió un error al actualizar, inténtelo de nuevo", Dialog.type.error);
                        }
                    }
                });
            }
        });
    },
    evts: {
        getAdministradorInfo: function (id, nombre, correo, usuario) {
            Administrador.Objects.IDAdministrador = id;
            $("#txtNombreAdm").val(nombre);
            $("#txtCorreoAdm").val(correo);
            $("#txtUsuarioAdm").val(usuario);
            $("#mdlDetail").modal("show");
            $("#employeeStr").text("Actualizar Empleado");
            Dialog.hide();
        },
        updateStatus: function (id, status) {
            if (status == "0") {
                Dialog.show("¿Estás seguro que quiere Eliminar este Administrador?", Dialog.type.question);
            }
            else {
                Dialog.show("¿Reactivar este Usuario?", Dialog.type.question);
            }
            $(".sem-dialog").on("done", function () {
                $.ajax({
                    url: Root + "Administrador/UpdateStatus",
                    type: "POST",
                    data: { id: id, estatus: status },
                    beforeSend: function () {
                        Dialog.show("Eliminando datos", Dialog.type.progress);
                    },
                    success: function (response) {
                        if (response > 0) {
                            location.reload(true);
                        }
                        else {
                            Dialog.show("A Ocurrido Un Error, Intente De Nuevo", Dialog.type.error);
                        }
                    }
                });
            });
        }
    },

}
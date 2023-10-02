var token = getCookie("Token")
let table = new DataTable('#usuarios', {
    ajax: {
        url: `https://localhost:7268/api/Usuario`,
        dataSrc: "data.items",
        headers: { "Authorization": "Bearer " + token }
    },
    columns: [
        { data: 'codUsuario', title: 'Id' },
        { data: 'nombre', title: 'Nombre' },
        { data: 'dni', title: 'Dni' },
        { data: 'rol.nombre', title: 'Rol' },
        {
            data: function (data) {
                var botones =
                    `<td><a href='javascript:EditarUsuario(${JSON.stringify(data)})'><i class="fa-solid fa-pen-to-square editarUsuario"></i></td>` +
                    `<td><a href='javascript:EliminarUsuario(${JSON.stringify(data)})'><i class="fa-solid fa-trash eliminarUsuario"></i></td>`
                return botones;
            }
        }

    ]
});

function AgregarUsuario() {
    $.ajax({
        type: "GET",
        url: "/Usuarios/UsuariosAddPartial",
        data: "",
        contentType: 'application/json',
        'dataType': "html",
        success: function (resultado) {
            $('#usuariosAddPartial').html(resultado);
            $('#usuarioModal').modal('show');
        }

    });
}
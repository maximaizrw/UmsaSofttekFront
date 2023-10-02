using Data.Dtos;

namespace UmsaSofttekFront.ViewModels
{
    public class UsuariosViewModel
    {
        public string Nombre { get; set; }
        public int Dni { get; set; }
        public string Clave { get; set; }
        public int RolId { get; internal set; }

        public static implicit operator UsuariosViewModel(UsuarioDto v)
        {
            throw new NotImplementedException();
        }
    }
}

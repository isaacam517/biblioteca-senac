using System.Linq;
using System.Collections.Generic;

namespace Biblioteca.Models
{
    public class UsuarioService
    {
        public List<Usuario> Listar()
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.usuarios.ToList();
            }
        }
        public Usuario Listar(int id)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.usuarios.Find(id);
            }
        }
        public void incluirUsuario(Usuario novoUser)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Add(novoUser);
                bc.SaveChanges();
            }
        }
        public void editarUsuario(Usuario userEditado)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                Usuario u = bc.usuarios.Find(userEditado.Id);

                u.login = userEditado.login;
                u.Nome = userEditado.Nome;
                u.senha = userEditado.senha;
                u.tipo = userEditado.tipo;

                bc.SaveChanges();
            }
        }
        public void excluirUsuario(int id)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                bc.usuarios.Remove(bc.usuarios.Find(id));
                bc.SaveChanges();
            }
        }
    }
}
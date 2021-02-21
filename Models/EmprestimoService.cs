using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Models
{
    public class EmprestimoService 
    {
        public void Inserir(Emprestimo e)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Emprestimos.Add(e);
                bc.SaveChanges();
            }
        }

        public void Atualizar(Emprestimo e)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                Emprestimo emprestimo = bc.Emprestimos.Find(e.Id);
                emprestimo.NomeUsuario = e.NomeUsuario;
                emprestimo.Telefone = e.Telefone;
                emprestimo.LivroId = e.LivroId;
                emprestimo.DataEmprestimo = e.DataEmprestimo;
                emprestimo.DataDevolucao = e.DataDevolucao;

                bc.SaveChanges();
            }
        }

        public ICollection<Emprestimo> ListarTodos(FiltrosEmprestimos filtro)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                IQueryable<Emprestimo> consulta;

                if(filtro!=null)
                {
                    switch(filtro.TipoFiltro)
                    {
                        case "Usuario":
                            consulta = bc.Emprestimos.Where(e => e.NomeUsuario.Contains(filtro.Filtro));
                        break;

                        case "Livro":
                            List<Livro> LivrosFiltrados = bc.Livros.Where(l => l.Titulo.Contains(filtro.Filtro)).ToList();

                            List<int>LivrosIds = new List<int>();
                            for (int i = 0; i < LivrosFiltrados.Count; i++)
                            {
                                LivrosIds.Add(LivrosFiltrados[i].Id);
                            }

                            consulta = bc.Emprestimos.Where(e => LivrosIds.Contains(e.LivroId));
                            var debug = consulta.ToList();
                        break;

                        default:
                            consulta = bc.Emprestimos;
                        break;
                    }
                }
                else{
                    consulta = bc.Emprestimos;
                }

                List<Emprestimo> ListaConsulta = consulta.OrderBy(e => e.DataEmprestimo).ToList();

                for (int i = 0; i < ListaConsulta.Count; i++)
                {
                    ListaConsulta[i].Livro = bc.Livros.Find(ListaConsulta[i].LivroId);
                }

                return ListaConsulta;
                
            }
        }

        public Emprestimo ObterPorId(int id)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Emprestimos.Find(id);
            }
        }
    }
}
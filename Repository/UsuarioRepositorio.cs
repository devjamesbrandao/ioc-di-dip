using ioc_di_dip.Context;
using ioc_di_dip.Model;
using Microsoft.EntityFrameworkCore;

namespace ioc_di_dip.Repository
{   
    // Implementando DIP com a interface
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        // Implementando IoC do método e DI do contexto
        private readonly ExemploContext _context;

        public UsuarioRepositorio(ExemploContext context)
        {
            _context = context;
        }

        public async Task<Usuario> ObterUsuarioPorId(int id)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
using ioc_di_dip.Model;

namespace ioc_di_dip.Repository
{
    public interface IUsuarioRepositorio
    {
        Task<Usuario> ObterUsuarioPorId(int id);
    }
}
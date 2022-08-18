using ioc_di_dip.Context;
using ioc_di_dip.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ioc_di_dip.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    // private readonly UsuarioRepositorio _repositorio;

    private readonly IUsuarioRepositorio _repositorio;

    public WeatherForecastController(IUsuarioRepositorio repositorio)
    {
        _repositorio = repositorio;
    }

    [HttpGet("exemplo-com-ioc-di-e-dip")]
    public async Task<IActionResult> ExemploComIocDI([FromQuery] int id)
    {
        return Ok(await _repositorio.ObterUsuarioPorId(id));
    }



    // [HttpGet("exemplo-com-ioc-e-di")]
    // public async Task<IActionResult> ExemploComIocDI([FromQuery] int id)
    // {
    //     return Ok(await _repositorio.ObterUsuarioPorId(id));
    // }

    // Sem IoC, DI e DIP
    // [HttpGet("exemplo-sem-injecao-de-dependencia")]
    // public async Task<IActionResult> ExemploSemInjecaoDeDependencia([FromQuery] int id)
    // {
    //     var configuracoes = new DbContextOptionsBuilder<ExemploContext>()
    //     .UseSqlite("DataSource=exemplo.db;Cache=Shared")
    //     .Options;

    //     var contexto = new ExemploContext(configuracoes);

    //     // Criar a estrutura do banco de dados
    //     contexto.Database.EnsureCreated();

    //     // #1. Obter usuário por id
    //     // Esse trecho de código está acoplado, isto é, não posso reutilizá-lo em nenhum outro lugar
    //     // Portanto, podemos afirmar que ele está ferindo o princípio da Inversão de controle (IoC)
    //     var usuarios = await contexto.Usuarios.FirstOrDefaultAsync(x => x.Id == id);

    //     return Ok(usuarios);
    // }
}

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[Route("api/[controller]")]
[ApiController]
public class UsuarioController : ControllerBase
{
    private readonly UsuarioRepository _repository;

    public UsuarioController(UsuarioRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public ActionResult<List<Usuario>> Get()
    {
        return _repository.ObterTodos();
    }

    [HttpGet("{id:length(24)}", Name = "GetUsuario")]
    public ActionResult<Usuario> Get(string id)
    {
        var usuario = _repository.ObterPorId(id);

        if (usuario == null)
        {
            return NotFound();
        }

        return usuario;
    }

    [HttpPost]
    public ActionResult<Usuario> Post(Usuario usuario)
    {
        _repository.Adicionar(usuario);

        return CreatedAtRoute("GetUsuario", new { id = usuario.Id.ToString() }, usuario);
    }

    [HttpPut("{id:length(24)}")]
    public IActionResult Put(string id, Usuario usuarioIn)
    {
        var usuario = _repository.ObterPorId(id);

        if (usuario == null)
        {
            return NotFound();
        }

        _repository.Atualizar(id, usuarioIn);

        return NoContent();
    }

    [HttpDelete("{id:length(24)}")]
    public IActionResult Delete(string id)
    {
        var usuario = _repository.ObterPorId(id);

        if (usuario == null)
        {
            return NotFound();
        }

        _repository.Deletar(id);

        return NoContent();
    }
}

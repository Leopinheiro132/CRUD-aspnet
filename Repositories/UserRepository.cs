using MongoDB.Driver;
using System.Collections.Generic;

public class UsuarioRepository
{
    private readonly IMongoCollection<Usuario> _usuarios;

    public UsuarioRepository(string connectionString, string databaseName)
    {
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase(databaseName);
        _usuarios = database.GetCollection<Usuario>("usuarios");
    }

    public List<Usuario> ObterTodos()
    {
        return _usuarios.Find(usuario => true).ToList();
    }

    public Usuario ObterPorId(string id)
    {
        return _usuarios.Find(usuario => usuario.Id == id).FirstOrDefault();
    }

    public Usuario Adicionar(Usuario usuario)
    {
        _usuarios.InsertOne(usuario);
        return usuario;
    }

    public void Atualizar(string id, Usuario usuario)
    {
        _usuarios.ReplaceOne(u => u.Id == id, usuario);
    }

    public void Deletar(string id)
    {
        _usuarios.DeleteOne(usuario => usuario.Id == id);
    }
}

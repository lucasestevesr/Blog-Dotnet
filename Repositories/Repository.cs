using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace BlogLucas.Repositories
{
    public class Repository<TModel> where TModel : class //Classe genérica, onde 'TModel' é um classe genérico
    {
        private readonly SqlConnection _connection;
        public Repository(SqlConnection connection)
            => _connection = connection;  //Construtor - Metódo com mesmo nome da Classe.
        public IEnumerable<TModel> Get() => _connection.GetAll<TModel>(); //Elimina '{} e o return' pelo Expression body '=>'

        public TModel Get(int id) => _connection.Get<TModel>(id);

        public void Create(TModel model) => _connection.Insert<TModel>(model);

        public void Update(TModel model) => _connection.Update<TModel>(model);

        public void Delete(TModel model) => _connection.Delete<TModel>(model);

        public void Delete(int id)
        {
            var model = _connection.Get<TModel>(id);
            _connection.Delete<TModel>(model);
        }

    }
}
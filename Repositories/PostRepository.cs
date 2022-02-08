using BlogLucas.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BlogLucas.Repositories
{
    public class PostRepository : Repository<User>
    {
        private readonly SqlConnection _connection;
        public PostRepository(SqlConnection connection)
        : base(connection)
            => _connection = connection;


        public void BindPostTag(int postId, int tagId)
        {
            var insertSql = @"INSERT INTO [PostTag] VALUES(@postId, @tagId)";

            _connection.Execute(insertSql, new
            {
                postId,
                tagId
            });
        }

        public void UnbindUserRole(int postId, int tagId)
        {
            var deleteSql = @"DELETE FROM [PostTag] WHERE [PostId] = @postId and [TagId] = @tagId";

            _connection.Execute(deleteSql, new
            {
                postId,
                tagId
            });
        }
    }
}
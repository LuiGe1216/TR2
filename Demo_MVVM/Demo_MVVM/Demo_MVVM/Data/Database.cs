using Demo_MVVM.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MVVM.Data
{
    public class Database
    {
        readonly SQLiteAsyncConnection _connection;

        public Database(string dbPath)
        {
            _connection = new SQLiteAsyncConnection(dbPath);
            _connection.CreateTableAsync<User>().Wait();
        }

        public Task<List<User>> GetUsuariosAsync()
        {
            return _connection.Table<User>().ToListAsync();
        }

        public Task<int> SaveUsuarioAsync(User usuario)
        {
            if (usuario.Id != 0)
            {
                return _connection.UpdateAsync(usuario);
            }
            else
            {
                return _connection.InsertAsync(usuario);
            }
        }
    }
}

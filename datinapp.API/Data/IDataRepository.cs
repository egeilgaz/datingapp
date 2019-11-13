using System.Collections.Generic;
using System.Threading.Tasks;
using datinapp.API.helpers;
using datinapp.API.models;
using DatingApp.API.Helpers;


namespace DatingApp.API.Data
{
    public interface IDataRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<PagedList<User>> GetUsers(UserParams userParams);
         Task<User> GetUser(int id);
         Task<Photo> GetPhoto(int id);
         Task<Photo> GetMainPhotoForUser(int userId);
    }
}
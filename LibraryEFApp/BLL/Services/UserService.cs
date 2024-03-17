using LibraryEFApp.BLL.Exceptions;
using LibraryEFApp.DAL.Entities;
using LibraryEFApp.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFApp.BLL.Services
{
    public class UserService
    {
        IUserRepository userRepository;
        public UserService()
        {
            userRepository = new UserRepository();
        }

        public void Register(UserEntity user)
        {
            if (String.IsNullOrEmpty(user.Name))
                throw new ArgumentNullException();

            if (String.IsNullOrEmpty(user.Email))
                throw new ArgumentNullException();

            var userEntity = new UserEntity()
            {
                Name = user.Name,
                Email = user.Email
            };

            try
            {
                userRepository.AddUser(userEntity);
            }
            catch (Exception ex) { throw new Exception(); };

        }

        public List<UserEntity> FindAll()
        {
            try
            {
                var users = userRepository.FindAll();
                return users;
            }
            catch (Exception ex) { throw new Exception(); };

        }

        public UserEntity FindUserById(int id)
        {
            var findUserEntity = userRepository.FindById(id);
            if (findUserEntity is null) throw new UserNotFoundException();

            return findUserEntity;
        }

        public void Delete(string name, string email)
        {
            if (String.IsNullOrEmpty(name))
                throw new ArgumentNullException();

            if (String.IsNullOrEmpty(email))
                throw new ArgumentNullException();

            try
            {
                userRepository.Delete(name, email);
            }
            catch (Exception ex) { throw new Exception(); };

        }
        public void UpdateById(int id, string name)
        {
            if (String.IsNullOrEmpty(name))
                throw new ArgumentNullException();
            
            try
            {
                userRepository.UpdateById(id, name);
            }
            catch (Exception ex) { throw new Exception(); };

        }

    }
}


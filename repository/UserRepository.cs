using System;
using System.Collections.Generic;
using System.Linq;
using AutoPartsStore;
using Microsoft.EntityFrameworkCore;

namespace AutoPartsStoreLibrary {
    public interface IUserRepository : IRepository<User> {

    }

    public class UserRepository : IUserRepository, Repository<User> {


    }

    public class qwe {
        public void qwer(){
            IUserRepository rep = new UserRepository();
            
        }
    }
}
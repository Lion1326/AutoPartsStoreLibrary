using System;
using System.Collections.Generic;
using System.Linq;
using AutoPartsStore;
using Microsoft.EntityFrameworkCore;

namespace KonstProgKyrsach {
    public interface IRepository<T> {
        T GetByID (int Id);
        T AddPart (T model);
        void UpdatePart (T model);
        void DeletePart (T model);
        List<T> GetList ();
    }

    public class Repository<T> : IRepository<T> where T : class {
        DbSet<T> _dbSet;
        private AutoStoryPartsDBContext _dbContext;
        public Repository (AutoStoryPartsDBContext dBEntities) {
            this._dbContext = dBEntities;
            this._dbSet = _dbContext.Set<T> ();
        }

        public virtual T GetByID (int Id) {
            return _dbSet.Find (Id);
        }

        public virtual T AddPart (T model) {
            model = _dbSet.Add (model).Entity;
            _dbContext.SaveChanges ();
            return model;
        }

        public virtual void UpdatePart (T model) {
            _dbContext.Entry (model).State = EntityState.Modified;
            _dbContext.SaveChanges ();
        }

        public virtual void DeletePart (T model) {
            _dbSet.Remove (model);
            _dbContext.Entry (model).State = EntityState.Modified;
            _dbContext.SaveChanges ();
        }

        public virtual List<T> GetList () {
            return _dbSet.ToList ();
        }
    }
}
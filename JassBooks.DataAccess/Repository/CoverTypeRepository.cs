using JassBooks.DataAccess.Repository.IRepository;
using JassBooks.Models;
using JassBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace JassBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

       
    }
}
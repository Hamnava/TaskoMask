﻿using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaskoMask.Domain.ReadModel.Data;
using TaskoMask.Domain.ReadModel.Entities;
using TaskoMask.Infrastructure.Data.Common.Contracts;
using TaskoMask.Infrastructure.Data.WriteMoldel.Repositories;

namespace TaskoMask.Infrastructure.Data.ReadMoldel.Repositories
{
    public class TaskRepository : BaseRepository<Domain.ReadModel.Entities.Task>, ITaskRepository
    {
        #region Fields

        private readonly IMongoCollection<Domain.ReadModel.Entities.Task> _tasks;

        #endregion

        #region Ctors

        public TaskRepository(IMongoDbContext dbContext) : base(dbContext)
        {
            _tasks = dbContext.GetCollection<Domain.ReadModel.Entities.Task>();
        }

        #endregion

        #region Public Methods



        #endregion

        #region Private Methods



        #endregion

    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaskoMask.Domain.Core.Data;
using TaskoMask.Domain.Data;

namespace TaskoMask.Infrastructure.Data.Repositories
{
    public class TaskRepository : Repository<Domain.Models.Task>, ITaskRepository
    {
        public TaskRepository()
        {

        }
        public Task<IEnumerable<Domain.Models.Task>> GetListByBoardIdAsync(string boardId)
        {
            throw new NotImplementedException();
        }
    }
}

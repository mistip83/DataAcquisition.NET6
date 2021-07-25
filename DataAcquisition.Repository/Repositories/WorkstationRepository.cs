﻿using System.Threading.Tasks;
using DataAcquisition.DataAccessEF.DataAccess;
using DataAcquisition.Interface.Repositories;
using DataAcquisition.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAcquisition.Repository.Repositories
{
    /// <summary>
    /// Encapsulate the logic required to access data sources
    /// </summary>
    public class WorkstationRepository : Repository<Workstation>, IWorkstationRepository
    {
        private AppDbContext AppDbContext => Context;

        public WorkstationRepository(AppDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Implementation detail
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Workstation> GetWorkstationWithDevicesAndExperimentsAsync(int id)
        {
            return await AppDbContext.Workstation.Include(x => x.Devices)
                .Include(x=>x.Experiments)
                .SingleOrDefaultAsync(x => x.WorkstationId == id);
        }
    }
}
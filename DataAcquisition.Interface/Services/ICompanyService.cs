﻿using System;
using System.Threading.Tasks;
using DataAcquisition.Model.Entities;

namespace DataAcquisition.Interface.Services
{
    public interface ICompanyService
    {
        /// <summary>
        /// Returns company entity with its facilities
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<Company> GetCompanyWithFacilitiesAsync(Guid id);

        /// <summary>
        /// Returns company entity
        /// </summary>
        /// <returns></returns>
        Task<Company> GetCompanyInfoAsync();
    }
}
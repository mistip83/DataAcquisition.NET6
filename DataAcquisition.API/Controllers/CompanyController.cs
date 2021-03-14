﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataAcquisition.Interface.Services;
using DataAcquisition.Model.DTOs;

namespace DataAcquisition.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        private readonly IMapper _mapper;

        public CompanyController(ICompanyService companyService, IMapper mapper)
        {
            _mapper = mapper;
            _companyService = companyService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCompanyInfo()
        {
            var company = await _companyService.GetCompanyInfoAsync();
            return Ok(company);
            //return Ok(_mapper.Map<CompanyDto>(company));
        }
    }
}
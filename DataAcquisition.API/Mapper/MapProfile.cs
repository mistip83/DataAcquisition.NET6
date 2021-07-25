using System.Collections.Generic;
using AutoMapper;
using DataAcquisition.Model.DTOs;
using DataAcquisition.Model.Entities;

namespace DataAcquisition.API.Mapper
{
    /// <summary>
    /// Transform entity to dto or dto to entity
    /// </summary>
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Company, CompanyDto>();
            CreateMap<CompanyDto, Company>();
            CreateMap<Company, OrganizationDto>();
            CreateMap<OrganizationDto, Company>();

            CreateMap<Device, DeviceDto>();
            CreateMap<DeviceDto, Device>();

            CreateMap<Experiment, ExperimentDto>();
            CreateMap<ExperimentDto, Experiment>();

            CreateMap<Facility, FacilityDto>();
            CreateMap<FacilityDto, Facility>();
            CreateMap<Facility, FacilityWithWorkstationsDto>();
            CreateMap<FacilityWithWorkstationsDto, Facility>();

            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();

            CreateMap<Workstation, WorkstationDto>();
            CreateMap<WorkstationDto, Workstation>();
        }
    }
}

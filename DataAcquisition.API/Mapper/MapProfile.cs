using AutoMapper;
using DataAcquisition.Core.Models.Acquisition;
using DataAcquisition.Core.Models.DTOs;
using DataAcquisition.Core.Models.Entities;

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
            CreateMap<Device, DeviceNameDto>();
            CreateMap<DeviceNameDto, Device>();

            CreateMap<Experiment, ExperimentDto>();
            CreateMap<ExperimentDto, Experiment>();
            CreateMap<Experiment, ExperimentNameDto>();
            CreateMap<ExperimentNameDto, Experiment>();
            CreateMap<ExperimentData, ExperimentDataDto>();
            CreateMap<ExperimentDataDto, ExperimentData>();

            CreateMap<Facility, FacilityDto>();
            CreateMap<FacilityDto, Facility>();
            CreateMap<Facility, FacilityWithWorkstationsDto>();
            CreateMap<FacilityWithWorkstationsDto, Facility>();

            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();

            CreateMap<Workstation, WorkstationDto>();
            CreateMap<WorkstationDto, Workstation>();
            CreateMap<Workstation, WorkstationWithDevicesAndExps>();
            CreateMap<WorkstationWithDevicesAndExps, Workstation>();
            CreateMap<Workstation, WorkstationNameDto>();
            CreateMap<WorkstationNameDto, Workstation>();
        }
    }
}

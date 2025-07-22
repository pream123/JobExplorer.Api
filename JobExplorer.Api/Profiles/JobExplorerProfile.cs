using AutoMapper;
using JobExplorer.Api.Dtos;
using JobExplorer.Api.Model;

namespace JobExplorer.Api.Profiles
{
    public class JobExplorerProfile : Profile
    {
        public JobExplorerProfile()
        {
            CreateMap<JobExplorerModel, JobExplorerReadDto>();
        }
    }
}
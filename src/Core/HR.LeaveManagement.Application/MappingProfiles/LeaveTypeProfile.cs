namespace HR.LeaveManagement.Application.MappingProfiles;

internal class LeaveTypeProfile : Profile
{
  public LeaveTypeProfile()
  {
    CreateMap<LeaveTypeDto, LeaveType>().ReverseMap();
  }
}

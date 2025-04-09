using AutoMapper;

public class MyMappingProfile : Profile
{
    public MyMappingProfile()
    {
        CreateMap<User, UserDTO>().ReverseMap();

    }
}
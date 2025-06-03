using AutoMapper;
using Microsoft.Identity.Client;

public class MyMappingProfile :Profile
{
    public MyMappingProfile()
    {
        CreateMap<Category,CategoryUi>().ReverseMap();
    }
}
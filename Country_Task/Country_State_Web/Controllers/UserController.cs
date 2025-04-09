using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Text.Json.Serialization;

namespace Country_State_Web.Controllers
{
    public class UserController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly string _endpoint;
        private readonly IMapper _mapper;
        public UserController(HttpClient httpClient, IConfiguration configuration , IMapper mapper)
        {
            _httpClient = httpClient;
            _endpoint = configuration.GetSection("apiUrl").Value;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var Users = new List<UserModel>();

            try
            {
                var response = _httpClient.GetAsync("https://localhost:7144/api/User").Result;

                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                      if(json != null) {
                     Users= JsonConvert.DeserializeObject<List<UserModel>>(json); 
                    }
                  
                }
            }
            catch (Exception EX)
            {

                Console.WriteLine("Error :" +EX.Message );
            }
            return View(Users);
        }
    }
}

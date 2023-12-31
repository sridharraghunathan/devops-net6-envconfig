﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace devops_net6_envconfig.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigController : ControllerBase
    {
        public IConfiguration _configuration { get; }

        public ConfigController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

         [HttpGet]
        public async Task<string> GetConfigurationAppSettings()
        {
            var config = _configuration["SqlConnectionString"];
            return await Task.Run(() => config);
        }

        [HttpGet("secret")]
        public async Task<string> GetSecret()
        {
            var config = _configuration["DBSecret"];
            return await Task.Run(() => config);
        }

    }
}

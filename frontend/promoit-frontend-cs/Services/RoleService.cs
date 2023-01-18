﻿using Newtonsoft.Json;
using Shared;

namespace promoit_frontend_cs.Services
{
    public class RoleService
    {

        private readonly ILogger<RoleService> _logger;
        private readonly HttpClient _http;
        private readonly Dictionary<string, string> roles;
        public RoleService(HttpClient Http, ILogger<RoleService> logger)
        {
            _http = Http;
            _logger = logger;
            roles = new Dictionary<string, string>(){
    {"Activist", "rol_Kfj83rfyJDGlIhEq"},
    {"BCR", "rol_rvrE4kaUwM1ZmDyc"},
    {"NPCR", "rol_E36SwZN0k609LcpS"}
    };

        }

        public async Task<HttpResponseMessage> RoleAdder(string user_id, string role_name)
        {
            string role_id = roles[role_name];
            string req_string = $"https://localhost:7263/add-role/{user_id}/{role_id}";

            try
            {
               return await _http.PutAsync(req_string, null);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, $"Error adding a role");
                throw new Exception($"Error adding a role", exception);
            }
        }

    }
}



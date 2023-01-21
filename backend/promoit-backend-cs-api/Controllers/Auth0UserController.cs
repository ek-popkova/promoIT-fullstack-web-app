﻿using Auth0.ManagementApi;
using Auth0.ManagementApi.Models;
using Auth0.ManagementApi.Paging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace promoit_backend_cs_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //[Authorize(Roles = "Admin")]

    public class UserController : ControllerBase
    {
        private readonly IManagementApiClient _managementApiClient;

        public UserController(IManagementApiClient managementApiClient)
        {
            _managementApiClient = managementApiClient;
        }

        [HttpGet]
		[Authorize(Roles = "Admin")]
		public async Task<IEnumerable<UserDTO>> GetUsers()
        {
            var users = await _managementApiClient.Users.GetAllAsync(new GetUsersRequest(), new PaginationInfo());
            return users.Select(x => new UserDTO
            {
                Email = x.Email,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Blocked = x.Blocked ?? false,
            });
        }

        [HttpPut("/add-role/{user_id}/{role_id}")]
		[Authorize(Roles = "Admin")]

		public async Task<IActionResult> AssignRole(string user_id, string role_id)
        {
            string[] roles = new string[] { role_id };

            var assignRequest = new AssignRolesRequest
            {
                Roles = roles
            };
            await _managementApiClient.Users.AssignRolesAsync(user_id, assignRequest);
            return NoContent();
        }

        [HttpPut("/delete-role/{user_id}/{role_id}")]
		[Authorize(Roles = "Admin")]

		public async Task<IActionResult> DeleteRole(string user_id, string role_id)
        {
            string[] roles = new string[] { role_id };

            var assignRequest = new AssignRolesRequest
            {
                Roles = roles
            };
            await _managementApiClient.Users.RemoveRolesAsync(user_id, assignRequest);
            return NoContent();
        }


        /// <summary>
        /// Assigns Roles to a user.
        /// </summary>
        /// <param name="id">The ID of the user to assign roles to.</param>
        /// <param name="request">A <see cref="AssignRolesRequest" /> containing the role IDs to assign to the user.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>A <see cref="Task"/> that represents the asynchronous assign operation.</returns>
        //Task AssignRolesAsync(string id, AssignRolesRequest request, CancellationToken cancellationToken = default);
    }
}
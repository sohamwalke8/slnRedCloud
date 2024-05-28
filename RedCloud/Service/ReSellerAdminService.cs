﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MvcApiCallingService.Helpers.ApiHelper;
using Newtonsoft.Json;
using RedCloud.Controllers;
using RedCloud.Domain.Entities;
using RedCloud.Interface;
using RedCloud.Models;

namespace RedCloud.Service
{
    public class ReSellerAdminService : IReSellerAdminService
    {
        private readonly ILogger<ReSellerAdminService> _logger;
        private readonly IApiClient<ResellerAdminVM> _client;
        public ReSellerAdminService(ILogger<ReSellerAdminService> logger, IApiClient<ResellerAdminVM> client)
        {
            _logger = logger;
            _client = client;
        }

       

        [HttpGet]
        public  async Task<IEnumerable<ResellerAdminVM>> GetallResellerAdmin()
        {
            //_logger.LogInformation("GetAllCategories Service initiated");
            var reSelleradmin = await _client.GetAllAsync("ReSellerAdmin/all");
            //_logger.LogInformation("GetAllCategories Service conpleted");
            return reSelleradmin.Data;
        }




        public async Task<ResellerAdminVM> GetResellerAdminById(int id)
        {
            // Ensure the id is properly inserted into the URL
            var apiUrl = $"ReSellerAdmin/{id}";
            var response = await _client.GetByIdAsync(apiUrl);
            return response.Data;
        }

        public async Task SoftDeleteResellerAdmin(int id)
        {
            //_logger.LogInformation($"Soft delete initiated for ResellerAdmin with ID: {id}");

            await _client.DeleteAsync($"ReSellerAdmin/{id}");

            //_logger.LogInformation($"Soft delete completed for ResellerAdmin with ID: {id}");
        }

        public async Task  Block(int Id)
        {
            var apiUrl = $"ReSellerAdmin/{Id}";
            var response = await _client.GetByIdAsync(apiUrl);
            var data = response.Data;
            data.IsActive = false;
            await _client.PutAsync(apiUrl, data);
                 
        }


    }




    }
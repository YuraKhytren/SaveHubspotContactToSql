using Application.Dto;
using Application.Services.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementation
{
    public class HubspotService : IHubspotService
    {

        public async Task<List<ContactDto>> GetContacts()
        {
            return new List<ContactDto> {
                new ContactDto(){ LastName = "Tom", FirstName = "Tom", BirthDate = "25.08.2020", Email = "Tom@gmail.com" },
                new ContactDto(){ LastName = "Robert", FirstName = "Robert", BirthDate = "25.08.2020", Email = "Robert@gmail.com" },
                new ContactDto(){ LastName = "Stive", FirstName = "Stive", BirthDate = "25.08.2020", Email = "Stive@gmail.com" },
                new ContactDto(){ LastName = "Julia", FirstName = "Julia", BirthDate = "25.08.2020", Email = "Julia@gmail.com" },
                new ContactDto(){ LastName = "Niro", FirstName = "Niro", BirthDate = "25.08.2020", Email = "Niro@gmail.com" }

            };
        }
    }
}

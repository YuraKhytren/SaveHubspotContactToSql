using Application.Dto;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IMssqlContactRepository
    {
        Task WriteContact(List<ContactDto> contacts);
    }
}

using Application.Dto;
using Application.Services.Interfaces;
using Domain.Entities;
using Infrastructure;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementation
{
    public class MssqlContactService : lContactRepository
    {
        private ContactContext _appContext;

        public MssqlContactService(ContactContext contactContext)
        {
            _appContext = contactContext;
        }

        public async Task WriteContact(List<ContactDto> contacts)
        {
            foreach (var contact in contacts)
            {
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@FirstName", contact.FirstName.SqlValue()),
                    new SqlParameter("@LastName", contact.LastName.SqlValue()),
                    new SqlParameter("@BirthDate", contact.BirthDate.SqlValue()),
                    new SqlParameter("@Email", contact.Email.SqlValue())
                };

                 await _appContext.Database.ExecuteSqlRawAsync("dbo.WriteContact @FirstName, @LastName, @BirthDate, @Email", sqlParameters);
            }
        }
    }
}

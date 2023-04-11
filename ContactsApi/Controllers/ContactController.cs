using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ContactsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private IHubspotService _hubspotService;
        private IMssqlContactRepository _msqlContactRepository;
        public ContactController(IConfiguration configuration, IHubspotService hubspotService, IMssqlContactRepository mssqlContactRepository) 
        {
            _configuration = configuration;
            _hubspotService = hubspotService;
            _msqlContactRepository = mssqlContactRepository;
        }
        [HttpGet]
        public async Task<IActionResult> WriteContacts() 
        {
            var contacts = await _hubspotService.GetContacts();

            try
            {
                await _msqlContactRepository.WriteContact(contacts);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}

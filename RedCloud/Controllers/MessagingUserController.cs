using Microsoft.AspNetCore.Mvc;
using RedCloud.Interfaces;
using RedCloud.Services;

namespace RedCloud.Controllers
{
    public class MessagingUserController : Controller
    {
        private readonly IMessagingUserService _messagingUserService;
        private readonly ILogger<MessagingUserController> _logger;



        public MessagingUserController(IMessagingUserService messagingUserService, ILogger<MessagingUserController> logger)
        {
            _messagingUserService = messagingUserService;
            _logger = logger;

        }

     

        [HttpGet]
        public async Task<IActionResult> ViewMessagingUsers(int Id)
        {
            //_logger.LogInformation("ViewOrganizationAdmin Action initiated");
            var model = await _messagingUserService.GetAllMessagingUsers();
            //_logger.LogInformation("ViewOrganizationAdmin Action completed");
            return View(model);
        }


        public async Task<IActionResult> ViewMessagingUserDetails(int id)
        {


            //_logger.LogInformation($"Fetching ViewOrganizationDetails with ID: {id}");
            var response = await _messagingUserService.GetMessagingUserById(id);
            if (response == null)
            {
                _logger.LogWarning($"ViewOrganizationDetails with ID: {id} not found");
                return NotFound();
            }

            return View(response);

        }



        [HttpPut]
        public async Task<IActionResult> BlockMessagingUser(int id)
        {
            try
            {
                var response = await _messagingUserService.BlockMessagingUser(id);
                return Json(new { success = true, message = "Successfully blocked the Messaging User " + response.MessagingUserFirstName });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "An error occurred while blocking the Messaging User." });
            }
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

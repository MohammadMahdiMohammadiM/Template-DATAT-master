namespace Server.Pages.Admin.CultureManagement
{
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Admin")]
    public class UpdateModel : Infrastructure.BasePageModelWithDatabaseContext
    {
        public UpdateModel 
            (Data.DatabaseContext databaseContext,
             Microsoft.Extensions.Logging.ILogger<UpdateModel> logger) :
		     base(databaseContext: databaseContext)
        {
            //Logger = logger;

            //ViewModel = new();
        }

        public void OnGet()
        {
        }
    }
}

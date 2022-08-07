namespace Server.Pages.Admin.CultureManagement
{
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Admin")]
    public class UpdateModel : Infrastructure.BasePageModel
    {
        public UpdateModel() : base()
        {
        }

        public void OnGet()
        {
        }
    }
}

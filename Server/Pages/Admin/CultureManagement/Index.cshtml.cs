using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Server.Pages.Admin.CultureManagement
{
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Admin")]
    public class IndexModel : Infrastructure.BasePageModel
    {
        #region Constructor
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public IndexModel
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
            (Microsoft.Extensions.Hosting.IHostEnvironment hostEnvironment,
            Infrastructure.Settings.ApplicationSettings applicationSettings) : base()
        {
            HostEnvironment = hostEnvironment;
            ApplicationSettings = applicationSettings;
        }
        #endregion /Constructor

        #region Public Property(ies)
        // **********
        [Microsoft.AspNetCore.Mvc.BindProperty]
        public ViewModels.Pages.Admin.CultureManagement.GetCultureItemDetailsViewModel ViewModel { get; private set; }
        // **********
        #endregion /Public Property(ies)


        #region Public Read Only Property(ies)
        // **********
        public string[] SupportedCultureEnabled { get; set; }
        // **********

        // **********
        public Microsoft.Extensions.Hosting.IHostEnvironment HostEnvironment { get; }
        // **********

        // **********
        public Infrastructure.Settings.ApplicationSettings ApplicationSettings { get; }
        // **********
        #endregion /Public Read Only Property(ies)

        #region OnGet
        public void OnGet()
        {
          
        }
        #endregion /OnGet

    }
}

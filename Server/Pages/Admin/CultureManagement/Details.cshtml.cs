using System.Linq;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace Server.Pages.Admin.CultureManagement
{
    [Microsoft.AspNetCore.Authorization.Authorize(Roles = "Admin")]
    public class DetailsModel : Infrastructure.BasePageModelWithDatabase
    {
        #region Constructor
        public DetailsModel
            (Microsoft.Extensions.Hosting.IHostEnvironment hostEnvironment,
            Persistence.DatabaseContext databaseContext,
            Microsoft.Extensions.Logging.ILogger<DetailsModel> logger,
            Infrastructure.Settings.ApplicationSettings applicationSettings) : base(databaseContext: databaseContext)
        {
            Logger = logger;
            ViewModel = new();
            HostEnvironment = hostEnvironment;
            ApplicationSettings = applicationSettings;
        }
        #endregion /Constructor

        #region Private Property(ies)
        // **********
        private Microsoft.Extensions.Logging.ILogger<DetailsModel> Logger { get; }
        // **********
        #endregion /Private Property(ies)

        #region Public Read Only Property(ies)
        // **********
        public Microsoft.Extensions.Hosting.IHostEnvironment HostEnvironment { get; }
        // **********

        // **********
        public Infrastructure.Settings.ApplicationSettings ApplicationSettings { get; }
        // **********
        #endregion /Public Read Only Property(ies)

        #region Public Property(ies)
        // **********
        [Microsoft.AspNetCore.Mvc.BindProperty]
        public ViewModels.Pages.Admin.CultureManagement.GetCultureItemDetailsViewModel ViewModel { get; private set; }
        // **********
        #endregion /Public Property(ies)

        #region OnGet
        public async
         System.Threading.Tasks.Task
         <Microsoft.AspNetCore.Mvc.IActionResult>
        OnGetAsync(System.Guid? id)
        {
            try
            {
                if (id == null)
                {
                    string errorMessage = string.Format
                        (Resources.Messages.Validations.Required,
                        Resources.DataDictionary.Id);

                    AddPageError(message: errorMessage);
                }
                else
                {
#pragma warning disable CS8601 // Possible null reference assignment.
                    ViewModel =
                        await DatabaseContext!.Cultures
                        .Where(current => current.Id == id.Value)
                        .Select(current => new ViewModels.Pages.Admin.CultureManagement.GetCultureItemDetailsViewModel
                        {
                            IsActive = current.IsActive,
                            IsDeleted = current.IsDeleted,
                            Description = current.Description,
                            InsertDateTime = current.InsertDateTime,
                            UpdateDateTime = current.UpdateDateTime,

                        }).FirstOrDefaultAsync();
#pragma warning restore CS8601 // Possible null reference assignment.
                }
            }
            catch (System.Exception ex)
            {
                Logger.LogError(message: ex.Message);

                AddPageError(message: Resources.Messages.Errors.UnexpectedError);
            }
            finally
            {
                await DisposeDatabaseContextAsync();
            }

            return Page();
        }
        #endregion /OnGet
    }
}

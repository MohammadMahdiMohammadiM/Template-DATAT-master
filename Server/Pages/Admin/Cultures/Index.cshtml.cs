using Domain;
using System.Linq;
using Infrastructure.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ViewModels.Pages.Admin.CultureManagement;

namespace Server.Pages.Admin.CultureManagement;

[Microsoft.AspNetCore.Authorization.Authorize
    (Roles = Constants.Role.Admin)]
public class IndexModel : Infrastructure.BasePageModelWithDatabaseContext
{
    public IndexModel
        (Data.DatabaseContext databaseContext,
        Microsoft.Extensions.Logging.ILogger<IndexModel> logger) :
        base(databaseContext: databaseContext)
    {
        Logger = logger;

        ViewModel =
            new System.Collections.Generic.List
            <ViewModels.Pages.Admin.CultureManagement.IndexItemViewModel>();
    }

    //**********
    public System.Collections.Generic.IList
        <ViewModels.Pages.Admin.CultureManagement.IndexItemViewModel> ViewModel
    { get; private set; }
    // **********

    // **********
    private Microsoft.Extensions.Logging.ILogger<IndexModel> Logger { get; }
    // **********

    public async System.Threading.Tasks.Task
        <Microsoft.AspNetCore.Mvc.IActionResult> OnGetAsync()
    {
        try
        {
            ViewModel =
                await
                DatabaseContext.Cultures
               .OrderBy(current => current.Ordering)
               .ThenBy(current => current.Name)
               .Select(current => new ViewModels.Pages.Admin.CultureManagement.IndexItemViewModel
               {
                   Id = current.Id,
                   Name = current.Name,
                   Flag = current.Flag,
                   Ordering = current.Ordering,
                   IsActive = current.IsActive,
                   IsDefault = current.IsDefault,
                   IsSystemic = current.IsSystemic,
                   InsertDateTime = current.InsertDateTime,
                   UpdateDateTime = current.UpdateDateTime,
               })
                .ToListAsync()
                ;

        }
        catch (System.Exception ex)
        {
            Logger.LogError
                (message: Constants.Logger.ErrorMessage, args: ex.Message);

            AddPageError
                (message: Resources.Messages.Errors.UnexpectedError);
        }
        finally
        {
            await DisposeDatabaseContextAsync();
        }

        return Page();
    }


}

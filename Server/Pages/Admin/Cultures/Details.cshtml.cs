using System.Linq;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace Server.Pages.Admin.CultureManagement;

[Microsoft.AspNetCore.Authorization
.Authorize(Roles = Constants.Role.Admin)]
public class DetailsModel : Infrastructure.BasePageModelWithDatabaseContext
{
    public DetailsModel
    (Data.DatabaseContext databaseContext,
    Microsoft.Extensions.Logging.ILogger<DetailsModel> logger) :
    base(databaseContext: databaseContext)
    {
        Logger = logger;

        ViewModel = new();
    }

    // **********
    private Microsoft.Extensions.Logging.ILogger<DetailsModel> Logger { get; }
    // **********

    // **********
    [Microsoft.AspNetCore.Mvc.BindProperty]
    public ViewModels.Pages.Admin.CultureManagement.DetailsVeiwModel? ViewModel
    { get; private set; }
    // **********

    public async System.Threading.Tasks.Task
    <Microsoft.AspNetCore.Mvc.IActionResult> OnGetAsync(System.Guid ? id)
    {
        try
        {
            if (id.HasValue == false)
            {
                AddToastError
                    (message: Resources.Messages.Errors.IdIsNull);

                return RedirectToPage(pageName: "Index");
            }


            ViewModel =
                await
                DatabaseContext.Cultures
                .Where(current => current.Id == id.Value)
                .Select(current => new ViewModels.Pages.Admin.CultureManagement.DetailsVeiwModel()
                {
                    Id = current.Id,
                    Name = current.Name,
                    Flag = current.Flag,
                    IsActive = current.IsActive,
                    IsDefault = current.IsDefault,
                    IsSystemic = current.IsSystemic,
                    IsDeletable = current.IsDeletable,
                    Description = current.Description,
                    InsertDateTime = current.InsertDateTime,
                    UpdateDateTime = current.UpdateDateTime,
                })
                .FirstOrDefaultAsync();

            if (ViewModel == null)
            {
                AddToastError
                    (message: Resources.Messages.Errors.ThereIsNotAnyDataWithThisId);

                return RedirectToPage(pageName: "Index");
            }

            return Page();
        }
        catch (System.Exception ex)
        {
            Logger.LogError
                (message: Constants.Logger.ErrorMessage, args: ex.Message);

            AddToastError
                (message: Resources.Messages.Errors.UnexpectedError);

            return RedirectToPage(pageName: "Index");
        }
        finally
        {
            await DisposeDatabaseContextAsync();
        }
    }
}

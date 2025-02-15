using Microsoft.AspNetCore.Components;
using MudBlazor;


namespace HotelManagementSystemUI.Features.Users.Profiles.Components;

public partial class DialogAdd
{
    [CascadingParameter]
    private MudDialogInstance MudDialog { get; set; }

    private void Submit() => MudDialog.Close(DialogResult.Ok(true));

    private void Cancel() => MudDialog.Cancel();
}

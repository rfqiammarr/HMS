using HotelManagementSystemUI.Features.Users.Profiles.Components;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace HotelManagementSystemUI.Features.Users.Profiles;
public partial class Index
{
    [Inject]
    private IDialogService DialogService { get; set; } = default!;

    private Task OpenDialogAsync()
    {
        var options = new DialogOptions { CloseOnEscapeKey = true };
        return DialogService.ShowAsync<DialogAdd>("Simple Dialog", options);
    }
}

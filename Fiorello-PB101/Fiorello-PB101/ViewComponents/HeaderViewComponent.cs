using Fiorello_PB101.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using NuGet.Configuration;

namespace Fiorello_PB101.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly ISettingService _settingsService;

        public HeaderViewComponent(ISettingService settingService)
        {
            _settingsService = settingService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult(View(await _settingsService.GetAllAsync()));
        }
    }
}

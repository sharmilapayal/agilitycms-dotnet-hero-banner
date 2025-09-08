using Agility.NET.FetchAPI.Models;
using Agility.NET.FetchAPI.Models.Data;
using Agility.NET.FetchAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Agility.NET.Starter.ViewComponents.PageModules
{
    public class HeroBanner : ViewComponent
    {
        private readonly FetchApiService _fetchApiService;

        public HeroBanner(FetchApiService fetchApiService)
        {
            _fetchApiService = fetchApiService;
        }
        public async Task<IViewComponentResult> InvokeAsync(ModuleModel moduleModel)
        {
            var heroBanner = await _fetchApiService.GetTypedContentItem<Agility.Models.HeroBanner>(new GetItemParameters
            {
                ContentId = moduleModel.Model.Item.ContentID,
                Locale = moduleModel.Locale,
                IsPreview = Util.Helpers.PreviewHelpers.IsPreviewMode(HttpContext)
            });
            return View("/Views/PageModules/HeroBanner.cshtml", heroBanner);

        }
     }
}

using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_BigDataOrdersDashboard.ViewComponents
{
    public class _LayoutPageLoaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}

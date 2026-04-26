using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_BigDataOrdersDashboard.ViewComponents
{
    public class _LayoutSearchComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}

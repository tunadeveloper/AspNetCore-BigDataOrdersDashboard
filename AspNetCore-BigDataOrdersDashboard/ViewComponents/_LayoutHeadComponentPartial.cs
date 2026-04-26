using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_BigDataOrdersDashboard.ViewComponents
{
    public class _LayoutHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}

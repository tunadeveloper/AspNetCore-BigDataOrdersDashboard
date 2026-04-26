using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_BigDataOrdersDashboard.ViewComponents
{
    public class _LayoutLeftSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}

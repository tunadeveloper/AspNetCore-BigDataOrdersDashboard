using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_BigDataOrdersDashboard.ViewComponents
{
    public class _LayoutRightSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}

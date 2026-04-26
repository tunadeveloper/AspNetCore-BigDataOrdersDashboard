using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_BigDataOrdersDashboard.ViewComponents
{
    public class _LayoutNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}

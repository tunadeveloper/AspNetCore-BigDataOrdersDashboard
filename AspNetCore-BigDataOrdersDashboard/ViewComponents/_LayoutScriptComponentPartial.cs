using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_BigDataOrdersDashboard.ViewComponents
{
    public class _LayoutScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}

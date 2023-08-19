
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.MemberDashboard
{
    public class _LastDestinations : ViewComponent
    {
        DestinationManager _destinationManager;

        public _LastDestinations(DestinationManager destinationManager)
        {
            _destinationManager = destinationManager;
        }

        public IViewComponentResult Invoke()
        {
            var values = _destinationManager.TGetLast4Destinations();

            return View();
        }
        
    }
}

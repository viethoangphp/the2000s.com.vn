using System.Web.Mvc;

namespace the2000s.com.vn.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            // Routing DashBoard
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index",Controller="Dashboard",id = UrlParameter.Optional }
            );
            //Routing Users
             context.MapRoute(
                "Users",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index",Controller="Users",id = UrlParameter.Optional }
            );
            context.MapRoute(
              "Users/create",
              "Admin/{controller}/{action}/{id}",
              new { action = "Create", Controller = "Users", id = UrlParameter.Optional }
          );
            context.MapRoute(
              "Users/delelte/{id}",
              "Admin/{controller}/{action}/{id}",
              new { action = "Delete", Controller = "Users", id = UrlParameter.Optional }
          );
            // Routing Page
            context.MapRoute(
              "Page",
              "Admin/{controller}/{action}/{id}",
              new { action = "Index", Controller = "Page", id = UrlParameter.Optional }
          );
            context.MapRoute(
              "Page/Add",
              "Admin/{controller}/{action}/{id}",
              new { action = "Add", Controller = "Page", id = UrlParameter.Optional }
          );
            // Routing Product 
            // Routing Order
        }
    }
}
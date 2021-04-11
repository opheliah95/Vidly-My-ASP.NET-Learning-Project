using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Text.RegularExpressions;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "MapMoviesByReleaseDate",
                url: "movies/released/{year}/{month}",
                // default route
                new
                {
                    controller = "Movie",
                    action = "ByReleaseDate",
                    id = UrlParameter.Optional
                },

                // constrains, i.e. year and month must match patterns
                new
                {
                    year = @"\d{4}",
                    month = @"\d{2}"
                }

           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );
        }
    }
}

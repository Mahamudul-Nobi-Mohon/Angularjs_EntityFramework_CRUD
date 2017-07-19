using System.Web;
using System.Web.Optimization;

namespace AngularCRUD_EntityFramework
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/JS").Include(
                      "~/Scripts/angular.min.js",
                      "~/Scripts/angular-route.js",
                      "~/Scripts/myangular/app.js",
                      "~/Scripts/myangular/controller.js",
                      "~/Content/vendor/jquery/jquery.min.js",
                      "~/Content/vendor/bootstrap/js/bootstrap.min.js",
                      "~/Content/vendor/metisMenu/metisMenu.min.js",
                      "~/Content/dist/js/sb-admin-2.js"));
                     
                       

            bundles.Add(new StyleBundle("~/Css").Include(
                      "~/Content/vendor/bootstrap/css/bootstrap.min.css",
                       "~/Content/vendor/metisMenu/metisMenu.min.css",
                      "~/Content/dist/css/sb-admin-2.css",
                      "~/Content/vendor/font-awesome/css/font-awesome.min.css"
                     ));
        }
    }
}

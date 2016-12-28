using System.Web;
using System.Web.Optimization;

namespace StudyAdmin___Mvc
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //Special thanks to Gentelella -Bootstrap Admin Template by
            bundles.Add(new ScriptBundle("~/bundles/AdminDashboard").Include(
                 "~/Dashboard Contents/vendors/jquery/dist/jquery.min.js",
                 "~/Dashboard Contents/vendors/bootstrap/dist/js/bootstrap.min.js",
                 "~/Dashboard Contents/vendors/fastclick/lib/fastclick.js",
                 "~/Dashboard Contents/vendors/nprogress/nprogress.js",
                 "~/Dashboard Contents/vendors/Chart.js/dist/Chart.min.js",
                 "~/Dashboard Contents/vendors/gauge.js/dist/gauge.min.js",
                 "~/Dashboard Contents/vendors/bootstrap-progressbar/bootstrap-progressbar.min.js",
                 "~/Dashboard Contents/vendors/iCheck/icheck.min.js",
                 "~/Dashboard Contents/vendors/skycons/skycons.js",
                 "~/Dashboard Contents/vendors/Flot/jquery.flot.js",
                 "~/Dashboard Contents/vendors/Flot/jquery.flot.pie.js",
                 "~/Dashboard Contents/vendors/Flot/jquery.flot.time.js",
                 "~/Dashboard Contents/vendors/Flot/jquery.flot.stack.js",
                 "~/Dashboard Contents/vendors/Flot/jquery.flot.resize.js",
                 "~/Dashboard Contents/vendors/flot.orderbars/js/jquery.flot.orderBars.js",
                 "~/Dashboard Contents/vendors/flot-spline/js/jquery.flot.spline.min.js",
                 "~/Dashboard Contents/vendors/flot.curvedlines/curvedLines.js",
                 "~/Dashboard Contents/vendors/DateJS/build/date.js",
                 "~/Dashboard Contents/vendors/jqvmap/dist/jquery.vmap.js",
                 "~/Dashboard Contents/vendors/jqvmap/dist/maps/jquery.vmap.world.js",
                 "~/Dashboard Contents/vendors/jqvmap/examples/js/jquery.vmap.sampledata.js",
                 "~/Dashboard Contents/vendors/moment/min/moment.min.js",
                 "~/Dashboard Contents/vendors/bootstrap-daterangepicker/daterangepicker.js",
                 "~/Dashboard Contents/build/js/custom.min.js"
                 ));

            bundles.Add(new StyleBundle("~/Content/AdminDashboard").Include(
                "~/Dashboard Contents/vendors/bootstrap/dist/css/bootstrap.min.css",
                "~/Dashboard Contents/vendors/font-awesome/css/font-awesome.min.css",
                "~/Dashboard Contents/vendors/nprogress/nprogress.css",
                "~/Dashboard Contents/vendors/iCheck/skins/flat/green.css",
                "~/Dashboard Contents/bootstrap-progressbar/css/bootstrap-progressbar-3.3.4.min.css",
                "~/Dashboard Contents/vendors/jqvmap/dist/jqvmap.min.css",
                "~/Dashboard Contents/vendors/bootstrap-daterangepicker/daterangepicker.css",
                "~/Dashboard Contents/build/css/custom.min.css"
                ));
        }
    }
}

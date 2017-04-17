using System.Web.Optimization;

namespace PAM.Presentation.MVC4
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = true;

            //bootstrap Styles
            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                        "~/Content/bootstrap/bootstrap.css",
                        "~/Content/bootstrap/bootstrap.min.css",
                        "~/Content/bootstrap/bootstrap-grid.css",
                        "~/Content/bootstrap/bootstrap-grid.min.css",
                        "~/Content/bootstrap/bootstrap-reboot.css",
                        "~/Content/bootstrap/bootstrap-reboot.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap/bootstrap.js",
                "~/Scripts/bootstrap/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery/bootstrap.js",
                "~/Scripts/jquery/jquery-3.2.1.min.js"));
        }
    }
}

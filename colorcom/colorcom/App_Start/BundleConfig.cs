using System.Web.Optimization;

namespace colorcom
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-{version}.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/Chart.min.js",
                      "~/Scripts/popper.min.js",
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/bundles/assets").Include(
                      "~/Scripts/dashboard.js",
                      "~/Scripts/main.js",
                      "~/Scripts/widget.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/chosen.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/style.css"));


            bundles.Add(new StyleBundle("~/Content/themify-icons").Include(
                      "~/Content/themify-icons/css/themify-icons.css"));
        }
    }
}

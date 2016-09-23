

using System.Web.Optimization;

namespace PersonalWeb.App_Start
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css")
                .Include("~/content/bootstrap.min.css",
                        "~/content/Site.css"));
            bundles.Add(new ScriptBundle("~/bundles/scripts")
                .Include("~/scripts/ai.0.22.19-build00125.min.js",
                        "~/scripts/bootstrap.min.js",
                        "~/scripts/jquery-{version}.min.js",
                        "~/scripts/GoogleAnalytics.js"));
            bundles.Add(new StyleBundle("~/Bootstrap/BootstrapCSS",
                "//maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css")
                .Include("~/content/bootstrap.css"));
            bundles.Add(new ScriptBundle("~/Bootstrap/scripts",
                "//maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js")
                .Include("~/scripts/bootstrap.js"));
        }
    }
}
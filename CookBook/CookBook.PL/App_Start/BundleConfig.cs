using System.Web.Optimization;

namespace CookBook.PL.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle(Links.Bundles.Styles.bootstrap).Include(
                "~/Content/bootstrap.min.css"));

            bundles.Add(new StyleBundle(Links.Bundles.Styles.theme).Include(
                "~/Content/_latin.css",
                "~/Content/latin-font.css",
                "~/Content/business-casual.min.css"));

            bundles.Add(new ScriptBundle(Links.Bundles.Scripts.jquery).Include(
                "~/Scripts/jquery.min.js",
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery-ui-1.12.1.min.js",
                "~/Scripts/jquery.sort.js", 
                "~/Scripts/jquery.validate*"));
        }
    }
}
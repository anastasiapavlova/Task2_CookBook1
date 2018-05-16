﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static partial class MVC
{
    public static CookBook.PL.Controllers.AuthorizationController Authorization = new CookBook.PL.Controllers.T4MVC_AuthorizationController();
    public static CookBook.PL.Controllers.HomeController Home = new CookBook.PL.Controllers.T4MVC_HomeController();
    public static CookBook.PL.Controllers.RecipeController Recipe = new CookBook.PL.Controllers.T4MVC_RecipeController();
    public static CookBook.PL.Controllers.UserControlController UserControl = new CookBook.PL.Controllers.T4MVC_UserControlController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC
{
}

#pragma warning disable 0436
namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}
#pragma warning restore 0436

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        public const string UrlPath = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
        public static readonly string bootstrap_bundle_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/bootstrap.bundle.min.js") ? Url("bootstrap.bundle.min.js") : Url("bootstrap.bundle.js");
        public static readonly string bootstrap_bundle_min_js = Url("bootstrap.bundle.min.js");
        public static readonly string bootstrap_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/bootstrap.min.js") ? Url("bootstrap.min.js") : Url("bootstrap.js");
        public static readonly string bootstrap_min_js = Url("bootstrap.min.js");
        public static readonly string jquery_2_1_3_intellisense_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery-2.1.3.intellisense.min.js") ? Url("jquery-2.1.3.intellisense.min.js") : Url("jquery-2.1.3.intellisense.js");
        public static readonly string jquery_3_3_1_intellisense_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery-3.3.1.intellisense.min.js") ? Url("jquery-3.3.1.intellisense.min.js") : Url("jquery-3.3.1.intellisense.js");
        public static readonly string jquery_3_3_1_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery-3.3.1.min.js") ? Url("jquery-3.3.1.min.js") : Url("jquery-3.3.1.js");
        public static readonly string jquery_3_3_1_min_js = Url("jquery-3.3.1.min.js");
        public static readonly string jquery_3_3_1_min_map = Url("jquery-3.3.1.min.map");
        public static readonly string jquery_3_3_1_slim_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery-3.3.1.slim.min.js") ? Url("jquery-3.3.1.slim.min.js") : Url("jquery-3.3.1.slim.js");
        public static readonly string jquery_3_3_1_slim_min_js = Url("jquery-3.3.1.slim.min.js");
        public static readonly string jquery_3_3_1_slim_min_map = Url("jquery-3.3.1.slim.min.map");
        public static readonly string jquery_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery.min.js") ? Url("jquery.min.js") : Url("jquery.js");
        public static readonly string jquery_min_js = Url("jquery.min.js");
        public static readonly string jquery_slim_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery.slim.min.js") ? Url("jquery.slim.min.js") : Url("jquery.slim.js");
        public static readonly string jquery_slim_min_js = Url("jquery.slim.min.js");
        public static readonly string jquery_validate_vsdoc_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery.validate-vsdoc.min.js") ? Url("jquery.validate-vsdoc.min.js") : Url("jquery.validate-vsdoc.js");
        public static readonly string jquery_validate_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery.validate.min.js") ? Url("jquery.validate.min.js") : Url("jquery.validate.js");
        public static readonly string jquery_validate_min_js = Url("jquery.validate.min.js");
        public static readonly string jquery_validate_unobtrusive_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/jquery.validate.unobtrusive.min.js") ? Url("jquery.validate.unobtrusive.min.js") : Url("jquery.validate.unobtrusive.js");
        public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        public const string UrlPath = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(UrlPath); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(UrlPath + "/" + fileName); }
        public static readonly string _about_scss = Url("_about.scss");
        public static readonly string _bootstrap_overrides_scss = Url("_bootstrap-overrides.scss");
        public static readonly string _buttons_scss = Url("_buttons.scss");
        public static readonly string _cta_scss = Url("_cta.scss");
        public static readonly string _footer_scss = Url("_footer.scss");
        public static readonly string _global_scss = Url("_global.scss");
        public static readonly string _intro_scss = Url("_intro.scss");
        public static readonly string _latin_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/_latin.min.css") ? Url("_latin.min.css") : Url("_latin.css");
        public static readonly string _mixins_scss = Url("_mixins.scss");
        public static readonly string _navbar_scss = Url("_navbar.scss");
        public static readonly string _products_scss = Url("_products.scss");
        public static readonly string _store_scss = Url("_store.scss");
        public static readonly string _variables_scss = Url("_variables.scss");
        public static readonly string bootstrap_theme_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/bootstrap-theme.min.css") ? Url("bootstrap-theme.min.css") : Url("bootstrap-theme.css");
        public static readonly string bootstrap_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/bootstrap.min.css") ? Url("bootstrap.min.css") : Url("bootstrap.css");
        public static readonly string bootstrap_css_map = Url("bootstrap.css.map");
        public static readonly string bootstrap_min_css = Url("bootstrap.min.css");
        public static readonly string bootstrap_min_css_map = Url("bootstrap.min.css.map");
        public static readonly string business_casual_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/business-casual.min.css") ? Url("business-casual.min.css") : Url("business-casual.css");
        public static readonly string business_casual_min_css = Url("business-casual.min.css");
        public static readonly string business_casual_scss = Url("business-casual.scss");
        public static readonly string latin_font_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(UrlPath + "/latin-font.min.css") ? Url("latin-font.min.css") : Url("latin-font.css");
    }

    
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
        public static partial class Scripts 
        {
            public static class Assets
            {
                public static readonly string bootstrap_bundle_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/bootstrap.bundle.js"); 
                public static readonly string bootstrap_bundle_min_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/bootstrap.bundle.min.js"); 
                public static readonly string bootstrap_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/bootstrap.js"); 
                public static readonly string bootstrap_min_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/bootstrap.min.js"); 
                public static readonly string jquery_2_1_3_intellisense_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery-2.1.3.intellisense.js"); 
                public static readonly string jquery_3_3_1_intellisense_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery-3.3.1.intellisense.js"); 
                public static readonly string jquery_3_3_1_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery-3.3.1.js"); 
                public static readonly string jquery_3_3_1_min_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery-3.3.1.min.js"); 
                public static readonly string jquery_3_3_1_slim_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery-3.3.1.slim.js"); 
                public static readonly string jquery_3_3_1_slim_min_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery-3.3.1.slim.min.js"); 
                public static readonly string jquery_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery.js"); 
                public static readonly string jquery_min_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery.min.js"); 
                public static readonly string jquery_slim_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery.slim.js"); 
                public static readonly string jquery_slim_min_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery.slim.min.js"); 
                public static readonly string jquery_validate_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery.validate.js"); 
                public static readonly string jquery_validate_min_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery.validate.min.js"); 
                public static readonly string jquery_validate_unobtrusive_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery.validate.unobtrusive.js"); 
                public static readonly string jquery_validate_unobtrusive_min_js = T4MVCHelpers.ProcessAssetPath("~/Scripts/jquery.validate.unobtrusive.min.js"); 
            }
        }
        public static partial class Content 
        {
            public static class Assets
            {
                public static readonly string _latin_css = T4MVCHelpers.ProcessAssetPath("~/Content/_latin.css");
                public static readonly string bootstrap_theme_css = T4MVCHelpers.ProcessAssetPath("~/Content/bootstrap-theme.css");
                public static readonly string bootstrap_css = T4MVCHelpers.ProcessAssetPath("~/Content/bootstrap.css");
                public static readonly string bootstrap_min_css = T4MVCHelpers.ProcessAssetPath("~/Content/bootstrap.min.css");
                public static readonly string business_casual_css = T4MVCHelpers.ProcessAssetPath("~/Content/business-casual.css");
                public static readonly string business_casual_min_css = T4MVCHelpers.ProcessAssetPath("~/Content/business-casual.min.css");
                public static readonly string latin_font_css = T4MVCHelpers.ProcessAssetPath("~/Content/latin-font.css");
            }
        }
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    private static string ProcessAssetPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and should retain this prefix
        return virtualPath;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;
    public static Func<string, string> ProcessAssetPath = ProcessAssetPathDefault;

    // Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;

    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114



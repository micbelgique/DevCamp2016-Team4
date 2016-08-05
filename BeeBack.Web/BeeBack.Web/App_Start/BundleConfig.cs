﻿using System.Web;
using System.Web.Optimization;

namespace BeeBack.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/js/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/toastr").Include(
                        "~/js/toastr.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                        "~/js/app/beeback.js",
                        "~/js/app/beeback_pattern.js",
                        "~/js/app/beeback_api.js",
                        "~/js/app/beeback.activities.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/js/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/js/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/js/bootstrap.js",
                      "~/js/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/css/bootstrap.css",
                      "~/css/site.css",
                      "~/css/beeback.css"));
        }
    }
}

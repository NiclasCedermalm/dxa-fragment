using Sdl.Web.Mvc.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SDL.DXA.Modules.Fragment
{
    public static class UrlHelperExtensions
    {
        /// <summary>
        /// Gets an absolute versioned URL (including the version number of the HTML design/assets).
        /// </summary>
        /// <param name="helper">The <see cref="UrlHelper"/> instance on which this extension method operates.</param>
        /// <param name="relativePath">The (unversioned) URL path relative to the system folder.</param>
        /// <param name="localization">Not used (deprecated).</param>
        /// <returns>A versioned URL path (server-relative).</returns>
        /// <remarks>
        /// Versioned URLs are used to facilitate agressive caching of those assets; see <see cref="Sdl.Web.Mvc.Statics.StaticContentModule"/>.
        /// </remarks>
        public static string AbsoluteVersionedContent(this UrlHelper helper, string relativePath, string localization = "")
        {
            string versionedUrlPath = WebRequestContext.Localization.GetVersionedUrlPath(relativePath);
            // Build a URI for the requested path
            var url = new Uri(HttpContext.Current.Request.Url, helper.Content(versionedUrlPath));
            // Return the absolute UrI
            return url.AbsoluteUri;
        }
    }
}
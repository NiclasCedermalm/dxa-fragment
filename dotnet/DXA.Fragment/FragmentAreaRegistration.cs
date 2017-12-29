using Sdl.Web.Common.Models;
using Sdl.Web.Mvc.Configuration;

namespace SDL.DXA.Modules.Fragment
{
    /// <summary>
    /// Fragment Area Registration
    /// </summary>
    public class FragmentAreaRegistration : BaseAreaRegistration
    {

        public override string AreaName
        {
            get
            {
                return "Fragment";
            }
        }

        protected override void RegisterAllViewModels()
        {
            // Page Views
            //
            RegisterViewModel("FragmentPage", typeof(PageModel));
            RegisterViewModel("CleanFragmentPage", typeof(PageModel));

        }

    }
}
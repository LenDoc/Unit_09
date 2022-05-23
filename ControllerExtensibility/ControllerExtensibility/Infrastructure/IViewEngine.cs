namespace System.Web.Mvc
{
    public interface IViewEngine
    {
        ViewEngineResult FindPartialView(ControllerContext ControllerContext,
            string partialViewName, bool useCache);
        ViewEngineResult FindView(ControllerContext ControllerContext,
            string viewName, string masterName, bool useCache);
        void ReleaseView(ControllerContext ControllerContext, IView view);
    }
}
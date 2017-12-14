using Abp.Web.Mvc.Views;

namespace CardCloud.Web.Views
{
    public abstract class CardCloudWebViewPageBase : CardCloudWebViewPageBase<dynamic>
    {

    }

    public abstract class CardCloudWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected CardCloudWebViewPageBase()
        {
            LocalizationSourceName = CardCloudConsts.LocalizationSourceName;
        }
    }
}
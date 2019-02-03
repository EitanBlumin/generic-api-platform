using Serenity.Navigation;
using MyPages = Serene.GenericAPIPlatform.Pages;

[assembly: NavigationLink(int.MaxValue, "GenericAPIPlatform/Api Fields", typeof(MyPages.ApiFieldsController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "GenericAPIPlatform/Api Headers", typeof(MyPages.ApiHeadersController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "GenericAPIPlatform/Api Target", typeof(MyPages.ApiTargetController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "GenericAPIPlatform/Api Target Field Values", typeof(MyPages.ApiTargetFieldValuesController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "GenericAPIPlatform/Api Type", typeof(MyPages.ApiTypeController), icon: null)]
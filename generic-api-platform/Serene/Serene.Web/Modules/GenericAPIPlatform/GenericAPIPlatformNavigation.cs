using Serenity.Navigation;
using MyPages = Serene.GenericAPIPlatform.Pages;

[assembly: NavigationLink(int.MaxValue, "Generic API/API Types", typeof(MyPages.ApiTypeController), icon: "fa-globe")]
[assembly: NavigationLink(int.MaxValue, "Generic API/API Headers", typeof(MyPages.ApiHeadersController), icon: "fa-header")]
[assembly: NavigationLink(int.MaxValue, "Generic API/API Fields", typeof(MyPages.ApiFieldsController), icon: "fa-file-text")]
[assembly: NavigationLink(int.MaxValue, "Generic API/API Targets", typeof(MyPages.ApiTargetController), icon: "fa-bullseye")]
[assembly: NavigationLink(int.MaxValue, "Generic API/API Target Field Values", typeof(MyPages.ApiTargetFieldValuesController), icon: "fa-sign-in")]

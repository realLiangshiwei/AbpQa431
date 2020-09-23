using Qa431.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Qa431.Permissions
{
    public class Qa431PermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(Qa431Permissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(Qa431Permissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<Qa431Resource>(name);
        }
    }
}

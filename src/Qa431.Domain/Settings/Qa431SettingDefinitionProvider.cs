using Volo.Abp.Settings;

namespace Qa431.Settings
{
    public class Qa431SettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(Qa431Settings.MySetting1));
        }
    }
}

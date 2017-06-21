using LiveSplit.Model;
using System;

namespace LiveSplit.UI.Components
{
    public class SplitsComponentFactory : IComponentFactory
    {
        public string ComponentName => "Detailed Splits";

        public string Description => "Displays splits as a normal splits component, but displays the current split in more detail.";

        public ComponentCategory Category => ComponentCategory.List;

        public IComponent Create(LiveSplitState state) => new SplitsComponent(state);

        public string UpdateName => ComponentName;

        public string XMLURL => "http://livesplit.org/update/Components/update.LiveSplit.DetailedSplits.xml";

        public string UpdateURL => "http://livesplit.org/update/";

        public Version Version => Version.Parse("1.7.3");
    }
}

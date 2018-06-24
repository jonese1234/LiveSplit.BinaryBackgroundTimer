using LiveSplit.Model;
using System;

namespace LiveSplit.UI.Components
{
    public class BinaryBackgroundTimerFactory : IComponentFactory
    {
        public string ComponentName => "Binary Background Timer";

        public string Description => "Displays the current run time. With a binary Background";

        public ComponentCategory Category => ComponentCategory.Timer;

        public IComponent Create(LiveSplitState state) => new BinaryBackgroundTimer();

        public string UpdateName => ComponentName;

        public string XMLURL => "";

        public string UpdateURL => "";

        public Version Version => Version.Parse("1.7.5");
    }
}

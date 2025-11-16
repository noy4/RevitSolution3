using Nice3point.Revit.Toolkit.External;
using RevitAddInWindow.Commands;

namespace RevitAddInWindow
{
    /// <summary>
    ///     Application entry point
    /// </summary>
    [UsedImplicitly]
    public class Application : ExternalApplication
    {
        public override void OnStartup()
        {
            CreateRibbon();
        }

        private void CreateRibbon()
        {
            var panel = Application.CreatePanel("Commands", "RevitAddInWindow");

            panel.AddPushButton<StartupCommand>("Execute")
                .SetImage("/RevitAddInWindow;component/Resources/Icons/RibbonIcon16.png")
                .SetLargeImage("/RevitAddInWindow;component/Resources/Icons/RibbonIcon32.png");
        }
    }
}
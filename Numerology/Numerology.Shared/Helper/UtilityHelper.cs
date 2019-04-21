using System;
using System.Collections.Generic;
using System.Text;
using Windows.System;
using Windows.UI.Popups;
using Windows.UI.Xaml;

namespace Numerology.Helper
{
    public class UtilityHelper
    {
        public async void ExitMe()
        {
            MessageDialog msg = new MessageDialog("Are you sure, you want to exit this apps?", "Exit!");

            msg.Commands.Add(new UICommand("Yes", new UICommandInvokedHandler(CommandHandlers)));
            msg.Commands.Add(new UICommand("No", new UICommandInvokedHandler(CommandHandlers)));

            await msg.ShowAsync();
        }

        public void CommandHandlers(IUICommand commandLabel)
        {
            var Actions = commandLabel.Label;
            switch (Actions)
            {
                case "Yes":
                    Application.Current.Exit();
                    break;
                case "No":
                    break;
            }
        }

        public async void AppsRating()
        {
            try
            {
                //Windows.ApplicationModel.Package.Current.Id.Name
                await Launcher.LaunchUriAsync(new Uri("ms-windows-store:reviewapp?appid=" + "15a67135-1533-42ae-a730-762126fc696b"));
            }
            catch (Exception ex)
            {
                MessageDialog msg = new MessageDialog(ex.Message, "Opps!");
                //await msg.ShowAsync();
            }
        }
    }
}

using System.Collections.Generic;

namespace K_MoodleNotifier.Interfaces
{
    public interface ILocalNotificationsService
    {
        void ShowNotification(string title, string message, IDictionary<string, string> data);
    }
}

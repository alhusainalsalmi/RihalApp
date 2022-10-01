using Radzen;

namespace RihalApp.Notifier
{
    internal sealed class AppNotifier
    {
        private readonly NotificationService _notificationService;

        public AppNotifier(NotificationService notificationService)
        {
            _notificationService = notificationService ?? throw new ArgumentNullException(nameof(notificationService));
        }

        public void NotifyError(string Message = "Unexpected Error Occured")
        {
            _notificationService.Notify(new NotificationMessage { Severity = NotificationSeverity.Error, Summary = "Error Summary", Detail = Message, Duration = 6000 });
        }
        public void NotifyWarning(string Message )
        {
            _notificationService.Notify(new NotificationMessage { Severity = NotificationSeverity.Warning, Summary = "Warning Summary", Detail = Message, Duration = 6000 });
        }
        public void NotifySuccess(string Message )
        {
            _notificationService.Notify(new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Success Summary", Detail = Message, Duration = 4000 });
        }
    }
}

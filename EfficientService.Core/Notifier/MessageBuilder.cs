using EfficientService.Core.Entities;

namespace EfficientService.Core.Notification
{
    public static class MessageBuilder
    {       
        public static string IncidentAdded(User user, Incident inc)
        {
            return string.Format(Resources.IncidentAddedMsg, 
                user.FullName, 
                inc.Title, 
                inc.Description, 
                inc.StartTime, 
                inc.Priority);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class SystemNotification : Notification
    {
        public SystemNotification(Guid systemId) : base("System")
        {
            SystemId = systemId;
        }

        public Guid SystemId { get; set; }

        public void AddMessage(string message)
        {
            Message = message;
        }
    }
}

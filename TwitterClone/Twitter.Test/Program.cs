using TwitterClone.Domain.Entities;

var notification = new Notification("Comment");

var message = notification.GetMessage();

Console.WriteLine(message);

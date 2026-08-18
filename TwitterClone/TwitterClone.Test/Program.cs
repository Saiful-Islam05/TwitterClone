using TwitterClone.Domain.Entities;

var likeNotification = new LikeNotification(Guid.NewGuid());
Console.WriteLine(likeNotification.GetMessage());

var commentNotification = new CommentNotification(Guid.NewGuid());
Console.WriteLine(commentNotification.GetMessage());

var friendRequestNotification = new FriendRequestNotification(Guid.NewGuid());
Console.WriteLine(friendRequestNotification.GetMessage());

var mentionNotification = new MentionNotification(Guid.NewGuid());
Console.WriteLine(mentionNotification.GetMessage());


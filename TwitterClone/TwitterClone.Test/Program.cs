using TwitterClone.Domain.Entities;

LikeNotification likeNotification = new LikeNotification(Guid.NewGuid());

Console.WriteLine(likeNotification.DescribeRecord());
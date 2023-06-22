namespace PIC_SocialApp.Domain.Assembly.PostAssembly
{
    public class PostComment
    {
        public PostComment() { }
        
        public Guid CommentId { get; private set; }
        public Guid PostId { get; private set; }
        public Guid UserProfileId { get; private set; }
        public string Text { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime LastUpdated { get; private set; }

        // Factories
        public static PostComment CreatePostComment(Guid postId, Guid userProfileId, string text)
        {
            // TO DO: add validation

            return new PostComment
            {
                PostId = postId,
                UserProfileId= userProfileId,
                Text = text,
                CreatedAt = DateTime.Now,
                LastUpdated = DateTime.Now
            };
        }

        // Public Method
        public void UpdateCommentText(string newText)
        {
            Text = newText;
            LastUpdated = DateTime.Now;
        }

    }
}

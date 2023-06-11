using PIC_SocialApp.Domain.Assembly.UserProfileAssembly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PIC_SocialApp.Domain.Assembly.PostAssembly
{
    public class Post
    {
        private readonly List<PostComment> _comment = new List<PostComment>();
        private readonly List<PostInteraction> _interaction = new List<PostInteraction>();

        private Post() { }
        
        public Guid PostId { get; private set; }
        public Guid UserProfileId { get; private set; }
        public string TextContent { get; private set; }
        public UserProfile UserProfile { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime LastUpdated { get; private set; }
        public IEnumerable<PostComment> Comments { get { return _comment; } }
        public IEnumerable<PostInteraction> Interactions { get { return _interaction; } }

        // Factories
        public static Post CreatePost(Guid userProfileId, string textContent)
        {
            return new Post
            {
                PostId = userProfileId,
                TextContent = textContent,
                CreatedAt = DateTime.UtcNow,
                LastUpdated = DateTime.UtcNow,
            };
        }

        // Public Methods
        public void UpdatePostText(string newText)
        {
            TextContent= newText;
            LastUpdated= DateTime.UtcNow;
        }

        public void AddPostComment(PostComment newComment)
        {
            _comment.Add(newComment);
        }

        public void RemoveComment(PostComment delete)
        {
            _comment.Remove(delete);
        }

        public void AddInteraction(PostInteraction newInteraction)
        {
            _interaction.Add(newInteraction);
        }

        public void RemoveInteraction(PostInteraction delete)
        {
            _interaction.Remove(delete);
        }
    }
}

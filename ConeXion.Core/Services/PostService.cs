using ConeXion.Core.Contracts;
using ConeXion.Core.Models.Like;
using ConeXion.Core.Models.Post;
using ConeXion.Infrastructure.Data;
using ConeXion.Infrastructure.Data.Common;
using ConeXion.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace ConeXion.Core.Services
{
    public class PostService : IPostService
    {

        private readonly IRepository repo;
        private readonly IUserService userSerivce;
        private readonly ApplicationDbContext context;

        public PostService(IRepository _repo,
                           IUserService _userService,
                           ApplicationDbContext _context)
        {
            repo = _repo;
            userSerivce = _userService;
            context = _context;
        }

        [Description("Creates a new post and adds it to the database.")]
        public async Task AddPostAsync(AddPostViewModel model)
        {
            var entity = new Post()
            {
                TextContent = model.TextContent,
                ImageData = model.ImageData,
                UserID = model.UserID
            };

            await repo.AddAsync(entity);
            await repo.SaveChangesAsync();

        }

        public void DislikePostAsync(string userId, int postId)
        {
            Like likeToRemove = repo.All<Like>()
                .FirstOrDefault(x => x.UserID == userId && x.PostID == postId);

            context.Likes.Remove(likeToRemove);          
            context.SaveChanges();
        }



        [Description("Returns all posts.")]
        public async Task<IEnumerable<PostViewModel>> GetAllAsync(string userId)
        {
            return await repo.AllReadonly<Post>()
                .Select(h => new PostViewModel()
                {
                    Id = h.Id,
                    TextContent = h.TextContent,
                    ImageData = h.ImageData,
                    UserID = h.UserID,
                    UserLikes = h.UserLikes
                })
                .Where(x => x.UserID != userId)
                .ToListAsync();
        }


        [Description("Returns all posts made by a given user.")]
        public async Task<IEnumerable<PostViewModel>> GetUsersPostsAsync(string userId)
        {
            return await repo.AllReadonly<Post>()
                .Select(h => new PostViewModel()
                {
                    Id = h.Id,
                    TextContent = h.TextContent,
                    ImageData = h.ImageData,
                    UserID = h.UserID
                })
                .Where(x => x.UserID == userId)
            .ToListAsync();
        }

        public async Task LikePostAsync(NewLikeViewModel model)
        {
            var entity = new Like()
            {
                PostID = model.PostID,
                UserID = model.UserID
            };


            var allLikes = repo.AllReadonly<Like>();

            if (!allLikes.Any(x => x.UserID == model.UserID && x.PostID==model.PostID))
            {
                await repo.AddAsync(entity);
                await repo.SaveChangesAsync();
            }
        }
    }
}
using ConeXion.Core.Models.Like;
using ConeXion.Core.Models.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConeXion.Core.Contracts
{
    public interface IPostService
    {
        Task AddPostAsync(AddPostViewModel model);
        Task<IEnumerable<PostViewModel>> GetAllAsync(string userId);
        Task<IEnumerable<PostViewModel>> GetUsersPostsAsync(string userId);

        Task LikePostAsync(NewLikeViewModel model);

    }
}

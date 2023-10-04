using ConeXion.Core.Contracts;
using ConeXion.Core.Models.Post;
using ConeXion.Infrastructure.Data.Common;
using ConeXion.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ConeXion.Core.Services
{
    public class PostService : IPostService
    {

        private readonly IRepository repo;
        private readonly IUserService userSerivce;

        public PostService(IRepository _repo,
                           IUserService _userService)
        {
            repo = _repo;
            userSerivce = _userService;
        }

        [Description("Creates a new post and adds it to the database.")]
        public async Task AddPostAsync(AddPostViewModel model)
        {

            var entity = new Post()
            {
                TextContent = model.TextContent,
                ImageData = model.ImageData,
                UserID=model.UserID
            };

            await repo.AddAsync(entity);
            await repo.SaveChangesAsync();

        }
    }
}

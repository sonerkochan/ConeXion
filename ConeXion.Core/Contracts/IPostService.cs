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
    }
}

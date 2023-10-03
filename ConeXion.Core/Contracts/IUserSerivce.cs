using ConeXion.Core.Models.User;
using ConeXion.Infrastructure.Data.Models;
using ConeXion.Core.Models.User;
using ConeXion.Infrastructure.Data.Models;

namespace ConeXion.Core.Contracts
{
    /// <summary>
    /// The interface for the UserService.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Returns the user by given username.
        /// </summary>
        /// <param name="username">Username of the user.</param>
        /// <returns>Returns a User object.</returns>
        User GetUserByUsername(string username);

        /// <summary>
        /// Returns the name of a user by their Id.
        /// </summary>
        /// <param name="userId">User's Id.</param>
        /// <returns>String that is the username of a given user.</returns>
        public string GetUserNameById(string userId);

        /// <summary>
        /// Returns a list of all users that are registered on the website.
        /// </summary>
        /// <returns>IEnumerable of user data transfer objects.</returns>

        Task<IEnumerable<UserServiceModel>> All();


        /// <summary>
        /// Deletes the account of a given user by given Id.
        /// </summary>
        /// <param name="userId">User's Id.</param>
        /// <returns>A flag indicating whether the operation was successful.</returns>
        Task<bool> Forget(string userId);

    }
}
﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using ZtherApiIntegration.API;
using ZtherApiIntegration.API.Models;

namespace ZtherApiIntegration.API
{
    public static partial class EmailFavoritesExtensions
    {
        /// <param name='operations'>
        /// Reference to the ZtherApiIntegration.API.IEmailFavorites.
        /// </param>
        /// <param name='brand'>
        /// Required.
        /// </param>
        /// <param name='model'>
        /// Required.
        /// </param>
        public static string Create(this IEmailFavorites operations, string brand, EmailFavorite model)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IEmailFavorites)s).CreateAsync(brand, model);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the ZtherApiIntegration.API.IEmailFavorites.
        /// </param>
        /// <param name='brand'>
        /// Required.
        /// </param>
        /// <param name='model'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<string> CreateAsync(this IEmailFavorites operations, string brand, EmailFavorite model, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<string> result = await operations.CreateWithOperationResponseAsync(brand, model, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the ZtherApiIntegration.API.IEmailFavorites.
        /// </param>
        /// <param name='brand'>
        /// Required.
        /// </param>
        public static EmailFavoriteList GetAllEmailFavorite(this IEmailFavorites operations, string brand)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IEmailFavorites)s).GetAllEmailFavoriteAsync(brand);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the ZtherApiIntegration.API.IEmailFavorites.
        /// </param>
        /// <param name='brand'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<EmailFavoriteList> GetAllEmailFavoriteAsync(this IEmailFavorites operations, string brand, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<ZtherApiIntegration.API.Models.EmailFavoriteList> result = await operations.GetAllEmailFavoriteWithOperationResponseAsync(brand, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the ZtherApiIntegration.API.IEmailFavorites.
        /// </param>
        /// <param name='brand'>
        /// Required.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static EmailFavorite GetEmailFavoriteById(this IEmailFavorites operations, string brand, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IEmailFavorites)s).GetEmailFavoriteByIdAsync(brand, id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the ZtherApiIntegration.API.IEmailFavorites.
        /// </param>
        /// <param name='brand'>
        /// Required.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<EmailFavorite> GetEmailFavoriteByIdAsync(this IEmailFavorites operations, string brand, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<ZtherApiIntegration.API.Models.EmailFavorite> result = await operations.GetEmailFavoriteByIdWithOperationResponseAsync(brand, id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the ZtherApiIntegration.API.IEmailFavorites.
        /// </param>
        /// <param name='brand'>
        /// Required.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static string RemoveEmailFavorite(this IEmailFavorites operations, string brand, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IEmailFavorites)s).RemoveEmailFavoriteAsync(brand, id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the ZtherApiIntegration.API.IEmailFavorites.
        /// </param>
        /// <param name='brand'>
        /// Required.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<string> RemoveEmailFavoriteAsync(this IEmailFavorites operations, string brand, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<string> result = await operations.RemoveEmailFavoriteWithOperationResponseAsync(brand, id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}

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
    public static partial class StatesExtensions
    {
        /// <param name='operations'>
        /// Reference to the ZtherApiIntegration.API.IStates.
        /// </param>
        public static StateList GetAll(this IStates operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IStates)s).GetAllAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the ZtherApiIntegration.API.IStates.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<StateList> GetAllAsync(this IStates operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<ZtherApiIntegration.API.Models.StateList> result = await operations.GetAllWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the ZtherApiIntegration.API.IStates.
        /// </param>
        /// <param name='code'>
        /// Required.
        /// </param>
        public static State GetByStateAbrrev(this IStates operations, string code)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IStates)s).GetByStateAbrrevAsync(code);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the ZtherApiIntegration.API.IStates.
        /// </param>
        /// <param name='code'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<State> GetByStateAbrrevAsync(this IStates operations, string code, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<ZtherApiIntegration.API.Models.State> result = await operations.GetByStateAbrrevWithOperationResponseAsync(code, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}

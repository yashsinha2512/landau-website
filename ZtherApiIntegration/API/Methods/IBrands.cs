﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using ZtherApiIntegration.API.Models;

namespace ZtherApiIntegration.API
{
    public partial interface IBrands
    {
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<BrandList>> GetAllBrandAsyncWithOperationResponseAsync(CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <param name='code'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<Brand>> GetBrandByCodeAsyncWithOperationResponseAsync(string code, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}

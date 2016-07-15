﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using Newtonsoft.Json.Linq;
using ZtherApiIntegration.API;
using ZtherApiIntegration.API.Models;

namespace ZtherApiIntegration.API
{
    internal partial class Banners : IServiceOperations<LandauPortalWebAPI>, IBanners
    {
        /// <summary>
        /// Initializes a new instance of the Banners class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal Banners(LandauPortalWebAPI client)
        {
            this._client = client;
        }
        
        private LandauPortalWebAPI _client;
        
        /// <summary>
        /// Gets a reference to the
        /// ZtherApiIntegration.API.LandauPortalWebAPI.
        /// </summary>
        public LandauPortalWebAPI Client
        {
            get { return this._client; }
        }
        
        /// <param name='brand'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public async Task<HttpOperationResponse<TileList>> GetAllPrintBannerByBrandAsyncWithOperationResponseAsync(string brand, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // Validate
            if (brand == null)
            {
                throw new ArgumentNullException("brand");
            }
            
            // Tracing
            bool shouldTrace = ServiceClientTracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("brand", brand);
                ServiceClientTracing.Enter(invocationId, this, "GetAllPrintBannerByBrandAsyncAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/banners/";
            url = url + Uri.EscapeDataString(brand);
            url = url + "/prints";
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = new HttpRequestMessage();
            httpRequest.Method = HttpMethod.Get;
            httpRequest.RequestUri = new Uri(url);
            
            // Set Credentials
            if (this.Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            }
            
            // Send Request
            if (shouldTrace)
            {
                ServiceClientTracing.SendRequest(invocationId, httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            HttpResponseMessage httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            if (shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(invocationId, httpResponse);
            }
            HttpStatusCode statusCode = httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (statusCode != HttpStatusCode.OK)
            {
                HttpOperationException<object> ex = new HttpOperationException<object>();
                ex.Request = httpRequest;
                ex.Response = httpResponse;
                ex.Body = null;
                if (shouldTrace)
                {
                    ServiceClientTracing.Error(invocationId, ex);
                }
                throw ex;
            }
            
            // Create Result
            HttpOperationResponse<TileList> result = new HttpOperationResponse<TileList>();
            result.Request = httpRequest;
            result.Response = httpResponse;
            
            // Deserialize Response
            if (statusCode == HttpStatusCode.OK)
            {
                TileList resultModel = new TileList();
                JToken responseDoc = null;
                if (string.IsNullOrEmpty(responseContent) == false)
                {
                    responseDoc = JToken.Parse(responseContent);
                }
                if (responseDoc != null)
                {
                    resultModel.DeserializeJson(responseDoc);
                }
                result.Body = resultModel;
            }
            
            if (shouldTrace)
            {
                ServiceClientTracing.Exit(invocationId, result);
            }
            return result;
        }
        
        /// <param name='brand'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public async Task<HttpOperationResponse<SeasonalList>> GetAllSeasonalByBrandAsyncWithOperationResponseAsync(string brand, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // Validate
            if (brand == null)
            {
                throw new ArgumentNullException("brand");
            }
            
            // Tracing
            bool shouldTrace = ServiceClientTracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("brand", brand);
                ServiceClientTracing.Enter(invocationId, this, "GetAllSeasonalByBrandAsyncAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/banners/";
            url = url + Uri.EscapeDataString(brand);
            url = url + "/seasonal";
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = new HttpRequestMessage();
            httpRequest.Method = HttpMethod.Get;
            httpRequest.RequestUri = new Uri(url);
            
            // Set Credentials
            if (this.Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            }
            
            // Send Request
            if (shouldTrace)
            {
                ServiceClientTracing.SendRequest(invocationId, httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            HttpResponseMessage httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            if (shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(invocationId, httpResponse);
            }
            HttpStatusCode statusCode = httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (statusCode != HttpStatusCode.OK)
            {
                HttpOperationException<object> ex = new HttpOperationException<object>();
                ex.Request = httpRequest;
                ex.Response = httpResponse;
                ex.Body = null;
                if (shouldTrace)
                {
                    ServiceClientTracing.Error(invocationId, ex);
                }
                throw ex;
            }
            
            // Create Result
            HttpOperationResponse<SeasonalList> result = new HttpOperationResponse<SeasonalList>();
            result.Request = httpRequest;
            result.Response = httpResponse;
            
            // Deserialize Response
            if (statusCode == HttpStatusCode.OK)
            {
                SeasonalList resultModel = new SeasonalList();
                JToken responseDoc = null;
                if (string.IsNullOrEmpty(responseContent) == false)
                {
                    responseDoc = JToken.Parse(responseContent);
                }
                if (responseDoc != null)
                {
                    resultModel.DeserializeJson(responseDoc);
                }
                result.Body = resultModel;
            }
            
            if (shouldTrace)
            {
                ServiceClientTracing.Exit(invocationId, result);
            }
            return result;
        }
        
        /// <param name='brand'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public async Task<HttpOperationResponse<SliderList>> GetAllSliderByBrandAsyncWithOperationResponseAsync(string brand, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // Validate
            if (brand == null)
            {
                throw new ArgumentNullException("brand");
            }
            
            // Tracing
            bool shouldTrace = ServiceClientTracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("brand", brand);
                ServiceClientTracing.Enter(invocationId, this, "GetAllSliderByBrandAsyncAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/banners/";
            url = url + Uri.EscapeDataString(brand);
            url = url + "/sliders";
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = new HttpRequestMessage();
            httpRequest.Method = HttpMethod.Get;
            httpRequest.RequestUri = new Uri(url);
            
            // Set Credentials
            if (this.Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            }
            
            // Send Request
            if (shouldTrace)
            {
                ServiceClientTracing.SendRequest(invocationId, httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            HttpResponseMessage httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            if (shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(invocationId, httpResponse);
            }
            HttpStatusCode statusCode = httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (statusCode != HttpStatusCode.OK)
            {
                HttpOperationException<object> ex = new HttpOperationException<object>();
                ex.Request = httpRequest;
                ex.Response = httpResponse;
                ex.Body = null;
                if (shouldTrace)
                {
                    ServiceClientTracing.Error(invocationId, ex);
                }
                throw ex;
            }
            
            // Create Result
            HttpOperationResponse<SliderList> result = new HttpOperationResponse<SliderList>();
            result.Request = httpRequest;
            result.Response = httpResponse;
            
            // Deserialize Response
            if (statusCode == HttpStatusCode.OK)
            {
                SliderList resultModel = new SliderList();
                JToken responseDoc = null;
                if (string.IsNullOrEmpty(responseContent) == false)
                {
                    responseDoc = JToken.Parse(responseContent);
                }
                if (responseDoc != null)
                {
                    resultModel.DeserializeJson(responseDoc);
                }
                result.Body = resultModel;
            }
            
            if (shouldTrace)
            {
                ServiceClientTracing.Exit(invocationId, result);
            }
            return result;
        }
        
        /// <param name='brand'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public async Task<HttpOperationResponse<TileList>> GetAllTileByBrandAsyncWithOperationResponseAsync(string brand, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // Validate
            if (brand == null)
            {
                throw new ArgumentNullException("brand");
            }
            
            // Tracing
            bool shouldTrace = ServiceClientTracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("brand", brand);
                ServiceClientTracing.Enter(invocationId, this, "GetAllTileByBrandAsyncAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/banners/";
            url = url + Uri.EscapeDataString(brand);
            url = url + "/tiles";
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = new HttpRequestMessage();
            httpRequest.Method = HttpMethod.Get;
            httpRequest.RequestUri = new Uri(url);
            
            // Set Credentials
            if (this.Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            }
            
            // Send Request
            if (shouldTrace)
            {
                ServiceClientTracing.SendRequest(invocationId, httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            HttpResponseMessage httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            if (shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(invocationId, httpResponse);
            }
            HttpStatusCode statusCode = httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (statusCode != HttpStatusCode.OK)
            {
                HttpOperationException<object> ex = new HttpOperationException<object>();
                ex.Request = httpRequest;
                ex.Response = httpResponse;
                ex.Body = null;
                if (shouldTrace)
                {
                    ServiceClientTracing.Error(invocationId, ex);
                }
                throw ex;
            }
            
            // Create Result
            HttpOperationResponse<TileList> result = new HttpOperationResponse<TileList>();
            result.Request = httpRequest;
            result.Response = httpResponse;
            
            // Deserialize Response
            if (statusCode == HttpStatusCode.OK)
            {
                TileList resultModel = new TileList();
                JToken responseDoc = null;
                if (string.IsNullOrEmpty(responseContent) == false)
                {
                    responseDoc = JToken.Parse(responseContent);
                }
                if (responseDoc != null)
                {
                    resultModel.DeserializeJson(responseDoc);
                }
                result.Body = resultModel;
            }
            
            if (shouldTrace)
            {
                ServiceClientTracing.Exit(invocationId, result);
            }
            return result;
        }
    }
}

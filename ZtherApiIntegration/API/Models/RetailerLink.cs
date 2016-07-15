﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace ZtherApiIntegration.API.Models
{
    public partial class RetailerLink
    {
        private string _account;

        /// <summary>
        /// Optional.
        /// </summary>
        public string Account
        {
            get { return this._account; }
            set { this._account = value; }
        }

        private string _imageUri;

        /// <summary>
        /// Optional.
        /// </summary>
        public string ImageUri
        {
            get { return this._imageUri; }
            set { this._imageUri = value; }
        }

        private string _siteUri;

        /// <summary>
        /// Optional.
        /// </summary>
        public string SiteUri
        {
            get { return this._siteUri; }
            set { this._siteUri = value; }
        }

        private string _storeName;

        /// <summary>
        /// Optional.
        /// </summary>
        public string StoreName
        {
            get { return this._storeName; }
            set { this._storeName = value; }
        }

        /// <summary>
        /// Initializes a new instance of the RetailerLink class.
        /// </summary>
        public RetailerLink()
        {
        }

        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken accountValue = inputObject["account"];
                if (accountValue != null && accountValue.Type != JTokenType.Null)
                {
                    this.Account = ((string)accountValue);
                }
                JToken imageUriValue = inputObject["imageUri"];
                if (imageUriValue != null && imageUriValue.Type != JTokenType.Null)
                {
                    this.ImageUri = ((string)imageUriValue);
                }
                JToken siteUriValue = inputObject["siteUri"];
                if (siteUriValue != null && siteUriValue.Type != JTokenType.Null)
                {
                    this.SiteUri = ((string)siteUriValue);
                }
                JToken storeNameValue = inputObject["storeName"];
                if (storeNameValue != null && storeNameValue.Type != JTokenType.Null)
                {
                    this.StoreName = ((string)storeNameValue);
                }
            }
        }
    }
}
﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace ZtherApiIntegration.API.Models
{
    public partial class Coordinate
    {
        private string _imageUri;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string ImageUri
        {
            get { return this._imageUri; }
            set { this._imageUri = value; }
        }
        
        private string _productCode;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string ProductCode
        {
            get { return this._productCode; }
            set { this._productCode = value; }
        }
        
        private string _productName;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string ProductName
        {
            get { return this._productName; }
            set { this._productName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Coordinate class.
        /// </summary>
        public Coordinate()
        {
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken imageUriValue = inputObject["imageUri"];
                if (imageUriValue != null && imageUriValue.Type != JTokenType.Null)
                {
                    this.ImageUri = ((string)imageUriValue);
                }
                JToken productCodeValue = inputObject["productCode"];
                if (productCodeValue != null && productCodeValue.Type != JTokenType.Null)
                {
                    this.ProductCode = ((string)productCodeValue);
                }
                JToken productNameValue = inputObject["productName"];
                if (productNameValue != null && productNameValue.Type != JTokenType.Null)
                {
                    this.ProductName = ((string)productNameValue);
                }
            }
        }
    }
}

﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace ZtherApiIntegration.API.Models
{
    public partial class Country
    {
        private string _countryCode;
        
        /// <summary>
        /// Required.
        /// </summary>
        public string CountryCode
        {
            get { return this._countryCode; }
            set { this._countryCode = value; }
        }
        
        private string _countryName;
        
        /// <summary>
        /// Required.
        /// </summary>
        public string CountryName
        {
            get { return this._countryName; }
            set { this._countryName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Country class.
        /// </summary>
        public Country()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the Country class with required
        /// arguments.
        /// </summary>
        public Country(string countryCode, string countryName)
            : this()
        {
            if (countryCode == null)
            {
                throw new ArgumentNullException("countryCode");
            }
            if (countryName == null)
            {
                throw new ArgumentNullException("countryName");
            }
            this.CountryCode = countryCode;
            this.CountryName = countryName;
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken countryCodeValue = inputObject["countryCode"];
                if (countryCodeValue != null && countryCodeValue.Type != JTokenType.Null)
                {
                    this.CountryCode = ((string)countryCodeValue);
                }
                JToken countryNameValue = inputObject["countryName"];
                if (countryNameValue != null && countryNameValue.Type != JTokenType.Null)
                {
                    this.CountryName = ((string)countryNameValue);
                }
            }
        }
    }
}

﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace ZtherApiIntegration.API.Models
{
    public partial class KeyValuePair
    {
        private string _key;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }
        
        private string _value;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the KeyValuePair class.
        /// </summary>
        public KeyValuePair()
        {
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken keyValue = inputObject["key"];
                if (keyValue != null && keyValue.Type != JTokenType.Null)
                {
                    this.Key = ((string)keyValue);
                }
                JToken valueValue = inputObject["value"];
                if (valueValue != null && valueValue.Type != JTokenType.Null)
                {
                    this.Value = ((string)valueValue);
                }
            }
        }
    }
}

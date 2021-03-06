﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace ZtherApiIntegration.API.Models
{
    public partial class State
    {
        private string _abbrev;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Abbrev
        {
            get { return this._abbrev; }
            set { this._abbrev = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the State class.
        /// </summary>
        public State()
        {
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken abbrevValue = inputObject["abbrev"];
                if (abbrevValue != null && abbrevValue.Type != JTokenType.Null)
                {
                    this.Abbrev = ((string)abbrevValue);
                }
                JToken nameValue = inputObject["name"];
                if (nameValue != null && nameValue.Type != JTokenType.Null)
                {
                    this.Name = ((string)nameValue);
                }
            }
        }
    }
}

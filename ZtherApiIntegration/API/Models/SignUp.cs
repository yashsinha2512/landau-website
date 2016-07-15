﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace ZtherApiIntegration.API.Models
{
    public partial class SignUp
    {
        private string _brand;
        
        /// <summary>
        /// Required.
        /// </summary>
        public string Brand
        {
            get { return this._brand; }
            set { this._brand = value; }
        }
        
        private string _email;
        
        /// <summary>
        /// Required.
        /// </summary>
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }
        
        private DateTimeOffset? _entryDate;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public DateTimeOffset? EntryDate
        {
            get { return this._entryDate; }
            set { this._entryDate = value; }
        }
        
        private string _firstName;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string FirstName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }
        
        private int? _id;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? ID
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private string _lastName;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string LastName
        {
            get { return this._lastName; }
            set { this._lastName = value; }
        }
        
        private string _phone;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Phone
        {
            get { return this._phone; }
            set { this._phone = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SignUp class.
        /// </summary>
        public SignUp()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the SignUp class with required
        /// arguments.
        /// </summary>
        public SignUp(string brand, string email)
            : this()
        {
            if (brand == null)
            {
                throw new ArgumentNullException("brand");
            }
            if (email == null)
            {
                throw new ArgumentNullException("email");
            }
            this.Brand = brand;
            this.Email = email;
        }
        
        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <returns>
        /// Returns the json model for the type SignUp
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (this.Brand == null)
            {
                throw new ArgumentNullException("Brand");
            }
            if (this.Email == null)
            {
                throw new ArgumentNullException("Email");
            }
            if (this.Brand != null)
            {
                outputObject["brand"] = this.Brand;
            }
            if (this.Email != null)
            {
                outputObject["email"] = this.Email;
            }
            if (this.EntryDate != null)
            {
                outputObject["entryDate"] = this.EntryDate.Value;
            }
            if (this.FirstName != null)
            {
                outputObject["firstName"] = this.FirstName;
            }
            if (this.ID != null)
            {
                outputObject["id"] = this.ID.Value;
            }
            if (this.LastName != null)
            {
                outputObject["lastName"] = this.LastName;
            }
            if (this.Phone != null)
            {
                outputObject["phone"] = this.Phone;
            }
            return outputObject;
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken brandValue = inputObject["brand"];
                if (brandValue != null && brandValue.Type != JTokenType.Null)
                {
                    this.Brand = ((string)brandValue);
                }
                JToken emailValue = inputObject["email"];
                if (emailValue != null && emailValue.Type != JTokenType.Null)
                {
                    this.Email = ((string)emailValue);
                }
                JToken entryDateValue = inputObject["entryDate"];
                if (entryDateValue != null && entryDateValue.Type != JTokenType.Null)
                {
                    this.EntryDate = ((DateTimeOffset)entryDateValue);
                }
                JToken firstNameValue = inputObject["firstName"];
                if (firstNameValue != null && firstNameValue.Type != JTokenType.Null)
                {
                    this.FirstName = ((string)firstNameValue);
                }
                JToken idValue = inputObject["id"];
                if (idValue != null && idValue.Type != JTokenType.Null)
                {
                    this.ID = ((int)idValue);
                }
                JToken lastNameValue = inputObject["lastName"];
                if (lastNameValue != null && lastNameValue.Type != JTokenType.Null)
                {
                    this.LastName = ((string)lastNameValue);
                }
                JToken phoneValue = inputObject["phone"];
                if (phoneValue != null && phoneValue.Type != JTokenType.Null)
                {
                    this.Phone = ((string)phoneValue);
                }
            }
        }
    }
}

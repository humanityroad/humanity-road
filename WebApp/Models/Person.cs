﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Security.Principal;
using WebApp.Utilities;

namespace WebApp
{
    public abstract class Person
    {
        public Person()
        {
            this.Id = ClaimsPrincipal.Current.GetPersonId();
            this.Languages = new List<string>();
            this.CreatedDate = DateTime.UtcNow;
            this.LastModifiedDate = DateTime.UtcNow;
        }

        [Key]
        public string Id { get; set; }
        // Name
        public string Name_First { get; set; }
        public string Name_Last { get; set; }

        // Online contact
        public string Email_Social { get; set; }
        public string Email_Contact { get; set; }
        public string Email_GoogleDocs { get; set; }
        public string SkypeId { get; set; }
        public string TwitterId { get; set; }

        // Offline contact
        public string PhoneNumber_Primary { get; set; }
        public string PhoneNumber_Mobile { get; set; }
        // Address
        public string Street { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string PostalCode { get; set; }
        public string CountryRegion { get; set; }
        public string CountryRegionOfCitizenship { get; set; }

        // Demographics
        public ICollection<string> Languages { get; set; }
        public int? BirthMonth { get; set; }
        public int? BirthDay { get; set; }

        public DateTime LastModifiedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

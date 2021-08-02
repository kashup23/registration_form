﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using ParticipantsAPI.Models;

namespace ParticipantsAPI.Models
{
    public class AddParticipantInput
    {
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mobile number is required")]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage = "Frist name is required")]
        public string Firstname { get; set; }

        public string Middlename { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public string Lastname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Pincode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public string E_q { get; set; }
        [Required(ErrorMessage = "Transaction password is required")]
        public string Tpwd { get; set; }

    }
    public class AddParticipantOutput
    {
        public string Message { get; set; }
        public HttpStatusCode RespCode { get; set; }
    }

    public class GetParticipantInput
    {
        public string Email { get; set; }
    }

    public class UpdateParticipantInput
    {
        public string Email { get; set; }

        public string MobileNumber { get; set; }
        public string Firstname { get; set; }

        public string Middlename { get; set; }

        public string Lastname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Pincode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public string E_q { get; set; }
        public string Tpwd { get; set; }
    }
    public class UpdateParticipantOutput
    {
        public string Message { get; set;  }
        public HttpStatusCode RespCode { get; set;  }
    }
}


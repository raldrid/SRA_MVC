﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SRA_MVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SRAEntities : DbContext
    {
        public SRAEntities()
            : base("name=SRAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<ra_GetAllMessages_Result> ra_GetAllMessages()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ra_GetAllMessages_Result>("ra_GetAllMessages");
        }
    
        public virtual ObjectResult<ra_GetMessageThread_Result> ra_GetMessageThread(Nullable<int> groupid)
        {
            var groupidParameter = groupid.HasValue ?
                new ObjectParameter("groupid", groupid) :
                new ObjectParameter("groupid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ra_GetMessageThread_Result>("ra_GetMessageThread", groupidParameter);
        }
    
        public virtual int ra_InsertOneMessage(Nullable<int> replyid, Nullable<int> groupid, Nullable<int> catid, string name, string email, string title, string message, Nullable<bool> sendemail, Nullable<int> face, string ip, string city, string state, string country)
        {
            var replyidParameter = replyid.HasValue ?
                new ObjectParameter("replyid", replyid) :
                new ObjectParameter("replyid", typeof(int));
    
            var groupidParameter = groupid.HasValue ?
                new ObjectParameter("groupid", groupid) :
                new ObjectParameter("groupid", typeof(int));
    
            var catidParameter = catid.HasValue ?
                new ObjectParameter("catid", catid) :
                new ObjectParameter("catid", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            var messageParameter = message != null ?
                new ObjectParameter("message", message) :
                new ObjectParameter("message", typeof(string));
    
            var sendemailParameter = sendemail.HasValue ?
                new ObjectParameter("sendemail", sendemail) :
                new ObjectParameter("sendemail", typeof(bool));
    
            var faceParameter = face.HasValue ?
                new ObjectParameter("face", face) :
                new ObjectParameter("face", typeof(int));
    
            var ipParameter = ip != null ?
                new ObjectParameter("ip", ip) :
                new ObjectParameter("ip", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("city", city) :
                new ObjectParameter("city", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("state", state) :
                new ObjectParameter("state", typeof(string));
    
            var countryParameter = country != null ?
                new ObjectParameter("country", country) :
                new ObjectParameter("country", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ra_InsertOneMessage", replyidParameter, groupidParameter, catidParameter, nameParameter, emailParameter, titleParameter, messageParameter, sendemailParameter, faceParameter, ipParameter, cityParameter, stateParameter, countryParameter);
        }
    }
}

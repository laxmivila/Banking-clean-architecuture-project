namespace Manga.WebApi.UseCases.Register
{
    using System.Collections.Generic;
    using System;

    public class CustomerModel
    {
        public Guid CustomerId { get; }
        public string SSN { get; }
        public string Name { get; }
        public List<AccountDetailsModel> Accounts { get; set; }
        public string Token { get; set; }
        public CustomerModel(
            Guid customerId,
            string ssn,
            string name, 
            string token,
            List<AccountDetailsModel> accounts)
        {
            CustomerId = customerId;
            SSN = ssn;
            Name = name;
            Token = token;
            Accounts = accounts;
        }
    }
}
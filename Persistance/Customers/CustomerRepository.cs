﻿using System.Linq;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Interfaces.Persistence;
using CleanArchitecture.Domain.Customers;
using CleanArchitecture.Persistance.Shared;

namespace CleanArchitecture.Persistance.Customers
{
    public class CustomerRepository 
        : Repository<Customer>, 
        ICustomerRepository
    {
        public CustomerRepository(IDatabaseService database) 
            : base(database) { }
    }
}
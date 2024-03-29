using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BankApp.Models;

namespace BankApp.Data {
    public class PaymentContext : DbContext {
        public PaymentContext (DbContextOptions<PaymentContext> options) : base(options) {
        }

        public DbSet<Payment> Payment { get; set;}
    }
}
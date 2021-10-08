using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryGeneric.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public UserType UserType { get; set; } = UserType.Operator;
    }

    public enum UserType
    {
        Operator,
        Admin
    }
}
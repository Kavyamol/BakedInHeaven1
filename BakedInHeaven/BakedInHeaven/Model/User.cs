using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BakedInHeaven.API.Context;

namespace BakedInHeaven.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}

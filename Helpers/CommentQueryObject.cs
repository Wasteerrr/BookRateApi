using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Helpers
{
    public class CommentQueryObject
    {
        public string Title { get; set; }   
        public bool IsDescending { get; set; } = true;
    }
}
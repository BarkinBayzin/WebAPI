using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class TestModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int MaxValue { get; set; }
        public int MinValue { get; set; }
        public bool IsActive { get; set; }
    }
}
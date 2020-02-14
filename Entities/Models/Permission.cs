using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Permission : IEntity
    {
        public int Id { get; set; }

        public string Mark { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public bool Type { get; set; }
        public string Url { get; set; }
        public int ParentId { get; set; }

    }
}

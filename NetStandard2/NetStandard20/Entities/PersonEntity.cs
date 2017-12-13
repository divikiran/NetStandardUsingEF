using System;
using System.ComponentModel.DataAnnotations;

namespace NetStandard2.Entities
{
    public class PersonEntity
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address
        {
            get;
            set;
        }
        public string State
        {
            get;
            set;
        }
    }
}

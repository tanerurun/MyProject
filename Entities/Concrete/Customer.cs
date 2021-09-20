using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {

        [Key]
        public string CategoryId { get; private set; }
        public string CustomerName { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }

    }
}

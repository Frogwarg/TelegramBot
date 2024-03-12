using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.ValueObjects
{
    public class FullName:BaseEntityObject
    {
        /// <summary>
        /// TODO: Определить заглушку
        /// </summary>
        public FullName()
        {

        }
        public required string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public required string LastName { get; set; } //мб null


    }
}

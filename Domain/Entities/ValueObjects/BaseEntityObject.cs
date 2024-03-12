using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.ValueObjects
{
    public abstract class BaseEntityObject
    {
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}

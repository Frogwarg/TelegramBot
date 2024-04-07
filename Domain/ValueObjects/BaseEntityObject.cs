using System;
using System.Text.Json;
namespace Domain.Entities.ValueObjects
{
    public abstract class BaseEntityObject
    {
        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj is null)
                return false;

            if (this.GetType() != obj.GetType())
            {
                return false;
            }

            string jsonThis = JsonSerializer.Serialize(this);
            string jsonOther = JsonSerializer.Serialize(obj);

            return jsonThis.Equals(jsonOther);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

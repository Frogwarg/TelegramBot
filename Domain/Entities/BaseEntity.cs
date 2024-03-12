using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    /// <summary>
    /// Базовый класс для всех сущностей
    /// </summary>
    public abstract class BaseEntity:ValueObjects.FullName
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid ID { get; set; }
        /// <summary>
        /// TODO: Описать
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj is not BaseEntity)
            {
                return false;
            }
            if (ID != BaseEntity.ID)
            {
                return false;
            }
            return base.Equals(obj);
        }
        /// <summary>
        /// TODO:Переопределить
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}

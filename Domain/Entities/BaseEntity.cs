using Domain.Entities.ValueObjects;
using System;
namespace Domain.Entities
{
    /// <summary>
    /// Базовый класс для всех сущностей
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public static Guid ID { get; set; }
        /// <summary>
        /// Сравнивает два объекта BaseEntity
        /// </summary>
        /// <param name="obj">Объект для сравнения</param>
        /// <returns>True, если объекты равны и false - иначе</returns>
        public override bool Equals(object? obj)
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
        /// Получает хеш-значение базовой сущности
        /// </summary>
        /// <returns>Хеш-значение</returns>
        public override int GetHashCode()
        {
            var hash = 17;
            hash = hash * 23 + ID.GetHashCode();
            return hash;
        }
    }
}

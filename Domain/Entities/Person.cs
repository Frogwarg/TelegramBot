using Domain.Entities.ValueObjects;
using Domain.Primitives;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Person<T>: BaseEntity
    {
        public Person()
        {

        }
        /// <summary>
        /// ФИО человека
        /// </summary>
        public FullName FullName { get; set; }
        /// <summary>
        /// День рождения
        /// </summary>
        public DateTime BirthDay { get; private set; }
        /// <summary>
        /// Возраст
        /// </summary>
        public int Age {
            get
            {
                return DateTime.Now.Year - BirthDay.Year;
            }
            set
            {
                if (DateTime.Now.Year - BirthDay.Year == value)
                {
                    Age = value;
                }
            }
        }
        /// <summary>
        /// Пол
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// Список особенных полей, хранящих имя поля и значение
        /// </summary>
        public List<CustomField<T>> CustomFields { get; set; }
    }
}
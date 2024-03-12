using System;

namespace Domain.Entities
{
    public class Person:BaseEntity
    {
        public Person()
        {

        }
        public FullName FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public int Age {
            get
            {
                return DateTime.Now.Year - BirthDay.Year;
            }
            set
            {
                //TODO: реализовать set (проверка, правильно ли установили)
            }
        }

        //!!! лист сущностей класс CustomField хранящий имя поля и значение
        public List<CustomField> CustomFields { get; set; }
    }
}
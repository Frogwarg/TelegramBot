namespace Domain.Entities.ValueObjects
{
    public class FullName:BaseEntityObject
    {
        /// <summary>
        /// Конструктор фамилия, имя
        /// </summary>
        /// <param name="firstName">Имя</param>
        /// <param name="lastName">Фамилия</param>
        public FullName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        /// <summary>
        /// Конструктор фамилия, имя, отчество
        /// </summary>
        /// <param name="firstName">Иия</param>
        /// <param name="lastName">Фамилия</param>
        /// <param name="middleName">Отчество (второе имя)</param>
        public FullName(string firstName, string lastName, string? middleName) : this(firstName, lastName)
        {
            MiddleName = middleName;
        }
        /// <summary>
        /// иМЯ
        /// </summary>
        public required string FirstName { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public required string LastName { get; set; } //мб null
        /// <summary>
        /// Отчество или второе имя
        /// </summary>
        public string? MiddleName { get; set; }


    }
}

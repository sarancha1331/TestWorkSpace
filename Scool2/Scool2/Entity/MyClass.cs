namespace School.Entity
{
    /// <summary>
    /// Учебные классы
    /// </summary>
    public class MyClass
    {
        /// <summary>
        /// Ид
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя класса
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// Список студентов класса
        /// </summary>
        public List<Student> MyListStudent { get; set; }

        /// <summary>
        /// Учитель класса
        /// </summary>
        public Teacher MyTeacher { get; set; }

        /// <summary>
        /// Идентификатор школы
        /// </summary>
        public int SchoolId { get; set; }

        /// <summary>
        /// Новое поле ИД Класса
        /// </summary>
        public int ClassId { get; set; }
    }
}

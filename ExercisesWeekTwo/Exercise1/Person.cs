namespace Exercise1
{
    class Person
    {
        public string SurName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public int Age { get; set; }

        public string FullName
        {
            get { return SurName + " " + LastName; }
        }
        public Person()
        {

        }
        public Person(string surname, string lastname, string adress, int age)
        {
            this.SurName = surname;
            this.LastName = lastname;
            this.Adress = adress;
            this.Age = age;
        }

    }
}

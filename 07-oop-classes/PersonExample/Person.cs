namespace PersonExample
{
    /*
    - first name
    - last name
    - is the person studying
    - full name (first name + last name)
    (- address)
    */
    class Person
    {
        public string lastName = "UnknownLastName";
        private string firstName = "UnknownFirstName";

        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
            }
        }

        public bool IsStudying { set; get; }  //shorthand: auto implementation 
        // public bool IsStudying { get; }  //auto implementation - now only a 'get'-value

        public string FullName => FirstName + " " + lastName; // create property FullName, its a 'read only'
        public string GetFirstName()
        {
            return firstName;
        }
        public string GetFullName()
        {
            return firstName + " " + lastName;
        }

        public Person() { } // <-- "no variable constructor" is required since we have defined more complex ones

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Person(string firstName)
        {
            this.firstName = firstName;
        }
    }
}
namespace Carfleet
{
    public class Person
    {
        #region private attributes
        private string _emailaddress;
        #endregion private attributes

        #region public methods
        public Person(string emailaddress)
        {
            _emailaddress = emailaddress;
        }

        public string Emailaddress { get => _emailaddress;}
        #endregion public methods
    }
}
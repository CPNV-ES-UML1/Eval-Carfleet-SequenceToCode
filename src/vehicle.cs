namespace Carfleet
{
    public class Vehicle
    {
        #region private attributes
        private string _chassisNumber;
        #endregion private attributes

        #region public methods
        public Vehicle(string chassisNumber)
        {
            _chassisNumber = chassisNumber;
        }

        public string ChassisNumber { get => _chassisNumber;}
        #endregion public methods
    }
}
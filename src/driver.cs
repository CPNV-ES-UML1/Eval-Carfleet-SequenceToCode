namespace Carfleet
{
    public class Driver : Person
    {
        #region private attributes
        private Vehicle _vehicle = null;
        #endregion private attributes

        #region public methods
        public Driver(string emailaddress) : base(emailaddress){}

        //STEP 1.3
        public void TakeAVehicle(Vehicle vehicle)
        {
            if(_vehicle != null)
            {
                throw new VehicleAlreadyAssignedException();
            }
            _vehicle = vehicle;
        }
        #endregion public methods

        #region nesteded classes
        public class DriverException : Exception { } //Not mandatory
        public class VehicleAlreadyAssignedException : DriverException { }
        #endregion nested classes
    }
}
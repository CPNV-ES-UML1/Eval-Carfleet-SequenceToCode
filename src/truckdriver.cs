namespace Carfleet
{
    public class TruckDriver : Driver
    {
        #region private attributes
        private TruckDriver _truckdriver = null;
        #endregion private attributes

        #region public methods
        public TruckDriver(string emailaddress) : base(emailaddress){}

        //STEP 1.3
        public void TakeAVehicle(Vehicle truckdriver)
        {
            if(_truckdriver != null)
            {
                throw new DriverNotAvailableException();
            }
            _truckdriver = truckdriver;
        }
        #endregion public methods

        #region nesteded classes
        public class DriverException : Exception { } //Not mandatory
        public class DriverNotAvailableException : DriverException { }
        #endregion nested classes
    }
}
namespace Carfleet
{
    public class Truck : Vehicle
    {
        #region private attributes
        private Truck _truck = null;
        #endregion private attributes

        #region public methods
        public Truck(string emailaddress) : base(emailaddress){}

        //STEP 1.3
        public void TakeAVehicle(Vehicle truck)
        {
            if(_truck != null)
            {
                throw new VehicleNotAvailableException();
            }
            _truck = truck;
        }
        #endregion public methods

        #region nesteded classes
        public class VehicleException : Exception { } //Not mandatory
        public class VehicleNotAvailableException : VehicleException { }
        #endregion nested classes
    }
}
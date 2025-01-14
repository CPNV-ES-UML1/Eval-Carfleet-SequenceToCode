//Step 1
_enterprise.AssignVehicleToDriver(_chassisNumber, _driverEmailaddress);

namespace Carfleet
{
    public class Enterprise
    {
        #region private attributes
        private List<Vehicle> _vehicles = new List<Vehicle>();
        private List<Driver> _drivers = new List<Driver>();
        private List<Truck> _trucks = new List<Truck>();
        private List<TruckDriver> _truckdrivers = new List<TruckDriver>();
        #endregion private attributes

        #region public methods
        //STEP 1.2
        public void AssignVehicleToDriver(string chassisNumber, string driverEmailaddress)
        {
            Driver driver = this.GetDriverByEmailaddress(driverEmailaddress);
            Vehicle vehicle = this.GetVehicleByChassisNumber(chassisNumber);
            driver.TakeAVehicle(vehicle);
        }
        #endregion public methods

        #region private methods
        //STEP 1.2
        private Vehicle GetVehicleByChassisNumber(string chassisNumber)
        {
            foreach (Vehicle vehicle in _vehicles)
            {
                if (vehicle.ChassisNumber == chassisNumber)
                {
                    return vehicle;
                }
            }
            throw new VehicleNotFoundException();
        }

        //STEP 1.1
        private Driver GetDriverByEmailaddress(string driverEmailaddress)
        {
            foreach (Driver driver in _drivers)
            {
                if (driver.Emailaddress == driverEmailaddress)
                {
                    return driver;
                }
            }
            throw new DriverNotFoundException();
        }

        #region nesteded class
        public class EnterpriseException : Exception { } //Not mandatory
        public class VehicleNotFoundException : EnterpriseException { }
        public class DriverNotFoundException : EnterpriseException { }
        #endregion nesteded class
    }
}
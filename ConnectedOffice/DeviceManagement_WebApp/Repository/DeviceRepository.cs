using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System.Linq;

namespace DeviceManagement_WebApp.Repository
{
    public class DeviceRepository : GenericRepository<Device>,IDeviceRepository
    {
        public DeviceRepository (ConnectedOfficeContext context): base(context)
        {
        }

        //Method Get most recent Device in the database
        public Device GetMostRecentDevice()
        {
            return _context.Device.OrderByDescending(device => device.DateCreated).FirstOrDefault();
        }
    }
}

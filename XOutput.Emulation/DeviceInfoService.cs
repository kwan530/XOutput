﻿using System.Collections.Generic;
using System.Linq;
using XOutput.Core.DependencyInjection;

namespace XOutput.Emulation
{
    public class DeviceInfoService
    {
        private List<NetworkDeviceInfo> connectedDevices = new List<NetworkDeviceInfo>();

        [ResolverMethod]
        public DeviceInfoService()
        {

        }

        public void Add(NetworkDeviceInfo deviceInfo)
        {
            connectedDevices.Add(deviceInfo);
        }

        public void Remove(IDevice device)
        {
            connectedDevices.RemoveAll(di => di.Device == device);
        }

        public void StopAndRemove(string id)
        {
            var device = connectedDevices.Where(di => di.Device.Id == id).First();
            device.Device.Close();
            connectedDevices.Remove(device);
        }

        public IEnumerable<NetworkDeviceInfo> GetConnectedDevices() => connectedDevices.ToList();
    }
}

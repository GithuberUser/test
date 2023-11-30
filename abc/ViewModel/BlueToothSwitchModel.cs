
using Plugin.BLE.Abstractions.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Model
{
    internal class BlueToothSwitchModel
    {
        private IBluetoothLE _BluetoothPle;
        private IAdapter _Adapter;
        public string a;

        public void on()
        {
            _BluetoothPle = Plugin.BLE.CrossBluetoothLE.Current;
            _Adapter = _BluetoothPle.Adapter;

            _Adapter.ScanTimeout = 100000;
            Debug.WriteLine(_BluetoothPle);
            Debug.WriteLine(_Adapter);

            _Adapter.DeviceDiscovered += Click;
            _Adapter.StartScanningForDevicesAsync();

        }
        
        public void Click(object sender, Plugin.BLE.Abstractions.EventArgs.DeviceEventArgs e)
        {
            a = e.Device.ToString();
        }

        
    }
}

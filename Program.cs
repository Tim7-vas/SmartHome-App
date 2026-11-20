using System.Text;
using SmartHome.Devices;
using SmartHome.Services;

Console.OutputEncoding = Encoding.UTF8;

var manager = new DeviceManager();
manager.Add(new SmartLight("L1", "Лампа спальня"));
manager.Add(new SmartThermostat("T1", "Термостат"));
manager.Add(new SmartCamera("C1", "Камера"));
manager.Add(new SmartLock("K1", "Замок"));

manager.TurnAllOn();
manager.PrintAllStatuses();
manager.SetLevelForAllAdjustable(25);
manager.PrintAllStatuses();
manager.PrintAllReports();

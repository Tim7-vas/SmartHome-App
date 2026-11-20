using System.Text;
using SmartHome.Devices;
using SmartHome.Services;

Console.OutputEncoding = Encoding.UTF8;

var manager = new DeviceManager();
manager.Add(new SmartLight("L1", "Лампа спальня"));
manager.Add(new SmartThermostat("T1", "Термостат"));
manager.Add(new SmartCamera("C1", "Камера"));
manager.Add(new SmartLock("K1", "Замок"));
manager.Add(new SmartFan("F1", "Вентилятор в гостиной"));

manager.TurnAllOn();
manager.PrintAllStatuses();

Console.WriteLine("\n--- Устанавливаем уровень 5 для всех регулируемых устройств ---");
manager.SetLevelForAllAdjustable(5);
manager.PrintAllStatuses();

using SmartHome.Devices;
using SmartHome.Interfaces;

namespace SmartHome.Services;

public class DeviceManager
{
private readonly List<SmartDevice> _devices = new();

public void Add(SmartDevice device) => _devices.Add(device);

public void TurnAllOn()
{
foreach (var d in _devices) d.TurnOn();
}

public void TurnAllOff()
{
foreach (var d in _devices) d.TurnOff();
}

public void PrintAllStatuses()
{
foreach (var d in _devices) Console.WriteLine(d.GetStatus());
}

public void SetLevelForAllAdjustable(int level)
{
foreach (var d in _devices)
{
if (d is IAdjustable a) a.SetLevel(level);
}
}

public void PrintAllReports()
{
foreach (var d in _devices)
{
if (d is IReportable r) Console.WriteLine(r.GetShortReport());
}
}
}

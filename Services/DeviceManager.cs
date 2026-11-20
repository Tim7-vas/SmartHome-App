using SmartHome.Devices;
using SmartHome.Interfaces;
namespace SmartHome.Services;
public class DeviceManager
{
private readonly List _devices = new();
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
public void PrintScheduledDevices()
{
Console.WriteLine("\n--- Устройства с активным расписанием ---");
foreach (var d in _devices)
{
if (d is ISchedulable s && (s.ScheduledOn.HasValue || s.ScheduledOff.HasValue))
{
string onStr = s.ScheduledOn?.ToString(@"hh:mm") ?? "не задано";
string offStr = s.ScheduledOff?.ToString(@"hh:mm") ?? "не задано";
Console.WriteLine($"[{d.Name}] Включение: {onStr}, Выключение: {offStr}");
}
}
}
}

using SmartHome.Interfaces;

namespace SmartHome.Devices;

public class SmartCamera : SmartDevice, IReportable
{
public DateTime LastMotion { get; private set; } = DateTime.Now;

public SmartCamera(string id, string name) : base(id, name) { }

public void SimulateMotion()
{
LastMotion = DateTime.Now;
Console.WriteLine($"[{Name}] зафиксировано движение!");
}

public string GetShortReport() =>
$"Камера {Name}: последнее движение {LastMotion:HH:mm:ss}";

public override string GetStatus() =>
$"Камера [{Name}]: {(IsOn ? "вкл" : "выкл")}";
}

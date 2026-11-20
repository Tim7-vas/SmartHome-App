namespace SmartHome.Devices;

public class SmartLock : SmartDevice
{
public bool IsLocked { get; private set; } = true;

public SmartLock(string id, string name) : base(id, name) { }

public void Unlock()
{
IsLocked = false;
Console.WriteLine($"[{Name}] разблокирован");
}

public void Lock()
{
IsLocked = true;
Console.WriteLine($"[{Name}] заблокирован");
}

public override string GetStatus() =>
$"Замок [{Name}]: {(IsLocked ? "заблокирован" : "открыт")}";
}

using SmartHome.Interfaces;

namespace SmartHome.Devices;

public class SmartLight : SmartDevice, IAdjustable
{
public int Brightness { get; private set; } = 100;

public SmartLight(string id, string name) : base(id, name) { }

public int Level => Brightness;

public void SetLevel(int level)
{
if (level < 0 || level > 100)
throw new ArgumentOutOfRangeException(nameof(level), "Яркость 0–100");
Brightness = level;
}

public override string GetStatus() =>
$"Лампа [{Name}]: {(IsOn ? "вкл" : "выкл")}, яркость {Brightness}%";
}

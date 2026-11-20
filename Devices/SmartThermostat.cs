using SmartHome.Interfaces;

namespace SmartHome.Devices;

public class SmartThermostat : SmartDevice, IAdjustable
{
public int TargetTemperature { get; private set; } = 22;

public SmartThermostat(string id, string name) : base(id, name) { }

public int Level => TargetTemperature;

public void SetLevel(int level)
{
if (level < 5 || level > 35)
throw new ArgumentOutOfRangeException(nameof(level), "Температура 5–35 °C");
TargetTemperature = level;
}

public override string GetStatus() =>
$"Термостат [{Name}]: {(IsOn ? "вкл" : "выкл")}, цель {TargetTemperature} °C";
}

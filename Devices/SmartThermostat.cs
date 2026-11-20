using SmartHome.Interfaces;
namespace SmartHome.Devices;
public class SmartThermostat : SmartDevice, IAdjustable, ISchedulable, IEnergyConsumer
{
public int TargetTemperature { get; private set; } = 22;
public TimeSpan? ScheduledOn { get; private set; }
public TimeSpan? ScheduledOff { get; private set; }
public double PowerConsumptionWatt => 500.0;
public SmartThermostat(string id, string name) : base(id, name) { }
public int Level => TargetTemperature;
public void SetLevel(int level)
{
if (level < 5 || level > 35)
throw new ArgumentOutOfRangeException(nameof(level), "Температура 5–35 °C");
TargetTemperature = level;
}
public void ScheduleOn(TimeSpan time) => ScheduledOn = time;
public void ScheduleOff(TimeSpan time) => ScheduledOff = time;
public double CalculateDailyConsumption()
{
// Расчёт при работе 12 часов в сутки (в кВт·ч)
return (PowerConsumptionWatt * 12) / 1000.0;
}
public override string GetStatus() =>
$"Термостат [{Name}]: {(IsOn ? "вкл" : "выкл")}, цель {TargetTemperature} °C";
}

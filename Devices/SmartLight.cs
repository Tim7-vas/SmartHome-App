using SmartHome.Interfaces;
namespace SmartHome.Devices;
public class SmartLight : SmartDevice, IAdjustable, ISchedulable, IEnergyConsumer
{
public int Brightness { get; private set; } = 100;
public TimeSpan? ScheduledOn { get; private set; }
public TimeSpan? ScheduledOff { get; private set; }
public double PowerConsumptionWatt => 10.0;
public SmartLight(string id, string name) : base(id, name) { }
public int Level => Brightness;
public void SetLevel(int level)
{
if (level < 0 || level > 100)
throw new ArgumentOutOfRangeException(nameof(level), "Яркость 0–100");
Brightness = level;
}
public void ScheduleOn(TimeSpan time) => ScheduledOn = time;
public void ScheduleOff(TimeSpan time) => ScheduledOff = time;
public double CalculateDailyConsumption()
{
// Расчёт при работе 8 часов в сутки (в кВт·ч)
return (PowerConsumptionWatt * 8) / 1000.0;
}
public override string GetStatus() =>
$"Лампа [{Name}]: {(IsOn ? "вкл" : "выкл")}, яркость {Brightness}%";
}

namespace SmartHome.Interfaces;
public interface IEnergyConsumer
{
double PowerConsumptionWatt { get; }
double CalculateDailyConsumption();
}

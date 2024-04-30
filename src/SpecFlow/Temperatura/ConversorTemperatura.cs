namespace Temperatura;

public static class ConversorTemperatura
{
    public static double FahrenheitParaCelsius(
        double temperatura)
    {
        return (temperatura - 32.0) / 1.8; // Simulacao de falha
        //return Math.Round(
        //    (temperatura - 32.0) / 1.8, 2);
    }

    public static double FahrenheitParaKelvin(
            double temperatura)
    {
        return FahrenheitParaCelsius(temperatura) + 273.15; // Simulacao de falha
        //return Math.Round(
        //    FahrenheitParaCelsius(temperatura) + 273.15, 2);
    }
}
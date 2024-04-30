namespace Groffe.Distancias;

public class ConversorDistancias
{
    public static double MilhasParaKm(double milhas) =>
        milhas * 1.609; // TODO: Retirar essa simulação de falha
        //Math.Round(milhas * 1.609, 3);

    public static double KmParaMilhas(double km) =>
        km / 1.609; // TODO: Retirar essa simulação de falha
        //Math.Round(km / 1.609, 3);
}
namespace TesteConsoleDIO.Calc;

public class CalcComum
{
    public string Soma(int x, int y)
    {
        return $"{x} + {y} =  {x + y}";
    }

    public double Seno(double angulo)
    {
        double radiano = angulo * Math.PI / 180;
        double seno = Math.Sin(radiano);
        return seno;
    }

    public double Cosseno(double angulo)
    {
        double radiano = angulo * Math.PI / 180;
        double cosseno = Math.Cos(radiano);
        return cosseno;
    }

    public double Tangente(double angulo)
    {
        double radiano = angulo * Math.PI / 180;
        double tangente = Math.Tan(radiano);
        return tangente;
    }
    
}
using System;

public class Fraction
{
    private int _top;
    private int _bottom;


    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {   
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

     public int GetTop() //public → qualquer lugar pode chamar, int → ele vai devolver um número, GetTop → nome que indica “pegar o numerador”
    {
        return _top; // 
    }

    public void SetTop(int top) // Por que isso é importante? Sem isso: ninguém consegue mudar o numerador depois de criado
    {
        _top = top;
    }

    public int GetBottom() // mesma logica do numerador
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue() // estamos usando double pois se nã usarmos e por exemplo fazer 3 dividido por 4 ele vai dar 0 pois o numero vai ser quebrado e INT não recebe numero quebrado 
    {
        return(double)_top/_bottom;
    }
}
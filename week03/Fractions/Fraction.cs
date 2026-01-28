using System;

public class Fraction
{
    private int _top; // numerador
    private int _bottom; // denominador

    public Fraction()
    {
        _top = 1; //como a atividade pediu se o usuario não passar nada a fração começa 1/1
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop() // aqui usa para dizer o númerador 
    {
        return _top;
    }

    public void SetTop(int top) // usa para alterar o valor
    {
        _top = top;
    }

    public int GetBottom()
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

    public double GetDecimalValue() // o double permiti que façamos divisoes que o resultado seja números decimal já que int só aceita número cheio
    {
        return (double)_top / _bottom; // para fraçoes devemos usar o double e não o float
    }

}
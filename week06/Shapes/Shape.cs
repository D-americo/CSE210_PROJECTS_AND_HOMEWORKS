using System;

public class Shape
{
    private string _color;

    public Shape(string color) // construtor
    {
        _color = color;
    }

    public string GetColor() // serve para acessar o _color que é um metodo privado mas com o getter da para acessar fora da base
    {
        return _color;
    }

    public virtual double GetArea() // significa que as classes filhas podem sobrescrever esse metodo com override ou seja mudar o comportamento dela e principlamente nesse exercicio dependendo do que estamos calculando a area como retangulo, triangulo ou quadrado o jeito de contar(comportamento) vai ser diferente
    {
        return 0;
    }
}
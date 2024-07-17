using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

public class Jogo
{
    public string Nome { get; set; }
    public int Quantidade { get; set; }
    public double Peso { get; set; }
    public double Preco { get; set; }
    public string Marca { get; set; }

    public Jogo(string nome, int quantidade, double peso, double preco, string marca)
    {
        Nome = nome.ToUpper();
        Quantidade = quantidade;
        Peso = peso;
        Preco = preco;
        Marca = marca.ToUpper();
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Quantidade: {Quantidade}, Peso: {Peso:F2}kg, Preço: {Preco:C}, Marca: {Marca}";
    }
    public double CalcularFrete(double distancia)
    {
        return distancia * (0.1 * Peso) / (Preco * 0.1) * Quantidade;
    }

}
// string CaixaAlta(string str) => str.ToUpper();
// string Capitalize(string str) => char.ToUpper(str[0]) + str.Substring(1);

// string CapitalizeAll(string str)
// {
//     var split = str.Split(' ');
//     var result = default(string);
//     foreach(string s in split)
//     {
//         result += char.ToUpper(s[0]) + s.Substring(1) + ' ';
//     }

//     return result;
// }

// List<String> strings = new List<String>();
// strings.Add("oi");
// strings.Add("pessoal lindo do caralho!");
// var newstrings = formatString(strings, CapitalizeAll);

// foreach(var s in newstrings)
// {
//     Console.WriteLine(s);
// }

// static List<string> formatString(List<string> strList, Func<string, string> myFunc)
// {
//     List<string> result = new List<string>();
//     foreach(var s in strList)
//     {
//         result.Add(myFunc(s));
//     }

//     return result;
// }

// public class Stack<T>
// {
//     private T[] stackList = new T[10];
//     private int top { get; set; } = -1;

//     public void Push(T item)
//     {
//         this.top++;
//         this.stackList[this.top] = item;
//     }

//     public void Pop()
//     {
//         if (this.isEmpty())
//         {
//             Console.WriteLine("Stack vazia.");
//         }

//         stackList[top] = default(T);
//         top--;
//     }

//     public bool isEmpty()
//     {
//         return top < 0;
//     }

//     public int Size()
//     {
//         return top + 1;
//     }

//     public void Clear()
//     {
//         while(top > 0)
//         {
//             this.stackList[top] = default(T);
//             top--;
//         }
//     }

//     public override string ToString()
//     {
//         string str = "";

//         while(this.top >= 0)
//         {
//             str += this.top + " - " + '[' + this.stackList[top] + ']' + "\n";
//             this.top--;
//         }

//         return str;
//     }
// }

using System.Collections.Generic;
using System;
using System.Linq;

var estoque = new List<Produto>()
{
    new Produto("Arroz", 10.0, new DateTime(2023, 12, 31)),
    new Produto("Feijão", 8.0, new DateTime(2023, 6, 30)),
    new Produto("Azeite", 20.0, new DateTime(2025, 2, 28)),
    new Produto("Sal", 2.0, new DateTime(2024, 10, 31)),
    new Produto("Açúcar", 5.0, new DateTime(2023, 8, 31)),
    new Produto("Café", 7.5, new DateTime(2022, 12, 31)),
    new Produto("Leite", 3.5, new DateTime(2023, 4, 30)),
    new Produto("Pão", 4.0, new DateTime(2022, 11, 30)),
    new Produto("Queijo", 15.0, new DateTime(2022, 10, 31)),
    new Produto("Presunto", 12.0, new DateTime(2022, 11, 30)),
    new Produto("Manteiga", 8.5, new DateTime(2023, 1, 31)),
    new Produto("Achocolatado", 6.0, new DateTime(2024, 5, 31)),
    new Produto("Refrigerante", 4.5, new DateTime(2023, 7, 31)),
    new Produto("Suco", 3.5, new DateTime(2023, 3, 31)),
    new Produto("Água", 2.0, new DateTime(2024, 2, 29)),
    new Produto("Carne", 25.0, new DateTime(2023, 2, 28)),
    new Produto("Frango", 15.0, new DateTime(2023, 1, 31)),
    new Produto("Peixe", 20.0, new DateTime(2022, 12, 31)),
    new Produto("Batata", 2.5, new DateTime(2022, 10, 31)),
    new Produto("Cebola", 3.0, new DateTime(2023, 3, 31)),
    new Produto("Alho", 2.0, new DateTime(2022, 11, 30)),
    new Produto("Tomate", 3.5, new DateTime(2023, 1, 28)),
    new Produto("Cenoura", 2.5, new DateTime(2023, 1, 31)),
    new Produto("Abóbora", 4.0, new DateTime(2024, 4, 30)),
    new Produto("Beterraba", 2.5, new DateTime(2023, 2, 19))
};

estoque.Where(p => p.Valor >= 10);

// 1 -Liste todos os produtos do estoque, do mais barato ao mais caro.
// var estoqueOrdenado = estoque.OrderBy(p => p.Valor);
// foreach(var produto in estoqueOrdenado)
//     Console.WriteLine(produto);

// 2 - Liste os produtos por ordem alfabética.
// estoqueOrdenado = estoque.OrderBy(p => p.Nome);
// foreach(var produto in estoqueOrdenado)
//     Console.WriteLine(produto);

// 3 - Encontre a média de preço dos produtos, mostre a média, e todos os produtos com o preço acima dela
// var avgPrice = estoque.Average(p => p.Valor);
// Console.WriteLine($"Média: {avgPrice}");
// var productsBehindAvg = estoque.Where(p => p.Valor >= avgPrice);
// foreach(var produto in productsBehindAvg)
//     Console.WriteLine(produto);

// 4 - Liste os produtos vencidos
// var dateNow = DateTime.Now;
// var produtosVencidos = estoque.Where(p => (p.DataValidade.Year < dateNow.Year) || (p.DataValidade.Month < dateNow.Month) || (p.DataValidade.Day < dateNow.Day));
// foreach(var produto in produtosVencidos)
//     Console.WriteLine(produto);

// 5 - Implemente uma função que receba a lista de estoque e uma data utilizando o tipo DateTime, 
// esta função deve retornar uma lista que contendo todos os produtos que irão expirar até esta data
// Ex: WillExpirate(List<estoque> estoque, DateTime dataDesejada) { }
static List<Produto> WillExpirate(List<Produto> stock, DateTime desiredDate)
{
    var expiredStock = stock.Where(p => p.DataValidade < desiredDate);
    return expiredStock.ToList();
}

var expiredStock = WillExpirate(estoque, new DateTime(2022, 11, 21));
foreach(var produto in expiredStock)
    Console.WriteLine(produto);

// 6 - Implemente uma função chamada valorMínimo, que tenha como parâmetro a lista de estoque e o valor mínimo
// que a lista deve filtrar, utilize o LINQ para retornar todos os valores acima do valorMínimo
// Ex: getByMinValue(List<estoque> estoque, double minValue)


// 7 - Assim como no exercício 6, implemente agora uma função que pegue todos os valores menores que o valor máximo
// Ex: getByMaxValue(List<estoque> estoque, double maxValue)

public class Produto
{
    public string Nome { get; set; }
    public double Valor { get; set; }

    public DateTime DataValidade { get; set; }

    public Produto(string nome, double valor, DateTime validade)
    {
        Nome = nome;
        Valor = valor;
        DataValidade = validade;
    }

    public override string ToString()
    {
        return Nome + " - R$ " + Valor + $" / Validade: {DataValidade.Day}/{DataValidade.Month}/{DataValidade.Year}";
    }
}
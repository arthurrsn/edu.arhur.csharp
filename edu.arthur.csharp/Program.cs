using edu.arthur.csharp.Models;
Pessoa pessoa = new Pessoa("Arthur", 18);
pessoa.Apresentar();
pessoa.Nome = "Eduarda";
pessoa.Apresentar();
Console.WriteLine(pessoa.Nome);
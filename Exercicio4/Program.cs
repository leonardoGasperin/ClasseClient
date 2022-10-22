using Exercicio4;

var _estudante = new Estudante(001, "Baldineia Maria", "Dódoi.", new DateTime(1970, 01, 01));
Cliente _comParametro = new(159, "Aldiney Aldaberto Cunha", "145.632.159-10", "Av.  Jucelino Kubchek?", 150.55);
var _semParemetro = new Cliente();

_semParemetro.Id = 001;
_semParemetro.Name = "Baldineyzinho Jr.";
_semParemetro.Cpf = "159.756.456-01";
_semParemetro.Endereco = "Rua Zezé Cantara";
_semParemetro.Renda = 1110001.11;
_comParametro.Cpf = "ops!";

Console.WriteLine("\n=================_estudante=================\n" +
                  $"\tID: {_estudante.Id}\n\tNome: {_estudante.Name}\n\tExame médico: {_estudante.ExameMedico}\n" +
                  $"\tData nascimento: {_estudante.DataNascimento.ToShortDateString()}\n\tEstatus: {_estudante.Estatus}" +
                  "\n=================_estudante=================\n");

Console.WriteLine("\n=================_comParametro=================\n" +
                  $"ID: {_comParametro.Id}\nNome: {_comParametro.Name}\nCPF: {_comParametro.Cpf}\n" +
                  $"Endereco: {_comParametro.Endereco}\nRenda: {_comParametro.Renda:C}\n" +
                  "\n=================_comParametro=================\n");

Console.WriteLine("\n=================_semParemetro=================\n" +
                  $"ID: {_semParemetro.Id}\nNome: {_semParemetro.Name}\nCPF: {_semParemetro.Cpf}\n" +
                  $"Endereco: {_semParemetro.Endereco}\nRenda: {_semParemetro.Renda:C}\n" +
                  "\n=================_semParemetro=================\n");

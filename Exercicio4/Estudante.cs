namespace Exercicio4
{
    internal class Estudante
    {
        private int id;
        private string name;
        private string exameMedico;
        private DateTime dataNascimento;
        private bool estatus;

        public int Id { get { return id; } }
        public string Name { get { return name; } }
        public string ExameMedico { get { return exameMedico; } }
        public DateTime DataNascimento { get { return dataNascimento; } }
        public bool Estatus { get { return estatus; } }

        public Estudante(int id, string name, string exameMedico, DateTime dataNascimento)
        {
            this.id = id;
            this.name = name;
            this.exameMedico = exameMedico;
            this.dataNascimento = dataNascimento;
            this.estatus = true;
        }
    }
}

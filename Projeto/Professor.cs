namespace Projeto
{
    class Professor : Pessoa
    {
        public string Disciplina { get; set; }

        public Professor (String nome, string disciplina): base(nome)
        {
            Disciplina = disciplina;
        }
        public override void ExibirInfo()
        {
            Console.WriteLine($"[Professor]: Nome {Nome}, Disciplina: {Disciplina}");
        }
    }
}
namespace Projeto
{
    class Aluno : Pessoa
    {
        public string CursoTecnico {get; set;}

        public Aluno(string nome,string cursoTecnico): base(nome)
        {
            cursoTecnico = cursoTecnico;
        }
        public override void ExibirInfo()
        {
            Console.WriteLine($"[Aluno] : {Nome}, Curso: {CursoTecnico}");
        }

    }
}
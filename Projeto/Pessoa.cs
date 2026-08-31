namespace Projeto
{
    public  class Pessoa
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Pessoa(string nome)
        {
            Nome = nome;
        }       

        public virtual void ExibirInfo()
        {
            Console.WriteLine($"Nome:{Nome}");
        }

    }
}
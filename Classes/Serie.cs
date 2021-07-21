namespace DIO.series
{
    public class Serie : EntidadeBase
    {
        // Atributos

        private Genero Genero { get; set; }

        private string Titulo { get; set; }

        private string Descricao { get; set; }

        private int Ano { get; set; }


        private bool Excluido { get; set; }

        // Métodos

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            // Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.evironment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + "\r\n";
            retorno += "Título: " + this.Titulo + "\r\n";
            retorno += "Descrição: " + this.Descricao + "\r\n";
            retorno += "Ano de Início: " + this.Ano + "\r\n";
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir() {
            this.Excluido = true;
        }

    }
}
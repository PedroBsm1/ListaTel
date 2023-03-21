namespace BLL
{
    public class Dados
    {
        public string Nome { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"Nome: {Nome} - Telefone: {Telefone}";
        }
    }
}
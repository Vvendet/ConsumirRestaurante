namespace Restaurante.DTOs
{
    public class RestauranteDTO
    {
        public RestauranteDTO(string nome, int cozinha)
        {
            Nome = nome;
            Cozinha = cozinha;
        }
        public string Nome { get; set; }
        public int Cozinha { get; set; }
        public EnderecoDTO Endereco { get; set; }
        public AvaliacaoDTO Avaliacao { get; set; }

        public void AtribuirEndereco(EnderecoDTO e)
        {
            Endereco = e;
        }
        public void AtribuirAvaliacao(AvaliacaoDTO a)
        {
            Avaliacao = a;
        }
    }
}
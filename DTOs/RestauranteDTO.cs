namespace Restaurante.DTOs
{
    public class RestauranteDTO
    {
        public string Nome { get; set; }
        public int Cozinha { get; set; }
        public EnderecoDTO Endereco { get; set; }
        public AvaliacaoDTO Avaliacao { get; set; }
    }
}

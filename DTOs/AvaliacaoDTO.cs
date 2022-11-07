namespace Restaurante.DTOs
{
    public class AvaliacaoDTO
    {
        public AvaliacaoDTO(double estrelas)
        {
            Estrelas = estrelas;
        }

        public double Estrelas { get; set; }

    }
}

namespace Restaurante.DTOs
{
    public class EnderecoDTO
    {
        public EnderecoDTO(string l, int n, string ci, string uf, int ce)
        {
            Logradouro = l;
            Numero = n;
            Cidade = ci;
            UF = uf;
            Cep = ce;
        }
        public string Logradouro { get; set; }
        public int Numero { get; set; }

        public string Cidade { get; set; }

        public string UF { get; set; }

        public int Cep { get; set; }


    }
}

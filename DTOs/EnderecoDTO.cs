namespace Restaurante.DTOs
{
    public class EnderecoDTO
    {
        public EnderecoDTO(string l, string n, string ci, string uf, string ce)
        {
            Logradouro = l;
            Numero = n;
            Cidade = ci;
            UF = uf;
            Cep = ce;
        }
        public string Logradouro { get; set; }
        public string Numero { get; set; }

        public string Cidade { get; set; }

        public string UF { get; set; }

        public string Cep { get; set; }


    }
}

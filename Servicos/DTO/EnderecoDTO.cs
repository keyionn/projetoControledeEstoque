namespace Servicos.DTO
{
    public class EnderecoDTO
    {
        public Guid Id { get; set; }

        public string Rua { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string CEP { get; set; }

        public int UsuarioId { get; set; }
        
        public virtual UsuarioDTO Usuario { get; set; }
    }
}

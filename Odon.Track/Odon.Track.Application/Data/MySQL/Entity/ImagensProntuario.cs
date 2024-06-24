using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Odon.Track.Application.Data.MySQL.Entity
{
    [Table("imagens_prontuario")]
    public class ImagensProntuario
    {
        [Key,Column("id")]
        public int Id { get; set; }
        [Column("id_prontuario")]
        public int IdProntuario { get; set; }
        [Column("tipo_imagem")]
        public string TipoImagem { get; set; }
        [Column("path")]
        public string Path { get; set; }
        [Column("filename")]
        public string Filename { get; set; }
        [Column("content_type")]
        public string ContentType { get; set; }
    }
}

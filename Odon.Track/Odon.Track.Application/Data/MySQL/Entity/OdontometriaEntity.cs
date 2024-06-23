using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Odon.Track.Application.Data.MySQL.Entity
{
    [Table("odontometria")]
    public class OdontometriaEntity
    {
        [Key, Column("id")]
        public int Id { get; set; }
        [Column("id_prontuario")]
        public int IdProntuario { get; set; }
        [Column("id_endodontia")]
        public int IdEndodontia { get; set; }
        [Column("canal")]
        public string Canal { get; set; }
        [Column("cad")]
        public string CAD { get; set; }
        [Column("crd")]
        public string CRD { get; set; }
        [Column("crt")]
        public string CRT { get; set; }
        [Column("diametro_anatomico")]
        public string DiametroAnatomico { get; set; }
        [Column("diametro_cirurgico")]
        public string DiametroCirurgico { get; set; }
        [Column("ponto_de_referencia")]
        public string PontoDeRefencia { get; set; }
    }
}

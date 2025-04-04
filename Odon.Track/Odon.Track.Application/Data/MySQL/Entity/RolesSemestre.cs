﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Odon.Track.Application.Data.MySQL.Entity
{
    [Table("roles_semestre")]
    public class RolesSemestre
    {
        [Key, Column("id")]
        public int Id { get; set; }
        [Column("id_role")]
        public int IdRole { get; set; }
        [Column("periodo")]
        public int Periodo { get; set; }

        [ForeignKey("IdRole")]
        public Roles Roles { get; set; }
    }
}

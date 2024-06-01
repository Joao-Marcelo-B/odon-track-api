﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Odon.Track.Application.Data.MySQL.Entity
{

    [Table("responsavel")]
    public class Responsavel
    {
        [Key, Column("id")]
        public int Id { get; set; }
        [Column("id_paciente")]
        public int IdPaciente { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("cpf")]
        public string CPF { get; set; }
        [Column("telefone")]
        public string Telefone { get; set; }
        [Column("email")]
        public string Email { get; set; }
    }
}
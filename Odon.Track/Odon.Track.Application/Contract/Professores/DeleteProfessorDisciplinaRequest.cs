using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odon.Track.Application.Data.MySQL.Entity;

namespace Odon.Track.Application.Contract.Professores
{
    public class DeleteProfessorDisciplinaRequest
    {
        public string NomeDisciplina {  get; set; }
    }
}

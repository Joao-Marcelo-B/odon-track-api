﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Odon.Track.Application.Contract.Estudantes;
using Odon.Track.Application.Data.MySQL;
using Odon.Track.Application.Data.MySQL.Entity;
using Odon.Track.Application.Errors;
using Odon.Track.Application.Responses;

namespace Odon.Track.Application.Services
{
    public class EstudantesServices : BaseResponses
    {
        private readonly OdontrackContext _context;
        public EstudantesServices(OdontrackContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> GetEstudantes()
        {
            
            var estudantes = await _context.Estudantes.ToListAsync();
            GetEstudantesResponse estudante = new ();
            foreach (var item in estudantes)
                estudante.Estudantes.Add(new EstudantesInfo
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    PeriodoAtual = item.PeriodoAtual
                });
            
            return Ok(new { estudante.Estudantes });
        }

        public async Task<IActionResult> GetByEstudante(int id)
        {
            var estudante = await _context.Estudantes.FirstOrDefaultAsync(x => x.Id == id);
            if (estudante == null)
                return BadRequest(OdonTrackErrors.EstudanteNotFound);
            else 
                return Ok(estudante);
        }
    }
}


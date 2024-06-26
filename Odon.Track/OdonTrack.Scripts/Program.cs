﻿using Microsoft.EntityFrameworkCore;
using Odon.Track.Application.Crypto;
using Odon.Track.Application.Data.MySQL;

var password = "teste123";

PasswordSaltHasher.CreatePasswordHashAndSalt(password, out var passwordHash, out var passwordSalt);

var options = new DbContextOptionsBuilder<OdontrackContext>();
options.UseMySQL("server=localhost;port=3307;database=odon_track;User=root;Password=root;");

using (var context = new OdontrackContext(options.Options))
{
    var usuarios = context.Usuarios.ToList();

    foreach (var usuario in usuarios)
    {
        usuario.PasswordHash = passwordHash;
        usuario.PasswordSalt = passwordSalt;
    }
    context.SaveChanges();
}
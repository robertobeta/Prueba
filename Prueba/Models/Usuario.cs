﻿using System;
using System.Collections.Generic;

namespace Prueba.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public string Contrasena { get; set; } = null!;

    public bool? Activo { get; set; }
}

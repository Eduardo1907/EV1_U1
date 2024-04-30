using System;
using System.Collections.Generic;

namespace MisClientes.Models;

public partial class Cliente
{
    public int ClientesId { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public float? Rut { get; set; }

    public string? Correo { get; set; }

    public DateTime? FechaHora { get; set; }
}

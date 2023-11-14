using System;
using System.Collections.Generic;

namespace PL;

public partial class Candidato
{
    public int IdCandidato { get; set; }

    public string Nombre { get; set; } = null!;

    public string ApellidoPaterno { get; set; } = null!;

    public string? ApellidoMaterno { get; set; }

    public string Contacto { get; set; } = null!;

    public decimal PretensionEconomica { get; set; }

    public int IdUniversidad { get; set; }

    public double Promedio { get; set; }

    public virtual ICollection<Entrevistum> Entrevista { get; set; } = new List<Entrevistum>();

    public virtual Universidad IdUniversidadNavigation { get; set; } = null!;
}

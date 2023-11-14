using System;
using System.Collections.Generic;

namespace PL;

public partial class Entrevistum
{
    public int IdEntrevista { get; set; }

    public int IdCandidato { get; set; }

    public double CalificacionPsicometricos { get; set; }

    public DateTime FechaEntrevista { get; set; }

    public virtual Candidato IdCandidatoNavigation { get; set; } = null!;
}

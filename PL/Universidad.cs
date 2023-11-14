using System;
using System.Collections.Generic;

namespace PL;

public partial class Universidad
{
    public int IdUniversidad { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Candidato> Candidatos { get; set; } = new List<Candidato>();
}

namespace PL.Model
{
    public class Entrevista
    {
        public int IdEntrevista { get; set; }
        public Candidato Candidato { get; set; }
        public double CalificacionPsicometricos { get; set; }
        public DateTime FechaEntrevista { get; set; }
        public List<object> Entrevistas { get; set; }
    }
}

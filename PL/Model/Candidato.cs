namespace PL.Model
{
    public class Candidato
    {
        public int IdCandidato { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Contacto { get; set; }
        public decimal PretensionEconomica { get; set; }
        public double Promedio { get; set; }
        public Universidad Universidad { get; set; }
    }
}

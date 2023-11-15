namespace PL.Model
{
    public class Curso
    {
        public int couseId { get; set; }
        public DateTime inscripcionDate { get; set; }
        public DateTime certificationDate { get; set; }
        public int advance { get; set; }
        public double scoreCourse { get; set; }
        public string folioCertificate { get; set; }
        public bool anyTest { get; set; }
        public Course course { get; set; }
    }
}

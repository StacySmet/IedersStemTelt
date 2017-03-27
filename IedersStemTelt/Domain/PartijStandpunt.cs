namespace IST.BL.Domain
{
    public class PartijStandpunt
    {
        public int PartijStandpuntId { get; set; }
        public Thema Thema { get; set; }
        public Partij Partij { get; set; }
        public string StandpuntTekst { get; set; }
    }
}
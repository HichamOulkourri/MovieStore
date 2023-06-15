namespace FilmsStoreMvc.Models.Domain
{
    public class Film
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Genre { get; set; }
        public string Duree { get; set; }
        public string Studio { get; set; }
        public int CritiqueScore { get; set; }
        public int AudienceScore { get; set; }

        public string Directeur { get; set; }
        public string ActeurPrincipal { get; set; }



    }
}

namespace DALapex
{
    public static class KarakterProcessor
    {
       /* public static int CreateKarakter(int karakterId, string karakternaam, string karaktersoort)
        {
            KarakterModel data = new KarakterModel //Met DTO oplossen
            {
                KarakterId = karakterId,
                KarakterNaam = karakternaam,
                KarakterSoort = karaktersoort
            };
            string sql = @"insert into dbo.Karakter (KarakterId, KarakterSoort, KarakterNaam)
            values(@KarakterId, @KarakterSoort, @KarakterNaam);";
            return SqlDataAccess.SaveData(sql, data);
        }
        public static List<KarakterModel> LoadKarakters()
        {
            string sql = @"select KarakterId, KarakterSoort, KarakterNaam
            from dbo.Karakter;";
            return SqlDataAccess.LoadData<KarakterModel>(sql);
        }*/
    }
}

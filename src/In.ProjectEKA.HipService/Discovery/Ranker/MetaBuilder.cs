namespace In.ProjectEKA.HipService.Discovery.Ranker
{
    using HipLibrary.Patient.Model;

    public static class MetaBuilder
    {
        public static Meta EmptyMeta => new Meta(Match.Empty.ToString(), MatchLevel.FullMatch);

        private static Meta Meta(string field, MatchLevel matchLevel)
        {
            return new Meta(field, matchLevel);
        }

        public static Meta FullMatchMeta(Match field)
        {
            return Meta(field.ToString(), MatchLevel.FullMatch);
        }
    }
}
namespace X12.Core.Sql.Interfaces
{
    public interface IIdentityProvider
    {
        /// <summary>
        /// Validates the provider's schema and ensures a table exists
        /// </summary>
        void EnsureSchema();

        object NextId(string schema, string table);
    }
}

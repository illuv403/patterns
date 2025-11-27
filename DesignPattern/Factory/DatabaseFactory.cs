namespace DesignPattern.Factory
{
    public static class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType type)
        {
            switch (type) {
                case DatabaseType.Oracle:
                    return new OracleDatabase();
                case DatabaseType.SqlServer:
                    return new SqlServerDatabase();
                default:
                    throw new ArgumentException("Wrong database type given");
            }
        }
    }
}

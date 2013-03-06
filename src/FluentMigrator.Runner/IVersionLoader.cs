namespace FluentMigrator.Runner
{
    public interface IVersionLoader
    {
        bool AlreadyCreatedVersionSchema { get; }
        bool AlreadyCreatedVersionTable { get; }
        void DeleteVersion(long version);
        FluentMigrator.VersionTableInfo.IVersionTableMetaData GetVersionTableMetaData();
        void LoadVersionInfo();
        void RemoveVersionTable();
        IMigrationRunner Runner { get; set; }
        void UpdateVersionInfo(long version);

        //IWT Specific
        void UpdateVersionInfo(long version, int majorVersion, int minorVersion, int branchNumber, int commitNumber);

        FluentMigrator.Runner.Versioning.IVersionInfo VersionInfo { get; set; }
        FluentMigrator.VersionTableInfo.IVersionTableMetaData VersionTableMetaData { get; }
    }
}
// <auto-generated />
namespace Microsoft.Data.Entity.Internal
{
    using System.Diagnostics;
    using System.Globalization;
    using System.Reflection;
    using System.Resources;
    using JetBrains.Annotations;

    public static class SqliteStrings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("EntityFramework.Sqlite.SqliteStrings", typeof(SqliteStrings).GetTypeInfo().Assembly);

        /// <summary>
        /// SQLite cannot support this migration operation.
        /// </summary>
        public static string InvalidMigrationOperation
        {
            get { return GetString("InvalidMigrationOperation"); }
        }

        /// <summary>
        /// Generating idempotent scripts for migration is not currently supported by SQLite.
        /// </summary>
        public static string MigrationScriptGenerationNotSupported
        {
            get { return GetString("MigrationScriptGenerationNotSupported"); }
        }

        /// <summary>
        /// SQLite does not support schemas.
        /// </summary>
        public static string SchemasNotSupported
        {
            get { return GetString("SchemasNotSupported"); }
        }

        /// <summary>
        /// SQLite does not support sequences.
        /// </summary>
        public static string SequencesNotSupported
        {
            get { return GetString("SequencesNotSupported"); }
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}

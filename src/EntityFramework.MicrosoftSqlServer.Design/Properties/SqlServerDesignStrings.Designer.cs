// <auto-generated />
namespace Microsoft.Data.Entity.Internal
{
    using System.Diagnostics;
    using System.Globalization;
    using System.Reflection;
    using System.Resources;
    using JetBrains.Annotations;

    public static class SqlServerDesignStrings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("EntityFramework.MicrosoftSqlServer.Design.SqlServerDesignStrings", typeof(SqlServerDesignStrings).GetTypeInfo().Assembly);

        /// <summary>
        /// Could not find foreignKeyMapping for ConstraintId {constraintId} for FromColumn {fromColumnId}. Skipping generation of ForeignKey.
        /// </summary>
        public static string CannotFindForeignKeyMappingForConstraintId([CanBeNull] object constraintId, [CanBeNull] object fromColumnId)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("CannotFindForeignKeyMappingForConstraintId", "constraintId", "fromColumnId"), constraintId, fromColumnId);
        }

        /// <summary>
        /// For foreign key ConstraintId {constraintId}, could not find relational property mapped to ToColumn {toColumnId}. Skipping generation of ForeignKey.
        /// </summary>
        public static string CannotFindRelationalPropertyForColumnId([CanBeNull] object constraintId, [CanBeNull] object toColumnId)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("CannotFindRelationalPropertyForColumnId", "constraintId", "toColumnId"), constraintId, toColumnId);
        }

        /// <summary>
        /// Unable to interpret the string {sqlServerStringLiteral} as a SQLServer string literal.
        /// </summary>
        public static string CannotInterpretSqlServerStringLiteral([CanBeNull] object sqlServerStringLiteral)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("CannotInterpretSqlServerStringLiteral", "sqlServerStringLiteral"), sqlServerStringLiteral);
        }

        /// <summary>
        /// For column {columnId}. This column is set up as an Identity column, but the SQL Server data type is {sqlServerDataType}. This will be mapped to CLR type byte which does not allow the SqlServerValueGenerationStrategy.IdentityColumn setting. Generating a matching Property but ignoring the Identity setting.
        /// </summary>
        public static string DataTypeDoesNotAllowSqlServerIdentityStrategy([CanBeNull] object columnId, [CanBeNull] object sqlServerDataType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("DataTypeDoesNotAllowSqlServerIdentityStrategy", "columnId", "sqlServerDataType"), columnId, sqlServerDataType);
        }

        /// <summary>
        /// For foreign key constraint {constraintId}.  The target column(s) belong to table [{schemaName}].[{tableName}] which was excluded from code generation.
        /// </summary>
        public static string ForeignKeyTargetTableWasExcluded([CanBeNull] object constraintId, [CanBeNull] object schemaName, [CanBeNull] object tableName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ForeignKeyTargetTableWasExcluded", "constraintId", "schemaName", "tableName"), constraintId, schemaName, tableName);
        }

        /// <summary>
        /// For foreign key constraint {constraintId}. Unable to identify any primary or alternate key on entity type {entityTypeName} for properties {propertyNames}. Skipping generation of ForeignKey.
        /// </summary>
        public static string NoKeyForColumns([CanBeNull] object constraintId, [CanBeNull] object entityTypeName, [CanBeNull] object propertyNames)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("NoKeyForColumns", "constraintId", "entityTypeName", "propertyNames"), constraintId, entityTypeName, propertyNames);
        }

        /// <summary>
        /// Unable to identify any primary key columns in the underlying SQL Server table [{schemaName}].[{tableName}].
        /// </summary>
        public static string NoPrimaryKeyColumns([CanBeNull] object schemaName, [CanBeNull] object tableName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("NoPrimaryKeyColumns", "schemaName", "tableName"), schemaName, tableName);
        }

        /// <summary>
        /// For column {columnId} unable to convert default value {defaultValue} into type {propertyType}. Will not generate code setting a default value for the property {propertyName} on entity type {entityTypeName}.
        /// </summary>
        public static string UnableToConvertDefaultValue([CanBeNull] object columnId, [CanBeNull] object defaultValue, [CanBeNull] object propertyType, [CanBeNull] object propertyName, [CanBeNull] object entityTypeName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("UnableToConvertDefaultValue", "columnId", "defaultValue", "propertyType", "propertyName", "entityTypeName"), columnId, defaultValue, propertyType, propertyName, entityTypeName);
        }

        /// <summary>
        /// For foreign key constraint {constraintId}. Could not find properties mapped to the following columns: {unmappedColumnIds}. Skipping generation of ForeignKey.
        /// </summary>
        public static string UnableToMatchPropertiesForForeignKey([CanBeNull] object constraintId, [CanBeNull] object unmappedColumnIds)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("UnableToMatchPropertiesForForeignKey", "constraintId", "unmappedColumnIds"), constraintId, unmappedColumnIds);
        }

        /// <summary>
        /// For unique constraint {constraintId}. Could not find properties mapped to the following columns: {unmappedColumnIds}. Skipping generation of AlternateKey.
        /// </summary>
        public static string UnableToMatchPropertiesForUniqueKey([CanBeNull] object constraintId, [CanBeNull] object unmappedColumnIds)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("UnableToMatchPropertiesForUniqueKey", "constraintId", "unmappedColumnIds"), constraintId, unmappedColumnIds);
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

using System;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Text;

namespace ElmahEFLogger.CustomElmahLogger
{
    public static class CommandDumper
    {
        public static string LogSqlAndParameters<TResult>(DbCommand command, DbCommandInterceptionContext<TResult> interceptionContext)
        {
            // -- Name: [Value] (Type = {}, Direction = {}, IsNullable = {}, Size = {}, Precision = {} Scale = {})
            var builder = new StringBuilder();

            var commandText = command.CommandText ?? "<null>";
            builder.AppendLine(string.Format("{0}Command: {0}{1}", Environment.NewLine, commandText));

            var parameters = command.Parameters.OfType<DbParameter>().ToList();

            if (parameters.Any())
            {
                builder.AppendLine(string.Format("{0}Parameters: ", Environment.NewLine));
            }

            foreach (var parameter in parameters)
            {
                builder.Append("-- ")
                    .Append(parameter.ParameterName)
                    .Append(": '")
                    .Append((parameter.Value == null || parameter.Value == DBNull.Value) ? "null" : parameter.Value)
                    .Append("' (Type = ")
                    .Append(parameter.DbType);

                if (parameter.Direction != ParameterDirection.Input)
                {
                    builder.Append(", Direction = ").Append(parameter.Direction);
                }

                if (!parameter.IsNullable)
                {
                    builder.Append(", IsNullable = false");
                }

                if (parameter.Size != 0)
                {
                    builder.Append(", Size = ").Append(parameter.Size);
                }

                if (((IDbDataParameter)parameter).Precision != 0)
                {
                    builder.Append(", Precision = ").Append(((IDbDataParameter)parameter).Precision);
                }

                if (((IDbDataParameter)parameter).Scale != 0)
                {
                    builder.Append(", Scale = ").Append(((IDbDataParameter)parameter).Scale);
                }

                builder.Append(")").Append(Environment.NewLine);

            }

            return builder.ToString();
        }
    }
}
using System.Data.Common;
using System.Data.Entity.Infrastructure.Interception;

namespace ElmahEFLogger
{
    public interface IEfExceptionsLogger
    {
        void LogException<TResult>(DbCommand command,
            DbCommandInterceptionContext<TResult> interceptionContext);
    }
}
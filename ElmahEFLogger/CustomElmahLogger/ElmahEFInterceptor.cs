namespace ElmahEFLogger.CustomElmahLogger
{
    public class ElmahEfInterceptor : EfExceptionsInterceptor
    {
        public ElmahEfInterceptor()
            : base(new ElmahEfExceptionsLogger())
        { }
    }
}
using System;
using System.Runtime.ExceptionServices;
using static OcaBorracha.result.Result_T;

namespace OcaBorracha.result
{
    public static class Result_Bind
    {
        public static Result<U> Bind<T, U>(this Result<T> r, Func<T, Result<U>> method)
        {
            try
            {
                return r.Success
                    ? method(r.Value)
                    : Result.Failure<U>(r.Errors);
            }
            catch (Exception e)
            {
                ExceptionDispatchInfo.Capture(e).Throw();
                throw;
            }
        }
    }
}
namespace IlWeavingWithMrAdvice;

public class FileThatBreaks
{
    [FileToControlExceptionAdvice]
    public void MethodthatBreaks()
    {
        throw new NotImplementedException();
    }
}

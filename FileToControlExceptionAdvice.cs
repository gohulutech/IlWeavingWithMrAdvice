using ArxOne.MrAdvice.Advice;

namespace IlWeavingWithMrAdvice;

public class FileToControlExceptionAdvice : Attribute, IMethodAdvice
{
    public void Advise(MethodAdviceContext context)
    {
        try
        {
            context.Proceed();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

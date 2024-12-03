using sorovi.DependencyInjection.AutoRegister;

namespace Sol_Auto_DI_Register_WebAPI.Services;

public interface ISingletonDemo
{
    void DoSomething();
}

[SingletonService(typeof(ISingletonDemo))]
public class SingletonDemo : ISingletonDemo
{
    void ISingletonDemo.DoSomething()
    {
        Console.WriteLine("SingletonDemo");
    }
}

public interface IScopedDemo
{
    void DoSomething();
}

[ScopedService(typeof(IScopedDemo))]
public class ScopedDemo : IScopedDemo
{
    void IScopedDemo.DoSomething()
    {
        Console.WriteLine("ScopedDemo");
    }
}

public interface ITransientDemo
{
    void DoSomething();
}

[TransientService(typeof(ITransientDemo))]
public class TransientDemo : ITransientDemo
{
    void ITransientDemo.DoSomething()
    {
        throw new NotImplementedException();
    }
}
using AutoDependencyRegistration.Attributes;

namespace Sol_Auto_DI_Register_WebAPI.Services;

public interface ISingletonDemo
{
    void DoSomething();
}

[RegisterClassAsSingleton]
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

[RegisterClassAsScoped]
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

[RegisterClassAsTransient]
public class TransientDemo : ITransientDemo
{
    void ITransientDemo.DoSomething()
    {
        throw new NotImplementedException();
    }
}
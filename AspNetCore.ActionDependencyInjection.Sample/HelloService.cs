namespace AspNetCore.ActionDependencyInjection.Sample
{
    public class HelloService : IHelloService
    {
        public string SayHello() => "Hello";
    }
}

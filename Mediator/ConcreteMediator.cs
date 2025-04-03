using design_pattern_mediator.Components;

namespace design_pattern_mediator.Mediator;

/// <summary>
/// Implementa o comportamento do Mediator para coordenar os componentes
/// </summary>
internal class ConcreteMediator : IMediator
{
    private Component1 _component1;
    private Component2 _component2;

    /// <summary>
    /// Estabelece uma relação bidirecional fazendo com que os componentes conheçam o
    /// mediador e o mediador conheça os componentes.
    /// </summary>
    /// <param name="component1"></param>
    /// <param name="component2"></param>
    public ConcreteMediator(Component1 component1, Component2 component2)
    {
        _component1 = component1;
        _component1.SetMediator(this); //Registra o mediator no componente

        _component2 = component2;
        _component2.SetMediator(this); //Registra o mediator no componente
    }

    /// <summary>
    /// Implementa o método de notificação
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="ev"></param>
    public void Notify(object sender, string ev)
    {
        if (ev == "A")
        {
            Console.WriteLine("Mediator reacts on A and triggers following operations:");
            _component2.DoC();
        }
        if (ev == "D")
        {
            Console.WriteLine("Mediator reacts on D and triggers following operations:");
            _component1.DoB();
            _component2.DoC();
        }
    }
}

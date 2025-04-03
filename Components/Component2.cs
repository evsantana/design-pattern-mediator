namespace design_pattern_mediator.Components;

/// <summary>
/// Componentes não dependem de outros componentes e de nenhuma classe mediadora concreta.
/// </summary>
internal class Component2 : BaseComponent
{
    public void DoC()
    {
        Console.WriteLine("Component 2 does C");
        _mediator.Notify(this, "C");
    }

    public void DoD()
    {
        Console.WriteLine("Component 2 does C.");
        _mediator.Notify(this, "C");
    }
}

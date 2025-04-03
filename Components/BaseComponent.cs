using design_pattern_mediator.Mediator;

namespace design_pattern_mediator.Components;

/// <summary>
/// Adiciona a interface do Mediator dentro dos componentes
/// </summary>
class BaseComponent
{
    protected IMediator _mediator;

    public BaseComponent(IMediator mediator = null)
    {
        _mediator = mediator;
    }

    public void SetMediator(IMediator mediator)
    {
        _mediator = mediator;
    }
}

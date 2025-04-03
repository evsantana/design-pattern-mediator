namespace design_pattern_mediator.Mediator;

/// <summary>
/// Interface de notificação usada para notificar o Mediator sobre os eventos
/// </summary>
internal interface IMediator
{
    void Notify(object sender, string ev);
}

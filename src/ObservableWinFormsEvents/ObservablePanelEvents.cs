namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on Panel.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservablePanelEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the AutoSizeChanged event on the Panel instance.
    /// </summary>
    /// <param name="instance">The Panel instance to observe.</param>
    /// <returns>An observable sequence wrapping the AutoSizeChanged event on the Panel instance.</returns>
    public static IObservable<EventPattern<EventArgs>> AutoSizeChangedObservable(this Panel instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.AutoSizeChanged += handler,
            handler => instance.AutoSizeChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the KeyUp event on the Panel instance.
    /// </summary>
    /// <param name="instance">The Panel instance to observe.</param>
    /// <returns>An observable sequence wrapping the KeyUp event on the Panel instance.</returns>
    public static IObservable<EventPattern<KeyEventArgs>> KeyUpObservable(this Panel instance)
    {
        return Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(
            handler => instance.KeyUp += handler,
            handler => instance.KeyUp -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the KeyDown event on the Panel instance.
    /// </summary>
    /// <param name="instance">The Panel instance to observe.</param>
    /// <returns>An observable sequence wrapping the KeyDown event on the Panel instance.</returns>
    public static IObservable<EventPattern<KeyEventArgs>> KeyDownObservable(this Panel instance)
    {
        return Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(
            handler => instance.KeyDown += handler,
            handler => instance.KeyDown -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the KeyPress event on the Panel instance.
    /// </summary>
    /// <param name="instance">The Panel instance to observe.</param>
    /// <returns>An observable sequence wrapping the KeyPress event on the Panel instance.</returns>
    public static IObservable<EventPattern<KeyPressEventArgs>> KeyPressObservable(this Panel instance)
    {
        return Observable.FromEventPattern<KeyPressEventHandler, KeyPressEventArgs>(
            handler => instance.KeyPress += handler,
            handler => instance.KeyPress -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the TextChanged event on the Panel instance.
    /// </summary>
    /// <param name="instance">The Panel instance to observe.</param>
    /// <returns>An observable sequence wrapping the TextChanged event on the Panel instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TextChangedObservable(this Panel instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.TextChanged += handler,
            handler => instance.TextChanged -= handler);
    }
}

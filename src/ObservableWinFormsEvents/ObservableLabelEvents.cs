namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on Label.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableLabelEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the AutoSizeChanged event on the Label instance.
    /// </summary>
    /// <param name="instance">The Label instance to observe.</param>
    /// <returns>An observable sequence wrapping the AutoSizeChanged event on the Label instance.</returns>
    public static IObservable<EventPattern<EventArgs>> AutoSizeChangedObservable(this Label instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.AutoSizeChanged += handler,
            handler => instance.AutoSizeChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the BackgroundImageChanged event on the Label instance.
    /// </summary>
    /// <param name="instance">The Label instance to observe.</param>
    /// <returns>An observable sequence wrapping the BackgroundImageChanged event on the Label instance.</returns>
    public static IObservable<EventPattern<EventArgs>> BackgroundImageChangedObservable(this Label instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.BackgroundImageChanged += handler,
            handler => instance.BackgroundImageChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the BackgroundImageLayoutChanged event on the Label instance.
    /// </summary>
    /// <param name="instance">The Label instance to observe.</param>
    /// <returns>An observable sequence wrapping the BackgroundImageLayoutChanged event on the Label instance.</returns>
    public static IObservable<EventPattern<EventArgs>> BackgroundImageLayoutChangedObservable(this Label instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.BackgroundImageLayoutChanged += handler,
            handler => instance.BackgroundImageLayoutChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ImeModeChanged event on the Label instance.
    /// </summary>
    /// <param name="instance">The Label instance to observe.</param>
    /// <returns>An observable sequence wrapping the ImeModeChanged event on the Label instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ImeModeChangedObservable(this Label instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.ImeModeChanged += handler,
            handler => instance.ImeModeChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the KeyUp event on the Label instance.
    /// </summary>
    /// <param name="instance">The Label instance to observe.</param>
    /// <returns>An observable sequence wrapping the KeyUp event on the Label instance.</returns>
    public static IObservable<EventPattern<KeyEventArgs>> KeyUpObservable(this Label instance)
    {
        return Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(
            handler => instance.KeyUp += handler,
            handler => instance.KeyUp -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the KeyDown event on the Label instance.
    /// </summary>
    /// <param name="instance">The Label instance to observe.</param>
    /// <returns>An observable sequence wrapping the KeyDown event on the Label instance.</returns>
    public static IObservable<EventPattern<KeyEventArgs>> KeyDownObservable(this Label instance)
    {
        return Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(
            handler => instance.KeyDown += handler,
            handler => instance.KeyDown -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the KeyPress event on the Label instance.
    /// </summary>
    /// <param name="instance">The Label instance to observe.</param>
    /// <returns>An observable sequence wrapping the KeyPress event on the Label instance.</returns>
    public static IObservable<EventPattern<KeyPressEventArgs>> KeyPressObservable(this Label instance)
    {
        return Observable.FromEventPattern<KeyPressEventHandler, KeyPressEventArgs>(
            handler => instance.KeyPress += handler,
            handler => instance.KeyPress -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the TabStopChanged event on the Label instance.
    /// </summary>
    /// <param name="instance">The Label instance to observe.</param>
    /// <returns>An observable sequence wrapping the TabStopChanged event on the Label instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TabStopChangedObservable(this Label instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.TabStopChanged += handler,
            handler => instance.TabStopChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the TextAlignChanged event on the Label instance.
    /// </summary>
    /// <param name="instance">The Label instance to observe.</param>
    /// <returns>An observable sequence wrapping the TextAlignChanged event on the Label instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TextAlignChangedObservable(this Label instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.TextAlignChanged += handler,
            handler => instance.TextAlignChanged -= handler);
    }
}

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on UpDownBase.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableUpDownBaseEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the AutoSizeChanged event on the UpDownBase instance.
    /// </summary>
    /// <param name="instance">The UpDownBase instance to observe.</param>
    /// <returns>An observable sequence wrapping the AutoSizeChanged event on the UpDownBase instance.</returns>
    public static IObservable<EventPattern<EventArgs>> AutoSizeChangedObservable(this UpDownBase instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.AutoSizeChanged += handler,
            handler => instance.AutoSizeChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the BackgroundImageChanged event on the UpDownBase instance.
    /// </summary>
    /// <param name="instance">The UpDownBase instance to observe.</param>
    /// <returns>An observable sequence wrapping the BackgroundImageChanged event on the UpDownBase instance.</returns>
    public static IObservable<EventPattern<EventArgs>> BackgroundImageChangedObservable(this UpDownBase instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.BackgroundImageChanged += handler,
            handler => instance.BackgroundImageChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the BackgroundImageLayoutChanged event on the UpDownBase instance.
    /// </summary>
    /// <param name="instance">The UpDownBase instance to observe.</param>
    /// <returns>An observable sequence wrapping the BackgroundImageLayoutChanged event on the UpDownBase instance.</returns>
    public static IObservable<EventPattern<EventArgs>> BackgroundImageLayoutChangedObservable(this UpDownBase instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.BackgroundImageLayoutChanged += handler,
            handler => instance.BackgroundImageLayoutChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MouseEnter event on the UpDownBase instance.
    /// </summary>
    /// <param name="instance">The UpDownBase instance to observe.</param>
    /// <returns>An observable sequence wrapping the MouseEnter event on the UpDownBase instance.</returns>
    public static IObservable<EventPattern<EventArgs>> MouseEnterObservable(this UpDownBase instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.MouseEnter += handler,
            handler => instance.MouseEnter -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MouseLeave event on the UpDownBase instance.
    /// </summary>
    /// <param name="instance">The UpDownBase instance to observe.</param>
    /// <returns>An observable sequence wrapping the MouseLeave event on the UpDownBase instance.</returns>
    public static IObservable<EventPattern<EventArgs>> MouseLeaveObservable(this UpDownBase instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.MouseLeave += handler,
            handler => instance.MouseLeave -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MouseHover event on the UpDownBase instance.
    /// </summary>
    /// <param name="instance">The UpDownBase instance to observe.</param>
    /// <returns>An observable sequence wrapping the MouseHover event on the UpDownBase instance.</returns>
    public static IObservable<EventPattern<EventArgs>> MouseHoverObservable(this UpDownBase instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.MouseHover += handler,
            handler => instance.MouseHover -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MouseMove event on the UpDownBase instance.
    /// </summary>
    /// <param name="instance">The UpDownBase instance to observe.</param>
    /// <returns>An observable sequence wrapping the MouseMove event on the UpDownBase instance.</returns>
    public static IObservable<EventPattern<MouseEventArgs>> MouseMoveObservable(this UpDownBase instance)
    {
        return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
            handler => instance.MouseMove += handler,
            handler => instance.MouseMove -= handler);
    }
}

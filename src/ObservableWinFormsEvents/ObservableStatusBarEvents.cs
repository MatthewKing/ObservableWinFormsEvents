#if NETFRAMEWORK

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on StatusBar.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableStatusBarEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the BackColorChanged event on the StatusBar instance.
    /// </summary>
    /// <param name="instance">The StatusBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the BackColorChanged event on the StatusBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> BackColorChangedObservable(this StatusBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.BackColorChanged += handler,
            handler => instance.BackColorChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the BackgroundImageChanged event on the StatusBar instance.
    /// </summary>
    /// <param name="instance">The StatusBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the BackgroundImageChanged event on the StatusBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> BackgroundImageChangedObservable(this StatusBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.BackgroundImageChanged += handler,
            handler => instance.BackgroundImageChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the BackgroundImageLayoutChanged event on the StatusBar instance.
    /// </summary>
    /// <param name="instance">The StatusBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the BackgroundImageLayoutChanged event on the StatusBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> BackgroundImageLayoutChangedObservable(this StatusBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.BackgroundImageLayoutChanged += handler,
            handler => instance.BackgroundImageLayoutChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ForeColorChanged event on the StatusBar instance.
    /// </summary>
    /// <param name="instance">The StatusBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the ForeColorChanged event on the StatusBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ForeColorChangedObservable(this StatusBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.ForeColorChanged += handler,
            handler => instance.ForeColorChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ImeModeChanged event on the StatusBar instance.
    /// </summary>
    /// <param name="instance">The StatusBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the ImeModeChanged event on the StatusBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ImeModeChangedObservable(this StatusBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.ImeModeChanged += handler,
            handler => instance.ImeModeChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the DrawItem event on the StatusBar instance.
    /// </summary>
    /// <param name="instance">The StatusBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the DrawItem event on the StatusBar instance.</returns>
    public static IObservable<EventPattern<StatusBarDrawItemEventArgs>> DrawItemObservable(this StatusBar instance)
    {
        return Observable.FromEventPattern<StatusBarDrawItemEventHandler, StatusBarDrawItemEventArgs>(
            handler => instance.DrawItem += handler,
            handler => instance.DrawItem -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the PanelClick event on the StatusBar instance.
    /// </summary>
    /// <param name="instance">The StatusBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the PanelClick event on the StatusBar instance.</returns>
    public static IObservable<EventPattern<StatusBarPanelClickEventArgs>> PanelClickObservable(this StatusBar instance)
    {
        return Observable.FromEventPattern<StatusBarPanelClickEventHandler, StatusBarPanelClickEventArgs>(
            handler => instance.PanelClick += handler,
            handler => instance.PanelClick -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Paint event on the StatusBar instance.
    /// </summary>
    /// <param name="instance">The StatusBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the Paint event on the StatusBar instance.</returns>
    public static IObservable<EventPattern<PaintEventArgs>> PaintObservable(this StatusBar instance)
    {
        return Observable.FromEventPattern<PaintEventHandler, PaintEventArgs>(
            handler => instance.Paint += handler,
            handler => instance.Paint -= handler);
    }
}

#endif

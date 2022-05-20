#if NETFRAMEWORK

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on MainMenu.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableMainMenuEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the Collapse event on the MainMenu instance.
    /// </summary>
    /// <param name="instance">The MainMenu instance to observe.</param>
    /// <returns>An observable sequence wrapping the Collapse event on the MainMenu instance.</returns>
    public static IObservable<EventPattern<EventArgs>> CollapseObservable(this MainMenu instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.Collapse += handler,
            handler => instance.Collapse -= handler);
    }
}

#endif

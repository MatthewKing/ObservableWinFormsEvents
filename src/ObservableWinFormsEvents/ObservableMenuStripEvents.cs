using System;
using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on MenuStrip.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableMenuStripEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the MenuActivate event on the MenuStrip instance.
    /// </summary>
    /// <param name="instance">The MenuStrip instance to observe.</param>
    /// <returns>An observable sequence wrapping the MenuActivate event on the MenuStrip instance.</returns>
    public static IObservable<EventPattern<EventArgs>> MenuActivateObservable(this MenuStrip instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.MenuActivate += handler,
            handler => instance.MenuActivate -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MenuDeactivate event on the MenuStrip instance.
    /// </summary>
    /// <param name="instance">The MenuStrip instance to observe.</param>
    /// <returns>An observable sequence wrapping the MenuDeactivate event on the MenuStrip instance.</returns>
    public static IObservable<EventPattern<EventArgs>> MenuDeactivateObservable(this MenuStrip instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.MenuDeactivate += handler,
            handler => instance.MenuDeactivate -= handler);
    }
}

using System;
using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on ThreadExceptionDialog.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableThreadExceptionDialogEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the AutoSizeChanged event on the ThreadExceptionDialog instance.
    /// </summary>
    /// <param name="instance">The ThreadExceptionDialog instance to observe.</param>
    /// <returns>An observable sequence wrapping the AutoSizeChanged event on the ThreadExceptionDialog instance.</returns>
    public static IObservable<EventPattern<EventArgs>> AutoSizeChangedObservable(this ThreadExceptionDialog instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.AutoSizeChanged += handler,
            handler => instance.AutoSizeChanged -= handler);
    }
}

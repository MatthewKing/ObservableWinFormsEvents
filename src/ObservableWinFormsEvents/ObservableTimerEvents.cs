using System;
using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on Timer.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableTimerEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the Tick event on the Timer instance.
    /// </summary>
    /// <param name="instance">The Timer instance to observe.</param>
    /// <returns>An observable sequence wrapping the Tick event on the Timer instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TickObservable(this Timer instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.Tick += handler,
            handler => instance.Tick -= handler);
    }
}

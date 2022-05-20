using System;
using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on RadioButton.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableRadioButtonEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the AppearanceChanged event on the RadioButton instance.
    /// </summary>
    /// <param name="instance">The RadioButton instance to observe.</param>
    /// <returns>An observable sequence wrapping the AppearanceChanged event on the RadioButton instance.</returns>
    public static IObservable<EventPattern<EventArgs>> AppearanceChangedObservable(this RadioButton instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.AppearanceChanged += handler,
            handler => instance.AppearanceChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the DoubleClick event on the RadioButton instance.
    /// </summary>
    /// <param name="instance">The RadioButton instance to observe.</param>
    /// <returns>An observable sequence wrapping the DoubleClick event on the RadioButton instance.</returns>
    public static IObservable<EventPattern<EventArgs>> DoubleClickObservable(this RadioButton instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.DoubleClick += handler,
            handler => instance.DoubleClick -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MouseDoubleClick event on the RadioButton instance.
    /// </summary>
    /// <param name="instance">The RadioButton instance to observe.</param>
    /// <returns>An observable sequence wrapping the MouseDoubleClick event on the RadioButton instance.</returns>
    public static IObservable<EventPattern<MouseEventArgs>> MouseDoubleClickObservable(this RadioButton instance)
    {
        return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
            handler => instance.MouseDoubleClick += handler,
            handler => instance.MouseDoubleClick -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the CheckedChanged event on the RadioButton instance.
    /// </summary>
    /// <param name="instance">The RadioButton instance to observe.</param>
    /// <returns>An observable sequence wrapping the CheckedChanged event on the RadioButton instance.</returns>
    public static IObservable<EventPattern<EventArgs>> CheckedChangedObservable(this RadioButton instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.CheckedChanged += handler,
            handler => instance.CheckedChanged -= handler);
    }
}

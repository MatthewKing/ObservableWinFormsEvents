using System;
using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on UserControl.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableUserControlEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the AutoSizeChanged event on the UserControl instance.
    /// </summary>
    /// <param name="instance">The UserControl instance to observe.</param>
    /// <returns>An observable sequence wrapping the AutoSizeChanged event on the UserControl instance.</returns>
    public static IObservable<EventPattern<EventArgs>> AutoSizeChangedObservable(this UserControl instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.AutoSizeChanged += handler,
            handler => instance.AutoSizeChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the AutoValidateChanged event on the UserControl instance.
    /// </summary>
    /// <param name="instance">The UserControl instance to observe.</param>
    /// <returns>An observable sequence wrapping the AutoValidateChanged event on the UserControl instance.</returns>
    public static IObservable<EventPattern<EventArgs>> AutoValidateChangedObservable(this UserControl instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.AutoValidateChanged += handler,
            handler => instance.AutoValidateChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Load event on the UserControl instance.
    /// </summary>
    /// <param name="instance">The UserControl instance to observe.</param>
    /// <returns>An observable sequence wrapping the Load event on the UserControl instance.</returns>
    public static IObservable<EventPattern<EventArgs>> LoadObservable(this UserControl instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.Load += handler,
            handler => instance.Load -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the TextChanged event on the UserControl instance.
    /// </summary>
    /// <param name="instance">The UserControl instance to observe.</param>
    /// <returns>An observable sequence wrapping the TextChanged event on the UserControl instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TextChangedObservable(this UserControl instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.TextChanged += handler,
            handler => instance.TextChanged -= handler);
    }
}

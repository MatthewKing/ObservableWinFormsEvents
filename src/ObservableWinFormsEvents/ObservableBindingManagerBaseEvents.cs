using System;
using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on BindingManagerBase.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableBindingManagerBaseEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the BindingComplete event on the BindingManagerBase instance.
    /// </summary>
    /// <param name="instance">The BindingManagerBase instance to observe.</param>
    /// <returns>An observable sequence wrapping the BindingComplete event on the BindingManagerBase instance.</returns>
    public static IObservable<EventPattern<BindingCompleteEventArgs>> BindingCompleteObservable(this BindingManagerBase instance)
    {
        return Observable.FromEventPattern<BindingCompleteEventHandler, BindingCompleteEventArgs>(
            handler => instance.BindingComplete += handler,
            handler => instance.BindingComplete -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the CurrentChanged event on the BindingManagerBase instance.
    /// </summary>
    /// <param name="instance">The BindingManagerBase instance to observe.</param>
    /// <returns>An observable sequence wrapping the CurrentChanged event on the BindingManagerBase instance.</returns>
    public static IObservable<EventPattern<EventArgs>> CurrentChangedObservable(this BindingManagerBase instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.CurrentChanged += handler,
            handler => instance.CurrentChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the CurrentItemChanged event on the BindingManagerBase instance.
    /// </summary>
    /// <param name="instance">The BindingManagerBase instance to observe.</param>
    /// <returns>An observable sequence wrapping the CurrentItemChanged event on the BindingManagerBase instance.</returns>
    public static IObservable<EventPattern<EventArgs>> CurrentItemChangedObservable(this BindingManagerBase instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.CurrentItemChanged += handler,
            handler => instance.CurrentItemChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the DataError event on the BindingManagerBase instance.
    /// </summary>
    /// <param name="instance">The BindingManagerBase instance to observe.</param>
    /// <returns>An observable sequence wrapping the DataError event on the BindingManagerBase instance.</returns>
    public static IObservable<EventPattern<BindingManagerDataErrorEventArgs>> DataErrorObservable(this BindingManagerBase instance)
    {
        return Observable.FromEventPattern<BindingManagerDataErrorEventHandler, BindingManagerDataErrorEventArgs>(
            handler => instance.DataError += handler,
            handler => instance.DataError -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the PositionChanged event on the BindingManagerBase instance.
    /// </summary>
    /// <param name="instance">The BindingManagerBase instance to observe.</param>
    /// <returns>An observable sequence wrapping the PositionChanged event on the BindingManagerBase instance.</returns>
    public static IObservable<EventPattern<EventArgs>> PositionChangedObservable(this BindingManagerBase instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.PositionChanged += handler,
            handler => instance.PositionChanged -= handler);
    }
}

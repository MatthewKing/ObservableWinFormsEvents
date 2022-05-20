using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on Binding.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableBindingEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the BindingComplete event on the Binding instance.
    /// </summary>
    /// <param name="instance">The Binding instance to observe.</param>
    /// <returns>An observable sequence wrapping the BindingComplete event on the Binding instance.</returns>
    public static IObservable<EventPattern<BindingCompleteEventArgs>> BindingCompleteObservable(this Binding instance)
    {
        return Observable.FromEventPattern<BindingCompleteEventHandler, BindingCompleteEventArgs>(
            handler => instance.BindingComplete += handler,
            handler => instance.BindingComplete -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Parse event on the Binding instance.
    /// </summary>
    /// <param name="instance">The Binding instance to observe.</param>
    /// <returns>An observable sequence wrapping the Parse event on the Binding instance.</returns>
    public static IObservable<EventPattern<ConvertEventArgs>> ParseObservable(this Binding instance)
    {
        return Observable.FromEventPattern<ConvertEventHandler, ConvertEventArgs>(
            handler => instance.Parse += handler,
            handler => instance.Parse -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Format event on the Binding instance.
    /// </summary>
    /// <param name="instance">The Binding instance to observe.</param>
    /// <returns>An observable sequence wrapping the Format event on the Binding instance.</returns>
    public static IObservable<EventPattern<ConvertEventArgs>> FormatObservable(this Binding instance)
    {
        return Observable.FromEventPattern<ConvertEventHandler, ConvertEventArgs>(
            handler => instance.Format += handler,
            handler => instance.Format -= handler);
    }
}

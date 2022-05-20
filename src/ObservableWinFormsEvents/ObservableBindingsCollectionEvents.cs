using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on BindingsCollection.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableBindingsCollectionEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the CollectionChanging event on the BindingsCollection instance.
    /// </summary>
    /// <param name="instance">The BindingsCollection instance to observe.</param>
    /// <returns>An observable sequence wrapping the CollectionChanging event on the BindingsCollection instance.</returns>
    public static IObservable<EventPattern<CollectionChangeEventArgs>> CollectionChangingObservable(this BindingsCollection instance)
    {
        return Observable.FromEventPattern<CollectionChangeEventHandler, CollectionChangeEventArgs>(
            handler => instance.CollectionChanging += handler,
            handler => instance.CollectionChanging -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the CollectionChanged event on the BindingsCollection instance.
    /// </summary>
    /// <param name="instance">The BindingsCollection instance to observe.</param>
    /// <returns>An observable sequence wrapping the CollectionChanged event on the BindingsCollection instance.</returns>
    public static IObservable<EventPattern<CollectionChangeEventArgs>> CollectionChangedObservable(this BindingsCollection instance)
    {
        return Observable.FromEventPattern<CollectionChangeEventHandler, CollectionChangeEventArgs>(
            handler => instance.CollectionChanged += handler,
            handler => instance.CollectionChanged -= handler);
    }
}

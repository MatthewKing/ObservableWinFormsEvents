using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;

#if NETFRAMEWORK

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on GridTableStylesCollection.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableGridTableStylesCollectionEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the CollectionChanged event on the GridTableStylesCollection instance.
    /// </summary>
    /// <param name="instance">The GridTableStylesCollection instance to observe.</param>
    /// <returns>An observable sequence wrapping the CollectionChanged event on the GridTableStylesCollection instance.</returns>
    public static IObservable<EventPattern<CollectionChangeEventArgs>> CollectionChangedObservable(this GridTableStylesCollection instance)
    {
        return Observable.FromEventPattern<CollectionChangeEventHandler, CollectionChangeEventArgs>(
            handler => instance.CollectionChanged += handler,
            handler => instance.CollectionChanged -= handler);
    }
}

#endif

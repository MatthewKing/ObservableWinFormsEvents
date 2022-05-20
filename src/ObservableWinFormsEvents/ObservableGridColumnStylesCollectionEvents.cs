using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;

#if NETFRAMEWORK

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on GridColumnStylesCollection.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableGridColumnStylesCollectionEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the CollectionChanged event on the GridColumnStylesCollection instance.
    /// </summary>
    /// <param name="instance">The GridColumnStylesCollection instance to observe.</param>
    /// <returns>An observable sequence wrapping the CollectionChanged event on the GridColumnStylesCollection instance.</returns>
    public static IObservable<EventPattern<CollectionChangeEventArgs>> CollectionChangedObservable(this GridColumnStylesCollection instance)
    {
        return Observable.FromEventPattern<CollectionChangeEventHandler, CollectionChangeEventArgs>(
            handler => instance.CollectionChanged += handler,
            handler => instance.CollectionChanged -= handler);
    }
}

#endif

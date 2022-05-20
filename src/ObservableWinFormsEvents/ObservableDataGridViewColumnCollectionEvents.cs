namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on DataGridViewColumnCollection.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableDataGridViewColumnCollectionEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the CollectionChanged event on the DataGridViewColumnCollection instance.
    /// </summary>
    /// <param name="instance">The DataGridViewColumnCollection instance to observe.</param>
    /// <returns>An observable sequence wrapping the CollectionChanged event on the DataGridViewColumnCollection instance.</returns>
    public static IObservable<EventPattern<CollectionChangeEventArgs>> CollectionChangedObservable(this DataGridViewColumnCollection instance)
    {
        return Observable.FromEventPattern<CollectionChangeEventHandler, CollectionChangeEventArgs>(
            handler => instance.CollectionChanged += handler,
            handler => instance.CollectionChanged -= handler);
    }
}

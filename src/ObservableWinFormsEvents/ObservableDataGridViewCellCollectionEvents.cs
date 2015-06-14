namespace System.Windows.Forms
{
    using System.ComponentModel;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on DataGridViewCellCollection.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class ObservableDataGridViewCellCollectionEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the CollectionChanged event on the DataGridViewCellCollection instance.
        /// </summary>
        /// <param name="instance">The DataGridViewCellCollection instance to observe.</param>
        /// <returns>An observable sequence wrapping the CollectionChanged event on the DataGridViewCellCollection instance.</returns>
        public static IObservable<EventPattern<CollectionChangeEventArgs>> CollectionChangedObservable(this DataGridViewCellCollection instance)
        {
            return Observable.FromEventPattern<CollectionChangeEventHandler, CollectionChangeEventArgs>(
                handler => instance.CollectionChanged += handler,
                handler => instance.CollectionChanged -= handler);
        }
    }
}

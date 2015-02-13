namespace System.Windows.Forms
{
    using System.ComponentModel;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on DataGridViewRowCollection.
    /// </summary>
    public static class ObservableDataGridViewRowCollectionEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the CollectionChanged event on the DataGridViewRowCollection instance.
        /// </summary>
        /// <param name="instance">The DataGridViewRowCollection instance to observe.</param>
        /// <returns>An observable sequence wrapping the CollectionChanged event on the DataGridViewRowCollection instance.</returns>
        public static IObservable<EventPattern<CollectionChangeEventArgs>> CollectionChangedObservable(this DataGridViewRowCollection instance)
        {
            return Observable.FromEventPattern<CollectionChangeEventHandler, CollectionChangeEventArgs>(
                handler => instance.CollectionChanged += handler,
                handler => instance.CollectionChanged -= handler);
        }
    }
}

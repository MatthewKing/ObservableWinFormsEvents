namespace System.Windows.Forms
{
    using System.ComponentModel;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on AutoCompleteStringCollection.
    /// </summary>
    public static class ObservableAutoCompleteStringCollectionEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the CollectionChanged event on the AutoCompleteStringCollection instance.
        /// </summary>
        /// <param name="instance">The AutoCompleteStringCollection instance to observe.</param>
        /// <returns>An observable sequence wrapping the CollectionChanged event on the AutoCompleteStringCollection instance.</returns>
        public static IObservable<EventPattern<CollectionChangeEventArgs>> CollectionChangedObservable(this AutoCompleteStringCollection instance)
        {
            return Observable.FromEventPattern<CollectionChangeEventHandler, CollectionChangeEventArgs>(
                handler => instance.CollectionChanged += handler,
                handler => instance.CollectionChanged -= handler);
        }
    }
}

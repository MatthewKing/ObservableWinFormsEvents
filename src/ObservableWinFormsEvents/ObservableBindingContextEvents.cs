namespace System.Windows.Forms
{
    using System.ComponentModel;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on BindingContext.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class ObservableBindingContextEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the CollectionChanged event on the BindingContext instance.
        /// </summary>
        /// <param name="instance">The BindingContext instance to observe.</param>
        /// <returns>An observable sequence wrapping the CollectionChanged event on the BindingContext instance.</returns>
        public static IObservable<EventPattern<CollectionChangeEventArgs>> CollectionChangedObservable(this BindingContext instance)
        {
            return Observable.FromEventPattern<CollectionChangeEventHandler, CollectionChangeEventArgs>(
                handler => instance.CollectionChanged += handler,
                handler => instance.CollectionChanged -= handler);
        }
    }
}

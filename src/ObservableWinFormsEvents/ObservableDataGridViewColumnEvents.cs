namespace System.Windows.Forms
{
    using System;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on DataGridViewColumn.
    /// </summary>
    public static class ObservableDataGridViewColumnEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the Disposed event on the DataGridViewColumn instance.
        /// </summary>
        /// <param name="instance">The DataGridViewColumn instance to observe.</param>
        /// <returns>An observable sequence wrapping the Disposed event on the DataGridViewColumn instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DisposedObservable(this DataGridViewColumn instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Disposed += handler,
                handler => instance.Disposed -= handler);
        }
    }
}

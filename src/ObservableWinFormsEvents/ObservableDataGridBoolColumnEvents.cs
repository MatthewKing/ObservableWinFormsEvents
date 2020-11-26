#if NETFRAMEWORK

namespace System.Windows.Forms
{
    using System;
    using System.ComponentModel;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on DataGridBoolColumn.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class ObservableDataGridBoolColumnEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the TrueValueChanged event on the DataGridBoolColumn instance.
        /// </summary>
        /// <param name="instance">The DataGridBoolColumn instance to observe.</param>
        /// <returns>An observable sequence wrapping the TrueValueChanged event on the DataGridBoolColumn instance.</returns>
        public static IObservable<EventPattern<EventArgs>> TrueValueChangedObservable(this DataGridBoolColumn instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.TrueValueChanged += handler,
                handler => instance.TrueValueChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the FalseValueChanged event on the DataGridBoolColumn instance.
        /// </summary>
        /// <param name="instance">The DataGridBoolColumn instance to observe.</param>
        /// <returns>An observable sequence wrapping the FalseValueChanged event on the DataGridBoolColumn instance.</returns>
        public static IObservable<EventPattern<EventArgs>> FalseValueChangedObservable(this DataGridBoolColumn instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.FalseValueChanged += handler,
                handler => instance.FalseValueChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the AllowNullChanged event on the DataGridBoolColumn instance.
        /// </summary>
        /// <param name="instance">The DataGridBoolColumn instance to observe.</param>
        /// <returns>An observable sequence wrapping the AllowNullChanged event on the DataGridBoolColumn instance.</returns>
        public static IObservable<EventPattern<EventArgs>> AllowNullChangedObservable(this DataGridBoolColumn instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.AllowNullChanged += handler,
                handler => instance.AllowNullChanged -= handler);
        }
    }
}

#endif

namespace System.Windows.Forms
{
    using System;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on ToolStripButton.
    /// </summary>
    public static class ObservableToolStripButtonEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the CheckedChanged event on the ToolStripButton instance.
        /// </summary>
        /// <param name="instance">The ToolStripButton instance to observe.</param>
        /// <returns>An observable sequence wrapping the CheckedChanged event on the ToolStripButton instance.</returns>
        public static IObservable<EventPattern<EventArgs>> CheckedChangedObservable(this ToolStripButton instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.CheckedChanged += handler,
                handler => instance.CheckedChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CheckStateChanged event on the ToolStripButton instance.
        /// </summary>
        /// <param name="instance">The ToolStripButton instance to observe.</param>
        /// <returns>An observable sequence wrapping the CheckStateChanged event on the ToolStripButton instance.</returns>
        public static IObservable<EventPattern<EventArgs>> CheckStateChangedObservable(this ToolStripButton instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.CheckStateChanged += handler,
                handler => instance.CheckStateChanged -= handler);
        }
    }
}

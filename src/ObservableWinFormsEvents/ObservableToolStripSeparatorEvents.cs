namespace System.Windows.Forms
{
    using System;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on ToolStripSeparator.
    /// </summary>
    public static class ObservableToolStripSeparatorEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the EnabledChanged event on the ToolStripSeparator instance.
        /// </summary>
        /// <param name="instance">The ToolStripSeparator instance to observe.</param>
        /// <returns>An observable sequence wrapping the EnabledChanged event on the ToolStripSeparator instance.</returns>
        public static IObservable<EventPattern<EventArgs>> EnabledChangedObservable(this ToolStripSeparator instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.EnabledChanged += handler,
                handler => instance.EnabledChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DisplayStyleChanged event on the ToolStripSeparator instance.
        /// </summary>
        /// <param name="instance">The ToolStripSeparator instance to observe.</param>
        /// <returns>An observable sequence wrapping the DisplayStyleChanged event on the ToolStripSeparator instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DisplayStyleChangedObservable(this ToolStripSeparator instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DisplayStyleChanged += handler,
                handler => instance.DisplayStyleChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the TextChanged event on the ToolStripSeparator instance.
        /// </summary>
        /// <param name="instance">The ToolStripSeparator instance to observe.</param>
        /// <returns>An observable sequence wrapping the TextChanged event on the ToolStripSeparator instance.</returns>
        public static IObservable<EventPattern<EventArgs>> TextChangedObservable(this ToolStripSeparator instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.TextChanged += handler,
                handler => instance.TextChanged -= handler);
        }
    }
}

namespace System.Windows.Forms
{
    using System;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on ToolStripContainer.
    /// </summary>
    public static class ObservableToolStripContainerEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the BackColorChanged event on the ToolStripContainer instance.
        /// </summary>
        /// <param name="instance">The ToolStripContainer instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackColorChanged event on the ToolStripContainer instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackColorChangedObservable(this ToolStripContainer instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackColorChanged += handler,
                handler => instance.BackColorChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageChanged event on the ToolStripContainer instance.
        /// </summary>
        /// <param name="instance">The ToolStripContainer instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageChanged event on the ToolStripContainer instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageChangedObservable(this ToolStripContainer instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageChanged += handler,
                handler => instance.BackgroundImageChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageLayoutChanged event on the ToolStripContainer instance.
        /// </summary>
        /// <param name="instance">The ToolStripContainer instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageLayoutChanged event on the ToolStripContainer instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageLayoutChangedObservable(this ToolStripContainer instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageLayoutChanged += handler,
                handler => instance.BackgroundImageLayoutChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CausesValidationChanged event on the ToolStripContainer instance.
        /// </summary>
        /// <param name="instance">The ToolStripContainer instance to observe.</param>
        /// <returns>An observable sequence wrapping the CausesValidationChanged event on the ToolStripContainer instance.</returns>
        public static IObservable<EventPattern<EventArgs>> CausesValidationChangedObservable(this ToolStripContainer instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.CausesValidationChanged += handler,
                handler => instance.CausesValidationChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ContextMenuStripChanged event on the ToolStripContainer instance.
        /// </summary>
        /// <param name="instance">The ToolStripContainer instance to observe.</param>
        /// <returns>An observable sequence wrapping the ContextMenuStripChanged event on the ToolStripContainer instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ContextMenuStripChangedObservable(this ToolStripContainer instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ContextMenuStripChanged += handler,
                handler => instance.ContextMenuStripChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CursorChanged event on the ToolStripContainer instance.
        /// </summary>
        /// <param name="instance">The ToolStripContainer instance to observe.</param>
        /// <returns>An observable sequence wrapping the CursorChanged event on the ToolStripContainer instance.</returns>
        public static IObservable<EventPattern<EventArgs>> CursorChangedObservable(this ToolStripContainer instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.CursorChanged += handler,
                handler => instance.CursorChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ForeColorChanged event on the ToolStripContainer instance.
        /// </summary>
        /// <param name="instance">The ToolStripContainer instance to observe.</param>
        /// <returns>An observable sequence wrapping the ForeColorChanged event on the ToolStripContainer instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ForeColorChangedObservable(this ToolStripContainer instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ForeColorChanged += handler,
                handler => instance.ForeColorChanged -= handler);
        }
    }
}

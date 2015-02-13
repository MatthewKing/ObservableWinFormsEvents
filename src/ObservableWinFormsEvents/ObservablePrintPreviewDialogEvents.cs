namespace System.Windows.Forms
{
    using System;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on PrintPreviewDialog.
    /// </summary>
    public static class ObservablePrintPreviewDialogEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the AutoSizeChanged event on the PrintPreviewDialog instance.
        /// </summary>
        /// <param name="instance">The PrintPreviewDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the AutoSizeChanged event on the PrintPreviewDialog instance.</returns>
        public static IObservable<EventPattern<EventArgs>> AutoSizeChangedObservable(this PrintPreviewDialog instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.AutoSizeChanged += handler,
                handler => instance.AutoSizeChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the AutoValidateChanged event on the PrintPreviewDialog instance.
        /// </summary>
        /// <param name="instance">The PrintPreviewDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the AutoValidateChanged event on the PrintPreviewDialog instance.</returns>
        public static IObservable<EventPattern<EventArgs>> AutoValidateChangedObservable(this PrintPreviewDialog instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.AutoValidateChanged += handler,
                handler => instance.AutoValidateChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackColorChanged event on the PrintPreviewDialog instance.
        /// </summary>
        /// <param name="instance">The PrintPreviewDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackColorChanged event on the PrintPreviewDialog instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackColorChangedObservable(this PrintPreviewDialog instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackColorChanged += handler,
                handler => instance.BackColorChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ContextMenuStripChanged event on the PrintPreviewDialog instance.
        /// </summary>
        /// <param name="instance">The PrintPreviewDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the ContextMenuStripChanged event on the PrintPreviewDialog instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ContextMenuStripChangedObservable(this PrintPreviewDialog instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ContextMenuStripChanged += handler,
                handler => instance.ContextMenuStripChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MaximumSizeChanged event on the PrintPreviewDialog instance.
        /// </summary>
        /// <param name="instance">The PrintPreviewDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the MaximumSizeChanged event on the PrintPreviewDialog instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MaximumSizeChangedObservable(this PrintPreviewDialog instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MaximumSizeChanged += handler,
                handler => instance.MaximumSizeChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MarginChanged event on the PrintPreviewDialog instance.
        /// </summary>
        /// <param name="instance">The PrintPreviewDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the MarginChanged event on the PrintPreviewDialog instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MarginChangedObservable(this PrintPreviewDialog instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MarginChanged += handler,
                handler => instance.MarginChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MinimumSizeChanged event on the PrintPreviewDialog instance.
        /// </summary>
        /// <param name="instance">The PrintPreviewDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the MinimumSizeChanged event on the PrintPreviewDialog instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MinimumSizeChangedObservable(this PrintPreviewDialog instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MinimumSizeChanged += handler,
                handler => instance.MinimumSizeChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the PaddingChanged event on the PrintPreviewDialog instance.
        /// </summary>
        /// <param name="instance">The PrintPreviewDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the PaddingChanged event on the PrintPreviewDialog instance.</returns>
        public static IObservable<EventPattern<EventArgs>> PaddingChangedObservable(this PrintPreviewDialog instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.PaddingChanged += handler,
                handler => instance.PaddingChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the SizeChanged event on the PrintPreviewDialog instance.
        /// </summary>
        /// <param name="instance">The PrintPreviewDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the SizeChanged event on the PrintPreviewDialog instance.</returns>
        public static IObservable<EventPattern<EventArgs>> SizeChangedObservable(this PrintPreviewDialog instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.SizeChanged += handler,
                handler => instance.SizeChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CausesValidationChanged event on the PrintPreviewDialog instance.
        /// </summary>
        /// <param name="instance">The PrintPreviewDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the CausesValidationChanged event on the PrintPreviewDialog instance.</returns>
        public static IObservable<EventPattern<EventArgs>> CausesValidationChangedObservable(this PrintPreviewDialog instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.CausesValidationChanged += handler,
                handler => instance.CausesValidationChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the EnabledChanged event on the PrintPreviewDialog instance.
        /// </summary>
        /// <param name="instance">The PrintPreviewDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the EnabledChanged event on the PrintPreviewDialog instance.</returns>
        public static IObservable<EventPattern<EventArgs>> EnabledChangedObservable(this PrintPreviewDialog instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.EnabledChanged += handler,
                handler => instance.EnabledChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the LocationChanged event on the PrintPreviewDialog instance.
        /// </summary>
        /// <param name="instance">The PrintPreviewDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the LocationChanged event on the PrintPreviewDialog instance.</returns>
        public static IObservable<EventPattern<EventArgs>> LocationChangedObservable(this PrintPreviewDialog instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.LocationChanged += handler,
                handler => instance.LocationChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CursorChanged event on the PrintPreviewDialog instance.
        /// </summary>
        /// <param name="instance">The PrintPreviewDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the CursorChanged event on the PrintPreviewDialog instance.</returns>
        public static IObservable<EventPattern<EventArgs>> CursorChangedObservable(this PrintPreviewDialog instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.CursorChanged += handler,
                handler => instance.CursorChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageChanged event on the PrintPreviewDialog instance.
        /// </summary>
        /// <param name="instance">The PrintPreviewDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageChanged event on the PrintPreviewDialog instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageChangedObservable(this PrintPreviewDialog instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageChanged += handler,
                handler => instance.BackgroundImageChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageLayoutChanged event on the PrintPreviewDialog instance.
        /// </summary>
        /// <param name="instance">The PrintPreviewDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageLayoutChanged event on the PrintPreviewDialog instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageLayoutChangedObservable(this PrintPreviewDialog instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageLayoutChanged += handler,
                handler => instance.BackgroundImageLayoutChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ImeModeChanged event on the PrintPreviewDialog instance.
        /// </summary>
        /// <param name="instance">The PrintPreviewDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the ImeModeChanged event on the PrintPreviewDialog instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ImeModeChangedObservable(this PrintPreviewDialog instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ImeModeChanged += handler,
                handler => instance.ImeModeChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the VisibleChanged event on the PrintPreviewDialog instance.
        /// </summary>
        /// <param name="instance">The PrintPreviewDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the VisibleChanged event on the PrintPreviewDialog instance.</returns>
        public static IObservable<EventPattern<EventArgs>> VisibleChangedObservable(this PrintPreviewDialog instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.VisibleChanged += handler,
                handler => instance.VisibleChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ForeColorChanged event on the PrintPreviewDialog instance.
        /// </summary>
        /// <param name="instance">The PrintPreviewDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the ForeColorChanged event on the PrintPreviewDialog instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ForeColorChangedObservable(this PrintPreviewDialog instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ForeColorChanged += handler,
                handler => instance.ForeColorChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RightToLeftChanged event on the PrintPreviewDialog instance.
        /// </summary>
        /// <param name="instance">The PrintPreviewDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the RightToLeftChanged event on the PrintPreviewDialog instance.</returns>
        public static IObservable<EventPattern<EventArgs>> RightToLeftChangedObservable(this PrintPreviewDialog instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.RightToLeftChanged += handler,
                handler => instance.RightToLeftChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RightToLeftLayoutChanged event on the PrintPreviewDialog instance.
        /// </summary>
        /// <param name="instance">The PrintPreviewDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the RightToLeftLayoutChanged event on the PrintPreviewDialog instance.</returns>
        public static IObservable<EventPattern<EventArgs>> RightToLeftLayoutChangedObservable(this PrintPreviewDialog instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.RightToLeftLayoutChanged += handler,
                handler => instance.RightToLeftLayoutChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the TabStopChanged event on the PrintPreviewDialog instance.
        /// </summary>
        /// <param name="instance">The PrintPreviewDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the TabStopChanged event on the PrintPreviewDialog instance.</returns>
        public static IObservable<EventPattern<EventArgs>> TabStopChangedObservable(this PrintPreviewDialog instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.TabStopChanged += handler,
                handler => instance.TabStopChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the TextChanged event on the PrintPreviewDialog instance.
        /// </summary>
        /// <param name="instance">The PrintPreviewDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the TextChanged event on the PrintPreviewDialog instance.</returns>
        public static IObservable<EventPattern<EventArgs>> TextChangedObservable(this PrintPreviewDialog instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.TextChanged += handler,
                handler => instance.TextChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DockChanged event on the PrintPreviewDialog instance.
        /// </summary>
        /// <param name="instance">The PrintPreviewDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the DockChanged event on the PrintPreviewDialog instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DockChangedObservable(this PrintPreviewDialog instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DockChanged += handler,
                handler => instance.DockChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the FontChanged event on the PrintPreviewDialog instance.
        /// </summary>
        /// <param name="instance">The PrintPreviewDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the FontChanged event on the PrintPreviewDialog instance.</returns>
        public static IObservable<EventPattern<EventArgs>> FontChangedObservable(this PrintPreviewDialog instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.FontChanged += handler,
                handler => instance.FontChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ContextMenuChanged event on the PrintPreviewDialog instance.
        /// </summary>
        /// <param name="instance">The PrintPreviewDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the ContextMenuChanged event on the PrintPreviewDialog instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ContextMenuChangedObservable(this PrintPreviewDialog instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ContextMenuChanged += handler,
                handler => instance.ContextMenuChanged -= handler);
        }
    }
}

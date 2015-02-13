namespace System.Windows.Forms
{
    using System;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on PrintPreviewControl.
    /// </summary>
    public static class ObservablePrintPreviewControlEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the TextChanged event on the PrintPreviewControl instance.
        /// </summary>
        /// <param name="instance">The PrintPreviewControl instance to observe.</param>
        /// <returns>An observable sequence wrapping the TextChanged event on the PrintPreviewControl instance.</returns>
        public static IObservable<EventPattern<EventArgs>> TextChangedObservable(this PrintPreviewControl instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.TextChanged += handler,
                handler => instance.TextChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the StartPageChanged event on the PrintPreviewControl instance.
        /// </summary>
        /// <param name="instance">The PrintPreviewControl instance to observe.</param>
        /// <returns>An observable sequence wrapping the StartPageChanged event on the PrintPreviewControl instance.</returns>
        public static IObservable<EventPattern<EventArgs>> StartPageChangedObservable(this PrintPreviewControl instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.StartPageChanged += handler,
                handler => instance.StartPageChanged -= handler);
        }
    }
}

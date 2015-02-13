namespace System.Windows.Forms
{
    using System;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on ThreadExceptionDialog.
    /// </summary>
    public static class ObservableThreadExceptionDialogEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the AutoSizeChanged event on the ThreadExceptionDialog instance.
        /// </summary>
        /// <param name="instance">The ThreadExceptionDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the AutoSizeChanged event on the ThreadExceptionDialog instance.</returns>
        public static IObservable<EventPattern<EventArgs>> AutoSizeChangedObservable(this ThreadExceptionDialog instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.AutoSizeChanged += handler,
                handler => instance.AutoSizeChanged -= handler);
        }
    }
}

namespace System.Windows.Forms
{
    using System;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on StatusStrip.
    /// </summary>
    public static class ObservableStatusStripEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the PaddingChanged event on the StatusStrip instance.
        /// </summary>
        /// <param name="instance">The StatusStrip instance to observe.</param>
        /// <returns>An observable sequence wrapping the PaddingChanged event on the StatusStrip instance.</returns>
        public static IObservable<EventPattern<EventArgs>> PaddingChangedObservable(this StatusStrip instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.PaddingChanged += handler,
                handler => instance.PaddingChanged -= handler);
        }
    }
}

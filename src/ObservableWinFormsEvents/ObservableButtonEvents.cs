namespace System.Windows.Forms
{
    using System;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on Button.
    /// </summary>
    public static class ObservableButtonEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the DoubleClick event on the Button instance.
        /// </summary>
        /// <param name="instance">The Button instance to observe.</param>
        /// <returns>An observable sequence wrapping the DoubleClick event on the Button instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DoubleClickObservable(this Button instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DoubleClick += handler,
                handler => instance.DoubleClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseDoubleClick event on the Button instance.
        /// </summary>
        /// <param name="instance">The Button instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseDoubleClick event on the Button instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseDoubleClickObservable(this Button instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseDoubleClick += handler,
                handler => instance.MouseDoubleClick -= handler);
        }
    }
}

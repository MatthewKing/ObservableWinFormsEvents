namespace System.Windows.Forms
{
    using System;
    using System.ComponentModel;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on ButtonBase.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class ObservableButtonBaseEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the AutoSizeChanged event on the ButtonBase instance.
        /// </summary>
        /// <param name="instance">The ButtonBase instance to observe.</param>
        /// <returns>An observable sequence wrapping the AutoSizeChanged event on the ButtonBase instance.</returns>
        public static IObservable<EventPattern<EventArgs>> AutoSizeChangedObservable(this ButtonBase instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.AutoSizeChanged += handler,
                handler => instance.AutoSizeChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ImeModeChanged event on the ButtonBase instance.
        /// </summary>
        /// <param name="instance">The ButtonBase instance to observe.</param>
        /// <returns>An observable sequence wrapping the ImeModeChanged event on the ButtonBase instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ImeModeChangedObservable(this ButtonBase instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ImeModeChanged += handler,
                handler => instance.ImeModeChanged -= handler);
        }
    }
}

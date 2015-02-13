namespace System.Windows.Forms
{
    using System;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on NotifyIcon.
    /// </summary>
    public static class ObservableNotifyIconEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the BalloonTipClicked event on the NotifyIcon instance.
        /// </summary>
        /// <param name="instance">The NotifyIcon instance to observe.</param>
        /// <returns>An observable sequence wrapping the BalloonTipClicked event on the NotifyIcon instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BalloonTipClickedObservable(this NotifyIcon instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BalloonTipClicked += handler,
                handler => instance.BalloonTipClicked -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BalloonTipClosed event on the NotifyIcon instance.
        /// </summary>
        /// <param name="instance">The NotifyIcon instance to observe.</param>
        /// <returns>An observable sequence wrapping the BalloonTipClosed event on the NotifyIcon instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BalloonTipClosedObservable(this NotifyIcon instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BalloonTipClosed += handler,
                handler => instance.BalloonTipClosed -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BalloonTipShown event on the NotifyIcon instance.
        /// </summary>
        /// <param name="instance">The NotifyIcon instance to observe.</param>
        /// <returns>An observable sequence wrapping the BalloonTipShown event on the NotifyIcon instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BalloonTipShownObservable(this NotifyIcon instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BalloonTipShown += handler,
                handler => instance.BalloonTipShown -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Click event on the NotifyIcon instance.
        /// </summary>
        /// <param name="instance">The NotifyIcon instance to observe.</param>
        /// <returns>An observable sequence wrapping the Click event on the NotifyIcon instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ClickObservable(this NotifyIcon instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Click += handler,
                handler => instance.Click -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DoubleClick event on the NotifyIcon instance.
        /// </summary>
        /// <param name="instance">The NotifyIcon instance to observe.</param>
        /// <returns>An observable sequence wrapping the DoubleClick event on the NotifyIcon instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DoubleClickObservable(this NotifyIcon instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DoubleClick += handler,
                handler => instance.DoubleClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseClick event on the NotifyIcon instance.
        /// </summary>
        /// <param name="instance">The NotifyIcon instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseClick event on the NotifyIcon instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseClickObservable(this NotifyIcon instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseClick += handler,
                handler => instance.MouseClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseDoubleClick event on the NotifyIcon instance.
        /// </summary>
        /// <param name="instance">The NotifyIcon instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseDoubleClick event on the NotifyIcon instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseDoubleClickObservable(this NotifyIcon instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseDoubleClick += handler,
                handler => instance.MouseDoubleClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseDown event on the NotifyIcon instance.
        /// </summary>
        /// <param name="instance">The NotifyIcon instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseDown event on the NotifyIcon instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseDownObservable(this NotifyIcon instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseDown += handler,
                handler => instance.MouseDown -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseMove event on the NotifyIcon instance.
        /// </summary>
        /// <param name="instance">The NotifyIcon instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseMove event on the NotifyIcon instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseMoveObservable(this NotifyIcon instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseMove += handler,
                handler => instance.MouseMove -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseUp event on the NotifyIcon instance.
        /// </summary>
        /// <param name="instance">The NotifyIcon instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseUp event on the NotifyIcon instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseUpObservable(this NotifyIcon instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseUp += handler,
                handler => instance.MouseUp -= handler);
        }
    }
}

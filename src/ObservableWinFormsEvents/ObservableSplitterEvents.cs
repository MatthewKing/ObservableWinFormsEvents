namespace System.Windows.Forms
{
    using System;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on Splitter.
    /// </summary>
    public static class ObservableSplitterEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the ForeColorChanged event on the Splitter instance.
        /// </summary>
        /// <param name="instance">The Splitter instance to observe.</param>
        /// <returns>An observable sequence wrapping the ForeColorChanged event on the Splitter instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ForeColorChangedObservable(this Splitter instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ForeColorChanged += handler,
                handler => instance.ForeColorChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageChanged event on the Splitter instance.
        /// </summary>
        /// <param name="instance">The Splitter instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageChanged event on the Splitter instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageChangedObservable(this Splitter instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageChanged += handler,
                handler => instance.BackgroundImageChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageLayoutChanged event on the Splitter instance.
        /// </summary>
        /// <param name="instance">The Splitter instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageLayoutChanged event on the Splitter instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageLayoutChangedObservable(this Splitter instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageLayoutChanged += handler,
                handler => instance.BackgroundImageLayoutChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the FontChanged event on the Splitter instance.
        /// </summary>
        /// <param name="instance">The Splitter instance to observe.</param>
        /// <returns>An observable sequence wrapping the FontChanged event on the Splitter instance.</returns>
        public static IObservable<EventPattern<EventArgs>> FontChangedObservable(this Splitter instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.FontChanged += handler,
                handler => instance.FontChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ImeModeChanged event on the Splitter instance.
        /// </summary>
        /// <param name="instance">The Splitter instance to observe.</param>
        /// <returns>An observable sequence wrapping the ImeModeChanged event on the Splitter instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ImeModeChangedObservable(this Splitter instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ImeModeChanged += handler,
                handler => instance.ImeModeChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the TabStopChanged event on the Splitter instance.
        /// </summary>
        /// <param name="instance">The Splitter instance to observe.</param>
        /// <returns>An observable sequence wrapping the TabStopChanged event on the Splitter instance.</returns>
        public static IObservable<EventPattern<EventArgs>> TabStopChangedObservable(this Splitter instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.TabStopChanged += handler,
                handler => instance.TabStopChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the TextChanged event on the Splitter instance.
        /// </summary>
        /// <param name="instance">The Splitter instance to observe.</param>
        /// <returns>An observable sequence wrapping the TextChanged event on the Splitter instance.</returns>
        public static IObservable<EventPattern<EventArgs>> TextChangedObservable(this Splitter instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.TextChanged += handler,
                handler => instance.TextChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Enter event on the Splitter instance.
        /// </summary>
        /// <param name="instance">The Splitter instance to observe.</param>
        /// <returns>An observable sequence wrapping the Enter event on the Splitter instance.</returns>
        public static IObservable<EventPattern<EventArgs>> EnterObservable(this Splitter instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Enter += handler,
                handler => instance.Enter -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the KeyUp event on the Splitter instance.
        /// </summary>
        /// <param name="instance">The Splitter instance to observe.</param>
        /// <returns>An observable sequence wrapping the KeyUp event on the Splitter instance.</returns>
        public static IObservable<EventPattern<KeyEventArgs>> KeyUpObservable(this Splitter instance)
        {
            return Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(
                handler => instance.KeyUp += handler,
                handler => instance.KeyUp -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the KeyDown event on the Splitter instance.
        /// </summary>
        /// <param name="instance">The Splitter instance to observe.</param>
        /// <returns>An observable sequence wrapping the KeyDown event on the Splitter instance.</returns>
        public static IObservable<EventPattern<KeyEventArgs>> KeyDownObservable(this Splitter instance)
        {
            return Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(
                handler => instance.KeyDown += handler,
                handler => instance.KeyDown -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the KeyPress event on the Splitter instance.
        /// </summary>
        /// <param name="instance">The Splitter instance to observe.</param>
        /// <returns>An observable sequence wrapping the KeyPress event on the Splitter instance.</returns>
        public static IObservable<EventPattern<KeyPressEventArgs>> KeyPressObservable(this Splitter instance)
        {
            return Observable.FromEventPattern<KeyPressEventHandler, KeyPressEventArgs>(
                handler => instance.KeyPress += handler,
                handler => instance.KeyPress -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Leave event on the Splitter instance.
        /// </summary>
        /// <param name="instance">The Splitter instance to observe.</param>
        /// <returns>An observable sequence wrapping the Leave event on the Splitter instance.</returns>
        public static IObservable<EventPattern<EventArgs>> LeaveObservable(this Splitter instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Leave += handler,
                handler => instance.Leave -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the SplitterMoving event on the Splitter instance.
        /// </summary>
        /// <param name="instance">The Splitter instance to observe.</param>
        /// <returns>An observable sequence wrapping the SplitterMoving event on the Splitter instance.</returns>
        public static IObservable<EventPattern<SplitterEventArgs>> SplitterMovingObservable(this Splitter instance)
        {
            return Observable.FromEventPattern<SplitterEventHandler, SplitterEventArgs>(
                handler => instance.SplitterMoving += handler,
                handler => instance.SplitterMoving -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the SplitterMoved event on the Splitter instance.
        /// </summary>
        /// <param name="instance">The Splitter instance to observe.</param>
        /// <returns>An observable sequence wrapping the SplitterMoved event on the Splitter instance.</returns>
        public static IObservable<EventPattern<SplitterEventArgs>> SplitterMovedObservable(this Splitter instance)
        {
            return Observable.FromEventPattern<SplitterEventHandler, SplitterEventArgs>(
                handler => instance.SplitterMoved += handler,
                handler => instance.SplitterMoved -= handler);
        }
    }
}

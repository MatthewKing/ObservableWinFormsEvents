namespace System.Windows.Forms
{
    using System;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on GroupBox.
    /// </summary>
    public static class ObservableGroupBoxEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the AutoSizeChanged event on the GroupBox instance.
        /// </summary>
        /// <param name="instance">The GroupBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the AutoSizeChanged event on the GroupBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> AutoSizeChangedObservable(this GroupBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.AutoSizeChanged += handler,
                handler => instance.AutoSizeChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the TabStopChanged event on the GroupBox instance.
        /// </summary>
        /// <param name="instance">The GroupBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the TabStopChanged event on the GroupBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> TabStopChangedObservable(this GroupBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.TabStopChanged += handler,
                handler => instance.TabStopChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Click event on the GroupBox instance.
        /// </summary>
        /// <param name="instance">The GroupBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the Click event on the GroupBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ClickObservable(this GroupBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Click += handler,
                handler => instance.Click -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseClick event on the GroupBox instance.
        /// </summary>
        /// <param name="instance">The GroupBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseClick event on the GroupBox instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseClickObservable(this GroupBox instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseClick += handler,
                handler => instance.MouseClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DoubleClick event on the GroupBox instance.
        /// </summary>
        /// <param name="instance">The GroupBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the DoubleClick event on the GroupBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DoubleClickObservable(this GroupBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DoubleClick += handler,
                handler => instance.DoubleClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseDoubleClick event on the GroupBox instance.
        /// </summary>
        /// <param name="instance">The GroupBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseDoubleClick event on the GroupBox instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseDoubleClickObservable(this GroupBox instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseDoubleClick += handler,
                handler => instance.MouseDoubleClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the KeyUp event on the GroupBox instance.
        /// </summary>
        /// <param name="instance">The GroupBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the KeyUp event on the GroupBox instance.</returns>
        public static IObservable<EventPattern<KeyEventArgs>> KeyUpObservable(this GroupBox instance)
        {
            return Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(
                handler => instance.KeyUp += handler,
                handler => instance.KeyUp -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the KeyDown event on the GroupBox instance.
        /// </summary>
        /// <param name="instance">The GroupBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the KeyDown event on the GroupBox instance.</returns>
        public static IObservable<EventPattern<KeyEventArgs>> KeyDownObservable(this GroupBox instance)
        {
            return Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(
                handler => instance.KeyDown += handler,
                handler => instance.KeyDown -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the KeyPress event on the GroupBox instance.
        /// </summary>
        /// <param name="instance">The GroupBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the KeyPress event on the GroupBox instance.</returns>
        public static IObservable<EventPattern<KeyPressEventArgs>> KeyPressObservable(this GroupBox instance)
        {
            return Observable.FromEventPattern<KeyPressEventHandler, KeyPressEventArgs>(
                handler => instance.KeyPress += handler,
                handler => instance.KeyPress -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseDown event on the GroupBox instance.
        /// </summary>
        /// <param name="instance">The GroupBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseDown event on the GroupBox instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseDownObservable(this GroupBox instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseDown += handler,
                handler => instance.MouseDown -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseUp event on the GroupBox instance.
        /// </summary>
        /// <param name="instance">The GroupBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseUp event on the GroupBox instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseUpObservable(this GroupBox instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseUp += handler,
                handler => instance.MouseUp -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseMove event on the GroupBox instance.
        /// </summary>
        /// <param name="instance">The GroupBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseMove event on the GroupBox instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseMoveObservable(this GroupBox instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseMove += handler,
                handler => instance.MouseMove -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseEnter event on the GroupBox instance.
        /// </summary>
        /// <param name="instance">The GroupBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseEnter event on the GroupBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MouseEnterObservable(this GroupBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MouseEnter += handler,
                handler => instance.MouseEnter -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseLeave event on the GroupBox instance.
        /// </summary>
        /// <param name="instance">The GroupBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseLeave event on the GroupBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MouseLeaveObservable(this GroupBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MouseLeave += handler,
                handler => instance.MouseLeave -= handler);
        }
    }
}

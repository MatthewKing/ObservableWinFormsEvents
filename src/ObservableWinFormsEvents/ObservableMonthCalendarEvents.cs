namespace System.Windows.Forms
{
    using System;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on MonthCalendar.
    /// </summary>
    public static class ObservableMonthCalendarEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageChanged event on the MonthCalendar instance.
        /// </summary>
        /// <param name="instance">The MonthCalendar instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageChanged event on the MonthCalendar instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageChangedObservable(this MonthCalendar instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageChanged += handler,
                handler => instance.BackgroundImageChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageLayoutChanged event on the MonthCalendar instance.
        /// </summary>
        /// <param name="instance">The MonthCalendar instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageLayoutChanged event on the MonthCalendar instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageLayoutChangedObservable(this MonthCalendar instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageLayoutChanged += handler,
                handler => instance.BackgroundImageLayoutChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ImeModeChanged event on the MonthCalendar instance.
        /// </summary>
        /// <param name="instance">The MonthCalendar instance to observe.</param>
        /// <returns>An observable sequence wrapping the ImeModeChanged event on the MonthCalendar instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ImeModeChangedObservable(this MonthCalendar instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ImeModeChanged += handler,
                handler => instance.ImeModeChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the PaddingChanged event on the MonthCalendar instance.
        /// </summary>
        /// <param name="instance">The MonthCalendar instance to observe.</param>
        /// <returns>An observable sequence wrapping the PaddingChanged event on the MonthCalendar instance.</returns>
        public static IObservable<EventPattern<EventArgs>> PaddingChangedObservable(this MonthCalendar instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.PaddingChanged += handler,
                handler => instance.PaddingChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the TextChanged event on the MonthCalendar instance.
        /// </summary>
        /// <param name="instance">The MonthCalendar instance to observe.</param>
        /// <returns>An observable sequence wrapping the TextChanged event on the MonthCalendar instance.</returns>
        public static IObservable<EventPattern<EventArgs>> TextChangedObservable(this MonthCalendar instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.TextChanged += handler,
                handler => instance.TextChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Click event on the MonthCalendar instance.
        /// </summary>
        /// <param name="instance">The MonthCalendar instance to observe.</param>
        /// <returns>An observable sequence wrapping the Click event on the MonthCalendar instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ClickObservable(this MonthCalendar instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Click += handler,
                handler => instance.Click -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DateChanged event on the MonthCalendar instance.
        /// </summary>
        /// <param name="instance">The MonthCalendar instance to observe.</param>
        /// <returns>An observable sequence wrapping the DateChanged event on the MonthCalendar instance.</returns>
        public static IObservable<EventPattern<DateRangeEventArgs>> DateChangedObservable(this MonthCalendar instance)
        {
            return Observable.FromEventPattern<DateRangeEventHandler, DateRangeEventArgs>(
                handler => instance.DateChanged += handler,
                handler => instance.DateChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DateSelected event on the MonthCalendar instance.
        /// </summary>
        /// <param name="instance">The MonthCalendar instance to observe.</param>
        /// <returns>An observable sequence wrapping the DateSelected event on the MonthCalendar instance.</returns>
        public static IObservable<EventPattern<DateRangeEventArgs>> DateSelectedObservable(this MonthCalendar instance)
        {
            return Observable.FromEventPattern<DateRangeEventHandler, DateRangeEventArgs>(
                handler => instance.DateSelected += handler,
                handler => instance.DateSelected -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DoubleClick event on the MonthCalendar instance.
        /// </summary>
        /// <param name="instance">The MonthCalendar instance to observe.</param>
        /// <returns>An observable sequence wrapping the DoubleClick event on the MonthCalendar instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DoubleClickObservable(this MonthCalendar instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DoubleClick += handler,
                handler => instance.DoubleClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseClick event on the MonthCalendar instance.
        /// </summary>
        /// <param name="instance">The MonthCalendar instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseClick event on the MonthCalendar instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseClickObservable(this MonthCalendar instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseClick += handler,
                handler => instance.MouseClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseDoubleClick event on the MonthCalendar instance.
        /// </summary>
        /// <param name="instance">The MonthCalendar instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseDoubleClick event on the MonthCalendar instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseDoubleClickObservable(this MonthCalendar instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseDoubleClick += handler,
                handler => instance.MouseDoubleClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Paint event on the MonthCalendar instance.
        /// </summary>
        /// <param name="instance">The MonthCalendar instance to observe.</param>
        /// <returns>An observable sequence wrapping the Paint event on the MonthCalendar instance.</returns>
        public static IObservable<EventPattern<PaintEventArgs>> PaintObservable(this MonthCalendar instance)
        {
            return Observable.FromEventPattern<PaintEventHandler, PaintEventArgs>(
                handler => instance.Paint += handler,
                handler => instance.Paint -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RightToLeftLayoutChanged event on the MonthCalendar instance.
        /// </summary>
        /// <param name="instance">The MonthCalendar instance to observe.</param>
        /// <returns>An observable sequence wrapping the RightToLeftLayoutChanged event on the MonthCalendar instance.</returns>
        public static IObservable<EventPattern<EventArgs>> RightToLeftLayoutChangedObservable(this MonthCalendar instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.RightToLeftLayoutChanged += handler,
                handler => instance.RightToLeftLayoutChanged -= handler);
        }
    }
}

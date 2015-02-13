namespace System.Windows.Forms
{
    using System;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on DateTimePicker.
    /// </summary>
    public static class ObservableDateTimePickerEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the BackColorChanged event on the DateTimePicker instance.
        /// </summary>
        /// <param name="instance">The DateTimePicker instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackColorChanged event on the DateTimePicker instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackColorChangedObservable(this DateTimePicker instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackColorChanged += handler,
                handler => instance.BackColorChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageChanged event on the DateTimePicker instance.
        /// </summary>
        /// <param name="instance">The DateTimePicker instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageChanged event on the DateTimePicker instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageChangedObservable(this DateTimePicker instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageChanged += handler,
                handler => instance.BackgroundImageChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageLayoutChanged event on the DateTimePicker instance.
        /// </summary>
        /// <param name="instance">The DateTimePicker instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageLayoutChanged event on the DateTimePicker instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageLayoutChangedObservable(this DateTimePicker instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageLayoutChanged += handler,
                handler => instance.BackgroundImageLayoutChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Click event on the DateTimePicker instance.
        /// </summary>
        /// <param name="instance">The DateTimePicker instance to observe.</param>
        /// <returns>An observable sequence wrapping the Click event on the DateTimePicker instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ClickObservable(this DateTimePicker instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Click += handler,
                handler => instance.Click -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DoubleClick event on the DateTimePicker instance.
        /// </summary>
        /// <param name="instance">The DateTimePicker instance to observe.</param>
        /// <returns>An observable sequence wrapping the DoubleClick event on the DateTimePicker instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DoubleClickObservable(this DateTimePicker instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DoubleClick += handler,
                handler => instance.DoubleClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ForeColorChanged event on the DateTimePicker instance.
        /// </summary>
        /// <param name="instance">The DateTimePicker instance to observe.</param>
        /// <returns>An observable sequence wrapping the ForeColorChanged event on the DateTimePicker instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ForeColorChangedObservable(this DateTimePicker instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ForeColorChanged += handler,
                handler => instance.ForeColorChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the FormatChanged event on the DateTimePicker instance.
        /// </summary>
        /// <param name="instance">The DateTimePicker instance to observe.</param>
        /// <returns>An observable sequence wrapping the FormatChanged event on the DateTimePicker instance.</returns>
        public static IObservable<EventPattern<EventArgs>> FormatChangedObservable(this DateTimePicker instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.FormatChanged += handler,
                handler => instance.FormatChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Paint event on the DateTimePicker instance.
        /// </summary>
        /// <param name="instance">The DateTimePicker instance to observe.</param>
        /// <returns>An observable sequence wrapping the Paint event on the DateTimePicker instance.</returns>
        public static IObservable<EventPattern<PaintEventArgs>> PaintObservable(this DateTimePicker instance)
        {
            return Observable.FromEventPattern<PaintEventHandler, PaintEventArgs>(
                handler => instance.Paint += handler,
                handler => instance.Paint -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseClick event on the DateTimePicker instance.
        /// </summary>
        /// <param name="instance">The DateTimePicker instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseClick event on the DateTimePicker instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseClickObservable(this DateTimePicker instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseClick += handler,
                handler => instance.MouseClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseDoubleClick event on the DateTimePicker instance.
        /// </summary>
        /// <param name="instance">The DateTimePicker instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseDoubleClick event on the DateTimePicker instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseDoubleClickObservable(this DateTimePicker instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseDoubleClick += handler,
                handler => instance.MouseDoubleClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the PaddingChanged event on the DateTimePicker instance.
        /// </summary>
        /// <param name="instance">The DateTimePicker instance to observe.</param>
        /// <returns>An observable sequence wrapping the PaddingChanged event on the DateTimePicker instance.</returns>
        public static IObservable<EventPattern<EventArgs>> PaddingChangedObservable(this DateTimePicker instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.PaddingChanged += handler,
                handler => instance.PaddingChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the TextChanged event on the DateTimePicker instance.
        /// </summary>
        /// <param name="instance">The DateTimePicker instance to observe.</param>
        /// <returns>An observable sequence wrapping the TextChanged event on the DateTimePicker instance.</returns>
        public static IObservable<EventPattern<EventArgs>> TextChangedObservable(this DateTimePicker instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.TextChanged += handler,
                handler => instance.TextChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CloseUp event on the DateTimePicker instance.
        /// </summary>
        /// <param name="instance">The DateTimePicker instance to observe.</param>
        /// <returns>An observable sequence wrapping the CloseUp event on the DateTimePicker instance.</returns>
        public static IObservable<EventPattern<EventArgs>> CloseUpObservable(this DateTimePicker instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.CloseUp += handler,
                handler => instance.CloseUp -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RightToLeftLayoutChanged event on the DateTimePicker instance.
        /// </summary>
        /// <param name="instance">The DateTimePicker instance to observe.</param>
        /// <returns>An observable sequence wrapping the RightToLeftLayoutChanged event on the DateTimePicker instance.</returns>
        public static IObservable<EventPattern<EventArgs>> RightToLeftLayoutChangedObservable(this DateTimePicker instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.RightToLeftLayoutChanged += handler,
                handler => instance.RightToLeftLayoutChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ValueChanged event on the DateTimePicker instance.
        /// </summary>
        /// <param name="instance">The DateTimePicker instance to observe.</param>
        /// <returns>An observable sequence wrapping the ValueChanged event on the DateTimePicker instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ValueChangedObservable(this DateTimePicker instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ValueChanged += handler,
                handler => instance.ValueChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DropDown event on the DateTimePicker instance.
        /// </summary>
        /// <param name="instance">The DateTimePicker instance to observe.</param>
        /// <returns>An observable sequence wrapping the DropDown event on the DateTimePicker instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DropDownObservable(this DateTimePicker instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DropDown += handler,
                handler => instance.DropDown -= handler);
        }
    }
}

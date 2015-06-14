namespace System.Windows.Forms
{
    using System;
    using System.ComponentModel;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on NumericUpDown.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class ObservableNumericUpDownEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the PaddingChanged event on the NumericUpDown instance.
        /// </summary>
        /// <param name="instance">The NumericUpDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the PaddingChanged event on the NumericUpDown instance.</returns>
        public static IObservable<EventPattern<EventArgs>> PaddingChangedObservable(this NumericUpDown instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.PaddingChanged += handler,
                handler => instance.PaddingChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the TextChanged event on the NumericUpDown instance.
        /// </summary>
        /// <param name="instance">The NumericUpDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the TextChanged event on the NumericUpDown instance.</returns>
        public static IObservable<EventPattern<EventArgs>> TextChangedObservable(this NumericUpDown instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.TextChanged += handler,
                handler => instance.TextChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ValueChanged event on the NumericUpDown instance.
        /// </summary>
        /// <param name="instance">The NumericUpDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the ValueChanged event on the NumericUpDown instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ValueChangedObservable(this NumericUpDown instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ValueChanged += handler,
                handler => instance.ValueChanged -= handler);
        }
    }
}

namespace System.Windows.Forms
{
    using System;
    using System.ComponentModel;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on MenuItem.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class ObservableMenuItemEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the Click event on the MenuItem instance.
        /// </summary>
        /// <param name="instance">The MenuItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the Click event on the MenuItem instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ClickObservable(this MenuItem instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Click += handler,
                handler => instance.Click -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DrawItem event on the MenuItem instance.
        /// </summary>
        /// <param name="instance">The MenuItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the DrawItem event on the MenuItem instance.</returns>
        public static IObservable<EventPattern<DrawItemEventArgs>> DrawItemObservable(this MenuItem instance)
        {
            return Observable.FromEventPattern<DrawItemEventHandler, DrawItemEventArgs>(
                handler => instance.DrawItem += handler,
                handler => instance.DrawItem -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MeasureItem event on the MenuItem instance.
        /// </summary>
        /// <param name="instance">The MenuItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the MeasureItem event on the MenuItem instance.</returns>
        public static IObservable<EventPattern<MeasureItemEventArgs>> MeasureItemObservable(this MenuItem instance)
        {
            return Observable.FromEventPattern<MeasureItemEventHandler, MeasureItemEventArgs>(
                handler => instance.MeasureItem += handler,
                handler => instance.MeasureItem -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Popup event on the MenuItem instance.
        /// </summary>
        /// <param name="instance">The MenuItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the Popup event on the MenuItem instance.</returns>
        public static IObservable<EventPattern<EventArgs>> PopupObservable(this MenuItem instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Popup += handler,
                handler => instance.Popup -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Select event on the MenuItem instance.
        /// </summary>
        /// <param name="instance">The MenuItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the Select event on the MenuItem instance.</returns>
        public static IObservable<EventPattern<EventArgs>> SelectObservable(this MenuItem instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Select += handler,
                handler => instance.Select -= handler);
        }
    }
}

namespace System.Windows.Forms
{
    using System;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on DomainUpDown.
    /// </summary>
    public static class ObservableDomainUpDownEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the PaddingChanged event on the DomainUpDown instance.
        /// </summary>
        /// <param name="instance">The DomainUpDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the PaddingChanged event on the DomainUpDown instance.</returns>
        public static IObservable<EventPattern<EventArgs>> PaddingChangedObservable(this DomainUpDown instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.PaddingChanged += handler,
                handler => instance.PaddingChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the SelectedItemChanged event on the DomainUpDown instance.
        /// </summary>
        /// <param name="instance">The DomainUpDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the SelectedItemChanged event on the DomainUpDown instance.</returns>
        public static IObservable<EventPattern<EventArgs>> SelectedItemChangedObservable(this DomainUpDown instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.SelectedItemChanged += handler,
                handler => instance.SelectedItemChanged -= handler);
        }
    }
}

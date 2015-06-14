namespace System.Windows.Forms
{
    using System;
    using System.ComponentModel;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on CheckedListBox.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class ObservableCheckedListBoxEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the DataSourceChanged event on the CheckedListBox instance.
        /// </summary>
        /// <param name="instance">The CheckedListBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the DataSourceChanged event on the CheckedListBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DataSourceChangedObservable(this CheckedListBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DataSourceChanged += handler,
                handler => instance.DataSourceChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DisplayMemberChanged event on the CheckedListBox instance.
        /// </summary>
        /// <param name="instance">The CheckedListBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the DisplayMemberChanged event on the CheckedListBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DisplayMemberChangedObservable(this CheckedListBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DisplayMemberChanged += handler,
                handler => instance.DisplayMemberChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ItemCheck event on the CheckedListBox instance.
        /// </summary>
        /// <param name="instance">The CheckedListBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the ItemCheck event on the CheckedListBox instance.</returns>
        public static IObservable<EventPattern<ItemCheckEventArgs>> ItemCheckObservable(this CheckedListBox instance)
        {
            return Observable.FromEventPattern<ItemCheckEventHandler, ItemCheckEventArgs>(
                handler => instance.ItemCheck += handler,
                handler => instance.ItemCheck -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Click event on the CheckedListBox instance.
        /// </summary>
        /// <param name="instance">The CheckedListBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the Click event on the CheckedListBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ClickObservable(this CheckedListBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Click += handler,
                handler => instance.Click -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseClick event on the CheckedListBox instance.
        /// </summary>
        /// <param name="instance">The CheckedListBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseClick event on the CheckedListBox instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseClickObservable(this CheckedListBox instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseClick += handler,
                handler => instance.MouseClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DrawItem event on the CheckedListBox instance.
        /// </summary>
        /// <param name="instance">The CheckedListBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the DrawItem event on the CheckedListBox instance.</returns>
        public static IObservable<EventPattern<DrawItemEventArgs>> DrawItemObservable(this CheckedListBox instance)
        {
            return Observable.FromEventPattern<DrawItemEventHandler, DrawItemEventArgs>(
                handler => instance.DrawItem += handler,
                handler => instance.DrawItem -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MeasureItem event on the CheckedListBox instance.
        /// </summary>
        /// <param name="instance">The CheckedListBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the MeasureItem event on the CheckedListBox instance.</returns>
        public static IObservable<EventPattern<MeasureItemEventArgs>> MeasureItemObservable(this CheckedListBox instance)
        {
            return Observable.FromEventPattern<MeasureItemEventHandler, MeasureItemEventArgs>(
                handler => instance.MeasureItem += handler,
                handler => instance.MeasureItem -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ValueMemberChanged event on the CheckedListBox instance.
        /// </summary>
        /// <param name="instance">The CheckedListBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the ValueMemberChanged event on the CheckedListBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ValueMemberChangedObservable(this CheckedListBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ValueMemberChanged += handler,
                handler => instance.ValueMemberChanged -= handler);
        }
    }
}

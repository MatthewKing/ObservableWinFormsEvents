namespace System.Windows.Forms
{
    using System;
    using System.ComponentModel;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on ComboBox.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class ObservableComboBoxEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageChanged event on the ComboBox instance.
        /// </summary>
        /// <param name="instance">The ComboBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageChanged event on the ComboBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageChangedObservable(this ComboBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageChanged += handler,
                handler => instance.BackgroundImageChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageLayoutChanged event on the ComboBox instance.
        /// </summary>
        /// <param name="instance">The ComboBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageLayoutChanged event on the ComboBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageLayoutChangedObservable(this ComboBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageLayoutChanged += handler,
                handler => instance.BackgroundImageLayoutChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the PaddingChanged event on the ComboBox instance.
        /// </summary>
        /// <param name="instance">The ComboBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the PaddingChanged event on the ComboBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> PaddingChangedObservable(this ComboBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.PaddingChanged += handler,
                handler => instance.PaddingChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DoubleClick event on the ComboBox instance.
        /// </summary>
        /// <param name="instance">The ComboBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the DoubleClick event on the ComboBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DoubleClickObservable(this ComboBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DoubleClick += handler,
                handler => instance.DoubleClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DrawItem event on the ComboBox instance.
        /// </summary>
        /// <param name="instance">The ComboBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the DrawItem event on the ComboBox instance.</returns>
        public static IObservable<EventPattern<DrawItemEventArgs>> DrawItemObservable(this ComboBox instance)
        {
            return Observable.FromEventPattern<DrawItemEventHandler, DrawItemEventArgs>(
                handler => instance.DrawItem += handler,
                handler => instance.DrawItem -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DropDown event on the ComboBox instance.
        /// </summary>
        /// <param name="instance">The ComboBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the DropDown event on the ComboBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DropDownObservable(this ComboBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DropDown += handler,
                handler => instance.DropDown -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MeasureItem event on the ComboBox instance.
        /// </summary>
        /// <param name="instance">The ComboBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the MeasureItem event on the ComboBox instance.</returns>
        public static IObservable<EventPattern<MeasureItemEventArgs>> MeasureItemObservable(this ComboBox instance)
        {
            return Observable.FromEventPattern<MeasureItemEventHandler, MeasureItemEventArgs>(
                handler => instance.MeasureItem += handler,
                handler => instance.MeasureItem -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the SelectedIndexChanged event on the ComboBox instance.
        /// </summary>
        /// <param name="instance">The ComboBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the SelectedIndexChanged event on the ComboBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> SelectedIndexChangedObservable(this ComboBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.SelectedIndexChanged += handler,
                handler => instance.SelectedIndexChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the SelectionChangeCommitted event on the ComboBox instance.
        /// </summary>
        /// <param name="instance">The ComboBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the SelectionChangeCommitted event on the ComboBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> SelectionChangeCommittedObservable(this ComboBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.SelectionChangeCommitted += handler,
                handler => instance.SelectionChangeCommitted -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DropDownStyleChanged event on the ComboBox instance.
        /// </summary>
        /// <param name="instance">The ComboBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the DropDownStyleChanged event on the ComboBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DropDownStyleChangedObservable(this ComboBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DropDownStyleChanged += handler,
                handler => instance.DropDownStyleChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Paint event on the ComboBox instance.
        /// </summary>
        /// <param name="instance">The ComboBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the Paint event on the ComboBox instance.</returns>
        public static IObservable<EventPattern<PaintEventArgs>> PaintObservable(this ComboBox instance)
        {
            return Observable.FromEventPattern<PaintEventHandler, PaintEventArgs>(
                handler => instance.Paint += handler,
                handler => instance.Paint -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the TextUpdate event on the ComboBox instance.
        /// </summary>
        /// <param name="instance">The ComboBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the TextUpdate event on the ComboBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> TextUpdateObservable(this ComboBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.TextUpdate += handler,
                handler => instance.TextUpdate -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DropDownClosed event on the ComboBox instance.
        /// </summary>
        /// <param name="instance">The ComboBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the DropDownClosed event on the ComboBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DropDownClosedObservable(this ComboBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DropDownClosed += handler,
                handler => instance.DropDownClosed -= handler);
        }
    }
}

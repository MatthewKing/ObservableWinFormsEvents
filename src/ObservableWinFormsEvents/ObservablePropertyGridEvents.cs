namespace System.Windows.Forms
{
    using System;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on PropertyGrid.
    /// </summary>
    public static class ObservablePropertyGridEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageChanged event on the PropertyGrid instance.
        /// </summary>
        /// <param name="instance">The PropertyGrid instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageChanged event on the PropertyGrid instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageChangedObservable(this PropertyGrid instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageChanged += handler,
                handler => instance.BackgroundImageChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageLayoutChanged event on the PropertyGrid instance.
        /// </summary>
        /// <param name="instance">The PropertyGrid instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageLayoutChanged event on the PropertyGrid instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageLayoutChangedObservable(this PropertyGrid instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageLayoutChanged += handler,
                handler => instance.BackgroundImageLayoutChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ForeColorChanged event on the PropertyGrid instance.
        /// </summary>
        /// <param name="instance">The PropertyGrid instance to observe.</param>
        /// <returns>An observable sequence wrapping the ForeColorChanged event on the PropertyGrid instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ForeColorChangedObservable(this PropertyGrid instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ForeColorChanged += handler,
                handler => instance.ForeColorChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the PaddingChanged event on the PropertyGrid instance.
        /// </summary>
        /// <param name="instance">The PropertyGrid instance to observe.</param>
        /// <returns>An observable sequence wrapping the PaddingChanged event on the PropertyGrid instance.</returns>
        public static IObservable<EventPattern<EventArgs>> PaddingChangedObservable(this PropertyGrid instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.PaddingChanged += handler,
                handler => instance.PaddingChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the TextChanged event on the PropertyGrid instance.
        /// </summary>
        /// <param name="instance">The PropertyGrid instance to observe.</param>
        /// <returns>An observable sequence wrapping the TextChanged event on the PropertyGrid instance.</returns>
        public static IObservable<EventPattern<EventArgs>> TextChangedObservable(this PropertyGrid instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.TextChanged += handler,
                handler => instance.TextChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the KeyDown event on the PropertyGrid instance.
        /// </summary>
        /// <param name="instance">The PropertyGrid instance to observe.</param>
        /// <returns>An observable sequence wrapping the KeyDown event on the PropertyGrid instance.</returns>
        public static IObservable<EventPattern<KeyEventArgs>> KeyDownObservable(this PropertyGrid instance)
        {
            return Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(
                handler => instance.KeyDown += handler,
                handler => instance.KeyDown -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the KeyPress event on the PropertyGrid instance.
        /// </summary>
        /// <param name="instance">The PropertyGrid instance to observe.</param>
        /// <returns>An observable sequence wrapping the KeyPress event on the PropertyGrid instance.</returns>
        public static IObservable<EventPattern<KeyPressEventArgs>> KeyPressObservable(this PropertyGrid instance)
        {
            return Observable.FromEventPattern<KeyPressEventHandler, KeyPressEventArgs>(
                handler => instance.KeyPress += handler,
                handler => instance.KeyPress -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the KeyUp event on the PropertyGrid instance.
        /// </summary>
        /// <param name="instance">The PropertyGrid instance to observe.</param>
        /// <returns>An observable sequence wrapping the KeyUp event on the PropertyGrid instance.</returns>
        public static IObservable<EventPattern<KeyEventArgs>> KeyUpObservable(this PropertyGrid instance)
        {
            return Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(
                handler => instance.KeyUp += handler,
                handler => instance.KeyUp -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseDown event on the PropertyGrid instance.
        /// </summary>
        /// <param name="instance">The PropertyGrid instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseDown event on the PropertyGrid instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseDownObservable(this PropertyGrid instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseDown += handler,
                handler => instance.MouseDown -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseUp event on the PropertyGrid instance.
        /// </summary>
        /// <param name="instance">The PropertyGrid instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseUp event on the PropertyGrid instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseUpObservable(this PropertyGrid instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseUp += handler,
                handler => instance.MouseUp -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseMove event on the PropertyGrid instance.
        /// </summary>
        /// <param name="instance">The PropertyGrid instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseMove event on the PropertyGrid instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseMoveObservable(this PropertyGrid instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseMove += handler,
                handler => instance.MouseMove -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseEnter event on the PropertyGrid instance.
        /// </summary>
        /// <param name="instance">The PropertyGrid instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseEnter event on the PropertyGrid instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MouseEnterObservable(this PropertyGrid instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MouseEnter += handler,
                handler => instance.MouseEnter -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseLeave event on the PropertyGrid instance.
        /// </summary>
        /// <param name="instance">The PropertyGrid instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseLeave event on the PropertyGrid instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MouseLeaveObservable(this PropertyGrid instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MouseLeave += handler,
                handler => instance.MouseLeave -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the PropertyValueChanged event on the PropertyGrid instance.
        /// </summary>
        /// <param name="instance">The PropertyGrid instance to observe.</param>
        /// <returns>An observable sequence wrapping the PropertyValueChanged event on the PropertyGrid instance.</returns>
        public static IObservable<EventPattern<PropertyValueChangedEventArgs>> PropertyValueChangedObservable(this PropertyGrid instance)
        {
            return Observable.FromEventPattern<PropertyValueChangedEventHandler, PropertyValueChangedEventArgs>(
                handler => instance.PropertyValueChanged += handler,
                handler => instance.PropertyValueChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the PropertyTabChanged event on the PropertyGrid instance.
        /// </summary>
        /// <param name="instance">The PropertyGrid instance to observe.</param>
        /// <returns>An observable sequence wrapping the PropertyTabChanged event on the PropertyGrid instance.</returns>
        public static IObservable<EventPattern<PropertyTabChangedEventArgs>> PropertyTabChangedObservable(this PropertyGrid instance)
        {
            return Observable.FromEventPattern<PropertyTabChangedEventHandler, PropertyTabChangedEventArgs>(
                handler => instance.PropertyTabChanged += handler,
                handler => instance.PropertyTabChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the PropertySortChanged event on the PropertyGrid instance.
        /// </summary>
        /// <param name="instance">The PropertyGrid instance to observe.</param>
        /// <returns>An observable sequence wrapping the PropertySortChanged event on the PropertyGrid instance.</returns>
        public static IObservable<EventPattern<EventArgs>> PropertySortChangedObservable(this PropertyGrid instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.PropertySortChanged += handler,
                handler => instance.PropertySortChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the SelectedGridItemChanged event on the PropertyGrid instance.
        /// </summary>
        /// <param name="instance">The PropertyGrid instance to observe.</param>
        /// <returns>An observable sequence wrapping the SelectedGridItemChanged event on the PropertyGrid instance.</returns>
        public static IObservable<EventPattern<SelectedGridItemChangedEventArgs>> SelectedGridItemChangedObservable(this PropertyGrid instance)
        {
            return Observable.FromEventPattern<SelectedGridItemChangedEventHandler, SelectedGridItemChangedEventArgs>(
                handler => instance.SelectedGridItemChanged += handler,
                handler => instance.SelectedGridItemChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the SelectedObjectsChanged event on the PropertyGrid instance.
        /// </summary>
        /// <param name="instance">The PropertyGrid instance to observe.</param>
        /// <returns>An observable sequence wrapping the SelectedObjectsChanged event on the PropertyGrid instance.</returns>
        public static IObservable<EventPattern<EventArgs>> SelectedObjectsChangedObservable(this PropertyGrid instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.SelectedObjectsChanged += handler,
                handler => instance.SelectedObjectsChanged -= handler);
        }
    }
}

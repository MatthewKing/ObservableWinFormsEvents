namespace System.Windows.Forms
{
    using System;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on TextBoxBase.
    /// </summary>
    public static class ObservableTextBoxBaseEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the AcceptsTabChanged event on the TextBoxBase instance.
        /// </summary>
        /// <param name="instance">The TextBoxBase instance to observe.</param>
        /// <returns>An observable sequence wrapping the AcceptsTabChanged event on the TextBoxBase instance.</returns>
        public static IObservable<EventPattern<EventArgs>> AcceptsTabChangedObservable(this TextBoxBase instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.AcceptsTabChanged += handler,
                handler => instance.AcceptsTabChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the AutoSizeChanged event on the TextBoxBase instance.
        /// </summary>
        /// <param name="instance">The TextBoxBase instance to observe.</param>
        /// <returns>An observable sequence wrapping the AutoSizeChanged event on the TextBoxBase instance.</returns>
        public static IObservable<EventPattern<EventArgs>> AutoSizeChangedObservable(this TextBoxBase instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.AutoSizeChanged += handler,
                handler => instance.AutoSizeChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageChanged event on the TextBoxBase instance.
        /// </summary>
        /// <param name="instance">The TextBoxBase instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageChanged event on the TextBoxBase instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageChangedObservable(this TextBoxBase instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageChanged += handler,
                handler => instance.BackgroundImageChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageLayoutChanged event on the TextBoxBase instance.
        /// </summary>
        /// <param name="instance">The TextBoxBase instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageLayoutChanged event on the TextBoxBase instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageLayoutChangedObservable(this TextBoxBase instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageLayoutChanged += handler,
                handler => instance.BackgroundImageLayoutChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BorderStyleChanged event on the TextBoxBase instance.
        /// </summary>
        /// <param name="instance">The TextBoxBase instance to observe.</param>
        /// <returns>An observable sequence wrapping the BorderStyleChanged event on the TextBoxBase instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BorderStyleChangedObservable(this TextBoxBase instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BorderStyleChanged += handler,
                handler => instance.BorderStyleChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Click event on the TextBoxBase instance.
        /// </summary>
        /// <param name="instance">The TextBoxBase instance to observe.</param>
        /// <returns>An observable sequence wrapping the Click event on the TextBoxBase instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ClickObservable(this TextBoxBase instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Click += handler,
                handler => instance.Click -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseClick event on the TextBoxBase instance.
        /// </summary>
        /// <param name="instance">The TextBoxBase instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseClick event on the TextBoxBase instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseClickObservable(this TextBoxBase instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseClick += handler,
                handler => instance.MouseClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the HideSelectionChanged event on the TextBoxBase instance.
        /// </summary>
        /// <param name="instance">The TextBoxBase instance to observe.</param>
        /// <returns>An observable sequence wrapping the HideSelectionChanged event on the TextBoxBase instance.</returns>
        public static IObservable<EventPattern<EventArgs>> HideSelectionChangedObservable(this TextBoxBase instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.HideSelectionChanged += handler,
                handler => instance.HideSelectionChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ModifiedChanged event on the TextBoxBase instance.
        /// </summary>
        /// <param name="instance">The TextBoxBase instance to observe.</param>
        /// <returns>An observable sequence wrapping the ModifiedChanged event on the TextBoxBase instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ModifiedChangedObservable(this TextBoxBase instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ModifiedChanged += handler,
                handler => instance.ModifiedChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MultilineChanged event on the TextBoxBase instance.
        /// </summary>
        /// <param name="instance">The TextBoxBase instance to observe.</param>
        /// <returns>An observable sequence wrapping the MultilineChanged event on the TextBoxBase instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MultilineChangedObservable(this TextBoxBase instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MultilineChanged += handler,
                handler => instance.MultilineChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the PaddingChanged event on the TextBoxBase instance.
        /// </summary>
        /// <param name="instance">The TextBoxBase instance to observe.</param>
        /// <returns>An observable sequence wrapping the PaddingChanged event on the TextBoxBase instance.</returns>
        public static IObservable<EventPattern<EventArgs>> PaddingChangedObservable(this TextBoxBase instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.PaddingChanged += handler,
                handler => instance.PaddingChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ReadOnlyChanged event on the TextBoxBase instance.
        /// </summary>
        /// <param name="instance">The TextBoxBase instance to observe.</param>
        /// <returns>An observable sequence wrapping the ReadOnlyChanged event on the TextBoxBase instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ReadOnlyChangedObservable(this TextBoxBase instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ReadOnlyChanged += handler,
                handler => instance.ReadOnlyChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Paint event on the TextBoxBase instance.
        /// </summary>
        /// <param name="instance">The TextBoxBase instance to observe.</param>
        /// <returns>An observable sequence wrapping the Paint event on the TextBoxBase instance.</returns>
        public static IObservable<EventPattern<PaintEventArgs>> PaintObservable(this TextBoxBase instance)
        {
            return Observable.FromEventPattern<PaintEventHandler, PaintEventArgs>(
                handler => instance.Paint += handler,
                handler => instance.Paint -= handler);
        }
    }
}

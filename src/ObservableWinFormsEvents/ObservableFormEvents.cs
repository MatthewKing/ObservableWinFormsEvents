namespace System.Windows.Forms
{
    using System;
    using System.ComponentModel;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on Form.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class ObservableFormEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the AutoSizeChanged event on the Form instance.
        /// </summary>
        /// <param name="instance">The Form instance to observe.</param>
        /// <returns>An observable sequence wrapping the AutoSizeChanged event on the Form instance.</returns>
        public static IObservable<EventPattern<EventArgs>> AutoSizeChangedObservable(this Form instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.AutoSizeChanged += handler,
                handler => instance.AutoSizeChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the AutoValidateChanged event on the Form instance.
        /// </summary>
        /// <param name="instance">The Form instance to observe.</param>
        /// <returns>An observable sequence wrapping the AutoValidateChanged event on the Form instance.</returns>
        public static IObservable<EventPattern<EventArgs>> AutoValidateChangedObservable(this Form instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.AutoValidateChanged += handler,
                handler => instance.AutoValidateChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the HelpButtonClicked event on the Form instance.
        /// </summary>
        /// <param name="instance">The Form instance to observe.</param>
        /// <returns>An observable sequence wrapping the HelpButtonClicked event on the Form instance.</returns>
        public static IObservable<EventPattern<CancelEventArgs>> HelpButtonClickedObservable(this Form instance)
        {
            return Observable.FromEventPattern<CancelEventHandler, CancelEventArgs>(
                handler => instance.HelpButtonClicked += handler,
                handler => instance.HelpButtonClicked -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MaximizedBoundsChanged event on the Form instance.
        /// </summary>
        /// <param name="instance">The Form instance to observe.</param>
        /// <returns>An observable sequence wrapping the MaximizedBoundsChanged event on the Form instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MaximizedBoundsChangedObservable(this Form instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MaximizedBoundsChanged += handler,
                handler => instance.MaximizedBoundsChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MaximumSizeChanged event on the Form instance.
        /// </summary>
        /// <param name="instance">The Form instance to observe.</param>
        /// <returns>An observable sequence wrapping the MaximumSizeChanged event on the Form instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MaximumSizeChangedObservable(this Form instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MaximumSizeChanged += handler,
                handler => instance.MaximumSizeChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MarginChanged event on the Form instance.
        /// </summary>
        /// <param name="instance">The Form instance to observe.</param>
        /// <returns>An observable sequence wrapping the MarginChanged event on the Form instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MarginChangedObservable(this Form instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MarginChanged += handler,
                handler => instance.MarginChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MinimumSizeChanged event on the Form instance.
        /// </summary>
        /// <param name="instance">The Form instance to observe.</param>
        /// <returns>An observable sequence wrapping the MinimumSizeChanged event on the Form instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MinimumSizeChangedObservable(this Form instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MinimumSizeChanged += handler,
                handler => instance.MinimumSizeChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the TabIndexChanged event on the Form instance.
        /// </summary>
        /// <param name="instance">The Form instance to observe.</param>
        /// <returns>An observable sequence wrapping the TabIndexChanged event on the Form instance.</returns>
        public static IObservable<EventPattern<EventArgs>> TabIndexChangedObservable(this Form instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.TabIndexChanged += handler,
                handler => instance.TabIndexChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the TabStopChanged event on the Form instance.
        /// </summary>
        /// <param name="instance">The Form instance to observe.</param>
        /// <returns>An observable sequence wrapping the TabStopChanged event on the Form instance.</returns>
        public static IObservable<EventPattern<EventArgs>> TabStopChangedObservable(this Form instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.TabStopChanged += handler,
                handler => instance.TabStopChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Activated event on the Form instance.
        /// </summary>
        /// <param name="instance">The Form instance to observe.</param>
        /// <returns>An observable sequence wrapping the Activated event on the Form instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ActivatedObservable(this Form instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Activated += handler,
                handler => instance.Activated -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Closing event on the Form instance.
        /// </summary>
        /// <param name="instance">The Form instance to observe.</param>
        /// <returns>An observable sequence wrapping the Closing event on the Form instance.</returns>
        public static IObservable<EventPattern<CancelEventArgs>> ClosingObservable(this Form instance)
        {
            return Observable.FromEventPattern<CancelEventHandler, CancelEventArgs>(
                handler => instance.Closing += handler,
                handler => instance.Closing -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Closed event on the Form instance.
        /// </summary>
        /// <param name="instance">The Form instance to observe.</param>
        /// <returns>An observable sequence wrapping the Closed event on the Form instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ClosedObservable(this Form instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Closed += handler,
                handler => instance.Closed -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Deactivate event on the Form instance.
        /// </summary>
        /// <param name="instance">The Form instance to observe.</param>
        /// <returns>An observable sequence wrapping the Deactivate event on the Form instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DeactivateObservable(this Form instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Deactivate += handler,
                handler => instance.Deactivate -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the FormClosing event on the Form instance.
        /// </summary>
        /// <param name="instance">The Form instance to observe.</param>
        /// <returns>An observable sequence wrapping the FormClosing event on the Form instance.</returns>
        public static IObservable<EventPattern<FormClosingEventArgs>> FormClosingObservable(this Form instance)
        {
            return Observable.FromEventPattern<FormClosingEventHandler, FormClosingEventArgs>(
                handler => instance.FormClosing += handler,
                handler => instance.FormClosing -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the FormClosed event on the Form instance.
        /// </summary>
        /// <param name="instance">The Form instance to observe.</param>
        /// <returns>An observable sequence wrapping the FormClosed event on the Form instance.</returns>
        public static IObservable<EventPattern<FormClosedEventArgs>> FormClosedObservable(this Form instance)
        {
            return Observable.FromEventPattern<FormClosedEventHandler, FormClosedEventArgs>(
                handler => instance.FormClosed += handler,
                handler => instance.FormClosed -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Load event on the Form instance.
        /// </summary>
        /// <param name="instance">The Form instance to observe.</param>
        /// <returns>An observable sequence wrapping the Load event on the Form instance.</returns>
        public static IObservable<EventPattern<EventArgs>> LoadObservable(this Form instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Load += handler,
                handler => instance.Load -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MdiChildActivate event on the Form instance.
        /// </summary>
        /// <param name="instance">The Form instance to observe.</param>
        /// <returns>An observable sequence wrapping the MdiChildActivate event on the Form instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MdiChildActivateObservable(this Form instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MdiChildActivate += handler,
                handler => instance.MdiChildActivate -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MenuComplete event on the Form instance.
        /// </summary>
        /// <param name="instance">The Form instance to observe.</param>
        /// <returns>An observable sequence wrapping the MenuComplete event on the Form instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MenuCompleteObservable(this Form instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MenuComplete += handler,
                handler => instance.MenuComplete -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MenuStart event on the Form instance.
        /// </summary>
        /// <param name="instance">The Form instance to observe.</param>
        /// <returns>An observable sequence wrapping the MenuStart event on the Form instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MenuStartObservable(this Form instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MenuStart += handler,
                handler => instance.MenuStart -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the InputLanguageChanged event on the Form instance.
        /// </summary>
        /// <param name="instance">The Form instance to observe.</param>
        /// <returns>An observable sequence wrapping the InputLanguageChanged event on the Form instance.</returns>
        public static IObservable<EventPattern<InputLanguageChangedEventArgs>> InputLanguageChangedObservable(this Form instance)
        {
            return Observable.FromEventPattern<InputLanguageChangedEventHandler, InputLanguageChangedEventArgs>(
                handler => instance.InputLanguageChanged += handler,
                handler => instance.InputLanguageChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the InputLanguageChanging event on the Form instance.
        /// </summary>
        /// <param name="instance">The Form instance to observe.</param>
        /// <returns>An observable sequence wrapping the InputLanguageChanging event on the Form instance.</returns>
        public static IObservable<EventPattern<InputLanguageChangingEventArgs>> InputLanguageChangingObservable(this Form instance)
        {
            return Observable.FromEventPattern<InputLanguageChangingEventHandler, InputLanguageChangingEventArgs>(
                handler => instance.InputLanguageChanging += handler,
                handler => instance.InputLanguageChanging -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RightToLeftLayoutChanged event on the Form instance.
        /// </summary>
        /// <param name="instance">The Form instance to observe.</param>
        /// <returns>An observable sequence wrapping the RightToLeftLayoutChanged event on the Form instance.</returns>
        public static IObservable<EventPattern<EventArgs>> RightToLeftLayoutChangedObservable(this Form instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.RightToLeftLayoutChanged += handler,
                handler => instance.RightToLeftLayoutChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Shown event on the Form instance.
        /// </summary>
        /// <param name="instance">The Form instance to observe.</param>
        /// <returns>An observable sequence wrapping the Shown event on the Form instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ShownObservable(this Form instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Shown += handler,
                handler => instance.Shown -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ResizeBegin event on the Form instance.
        /// </summary>
        /// <param name="instance">The Form instance to observe.</param>
        /// <returns>An observable sequence wrapping the ResizeBegin event on the Form instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ResizeBeginObservable(this Form instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ResizeBegin += handler,
                handler => instance.ResizeBegin -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ResizeEnd event on the Form instance.
        /// </summary>
        /// <param name="instance">The Form instance to observe.</param>
        /// <returns>An observable sequence wrapping the ResizeEnd event on the Form instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ResizeEndObservable(this Form instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ResizeEnd += handler,
                handler => instance.ResizeEnd -= handler);
        }
    }
}

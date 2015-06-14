namespace System.Windows.Forms
{
    using System;
    using System.ComponentModel;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on ToolStripTextBox.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class ObservableToolStripTextBoxEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the AcceptsTabChanged event on the ToolStripTextBox instance.
        /// </summary>
        /// <param name="instance">The ToolStripTextBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the AcceptsTabChanged event on the ToolStripTextBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> AcceptsTabChangedObservable(this ToolStripTextBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.AcceptsTabChanged += handler,
                handler => instance.AcceptsTabChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BorderStyleChanged event on the ToolStripTextBox instance.
        /// </summary>
        /// <param name="instance">The ToolStripTextBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the BorderStyleChanged event on the ToolStripTextBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BorderStyleChangedObservable(this ToolStripTextBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BorderStyleChanged += handler,
                handler => instance.BorderStyleChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the HideSelectionChanged event on the ToolStripTextBox instance.
        /// </summary>
        /// <param name="instance">The ToolStripTextBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the HideSelectionChanged event on the ToolStripTextBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> HideSelectionChangedObservable(this ToolStripTextBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.HideSelectionChanged += handler,
                handler => instance.HideSelectionChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ModifiedChanged event on the ToolStripTextBox instance.
        /// </summary>
        /// <param name="instance">The ToolStripTextBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the ModifiedChanged event on the ToolStripTextBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ModifiedChangedObservable(this ToolStripTextBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ModifiedChanged += handler,
                handler => instance.ModifiedChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MultilineChanged event on the ToolStripTextBox instance.
        /// </summary>
        /// <param name="instance">The ToolStripTextBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the MultilineChanged event on the ToolStripTextBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MultilineChangedObservable(this ToolStripTextBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MultilineChanged += handler,
                handler => instance.MultilineChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ReadOnlyChanged event on the ToolStripTextBox instance.
        /// </summary>
        /// <param name="instance">The ToolStripTextBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the ReadOnlyChanged event on the ToolStripTextBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ReadOnlyChangedObservable(this ToolStripTextBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ReadOnlyChanged += handler,
                handler => instance.ReadOnlyChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the TextBoxTextAlignChanged event on the ToolStripTextBox instance.
        /// </summary>
        /// <param name="instance">The ToolStripTextBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the TextBoxTextAlignChanged event on the ToolStripTextBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> TextBoxTextAlignChangedObservable(this ToolStripTextBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.TextBoxTextAlignChanged += handler,
                handler => instance.TextBoxTextAlignChanged -= handler);
        }
    }
}

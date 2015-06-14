namespace System.Windows.Forms
{
    using System;
    using System.ComponentModel;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on ToolStripComboBox.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class ObservableToolStripComboBoxEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the DoubleClick event on the ToolStripComboBox instance.
        /// </summary>
        /// <param name="instance">The ToolStripComboBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the DoubleClick event on the ToolStripComboBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DoubleClickObservable(this ToolStripComboBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DoubleClick += handler,
                handler => instance.DoubleClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DropDown event on the ToolStripComboBox instance.
        /// </summary>
        /// <param name="instance">The ToolStripComboBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the DropDown event on the ToolStripComboBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DropDownObservable(this ToolStripComboBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DropDown += handler,
                handler => instance.DropDown -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DropDownClosed event on the ToolStripComboBox instance.
        /// </summary>
        /// <param name="instance">The ToolStripComboBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the DropDownClosed event on the ToolStripComboBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DropDownClosedObservable(this ToolStripComboBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DropDownClosed += handler,
                handler => instance.DropDownClosed -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DropDownStyleChanged event on the ToolStripComboBox instance.
        /// </summary>
        /// <param name="instance">The ToolStripComboBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the DropDownStyleChanged event on the ToolStripComboBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DropDownStyleChangedObservable(this ToolStripComboBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DropDownStyleChanged += handler,
                handler => instance.DropDownStyleChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the SelectedIndexChanged event on the ToolStripComboBox instance.
        /// </summary>
        /// <param name="instance">The ToolStripComboBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the SelectedIndexChanged event on the ToolStripComboBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> SelectedIndexChangedObservable(this ToolStripComboBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.SelectedIndexChanged += handler,
                handler => instance.SelectedIndexChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the TextUpdate event on the ToolStripComboBox instance.
        /// </summary>
        /// <param name="instance">The ToolStripComboBox instance to observe.</param>
        /// <returns>An observable sequence wrapping the TextUpdate event on the ToolStripComboBox instance.</returns>
        public static IObservable<EventPattern<EventArgs>> TextUpdateObservable(this ToolStripComboBox instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.TextUpdate += handler,
                handler => instance.TextUpdate -= handler);
        }
    }
}

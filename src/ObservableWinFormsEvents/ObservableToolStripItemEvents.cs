namespace System.Windows.Forms
{
    using System;
    using System.ComponentModel;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on ToolStripItem.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class ObservableToolStripItemEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the AvailableChanged event on the ToolStripItem instance.
        /// </summary>
        /// <param name="instance">The ToolStripItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the AvailableChanged event on the ToolStripItem instance.</returns>
        public static IObservable<EventPattern<EventArgs>> AvailableChangedObservable(this ToolStripItem instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.AvailableChanged += handler,
                handler => instance.AvailableChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackColorChanged event on the ToolStripItem instance.
        /// </summary>
        /// <param name="instance">The ToolStripItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackColorChanged event on the ToolStripItem instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackColorChangedObservable(this ToolStripItem instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackColorChanged += handler,
                handler => instance.BackColorChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Click event on the ToolStripItem instance.
        /// </summary>
        /// <param name="instance">The ToolStripItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the Click event on the ToolStripItem instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ClickObservable(this ToolStripItem instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Click += handler,
                handler => instance.Click -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DisplayStyleChanged event on the ToolStripItem instance.
        /// </summary>
        /// <param name="instance">The ToolStripItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the DisplayStyleChanged event on the ToolStripItem instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DisplayStyleChangedObservable(this ToolStripItem instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DisplayStyleChanged += handler,
                handler => instance.DisplayStyleChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DoubleClick event on the ToolStripItem instance.
        /// </summary>
        /// <param name="instance">The ToolStripItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the DoubleClick event on the ToolStripItem instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DoubleClickObservable(this ToolStripItem instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DoubleClick += handler,
                handler => instance.DoubleClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DragDrop event on the ToolStripItem instance.
        /// </summary>
        /// <param name="instance">The ToolStripItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the DragDrop event on the ToolStripItem instance.</returns>
        public static IObservable<EventPattern<DragEventArgs>> DragDropObservable(this ToolStripItem instance)
        {
            return Observable.FromEventPattern<DragEventHandler, DragEventArgs>(
                handler => instance.DragDrop += handler,
                handler => instance.DragDrop -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DragEnter event on the ToolStripItem instance.
        /// </summary>
        /// <param name="instance">The ToolStripItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the DragEnter event on the ToolStripItem instance.</returns>
        public static IObservable<EventPattern<DragEventArgs>> DragEnterObservable(this ToolStripItem instance)
        {
            return Observable.FromEventPattern<DragEventHandler, DragEventArgs>(
                handler => instance.DragEnter += handler,
                handler => instance.DragEnter -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DragOver event on the ToolStripItem instance.
        /// </summary>
        /// <param name="instance">The ToolStripItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the DragOver event on the ToolStripItem instance.</returns>
        public static IObservable<EventPattern<DragEventArgs>> DragOverObservable(this ToolStripItem instance)
        {
            return Observable.FromEventPattern<DragEventHandler, DragEventArgs>(
                handler => instance.DragOver += handler,
                handler => instance.DragOver -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DragLeave event on the ToolStripItem instance.
        /// </summary>
        /// <param name="instance">The ToolStripItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the DragLeave event on the ToolStripItem instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DragLeaveObservable(this ToolStripItem instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DragLeave += handler,
                handler => instance.DragLeave -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the EnabledChanged event on the ToolStripItem instance.
        /// </summary>
        /// <param name="instance">The ToolStripItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the EnabledChanged event on the ToolStripItem instance.</returns>
        public static IObservable<EventPattern<EventArgs>> EnabledChangedObservable(this ToolStripItem instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.EnabledChanged += handler,
                handler => instance.EnabledChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ForeColorChanged event on the ToolStripItem instance.
        /// </summary>
        /// <param name="instance">The ToolStripItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the ForeColorChanged event on the ToolStripItem instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ForeColorChangedObservable(this ToolStripItem instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ForeColorChanged += handler,
                handler => instance.ForeColorChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the GiveFeedback event on the ToolStripItem instance.
        /// </summary>
        /// <param name="instance">The ToolStripItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the GiveFeedback event on the ToolStripItem instance.</returns>
        public static IObservable<EventPattern<GiveFeedbackEventArgs>> GiveFeedbackObservable(this ToolStripItem instance)
        {
            return Observable.FromEventPattern<GiveFeedbackEventHandler, GiveFeedbackEventArgs>(
                handler => instance.GiveFeedback += handler,
                handler => instance.GiveFeedback -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the LocationChanged event on the ToolStripItem instance.
        /// </summary>
        /// <param name="instance">The ToolStripItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the LocationChanged event on the ToolStripItem instance.</returns>
        public static IObservable<EventPattern<EventArgs>> LocationChangedObservable(this ToolStripItem instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.LocationChanged += handler,
                handler => instance.LocationChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseDown event on the ToolStripItem instance.
        /// </summary>
        /// <param name="instance">The ToolStripItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseDown event on the ToolStripItem instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseDownObservable(this ToolStripItem instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseDown += handler,
                handler => instance.MouseDown -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseEnter event on the ToolStripItem instance.
        /// </summary>
        /// <param name="instance">The ToolStripItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseEnter event on the ToolStripItem instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MouseEnterObservable(this ToolStripItem instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MouseEnter += handler,
                handler => instance.MouseEnter -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseLeave event on the ToolStripItem instance.
        /// </summary>
        /// <param name="instance">The ToolStripItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseLeave event on the ToolStripItem instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MouseLeaveObservable(this ToolStripItem instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MouseLeave += handler,
                handler => instance.MouseLeave -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseHover event on the ToolStripItem instance.
        /// </summary>
        /// <param name="instance">The ToolStripItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseHover event on the ToolStripItem instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MouseHoverObservable(this ToolStripItem instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MouseHover += handler,
                handler => instance.MouseHover -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseMove event on the ToolStripItem instance.
        /// </summary>
        /// <param name="instance">The ToolStripItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseMove event on the ToolStripItem instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseMoveObservable(this ToolStripItem instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseMove += handler,
                handler => instance.MouseMove -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseUp event on the ToolStripItem instance.
        /// </summary>
        /// <param name="instance">The ToolStripItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseUp event on the ToolStripItem instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseUpObservable(this ToolStripItem instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseUp += handler,
                handler => instance.MouseUp -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the OwnerChanged event on the ToolStripItem instance.
        /// </summary>
        /// <param name="instance">The ToolStripItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the OwnerChanged event on the ToolStripItem instance.</returns>
        public static IObservable<EventPattern<EventArgs>> OwnerChangedObservable(this ToolStripItem instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.OwnerChanged += handler,
                handler => instance.OwnerChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Paint event on the ToolStripItem instance.
        /// </summary>
        /// <param name="instance">The ToolStripItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the Paint event on the ToolStripItem instance.</returns>
        public static IObservable<EventPattern<PaintEventArgs>> PaintObservable(this ToolStripItem instance)
        {
            return Observable.FromEventPattern<PaintEventHandler, PaintEventArgs>(
                handler => instance.Paint += handler,
                handler => instance.Paint -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the QueryContinueDrag event on the ToolStripItem instance.
        /// </summary>
        /// <param name="instance">The ToolStripItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the QueryContinueDrag event on the ToolStripItem instance.</returns>
        public static IObservable<EventPattern<QueryContinueDragEventArgs>> QueryContinueDragObservable(this ToolStripItem instance)
        {
            return Observable.FromEventPattern<QueryContinueDragEventHandler, QueryContinueDragEventArgs>(
                handler => instance.QueryContinueDrag += handler,
                handler => instance.QueryContinueDrag -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the QueryAccessibilityHelp event on the ToolStripItem instance.
        /// </summary>
        /// <param name="instance">The ToolStripItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the QueryAccessibilityHelp event on the ToolStripItem instance.</returns>
        public static IObservable<EventPattern<QueryAccessibilityHelpEventArgs>> QueryAccessibilityHelpObservable(this ToolStripItem instance)
        {
            return Observable.FromEventPattern<QueryAccessibilityHelpEventHandler, QueryAccessibilityHelpEventArgs>(
                handler => instance.QueryAccessibilityHelp += handler,
                handler => instance.QueryAccessibilityHelp -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RightToLeftChanged event on the ToolStripItem instance.
        /// </summary>
        /// <param name="instance">The ToolStripItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the RightToLeftChanged event on the ToolStripItem instance.</returns>
        public static IObservable<EventPattern<EventArgs>> RightToLeftChangedObservable(this ToolStripItem instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.RightToLeftChanged += handler,
                handler => instance.RightToLeftChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the TextChanged event on the ToolStripItem instance.
        /// </summary>
        /// <param name="instance">The ToolStripItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the TextChanged event on the ToolStripItem instance.</returns>
        public static IObservable<EventPattern<EventArgs>> TextChangedObservable(this ToolStripItem instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.TextChanged += handler,
                handler => instance.TextChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the VisibleChanged event on the ToolStripItem instance.
        /// </summary>
        /// <param name="instance">The ToolStripItem instance to observe.</param>
        /// <returns>An observable sequence wrapping the VisibleChanged event on the ToolStripItem instance.</returns>
        public static IObservable<EventPattern<EventArgs>> VisibleChangedObservable(this ToolStripItem instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.VisibleChanged += handler,
                handler => instance.VisibleChanged -= handler);
        }
    }
}

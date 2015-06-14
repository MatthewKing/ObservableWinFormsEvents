namespace System.Windows.Forms
{
    using System;
    using System.ComponentModel;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on AxHost.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class ObservableAxHostEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the MouseClick event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseClick event on the AxHost instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MouseClickObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MouseClick += handler,
                handler => instance.MouseClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseDoubleClick event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseDoubleClick event on the AxHost instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MouseDoubleClickObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MouseDoubleClick += handler,
                handler => instance.MouseDoubleClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackColorChanged event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackColorChanged event on the AxHost instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackColorChangedObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackColorChanged += handler,
                handler => instance.BackColorChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageChanged event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageChanged event on the AxHost instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageChangedObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageChanged += handler,
                handler => instance.BackgroundImageChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageLayoutChanged event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageLayoutChanged event on the AxHost instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageLayoutChangedObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageLayoutChanged += handler,
                handler => instance.BackgroundImageLayoutChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BindingContextChanged event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the BindingContextChanged event on the AxHost instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BindingContextChangedObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BindingContextChanged += handler,
                handler => instance.BindingContextChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ContextMenuChanged event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the ContextMenuChanged event on the AxHost instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ContextMenuChangedObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ContextMenuChanged += handler,
                handler => instance.ContextMenuChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CursorChanged event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the CursorChanged event on the AxHost instance.</returns>
        public static IObservable<EventPattern<EventArgs>> CursorChangedObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.CursorChanged += handler,
                handler => instance.CursorChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the EnabledChanged event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the EnabledChanged event on the AxHost instance.</returns>
        public static IObservable<EventPattern<EventArgs>> EnabledChangedObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.EnabledChanged += handler,
                handler => instance.EnabledChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the FontChanged event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the FontChanged event on the AxHost instance.</returns>
        public static IObservable<EventPattern<EventArgs>> FontChangedObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.FontChanged += handler,
                handler => instance.FontChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ForeColorChanged event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the ForeColorChanged event on the AxHost instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ForeColorChangedObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ForeColorChanged += handler,
                handler => instance.ForeColorChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RightToLeftChanged event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the RightToLeftChanged event on the AxHost instance.</returns>
        public static IObservable<EventPattern<EventArgs>> RightToLeftChangedObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.RightToLeftChanged += handler,
                handler => instance.RightToLeftChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the TextChanged event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the TextChanged event on the AxHost instance.</returns>
        public static IObservable<EventPattern<EventArgs>> TextChangedObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.TextChanged += handler,
                handler => instance.TextChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Click event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the Click event on the AxHost instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ClickObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Click += handler,
                handler => instance.Click -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DragDrop event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the DragDrop event on the AxHost instance.</returns>
        public static IObservable<EventPattern<DragEventArgs>> DragDropObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<DragEventHandler, DragEventArgs>(
                handler => instance.DragDrop += handler,
                handler => instance.DragDrop -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DragEnter event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the DragEnter event on the AxHost instance.</returns>
        public static IObservable<EventPattern<DragEventArgs>> DragEnterObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<DragEventHandler, DragEventArgs>(
                handler => instance.DragEnter += handler,
                handler => instance.DragEnter -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DragOver event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the DragOver event on the AxHost instance.</returns>
        public static IObservable<EventPattern<DragEventArgs>> DragOverObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<DragEventHandler, DragEventArgs>(
                handler => instance.DragOver += handler,
                handler => instance.DragOver -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DragLeave event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the DragLeave event on the AxHost instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DragLeaveObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DragLeave += handler,
                handler => instance.DragLeave -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the GiveFeedback event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the GiveFeedback event on the AxHost instance.</returns>
        public static IObservable<EventPattern<GiveFeedbackEventArgs>> GiveFeedbackObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<GiveFeedbackEventHandler, GiveFeedbackEventArgs>(
                handler => instance.GiveFeedback += handler,
                handler => instance.GiveFeedback -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the HelpRequested event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the HelpRequested event on the AxHost instance.</returns>
        public static IObservable<EventPattern<HelpEventArgs>> HelpRequestedObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<HelpEventHandler, HelpEventArgs>(
                handler => instance.HelpRequested += handler,
                handler => instance.HelpRequested -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Paint event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the Paint event on the AxHost instance.</returns>
        public static IObservable<EventPattern<PaintEventArgs>> PaintObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<PaintEventHandler, PaintEventArgs>(
                handler => instance.Paint += handler,
                handler => instance.Paint -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the QueryContinueDrag event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the QueryContinueDrag event on the AxHost instance.</returns>
        public static IObservable<EventPattern<QueryContinueDragEventArgs>> QueryContinueDragObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<QueryContinueDragEventHandler, QueryContinueDragEventArgs>(
                handler => instance.QueryContinueDrag += handler,
                handler => instance.QueryContinueDrag -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the QueryAccessibilityHelp event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the QueryAccessibilityHelp event on the AxHost instance.</returns>
        public static IObservable<EventPattern<QueryAccessibilityHelpEventArgs>> QueryAccessibilityHelpObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<QueryAccessibilityHelpEventHandler, QueryAccessibilityHelpEventArgs>(
                handler => instance.QueryAccessibilityHelp += handler,
                handler => instance.QueryAccessibilityHelp -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DoubleClick event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the DoubleClick event on the AxHost instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DoubleClickObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DoubleClick += handler,
                handler => instance.DoubleClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ImeModeChanged event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the ImeModeChanged event on the AxHost instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ImeModeChangedObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ImeModeChanged += handler,
                handler => instance.ImeModeChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the KeyDown event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the KeyDown event on the AxHost instance.</returns>
        public static IObservable<EventPattern<KeyEventArgs>> KeyDownObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(
                handler => instance.KeyDown += handler,
                handler => instance.KeyDown -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the KeyPress event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the KeyPress event on the AxHost instance.</returns>
        public static IObservable<EventPattern<KeyPressEventArgs>> KeyPressObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<KeyPressEventHandler, KeyPressEventArgs>(
                handler => instance.KeyPress += handler,
                handler => instance.KeyPress -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the KeyUp event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the KeyUp event on the AxHost instance.</returns>
        public static IObservable<EventPattern<KeyEventArgs>> KeyUpObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(
                handler => instance.KeyUp += handler,
                handler => instance.KeyUp -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Layout event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the Layout event on the AxHost instance.</returns>
        public static IObservable<EventPattern<LayoutEventArgs>> LayoutObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<LayoutEventHandler, LayoutEventArgs>(
                handler => instance.Layout += handler,
                handler => instance.Layout -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseDown event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseDown event on the AxHost instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseDownObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseDown += handler,
                handler => instance.MouseDown -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseEnter event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseEnter event on the AxHost instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MouseEnterObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MouseEnter += handler,
                handler => instance.MouseEnter -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseLeave event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseLeave event on the AxHost instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MouseLeaveObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MouseLeave += handler,
                handler => instance.MouseLeave -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseHover event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseHover event on the AxHost instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MouseHoverObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MouseHover += handler,
                handler => instance.MouseHover -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseMove event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseMove event on the AxHost instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseMoveObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseMove += handler,
                handler => instance.MouseMove -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseUp event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseUp event on the AxHost instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseUpObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseUp += handler,
                handler => instance.MouseUp -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseWheel event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseWheel event on the AxHost instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseWheelObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseWheel += handler,
                handler => instance.MouseWheel -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ChangeUICues event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the ChangeUICues event on the AxHost instance.</returns>
        public static IObservable<EventPattern<UICuesEventArgs>> ChangeUICuesObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<UICuesEventHandler, UICuesEventArgs>(
                handler => instance.ChangeUICues += handler,
                handler => instance.ChangeUICues -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the StyleChanged event on the AxHost instance.
        /// </summary>
        /// <param name="instance">The AxHost instance to observe.</param>
        /// <returns>An observable sequence wrapping the StyleChanged event on the AxHost instance.</returns>
        public static IObservable<EventPattern<EventArgs>> StyleChangedObservable(this AxHost instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.StyleChanged += handler,
                handler => instance.StyleChanged -= handler);
        }
    }
}

namespace System.Windows.Forms
{
    using System;
    using System.ComponentModel;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on Control.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class ObservableControlEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the AutoSizeChanged event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the AutoSizeChanged event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> AutoSizeChangedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.AutoSizeChanged += handler,
                handler => instance.AutoSizeChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackColorChanged event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackColorChanged event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackColorChangedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackColorChanged += handler,
                handler => instance.BackColorChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageChanged event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageChanged event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageChangedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageChanged += handler,
                handler => instance.BackgroundImageChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageLayoutChanged event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageLayoutChanged event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageLayoutChangedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageLayoutChanged += handler,
                handler => instance.BackgroundImageLayoutChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BindingContextChanged event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the BindingContextChanged event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BindingContextChangedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BindingContextChanged += handler,
                handler => instance.BindingContextChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CausesValidationChanged event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the CausesValidationChanged event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> CausesValidationChangedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.CausesValidationChanged += handler,
                handler => instance.CausesValidationChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ClientSizeChanged event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the ClientSizeChanged event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ClientSizeChangedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ClientSizeChanged += handler,
                handler => instance.ClientSizeChanged -= handler);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns an observable sequence wrapping the ContextMenuChanged event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the ContextMenuChanged event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ContextMenuChangedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ContextMenuChanged += handler,
                handler => instance.ContextMenuChanged -= handler);
        }
#endif

        /// <summary>
        /// Returns an observable sequence wrapping the ContextMenuStripChanged event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the ContextMenuStripChanged event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ContextMenuStripChangedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ContextMenuStripChanged += handler,
                handler => instance.ContextMenuStripChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CursorChanged event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the CursorChanged event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> CursorChangedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.CursorChanged += handler,
                handler => instance.CursorChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DockChanged event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the DockChanged event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DockChangedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DockChanged += handler,
                handler => instance.DockChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the EnabledChanged event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the EnabledChanged event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> EnabledChangedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.EnabledChanged += handler,
                handler => instance.EnabledChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the FontChanged event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the FontChanged event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> FontChangedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.FontChanged += handler,
                handler => instance.FontChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ForeColorChanged event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the ForeColorChanged event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ForeColorChangedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ForeColorChanged += handler,
                handler => instance.ForeColorChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the LocationChanged event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the LocationChanged event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> LocationChangedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.LocationChanged += handler,
                handler => instance.LocationChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MarginChanged event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the MarginChanged event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MarginChangedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MarginChanged += handler,
                handler => instance.MarginChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RegionChanged event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the RegionChanged event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> RegionChangedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.RegionChanged += handler,
                handler => instance.RegionChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RightToLeftChanged event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the RightToLeftChanged event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> RightToLeftChangedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.RightToLeftChanged += handler,
                handler => instance.RightToLeftChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the SizeChanged event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the SizeChanged event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> SizeChangedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.SizeChanged += handler,
                handler => instance.SizeChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the TabIndexChanged event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the TabIndexChanged event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> TabIndexChangedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.TabIndexChanged += handler,
                handler => instance.TabIndexChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the TabStopChanged event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the TabStopChanged event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> TabStopChangedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.TabStopChanged += handler,
                handler => instance.TabStopChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the TextChanged event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the TextChanged event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> TextChangedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.TextChanged += handler,
                handler => instance.TextChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the VisibleChanged event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the VisibleChanged event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> VisibleChangedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.VisibleChanged += handler,
                handler => instance.VisibleChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Click event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the Click event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ClickObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Click += handler,
                handler => instance.Click -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ControlAdded event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the ControlAdded event on the Control instance.</returns>
        public static IObservable<EventPattern<ControlEventArgs>> ControlAddedObservable(this Control instance)
        {
            return Observable.FromEventPattern<ControlEventHandler, ControlEventArgs>(
                handler => instance.ControlAdded += handler,
                handler => instance.ControlAdded -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ControlRemoved event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the ControlRemoved event on the Control instance.</returns>
        public static IObservable<EventPattern<ControlEventArgs>> ControlRemovedObservable(this Control instance)
        {
            return Observable.FromEventPattern<ControlEventHandler, ControlEventArgs>(
                handler => instance.ControlRemoved += handler,
                handler => instance.ControlRemoved -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DragDrop event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the DragDrop event on the Control instance.</returns>
        public static IObservable<EventPattern<DragEventArgs>> DragDropObservable(this Control instance)
        {
            return Observable.FromEventPattern<DragEventHandler, DragEventArgs>(
                handler => instance.DragDrop += handler,
                handler => instance.DragDrop -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DragEnter event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the DragEnter event on the Control instance.</returns>
        public static IObservable<EventPattern<DragEventArgs>> DragEnterObservable(this Control instance)
        {
            return Observable.FromEventPattern<DragEventHandler, DragEventArgs>(
                handler => instance.DragEnter += handler,
                handler => instance.DragEnter -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DragOver event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the DragOver event on the Control instance.</returns>
        public static IObservable<EventPattern<DragEventArgs>> DragOverObservable(this Control instance)
        {
            return Observable.FromEventPattern<DragEventHandler, DragEventArgs>(
                handler => instance.DragOver += handler,
                handler => instance.DragOver -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DragLeave event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the DragLeave event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DragLeaveObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DragLeave += handler,
                handler => instance.DragLeave -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the GiveFeedback event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the GiveFeedback event on the Control instance.</returns>
        public static IObservable<EventPattern<GiveFeedbackEventArgs>> GiveFeedbackObservable(this Control instance)
        {
            return Observable.FromEventPattern<GiveFeedbackEventHandler, GiveFeedbackEventArgs>(
                handler => instance.GiveFeedback += handler,
                handler => instance.GiveFeedback -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the HandleCreated event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the HandleCreated event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> HandleCreatedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.HandleCreated += handler,
                handler => instance.HandleCreated -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the HandleDestroyed event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the HandleDestroyed event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> HandleDestroyedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.HandleDestroyed += handler,
                handler => instance.HandleDestroyed -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the HelpRequested event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the HelpRequested event on the Control instance.</returns>
        public static IObservable<EventPattern<HelpEventArgs>> HelpRequestedObservable(this Control instance)
        {
            return Observable.FromEventPattern<HelpEventHandler, HelpEventArgs>(
                handler => instance.HelpRequested += handler,
                handler => instance.HelpRequested -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Invalidated event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the Invalidated event on the Control instance.</returns>
        public static IObservable<EventPattern<InvalidateEventArgs>> InvalidatedObservable(this Control instance)
        {
            return Observable.FromEventPattern<InvalidateEventHandler, InvalidateEventArgs>(
                handler => instance.Invalidated += handler,
                handler => instance.Invalidated -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the PaddingChanged event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the PaddingChanged event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> PaddingChangedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.PaddingChanged += handler,
                handler => instance.PaddingChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Paint event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the Paint event on the Control instance.</returns>
        public static IObservable<EventPattern<PaintEventArgs>> PaintObservable(this Control instance)
        {
            return Observable.FromEventPattern<PaintEventHandler, PaintEventArgs>(
                handler => instance.Paint += handler,
                handler => instance.Paint -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the QueryContinueDrag event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the QueryContinueDrag event on the Control instance.</returns>
        public static IObservable<EventPattern<QueryContinueDragEventArgs>> QueryContinueDragObservable(this Control instance)
        {
            return Observable.FromEventPattern<QueryContinueDragEventHandler, QueryContinueDragEventArgs>(
                handler => instance.QueryContinueDrag += handler,
                handler => instance.QueryContinueDrag -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the QueryAccessibilityHelp event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the QueryAccessibilityHelp event on the Control instance.</returns>
        public static IObservable<EventPattern<QueryAccessibilityHelpEventArgs>> QueryAccessibilityHelpObservable(this Control instance)
        {
            return Observable.FromEventPattern<QueryAccessibilityHelpEventHandler, QueryAccessibilityHelpEventArgs>(
                handler => instance.QueryAccessibilityHelp += handler,
                handler => instance.QueryAccessibilityHelp -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DoubleClick event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the DoubleClick event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DoubleClickObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DoubleClick += handler,
                handler => instance.DoubleClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Enter event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the Enter event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> EnterObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Enter += handler,
                handler => instance.Enter -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the GotFocus event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the GotFocus event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> GotFocusObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.GotFocus += handler,
                handler => instance.GotFocus -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the KeyDown event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the KeyDown event on the Control instance.</returns>
        public static IObservable<EventPattern<KeyEventArgs>> KeyDownObservable(this Control instance)
        {
            return Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(
                handler => instance.KeyDown += handler,
                handler => instance.KeyDown -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the KeyPress event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the KeyPress event on the Control instance.</returns>
        public static IObservable<EventPattern<KeyPressEventArgs>> KeyPressObservable(this Control instance)
        {
            return Observable.FromEventPattern<KeyPressEventHandler, KeyPressEventArgs>(
                handler => instance.KeyPress += handler,
                handler => instance.KeyPress -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the KeyUp event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the KeyUp event on the Control instance.</returns>
        public static IObservable<EventPattern<KeyEventArgs>> KeyUpObservable(this Control instance)
        {
            return Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(
                handler => instance.KeyUp += handler,
                handler => instance.KeyUp -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Layout event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the Layout event on the Control instance.</returns>
        public static IObservable<EventPattern<LayoutEventArgs>> LayoutObservable(this Control instance)
        {
            return Observable.FromEventPattern<LayoutEventHandler, LayoutEventArgs>(
                handler => instance.Layout += handler,
                handler => instance.Layout -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Leave event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the Leave event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> LeaveObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Leave += handler,
                handler => instance.Leave -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the LostFocus event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the LostFocus event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> LostFocusObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.LostFocus += handler,
                handler => instance.LostFocus -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseClick event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseClick event on the Control instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseClickObservable(this Control instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseClick += handler,
                handler => instance.MouseClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseDoubleClick event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseDoubleClick event on the Control instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseDoubleClickObservable(this Control instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseDoubleClick += handler,
                handler => instance.MouseDoubleClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseCaptureChanged event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseCaptureChanged event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MouseCaptureChangedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MouseCaptureChanged += handler,
                handler => instance.MouseCaptureChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseDown event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseDown event on the Control instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseDownObservable(this Control instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseDown += handler,
                handler => instance.MouseDown -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseEnter event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseEnter event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MouseEnterObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MouseEnter += handler,
                handler => instance.MouseEnter -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseLeave event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseLeave event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MouseLeaveObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MouseLeave += handler,
                handler => instance.MouseLeave -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseHover event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseHover event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MouseHoverObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MouseHover += handler,
                handler => instance.MouseHover -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseMove event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseMove event on the Control instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseMoveObservable(this Control instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseMove += handler,
                handler => instance.MouseMove -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseUp event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseUp event on the Control instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseUpObservable(this Control instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseUp += handler,
                handler => instance.MouseUp -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MouseWheel event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the MouseWheel event on the Control instance.</returns>
        public static IObservable<EventPattern<MouseEventArgs>> MouseWheelObservable(this Control instance)
        {
            return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                handler => instance.MouseWheel += handler,
                handler => instance.MouseWheel -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Move event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the Move event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MoveObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Move += handler,
                handler => instance.Move -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the PreviewKeyDown event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the PreviewKeyDown event on the Control instance.</returns>
        public static IObservable<EventPattern<PreviewKeyDownEventArgs>> PreviewKeyDownObservable(this Control instance)
        {
            return Observable.FromEventPattern<PreviewKeyDownEventHandler, PreviewKeyDownEventArgs>(
                handler => instance.PreviewKeyDown += handler,
                handler => instance.PreviewKeyDown -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Resize event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the Resize event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ResizeObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Resize += handler,
                handler => instance.Resize -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ChangeUICues event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the ChangeUICues event on the Control instance.</returns>
        public static IObservable<EventPattern<UICuesEventArgs>> ChangeUICuesObservable(this Control instance)
        {
            return Observable.FromEventPattern<UICuesEventHandler, UICuesEventArgs>(
                handler => instance.ChangeUICues += handler,
                handler => instance.ChangeUICues -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the StyleChanged event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the StyleChanged event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> StyleChangedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.StyleChanged += handler,
                handler => instance.StyleChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the SystemColorsChanged event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the SystemColorsChanged event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> SystemColorsChangedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.SystemColorsChanged += handler,
                handler => instance.SystemColorsChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Validating event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the Validating event on the Control instance.</returns>
        public static IObservable<EventPattern<CancelEventArgs>> ValidatingObservable(this Control instance)
        {
            return Observable.FromEventPattern<CancelEventHandler, CancelEventArgs>(
                handler => instance.Validating += handler,
                handler => instance.Validating -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Validated event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the Validated event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ValidatedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Validated += handler,
                handler => instance.Validated -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ParentChanged event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the ParentChanged event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ParentChangedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ParentChanged += handler,
                handler => instance.ParentChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ImeModeChanged event on the Control instance.
        /// </summary>
        /// <param name="instance">The Control instance to observe.</param>
        /// <returns>An observable sequence wrapping the ImeModeChanged event on the Control instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ImeModeChangedObservable(this Control instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ImeModeChanged += handler,
                handler => instance.ImeModeChanged -= handler);
        }
    }
}

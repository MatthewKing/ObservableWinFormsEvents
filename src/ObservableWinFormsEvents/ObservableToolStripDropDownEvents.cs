namespace System.Windows.Forms
{
    using System;
    using System.ComponentModel;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on ToolStripDropDown.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class ObservableToolStripDropDownEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageChanged event on the ToolStripDropDown instance.
        /// </summary>
        /// <param name="instance">The ToolStripDropDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageChanged event on the ToolStripDropDown instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageChangedObservable(this ToolStripDropDown instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageChanged += handler,
                handler => instance.BackgroundImageChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageLayoutChanged event on the ToolStripDropDown instance.
        /// </summary>
        /// <param name="instance">The ToolStripDropDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageLayoutChanged event on the ToolStripDropDown instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageLayoutChangedObservable(this ToolStripDropDown instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageLayoutChanged += handler,
                handler => instance.BackgroundImageLayoutChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BindingContextChanged event on the ToolStripDropDown instance.
        /// </summary>
        /// <param name="instance">The ToolStripDropDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the BindingContextChanged event on the ToolStripDropDown instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BindingContextChangedObservable(this ToolStripDropDown instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BindingContextChanged += handler,
                handler => instance.BindingContextChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ChangeUICues event on the ToolStripDropDown instance.
        /// </summary>
        /// <param name="instance">The ToolStripDropDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the ChangeUICues event on the ToolStripDropDown instance.</returns>
        public static IObservable<EventPattern<UICuesEventArgs>> ChangeUICuesObservable(this ToolStripDropDown instance)
        {
            return Observable.FromEventPattern<UICuesEventHandler, UICuesEventArgs>(
                handler => instance.ChangeUICues += handler,
                handler => instance.ChangeUICues -= handler);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Returns an observable sequence wrapping the ContextMenuChanged event on the ToolStripDropDown instance.
        /// </summary>
        /// <param name="instance">The ToolStripDropDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the ContextMenuChanged event on the ToolStripDropDown instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ContextMenuChangedObservable(this ToolStripDropDown instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ContextMenuChanged += handler,
                handler => instance.ContextMenuChanged -= handler);
        }
#endif

        /// <summary>
        /// Returns an observable sequence wrapping the ContextMenuStripChanged event on the ToolStripDropDown instance.
        /// </summary>
        /// <param name="instance">The ToolStripDropDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the ContextMenuStripChanged event on the ToolStripDropDown instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ContextMenuStripChangedObservable(this ToolStripDropDown instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ContextMenuStripChanged += handler,
                handler => instance.ContextMenuStripChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DockChanged event on the ToolStripDropDown instance.
        /// </summary>
        /// <param name="instance">The ToolStripDropDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the DockChanged event on the ToolStripDropDown instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DockChangedObservable(this ToolStripDropDown instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DockChanged += handler,
                handler => instance.DockChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Closed event on the ToolStripDropDown instance.
        /// </summary>
        /// <param name="instance">The ToolStripDropDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the Closed event on the ToolStripDropDown instance.</returns>
        public static IObservable<EventPattern<ToolStripDropDownClosedEventArgs>> ClosedObservable(this ToolStripDropDown instance)
        {
            return Observable.FromEventPattern<ToolStripDropDownClosedEventHandler, ToolStripDropDownClosedEventArgs>(
                handler => instance.Closed += handler,
                handler => instance.Closed -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Closing event on the ToolStripDropDown instance.
        /// </summary>
        /// <param name="instance">The ToolStripDropDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the Closing event on the ToolStripDropDown instance.</returns>
        public static IObservable<EventPattern<ToolStripDropDownClosingEventArgs>> ClosingObservable(this ToolStripDropDown instance)
        {
            return Observable.FromEventPattern<ToolStripDropDownClosingEventHandler, ToolStripDropDownClosingEventArgs>(
                handler => instance.Closing += handler,
                handler => instance.Closing -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Enter event on the ToolStripDropDown instance.
        /// </summary>
        /// <param name="instance">The ToolStripDropDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the Enter event on the ToolStripDropDown instance.</returns>
        public static IObservable<EventPattern<EventArgs>> EnterObservable(this ToolStripDropDown instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Enter += handler,
                handler => instance.Enter -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the FontChanged event on the ToolStripDropDown instance.
        /// </summary>
        /// <param name="instance">The ToolStripDropDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the FontChanged event on the ToolStripDropDown instance.</returns>
        public static IObservable<EventPattern<EventArgs>> FontChangedObservable(this ToolStripDropDown instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.FontChanged += handler,
                handler => instance.FontChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ForeColorChanged event on the ToolStripDropDown instance.
        /// </summary>
        /// <param name="instance">The ToolStripDropDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the ForeColorChanged event on the ToolStripDropDown instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ForeColorChangedObservable(this ToolStripDropDown instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ForeColorChanged += handler,
                handler => instance.ForeColorChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the GiveFeedback event on the ToolStripDropDown instance.
        /// </summary>
        /// <param name="instance">The ToolStripDropDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the GiveFeedback event on the ToolStripDropDown instance.</returns>
        public static IObservable<EventPattern<GiveFeedbackEventArgs>> GiveFeedbackObservable(this ToolStripDropDown instance)
        {
            return Observable.FromEventPattern<GiveFeedbackEventHandler, GiveFeedbackEventArgs>(
                handler => instance.GiveFeedback += handler,
                handler => instance.GiveFeedback -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the HelpRequested event on the ToolStripDropDown instance.
        /// </summary>
        /// <param name="instance">The ToolStripDropDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the HelpRequested event on the ToolStripDropDown instance.</returns>
        public static IObservable<EventPattern<HelpEventArgs>> HelpRequestedObservable(this ToolStripDropDown instance)
        {
            return Observable.FromEventPattern<HelpEventHandler, HelpEventArgs>(
                handler => instance.HelpRequested += handler,
                handler => instance.HelpRequested -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ImeModeChanged event on the ToolStripDropDown instance.
        /// </summary>
        /// <param name="instance">The ToolStripDropDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the ImeModeChanged event on the ToolStripDropDown instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ImeModeChangedObservable(this ToolStripDropDown instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ImeModeChanged += handler,
                handler => instance.ImeModeChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the KeyDown event on the ToolStripDropDown instance.
        /// </summary>
        /// <param name="instance">The ToolStripDropDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the KeyDown event on the ToolStripDropDown instance.</returns>
        public static IObservable<EventPattern<KeyEventArgs>> KeyDownObservable(this ToolStripDropDown instance)
        {
            return Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(
                handler => instance.KeyDown += handler,
                handler => instance.KeyDown -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the KeyPress event on the ToolStripDropDown instance.
        /// </summary>
        /// <param name="instance">The ToolStripDropDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the KeyPress event on the ToolStripDropDown instance.</returns>
        public static IObservable<EventPattern<KeyPressEventArgs>> KeyPressObservable(this ToolStripDropDown instance)
        {
            return Observable.FromEventPattern<KeyPressEventHandler, KeyPressEventArgs>(
                handler => instance.KeyPress += handler,
                handler => instance.KeyPress -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the KeyUp event on the ToolStripDropDown instance.
        /// </summary>
        /// <param name="instance">The ToolStripDropDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the KeyUp event on the ToolStripDropDown instance.</returns>
        public static IObservable<EventPattern<KeyEventArgs>> KeyUpObservable(this ToolStripDropDown instance)
        {
            return Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(
                handler => instance.KeyUp += handler,
                handler => instance.KeyUp -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Leave event on the ToolStripDropDown instance.
        /// </summary>
        /// <param name="instance">The ToolStripDropDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the Leave event on the ToolStripDropDown instance.</returns>
        public static IObservable<EventPattern<EventArgs>> LeaveObservable(this ToolStripDropDown instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Leave += handler,
                handler => instance.Leave -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Opening event on the ToolStripDropDown instance.
        /// </summary>
        /// <param name="instance">The ToolStripDropDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the Opening event on the ToolStripDropDown instance.</returns>
        public static IObservable<EventPattern<CancelEventArgs>> OpeningObservable(this ToolStripDropDown instance)
        {
            return Observable.FromEventPattern<CancelEventHandler, CancelEventArgs>(
                handler => instance.Opening += handler,
                handler => instance.Opening -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Opened event on the ToolStripDropDown instance.
        /// </summary>
        /// <param name="instance">The ToolStripDropDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the Opened event on the ToolStripDropDown instance.</returns>
        public static IObservable<EventPattern<EventArgs>> OpenedObservable(this ToolStripDropDown instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Opened += handler,
                handler => instance.Opened -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RegionChanged event on the ToolStripDropDown instance.
        /// </summary>
        /// <param name="instance">The ToolStripDropDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the RegionChanged event on the ToolStripDropDown instance.</returns>
        public static IObservable<EventPattern<EventArgs>> RegionChangedObservable(this ToolStripDropDown instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.RegionChanged += handler,
                handler => instance.RegionChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Scroll event on the ToolStripDropDown instance.
        /// </summary>
        /// <param name="instance">The ToolStripDropDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the Scroll event on the ToolStripDropDown instance.</returns>
        public static IObservable<EventPattern<ScrollEventArgs>> ScrollObservable(this ToolStripDropDown instance)
        {
            return Observable.FromEventPattern<ScrollEventHandler, ScrollEventArgs>(
                handler => instance.Scroll += handler,
                handler => instance.Scroll -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the StyleChanged event on the ToolStripDropDown instance.
        /// </summary>
        /// <param name="instance">The ToolStripDropDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the StyleChanged event on the ToolStripDropDown instance.</returns>
        public static IObservable<EventPattern<EventArgs>> StyleChangedObservable(this ToolStripDropDown instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.StyleChanged += handler,
                handler => instance.StyleChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the TabStopChanged event on the ToolStripDropDown instance.
        /// </summary>
        /// <param name="instance">The ToolStripDropDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the TabStopChanged event on the ToolStripDropDown instance.</returns>
        public static IObservable<EventPattern<EventArgs>> TabStopChangedObservable(this ToolStripDropDown instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.TabStopChanged += handler,
                handler => instance.TabStopChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the TextChanged event on the ToolStripDropDown instance.
        /// </summary>
        /// <param name="instance">The ToolStripDropDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the TextChanged event on the ToolStripDropDown instance.</returns>
        public static IObservable<EventPattern<EventArgs>> TextChangedObservable(this ToolStripDropDown instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.TextChanged += handler,
                handler => instance.TextChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the TabIndexChanged event on the ToolStripDropDown instance.
        /// </summary>
        /// <param name="instance">The ToolStripDropDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the TabIndexChanged event on the ToolStripDropDown instance.</returns>
        public static IObservable<EventPattern<EventArgs>> TabIndexChangedObservable(this ToolStripDropDown instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.TabIndexChanged += handler,
                handler => instance.TabIndexChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Validated event on the ToolStripDropDown instance.
        /// </summary>
        /// <param name="instance">The ToolStripDropDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the Validated event on the ToolStripDropDown instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ValidatedObservable(this ToolStripDropDown instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Validated += handler,
                handler => instance.Validated -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Validating event on the ToolStripDropDown instance.
        /// </summary>
        /// <param name="instance">The ToolStripDropDown instance to observe.</param>
        /// <returns>An observable sequence wrapping the Validating event on the ToolStripDropDown instance.</returns>
        public static IObservable<EventPattern<CancelEventArgs>> ValidatingObservable(this ToolStripDropDown instance)
        {
            return Observable.FromEventPattern<CancelEventHandler, CancelEventArgs>(
                handler => instance.Validating += handler,
                handler => instance.Validating -= handler);
        }
    }
}

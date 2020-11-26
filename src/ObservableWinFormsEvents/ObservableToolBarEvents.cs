#if NETFRAMEWORK

namespace System.Windows.Forms
{
    using System;
    using System.ComponentModel;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on ToolBar.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class ObservableToolBarEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the AutoSizeChanged event on the ToolBar instance.
        /// </summary>
        /// <param name="instance">The ToolBar instance to observe.</param>
        /// <returns>An observable sequence wrapping the AutoSizeChanged event on the ToolBar instance.</returns>
        public static IObservable<EventPattern<EventArgs>> AutoSizeChangedObservable(this ToolBar instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.AutoSizeChanged += handler,
                handler => instance.AutoSizeChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackColorChanged event on the ToolBar instance.
        /// </summary>
        /// <param name="instance">The ToolBar instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackColorChanged event on the ToolBar instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackColorChangedObservable(this ToolBar instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackColorChanged += handler,
                handler => instance.BackColorChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageChanged event on the ToolBar instance.
        /// </summary>
        /// <param name="instance">The ToolBar instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageChanged event on the ToolBar instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageChangedObservable(this ToolBar instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageChanged += handler,
                handler => instance.BackgroundImageChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageLayoutChanged event on the ToolBar instance.
        /// </summary>
        /// <param name="instance">The ToolBar instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageLayoutChanged event on the ToolBar instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageLayoutChangedObservable(this ToolBar instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageLayoutChanged += handler,
                handler => instance.BackgroundImageLayoutChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ForeColorChanged event on the ToolBar instance.
        /// </summary>
        /// <param name="instance">The ToolBar instance to observe.</param>
        /// <returns>An observable sequence wrapping the ForeColorChanged event on the ToolBar instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ForeColorChangedObservable(this ToolBar instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ForeColorChanged += handler,
                handler => instance.ForeColorChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ImeModeChanged event on the ToolBar instance.
        /// </summary>
        /// <param name="instance">The ToolBar instance to observe.</param>
        /// <returns>An observable sequence wrapping the ImeModeChanged event on the ToolBar instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ImeModeChangedObservable(this ToolBar instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ImeModeChanged += handler,
                handler => instance.ImeModeChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RightToLeftChanged event on the ToolBar instance.
        /// </summary>
        /// <param name="instance">The ToolBar instance to observe.</param>
        /// <returns>An observable sequence wrapping the RightToLeftChanged event on the ToolBar instance.</returns>
        public static IObservable<EventPattern<EventArgs>> RightToLeftChangedObservable(this ToolBar instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.RightToLeftChanged += handler,
                handler => instance.RightToLeftChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the TextChanged event on the ToolBar instance.
        /// </summary>
        /// <param name="instance">The ToolBar instance to observe.</param>
        /// <returns>An observable sequence wrapping the TextChanged event on the ToolBar instance.</returns>
        public static IObservable<EventPattern<EventArgs>> TextChangedObservable(this ToolBar instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.TextChanged += handler,
                handler => instance.TextChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ButtonClick event on the ToolBar instance.
        /// </summary>
        /// <param name="instance">The ToolBar instance to observe.</param>
        /// <returns>An observable sequence wrapping the ButtonClick event on the ToolBar instance.</returns>
        public static IObservable<EventPattern<ToolBarButtonClickEventArgs>> ButtonClickObservable(this ToolBar instance)
        {
            return Observable.FromEventPattern<ToolBarButtonClickEventHandler, ToolBarButtonClickEventArgs>(
                handler => instance.ButtonClick += handler,
                handler => instance.ButtonClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ButtonDropDown event on the ToolBar instance.
        /// </summary>
        /// <param name="instance">The ToolBar instance to observe.</param>
        /// <returns>An observable sequence wrapping the ButtonDropDown event on the ToolBar instance.</returns>
        public static IObservable<EventPattern<ToolBarButtonClickEventArgs>> ButtonDropDownObservable(this ToolBar instance)
        {
            return Observable.FromEventPattern<ToolBarButtonClickEventHandler, ToolBarButtonClickEventArgs>(
                handler => instance.ButtonDropDown += handler,
                handler => instance.ButtonDropDown -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Paint event on the ToolBar instance.
        /// </summary>
        /// <param name="instance">The ToolBar instance to observe.</param>
        /// <returns>An observable sequence wrapping the Paint event on the ToolBar instance.</returns>
        public static IObservable<EventPattern<PaintEventArgs>> PaintObservable(this ToolBar instance)
        {
            return Observable.FromEventPattern<PaintEventHandler, PaintEventArgs>(
                handler => instance.Paint += handler,
                handler => instance.Paint -= handler);
        }
    }
}

#endif

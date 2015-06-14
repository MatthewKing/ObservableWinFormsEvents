namespace System.Windows.Forms
{
    using System;
    using System.ComponentModel;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on SplitContainer.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class ObservableSplitContainerEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the AutoSizeChanged event on the SplitContainer instance.
        /// </summary>
        /// <param name="instance">The SplitContainer instance to observe.</param>
        /// <returns>An observable sequence wrapping the AutoSizeChanged event on the SplitContainer instance.</returns>
        public static IObservable<EventPattern<EventArgs>> AutoSizeChangedObservable(this SplitContainer instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.AutoSizeChanged += handler,
                handler => instance.AutoSizeChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ControlAdded event on the SplitContainer instance.
        /// </summary>
        /// <param name="instance">The SplitContainer instance to observe.</param>
        /// <returns>An observable sequence wrapping the ControlAdded event on the SplitContainer instance.</returns>
        public static IObservable<EventPattern<ControlEventArgs>> ControlAddedObservable(this SplitContainer instance)
        {
            return Observable.FromEventPattern<ControlEventHandler, ControlEventArgs>(
                handler => instance.ControlAdded += handler,
                handler => instance.ControlAdded -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ControlRemoved event on the SplitContainer instance.
        /// </summary>
        /// <param name="instance">The SplitContainer instance to observe.</param>
        /// <returns>An observable sequence wrapping the ControlRemoved event on the SplitContainer instance.</returns>
        public static IObservable<EventPattern<ControlEventArgs>> ControlRemovedObservable(this SplitContainer instance)
        {
            return Observable.FromEventPattern<ControlEventHandler, ControlEventArgs>(
                handler => instance.ControlRemoved += handler,
                handler => instance.ControlRemoved -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the PaddingChanged event on the SplitContainer instance.
        /// </summary>
        /// <param name="instance">The SplitContainer instance to observe.</param>
        /// <returns>An observable sequence wrapping the PaddingChanged event on the SplitContainer instance.</returns>
        public static IObservable<EventPattern<EventArgs>> PaddingChangedObservable(this SplitContainer instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.PaddingChanged += handler,
                handler => instance.PaddingChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageChanged event on the SplitContainer instance.
        /// </summary>
        /// <param name="instance">The SplitContainer instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageChanged event on the SplitContainer instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageChangedObservable(this SplitContainer instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageChanged += handler,
                handler => instance.BackgroundImageChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageLayoutChanged event on the SplitContainer instance.
        /// </summary>
        /// <param name="instance">The SplitContainer instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageLayoutChanged event on the SplitContainer instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageLayoutChangedObservable(this SplitContainer instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageLayoutChanged += handler,
                handler => instance.BackgroundImageLayoutChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the SplitterMoving event on the SplitContainer instance.
        /// </summary>
        /// <param name="instance">The SplitContainer instance to observe.</param>
        /// <returns>An observable sequence wrapping the SplitterMoving event on the SplitContainer instance.</returns>
        public static IObservable<EventPattern<SplitterCancelEventArgs>> SplitterMovingObservable(this SplitContainer instance)
        {
            return Observable.FromEventPattern<SplitterCancelEventHandler, SplitterCancelEventArgs>(
                handler => instance.SplitterMoving += handler,
                handler => instance.SplitterMoving -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the SplitterMoved event on the SplitContainer instance.
        /// </summary>
        /// <param name="instance">The SplitContainer instance to observe.</param>
        /// <returns>An observable sequence wrapping the SplitterMoved event on the SplitContainer instance.</returns>
        public static IObservable<EventPattern<SplitterEventArgs>> SplitterMovedObservable(this SplitContainer instance)
        {
            return Observable.FromEventPattern<SplitterEventHandler, SplitterEventArgs>(
                handler => instance.SplitterMoved += handler,
                handler => instance.SplitterMoved -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the TextChanged event on the SplitContainer instance.
        /// </summary>
        /// <param name="instance">The SplitContainer instance to observe.</param>
        /// <returns>An observable sequence wrapping the TextChanged event on the SplitContainer instance.</returns>
        public static IObservable<EventPattern<EventArgs>> TextChangedObservable(this SplitContainer instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.TextChanged += handler,
                handler => instance.TextChanged -= handler);
        }
    }
}

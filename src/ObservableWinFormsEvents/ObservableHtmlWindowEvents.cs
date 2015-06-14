namespace System.Windows.Forms
{
    using System.ComponentModel;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on HtmlWindow.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class ObservableHtmlWindowEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the Error event on the HtmlWindow instance.
        /// </summary>
        /// <param name="instance">The HtmlWindow instance to observe.</param>
        /// <returns>An observable sequence wrapping the Error event on the HtmlWindow instance.</returns>
        public static IObservable<EventPattern<HtmlElementErrorEventArgs>> ErrorObservable(this HtmlWindow instance)
        {
            return Observable.FromEventPattern<HtmlElementErrorEventHandler, HtmlElementErrorEventArgs>(
                handler => instance.Error += handler,
                handler => instance.Error -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the GotFocus event on the HtmlWindow instance.
        /// </summary>
        /// <param name="instance">The HtmlWindow instance to observe.</param>
        /// <returns>An observable sequence wrapping the GotFocus event on the HtmlWindow instance.</returns>
        public static IObservable<EventPattern<HtmlElementEventArgs>> GotFocusObservable(this HtmlWindow instance)
        {
            return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
                handler => instance.GotFocus += handler,
                handler => instance.GotFocus -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Load event on the HtmlWindow instance.
        /// </summary>
        /// <param name="instance">The HtmlWindow instance to observe.</param>
        /// <returns>An observable sequence wrapping the Load event on the HtmlWindow instance.</returns>
        public static IObservable<EventPattern<HtmlElementEventArgs>> LoadObservable(this HtmlWindow instance)
        {
            return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
                handler => instance.Load += handler,
                handler => instance.Load -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the LostFocus event on the HtmlWindow instance.
        /// </summary>
        /// <param name="instance">The HtmlWindow instance to observe.</param>
        /// <returns>An observable sequence wrapping the LostFocus event on the HtmlWindow instance.</returns>
        public static IObservable<EventPattern<HtmlElementEventArgs>> LostFocusObservable(this HtmlWindow instance)
        {
            return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
                handler => instance.LostFocus += handler,
                handler => instance.LostFocus -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Resize event on the HtmlWindow instance.
        /// </summary>
        /// <param name="instance">The HtmlWindow instance to observe.</param>
        /// <returns>An observable sequence wrapping the Resize event on the HtmlWindow instance.</returns>
        public static IObservable<EventPattern<HtmlElementEventArgs>> ResizeObservable(this HtmlWindow instance)
        {
            return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
                handler => instance.Resize += handler,
                handler => instance.Resize -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Scroll event on the HtmlWindow instance.
        /// </summary>
        /// <param name="instance">The HtmlWindow instance to observe.</param>
        /// <returns>An observable sequence wrapping the Scroll event on the HtmlWindow instance.</returns>
        public static IObservable<EventPattern<HtmlElementEventArgs>> ScrollObservable(this HtmlWindow instance)
        {
            return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
                handler => instance.Scroll += handler,
                handler => instance.Scroll -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Unload event on the HtmlWindow instance.
        /// </summary>
        /// <param name="instance">The HtmlWindow instance to observe.</param>
        /// <returns>An observable sequence wrapping the Unload event on the HtmlWindow instance.</returns>
        public static IObservable<EventPattern<HtmlElementEventArgs>> UnloadObservable(this HtmlWindow instance)
        {
            return Observable.FromEventPattern<HtmlElementEventHandler, HtmlElementEventArgs>(
                handler => instance.Unload += handler,
                handler => instance.Unload -= handler);
        }
    }
}

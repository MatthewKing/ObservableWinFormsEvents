namespace System.Windows.Forms
{
    using System;
    using System.ComponentModel;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on ImageList.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class ObservableImageListEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the RecreateHandle event on the ImageList instance.
        /// </summary>
        /// <param name="instance">The ImageList instance to observe.</param>
        /// <returns>An observable sequence wrapping the RecreateHandle event on the ImageList instance.</returns>
        public static IObservable<EventPattern<EventArgs>> RecreateHandleObservable(this ImageList instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.RecreateHandle += handler,
                handler => instance.RecreateHandle -= handler);
        }
    }
}

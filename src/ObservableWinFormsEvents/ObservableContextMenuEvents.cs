namespace System.Windows.Forms
{
    using System;
    using System.ComponentModel;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on ContextMenu.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class ObservableContextMenuEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the Popup event on the ContextMenu instance.
        /// </summary>
        /// <param name="instance">The ContextMenu instance to observe.</param>
        /// <returns>An observable sequence wrapping the Popup event on the ContextMenu instance.</returns>
        public static IObservable<EventPattern<EventArgs>> PopupObservable(this ContextMenu instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Popup += handler,
                handler => instance.Popup -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Collapse event on the ContextMenu instance.
        /// </summary>
        /// <param name="instance">The ContextMenu instance to observe.</param>
        /// <returns>An observable sequence wrapping the Collapse event on the ContextMenu instance.</returns>
        public static IObservable<EventPattern<EventArgs>> CollapseObservable(this ContextMenu instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Collapse += handler,
                handler => instance.Collapse -= handler);
        }
    }
}

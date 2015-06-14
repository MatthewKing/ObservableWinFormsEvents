namespace System.Windows.Forms
{
    using System;
    using System.ComponentModel;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on FontDialog.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class ObservableFontDialogEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the Apply event on the FontDialog instance.
        /// </summary>
        /// <param name="instance">The FontDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the Apply event on the FontDialog instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ApplyObservable(this FontDialog instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Apply += handler,
                handler => instance.Apply -= handler);
        }
    }
}

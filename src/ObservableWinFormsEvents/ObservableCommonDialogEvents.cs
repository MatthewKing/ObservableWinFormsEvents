namespace System.Windows.Forms
{
    using System;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on CommonDialog.
    /// </summary>
    public static class ObservableCommonDialogEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the HelpRequest event on the CommonDialog instance.
        /// </summary>
        /// <param name="instance">The CommonDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the HelpRequest event on the CommonDialog instance.</returns>
        public static IObservable<EventPattern<EventArgs>> HelpRequestObservable(this CommonDialog instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.HelpRequest += handler,
                handler => instance.HelpRequest -= handler);
        }
    }
}

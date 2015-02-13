namespace System.Windows.Forms
{
    using System;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on FolderBrowserDialog.
    /// </summary>
    public static class ObservableFolderBrowserDialogEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the HelpRequest event on the FolderBrowserDialog instance.
        /// </summary>
        /// <param name="instance">The FolderBrowserDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the HelpRequest event on the FolderBrowserDialog instance.</returns>
        public static IObservable<EventPattern<EventArgs>> HelpRequestObservable(this FolderBrowserDialog instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.HelpRequest += handler,
                handler => instance.HelpRequest -= handler);
        }
    }
}

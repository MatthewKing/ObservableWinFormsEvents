namespace System.Windows.Forms
{
    using System.ComponentModel;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on FileDialog.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class ObservableFileDialogEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the FileOk event on the FileDialog instance.
        /// </summary>
        /// <param name="instance">The FileDialog instance to observe.</param>
        /// <returns>An observable sequence wrapping the FileOk event on the FileDialog instance.</returns>
        public static IObservable<EventPattern<CancelEventArgs>> FileOkObservable(this FileDialog instance)
        {
            return Observable.FromEventPattern<CancelEventHandler, CancelEventArgs>(
                handler => instance.FileOk += handler,
                handler => instance.FileOk -= handler);
        }
    }
}

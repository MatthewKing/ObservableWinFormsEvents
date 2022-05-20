namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on VScrollBar.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableVScrollBarEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the RightToLeftChanged event on the VScrollBar instance.
    /// </summary>
    /// <param name="instance">The VScrollBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the RightToLeftChanged event on the VScrollBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> RightToLeftChangedObservable(this VScrollBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.RightToLeftChanged += handler,
            handler => instance.RightToLeftChanged -= handler);
    }
}

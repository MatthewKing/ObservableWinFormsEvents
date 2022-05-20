namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on LinkLabel.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableLinkLabelEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the TabStopChanged event on the LinkLabel instance.
    /// </summary>
    /// <param name="instance">The LinkLabel instance to observe.</param>
    /// <returns>An observable sequence wrapping the TabStopChanged event on the LinkLabel instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TabStopChangedObservable(this LinkLabel instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.TabStopChanged += handler,
            handler => instance.TabStopChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the LinkClicked event on the LinkLabel instance.
    /// </summary>
    /// <param name="instance">The LinkLabel instance to observe.</param>
    /// <returns>An observable sequence wrapping the LinkClicked event on the LinkLabel instance.</returns>
    public static IObservable<EventPattern<LinkLabelLinkClickedEventArgs>> LinkClickedObservable(this LinkLabel instance)
    {
        return Observable.FromEventPattern<LinkLabelLinkClickedEventHandler, LinkLabelLinkClickedEventArgs>(
            handler => instance.LinkClicked += handler,
            handler => instance.LinkClicked -= handler);
    }
}

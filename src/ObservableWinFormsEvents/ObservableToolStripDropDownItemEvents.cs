namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on ToolStripDropDownItem.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableToolStripDropDownItemEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the DropDownClosed event on the ToolStripDropDownItem instance.
    /// </summary>
    /// <param name="instance">The ToolStripDropDownItem instance to observe.</param>
    /// <returns>An observable sequence wrapping the DropDownClosed event on the ToolStripDropDownItem instance.</returns>
    public static IObservable<EventPattern<EventArgs>> DropDownClosedObservable(this ToolStripDropDownItem instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.DropDownClosed += handler,
            handler => instance.DropDownClosed -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the DropDownOpening event on the ToolStripDropDownItem instance.
    /// </summary>
    /// <param name="instance">The ToolStripDropDownItem instance to observe.</param>
    /// <returns>An observable sequence wrapping the DropDownOpening event on the ToolStripDropDownItem instance.</returns>
    public static IObservable<EventPattern<EventArgs>> DropDownOpeningObservable(this ToolStripDropDownItem instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.DropDownOpening += handler,
            handler => instance.DropDownOpening -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the DropDownOpened event on the ToolStripDropDownItem instance.
    /// </summary>
    /// <param name="instance">The ToolStripDropDownItem instance to observe.</param>
    /// <returns>An observable sequence wrapping the DropDownOpened event on the ToolStripDropDownItem instance.</returns>
    public static IObservable<EventPattern<EventArgs>> DropDownOpenedObservable(this ToolStripDropDownItem instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.DropDownOpened += handler,
            handler => instance.DropDownOpened -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the DropDownItemClicked event on the ToolStripDropDownItem instance.
    /// </summary>
    /// <param name="instance">The ToolStripDropDownItem instance to observe.</param>
    /// <returns>An observable sequence wrapping the DropDownItemClicked event on the ToolStripDropDownItem instance.</returns>
    public static IObservable<EventPattern<ToolStripItemClickedEventArgs>> DropDownItemClickedObservable(this ToolStripDropDownItem instance)
    {
        return Observable.FromEventPattern<ToolStripItemClickedEventHandler, ToolStripItemClickedEventArgs>(
            handler => instance.DropDownItemClicked += handler,
            handler => instance.DropDownItemClicked -= handler);
    }
}

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on ToolStripMenuItem.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableToolStripMenuItemEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the CheckedChanged event on the ToolStripMenuItem instance.
    /// </summary>
    /// <param name="instance">The ToolStripMenuItem instance to observe.</param>
    /// <returns>An observable sequence wrapping the CheckedChanged event on the ToolStripMenuItem instance.</returns>
    public static IObservable<EventPattern<EventArgs>> CheckedChangedObservable(this ToolStripMenuItem instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.CheckedChanged += handler,
            handler => instance.CheckedChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the CheckStateChanged event on the ToolStripMenuItem instance.
    /// </summary>
    /// <param name="instance">The ToolStripMenuItem instance to observe.</param>
    /// <returns>An observable sequence wrapping the CheckStateChanged event on the ToolStripMenuItem instance.</returns>
    public static IObservable<EventPattern<EventArgs>> CheckStateChangedObservable(this ToolStripMenuItem instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.CheckStateChanged += handler,
            handler => instance.CheckStateChanged -= handler);
    }
}

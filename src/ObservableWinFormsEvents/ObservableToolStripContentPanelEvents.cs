namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on ToolStripContentPanel.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableToolStripContentPanelEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the AutoSizeChanged event on the ToolStripContentPanel instance.
    /// </summary>
    /// <param name="instance">The ToolStripContentPanel instance to observe.</param>
    /// <returns>An observable sequence wrapping the AutoSizeChanged event on the ToolStripContentPanel instance.</returns>
    public static IObservable<EventPattern<EventArgs>> AutoSizeChangedObservable(this ToolStripContentPanel instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.AutoSizeChanged += handler,
            handler => instance.AutoSizeChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the CausesValidationChanged event on the ToolStripContentPanel instance.
    /// </summary>
    /// <param name="instance">The ToolStripContentPanel instance to observe.</param>
    /// <returns>An observable sequence wrapping the CausesValidationChanged event on the ToolStripContentPanel instance.</returns>
    public static IObservable<EventPattern<EventArgs>> CausesValidationChangedObservable(this ToolStripContentPanel instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.CausesValidationChanged += handler,
            handler => instance.CausesValidationChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the DockChanged event on the ToolStripContentPanel instance.
    /// </summary>
    /// <param name="instance">The ToolStripContentPanel instance to observe.</param>
    /// <returns>An observable sequence wrapping the DockChanged event on the ToolStripContentPanel instance.</returns>
    public static IObservable<EventPattern<EventArgs>> DockChangedObservable(this ToolStripContentPanel instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.DockChanged += handler,
            handler => instance.DockChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Load event on the ToolStripContentPanel instance.
    /// </summary>
    /// <param name="instance">The ToolStripContentPanel instance to observe.</param>
    /// <returns>An observable sequence wrapping the Load event on the ToolStripContentPanel instance.</returns>
    public static IObservable<EventPattern<EventArgs>> LoadObservable(this ToolStripContentPanel instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.Load += handler,
            handler => instance.Load -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the LocationChanged event on the ToolStripContentPanel instance.
    /// </summary>
    /// <param name="instance">The ToolStripContentPanel instance to observe.</param>
    /// <returns>An observable sequence wrapping the LocationChanged event on the ToolStripContentPanel instance.</returns>
    public static IObservable<EventPattern<EventArgs>> LocationChangedObservable(this ToolStripContentPanel instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.LocationChanged += handler,
            handler => instance.LocationChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the TabIndexChanged event on the ToolStripContentPanel instance.
    /// </summary>
    /// <param name="instance">The ToolStripContentPanel instance to observe.</param>
    /// <returns>An observable sequence wrapping the TabIndexChanged event on the ToolStripContentPanel instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TabIndexChangedObservable(this ToolStripContentPanel instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.TabIndexChanged += handler,
            handler => instance.TabIndexChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the TabStopChanged event on the ToolStripContentPanel instance.
    /// </summary>
    /// <param name="instance">The ToolStripContentPanel instance to observe.</param>
    /// <returns>An observable sequence wrapping the TabStopChanged event on the ToolStripContentPanel instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TabStopChangedObservable(this ToolStripContentPanel instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.TabStopChanged += handler,
            handler => instance.TabStopChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RendererChanged event on the ToolStripContentPanel instance.
    /// </summary>
    /// <param name="instance">The ToolStripContentPanel instance to observe.</param>
    /// <returns>An observable sequence wrapping the RendererChanged event on the ToolStripContentPanel instance.</returns>
    public static IObservable<EventPattern<EventArgs>> RendererChangedObservable(this ToolStripContentPanel instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.RendererChanged += handler,
            handler => instance.RendererChanged -= handler);
    }
}

using System;
using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on ToolStripPanel.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableToolStripPanelEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the AutoSizeChanged event on the ToolStripPanel instance.
    /// </summary>
    /// <param name="instance">The ToolStripPanel instance to observe.</param>
    /// <returns>An observable sequence wrapping the AutoSizeChanged event on the ToolStripPanel instance.</returns>
    public static IObservable<EventPattern<EventArgs>> AutoSizeChangedObservable(this ToolStripPanel instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.AutoSizeChanged += handler,
            handler => instance.AutoSizeChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RendererChanged event on the ToolStripPanel instance.
    /// </summary>
    /// <param name="instance">The ToolStripPanel instance to observe.</param>
    /// <returns>An observable sequence wrapping the RendererChanged event on the ToolStripPanel instance.</returns>
    public static IObservable<EventPattern<EventArgs>> RendererChangedObservable(this ToolStripPanel instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.RendererChanged += handler,
            handler => instance.RendererChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the TabIndexChanged event on the ToolStripPanel instance.
    /// </summary>
    /// <param name="instance">The ToolStripPanel instance to observe.</param>
    /// <returns>An observable sequence wrapping the TabIndexChanged event on the ToolStripPanel instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TabIndexChangedObservable(this ToolStripPanel instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.TabIndexChanged += handler,
            handler => instance.TabIndexChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the TabStopChanged event on the ToolStripPanel instance.
    /// </summary>
    /// <param name="instance">The ToolStripPanel instance to observe.</param>
    /// <returns>An observable sequence wrapping the TabStopChanged event on the ToolStripPanel instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TabStopChangedObservable(this ToolStripPanel instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.TabStopChanged += handler,
            handler => instance.TabStopChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the TextChanged event on the ToolStripPanel instance.
    /// </summary>
    /// <param name="instance">The ToolStripPanel instance to observe.</param>
    /// <returns>An observable sequence wrapping the TextChanged event on the ToolStripPanel instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TextChangedObservable(this ToolStripPanel instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.TextChanged += handler,
            handler => instance.TextChanged -= handler);
    }
}

using System;
using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on SplitterPanel.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableSplitterPanelEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the AutoSizeChanged event on the SplitterPanel instance.
    /// </summary>
    /// <param name="instance">The SplitterPanel instance to observe.</param>
    /// <returns>An observable sequence wrapping the AutoSizeChanged event on the SplitterPanel instance.</returns>
    public static IObservable<EventPattern<EventArgs>> AutoSizeChangedObservable(this SplitterPanel instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.AutoSizeChanged += handler,
            handler => instance.AutoSizeChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the VisibleChanged event on the SplitterPanel instance.
    /// </summary>
    /// <param name="instance">The SplitterPanel instance to observe.</param>
    /// <returns>An observable sequence wrapping the VisibleChanged event on the SplitterPanel instance.</returns>
    public static IObservable<EventPattern<EventArgs>> VisibleChangedObservable(this SplitterPanel instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.VisibleChanged += handler,
            handler => instance.VisibleChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the DockChanged event on the SplitterPanel instance.
    /// </summary>
    /// <param name="instance">The SplitterPanel instance to observe.</param>
    /// <returns>An observable sequence wrapping the DockChanged event on the SplitterPanel instance.</returns>
    public static IObservable<EventPattern<EventArgs>> DockChangedObservable(this SplitterPanel instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.DockChanged += handler,
            handler => instance.DockChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the LocationChanged event on the SplitterPanel instance.
    /// </summary>
    /// <param name="instance">The SplitterPanel instance to observe.</param>
    /// <returns>An observable sequence wrapping the LocationChanged event on the SplitterPanel instance.</returns>
    public static IObservable<EventPattern<EventArgs>> LocationChangedObservable(this SplitterPanel instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.LocationChanged += handler,
            handler => instance.LocationChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the TabIndexChanged event on the SplitterPanel instance.
    /// </summary>
    /// <param name="instance">The SplitterPanel instance to observe.</param>
    /// <returns>An observable sequence wrapping the TabIndexChanged event on the SplitterPanel instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TabIndexChangedObservable(this SplitterPanel instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.TabIndexChanged += handler,
            handler => instance.TabIndexChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the TabStopChanged event on the SplitterPanel instance.
    /// </summary>
    /// <param name="instance">The SplitterPanel instance to observe.</param>
    /// <returns>An observable sequence wrapping the TabStopChanged event on the SplitterPanel instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TabStopChangedObservable(this SplitterPanel instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.TabStopChanged += handler,
            handler => instance.TabStopChanged -= handler);
    }
}

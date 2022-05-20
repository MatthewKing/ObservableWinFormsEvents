using System;
using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on TabPage.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableTabPageEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the AutoSizeChanged event on the TabPage instance.
    /// </summary>
    /// <param name="instance">The TabPage instance to observe.</param>
    /// <returns>An observable sequence wrapping the AutoSizeChanged event on the TabPage instance.</returns>
    public static IObservable<EventPattern<EventArgs>> AutoSizeChangedObservable(this TabPage instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.AutoSizeChanged += handler,
            handler => instance.AutoSizeChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the DockChanged event on the TabPage instance.
    /// </summary>
    /// <param name="instance">The TabPage instance to observe.</param>
    /// <returns>An observable sequence wrapping the DockChanged event on the TabPage instance.</returns>
    public static IObservable<EventPattern<EventArgs>> DockChangedObservable(this TabPage instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.DockChanged += handler,
            handler => instance.DockChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the EnabledChanged event on the TabPage instance.
    /// </summary>
    /// <param name="instance">The TabPage instance to observe.</param>
    /// <returns>An observable sequence wrapping the EnabledChanged event on the TabPage instance.</returns>
    public static IObservable<EventPattern<EventArgs>> EnabledChangedObservable(this TabPage instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.EnabledChanged += handler,
            handler => instance.EnabledChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the LocationChanged event on the TabPage instance.
    /// </summary>
    /// <param name="instance">The TabPage instance to observe.</param>
    /// <returns>An observable sequence wrapping the LocationChanged event on the TabPage instance.</returns>
    public static IObservable<EventPattern<EventArgs>> LocationChangedObservable(this TabPage instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.LocationChanged += handler,
            handler => instance.LocationChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the TabIndexChanged event on the TabPage instance.
    /// </summary>
    /// <param name="instance">The TabPage instance to observe.</param>
    /// <returns>An observable sequence wrapping the TabIndexChanged event on the TabPage instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TabIndexChangedObservable(this TabPage instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.TabIndexChanged += handler,
            handler => instance.TabIndexChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the TabStopChanged event on the TabPage instance.
    /// </summary>
    /// <param name="instance">The TabPage instance to observe.</param>
    /// <returns>An observable sequence wrapping the TabStopChanged event on the TabPage instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TabStopChangedObservable(this TabPage instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.TabStopChanged += handler,
            handler => instance.TabStopChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the TextChanged event on the TabPage instance.
    /// </summary>
    /// <param name="instance">The TabPage instance to observe.</param>
    /// <returns>An observable sequence wrapping the TextChanged event on the TabPage instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TextChangedObservable(this TabPage instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.TextChanged += handler,
            handler => instance.TextChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the VisibleChanged event on the TabPage instance.
    /// </summary>
    /// <param name="instance">The TabPage instance to observe.</param>
    /// <returns>An observable sequence wrapping the VisibleChanged event on the TabPage instance.</returns>
    public static IObservable<EventPattern<EventArgs>> VisibleChangedObservable(this TabPage instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.VisibleChanged += handler,
            handler => instance.VisibleChanged -= handler);
    }
}

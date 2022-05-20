using System;
using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on TabControl.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableTabControlEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the BackColorChanged event on the TabControl instance.
    /// </summary>
    /// <param name="instance">The TabControl instance to observe.</param>
    /// <returns>An observable sequence wrapping the BackColorChanged event on the TabControl instance.</returns>
    public static IObservable<EventPattern<EventArgs>> BackColorChangedObservable(this TabControl instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.BackColorChanged += handler,
            handler => instance.BackColorChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the BackgroundImageChanged event on the TabControl instance.
    /// </summary>
    /// <param name="instance">The TabControl instance to observe.</param>
    /// <returns>An observable sequence wrapping the BackgroundImageChanged event on the TabControl instance.</returns>
    public static IObservable<EventPattern<EventArgs>> BackgroundImageChangedObservable(this TabControl instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.BackgroundImageChanged += handler,
            handler => instance.BackgroundImageChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the BackgroundImageLayoutChanged event on the TabControl instance.
    /// </summary>
    /// <param name="instance">The TabControl instance to observe.</param>
    /// <returns>An observable sequence wrapping the BackgroundImageLayoutChanged event on the TabControl instance.</returns>
    public static IObservable<EventPattern<EventArgs>> BackgroundImageLayoutChangedObservable(this TabControl instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.BackgroundImageLayoutChanged += handler,
            handler => instance.BackgroundImageLayoutChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ForeColorChanged event on the TabControl instance.
    /// </summary>
    /// <param name="instance">The TabControl instance to observe.</param>
    /// <returns>An observable sequence wrapping the ForeColorChanged event on the TabControl instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ForeColorChangedObservable(this TabControl instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.ForeColorChanged += handler,
            handler => instance.ForeColorChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the TextChanged event on the TabControl instance.
    /// </summary>
    /// <param name="instance">The TabControl instance to observe.</param>
    /// <returns>An observable sequence wrapping the TextChanged event on the TabControl instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TextChangedObservable(this TabControl instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.TextChanged += handler,
            handler => instance.TextChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the DrawItem event on the TabControl instance.
    /// </summary>
    /// <param name="instance">The TabControl instance to observe.</param>
    /// <returns>An observable sequence wrapping the DrawItem event on the TabControl instance.</returns>
    public static IObservable<EventPattern<DrawItemEventArgs>> DrawItemObservable(this TabControl instance)
    {
        return Observable.FromEventPattern<DrawItemEventHandler, DrawItemEventArgs>(
            handler => instance.DrawItem += handler,
            handler => instance.DrawItem -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RightToLeftLayoutChanged event on the TabControl instance.
    /// </summary>
    /// <param name="instance">The TabControl instance to observe.</param>
    /// <returns>An observable sequence wrapping the RightToLeftLayoutChanged event on the TabControl instance.</returns>
    public static IObservable<EventPattern<EventArgs>> RightToLeftLayoutChangedObservable(this TabControl instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.RightToLeftLayoutChanged += handler,
            handler => instance.RightToLeftLayoutChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the SelectedIndexChanged event on the TabControl instance.
    /// </summary>
    /// <param name="instance">The TabControl instance to observe.</param>
    /// <returns>An observable sequence wrapping the SelectedIndexChanged event on the TabControl instance.</returns>
    public static IObservable<EventPattern<EventArgs>> SelectedIndexChangedObservable(this TabControl instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.SelectedIndexChanged += handler,
            handler => instance.SelectedIndexChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Selecting event on the TabControl instance.
    /// </summary>
    /// <param name="instance">The TabControl instance to observe.</param>
    /// <returns>An observable sequence wrapping the Selecting event on the TabControl instance.</returns>
    public static IObservable<EventPattern<TabControlCancelEventArgs>> SelectingObservable(this TabControl instance)
    {
        return Observable.FromEventPattern<TabControlCancelEventHandler, TabControlCancelEventArgs>(
            handler => instance.Selecting += handler,
            handler => instance.Selecting -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Selected event on the TabControl instance.
    /// </summary>
    /// <param name="instance">The TabControl instance to observe.</param>
    /// <returns>An observable sequence wrapping the Selected event on the TabControl instance.</returns>
    public static IObservable<EventPattern<TabControlEventArgs>> SelectedObservable(this TabControl instance)
    {
        return Observable.FromEventPattern<TabControlEventHandler, TabControlEventArgs>(
            handler => instance.Selected += handler,
            handler => instance.Selected -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Deselecting event on the TabControl instance.
    /// </summary>
    /// <param name="instance">The TabControl instance to observe.</param>
    /// <returns>An observable sequence wrapping the Deselecting event on the TabControl instance.</returns>
    public static IObservable<EventPattern<TabControlCancelEventArgs>> DeselectingObservable(this TabControl instance)
    {
        return Observable.FromEventPattern<TabControlCancelEventHandler, TabControlCancelEventArgs>(
            handler => instance.Deselecting += handler,
            handler => instance.Deselecting -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Deselected event on the TabControl instance.
    /// </summary>
    /// <param name="instance">The TabControl instance to observe.</param>
    /// <returns>An observable sequence wrapping the Deselected event on the TabControl instance.</returns>
    public static IObservable<EventPattern<TabControlEventArgs>> DeselectedObservable(this TabControl instance)
    {
        return Observable.FromEventPattern<TabControlEventHandler, TabControlEventArgs>(
            handler => instance.Deselected += handler,
            handler => instance.Deselected -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Paint event on the TabControl instance.
    /// </summary>
    /// <param name="instance">The TabControl instance to observe.</param>
    /// <returns>An observable sequence wrapping the Paint event on the TabControl instance.</returns>
    public static IObservable<EventPattern<PaintEventArgs>> PaintObservable(this TabControl instance)
    {
        return Observable.FromEventPattern<PaintEventHandler, PaintEventArgs>(
            handler => instance.Paint += handler,
            handler => instance.Paint -= handler);
    }
}

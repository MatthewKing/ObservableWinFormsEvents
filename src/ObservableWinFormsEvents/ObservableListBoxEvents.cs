using System;
using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on ListBox.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableListBoxEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the BackgroundImageChanged event on the ListBox instance.
    /// </summary>
    /// <param name="instance">The ListBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the BackgroundImageChanged event on the ListBox instance.</returns>
    public static IObservable<EventPattern<EventArgs>> BackgroundImageChangedObservable(this ListBox instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.BackgroundImageChanged += handler,
            handler => instance.BackgroundImageChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the BackgroundImageLayoutChanged event on the ListBox instance.
    /// </summary>
    /// <param name="instance">The ListBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the BackgroundImageLayoutChanged event on the ListBox instance.</returns>
    public static IObservable<EventPattern<EventArgs>> BackgroundImageLayoutChangedObservable(this ListBox instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.BackgroundImageLayoutChanged += handler,
            handler => instance.BackgroundImageLayoutChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the TextChanged event on the ListBox instance.
    /// </summary>
    /// <param name="instance">The ListBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the TextChanged event on the ListBox instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TextChangedObservable(this ListBox instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.TextChanged += handler,
            handler => instance.TextChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Click event on the ListBox instance.
    /// </summary>
    /// <param name="instance">The ListBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the Click event on the ListBox instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ClickObservable(this ListBox instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.Click += handler,
            handler => instance.Click -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MouseClick event on the ListBox instance.
    /// </summary>
    /// <param name="instance">The ListBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the MouseClick event on the ListBox instance.</returns>
    public static IObservable<EventPattern<MouseEventArgs>> MouseClickObservable(this ListBox instance)
    {
        return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
            handler => instance.MouseClick += handler,
            handler => instance.MouseClick -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the PaddingChanged event on the ListBox instance.
    /// </summary>
    /// <param name="instance">The ListBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the PaddingChanged event on the ListBox instance.</returns>
    public static IObservable<EventPattern<EventArgs>> PaddingChangedObservable(this ListBox instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.PaddingChanged += handler,
            handler => instance.PaddingChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Paint event on the ListBox instance.
    /// </summary>
    /// <param name="instance">The ListBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the Paint event on the ListBox instance.</returns>
    public static IObservable<EventPattern<PaintEventArgs>> PaintObservable(this ListBox instance)
    {
        return Observable.FromEventPattern<PaintEventHandler, PaintEventArgs>(
            handler => instance.Paint += handler,
            handler => instance.Paint -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the DrawItem event on the ListBox instance.
    /// </summary>
    /// <param name="instance">The ListBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the DrawItem event on the ListBox instance.</returns>
    public static IObservable<EventPattern<DrawItemEventArgs>> DrawItemObservable(this ListBox instance)
    {
        return Observable.FromEventPattern<DrawItemEventHandler, DrawItemEventArgs>(
            handler => instance.DrawItem += handler,
            handler => instance.DrawItem -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MeasureItem event on the ListBox instance.
    /// </summary>
    /// <param name="instance">The ListBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the MeasureItem event on the ListBox instance.</returns>
    public static IObservable<EventPattern<MeasureItemEventArgs>> MeasureItemObservable(this ListBox instance)
    {
        return Observable.FromEventPattern<MeasureItemEventHandler, MeasureItemEventArgs>(
            handler => instance.MeasureItem += handler,
            handler => instance.MeasureItem -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the SelectedIndexChanged event on the ListBox instance.
    /// </summary>
    /// <param name="instance">The ListBox instance to observe.</param>
    /// <returns>An observable sequence wrapping the SelectedIndexChanged event on the ListBox instance.</returns>
    public static IObservable<EventPattern<EventArgs>> SelectedIndexChangedObservable(this ListBox instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.SelectedIndexChanged += handler,
            handler => instance.SelectedIndexChanged -= handler);
    }
}

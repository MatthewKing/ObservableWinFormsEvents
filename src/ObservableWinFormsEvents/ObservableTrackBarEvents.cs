using System;
using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on TrackBar.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableTrackBarEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the AutoSizeChanged event on the TrackBar instance.
    /// </summary>
    /// <param name="instance">The TrackBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the AutoSizeChanged event on the TrackBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> AutoSizeChangedObservable(this TrackBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.AutoSizeChanged += handler,
            handler => instance.AutoSizeChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the BackgroundImageChanged event on the TrackBar instance.
    /// </summary>
    /// <param name="instance">The TrackBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the BackgroundImageChanged event on the TrackBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> BackgroundImageChangedObservable(this TrackBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.BackgroundImageChanged += handler,
            handler => instance.BackgroundImageChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the BackgroundImageLayoutChanged event on the TrackBar instance.
    /// </summary>
    /// <param name="instance">The TrackBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the BackgroundImageLayoutChanged event on the TrackBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> BackgroundImageLayoutChangedObservable(this TrackBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.BackgroundImageLayoutChanged += handler,
            handler => instance.BackgroundImageLayoutChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the FontChanged event on the TrackBar instance.
    /// </summary>
    /// <param name="instance">The TrackBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the FontChanged event on the TrackBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> FontChangedObservable(this TrackBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.FontChanged += handler,
            handler => instance.FontChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ForeColorChanged event on the TrackBar instance.
    /// </summary>
    /// <param name="instance">The TrackBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the ForeColorChanged event on the TrackBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ForeColorChangedObservable(this TrackBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.ForeColorChanged += handler,
            handler => instance.ForeColorChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ImeModeChanged event on the TrackBar instance.
    /// </summary>
    /// <param name="instance">The TrackBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the ImeModeChanged event on the TrackBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ImeModeChangedObservable(this TrackBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.ImeModeChanged += handler,
            handler => instance.ImeModeChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the PaddingChanged event on the TrackBar instance.
    /// </summary>
    /// <param name="instance">The TrackBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the PaddingChanged event on the TrackBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> PaddingChangedObservable(this TrackBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.PaddingChanged += handler,
            handler => instance.PaddingChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the TextChanged event on the TrackBar instance.
    /// </summary>
    /// <param name="instance">The TrackBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the TextChanged event on the TrackBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TextChangedObservable(this TrackBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.TextChanged += handler,
            handler => instance.TextChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Click event on the TrackBar instance.
    /// </summary>
    /// <param name="instance">The TrackBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the Click event on the TrackBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ClickObservable(this TrackBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.Click += handler,
            handler => instance.Click -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the DoubleClick event on the TrackBar instance.
    /// </summary>
    /// <param name="instance">The TrackBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the DoubleClick event on the TrackBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> DoubleClickObservable(this TrackBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.DoubleClick += handler,
            handler => instance.DoubleClick -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MouseClick event on the TrackBar instance.
    /// </summary>
    /// <param name="instance">The TrackBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the MouseClick event on the TrackBar instance.</returns>
    public static IObservable<EventPattern<MouseEventArgs>> MouseClickObservable(this TrackBar instance)
    {
        return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
            handler => instance.MouseClick += handler,
            handler => instance.MouseClick -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MouseDoubleClick event on the TrackBar instance.
    /// </summary>
    /// <param name="instance">The TrackBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the MouseDoubleClick event on the TrackBar instance.</returns>
    public static IObservable<EventPattern<MouseEventArgs>> MouseDoubleClickObservable(this TrackBar instance)
    {
        return Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
            handler => instance.MouseDoubleClick += handler,
            handler => instance.MouseDoubleClick -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RightToLeftLayoutChanged event on the TrackBar instance.
    /// </summary>
    /// <param name="instance">The TrackBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the RightToLeftLayoutChanged event on the TrackBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> RightToLeftLayoutChangedObservable(this TrackBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.RightToLeftLayoutChanged += handler,
            handler => instance.RightToLeftLayoutChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Scroll event on the TrackBar instance.
    /// </summary>
    /// <param name="instance">The TrackBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the Scroll event on the TrackBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ScrollObservable(this TrackBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.Scroll += handler,
            handler => instance.Scroll -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Paint event on the TrackBar instance.
    /// </summary>
    /// <param name="instance">The TrackBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the Paint event on the TrackBar instance.</returns>
    public static IObservable<EventPattern<PaintEventArgs>> PaintObservable(this TrackBar instance)
    {
        return Observable.FromEventPattern<PaintEventHandler, PaintEventArgs>(
            handler => instance.Paint += handler,
            handler => instance.Paint -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ValueChanged event on the TrackBar instance.
    /// </summary>
    /// <param name="instance">The TrackBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the ValueChanged event on the TrackBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ValueChangedObservable(this TrackBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.ValueChanged += handler,
            handler => instance.ValueChanged -= handler);
    }
}

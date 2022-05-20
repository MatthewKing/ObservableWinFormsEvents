using System;
using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on ToolStripProgressBar.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableToolStripProgressBarEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the KeyDown event on the ToolStripProgressBar instance.
    /// </summary>
    /// <param name="instance">The ToolStripProgressBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the KeyDown event on the ToolStripProgressBar instance.</returns>
    public static IObservable<EventPattern<KeyEventArgs>> KeyDownObservable(this ToolStripProgressBar instance)
    {
        return Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(
            handler => instance.KeyDown += handler,
            handler => instance.KeyDown -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the KeyPress event on the ToolStripProgressBar instance.
    /// </summary>
    /// <param name="instance">The ToolStripProgressBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the KeyPress event on the ToolStripProgressBar instance.</returns>
    public static IObservable<EventPattern<KeyPressEventArgs>> KeyPressObservable(this ToolStripProgressBar instance)
    {
        return Observable.FromEventPattern<KeyPressEventHandler, KeyPressEventArgs>(
            handler => instance.KeyPress += handler,
            handler => instance.KeyPress -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the KeyUp event on the ToolStripProgressBar instance.
    /// </summary>
    /// <param name="instance">The ToolStripProgressBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the KeyUp event on the ToolStripProgressBar instance.</returns>
    public static IObservable<EventPattern<KeyEventArgs>> KeyUpObservable(this ToolStripProgressBar instance)
    {
        return Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(
            handler => instance.KeyUp += handler,
            handler => instance.KeyUp -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the LocationChanged event on the ToolStripProgressBar instance.
    /// </summary>
    /// <param name="instance">The ToolStripProgressBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the LocationChanged event on the ToolStripProgressBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> LocationChangedObservable(this ToolStripProgressBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.LocationChanged += handler,
            handler => instance.LocationChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the OwnerChanged event on the ToolStripProgressBar instance.
    /// </summary>
    /// <param name="instance">The ToolStripProgressBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the OwnerChanged event on the ToolStripProgressBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> OwnerChangedObservable(this ToolStripProgressBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.OwnerChanged += handler,
            handler => instance.OwnerChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RightToLeftLayoutChanged event on the ToolStripProgressBar instance.
    /// </summary>
    /// <param name="instance">The ToolStripProgressBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the RightToLeftLayoutChanged event on the ToolStripProgressBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> RightToLeftLayoutChangedObservable(this ToolStripProgressBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.RightToLeftLayoutChanged += handler,
            handler => instance.RightToLeftLayoutChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the TextChanged event on the ToolStripProgressBar instance.
    /// </summary>
    /// <param name="instance">The ToolStripProgressBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the TextChanged event on the ToolStripProgressBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TextChangedObservable(this ToolStripProgressBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.TextChanged += handler,
            handler => instance.TextChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Validated event on the ToolStripProgressBar instance.
    /// </summary>
    /// <param name="instance">The ToolStripProgressBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the Validated event on the ToolStripProgressBar instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ValidatedObservable(this ToolStripProgressBar instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.Validated += handler,
            handler => instance.Validated -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Validating event on the ToolStripProgressBar instance.
    /// </summary>
    /// <param name="instance">The ToolStripProgressBar instance to observe.</param>
    /// <returns>An observable sequence wrapping the Validating event on the ToolStripProgressBar instance.</returns>
    public static IObservable<EventPattern<CancelEventArgs>> ValidatingObservable(this ToolStripProgressBar instance)
    {
        return Observable.FromEventPattern<CancelEventHandler, CancelEventArgs>(
            handler => instance.Validating += handler,
            handler => instance.Validating -= handler);
    }
}

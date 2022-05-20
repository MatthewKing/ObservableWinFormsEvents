using System;
using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on ToolStripControlHost.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableToolStripControlHostEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the DisplayStyleChanged event on the ToolStripControlHost instance.
    /// </summary>
    /// <param name="instance">The ToolStripControlHost instance to observe.</param>
    /// <returns>An observable sequence wrapping the DisplayStyleChanged event on the ToolStripControlHost instance.</returns>
    public static IObservable<EventPattern<EventArgs>> DisplayStyleChangedObservable(this ToolStripControlHost instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.DisplayStyleChanged += handler,
            handler => instance.DisplayStyleChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Enter event on the ToolStripControlHost instance.
    /// </summary>
    /// <param name="instance">The ToolStripControlHost instance to observe.</param>
    /// <returns>An observable sequence wrapping the Enter event on the ToolStripControlHost instance.</returns>
    public static IObservable<EventPattern<EventArgs>> EnterObservable(this ToolStripControlHost instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.Enter += handler,
            handler => instance.Enter -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the GotFocus event on the ToolStripControlHost instance.
    /// </summary>
    /// <param name="instance">The ToolStripControlHost instance to observe.</param>
    /// <returns>An observable sequence wrapping the GotFocus event on the ToolStripControlHost instance.</returns>
    public static IObservable<EventPattern<EventArgs>> GotFocusObservable(this ToolStripControlHost instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.GotFocus += handler,
            handler => instance.GotFocus -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Leave event on the ToolStripControlHost instance.
    /// </summary>
    /// <param name="instance">The ToolStripControlHost instance to observe.</param>
    /// <returns>An observable sequence wrapping the Leave event on the ToolStripControlHost instance.</returns>
    public static IObservable<EventPattern<EventArgs>> LeaveObservable(this ToolStripControlHost instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.Leave += handler,
            handler => instance.Leave -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the LostFocus event on the ToolStripControlHost instance.
    /// </summary>
    /// <param name="instance">The ToolStripControlHost instance to observe.</param>
    /// <returns>An observable sequence wrapping the LostFocus event on the ToolStripControlHost instance.</returns>
    public static IObservable<EventPattern<EventArgs>> LostFocusObservable(this ToolStripControlHost instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.LostFocus += handler,
            handler => instance.LostFocus -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the KeyDown event on the ToolStripControlHost instance.
    /// </summary>
    /// <param name="instance">The ToolStripControlHost instance to observe.</param>
    /// <returns>An observable sequence wrapping the KeyDown event on the ToolStripControlHost instance.</returns>
    public static IObservable<EventPattern<KeyEventArgs>> KeyDownObservable(this ToolStripControlHost instance)
    {
        return Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(
            handler => instance.KeyDown += handler,
            handler => instance.KeyDown -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the KeyPress event on the ToolStripControlHost instance.
    /// </summary>
    /// <param name="instance">The ToolStripControlHost instance to observe.</param>
    /// <returns>An observable sequence wrapping the KeyPress event on the ToolStripControlHost instance.</returns>
    public static IObservable<EventPattern<KeyPressEventArgs>> KeyPressObservable(this ToolStripControlHost instance)
    {
        return Observable.FromEventPattern<KeyPressEventHandler, KeyPressEventArgs>(
            handler => instance.KeyPress += handler,
            handler => instance.KeyPress -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the KeyUp event on the ToolStripControlHost instance.
    /// </summary>
    /// <param name="instance">The ToolStripControlHost instance to observe.</param>
    /// <returns>An observable sequence wrapping the KeyUp event on the ToolStripControlHost instance.</returns>
    public static IObservable<EventPattern<KeyEventArgs>> KeyUpObservable(this ToolStripControlHost instance)
    {
        return Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(
            handler => instance.KeyUp += handler,
            handler => instance.KeyUp -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Validating event on the ToolStripControlHost instance.
    /// </summary>
    /// <param name="instance">The ToolStripControlHost instance to observe.</param>
    /// <returns>An observable sequence wrapping the Validating event on the ToolStripControlHost instance.</returns>
    public static IObservable<EventPattern<CancelEventArgs>> ValidatingObservable(this ToolStripControlHost instance)
    {
        return Observable.FromEventPattern<CancelEventHandler, CancelEventArgs>(
            handler => instance.Validating += handler,
            handler => instance.Validating -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Validated event on the ToolStripControlHost instance.
    /// </summary>
    /// <param name="instance">The ToolStripControlHost instance to observe.</param>
    /// <returns>An observable sequence wrapping the Validated event on the ToolStripControlHost instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ValidatedObservable(this ToolStripControlHost instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.Validated += handler,
            handler => instance.Validated -= handler);
    }
}

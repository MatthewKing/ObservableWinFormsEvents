using System;
using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on ToolStrip.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableToolStripEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the AutoSizeChanged event on the ToolStrip instance.
    /// </summary>
    /// <param name="instance">The ToolStrip instance to observe.</param>
    /// <returns>An observable sequence wrapping the AutoSizeChanged event on the ToolStrip instance.</returns>
    public static IObservable<EventPattern<EventArgs>> AutoSizeChangedObservable(this ToolStrip instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.AutoSizeChanged += handler,
            handler => instance.AutoSizeChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the BeginDrag event on the ToolStrip instance.
    /// </summary>
    /// <param name="instance">The ToolStrip instance to observe.</param>
    /// <returns>An observable sequence wrapping the BeginDrag event on the ToolStrip instance.</returns>
    public static IObservable<EventPattern<EventArgs>> BeginDragObservable(this ToolStrip instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.BeginDrag += handler,
            handler => instance.BeginDrag -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the CausesValidationChanged event on the ToolStrip instance.
    /// </summary>
    /// <param name="instance">The ToolStrip instance to observe.</param>
    /// <returns>An observable sequence wrapping the CausesValidationChanged event on the ToolStrip instance.</returns>
    public static IObservable<EventPattern<EventArgs>> CausesValidationChangedObservable(this ToolStrip instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.CausesValidationChanged += handler,
            handler => instance.CausesValidationChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ControlAdded event on the ToolStrip instance.
    /// </summary>
    /// <param name="instance">The ToolStrip instance to observe.</param>
    /// <returns>An observable sequence wrapping the ControlAdded event on the ToolStrip instance.</returns>
    public static IObservable<EventPattern<ControlEventArgs>> ControlAddedObservable(this ToolStrip instance)
    {
        return Observable.FromEventPattern<ControlEventHandler, ControlEventArgs>(
            handler => instance.ControlAdded += handler,
            handler => instance.ControlAdded -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the CursorChanged event on the ToolStrip instance.
    /// </summary>
    /// <param name="instance">The ToolStrip instance to observe.</param>
    /// <returns>An observable sequence wrapping the CursorChanged event on the ToolStrip instance.</returns>
    public static IObservable<EventPattern<EventArgs>> CursorChangedObservable(this ToolStrip instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.CursorChanged += handler,
            handler => instance.CursorChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ControlRemoved event on the ToolStrip instance.
    /// </summary>
    /// <param name="instance">The ToolStrip instance to observe.</param>
    /// <returns>An observable sequence wrapping the ControlRemoved event on the ToolStrip instance.</returns>
    public static IObservable<EventPattern<ControlEventArgs>> ControlRemovedObservable(this ToolStrip instance)
    {
        return Observable.FromEventPattern<ControlEventHandler, ControlEventArgs>(
            handler => instance.ControlRemoved += handler,
            handler => instance.ControlRemoved -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the EndDrag event on the ToolStrip instance.
    /// </summary>
    /// <param name="instance">The ToolStrip instance to observe.</param>
    /// <returns>An observable sequence wrapping the EndDrag event on the ToolStrip instance.</returns>
    public static IObservable<EventPattern<EventArgs>> EndDragObservable(this ToolStrip instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.EndDrag += handler,
            handler => instance.EndDrag -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ForeColorChanged event on the ToolStrip instance.
    /// </summary>
    /// <param name="instance">The ToolStrip instance to observe.</param>
    /// <returns>An observable sequence wrapping the ForeColorChanged event on the ToolStrip instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ForeColorChangedObservable(this ToolStrip instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.ForeColorChanged += handler,
            handler => instance.ForeColorChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ItemAdded event on the ToolStrip instance.
    /// </summary>
    /// <param name="instance">The ToolStrip instance to observe.</param>
    /// <returns>An observable sequence wrapping the ItemAdded event on the ToolStrip instance.</returns>
    public static IObservable<EventPattern<ToolStripItemEventArgs>> ItemAddedObservable(this ToolStrip instance)
    {
        return Observable.FromEventPattern<ToolStripItemEventHandler, ToolStripItemEventArgs>(
            handler => instance.ItemAdded += handler,
            handler => instance.ItemAdded -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ItemClicked event on the ToolStrip instance.
    /// </summary>
    /// <param name="instance">The ToolStrip instance to observe.</param>
    /// <returns>An observable sequence wrapping the ItemClicked event on the ToolStrip instance.</returns>
    public static IObservable<EventPattern<ToolStripItemClickedEventArgs>> ItemClickedObservable(this ToolStrip instance)
    {
        return Observable.FromEventPattern<ToolStripItemClickedEventHandler, ToolStripItemClickedEventArgs>(
            handler => instance.ItemClicked += handler,
            handler => instance.ItemClicked -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ItemRemoved event on the ToolStrip instance.
    /// </summary>
    /// <param name="instance">The ToolStrip instance to observe.</param>
    /// <returns>An observable sequence wrapping the ItemRemoved event on the ToolStrip instance.</returns>
    public static IObservable<EventPattern<ToolStripItemEventArgs>> ItemRemovedObservable(this ToolStrip instance)
    {
        return Observable.FromEventPattern<ToolStripItemEventHandler, ToolStripItemEventArgs>(
            handler => instance.ItemRemoved += handler,
            handler => instance.ItemRemoved -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the LayoutCompleted event on the ToolStrip instance.
    /// </summary>
    /// <param name="instance">The ToolStrip instance to observe.</param>
    /// <returns>An observable sequence wrapping the LayoutCompleted event on the ToolStrip instance.</returns>
    public static IObservable<EventPattern<EventArgs>> LayoutCompletedObservable(this ToolStrip instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.LayoutCompleted += handler,
            handler => instance.LayoutCompleted -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the LayoutStyleChanged event on the ToolStrip instance.
    /// </summary>
    /// <param name="instance">The ToolStrip instance to observe.</param>
    /// <returns>An observable sequence wrapping the LayoutStyleChanged event on the ToolStrip instance.</returns>
    public static IObservable<EventPattern<EventArgs>> LayoutStyleChangedObservable(this ToolStrip instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.LayoutStyleChanged += handler,
            handler => instance.LayoutStyleChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the PaintGrip event on the ToolStrip instance.
    /// </summary>
    /// <param name="instance">The ToolStrip instance to observe.</param>
    /// <returns>An observable sequence wrapping the PaintGrip event on the ToolStrip instance.</returns>
    public static IObservable<EventPattern<PaintEventArgs>> PaintGripObservable(this ToolStrip instance)
    {
        return Observable.FromEventPattern<PaintEventHandler, PaintEventArgs>(
            handler => instance.PaintGrip += handler,
            handler => instance.PaintGrip -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RendererChanged event on the ToolStrip instance.
    /// </summary>
    /// <param name="instance">The ToolStrip instance to observe.</param>
    /// <returns>An observable sequence wrapping the RendererChanged event on the ToolStrip instance.</returns>
    public static IObservable<EventPattern<EventArgs>> RendererChangedObservable(this ToolStrip instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.RendererChanged += handler,
            handler => instance.RendererChanged -= handler);
    }
}

using System;
using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on ToolStripSplitButton.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableToolStripSplitButtonEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the ButtonClick event on the ToolStripSplitButton instance.
    /// </summary>
    /// <param name="instance">The ToolStripSplitButton instance to observe.</param>
    /// <returns>An observable sequence wrapping the ButtonClick event on the ToolStripSplitButton instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ButtonClickObservable(this ToolStripSplitButton instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.ButtonClick += handler,
            handler => instance.ButtonClick -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ButtonDoubleClick event on the ToolStripSplitButton instance.
    /// </summary>
    /// <param name="instance">The ToolStripSplitButton instance to observe.</param>
    /// <returns>An observable sequence wrapping the ButtonDoubleClick event on the ToolStripSplitButton instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ButtonDoubleClickObservable(this ToolStripSplitButton instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.ButtonDoubleClick += handler,
            handler => instance.ButtonDoubleClick -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the DefaultItemChanged event on the ToolStripSplitButton instance.
    /// </summary>
    /// <param name="instance">The ToolStripSplitButton instance to observe.</param>
    /// <returns>An observable sequence wrapping the DefaultItemChanged event on the ToolStripSplitButton instance.</returns>
    public static IObservable<EventPattern<EventArgs>> DefaultItemChangedObservable(this ToolStripSplitButton instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.DefaultItemChanged += handler,
            handler => instance.DefaultItemChanged -= handler);
    }
}

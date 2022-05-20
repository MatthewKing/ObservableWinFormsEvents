using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on ToolStripRenderer.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableToolStripRendererEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the RenderArrow event on the ToolStripRenderer instance.
    /// </summary>
    /// <param name="instance">The ToolStripRenderer instance to observe.</param>
    /// <returns>An observable sequence wrapping the RenderArrow event on the ToolStripRenderer instance.</returns>
    public static IObservable<EventPattern<ToolStripArrowRenderEventArgs>> RenderArrowObservable(this ToolStripRenderer instance)
    {
        return Observable.FromEventPattern<ToolStripArrowRenderEventHandler, ToolStripArrowRenderEventArgs>(
            handler => instance.RenderArrow += handler,
            handler => instance.RenderArrow -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RenderToolStripBackground event on the ToolStripRenderer instance.
    /// </summary>
    /// <param name="instance">The ToolStripRenderer instance to observe.</param>
    /// <returns>An observable sequence wrapping the RenderToolStripBackground event on the ToolStripRenderer instance.</returns>
    public static IObservable<EventPattern<ToolStripRenderEventArgs>> RenderToolStripBackgroundObservable(this ToolStripRenderer instance)
    {
        return Observable.FromEventPattern<ToolStripRenderEventHandler, ToolStripRenderEventArgs>(
            handler => instance.RenderToolStripBackground += handler,
            handler => instance.RenderToolStripBackground -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RenderToolStripPanelBackground event on the ToolStripRenderer instance.
    /// </summary>
    /// <param name="instance">The ToolStripRenderer instance to observe.</param>
    /// <returns>An observable sequence wrapping the RenderToolStripPanelBackground event on the ToolStripRenderer instance.</returns>
    public static IObservable<EventPattern<ToolStripPanelRenderEventArgs>> RenderToolStripPanelBackgroundObservable(this ToolStripRenderer instance)
    {
        return Observable.FromEventPattern<ToolStripPanelRenderEventHandler, ToolStripPanelRenderEventArgs>(
            handler => instance.RenderToolStripPanelBackground += handler,
            handler => instance.RenderToolStripPanelBackground -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RenderToolStripContentPanelBackground event on the ToolStripRenderer instance.
    /// </summary>
    /// <param name="instance">The ToolStripRenderer instance to observe.</param>
    /// <returns>An observable sequence wrapping the RenderToolStripContentPanelBackground event on the ToolStripRenderer instance.</returns>
    public static IObservable<EventPattern<ToolStripContentPanelRenderEventArgs>> RenderToolStripContentPanelBackgroundObservable(this ToolStripRenderer instance)
    {
        return Observable.FromEventPattern<ToolStripContentPanelRenderEventHandler, ToolStripContentPanelRenderEventArgs>(
            handler => instance.RenderToolStripContentPanelBackground += handler,
            handler => instance.RenderToolStripContentPanelBackground -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RenderToolStripBorder event on the ToolStripRenderer instance.
    /// </summary>
    /// <param name="instance">The ToolStripRenderer instance to observe.</param>
    /// <returns>An observable sequence wrapping the RenderToolStripBorder event on the ToolStripRenderer instance.</returns>
    public static IObservable<EventPattern<ToolStripRenderEventArgs>> RenderToolStripBorderObservable(this ToolStripRenderer instance)
    {
        return Observable.FromEventPattern<ToolStripRenderEventHandler, ToolStripRenderEventArgs>(
            handler => instance.RenderToolStripBorder += handler,
            handler => instance.RenderToolStripBorder -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RenderButtonBackground event on the ToolStripRenderer instance.
    /// </summary>
    /// <param name="instance">The ToolStripRenderer instance to observe.</param>
    /// <returns>An observable sequence wrapping the RenderButtonBackground event on the ToolStripRenderer instance.</returns>
    public static IObservable<EventPattern<ToolStripItemRenderEventArgs>> RenderButtonBackgroundObservable(this ToolStripRenderer instance)
    {
        return Observable.FromEventPattern<ToolStripItemRenderEventHandler, ToolStripItemRenderEventArgs>(
            handler => instance.RenderButtonBackground += handler,
            handler => instance.RenderButtonBackground -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RenderDropDownButtonBackground event on the ToolStripRenderer instance.
    /// </summary>
    /// <param name="instance">The ToolStripRenderer instance to observe.</param>
    /// <returns>An observable sequence wrapping the RenderDropDownButtonBackground event on the ToolStripRenderer instance.</returns>
    public static IObservable<EventPattern<ToolStripItemRenderEventArgs>> RenderDropDownButtonBackgroundObservable(this ToolStripRenderer instance)
    {
        return Observable.FromEventPattern<ToolStripItemRenderEventHandler, ToolStripItemRenderEventArgs>(
            handler => instance.RenderDropDownButtonBackground += handler,
            handler => instance.RenderDropDownButtonBackground -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RenderOverflowButtonBackground event on the ToolStripRenderer instance.
    /// </summary>
    /// <param name="instance">The ToolStripRenderer instance to observe.</param>
    /// <returns>An observable sequence wrapping the RenderOverflowButtonBackground event on the ToolStripRenderer instance.</returns>
    public static IObservable<EventPattern<ToolStripItemRenderEventArgs>> RenderOverflowButtonBackgroundObservable(this ToolStripRenderer instance)
    {
        return Observable.FromEventPattern<ToolStripItemRenderEventHandler, ToolStripItemRenderEventArgs>(
            handler => instance.RenderOverflowButtonBackground += handler,
            handler => instance.RenderOverflowButtonBackground -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RenderGrip event on the ToolStripRenderer instance.
    /// </summary>
    /// <param name="instance">The ToolStripRenderer instance to observe.</param>
    /// <returns>An observable sequence wrapping the RenderGrip event on the ToolStripRenderer instance.</returns>
    public static IObservable<EventPattern<ToolStripGripRenderEventArgs>> RenderGripObservable(this ToolStripRenderer instance)
    {
        return Observable.FromEventPattern<ToolStripGripRenderEventHandler, ToolStripGripRenderEventArgs>(
            handler => instance.RenderGrip += handler,
            handler => instance.RenderGrip -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RenderItemBackground event on the ToolStripRenderer instance.
    /// </summary>
    /// <param name="instance">The ToolStripRenderer instance to observe.</param>
    /// <returns>An observable sequence wrapping the RenderItemBackground event on the ToolStripRenderer instance.</returns>
    public static IObservable<EventPattern<ToolStripItemRenderEventArgs>> RenderItemBackgroundObservable(this ToolStripRenderer instance)
    {
        return Observable.FromEventPattern<ToolStripItemRenderEventHandler, ToolStripItemRenderEventArgs>(
            handler => instance.RenderItemBackground += handler,
            handler => instance.RenderItemBackground -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RenderItemImage event on the ToolStripRenderer instance.
    /// </summary>
    /// <param name="instance">The ToolStripRenderer instance to observe.</param>
    /// <returns>An observable sequence wrapping the RenderItemImage event on the ToolStripRenderer instance.</returns>
    public static IObservable<EventPattern<ToolStripItemImageRenderEventArgs>> RenderItemImageObservable(this ToolStripRenderer instance)
    {
        return Observable.FromEventPattern<ToolStripItemImageRenderEventHandler, ToolStripItemImageRenderEventArgs>(
            handler => instance.RenderItemImage += handler,
            handler => instance.RenderItemImage -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RenderItemCheck event on the ToolStripRenderer instance.
    /// </summary>
    /// <param name="instance">The ToolStripRenderer instance to observe.</param>
    /// <returns>An observable sequence wrapping the RenderItemCheck event on the ToolStripRenderer instance.</returns>
    public static IObservable<EventPattern<ToolStripItemImageRenderEventArgs>> RenderItemCheckObservable(this ToolStripRenderer instance)
    {
        return Observable.FromEventPattern<ToolStripItemImageRenderEventHandler, ToolStripItemImageRenderEventArgs>(
            handler => instance.RenderItemCheck += handler,
            handler => instance.RenderItemCheck -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RenderItemText event on the ToolStripRenderer instance.
    /// </summary>
    /// <param name="instance">The ToolStripRenderer instance to observe.</param>
    /// <returns>An observable sequence wrapping the RenderItemText event on the ToolStripRenderer instance.</returns>
    public static IObservable<EventPattern<ToolStripItemTextRenderEventArgs>> RenderItemTextObservable(this ToolStripRenderer instance)
    {
        return Observable.FromEventPattern<ToolStripItemTextRenderEventHandler, ToolStripItemTextRenderEventArgs>(
            handler => instance.RenderItemText += handler,
            handler => instance.RenderItemText -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RenderImageMargin event on the ToolStripRenderer instance.
    /// </summary>
    /// <param name="instance">The ToolStripRenderer instance to observe.</param>
    /// <returns>An observable sequence wrapping the RenderImageMargin event on the ToolStripRenderer instance.</returns>
    public static IObservable<EventPattern<ToolStripRenderEventArgs>> RenderImageMarginObservable(this ToolStripRenderer instance)
    {
        return Observable.FromEventPattern<ToolStripRenderEventHandler, ToolStripRenderEventArgs>(
            handler => instance.RenderImageMargin += handler,
            handler => instance.RenderImageMargin -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RenderLabelBackground event on the ToolStripRenderer instance.
    /// </summary>
    /// <param name="instance">The ToolStripRenderer instance to observe.</param>
    /// <returns>An observable sequence wrapping the RenderLabelBackground event on the ToolStripRenderer instance.</returns>
    public static IObservable<EventPattern<ToolStripItemRenderEventArgs>> RenderLabelBackgroundObservable(this ToolStripRenderer instance)
    {
        return Observable.FromEventPattern<ToolStripItemRenderEventHandler, ToolStripItemRenderEventArgs>(
            handler => instance.RenderLabelBackground += handler,
            handler => instance.RenderLabelBackground -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RenderMenuItemBackground event on the ToolStripRenderer instance.
    /// </summary>
    /// <param name="instance">The ToolStripRenderer instance to observe.</param>
    /// <returns>An observable sequence wrapping the RenderMenuItemBackground event on the ToolStripRenderer instance.</returns>
    public static IObservable<EventPattern<ToolStripItemRenderEventArgs>> RenderMenuItemBackgroundObservable(this ToolStripRenderer instance)
    {
        return Observable.FromEventPattern<ToolStripItemRenderEventHandler, ToolStripItemRenderEventArgs>(
            handler => instance.RenderMenuItemBackground += handler,
            handler => instance.RenderMenuItemBackground -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RenderToolStripStatusLabelBackground event on the ToolStripRenderer instance.
    /// </summary>
    /// <param name="instance">The ToolStripRenderer instance to observe.</param>
    /// <returns>An observable sequence wrapping the RenderToolStripStatusLabelBackground event on the ToolStripRenderer instance.</returns>
    public static IObservable<EventPattern<ToolStripItemRenderEventArgs>> RenderToolStripStatusLabelBackgroundObservable(this ToolStripRenderer instance)
    {
        return Observable.FromEventPattern<ToolStripItemRenderEventHandler, ToolStripItemRenderEventArgs>(
            handler => instance.RenderToolStripStatusLabelBackground += handler,
            handler => instance.RenderToolStripStatusLabelBackground -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RenderStatusStripSizingGrip event on the ToolStripRenderer instance.
    /// </summary>
    /// <param name="instance">The ToolStripRenderer instance to observe.</param>
    /// <returns>An observable sequence wrapping the RenderStatusStripSizingGrip event on the ToolStripRenderer instance.</returns>
    public static IObservable<EventPattern<ToolStripRenderEventArgs>> RenderStatusStripSizingGripObservable(this ToolStripRenderer instance)
    {
        return Observable.FromEventPattern<ToolStripRenderEventHandler, ToolStripRenderEventArgs>(
            handler => instance.RenderStatusStripSizingGrip += handler,
            handler => instance.RenderStatusStripSizingGrip -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RenderSplitButtonBackground event on the ToolStripRenderer instance.
    /// </summary>
    /// <param name="instance">The ToolStripRenderer instance to observe.</param>
    /// <returns>An observable sequence wrapping the RenderSplitButtonBackground event on the ToolStripRenderer instance.</returns>
    public static IObservable<EventPattern<ToolStripItemRenderEventArgs>> RenderSplitButtonBackgroundObservable(this ToolStripRenderer instance)
    {
        return Observable.FromEventPattern<ToolStripItemRenderEventHandler, ToolStripItemRenderEventArgs>(
            handler => instance.RenderSplitButtonBackground += handler,
            handler => instance.RenderSplitButtonBackground -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RenderSeparator event on the ToolStripRenderer instance.
    /// </summary>
    /// <param name="instance">The ToolStripRenderer instance to observe.</param>
    /// <returns>An observable sequence wrapping the RenderSeparator event on the ToolStripRenderer instance.</returns>
    public static IObservable<EventPattern<ToolStripSeparatorRenderEventArgs>> RenderSeparatorObservable(this ToolStripRenderer instance)
    {
        return Observable.FromEventPattern<ToolStripSeparatorRenderEventHandler, ToolStripSeparatorRenderEventArgs>(
            handler => instance.RenderSeparator += handler,
            handler => instance.RenderSeparator -= handler);
    }
}

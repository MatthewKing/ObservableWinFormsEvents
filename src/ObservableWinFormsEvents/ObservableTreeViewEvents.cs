using System;
using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on TreeView.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableTreeViewEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the BackgroundImageChanged event on the TreeView instance.
    /// </summary>
    /// <param name="instance">The TreeView instance to observe.</param>
    /// <returns>An observable sequence wrapping the BackgroundImageChanged event on the TreeView instance.</returns>
    public static IObservable<EventPattern<EventArgs>> BackgroundImageChangedObservable(this TreeView instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.BackgroundImageChanged += handler,
            handler => instance.BackgroundImageChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the BackgroundImageLayoutChanged event on the TreeView instance.
    /// </summary>
    /// <param name="instance">The TreeView instance to observe.</param>
    /// <returns>An observable sequence wrapping the BackgroundImageLayoutChanged event on the TreeView instance.</returns>
    public static IObservable<EventPattern<EventArgs>> BackgroundImageLayoutChangedObservable(this TreeView instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.BackgroundImageLayoutChanged += handler,
            handler => instance.BackgroundImageLayoutChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the PaddingChanged event on the TreeView instance.
    /// </summary>
    /// <param name="instance">The TreeView instance to observe.</param>
    /// <returns>An observable sequence wrapping the PaddingChanged event on the TreeView instance.</returns>
    public static IObservable<EventPattern<EventArgs>> PaddingChangedObservable(this TreeView instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.PaddingChanged += handler,
            handler => instance.PaddingChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the TextChanged event on the TreeView instance.
    /// </summary>
    /// <param name="instance">The TreeView instance to observe.</param>
    /// <returns>An observable sequence wrapping the TextChanged event on the TreeView instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TextChangedObservable(this TreeView instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.TextChanged += handler,
            handler => instance.TextChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the BeforeLabelEdit event on the TreeView instance.
    /// </summary>
    /// <param name="instance">The TreeView instance to observe.</param>
    /// <returns>An observable sequence wrapping the BeforeLabelEdit event on the TreeView instance.</returns>
    public static IObservable<EventPattern<NodeLabelEditEventArgs>> BeforeLabelEditObservable(this TreeView instance)
    {
        return Observable.FromEventPattern<NodeLabelEditEventHandler, NodeLabelEditEventArgs>(
            handler => instance.BeforeLabelEdit += handler,
            handler => instance.BeforeLabelEdit -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the AfterLabelEdit event on the TreeView instance.
    /// </summary>
    /// <param name="instance">The TreeView instance to observe.</param>
    /// <returns>An observable sequence wrapping the AfterLabelEdit event on the TreeView instance.</returns>
    public static IObservable<EventPattern<NodeLabelEditEventArgs>> AfterLabelEditObservable(this TreeView instance)
    {
        return Observable.FromEventPattern<NodeLabelEditEventHandler, NodeLabelEditEventArgs>(
            handler => instance.AfterLabelEdit += handler,
            handler => instance.AfterLabelEdit -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the BeforeCheck event on the TreeView instance.
    /// </summary>
    /// <param name="instance">The TreeView instance to observe.</param>
    /// <returns>An observable sequence wrapping the BeforeCheck event on the TreeView instance.</returns>
    public static IObservable<EventPattern<TreeViewCancelEventArgs>> BeforeCheckObservable(this TreeView instance)
    {
        return Observable.FromEventPattern<TreeViewCancelEventHandler, TreeViewCancelEventArgs>(
            handler => instance.BeforeCheck += handler,
            handler => instance.BeforeCheck -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the AfterCheck event on the TreeView instance.
    /// </summary>
    /// <param name="instance">The TreeView instance to observe.</param>
    /// <returns>An observable sequence wrapping the AfterCheck event on the TreeView instance.</returns>
    public static IObservable<EventPattern<TreeViewEventArgs>> AfterCheckObservable(this TreeView instance)
    {
        return Observable.FromEventPattern<TreeViewEventHandler, TreeViewEventArgs>(
            handler => instance.AfterCheck += handler,
            handler => instance.AfterCheck -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the BeforeCollapse event on the TreeView instance.
    /// </summary>
    /// <param name="instance">The TreeView instance to observe.</param>
    /// <returns>An observable sequence wrapping the BeforeCollapse event on the TreeView instance.</returns>
    public static IObservable<EventPattern<TreeViewCancelEventArgs>> BeforeCollapseObservable(this TreeView instance)
    {
        return Observable.FromEventPattern<TreeViewCancelEventHandler, TreeViewCancelEventArgs>(
            handler => instance.BeforeCollapse += handler,
            handler => instance.BeforeCollapse -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the AfterCollapse event on the TreeView instance.
    /// </summary>
    /// <param name="instance">The TreeView instance to observe.</param>
    /// <returns>An observable sequence wrapping the AfterCollapse event on the TreeView instance.</returns>
    public static IObservable<EventPattern<TreeViewEventArgs>> AfterCollapseObservable(this TreeView instance)
    {
        return Observable.FromEventPattern<TreeViewEventHandler, TreeViewEventArgs>(
            handler => instance.AfterCollapse += handler,
            handler => instance.AfterCollapse -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the BeforeExpand event on the TreeView instance.
    /// </summary>
    /// <param name="instance">The TreeView instance to observe.</param>
    /// <returns>An observable sequence wrapping the BeforeExpand event on the TreeView instance.</returns>
    public static IObservable<EventPattern<TreeViewCancelEventArgs>> BeforeExpandObservable(this TreeView instance)
    {
        return Observable.FromEventPattern<TreeViewCancelEventHandler, TreeViewCancelEventArgs>(
            handler => instance.BeforeExpand += handler,
            handler => instance.BeforeExpand -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the AfterExpand event on the TreeView instance.
    /// </summary>
    /// <param name="instance">The TreeView instance to observe.</param>
    /// <returns>An observable sequence wrapping the AfterExpand event on the TreeView instance.</returns>
    public static IObservable<EventPattern<TreeViewEventArgs>> AfterExpandObservable(this TreeView instance)
    {
        return Observable.FromEventPattern<TreeViewEventHandler, TreeViewEventArgs>(
            handler => instance.AfterExpand += handler,
            handler => instance.AfterExpand -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the DrawNode event on the TreeView instance.
    /// </summary>
    /// <param name="instance">The TreeView instance to observe.</param>
    /// <returns>An observable sequence wrapping the DrawNode event on the TreeView instance.</returns>
    public static IObservable<EventPattern<DrawTreeNodeEventArgs>> DrawNodeObservable(this TreeView instance)
    {
        return Observable.FromEventPattern<DrawTreeNodeEventHandler, DrawTreeNodeEventArgs>(
            handler => instance.DrawNode += handler,
            handler => instance.DrawNode -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ItemDrag event on the TreeView instance.
    /// </summary>
    /// <param name="instance">The TreeView instance to observe.</param>
    /// <returns>An observable sequence wrapping the ItemDrag event on the TreeView instance.</returns>
    public static IObservable<EventPattern<ItemDragEventArgs>> ItemDragObservable(this TreeView instance)
    {
        return Observable.FromEventPattern<ItemDragEventHandler, ItemDragEventArgs>(
            handler => instance.ItemDrag += handler,
            handler => instance.ItemDrag -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the NodeMouseHover event on the TreeView instance.
    /// </summary>
    /// <param name="instance">The TreeView instance to observe.</param>
    /// <returns>An observable sequence wrapping the NodeMouseHover event on the TreeView instance.</returns>
    public static IObservable<EventPattern<TreeNodeMouseHoverEventArgs>> NodeMouseHoverObservable(this TreeView instance)
    {
        return Observable.FromEventPattern<TreeNodeMouseHoverEventHandler, TreeNodeMouseHoverEventArgs>(
            handler => instance.NodeMouseHover += handler,
            handler => instance.NodeMouseHover -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the BeforeSelect event on the TreeView instance.
    /// </summary>
    /// <param name="instance">The TreeView instance to observe.</param>
    /// <returns>An observable sequence wrapping the BeforeSelect event on the TreeView instance.</returns>
    public static IObservable<EventPattern<TreeViewCancelEventArgs>> BeforeSelectObservable(this TreeView instance)
    {
        return Observable.FromEventPattern<TreeViewCancelEventHandler, TreeViewCancelEventArgs>(
            handler => instance.BeforeSelect += handler,
            handler => instance.BeforeSelect -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the AfterSelect event on the TreeView instance.
    /// </summary>
    /// <param name="instance">The TreeView instance to observe.</param>
    /// <returns>An observable sequence wrapping the AfterSelect event on the TreeView instance.</returns>
    public static IObservable<EventPattern<TreeViewEventArgs>> AfterSelectObservable(this TreeView instance)
    {
        return Observable.FromEventPattern<TreeViewEventHandler, TreeViewEventArgs>(
            handler => instance.AfterSelect += handler,
            handler => instance.AfterSelect -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Paint event on the TreeView instance.
    /// </summary>
    /// <param name="instance">The TreeView instance to observe.</param>
    /// <returns>An observable sequence wrapping the Paint event on the TreeView instance.</returns>
    public static IObservable<EventPattern<PaintEventArgs>> PaintObservable(this TreeView instance)
    {
        return Observable.FromEventPattern<PaintEventHandler, PaintEventArgs>(
            handler => instance.Paint += handler,
            handler => instance.Paint -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the NodeMouseClick event on the TreeView instance.
    /// </summary>
    /// <param name="instance">The TreeView instance to observe.</param>
    /// <returns>An observable sequence wrapping the NodeMouseClick event on the TreeView instance.</returns>
    public static IObservable<EventPattern<TreeNodeMouseClickEventArgs>> NodeMouseClickObservable(this TreeView instance)
    {
        return Observable.FromEventPattern<TreeNodeMouseClickEventHandler, TreeNodeMouseClickEventArgs>(
            handler => instance.NodeMouseClick += handler,
            handler => instance.NodeMouseClick -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the NodeMouseDoubleClick event on the TreeView instance.
    /// </summary>
    /// <param name="instance">The TreeView instance to observe.</param>
    /// <returns>An observable sequence wrapping the NodeMouseDoubleClick event on the TreeView instance.</returns>
    public static IObservable<EventPattern<TreeNodeMouseClickEventArgs>> NodeMouseDoubleClickObservable(this TreeView instance)
    {
        return Observable.FromEventPattern<TreeNodeMouseClickEventHandler, TreeNodeMouseClickEventArgs>(
            handler => instance.NodeMouseDoubleClick += handler,
            handler => instance.NodeMouseDoubleClick -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RightToLeftLayoutChanged event on the TreeView instance.
    /// </summary>
    /// <param name="instance">The TreeView instance to observe.</param>
    /// <returns>An observable sequence wrapping the RightToLeftLayoutChanged event on the TreeView instance.</returns>
    public static IObservable<EventPattern<EventArgs>> RightToLeftLayoutChangedObservable(this TreeView instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.RightToLeftLayoutChanged += handler,
            handler => instance.RightToLeftLayoutChanged -= handler);
    }
}

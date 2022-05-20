#if NETFRAMEWORK

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on DataGrid.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableDataGridEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the BorderStyleChanged event on the DataGrid instance.
    /// </summary>
    /// <param name="instance">The DataGrid instance to observe.</param>
    /// <returns>An observable sequence wrapping the BorderStyleChanged event on the DataGrid instance.</returns>
    public static IObservable<EventPattern<EventArgs>> BorderStyleChangedObservable(this DataGrid instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.BorderStyleChanged += handler,
            handler => instance.BorderStyleChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the CaptionVisibleChanged event on the DataGrid instance.
    /// </summary>
    /// <param name="instance">The DataGrid instance to observe.</param>
    /// <returns>An observable sequence wrapping the CaptionVisibleChanged event on the DataGrid instance.</returns>
    public static IObservable<EventPattern<EventArgs>> CaptionVisibleChangedObservable(this DataGrid instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.CaptionVisibleChanged += handler,
            handler => instance.CaptionVisibleChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the CurrentCellChanged event on the DataGrid instance.
    /// </summary>
    /// <param name="instance">The DataGrid instance to observe.</param>
    /// <returns>An observable sequence wrapping the CurrentCellChanged event on the DataGrid instance.</returns>
    public static IObservable<EventPattern<EventArgs>> CurrentCellChangedObservable(this DataGrid instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.CurrentCellChanged += handler,
            handler => instance.CurrentCellChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the DataSourceChanged event on the DataGrid instance.
    /// </summary>
    /// <param name="instance">The DataGrid instance to observe.</param>
    /// <returns>An observable sequence wrapping the DataSourceChanged event on the DataGrid instance.</returns>
    public static IObservable<EventPattern<EventArgs>> DataSourceChangedObservable(this DataGrid instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.DataSourceChanged += handler,
            handler => instance.DataSourceChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ParentRowsLabelStyleChanged event on the DataGrid instance.
    /// </summary>
    /// <param name="instance">The DataGrid instance to observe.</param>
    /// <returns>An observable sequence wrapping the ParentRowsLabelStyleChanged event on the DataGrid instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ParentRowsLabelStyleChangedObservable(this DataGrid instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.ParentRowsLabelStyleChanged += handler,
            handler => instance.ParentRowsLabelStyleChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the FlatModeChanged event on the DataGrid instance.
    /// </summary>
    /// <param name="instance">The DataGrid instance to observe.</param>
    /// <returns>An observable sequence wrapping the FlatModeChanged event on the DataGrid instance.</returns>
    public static IObservable<EventPattern<EventArgs>> FlatModeChangedObservable(this DataGrid instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.FlatModeChanged += handler,
            handler => instance.FlatModeChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the BackgroundColorChanged event on the DataGrid instance.
    /// </summary>
    /// <param name="instance">The DataGrid instance to observe.</param>
    /// <returns>An observable sequence wrapping the BackgroundColorChanged event on the DataGrid instance.</returns>
    public static IObservable<EventPattern<EventArgs>> BackgroundColorChangedObservable(this DataGrid instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.BackgroundColorChanged += handler,
            handler => instance.BackgroundColorChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the AllowNavigationChanged event on the DataGrid instance.
    /// </summary>
    /// <param name="instance">The DataGrid instance to observe.</param>
    /// <returns>An observable sequence wrapping the AllowNavigationChanged event on the DataGrid instance.</returns>
    public static IObservable<EventPattern<EventArgs>> AllowNavigationChangedObservable(this DataGrid instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.AllowNavigationChanged += handler,
            handler => instance.AllowNavigationChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the CursorChanged event on the DataGrid instance.
    /// </summary>
    /// <param name="instance">The DataGrid instance to observe.</param>
    /// <returns>An observable sequence wrapping the CursorChanged event on the DataGrid instance.</returns>
    public static IObservable<EventPattern<EventArgs>> CursorChangedObservable(this DataGrid instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.CursorChanged += handler,
            handler => instance.CursorChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the BackgroundImageChanged event on the DataGrid instance.
    /// </summary>
    /// <param name="instance">The DataGrid instance to observe.</param>
    /// <returns>An observable sequence wrapping the BackgroundImageChanged event on the DataGrid instance.</returns>
    public static IObservable<EventPattern<EventArgs>> BackgroundImageChangedObservable(this DataGrid instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.BackgroundImageChanged += handler,
            handler => instance.BackgroundImageChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the BackgroundImageLayoutChanged event on the DataGrid instance.
    /// </summary>
    /// <param name="instance">The DataGrid instance to observe.</param>
    /// <returns>An observable sequence wrapping the BackgroundImageLayoutChanged event on the DataGrid instance.</returns>
    public static IObservable<EventPattern<EventArgs>> BackgroundImageLayoutChangedObservable(this DataGrid instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.BackgroundImageLayoutChanged += handler,
            handler => instance.BackgroundImageLayoutChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ReadOnlyChanged event on the DataGrid instance.
    /// </summary>
    /// <param name="instance">The DataGrid instance to observe.</param>
    /// <returns>An observable sequence wrapping the ReadOnlyChanged event on the DataGrid instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ReadOnlyChangedObservable(this DataGrid instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.ReadOnlyChanged += handler,
            handler => instance.ReadOnlyChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ParentRowsVisibleChanged event on the DataGrid instance.
    /// </summary>
    /// <param name="instance">The DataGrid instance to observe.</param>
    /// <returns>An observable sequence wrapping the ParentRowsVisibleChanged event on the DataGrid instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ParentRowsVisibleChangedObservable(this DataGrid instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.ParentRowsVisibleChanged += handler,
            handler => instance.ParentRowsVisibleChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the TextChanged event on the DataGrid instance.
    /// </summary>
    /// <param name="instance">The DataGrid instance to observe.</param>
    /// <returns>An observable sequence wrapping the TextChanged event on the DataGrid instance.</returns>
    public static IObservable<EventPattern<EventArgs>> TextChangedObservable(this DataGrid instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.TextChanged += handler,
            handler => instance.TextChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Navigate event on the DataGrid instance.
    /// </summary>
    /// <param name="instance">The DataGrid instance to observe.</param>
    /// <returns>An observable sequence wrapping the Navigate event on the DataGrid instance.</returns>
    public static IObservable<EventPattern<NavigateEventArgs>> NavigateObservable(this DataGrid instance)
    {
        return Observable.FromEventPattern<NavigateEventHandler, NavigateEventArgs>(
            handler => instance.Navigate += handler,
            handler => instance.Navigate -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Scroll event on the DataGrid instance.
    /// </summary>
    /// <param name="instance">The DataGrid instance to observe.</param>
    /// <returns>An observable sequence wrapping the Scroll event on the DataGrid instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ScrollObservable(this DataGrid instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.Scroll += handler,
            handler => instance.Scroll -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the BackButtonClick event on the DataGrid instance.
    /// </summary>
    /// <param name="instance">The DataGrid instance to observe.</param>
    /// <returns>An observable sequence wrapping the BackButtonClick event on the DataGrid instance.</returns>
    public static IObservable<EventPattern<EventArgs>> BackButtonClickObservable(this DataGrid instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.BackButtonClick += handler,
            handler => instance.BackButtonClick -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ShowParentDetailsButtonClick event on the DataGrid instance.
    /// </summary>
    /// <param name="instance">The DataGrid instance to observe.</param>
    /// <returns>An observable sequence wrapping the ShowParentDetailsButtonClick event on the DataGrid instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ShowParentDetailsButtonClickObservable(this DataGrid instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.ShowParentDetailsButtonClick += handler,
            handler => instance.ShowParentDetailsButtonClick -= handler);
    }
}

#endif

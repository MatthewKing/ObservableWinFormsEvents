#if NETFRAMEWORK

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on DataGridTableStyle.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableDataGridTableStyleEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the AllowSortingChanged event on the DataGridTableStyle instance.
    /// </summary>
    /// <param name="instance">The DataGridTableStyle instance to observe.</param>
    /// <returns>An observable sequence wrapping the AllowSortingChanged event on the DataGridTableStyle instance.</returns>
    public static IObservable<EventPattern<EventArgs>> AllowSortingChangedObservable(this DataGridTableStyle instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.AllowSortingChanged += handler,
            handler => instance.AllowSortingChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the AlternatingBackColorChanged event on the DataGridTableStyle instance.
    /// </summary>
    /// <param name="instance">The DataGridTableStyle instance to observe.</param>
    /// <returns>An observable sequence wrapping the AlternatingBackColorChanged event on the DataGridTableStyle instance.</returns>
    public static IObservable<EventPattern<EventArgs>> AlternatingBackColorChangedObservable(this DataGridTableStyle instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.AlternatingBackColorChanged += handler,
            handler => instance.AlternatingBackColorChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the BackColorChanged event on the DataGridTableStyle instance.
    /// </summary>
    /// <param name="instance">The DataGridTableStyle instance to observe.</param>
    /// <returns>An observable sequence wrapping the BackColorChanged event on the DataGridTableStyle instance.</returns>
    public static IObservable<EventPattern<EventArgs>> BackColorChangedObservable(this DataGridTableStyle instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.BackColorChanged += handler,
            handler => instance.BackColorChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ForeColorChanged event on the DataGridTableStyle instance.
    /// </summary>
    /// <param name="instance">The DataGridTableStyle instance to observe.</param>
    /// <returns>An observable sequence wrapping the ForeColorChanged event on the DataGridTableStyle instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ForeColorChangedObservable(this DataGridTableStyle instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.ForeColorChanged += handler,
            handler => instance.ForeColorChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the GridLineColorChanged event on the DataGridTableStyle instance.
    /// </summary>
    /// <param name="instance">The DataGridTableStyle instance to observe.</param>
    /// <returns>An observable sequence wrapping the GridLineColorChanged event on the DataGridTableStyle instance.</returns>
    public static IObservable<EventPattern<EventArgs>> GridLineColorChangedObservable(this DataGridTableStyle instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.GridLineColorChanged += handler,
            handler => instance.GridLineColorChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the GridLineStyleChanged event on the DataGridTableStyle instance.
    /// </summary>
    /// <param name="instance">The DataGridTableStyle instance to observe.</param>
    /// <returns>An observable sequence wrapping the GridLineStyleChanged event on the DataGridTableStyle instance.</returns>
    public static IObservable<EventPattern<EventArgs>> GridLineStyleChangedObservable(this DataGridTableStyle instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.GridLineStyleChanged += handler,
            handler => instance.GridLineStyleChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the HeaderBackColorChanged event on the DataGridTableStyle instance.
    /// </summary>
    /// <param name="instance">The DataGridTableStyle instance to observe.</param>
    /// <returns>An observable sequence wrapping the HeaderBackColorChanged event on the DataGridTableStyle instance.</returns>
    public static IObservable<EventPattern<EventArgs>> HeaderBackColorChangedObservable(this DataGridTableStyle instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.HeaderBackColorChanged += handler,
            handler => instance.HeaderBackColorChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the HeaderFontChanged event on the DataGridTableStyle instance.
    /// </summary>
    /// <param name="instance">The DataGridTableStyle instance to observe.</param>
    /// <returns>An observable sequence wrapping the HeaderFontChanged event on the DataGridTableStyle instance.</returns>
    public static IObservable<EventPattern<EventArgs>> HeaderFontChangedObservable(this DataGridTableStyle instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.HeaderFontChanged += handler,
            handler => instance.HeaderFontChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the HeaderForeColorChanged event on the DataGridTableStyle instance.
    /// </summary>
    /// <param name="instance">The DataGridTableStyle instance to observe.</param>
    /// <returns>An observable sequence wrapping the HeaderForeColorChanged event on the DataGridTableStyle instance.</returns>
    public static IObservable<EventPattern<EventArgs>> HeaderForeColorChangedObservable(this DataGridTableStyle instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.HeaderForeColorChanged += handler,
            handler => instance.HeaderForeColorChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the LinkColorChanged event on the DataGridTableStyle instance.
    /// </summary>
    /// <param name="instance">The DataGridTableStyle instance to observe.</param>
    /// <returns>An observable sequence wrapping the LinkColorChanged event on the DataGridTableStyle instance.</returns>
    public static IObservable<EventPattern<EventArgs>> LinkColorChangedObservable(this DataGridTableStyle instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.LinkColorChanged += handler,
            handler => instance.LinkColorChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the LinkHoverColorChanged event on the DataGridTableStyle instance.
    /// </summary>
    /// <param name="instance">The DataGridTableStyle instance to observe.</param>
    /// <returns>An observable sequence wrapping the LinkHoverColorChanged event on the DataGridTableStyle instance.</returns>
    public static IObservable<EventPattern<EventArgs>> LinkHoverColorChangedObservable(this DataGridTableStyle instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.LinkHoverColorChanged += handler,
            handler => instance.LinkHoverColorChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the PreferredColumnWidthChanged event on the DataGridTableStyle instance.
    /// </summary>
    /// <param name="instance">The DataGridTableStyle instance to observe.</param>
    /// <returns>An observable sequence wrapping the PreferredColumnWidthChanged event on the DataGridTableStyle instance.</returns>
    public static IObservable<EventPattern<EventArgs>> PreferredColumnWidthChangedObservable(this DataGridTableStyle instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.PreferredColumnWidthChanged += handler,
            handler => instance.PreferredColumnWidthChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the PreferredRowHeightChanged event on the DataGridTableStyle instance.
    /// </summary>
    /// <param name="instance">The DataGridTableStyle instance to observe.</param>
    /// <returns>An observable sequence wrapping the PreferredRowHeightChanged event on the DataGridTableStyle instance.</returns>
    public static IObservable<EventPattern<EventArgs>> PreferredRowHeightChangedObservable(this DataGridTableStyle instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.PreferredRowHeightChanged += handler,
            handler => instance.PreferredRowHeightChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ColumnHeadersVisibleChanged event on the DataGridTableStyle instance.
    /// </summary>
    /// <param name="instance">The DataGridTableStyle instance to observe.</param>
    /// <returns>An observable sequence wrapping the ColumnHeadersVisibleChanged event on the DataGridTableStyle instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ColumnHeadersVisibleChangedObservable(this DataGridTableStyle instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.ColumnHeadersVisibleChanged += handler,
            handler => instance.ColumnHeadersVisibleChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RowHeadersVisibleChanged event on the DataGridTableStyle instance.
    /// </summary>
    /// <param name="instance">The DataGridTableStyle instance to observe.</param>
    /// <returns>An observable sequence wrapping the RowHeadersVisibleChanged event on the DataGridTableStyle instance.</returns>
    public static IObservable<EventPattern<EventArgs>> RowHeadersVisibleChangedObservable(this DataGridTableStyle instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.RowHeadersVisibleChanged += handler,
            handler => instance.RowHeadersVisibleChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the RowHeaderWidthChanged event on the DataGridTableStyle instance.
    /// </summary>
    /// <param name="instance">The DataGridTableStyle instance to observe.</param>
    /// <returns>An observable sequence wrapping the RowHeaderWidthChanged event on the DataGridTableStyle instance.</returns>
    public static IObservable<EventPattern<EventArgs>> RowHeaderWidthChangedObservable(this DataGridTableStyle instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.RowHeaderWidthChanged += handler,
            handler => instance.RowHeaderWidthChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the SelectionBackColorChanged event on the DataGridTableStyle instance.
    /// </summary>
    /// <param name="instance">The DataGridTableStyle instance to observe.</param>
    /// <returns>An observable sequence wrapping the SelectionBackColorChanged event on the DataGridTableStyle instance.</returns>
    public static IObservable<EventPattern<EventArgs>> SelectionBackColorChangedObservable(this DataGridTableStyle instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.SelectionBackColorChanged += handler,
            handler => instance.SelectionBackColorChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the SelectionForeColorChanged event on the DataGridTableStyle instance.
    /// </summary>
    /// <param name="instance">The DataGridTableStyle instance to observe.</param>
    /// <returns>An observable sequence wrapping the SelectionForeColorChanged event on the DataGridTableStyle instance.</returns>
    public static IObservable<EventPattern<EventArgs>> SelectionForeColorChangedObservable(this DataGridTableStyle instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.SelectionForeColorChanged += handler,
            handler => instance.SelectionForeColorChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MappingNameChanged event on the DataGridTableStyle instance.
    /// </summary>
    /// <param name="instance">The DataGridTableStyle instance to observe.</param>
    /// <returns>An observable sequence wrapping the MappingNameChanged event on the DataGridTableStyle instance.</returns>
    public static IObservable<EventPattern<EventArgs>> MappingNameChangedObservable(this DataGridTableStyle instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.MappingNameChanged += handler,
            handler => instance.MappingNameChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ReadOnlyChanged event on the DataGridTableStyle instance.
    /// </summary>
    /// <param name="instance">The DataGridTableStyle instance to observe.</param>
    /// <returns>An observable sequence wrapping the ReadOnlyChanged event on the DataGridTableStyle instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ReadOnlyChangedObservable(this DataGridTableStyle instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.ReadOnlyChanged += handler,
            handler => instance.ReadOnlyChanged -= handler);
    }
}

#endif

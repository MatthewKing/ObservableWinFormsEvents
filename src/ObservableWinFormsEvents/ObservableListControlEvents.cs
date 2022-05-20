namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on ListControl.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableListControlEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the DataSourceChanged event on the ListControl instance.
    /// </summary>
    /// <param name="instance">The ListControl instance to observe.</param>
    /// <returns>An observable sequence wrapping the DataSourceChanged event on the ListControl instance.</returns>
    public static IObservable<EventPattern<EventArgs>> DataSourceChangedObservable(this ListControl instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.DataSourceChanged += handler,
            handler => instance.DataSourceChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the DisplayMemberChanged event on the ListControl instance.
    /// </summary>
    /// <param name="instance">The ListControl instance to observe.</param>
    /// <returns>An observable sequence wrapping the DisplayMemberChanged event on the ListControl instance.</returns>
    public static IObservable<EventPattern<EventArgs>> DisplayMemberChangedObservable(this ListControl instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.DisplayMemberChanged += handler,
            handler => instance.DisplayMemberChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the Format event on the ListControl instance.
    /// </summary>
    /// <param name="instance">The ListControl instance to observe.</param>
    /// <returns>An observable sequence wrapping the Format event on the ListControl instance.</returns>
    public static IObservable<EventPattern<ListControlConvertEventArgs>> FormatObservable(this ListControl instance)
    {
        return Observable.FromEventPattern<ListControlConvertEventHandler, ListControlConvertEventArgs>(
            handler => instance.Format += handler,
            handler => instance.Format -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the FormatInfoChanged event on the ListControl instance.
    /// </summary>
    /// <param name="instance">The ListControl instance to observe.</param>
    /// <returns>An observable sequence wrapping the FormatInfoChanged event on the ListControl instance.</returns>
    public static IObservable<EventPattern<EventArgs>> FormatInfoChangedObservable(this ListControl instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.FormatInfoChanged += handler,
            handler => instance.FormatInfoChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the FormatStringChanged event on the ListControl instance.
    /// </summary>
    /// <param name="instance">The ListControl instance to observe.</param>
    /// <returns>An observable sequence wrapping the FormatStringChanged event on the ListControl instance.</returns>
    public static IObservable<EventPattern<EventArgs>> FormatStringChangedObservable(this ListControl instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.FormatStringChanged += handler,
            handler => instance.FormatStringChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the FormattingEnabledChanged event on the ListControl instance.
    /// </summary>
    /// <param name="instance">The ListControl instance to observe.</param>
    /// <returns>An observable sequence wrapping the FormattingEnabledChanged event on the ListControl instance.</returns>
    public static IObservable<EventPattern<EventArgs>> FormattingEnabledChangedObservable(this ListControl instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.FormattingEnabledChanged += handler,
            handler => instance.FormattingEnabledChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ValueMemberChanged event on the ListControl instance.
    /// </summary>
    /// <param name="instance">The ListControl instance to observe.</param>
    /// <returns>An observable sequence wrapping the ValueMemberChanged event on the ListControl instance.</returns>
    public static IObservable<EventPattern<EventArgs>> ValueMemberChangedObservable(this ListControl instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.ValueMemberChanged += handler,
            handler => instance.ValueMemberChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the SelectedValueChanged event on the ListControl instance.
    /// </summary>
    /// <param name="instance">The ListControl instance to observe.</param>
    /// <returns>An observable sequence wrapping the SelectedValueChanged event on the ListControl instance.</returns>
    public static IObservable<EventPattern<EventArgs>> SelectedValueChangedObservable(this ListControl instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.SelectedValueChanged += handler,
            handler => instance.SelectedValueChanged -= handler);
    }
}

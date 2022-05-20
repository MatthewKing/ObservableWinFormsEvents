namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on BindingSource.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableBindingSourceEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the AddingNew event on the BindingSource instance.
    /// </summary>
    /// <param name="instance">The BindingSource instance to observe.</param>
    /// <returns>An observable sequence wrapping the AddingNew event on the BindingSource instance.</returns>
    public static IObservable<EventPattern<AddingNewEventArgs>> AddingNewObservable(this BindingSource instance)
    {
        return Observable.FromEventPattern<AddingNewEventHandler, AddingNewEventArgs>(
            handler => instance.AddingNew += handler,
            handler => instance.AddingNew -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the BindingComplete event on the BindingSource instance.
    /// </summary>
    /// <param name="instance">The BindingSource instance to observe.</param>
    /// <returns>An observable sequence wrapping the BindingComplete event on the BindingSource instance.</returns>
    public static IObservable<EventPattern<BindingCompleteEventArgs>> BindingCompleteObservable(this BindingSource instance)
    {
        return Observable.FromEventPattern<BindingCompleteEventHandler, BindingCompleteEventArgs>(
            handler => instance.BindingComplete += handler,
            handler => instance.BindingComplete -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the DataError event on the BindingSource instance.
    /// </summary>
    /// <param name="instance">The BindingSource instance to observe.</param>
    /// <returns>An observable sequence wrapping the DataError event on the BindingSource instance.</returns>
    public static IObservable<EventPattern<BindingManagerDataErrorEventArgs>> DataErrorObservable(this BindingSource instance)
    {
        return Observable.FromEventPattern<BindingManagerDataErrorEventHandler, BindingManagerDataErrorEventArgs>(
            handler => instance.DataError += handler,
            handler => instance.DataError -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the DataSourceChanged event on the BindingSource instance.
    /// </summary>
    /// <param name="instance">The BindingSource instance to observe.</param>
    /// <returns>An observable sequence wrapping the DataSourceChanged event on the BindingSource instance.</returns>
    public static IObservable<EventPattern<EventArgs>> DataSourceChangedObservable(this BindingSource instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.DataSourceChanged += handler,
            handler => instance.DataSourceChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the DataMemberChanged event on the BindingSource instance.
    /// </summary>
    /// <param name="instance">The BindingSource instance to observe.</param>
    /// <returns>An observable sequence wrapping the DataMemberChanged event on the BindingSource instance.</returns>
    public static IObservable<EventPattern<EventArgs>> DataMemberChangedObservable(this BindingSource instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.DataMemberChanged += handler,
            handler => instance.DataMemberChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the CurrentChanged event on the BindingSource instance.
    /// </summary>
    /// <param name="instance">The BindingSource instance to observe.</param>
    /// <returns>An observable sequence wrapping the CurrentChanged event on the BindingSource instance.</returns>
    public static IObservable<EventPattern<EventArgs>> CurrentChangedObservable(this BindingSource instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.CurrentChanged += handler,
            handler => instance.CurrentChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the CurrentItemChanged event on the BindingSource instance.
    /// </summary>
    /// <param name="instance">The BindingSource instance to observe.</param>
    /// <returns>An observable sequence wrapping the CurrentItemChanged event on the BindingSource instance.</returns>
    public static IObservable<EventPattern<EventArgs>> CurrentItemChangedObservable(this BindingSource instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.CurrentItemChanged += handler,
            handler => instance.CurrentItemChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ListChanged event on the BindingSource instance.
    /// </summary>
    /// <param name="instance">The BindingSource instance to observe.</param>
    /// <returns>An observable sequence wrapping the ListChanged event on the BindingSource instance.</returns>
    public static IObservable<EventPattern<ListChangedEventArgs>> ListChangedObservable(this BindingSource instance)
    {
        return Observable.FromEventPattern<ListChangedEventHandler, ListChangedEventArgs>(
            handler => instance.ListChanged += handler,
            handler => instance.ListChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the PositionChanged event on the BindingSource instance.
    /// </summary>
    /// <param name="instance">The BindingSource instance to observe.</param>
    /// <returns>An observable sequence wrapping the PositionChanged event on the BindingSource instance.</returns>
    public static IObservable<EventPattern<EventArgs>> PositionChangedObservable(this BindingSource instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.PositionChanged += handler,
            handler => instance.PositionChanged -= handler);
    }
}

namespace System.Windows.Forms;

/// <summary>
/// Extension methods providing IObservable wrappers for the events on CurrencyManager.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ObservableCurrencyManagerEvents
{
    /// <summary>
    /// Returns an observable sequence wrapping the ItemChanged event on the CurrencyManager instance.
    /// </summary>
    /// <param name="instance">The CurrencyManager instance to observe.</param>
    /// <returns>An observable sequence wrapping the ItemChanged event on the CurrencyManager instance.</returns>
    public static IObservable<EventPattern<ItemChangedEventArgs>> ItemChangedObservable(this CurrencyManager instance)
    {
        return Observable.FromEventPattern<ItemChangedEventHandler, ItemChangedEventArgs>(
            handler => instance.ItemChanged += handler,
            handler => instance.ItemChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the ListChanged event on the CurrencyManager instance.
    /// </summary>
    /// <param name="instance">The CurrencyManager instance to observe.</param>
    /// <returns>An observable sequence wrapping the ListChanged event on the CurrencyManager instance.</returns>
    public static IObservable<EventPattern<ListChangedEventArgs>> ListChangedObservable(this CurrencyManager instance)
    {
        return Observable.FromEventPattern<ListChangedEventHandler, ListChangedEventArgs>(
            handler => instance.ListChanged += handler,
            handler => instance.ListChanged -= handler);
    }

    /// <summary>
    /// Returns an observable sequence wrapping the MetaDataChanged event on the CurrencyManager instance.
    /// </summary>
    /// <param name="instance">The CurrencyManager instance to observe.</param>
    /// <returns>An observable sequence wrapping the MetaDataChanged event on the CurrencyManager instance.</returns>
    public static IObservable<EventPattern<EventArgs>> MetaDataChangedObservable(this CurrencyManager instance)
    {
        return Observable.FromEventPattern<EventHandler, EventArgs>(
            handler => instance.MetaDataChanged += handler,
            handler => instance.MetaDataChanged -= handler);
    }
}

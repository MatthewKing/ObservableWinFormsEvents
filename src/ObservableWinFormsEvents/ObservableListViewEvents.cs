namespace System.Windows.Forms
{
    using System;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on ListView.
    /// </summary>
    public static class ObservableListViewEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageLayoutChanged event on the ListView instance.
        /// </summary>
        /// <param name="instance">The ListView instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageLayoutChanged event on the ListView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageLayoutChangedObservable(this ListView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageLayoutChanged += handler,
                handler => instance.BackgroundImageLayoutChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RightToLeftLayoutChanged event on the ListView instance.
        /// </summary>
        /// <param name="instance">The ListView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RightToLeftLayoutChanged event on the ListView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> RightToLeftLayoutChangedObservable(this ListView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.RightToLeftLayoutChanged += handler,
                handler => instance.RightToLeftLayoutChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the TextChanged event on the ListView instance.
        /// </summary>
        /// <param name="instance">The ListView instance to observe.</param>
        /// <returns>An observable sequence wrapping the TextChanged event on the ListView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> TextChangedObservable(this ListView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.TextChanged += handler,
                handler => instance.TextChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the AfterLabelEdit event on the ListView instance.
        /// </summary>
        /// <param name="instance">The ListView instance to observe.</param>
        /// <returns>An observable sequence wrapping the AfterLabelEdit event on the ListView instance.</returns>
        public static IObservable<EventPattern<LabelEditEventArgs>> AfterLabelEditObservable(this ListView instance)
        {
            return Observable.FromEventPattern<LabelEditEventHandler, LabelEditEventArgs>(
                handler => instance.AfterLabelEdit += handler,
                handler => instance.AfterLabelEdit -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BeforeLabelEdit event on the ListView instance.
        /// </summary>
        /// <param name="instance">The ListView instance to observe.</param>
        /// <returns>An observable sequence wrapping the BeforeLabelEdit event on the ListView instance.</returns>
        public static IObservable<EventPattern<LabelEditEventArgs>> BeforeLabelEditObservable(this ListView instance)
        {
            return Observable.FromEventPattern<LabelEditEventHandler, LabelEditEventArgs>(
                handler => instance.BeforeLabelEdit += handler,
                handler => instance.BeforeLabelEdit -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CacheVirtualItems event on the ListView instance.
        /// </summary>
        /// <param name="instance">The ListView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CacheVirtualItems event on the ListView instance.</returns>
        public static IObservable<EventPattern<CacheVirtualItemsEventArgs>> CacheVirtualItemsObservable(this ListView instance)
        {
            return Observable.FromEventPattern<CacheVirtualItemsEventHandler, CacheVirtualItemsEventArgs>(
                handler => instance.CacheVirtualItems += handler,
                handler => instance.CacheVirtualItems -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ColumnClick event on the ListView instance.
        /// </summary>
        /// <param name="instance">The ListView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ColumnClick event on the ListView instance.</returns>
        public static IObservable<EventPattern<ColumnClickEventArgs>> ColumnClickObservable(this ListView instance)
        {
            return Observable.FromEventPattern<ColumnClickEventHandler, ColumnClickEventArgs>(
                handler => instance.ColumnClick += handler,
                handler => instance.ColumnClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ColumnReordered event on the ListView instance.
        /// </summary>
        /// <param name="instance">The ListView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ColumnReordered event on the ListView instance.</returns>
        public static IObservable<EventPattern<ColumnReorderedEventArgs>> ColumnReorderedObservable(this ListView instance)
        {
            return Observable.FromEventPattern<ColumnReorderedEventHandler, ColumnReorderedEventArgs>(
                handler => instance.ColumnReordered += handler,
                handler => instance.ColumnReordered -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ColumnWidthChanged event on the ListView instance.
        /// </summary>
        /// <param name="instance">The ListView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ColumnWidthChanged event on the ListView instance.</returns>
        public static IObservable<EventPattern<ColumnWidthChangedEventArgs>> ColumnWidthChangedObservable(this ListView instance)
        {
            return Observable.FromEventPattern<ColumnWidthChangedEventHandler, ColumnWidthChangedEventArgs>(
                handler => instance.ColumnWidthChanged += handler,
                handler => instance.ColumnWidthChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ColumnWidthChanging event on the ListView instance.
        /// </summary>
        /// <param name="instance">The ListView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ColumnWidthChanging event on the ListView instance.</returns>
        public static IObservable<EventPattern<ColumnWidthChangingEventArgs>> ColumnWidthChangingObservable(this ListView instance)
        {
            return Observable.FromEventPattern<ColumnWidthChangingEventHandler, ColumnWidthChangingEventArgs>(
                handler => instance.ColumnWidthChanging += handler,
                handler => instance.ColumnWidthChanging -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DrawColumnHeader event on the ListView instance.
        /// </summary>
        /// <param name="instance">The ListView instance to observe.</param>
        /// <returns>An observable sequence wrapping the DrawColumnHeader event on the ListView instance.</returns>
        public static IObservable<EventPattern<DrawListViewColumnHeaderEventArgs>> DrawColumnHeaderObservable(this ListView instance)
        {
            return Observable.FromEventPattern<DrawListViewColumnHeaderEventHandler, DrawListViewColumnHeaderEventArgs>(
                handler => instance.DrawColumnHeader += handler,
                handler => instance.DrawColumnHeader -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DrawItem event on the ListView instance.
        /// </summary>
        /// <param name="instance">The ListView instance to observe.</param>
        /// <returns>An observable sequence wrapping the DrawItem event on the ListView instance.</returns>
        public static IObservable<EventPattern<DrawListViewItemEventArgs>> DrawItemObservable(this ListView instance)
        {
            return Observable.FromEventPattern<DrawListViewItemEventHandler, DrawListViewItemEventArgs>(
                handler => instance.DrawItem += handler,
                handler => instance.DrawItem -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DrawSubItem event on the ListView instance.
        /// </summary>
        /// <param name="instance">The ListView instance to observe.</param>
        /// <returns>An observable sequence wrapping the DrawSubItem event on the ListView instance.</returns>
        public static IObservable<EventPattern<DrawListViewSubItemEventArgs>> DrawSubItemObservable(this ListView instance)
        {
            return Observable.FromEventPattern<DrawListViewSubItemEventHandler, DrawListViewSubItemEventArgs>(
                handler => instance.DrawSubItem += handler,
                handler => instance.DrawSubItem -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ItemActivate event on the ListView instance.
        /// </summary>
        /// <param name="instance">The ListView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ItemActivate event on the ListView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ItemActivateObservable(this ListView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ItemActivate += handler,
                handler => instance.ItemActivate -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ItemCheck event on the ListView instance.
        /// </summary>
        /// <param name="instance">The ListView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ItemCheck event on the ListView instance.</returns>
        public static IObservable<EventPattern<ItemCheckEventArgs>> ItemCheckObservable(this ListView instance)
        {
            return Observable.FromEventPattern<ItemCheckEventHandler, ItemCheckEventArgs>(
                handler => instance.ItemCheck += handler,
                handler => instance.ItemCheck -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ItemChecked event on the ListView instance.
        /// </summary>
        /// <param name="instance">The ListView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ItemChecked event on the ListView instance.</returns>
        public static IObservable<EventPattern<ItemCheckedEventArgs>> ItemCheckedObservable(this ListView instance)
        {
            return Observable.FromEventPattern<ItemCheckedEventHandler, ItemCheckedEventArgs>(
                handler => instance.ItemChecked += handler,
                handler => instance.ItemChecked -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ItemDrag event on the ListView instance.
        /// </summary>
        /// <param name="instance">The ListView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ItemDrag event on the ListView instance.</returns>
        public static IObservable<EventPattern<ItemDragEventArgs>> ItemDragObservable(this ListView instance)
        {
            return Observable.FromEventPattern<ItemDragEventHandler, ItemDragEventArgs>(
                handler => instance.ItemDrag += handler,
                handler => instance.ItemDrag -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ItemMouseHover event on the ListView instance.
        /// </summary>
        /// <param name="instance">The ListView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ItemMouseHover event on the ListView instance.</returns>
        public static IObservable<EventPattern<ListViewItemMouseHoverEventArgs>> ItemMouseHoverObservable(this ListView instance)
        {
            return Observable.FromEventPattern<ListViewItemMouseHoverEventHandler, ListViewItemMouseHoverEventArgs>(
                handler => instance.ItemMouseHover += handler,
                handler => instance.ItemMouseHover -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ItemSelectionChanged event on the ListView instance.
        /// </summary>
        /// <param name="instance">The ListView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ItemSelectionChanged event on the ListView instance.</returns>
        public static IObservable<EventPattern<ListViewItemSelectionChangedEventArgs>> ItemSelectionChangedObservable(this ListView instance)
        {
            return Observable.FromEventPattern<ListViewItemSelectionChangedEventHandler, ListViewItemSelectionChangedEventArgs>(
                handler => instance.ItemSelectionChanged += handler,
                handler => instance.ItemSelectionChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the PaddingChanged event on the ListView instance.
        /// </summary>
        /// <param name="instance">The ListView instance to observe.</param>
        /// <returns>An observable sequence wrapping the PaddingChanged event on the ListView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> PaddingChangedObservable(this ListView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.PaddingChanged += handler,
                handler => instance.PaddingChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Paint event on the ListView instance.
        /// </summary>
        /// <param name="instance">The ListView instance to observe.</param>
        /// <returns>An observable sequence wrapping the Paint event on the ListView instance.</returns>
        public static IObservable<EventPattern<PaintEventArgs>> PaintObservable(this ListView instance)
        {
            return Observable.FromEventPattern<PaintEventHandler, PaintEventArgs>(
                handler => instance.Paint += handler,
                handler => instance.Paint -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RetrieveVirtualItem event on the ListView instance.
        /// </summary>
        /// <param name="instance">The ListView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RetrieveVirtualItem event on the ListView instance.</returns>
        public static IObservable<EventPattern<RetrieveVirtualItemEventArgs>> RetrieveVirtualItemObservable(this ListView instance)
        {
            return Observable.FromEventPattern<RetrieveVirtualItemEventHandler, RetrieveVirtualItemEventArgs>(
                handler => instance.RetrieveVirtualItem += handler,
                handler => instance.RetrieveVirtualItem -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the SearchForVirtualItem event on the ListView instance.
        /// </summary>
        /// <param name="instance">The ListView instance to observe.</param>
        /// <returns>An observable sequence wrapping the SearchForVirtualItem event on the ListView instance.</returns>
        public static IObservable<EventPattern<SearchForVirtualItemEventArgs>> SearchForVirtualItemObservable(this ListView instance)
        {
            return Observable.FromEventPattern<SearchForVirtualItemEventHandler, SearchForVirtualItemEventArgs>(
                handler => instance.SearchForVirtualItem += handler,
                handler => instance.SearchForVirtualItem -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the SelectedIndexChanged event on the ListView instance.
        /// </summary>
        /// <param name="instance">The ListView instance to observe.</param>
        /// <returns>An observable sequence wrapping the SelectedIndexChanged event on the ListView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> SelectedIndexChangedObservable(this ListView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.SelectedIndexChanged += handler,
                handler => instance.SelectedIndexChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the VirtualItemsSelectionRangeChanged event on the ListView instance.
        /// </summary>
        /// <param name="instance">The ListView instance to observe.</param>
        /// <returns>An observable sequence wrapping the VirtualItemsSelectionRangeChanged event on the ListView instance.</returns>
        public static IObservable<EventPattern<ListViewVirtualItemsSelectionRangeChangedEventArgs>> VirtualItemsSelectionRangeChangedObservable(this ListView instance)
        {
            return Observable.FromEventPattern<ListViewVirtualItemsSelectionRangeChangedEventHandler, ListViewVirtualItemsSelectionRangeChangedEventArgs>(
                handler => instance.VirtualItemsSelectionRangeChanged += handler,
                handler => instance.VirtualItemsSelectionRangeChanged -= handler);
        }
    }
}

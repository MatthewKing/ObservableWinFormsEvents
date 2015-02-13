namespace System.Windows.Forms
{
    using System;
    using System.Reactive;
    using System.Reactive.Linq;

    /// <summary>
    /// Extension methods providing IObservable wrappers for the events on DataGridView.
    /// </summary>
    public static class ObservableDataGridViewEvents
    {
        /// <summary>
        /// Returns an observable sequence wrapping the AllowUserToAddRowsChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the AllowUserToAddRowsChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> AllowUserToAddRowsChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.AllowUserToAddRowsChanged += handler,
                handler => instance.AllowUserToAddRowsChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the AllowUserToDeleteRowsChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the AllowUserToDeleteRowsChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> AllowUserToDeleteRowsChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.AllowUserToDeleteRowsChanged += handler,
                handler => instance.AllowUserToDeleteRowsChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the AllowUserToOrderColumnsChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the AllowUserToOrderColumnsChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> AllowUserToOrderColumnsChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.AllowUserToOrderColumnsChanged += handler,
                handler => instance.AllowUserToOrderColumnsChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the AllowUserToResizeColumnsChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the AllowUserToResizeColumnsChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> AllowUserToResizeColumnsChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.AllowUserToResizeColumnsChanged += handler,
                handler => instance.AllowUserToResizeColumnsChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the AllowUserToResizeRowsChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the AllowUserToResizeRowsChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> AllowUserToResizeRowsChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.AllowUserToResizeRowsChanged += handler,
                handler => instance.AllowUserToResizeRowsChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the AlternatingRowsDefaultCellStyleChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the AlternatingRowsDefaultCellStyleChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> AlternatingRowsDefaultCellStyleChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.AlternatingRowsDefaultCellStyleChanged += handler,
                handler => instance.AlternatingRowsDefaultCellStyleChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the AutoGenerateColumnsChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the AutoGenerateColumnsChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> AutoGenerateColumnsChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.AutoGenerateColumnsChanged += handler,
                handler => instance.AutoGenerateColumnsChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the AutoSizeColumnsModeChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the AutoSizeColumnsModeChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewAutoSizeColumnsModeEventArgs>> AutoSizeColumnsModeChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewAutoSizeColumnsModeEventHandler, DataGridViewAutoSizeColumnsModeEventArgs>(
                handler => instance.AutoSizeColumnsModeChanged += handler,
                handler => instance.AutoSizeColumnsModeChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the AutoSizeRowsModeChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the AutoSizeRowsModeChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewAutoSizeModeEventArgs>> AutoSizeRowsModeChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewAutoSizeModeEventHandler, DataGridViewAutoSizeModeEventArgs>(
                handler => instance.AutoSizeRowsModeChanged += handler,
                handler => instance.AutoSizeRowsModeChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackColorChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackColorChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackColorChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackColorChanged += handler,
                handler => instance.BackColorChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundColorChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundColorChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundColorChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundColorChanged += handler,
                handler => instance.BackgroundColorChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageChanged += handler,
                handler => instance.BackgroundImageChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BackgroundImageLayoutChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the BackgroundImageLayoutChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BackgroundImageLayoutChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BackgroundImageLayoutChanged += handler,
                handler => instance.BackgroundImageLayoutChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the BorderStyleChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the BorderStyleChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> BorderStyleChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.BorderStyleChanged += handler,
                handler => instance.BorderStyleChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellBorderStyleChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellBorderStyleChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> CellBorderStyleChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.CellBorderStyleChanged += handler,
                handler => instance.CellBorderStyleChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ColumnHeadersBorderStyleChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ColumnHeadersBorderStyleChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ColumnHeadersBorderStyleChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ColumnHeadersBorderStyleChanged += handler,
                handler => instance.ColumnHeadersBorderStyleChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ColumnHeadersDefaultCellStyleChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ColumnHeadersDefaultCellStyleChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ColumnHeadersDefaultCellStyleChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ColumnHeadersDefaultCellStyleChanged += handler,
                handler => instance.ColumnHeadersDefaultCellStyleChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ColumnHeadersHeightChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ColumnHeadersHeightChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ColumnHeadersHeightChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ColumnHeadersHeightChanged += handler,
                handler => instance.ColumnHeadersHeightChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ColumnHeadersHeightSizeModeChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ColumnHeadersHeightSizeModeChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewAutoSizeModeEventArgs>> ColumnHeadersHeightSizeModeChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewAutoSizeModeEventHandler, DataGridViewAutoSizeModeEventArgs>(
                handler => instance.ColumnHeadersHeightSizeModeChanged += handler,
                handler => instance.ColumnHeadersHeightSizeModeChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DataMemberChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the DataMemberChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DataMemberChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DataMemberChanged += handler,
                handler => instance.DataMemberChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DataSourceChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the DataSourceChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DataSourceChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DataSourceChanged += handler,
                handler => instance.DataSourceChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DefaultCellStyleChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the DefaultCellStyleChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> DefaultCellStyleChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.DefaultCellStyleChanged += handler,
                handler => instance.DefaultCellStyleChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the EditModeChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the EditModeChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> EditModeChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.EditModeChanged += handler,
                handler => instance.EditModeChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ForeColorChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ForeColorChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ForeColorChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ForeColorChanged += handler,
                handler => instance.ForeColorChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the FontChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the FontChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> FontChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.FontChanged += handler,
                handler => instance.FontChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the GridColorChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the GridColorChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> GridColorChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.GridColorChanged += handler,
                handler => instance.GridColorChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the MultiSelectChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the MultiSelectChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> MultiSelectChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.MultiSelectChanged += handler,
                handler => instance.MultiSelectChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the PaddingChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the PaddingChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> PaddingChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.PaddingChanged += handler,
                handler => instance.PaddingChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ReadOnlyChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ReadOnlyChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> ReadOnlyChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.ReadOnlyChanged += handler,
                handler => instance.ReadOnlyChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowHeadersBorderStyleChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowHeadersBorderStyleChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> RowHeadersBorderStyleChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.RowHeadersBorderStyleChanged += handler,
                handler => instance.RowHeadersBorderStyleChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowHeadersDefaultCellStyleChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowHeadersDefaultCellStyleChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> RowHeadersDefaultCellStyleChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.RowHeadersDefaultCellStyleChanged += handler,
                handler => instance.RowHeadersDefaultCellStyleChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowHeadersWidthChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowHeadersWidthChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> RowHeadersWidthChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.RowHeadersWidthChanged += handler,
                handler => instance.RowHeadersWidthChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowHeadersWidthSizeModeChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowHeadersWidthSizeModeChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewAutoSizeModeEventArgs>> RowHeadersWidthSizeModeChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewAutoSizeModeEventHandler, DataGridViewAutoSizeModeEventArgs>(
                handler => instance.RowHeadersWidthSizeModeChanged += handler,
                handler => instance.RowHeadersWidthSizeModeChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowsDefaultCellStyleChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowsDefaultCellStyleChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> RowsDefaultCellStyleChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.RowsDefaultCellStyleChanged += handler,
                handler => instance.RowsDefaultCellStyleChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the TextChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the TextChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> TextChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.TextChanged += handler,
                handler => instance.TextChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the AutoSizeColumnModeChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the AutoSizeColumnModeChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewAutoSizeColumnModeEventArgs>> AutoSizeColumnModeChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewAutoSizeColumnModeEventHandler, DataGridViewAutoSizeColumnModeEventArgs>(
                handler => instance.AutoSizeColumnModeChanged += handler,
                handler => instance.AutoSizeColumnModeChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CancelRowEdit event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CancelRowEdit event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<QuestionEventArgs>> CancelRowEditObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<QuestionEventHandler, QuestionEventArgs>(
                handler => instance.CancelRowEdit += handler,
                handler => instance.CancelRowEdit -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellBeginEdit event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellBeginEdit event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellCancelEventArgs>> CellBeginEditObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellCancelEventHandler, DataGridViewCellCancelEventArgs>(
                handler => instance.CellBeginEdit += handler,
                handler => instance.CellBeginEdit -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellClick event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellClick event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellEventArgs>> CellClickObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                handler => instance.CellClick += handler,
                handler => instance.CellClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellContentClick event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellContentClick event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellEventArgs>> CellContentClickObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                handler => instance.CellContentClick += handler,
                handler => instance.CellContentClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellContentDoubleClick event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellContentDoubleClick event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellEventArgs>> CellContentDoubleClickObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                handler => instance.CellContentDoubleClick += handler,
                handler => instance.CellContentDoubleClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellContextMenuStripChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellContextMenuStripChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellEventArgs>> CellContextMenuStripChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                handler => instance.CellContextMenuStripChanged += handler,
                handler => instance.CellContextMenuStripChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellContextMenuStripNeeded event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellContextMenuStripNeeded event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellContextMenuStripNeededEventArgs>> CellContextMenuStripNeededObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellContextMenuStripNeededEventHandler, DataGridViewCellContextMenuStripNeededEventArgs>(
                handler => instance.CellContextMenuStripNeeded += handler,
                handler => instance.CellContextMenuStripNeeded -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellDoubleClick event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellDoubleClick event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellEventArgs>> CellDoubleClickObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                handler => instance.CellDoubleClick += handler,
                handler => instance.CellDoubleClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellEndEdit event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellEndEdit event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellEventArgs>> CellEndEditObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                handler => instance.CellEndEdit += handler,
                handler => instance.CellEndEdit -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellEnter event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellEnter event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellEventArgs>> CellEnterObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                handler => instance.CellEnter += handler,
                handler => instance.CellEnter -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellErrorTextChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellErrorTextChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellEventArgs>> CellErrorTextChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                handler => instance.CellErrorTextChanged += handler,
                handler => instance.CellErrorTextChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellErrorTextNeeded event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellErrorTextNeeded event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellErrorTextNeededEventArgs>> CellErrorTextNeededObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellErrorTextNeededEventHandler, DataGridViewCellErrorTextNeededEventArgs>(
                handler => instance.CellErrorTextNeeded += handler,
                handler => instance.CellErrorTextNeeded -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellFormatting event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellFormatting event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellFormattingEventArgs>> CellFormattingObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellFormattingEventHandler, DataGridViewCellFormattingEventArgs>(
                handler => instance.CellFormatting += handler,
                handler => instance.CellFormatting -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellLeave event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellLeave event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellEventArgs>> CellLeaveObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                handler => instance.CellLeave += handler,
                handler => instance.CellLeave -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellMouseClick event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellMouseClick event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellMouseEventArgs>> CellMouseClickObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                handler => instance.CellMouseClick += handler,
                handler => instance.CellMouseClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellMouseDoubleClick event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellMouseDoubleClick event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellMouseEventArgs>> CellMouseDoubleClickObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                handler => instance.CellMouseDoubleClick += handler,
                handler => instance.CellMouseDoubleClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellMouseDown event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellMouseDown event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellMouseEventArgs>> CellMouseDownObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                handler => instance.CellMouseDown += handler,
                handler => instance.CellMouseDown -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellMouseEnter event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellMouseEnter event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellEventArgs>> CellMouseEnterObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                handler => instance.CellMouseEnter += handler,
                handler => instance.CellMouseEnter -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellMouseLeave event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellMouseLeave event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellEventArgs>> CellMouseLeaveObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                handler => instance.CellMouseLeave += handler,
                handler => instance.CellMouseLeave -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellMouseMove event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellMouseMove event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellMouseEventArgs>> CellMouseMoveObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                handler => instance.CellMouseMove += handler,
                handler => instance.CellMouseMove -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellMouseUp event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellMouseUp event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellMouseEventArgs>> CellMouseUpObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                handler => instance.CellMouseUp += handler,
                handler => instance.CellMouseUp -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellPainting event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellPainting event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellPaintingEventArgs>> CellPaintingObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellPaintingEventHandler, DataGridViewCellPaintingEventArgs>(
                handler => instance.CellPainting += handler,
                handler => instance.CellPainting -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellParsing event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellParsing event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellParsingEventArgs>> CellParsingObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellParsingEventHandler, DataGridViewCellParsingEventArgs>(
                handler => instance.CellParsing += handler,
                handler => instance.CellParsing -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellStateChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellStateChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellStateChangedEventArgs>> CellStateChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellStateChangedEventHandler, DataGridViewCellStateChangedEventArgs>(
                handler => instance.CellStateChanged += handler,
                handler => instance.CellStateChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellStyleChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellStyleChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellEventArgs>> CellStyleChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                handler => instance.CellStyleChanged += handler,
                handler => instance.CellStyleChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellStyleContentChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellStyleContentChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellStyleContentChangedEventArgs>> CellStyleContentChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellStyleContentChangedEventHandler, DataGridViewCellStyleContentChangedEventArgs>(
                handler => instance.CellStyleContentChanged += handler,
                handler => instance.CellStyleContentChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellToolTipTextChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellToolTipTextChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellEventArgs>> CellToolTipTextChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                handler => instance.CellToolTipTextChanged += handler,
                handler => instance.CellToolTipTextChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellToolTipTextNeeded event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellToolTipTextNeeded event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellToolTipTextNeededEventArgs>> CellToolTipTextNeededObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellToolTipTextNeededEventHandler, DataGridViewCellToolTipTextNeededEventArgs>(
                handler => instance.CellToolTipTextNeeded += handler,
                handler => instance.CellToolTipTextNeeded -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellValidated event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellValidated event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellEventArgs>> CellValidatedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                handler => instance.CellValidated += handler,
                handler => instance.CellValidated -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellValidating event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellValidating event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellValidatingEventArgs>> CellValidatingObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellValidatingEventHandler, DataGridViewCellValidatingEventArgs>(
                handler => instance.CellValidating += handler,
                handler => instance.CellValidating -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellValueChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellValueChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellEventArgs>> CellValueChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                handler => instance.CellValueChanged += handler,
                handler => instance.CellValueChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellValueNeeded event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellValueNeeded event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellValueEventArgs>> CellValueNeededObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellValueEventHandler, DataGridViewCellValueEventArgs>(
                handler => instance.CellValueNeeded += handler,
                handler => instance.CellValueNeeded -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CellValuePushed event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CellValuePushed event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellValueEventArgs>> CellValuePushedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellValueEventHandler, DataGridViewCellValueEventArgs>(
                handler => instance.CellValuePushed += handler,
                handler => instance.CellValuePushed -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ColumnAdded event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ColumnAdded event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewColumnEventArgs>> ColumnAddedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                handler => instance.ColumnAdded += handler,
                handler => instance.ColumnAdded -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ColumnContextMenuStripChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ColumnContextMenuStripChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewColumnEventArgs>> ColumnContextMenuStripChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                handler => instance.ColumnContextMenuStripChanged += handler,
                handler => instance.ColumnContextMenuStripChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ColumnDataPropertyNameChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ColumnDataPropertyNameChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewColumnEventArgs>> ColumnDataPropertyNameChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                handler => instance.ColumnDataPropertyNameChanged += handler,
                handler => instance.ColumnDataPropertyNameChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ColumnDefaultCellStyleChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ColumnDefaultCellStyleChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewColumnEventArgs>> ColumnDefaultCellStyleChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                handler => instance.ColumnDefaultCellStyleChanged += handler,
                handler => instance.ColumnDefaultCellStyleChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ColumnDisplayIndexChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ColumnDisplayIndexChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewColumnEventArgs>> ColumnDisplayIndexChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                handler => instance.ColumnDisplayIndexChanged += handler,
                handler => instance.ColumnDisplayIndexChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ColumnDividerDoubleClick event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ColumnDividerDoubleClick event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewColumnDividerDoubleClickEventArgs>> ColumnDividerDoubleClickObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewColumnDividerDoubleClickEventHandler, DataGridViewColumnDividerDoubleClickEventArgs>(
                handler => instance.ColumnDividerDoubleClick += handler,
                handler => instance.ColumnDividerDoubleClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ColumnDividerWidthChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ColumnDividerWidthChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewColumnEventArgs>> ColumnDividerWidthChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                handler => instance.ColumnDividerWidthChanged += handler,
                handler => instance.ColumnDividerWidthChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ColumnHeaderMouseClick event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ColumnHeaderMouseClick event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellMouseEventArgs>> ColumnHeaderMouseClickObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                handler => instance.ColumnHeaderMouseClick += handler,
                handler => instance.ColumnHeaderMouseClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ColumnHeaderMouseDoubleClick event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ColumnHeaderMouseDoubleClick event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellMouseEventArgs>> ColumnHeaderMouseDoubleClickObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                handler => instance.ColumnHeaderMouseDoubleClick += handler,
                handler => instance.ColumnHeaderMouseDoubleClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ColumnHeaderCellChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ColumnHeaderCellChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewColumnEventArgs>> ColumnHeaderCellChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                handler => instance.ColumnHeaderCellChanged += handler,
                handler => instance.ColumnHeaderCellChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ColumnMinimumWidthChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ColumnMinimumWidthChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewColumnEventArgs>> ColumnMinimumWidthChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                handler => instance.ColumnMinimumWidthChanged += handler,
                handler => instance.ColumnMinimumWidthChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ColumnNameChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ColumnNameChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewColumnEventArgs>> ColumnNameChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                handler => instance.ColumnNameChanged += handler,
                handler => instance.ColumnNameChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ColumnRemoved event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ColumnRemoved event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewColumnEventArgs>> ColumnRemovedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                handler => instance.ColumnRemoved += handler,
                handler => instance.ColumnRemoved -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ColumnSortModeChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ColumnSortModeChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewColumnEventArgs>> ColumnSortModeChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                handler => instance.ColumnSortModeChanged += handler,
                handler => instance.ColumnSortModeChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ColumnStateChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ColumnStateChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewColumnStateChangedEventArgs>> ColumnStateChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewColumnStateChangedEventHandler, DataGridViewColumnStateChangedEventArgs>(
                handler => instance.ColumnStateChanged += handler,
                handler => instance.ColumnStateChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ColumnToolTipTextChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ColumnToolTipTextChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewColumnEventArgs>> ColumnToolTipTextChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                handler => instance.ColumnToolTipTextChanged += handler,
                handler => instance.ColumnToolTipTextChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the ColumnWidthChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the ColumnWidthChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewColumnEventArgs>> ColumnWidthChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                handler => instance.ColumnWidthChanged += handler,
                handler => instance.ColumnWidthChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CurrentCellChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CurrentCellChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> CurrentCellChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.CurrentCellChanged += handler,
                handler => instance.CurrentCellChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the CurrentCellDirtyStateChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the CurrentCellDirtyStateChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> CurrentCellDirtyStateChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.CurrentCellDirtyStateChanged += handler,
                handler => instance.CurrentCellDirtyStateChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DataBindingComplete event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the DataBindingComplete event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewBindingCompleteEventArgs>> DataBindingCompleteObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewBindingCompleteEventHandler, DataGridViewBindingCompleteEventArgs>(
                handler => instance.DataBindingComplete += handler,
                handler => instance.DataBindingComplete -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DataError event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the DataError event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewDataErrorEventArgs>> DataErrorObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewDataErrorEventHandler, DataGridViewDataErrorEventArgs>(
                handler => instance.DataError += handler,
                handler => instance.DataError -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the DefaultValuesNeeded event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the DefaultValuesNeeded event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewRowEventArgs>> DefaultValuesNeededObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                handler => instance.DefaultValuesNeeded += handler,
                handler => instance.DefaultValuesNeeded -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the EditingControlShowing event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the EditingControlShowing event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewEditingControlShowingEventArgs>> EditingControlShowingObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewEditingControlShowingEventHandler, DataGridViewEditingControlShowingEventArgs>(
                handler => instance.EditingControlShowing += handler,
                handler => instance.EditingControlShowing -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the NewRowNeeded event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the NewRowNeeded event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewRowEventArgs>> NewRowNeededObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                handler => instance.NewRowNeeded += handler,
                handler => instance.NewRowNeeded -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowContextMenuStripChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowContextMenuStripChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewRowEventArgs>> RowContextMenuStripChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                handler => instance.RowContextMenuStripChanged += handler,
                handler => instance.RowContextMenuStripChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowContextMenuStripNeeded event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowContextMenuStripNeeded event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewRowContextMenuStripNeededEventArgs>> RowContextMenuStripNeededObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewRowContextMenuStripNeededEventHandler, DataGridViewRowContextMenuStripNeededEventArgs>(
                handler => instance.RowContextMenuStripNeeded += handler,
                handler => instance.RowContextMenuStripNeeded -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowDefaultCellStyleChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowDefaultCellStyleChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewRowEventArgs>> RowDefaultCellStyleChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                handler => instance.RowDefaultCellStyleChanged += handler,
                handler => instance.RowDefaultCellStyleChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowDirtyStateNeeded event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowDirtyStateNeeded event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<QuestionEventArgs>> RowDirtyStateNeededObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<QuestionEventHandler, QuestionEventArgs>(
                handler => instance.RowDirtyStateNeeded += handler,
                handler => instance.RowDirtyStateNeeded -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowDividerDoubleClick event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowDividerDoubleClick event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewRowDividerDoubleClickEventArgs>> RowDividerDoubleClickObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewRowDividerDoubleClickEventHandler, DataGridViewRowDividerDoubleClickEventArgs>(
                handler => instance.RowDividerDoubleClick += handler,
                handler => instance.RowDividerDoubleClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowDividerHeightChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowDividerHeightChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewRowEventArgs>> RowDividerHeightChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                handler => instance.RowDividerHeightChanged += handler,
                handler => instance.RowDividerHeightChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowEnter event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowEnter event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellEventArgs>> RowEnterObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                handler => instance.RowEnter += handler,
                handler => instance.RowEnter -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowErrorTextChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowErrorTextChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewRowEventArgs>> RowErrorTextChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                handler => instance.RowErrorTextChanged += handler,
                handler => instance.RowErrorTextChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowErrorTextNeeded event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowErrorTextNeeded event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewRowErrorTextNeededEventArgs>> RowErrorTextNeededObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewRowErrorTextNeededEventHandler, DataGridViewRowErrorTextNeededEventArgs>(
                handler => instance.RowErrorTextNeeded += handler,
                handler => instance.RowErrorTextNeeded -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowHeaderMouseClick event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowHeaderMouseClick event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellMouseEventArgs>> RowHeaderMouseClickObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                handler => instance.RowHeaderMouseClick += handler,
                handler => instance.RowHeaderMouseClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowHeaderMouseDoubleClick event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowHeaderMouseDoubleClick event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellMouseEventArgs>> RowHeaderMouseDoubleClickObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                handler => instance.RowHeaderMouseDoubleClick += handler,
                handler => instance.RowHeaderMouseDoubleClick -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowHeaderCellChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowHeaderCellChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewRowEventArgs>> RowHeaderCellChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                handler => instance.RowHeaderCellChanged += handler,
                handler => instance.RowHeaderCellChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowHeightChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowHeightChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewRowEventArgs>> RowHeightChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                handler => instance.RowHeightChanged += handler,
                handler => instance.RowHeightChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowHeightInfoNeeded event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowHeightInfoNeeded event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewRowHeightInfoNeededEventArgs>> RowHeightInfoNeededObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewRowHeightInfoNeededEventHandler, DataGridViewRowHeightInfoNeededEventArgs>(
                handler => instance.RowHeightInfoNeeded += handler,
                handler => instance.RowHeightInfoNeeded -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowHeightInfoPushed event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowHeightInfoPushed event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewRowHeightInfoPushedEventArgs>> RowHeightInfoPushedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewRowHeightInfoPushedEventHandler, DataGridViewRowHeightInfoPushedEventArgs>(
                handler => instance.RowHeightInfoPushed += handler,
                handler => instance.RowHeightInfoPushed -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowLeave event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowLeave event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellEventArgs>> RowLeaveObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                handler => instance.RowLeave += handler,
                handler => instance.RowLeave -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowMinimumHeightChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowMinimumHeightChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewRowEventArgs>> RowMinimumHeightChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                handler => instance.RowMinimumHeightChanged += handler,
                handler => instance.RowMinimumHeightChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowPostPaint event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowPostPaint event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewRowPostPaintEventArgs>> RowPostPaintObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewRowPostPaintEventHandler, DataGridViewRowPostPaintEventArgs>(
                handler => instance.RowPostPaint += handler,
                handler => instance.RowPostPaint -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowPrePaint event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowPrePaint event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewRowPrePaintEventArgs>> RowPrePaintObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewRowPrePaintEventHandler, DataGridViewRowPrePaintEventArgs>(
                handler => instance.RowPrePaint += handler,
                handler => instance.RowPrePaint -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowsAdded event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowsAdded event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewRowsAddedEventArgs>> RowsAddedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewRowsAddedEventHandler, DataGridViewRowsAddedEventArgs>(
                handler => instance.RowsAdded += handler,
                handler => instance.RowsAdded -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowsRemoved event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowsRemoved event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewRowsRemovedEventArgs>> RowsRemovedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewRowsRemovedEventHandler, DataGridViewRowsRemovedEventArgs>(
                handler => instance.RowsRemoved += handler,
                handler => instance.RowsRemoved -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowStateChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowStateChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewRowStateChangedEventArgs>> RowStateChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewRowStateChangedEventHandler, DataGridViewRowStateChangedEventArgs>(
                handler => instance.RowStateChanged += handler,
                handler => instance.RowStateChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowUnshared event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowUnshared event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewRowEventArgs>> RowUnsharedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                handler => instance.RowUnshared += handler,
                handler => instance.RowUnshared -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowValidated event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowValidated event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellEventArgs>> RowValidatedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                handler => instance.RowValidated += handler,
                handler => instance.RowValidated -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the RowValidating event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the RowValidating event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewCellCancelEventArgs>> RowValidatingObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewCellCancelEventHandler, DataGridViewCellCancelEventArgs>(
                handler => instance.RowValidating += handler,
                handler => instance.RowValidating -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Scroll event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the Scroll event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<ScrollEventArgs>> ScrollObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<ScrollEventHandler, ScrollEventArgs>(
                handler => instance.Scroll += handler,
                handler => instance.Scroll -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the SelectionChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the SelectionChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> SelectionChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.SelectionChanged += handler,
                handler => instance.SelectionChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the SortCompare event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the SortCompare event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewSortCompareEventArgs>> SortCompareObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewSortCompareEventHandler, DataGridViewSortCompareEventArgs>(
                handler => instance.SortCompare += handler,
                handler => instance.SortCompare -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the Sorted event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the Sorted event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> SortedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.Sorted += handler,
                handler => instance.Sorted -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the StyleChanged event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the StyleChanged event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<EventArgs>> StyleChangedObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<EventHandler, EventArgs>(
                handler => instance.StyleChanged += handler,
                handler => instance.StyleChanged -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the UserAddedRow event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the UserAddedRow event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewRowEventArgs>> UserAddedRowObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                handler => instance.UserAddedRow += handler,
                handler => instance.UserAddedRow -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the UserDeletedRow event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the UserDeletedRow event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewRowEventArgs>> UserDeletedRowObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                handler => instance.UserDeletedRow += handler,
                handler => instance.UserDeletedRow -= handler);
        }

        /// <summary>
        /// Returns an observable sequence wrapping the UserDeletingRow event on the DataGridView instance.
        /// </summary>
        /// <param name="instance">The DataGridView instance to observe.</param>
        /// <returns>An observable sequence wrapping the UserDeletingRow event on the DataGridView instance.</returns>
        public static IObservable<EventPattern<DataGridViewRowCancelEventArgs>> UserDeletingRowObservable(this DataGridView instance)
        {
            return Observable.FromEventPattern<DataGridViewRowCancelEventHandler, DataGridViewRowCancelEventArgs>(
                handler => instance.UserDeletingRow += handler,
                handler => instance.UserDeletingRow -= handler);
        }
    }
}

' Class Name:   frmDisplayTaxRates
' Author:       Tu Tong
' Date:         December 10, 2017
' Purpose:      The frmDisplayTaxRates Form is opened by frmIncomeTax Form
'               and displays the Tax Ranges in various countries

' Turn off conversion
Option Strict On

Public Class frmDisplayTaxRates

    Private objLVComparer As ListViewItemComparer

    Private Sub frmTaxRates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' The frmDisplayTaxRates load event handler
        ' add Tax Ranges to ListView

        lsvTaxRates.Items.Clear()

        For Each range In frmIncomeTax.m_objTaxRanges
            Dim item = New ListViewItem({range.Country, range.TaxRange})
            lsvTaxRates.Items.Add(item)
        Next

        ' initialize and assign a ListViewItemComparer for Tax Rates listview
        objLVComparer = New ListViewItemComparer()
        lsvTaxRates.ListViewItemSorter = objLVComparer

    End Sub

    Private Sub frmDisplayTaxRates_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Show the parent form
        Owner.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' close the form
        Close()
    End Sub

    ' Sorting ListView Items by Column Using Windows Forms
    ' https://msdn.microsoft.com/en-us/library/ms996467.aspx
    Private Sub lsvTaxRates_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lsvTaxRates.ColumnClick

        ' Determine whether the column is the same as the last column clicked.
        If objLVComparer.column <> e.Column Then
            ' Set the sort order to ascending by default.
            lsvTaxRates.Sorting = SortOrder.Ascending
        Else
            ' Determine what the last sort order was and change it.
            If lsvTaxRates.Sorting = SortOrder.Ascending Then
                lsvTaxRates.Sorting = SortOrder.Descending
            Else
                lsvTaxRates.Sorting = SortOrder.Ascending
            End If
        End If

        ' Set the sort column to the new column.
        objLVComparer.column = e.Column

        ' update sort order for comparer to same as listview
        objLVComparer.order = lsvTaxRates.Sorting

        ' Call the sort method to manually sort.
        lsvTaxRates.Sort()

        ' update label
        UpdateSortingLabelText(e.Column, lsvTaxRates.Sorting)

    End Sub

    Private Sub UpdateSortingLabelText(column As Integer, order As SortOrder)
        Dim strSortDesc As String = "The list sorted by "

        If column = 0 Then
            strSortDesc &= "Country"
        Else
            strSortDesc &= "Tax Rate"
        End If

        If order = SortOrder.Ascending Then
            strSortDesc &= " ascending order"
        Else
            strSortDesc &= " decending order"
        End If

        lblSortDesc.Text = strSortDesc
    End Sub

End Class


' Implements the manual sorting of items by column.
' https://msdn.microsoft.com/en-us/library/ms996467.aspx
Friend Class ListViewItemComparer
    Implements IComparer

    Friend column As Integer
    Friend order As SortOrder

    Public Sub New()
        column = 0
        order = SortOrder.Ascending
    End Sub

    Public Sub New(column As Integer, order As SortOrder)
        Me.column = column
        Me.order = order
    End Sub

    Public Function Compare(x As Object, y As Object) As Integer _
                            Implements System.Collections.IComparer.Compare

        Dim returnVal As Integer = -1

        ' compare 2 strings
        returnVal = CType(x, ListViewItem).SubItems(column).Text.CompareTo(
            CType(y, ListViewItem).SubItems(column).Text)

        ' Determine whether the sort order is descending.
        If order = SortOrder.Descending Then
            ' Invert the value returned by String.Compare.
            returnVal *= -1
        End If

        'Console.WriteLine("Value: " & returnVal)
        Return returnVal

    End Function

End Class

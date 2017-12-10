' Class Name:   frmDisplayTaxRates
' Author:       Tu Tong
' Date:         December 10, 2017
' Purpose:      The frmDisplayTaxRates Form is opened by frmIncomeTax Form
'               and displays the Tax Ranges in various countries

' Turn off conversion
Option Strict On

Public Class frmDisplayTaxRates

    Private Sub frmTaxRates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' The frmDisplayTaxRates load event handler
        ' add Tax Ranges to ListView

        lsvTaxRates.Items.Clear()

        For Each range In frmIncomeTax.m_objTaxRanges
            Dim item = New ListViewItem({range.Country, range.TaxRange})
            lsvTaxRates.Items.Add(item)
        Next

    End Sub

    Private Sub frmDisplayTaxRates_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Show the parent form
        Owner.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' close the form
        Close()
    End Sub

End Class
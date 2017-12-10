' Program Name: Perconal Income Tax Comparison by Country
' Author:       Tu Tong
' Date:         December 10, 2017
' Purpose:      This Windows application opens a text file aht lists the 
'               personal marginal income tax rate ranges for 17 countries. 
'               The user selects a country and displays the personal income 
'               tax rate range. A menu selection also can show the entire listing 
'               of the countries and the tax rate ranges on a second Windows Form Object.

' Turn off automatic conversion for values
Option Strict On

Public Class frmIncomeTax

    ' Tax ranges file
    Const cstrTaxRangesPath = "D:\tax.txt"

    ' shared tax ranges
    Public Shared m_objTaxRanges As List(Of TaxRange)


    Private Sub frmIncomeTax_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' The frmIncomeTax load event handler read tax ranges from tax.txt text
        ' and fill the ListBox with the TaxRange objects

        ' clear Tax Range listview
        lstCountries.Items.Clear()

        If LoadTaxRangesFromText(cstrTaxRangesPath) Then

            For Each tax In m_objTaxRanges
                lstCountries.Items.Add(tax)
            Next

        End If

    End Sub

    Function LoadTaxRangesFromText(strPath As String) As Boolean
        ' Open the given text file and load Tax Ranges into memory
        ' return True if file exist and read successfully

        ' if file does not exist, terminate the procedure
        If Not IO.File.Exists(strPath) Then
            MsgBox("The file is not available. Restart when the file is available.",
                   MsgBoxStyle.Critical, "Error")
            Return False
        End If

        ' Declare variables that use for reading text file
        Dim intCount As Integer = 0
        Dim objTaxRange As TaxRange

        ' initialize tax range array
        m_objTaxRanges = New List(Of TaxRange)

        Using objReader = IO.File.OpenText(strPath)

            ' Read the file line by line until the file is completed
            Do While objReader.Peek <> -1

                ' initialize new tax range object
                objTaxRange = New TaxRange(objReader.ReadLine(),
                                           objReader.ReadLine())

                ' add to list
                Console.WriteLine("Added " & objTaxRange.DebugInfo())
                m_objTaxRanges.Add(objTaxRange)

                intCount += 1
            Loop


        End Using

        Return True
    End Function

    Private Sub btnDisplayTaxRange_Click(sender As Object, e As EventArgs) Handles btnDisplayTaxRange.Click
        ' Click button event handler retrieve Country selected
        ' and display its tax range

        If lstCountries.SelectedIndex = -1 Then
            MsgBox("Select a country from list.", MsgBoxStyle.Information, "Select a country")
            Exit Sub
        End If

        ' get the selected tax range
        Dim selectedTaxRange As TaxRange = CType(lstCountries.SelectedItem, TaxRange)

        lblTaxRangeLabel.Text = "Tax rate of " & selectedTaxRange.Country
        lblTaxRange.Text = selectedTaxRange.TaxRange

        ' show Tax Range labels
        lblTaxRangeLabel.Visible = True
        lblTaxRange.Visible = True
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        ' Clear ListView selection and hide Tax Range labels

        lstCountries.ClearSelected()
        lblTaxRangeLabel.Visible = False
        lblTaxRange.Visible = False
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' The mnuExit click event closes the application
        Application.Exit()
    End Sub

    Private Sub mnuDisplayTaxForm_Click(sender As Object, e As EventArgs) Handles mnuDisplayTaxForm.Click
        ' The mnuDisplay click event creates an instance of the frmTaxRates
        Using frmSecond As New frmTaxRates
            ' Hide this form 
            Hide()

            ' add Owner and show the Display Inventory form
            Me.AddOwnedForm(frmSecond)
            frmSecond.ShowDialog()

        End Using
    End Sub
End Class

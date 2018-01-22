' Class Name:   TaxRange
' Author:       Tu Tong
' Date:         December 10, 2017
' Purpose:      Custom object for tax information
'               the class produce objects which are sortable and comparable

' Creating Classes in Visual Basic .NET
' https://msdn.microsoft.com/en-us/library/ms973814.aspx

Public Class TaxRange
    ' Sortable object implementation
    ' https://msdn.microsoft.com/en-us/library/b0zbh7b6%28v=vs.110%29.aspx?f=255&MSPPError=-2147217396
    Implements IComparable(Of TaxRange)
    Implements IEquatable(Of TaxRange)

    Public ReadOnly Country As String
    Public ReadOnly TaxRange As String

    Public Sub New(Country As String, TaxRange As String)

        Me.Country = Country
        Me.TaxRange = TaxRange

    End Sub

    ' Object Lifetime: How Objects Are Created and Destroyed 
    ' https://docs.microsoft.com/en-us/dotnet/visual-basic/programming-guide/language-features/objects-and-classes/object-lifetime-how-objects-are-created-and-destroyed
    Protected Overrides Sub Finalize()
        Console.WriteLine("Finalizing Tax Range: " & Country)
        MyBase.Finalize()
    End Sub

    Public Function DebugInfo() As String
        ' String format
        ' https://msdn.microsoft.com/en-us/library/system.string.format(v=vs.110).aspx
        Return String.Format("Tax range: {0}, {1}", Country, TaxRange)
    End Function

    Public Overrides Function ToString() As String
        Return Country
    End Function

    ' IComparable interface
    Public Function CompareTo(other As TaxRange) As Integer Implements IComparable(Of TaxRange).CompareTo
        Return Country.CompareTo(other.Country)
    End Function

    ' IEquatable interface
    Public Function Equals(other As TaxRange) As Boolean Implements IEquatable(Of TaxRange).Equals
        Return Country.Equals(other.Country)
    End Function

End Class

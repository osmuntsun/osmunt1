Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "osmunt1.txt", OpenMode.Input)
        FileOpen(2, "osmunt2.txt", OpenMode.Output)
        Dim O As Integer = LineInput(1)
        For i = 1 To O
            Dim S As String = LineInput(1)
            Dim M() As String = Split(S, " ")
            Dim U(M(0).Length) As Char
            For n = 1 To M(0).Length
                U(n) = Mid(M(0), n, 1)
            Next
            Dim V As Boolean = False
            For n = 1 To UBound(M)
                If M(1) = U(n) Then
                    V = True
                End If
            Next
            Dim K As String = ""
            If V = True Then
                K = "T"
            Else
                K = "F"
            End If
            PrintLine(2, K)
        Next
        MsgBox(0)
    End Sub
End Class

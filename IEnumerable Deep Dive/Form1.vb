Public Class Form1

    Private rand As New Random
    ''' <summary>
    ''' Generates an ienumerable of random numbers
    ''' </summary>
    ''' <param name="MaxValue">Sets the exclusive max value of random number range.</param>
    ''' <returns></returns>

    Iterator Function EndlessRandom(MaxValue As Integer) As IEnumerable(Of Integer)
        While True
            Yield rand.Next(0, MaxValue)
        End While



    End Function
    Private Sub btn20Random_Click(sender As Object, e As EventArgs) Handles btn20Random.Click
        Dim numbers As IEnumerable(Of Integer) = EndlessRandom(901).Take(20) ' lazy.  Not even processed yet

        numbers = numbers.ToArray 'step into this line.  See how it works.

        lstResults.Items.Clear()
        lstResults.DataSource = numbers



    End Sub
End Class

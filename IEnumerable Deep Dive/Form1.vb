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

    Iterator Function OnlyEven(source As IEnumerable(Of Integer)) As IEnumerable(Of Integer)
        For Each num In source
            If num Mod 2 = 0 Then Yield num
        Next
    End Function
    Private Sub btn20Random_Click(sender As Object, e As EventArgs) Handles btn20Random.Click
        Dim numbers As IEnumerable(Of Integer) = EndlessRandom(901).Take(20) ' lazy.  Not even processed yet

        Debug.WriteLine($"Numbers is a {numbers.GetType().FullName}")
        numbers = OnlyEven(numbers) 'still lazy.  
        Debug.WriteLine($"Numbers is a {numbers.GetType().FullName}")

        numbers = numbers.ToArray 'step into this line.  See how it works.

        Debug.WriteLine($"Numbers is a {numbers.GetType().FullName}")

        lstResults.Items.Clear()
        lstResults.DataSource = numbers



    End Sub
End Class

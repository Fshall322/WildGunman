Public Class MessBox

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Me.Close()
        GameScreen.Show()
    End Sub

    Private Sub MessBox_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        GameScreen.lblRound.Text = "Round " & GameScreen.roundNumber.ToString
    End Sub

    Private Sub MessBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'display round score in label
        Me.lblScore.Text = GameScreen.score
        'tally up total score
        GameScreen.totalScore = GameScreen.totalScore + GameScreen.score
        'display total score in label
        Me.lblTotalScore.Text = GameScreen.totalScore
        Me.lblRound.Text = "Round " & GameScreen.roundNumber & " results"
        GameScreen.roundNumber += 1
        'reset the round score
        GameScreen.score = 0
        Me.btnContinue.Text = "Continue to Round " & GameScreen.roundNumber
    End Sub

End Class
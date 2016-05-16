Public Class GameScreen
    Dim rndNum As New Random(System.DateTime.Now.Millisecond)

    Public roundNumber As Integer = 1
    Public score As Integer = 0
    Public totalScore As Integer = 0
    Dim holder As Integer
    'change picture or create animation on hit??
    Dim icons(30) As String
    'variable used to keep track the number of seconds for the timer
    Dim y As Integer
    Dim ft As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'make sure there are no images set in the picture boxes -- (red x or green check)
        Me.PictureBox1.Image = Nothing
        Me.PictureBox2.Image = Nothing
        Me.PictureBox3.Image = Nothing
        Me.PictureBox4.Image = Nothing
        Me.PictureBox5.Image = Nothing
        Me.PictureBox6.Image = Nothing
        Me.PictureBox7.Image = Nothing
        Me.PictureBox8.Image = Nothing
        Me.PictureBox9.Image = Nothing
        Me.PictureBox10.Image = Nothing
        Me.PictureBox11.Image = Nothing
        Me.PictureBox12.Image = Nothing
        Me.PictureBox13.Image = Nothing
        Me.PictureBox14.Image = Nothing
        Me.PictureBox15.Image = Nothing
        Me.PictureBox16.Image = Nothing
        'enable the picture boxes so they can be clicked
        Me.PictureBox1.Enabled = True
        Me.PictureBox2.Enabled = True
        Me.PictureBox3.Enabled = True
        Me.PictureBox4.Enabled = True
        Me.PictureBox5.Enabled = True
        Me.PictureBox6.Enabled = True
        Me.PictureBox7.Enabled = True
        Me.PictureBox8.Enabled = True
        Me.PictureBox9.Enabled = True
        Me.PictureBox10.Enabled = True
        Me.PictureBox11.Enabled = True
        Me.PictureBox12.Enabled = True
        Me.PictureBox13.Enabled = True
        Me.PictureBox14.Enabled = True
        Me.PictureBox15.Enabled = True
        Me.PictureBox16.Enabled = True
        'make the picture boxes visible so they can be seen
        Me.PictureBox1.Visible = True
        Me.PictureBox2.Visible = True
        Me.PictureBox3.Visible = True
        Me.PictureBox4.Visible = True
        Me.PictureBox5.Visible = True
        Me.PictureBox6.Visible = True
        Me.PictureBox7.Visible = True
        Me.PictureBox8.Visible = True
        Me.PictureBox9.Visible = True
        Me.PictureBox10.Visible = True
        Me.PictureBox11.Visible = True
        Me.PictureBox12.Visible = True
        Me.PictureBox13.Visible = True
        Me.PictureBox14.Visible = True
        Me.PictureBox15.Visible = True
        Me.PictureBox16.Visible = True
        'random number used to designate what pictures are set as the background image in the picture boxes
        holder = rndNum.Next(0, 6)

        'this loop sets the random images into each picture box and an array is associated with each as to determine
        'if it is a "good guy" or a "bad guy"
        For Each cntrl As Control In Me.Controls

            If TypeOf cntrl Is PictureBox Then
                If cntrl.Name.Length > 11 Then 'this looks at the last index of array to determine good or bad (1 or 2)
                    ft = cntrl.Name.ToString.Substring(cntrl.Name.Length - 2, 2)
                Else
                    ft = cntrl.Name.ToString.Substring(cntrl.Name.Length - 1, 1)
                End If

                cntrl.BackgroundImageLayout = ImageLayout.Stretch
                Select Case holder
                    Case 0
                        cntrl.BackgroundImage = My.Resources.goodguy1
                        icons(ft) = "1"
                    Case 1
                        cntrl.BackgroundImage = My.Resources.goodguy2
                        icons(ft) = "1"
                    Case 2
                        cntrl.BackgroundImage = My.Resources.goodguy3
                        icons(ft) = "1"
                    Case 3
                        cntrl.BackgroundImage = My.Resources.badguy1
                        icons(ft) = "2"
                    Case 4
                        cntrl.BackgroundImage = My.Resources.badguy2
                        icons(ft) = "2"
                    Case 5
                        cntrl.BackgroundImage = My.Resources.badguy3
                        icons(ft) = "2"
                End Select
            End If
            'grab new random number for the next iteration of the loop
            holder = rndNum.Next(0, 6)
        Next
        'start timer
        Timer1.Enabled = True
        Timer1.Start()
        'make start button invisible so user cannot reset in the middle of the round
        Me.btnStart.Visible = False
    End Sub

    'each picture box checks for a good guy or bad guy on click
    'and then scores appropriately while disabling the box so it cannot be clicked again in the same round
    'a good guy gets a red x and a bad guy get a breen check
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        My.Computer.Audio.Play(My.Resources.gunshot, AudioPlayMode.Background)
        Me.PictureBox1.Enabled = False
        If icons(1).ToString = "1" Then
            Me.PictureBox1.Image = My.Resources.redx
            'My.Computer.Audio.Play(My.Resources.buzz, AudioPlayMode.Background)
            score = score - 100
        Else
            'My.Computer.Audio.Play(My.Resources.ting, AudioPlayMode.Background)
            Me.PictureBox1.Image = My.Resources.greencheck
            score = score + 50
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        My.Computer.Audio.Play(My.Resources.gunshot, AudioPlayMode.Background)
        Me.PictureBox2.Enabled = False
        If icons(2).ToString = "1" Then
            Me.PictureBox2.Image = My.Resources.redx
            'My.Computer.Audio.Play(My.Resources.buzz, AudioPlayMode.Background)
            score = score - 100
        Else
            ' My.Computer.Audio.Play(My.Resources.ting, AudioPlayMode.Background)
            Me.PictureBox2.Image = My.Resources.greencheck
            score = score + 50
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        My.Computer.Audio.Play(My.Resources.gunshot, AudioPlayMode.Background)
        Me.PictureBox3.Enabled = False
        If icons(3).ToString = "1" Then
            Me.PictureBox3.Image = My.Resources.redx
            'My.Computer.Audio.Play(My.Resources.buzz, AudioPlayMode.Background)
            score = score - 100
        Else
            'My.Computer.Audio.Play(My.Resources.ting, AudioPlayMode.Background)
            Me.PictureBox3.Image = My.Resources.greencheck
            score = score + 50
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        My.Computer.Audio.Play(My.Resources.gunshot, AudioPlayMode.Background)
        Me.PictureBox4.Enabled = False
        If icons(4) = "1" Then
            Me.PictureBox4.Image = My.Resources.redx
            'My.Computer.Audio.Play(My.Resources.buzz, AudioPlayMode.Background)
            score = score - 100
        Else
            'My.Computer.Audio.Play(My.Resources.ting, AudioPlayMode.Background)
            Me.PictureBox4.Image = My.Resources.greencheck
            score = score + 50
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        My.Computer.Audio.Play(My.Resources.gunshot, AudioPlayMode.Background)
        Me.PictureBox5.Enabled = False
        If icons(5) = "1" Then
            Me.PictureBox5.Image = My.Resources.redx
            'My.Computer.Audio.Play(My.Resources.buzz, AudioPlayMode.Background)
            score = score - 100
        Else
            'My.Computer.Audio.Play(My.Resources.ting, AudioPlayMode.Background)
            Me.PictureBox5.Image = My.Resources.greencheck
            score = score + 50
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        My.Computer.Audio.Play(My.Resources.gunshot, AudioPlayMode.Background)
        Me.PictureBox6.Enabled = False
        If icons(6) = "1" Then
            Me.PictureBox6.Image = My.Resources.redx
            ' My.Computer.Audio.Play(My.Resources.buzz, AudioPlayMode.Background)
            score = score - 100
        Else
            'My.Computer.Audio.Play(My.Resources.ting, AudioPlayMode.Background)
            Me.PictureBox6.Image = My.Resources.greencheck
            score = score + 50
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        My.Computer.Audio.Play(My.Resources.gunshot, AudioPlayMode.Background)
        Me.PictureBox7.Enabled = False
        If icons(7) = "1" Then
            Me.PictureBox7.Image = My.Resources.redx
            'My.Computer.Audio.Play(My.Resources.buzz, AudioPlayMode.Background)
            score = score - 100
        Else
            'My.Computer.Audio.Play(My.Resources.ting, AudioPlayMode.Background)
            Me.PictureBox7.Image = My.Resources.greencheck
            score = score + 50
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        My.Computer.Audio.Play(My.Resources.gunshot, AudioPlayMode.Background)
        Me.PictureBox8.Enabled = False
        If icons(8) = "1" Then
            Me.PictureBox8.Image = My.Resources.redx
            'My.Computer.Audio.Play(My.Resources.buzz, AudioPlayMode.Background)
            score = score - 100
        Else
            'My.Computer.Audio.Play(My.Resources.ting, AudioPlayMode.Background)
            Me.PictureBox8.Image = My.Resources.greencheck
            score = score + 50
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        My.Computer.Audio.Play(My.Resources.gunshot, AudioPlayMode.Background)
        Me.PictureBox9.Enabled = False
        If icons(9) = "1" Then
            Me.PictureBox9.Image = My.Resources.redx
            'My.Computer.Audio.Play(My.Resources.buzz, AudioPlayMode.Background)
            score = score - 100
        Else
            'My.Computer.Audio.Play(My.Resources.ting, AudioPlayMode.Background)
            Me.PictureBox9.Image = My.Resources.greencheck
            score = score + 50
        End If
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        My.Computer.Audio.Play(My.Resources.gunshot, AudioPlayMode.Background)
        Me.PictureBox10.Enabled = False
        If icons(10) = "1" Then
            Me.PictureBox10.Image = My.Resources.redx
            'My.Computer.Audio.Play(My.Resources.buzz, AudioPlayMode.Background)
            score = score - 100
        Else
            'My.Computer.Audio.Play(My.Resources.ting, AudioPlayMode.Background)
            Me.PictureBox10.Image = My.Resources.greencheck
            score = score + 50
        End If
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        My.Computer.Audio.Play(My.Resources.gunshot, AudioPlayMode.Background)
        Me.PictureBox11.Enabled = False
        If icons(11) = "1" Then
            Me.PictureBox11.Image = My.Resources.redx
            'My.Computer.Audio.Play(My.Resources.buzz, AudioPlayMode.Background)
            score = score - 100
        Else
            'My.Computer.Audio.Play(My.Resources.ting, AudioPlayMode.Background)
            Me.PictureBox11.Image = My.Resources.greencheck
            score = score + 50
        End If
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        My.Computer.Audio.Play(My.Resources.gunshot, AudioPlayMode.Background)
        Me.PictureBox12.Enabled = False
        If icons(12) = "1" Then
            Me.PictureBox12.Image = My.Resources.redx
            'My.Computer.Audio.Play(My.Resources.buzz, AudioPlayMode.Background)
            score = score - 100
        Else
            'My.Computer.Audio.Play(My.Resources.ting, AudioPlayMode.Background)
            Me.PictureBox12.Image = My.Resources.greencheck
            score = score + 50
        End If
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        My.Computer.Audio.Play(My.Resources.gunshot, AudioPlayMode.Background)
        Me.PictureBox13.Enabled = False
        If icons(13) = "1" Then
            Me.PictureBox13.Image = My.Resources.redx
            'My.Computer.Audio.Play(My.Resources.buzz, AudioPlayMode.Background)
            score = score - 100
        Else
            'My.Computer.Audio.Play(My.Resources.ting, AudioPlayMode.Background)
            Me.PictureBox13.Image = My.Resources.greencheck
            score = score + 50
        End If
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        My.Computer.Audio.Play(My.Resources.gunshot, AudioPlayMode.Background)
        Me.PictureBox14.Enabled = False
        If icons(14) = "1" Then
            Me.PictureBox14.Image = My.Resources.redx
            'My.Computer.Audio.Play(My.Resources.buzz, AudioPlayMode.Background)
            score = score - 100
        Else
            'My.Computer.Audio.Play(My.Resources.ting, AudioPlayMode.Background)
            Me.PictureBox14.Image = My.Resources.greencheck
            score = score + 50
        End If
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        My.Computer.Audio.Play(My.Resources.gunshot, AudioPlayMode.Background)
        Me.PictureBox15.Enabled = False
        If icons(15) = "1" Then
            Me.PictureBox15.Image = My.Resources.redx
            'My.Computer.Audio.Play(My.Resources.buzz, AudioPlayMode.Background)
            score = score - 100
        Else
            'My.Computer.Audio.Play(My.Resources.ting, AudioPlayMode.Background)
            Me.PictureBox15.Image = My.Resources.greencheck
            score = score + 50
        End If
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        My.Computer.Audio.Play(My.Resources.gunshot, AudioPlayMode.Background)
        Me.PictureBox16.Enabled = False
        If icons(16) = "1" Then
            Me.PictureBox16.Image = My.Resources.redx
            'My.Computer.Audio.Play(My.Resources.buzz, AudioPlayMode.Background)
            score = score - 100
        Else
            'My.Computer.Audio.Play(My.Resources.ting, AudioPlayMode.Background)
            Me.PictureBox16.Image = My.Resources.greencheck
            score = score + 50
        End If
    End Sub

    'change the round number each round
    Private Sub GameScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblRound.Text = "Round " & roundNumber
    End Sub

    'timer gives 5 seconds to click on picture boxes
    'when timer is up, the picture boxes become invisible and the next form is called
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        y += 1
        If y = 5 Then
            Timer1.Stop()
            Me.Hide()
            MessBox.Show()
            Me.btnStart.Visible = True
            'reset variable used for number of seconds
            y = 0
            Me.PictureBox1.Visible = False
            Me.PictureBox2.Visible = False
            Me.PictureBox3.Visible = False
            Me.PictureBox4.Visible = False
            Me.PictureBox5.Visible = False
            Me.PictureBox6.Visible = False
            Me.PictureBox7.Visible = False
            Me.PictureBox8.Visible = False
            Me.PictureBox9.Visible = False
            Me.PictureBox10.Visible = False
            Me.PictureBox11.Visible = False
            Me.PictureBox12.Visible = False
            Me.PictureBox13.Visible = False
            Me.PictureBox14.Visible = False
            Me.PictureBox15.Visible = False
            Me.PictureBox16.Visible = False
        End If
    End Sub
End Class

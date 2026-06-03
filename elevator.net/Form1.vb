Imports System.Collections.Generic
Imports System.Threading.Tasks

Public Class Form1

    Private Enum LiftDirection
        Waiting
        Up
        Down
    End Enum

    Private activeLevel As Integer = 1
    Private destinationLevel As Integer = 1

    Private travelState As LiftDirection =
        LiftDirection.Waiting

    Private isTravelling As Boolean = False
    Private doorsOpened As Boolean = True

    Private requestQueue As New Queue(Of Integer)

    Private floorMap As New Dictionary(Of Integer, Integer)

    Private Sub Form1_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        floorMap.Add(1, 350)
        floorMap.Add(2, 245)
        floorMap.Add(3, 130)
        floorMap.Add(4, 12)

        panelLift.Top = floorMap(1)

        panelLeftDoor.Left = 0
        panelRightDoor.Left = panelLift.Width \ 2

        tmrLift.Interval = 15

        RefreshDisplay()

    End Sub

    Private Sub RefreshDisplay()

        lblCurrent.Text =
            "Floor: " & activeLevel

        lblState.Text =
            "Direction: " & travelState.ToString()

        lblDoorState.Text =
            "Door: " &
            If(doorsOpened, "OPEN", "CLOSED")

        lblPending.Text =
            "Queue: " &
            String.Join(", ", requestQueue)

    End Sub

    Private Sub RegisterFloor(level As Integer)

        If level = activeLevel Then Exit Sub

        If Not requestQueue.Contains(level) Then

            requestQueue.Enqueue(level)

        End If

        RefreshDisplay()

        If Not isTravelling Then

            MoveToNextDestination()

        End If

    End Sub

    Private Async Sub MoveToNextDestination()

        If requestQueue.Count = 0 Then

            isTravelling = False

            travelState =
                LiftDirection.Waiting

            RefreshDisplay()

            Exit Sub

        End If

        destinationLevel =
            requestQueue.Dequeue()

        If destinationLevel > activeLevel Then

            travelState = LiftDirection.Up

        Else

            travelState = LiftDirection.Down

        End If

        isTravelling = True

        Await AnimateDoor(False)

        tmrLift.Start()

        RefreshDisplay()

    End Sub

    Private Async Sub tmrLift_Tick(
        sender As Object,
        e As EventArgs
    ) Handles tmrLift.Tick

        Dim targetPosition As Integer =
            floorMap(destinationLevel)

        If panelLift.Top > targetPosition Then

            panelLift.Top -= 2

        ElseIf panelLift.Top < targetPosition Then

            panelLift.Top += 2

        End If

        If Math.Abs(
            panelLift.Top - targetPosition
        ) <= 2 Then

            panelLift.Top = targetPosition

            activeLevel =
                destinationLevel

            tmrLift.Stop()

            RefreshDisplay()

            Await AnimateDoor(True)

            Await Task.Delay(1000)

            Await AnimateDoor(False)

            MoveToNextDestination()

        End If

    End Sub

    Private Async Function AnimateDoor(
        opening As Boolean
    ) As Task

        Dim moveAmount As Integer = 2

        If opening Then

            While panelLeftDoor.Left >
                -panelLeftDoor.Width

                panelLeftDoor.Left -= moveAmount
                panelRightDoor.Left += moveAmount

                Await Task.Delay(10)

            End While

            doorsOpened = True

        Else

            While panelLeftDoor.Left < 0

                panelLeftDoor.Left += moveAmount
                panelRightDoor.Left -= moveAmount

                Await Task.Delay(10)

            End While

            panelLeftDoor.Left = 0
            panelRightDoor.Left =
                panelLift.Width \ 2

            doorsOpened = False

        End If

        RefreshDisplay()

    End Function

    Private Async Sub btnDoorOpen_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnDoorOpen.Click

        Await AnimateDoor(True)

    End Sub

    Private Async Sub btnDoorClose_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnDoorClose.Click

        Await AnimateDoor(False)

    End Sub

    Private Sub btnFloor1_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnFloor1.Click

        RegisterFloor(1)

    End Sub

    Private Sub btnFloor2_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnFloor2.Click

        RegisterFloor(2)

    End Sub

    Private Sub btnFloor3_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnFloor3.Click

        RegisterFloor(3)

    End Sub

    Private Sub btnFloor4_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnFloor4.Click

        RegisterFloor(4)

    End Sub

    Private Sub btnCallUp1_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCallUp1.Click

        RegisterFloor(1)

    End Sub

    Private Sub btnCallUp2_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCallUp2.Click

        RegisterFloor(2)

    End Sub

    Private Sub btnCallUp3_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCallUp3.Click

        RegisterFloor(3)

    End Sub

    Private Sub btnCallDown2_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCallDown2.Click

        RegisterFloor(2)

    End Sub

    Private Sub btnCallDown3_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCallDown3.Click

        RegisterFloor(3)

    End Sub

    Private Sub btnCallDown4_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCallDown4.Click

        RegisterFloor(4)

    End Sub

    Private Sub btnFloor1_Click_1(sender As Object, e As EventArgs) Handles btnFloor1.Click

    End Sub

    Private Sub lblState_Click(sender As Object, e As EventArgs) Handles lblState.Click

    End Sub
End Class
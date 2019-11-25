Imports System.IO
Imports System
Imports System.IO.Ports
Imports System.Runtime.InteropServices
Public Class Form1
    Dim WithEvents SerialPort As New IO.Ports.SerialPort
    Dim Readdata As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If lstPorts.SelectedIndex <> -1 Then
            Try
                If SerialPort.IsOpen Then
                    SerialPort.Close()
                    Button1.Text = "Connect"

                Else
                    SerialPort.PortName = lstPorts.SelectedItem.ToString
                    SerialPort.BaudRate = 9600
                    SerialPort.DataBits = 8
                    SerialPort.Parity = Parity.None
                    SerialPort.StopBits = StopBits.One
                    SerialPort.Handshake = Handshake.None
                    SerialPort.Encoding = System.Text.Encoding.Default
                    SerialPort.RtsEnable = True
                    SerialPort.Open()
                    Button1.Text = "Disconnect"
                    AddHandler SerialPort.DataReceived, AddressOf DataReceivedHandler
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Please choose a serial port", vbInformation, "Serial Port")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetSerialPortNames()
    End Sub

    Private Sub DataReceivedHandler(sender As Object, e As SerialDataReceivedEventArgs)

        Dim K As String = SerialPort.ReadLine()
        If (Asc(K) = 97) Then

            SendKeys.SendWait("{LEFT}")
            SendKeys.Flush()

        End If

        If (Asc(K) = 98) Then

            SendKeys.SendWait("{RIGHT}")
            SendKeys.Flush()

        End If
        K = ""
        SerialPort.DiscardInBuffer()

    End Sub
    Sub GetSerialPortNames()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            lstPorts.Items.Add(sp)
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub
End Class

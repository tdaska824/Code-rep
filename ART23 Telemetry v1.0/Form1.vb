Imports System.Globalization
Imports System.Windows.Forms.DataVisualization.Charting

'DIMITRIS TSOMPANIDIS-ART23'
Public Class Form1
    Private WithEvents Timer1 As New Timer()
    Private WithEvents Timer2 As New Timer()
    Dim StrSerialIn, StrSerialInRam, StrSerialInRam1, StrSerialInRam2 As String
    Dim k As Integer
    Dim titles As New ArrayList
    Dim titles1 As New ArrayList
    Dim values As New ArrayList
    Dim values1 As New ArrayList
    Dim multipliers As New ArrayList
    Dim multipliers1 As New ArrayList
    Dim inparraytemp As New ArrayList
    Dim InpArray() As String
    Dim InpArray1() As String
    Dim InpLabelArray() As String
    Dim received As Boolean = False
    Dim received1 As Boolean = False
    Dim connected As Boolean = False
    Dim messagesent As Boolean = False
    Dim messagesent1 As Boolean = False
    Dim ECU_TURNED_OFF As Boolean = False
    Dim durationInSeconds As Integer = 5
    Dim l As Integer = 0
    Dim startTime As DateTime
    Dim waiting = False
    Dim TB As New TextBox
    Dim RPM, ENGINE_TEMP, OIL_TEMP,
        OIL_PRESS, BATTERY, TPS, MAP, INTAKE_TEMP, FUEL_PRESS, LAMBDA, GEAR, SPEED,
        BRAKE_TEMP, FL_TYRE_TEMP, FR_TYRE_TEMP, RL_TYRE_TEMP, RR_TYRE_TEMP, ENGINE_MAP,
        LAUNCH, LAUNCHRAM, FUEL_USED, SIGNAL_STRENGTH, CHASSIS_TEMP, TIME, FUEL_USED_SHOWN, FUEL_USED_TEMP As Double
    Dim InnerFLIR, CenterFLIR, OuterFLIR, InnerFRIR, CenterFRIR, OuterFRIR, InnerRRIR, CenterRRIR, OuterRRIR, InnerRLIR, CenterRLIR, OuterRLIR As Double



    Dim ChartLimit As Integer = 200
    Dim RpmColorGValue, EngineTempRValue, OilTempRValue As Integer
    Dim culture As New CultureInfo("en-US")
    Dim isMessageBoxShown As Boolean = False ' A flag to track if the message box has been shown
    Dim message1, message2, message3 As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        ConnectionButton.Enabled = False
        ComboBoxBaudRate.SelectedIndex = 5
        LaunchComboBox.SelectedIndex = 0
        CarControlComboBox.SelectedIndex = 0
        TimerComboBox.SelectedIndex = 13
        EngineMapButtonA.Enabled = False
        EngineMapButtonB.Enabled = False
        LaunchComboBox.Enabled = False
        Page1Button.Enabled = False
        CarControlComboBox.Enabled = False
        RpmProgress.Value = 0
        SpeedProgress.Value = 0
        EngineTempProgress.Value = 0
        OilTempProgress.Value = 0
        ChartPanel1.BringToFront()
        ChartPanel2.SendToBack()
        ChartButtonsPanel.BringToFront()
        TyreTempPanel.BringToFront()
        TyreTempDetailPanel.SendToBack()
        Form2.SerialDataLabel.Text = ""
        Form2.Width = 184
        LAUNCHRAM = 0
        culture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture = culture
        System.Threading.Thread.CurrentThread.CurrentUICulture = culture

        Timer2.Interval = 3000
        Timer2.Start()

        For i = 0 To ChartLimit Step 1
            MAPTPSChart.Series("MAP").Points.AddY(0)
            MAPTPSChart.Series("TPS").Points.AddY(0)
            FuelPressChart.Series("FuelPressure").Points.AddY(0)
            FuelPressChart.Series("Battery").Points.AddY(0)
            LambdaChart.Series("Lambda").Points.AddY(0)
            RpmOilPressChart.Series("RPM").Points.AddY(0)
            RpmOilPressChart.Series("OilPress").Points.AddY(0)
            If MAPTPSChart.Series(0).Points.Count = ChartLimit Then
                MAPTPSChart.Series(0).Points.RemoveAt(0)
            End If
            If MAPTPSChart.Series(1).Points.Count = ChartLimit Then
                MAPTPSChart.Series(1).Points.RemoveAt(0)
            End If
            If FuelPressChart.Series(0).Points.Count = ChartLimit Then
                FuelPressChart.Series(0).Points.RemoveAt(0)
            End If
            If FuelPressChart.Series(1).Points.Count = ChartLimit Then
                FuelPressChart.Series(1).Points.RemoveAt(0)
            End If
            If LambdaChart.Series(0).Points.Count = ChartLimit Then
                LambdaChart.Series(0).Points.RemoveAt(0)
            End If
            If RpmOilPressChart.Series(0).Points.Count = ChartLimit Then
                RpmOilPressChart.Series(0).Points.RemoveAt(0)
            End If
            If RpmOilPressChart.Series(1).Points.Count = ChartLimit Then
                RpmOilPressChart.Series(1).Points.RemoveAt(0)
            End If
        Next
        MAPTPSChart.ChartAreas(0).AxisY.Maximum = 120
        MAPTPSChart.ChartAreas(0).AxisY.Minimum = 0
        MAPTPSChart.ChartAreas(0).AxisY2.Maximum = 100
        MAPTPSChart.ChartAreas(0).AxisY2.Minimum = 0
        FuelPressChart.ChartAreas(0).AxisY.Maximum = 450
        FuelPressChart.ChartAreas(0).AxisY.Minimum = 0
        FuelPressChart.ChartAreas(0).AxisY2.Maximum = 20
        FuelPressChart.ChartAreas(0).AxisY2.Minimum = 0
        LambdaChart.ChartAreas(0).AxisY.Maximum = 1.7
        LambdaChart.ChartAreas(0).AxisY.Minimum = 0
        RpmOilPressChart.ChartAreas(0).AxisY.Maximum = 14500
        RpmOilPressChart.ChartAreas(0).AxisY.Minimum = 0
        RpmOilPressChart.ChartAreas(0).AxisY2.Maximum = 700
        RpmOilPressChart.ChartAreas(0).AxisY2.Minimum = 0
        MAPTPSChart.ChartAreas("ChartArea1").AxisX.LabelStyle.Enabled = False
        FuelPressChart.ChartAreas("ChartArea1").AxisX.LabelStyle.Enabled = False
        LambdaChart.ChartAreas("ChartArea1").AxisX.LabelStyle.Enabled = False
        RpmOilPressChart.ChartAreas("ChartArea1").AxisX.LabelStyle.Enabled = False
        Label5.Text = ""
        Label6.Text = ""
        Label7.Text = ""

    End Sub




    Private Sub TimerComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TimerComboBox.SelectedIndexChanged
        TimerSerial.Interval = TimerComboBox.SelectedItem
    End Sub

    Private Sub TimerSerial_Tick(sender As Object, e As EventArgs) Handles TimerSerial.Tick

        If SerialPort1.IsOpen Then
            Try
                'values.Clear()
                'values1.Clear()
                'inparraytemp.Clear()


                'Label2.Text = StrSerialInRam
                'Label3.Text = StrSerialInRam1

                If received = True And received1 = True Then
                    messagesent = False
                    messagesent1 = False
                    StrSerialIn = ""
                    SerialPort1.Write("k")
                    'send j every 5 seconds
                    'Timer1.Interval = 5000 ' 5 seconds
                    'Timer1.Enabled = True
                    Dim eventArgs As New EventArgs()
                    Timer2_Tick(Me, eventArgs)


                    StrSerialIn = SerialPort1.ReadExisting
                    'System.Threading.Thread.Sleep(100)
                    InpArray = Split(StrSerialIn, ",")
                    'store data of first package'

                    For l = 0 To InpArray.Length - 1 Step 1
                        If InpArray(l) = "~" Then

                            inparraytemp.Clear()
                            Dim p As Integer = -1
                            Do
                                p = p + 1
                                inparraytemp.Add(InpArray(l + p))


                            Loop While InpArray(l + p) <> "`"
                            messagesent = True
                            Exit For

                        End If
                    Next
                    If messagesent = True Then
                        If inparraytemp(0) = "~" And inparraytemp(inparraytemp.Count - 1) = "`" Then
                            StrSerialInRam2 = ""
                            'values.Clear()
                            Dim i As Integer = 0
                            While i < inparraytemp.Count

                                Dim temp As Integer
                                Integer.TryParse(inparraytemp(i), temp)
                                values(i) = temp
                                StrSerialInRam2 = StrSerialInRam2 + CStr(values(i)) + vbCrLf
                                i = i + 1

                            End While

                        End If
                    End If
                    'store data of second package
                    Dim r As Integer
                    For r = 0 To InpArray.Length - 1 Step 1
                        If InpArray(r) = "$" Then

                            inparraytemp.Clear()
                            Dim p As Integer = -1
                            Do
                                p = p + 1
                                inparraytemp.Add(InpArray(r + p))
                                If InpArray(r + p) = "`" & vbNullChar & "0" Or InpArray(r + p) = "`" Then
                                    Exit For
                                End If
                            Loop While InpArray(r + p) <> "#"
                            messagesent1 = True
                            Exit For


                        End If
                    Next
                    If messagesent1 = True Then
                        If inparraytemp(0) = "$" And inparraytemp(inparraytemp.Count - 1) = "#" Then
                            StrSerialInRam2 = ""
                            Dim j As Integer = 0
                            'values1.Clear()
                            While j < inparraytemp.Count

                                Dim temp As Integer = 0
                                Integer.TryParse(inparraytemp(j), temp)
                                values1(j) = temp
                                StrSerialInRam2 = StrSerialInRam2 + CStr(values1(j)) + vbCrLf
                                j = j + 1

                            End While
                        Else

                        End If
                    End If

                End If

                Dim cnt As Integer
                Dim cnt1 As Integer
                Dim tempstr As String = ""
                Dim tempstr1 As String = ""
                ' If messagesent = True Then
                For cnt = 1 To titles.Count - 2 Step 1
                    tempstr = tempstr + CStr(titles(cnt)) + ": " + CStr(values(cnt) / multipliers(cnt)) + vbCrLf
                Next
                'End If
                'If messagesent1 = True Then
                For cnt1 = 1 To titles1.Count - 2 Step 1
                    tempstr1 = tempstr1 + CStr(titles1(cnt1)) + ": " + CStr(values1(cnt1) / multipliers1(cnt1)) + vbCrLf
                Next
                'End If



                Form2.SerialDataLabel.Text = tempstr + tempstr1
                If messagesent = True Then
                    ValueOfTitle(titles, values, multipliers, RPM, "RPM")
                    ValueOfTitle(titles, values, multipliers, OIL_PRESS, "OilPress")
                    ValueOfTitle(titles, values, multipliers, BATTERY, "Batt")
                    ValueOfTitle(titles, values, multipliers, TPS, "TPS")
                    ValueOfTitle(titles, values, multipliers, MAP, "MAP")
                    ValueOfTitle(titles, values, multipliers, FUEL_PRESS, "Fuel Press")
                    ValueOfTitle(titles, values, multipliers, LAMBDA, "Lambda")
                    ValueOfTitle(titles, values, multipliers, GEAR, "Gear")
                    ValueOfTitle(titles, values, multipliers, SPEED, "Speed")
                    ValueOfTitle(titles, values, multipliers, TIME, "Time")
                End If
                If messagesent1 = True Then
                    ValueOfTitle(titles1, values1, multipliers1, INTAKE_TEMP, "AirTemp")
                    ValueOfTitle(titles1, values1, multipliers1, BRAKE_TEMP, "BrakeTemp")
                    ValueOfTitle(titles1, values1, multipliers1, FL_TYRE_TEMP, "FLTemp")
                    ValueOfTitle(titles1, values1, multipliers1, FR_TYRE_TEMP, "FRTemp")
                    ValueOfTitle(titles1, values1, multipliers1, RL_TYRE_TEMP, "RLTemp")
                    ValueOfTitle(titles1, values1, multipliers1, RR_TYRE_TEMP, "RRTemp")
                    ValueOfTitle(titles1, values1, multipliers1, LAUNCH, "Launch")
                    ValueOfTitle(titles1, values1, multipliers1, ENGINE_MAP, "EngineMap")
                    ValueOfTitle(titles1, values1, multipliers1, CHASSIS_TEMP, "ChassisTemp")
                    ValueOfTitle(titles1, values1, multipliers1, ENGINE_TEMP, "EngineTemp")
                    ValueOfTitle(titles1, values1, multipliers1, OIL_TEMP, "OilTemp")
                    ValueOfTitle(titles1, values1, multipliers1, FUEL_USED, "FuelUsed")
                    ValueOfTitle(titles1, values1, multipliers1, InnerFLIR, "InnerFLIR")
                    ValueOfTitle(titles1, values1, multipliers1, CenterFLIR, "CenterFLIR")
                    ValueOfTitle(titles1, values1, multipliers1, OuterFLIR, "OuterFLIR")
                    ValueOfTitle(titles1, values1, multipliers1, InnerFRIR, "InnerFRIR")
                    ValueOfTitle(titles1, values1, multipliers1, CenterFRIR, "CenterFRIR")
                    ValueOfTitle(titles1, values1, multipliers1, OuterFRIR, "OuterFRIR")
                    ValueOfTitle(titles1, values1, multipliers1, InnerRRIR, "InnerRRIR")
                    ValueOfTitle(titles1, values1, multipliers1, CenterRRIR, "CenterRRIR")
                    ValueOfTitle(titles1, values1, multipliers1, OuterRRIR, "OuterRRIR")
                    ValueOfTitle(titles1, values1, multipliers1, InnerRLIR, "InnerRLIR")
                    ValueOfTitle(titles1, values1, multipliers1, CenterRLIR, "CenterRLIR")
                    ValueOfTitle(titles1, values1, multipliers1, OuterRLIR, "OuterRLIR")


                End If






            Catch ex As Exception
                'Dim errorMsg As String = "Error communicating with the Arduino." & ex.Message & vbCrLf & "At line: " & (New System.Diagnostics.StackTrace()).GetFrame(0).GetFileLineNumber()
                'MessageBox.Show(errorMsg)
                'MessageBox.Show("Error communicating with the Arduino: " & ex.Message)
                'MsgBox("error")

            End Try



        Else
            PictureBoxConnectionStatus.BackColor = Color.Tomato
            If isMessageBoxShown = False Then
                isMessageBoxShown = True ' Set the flag to true, so the message box won't be shown again
                MessageBox.Show("Check the USB connection.")

            End If

            Try
                SerialPort1.Close()
                SerialPort1.Open()
                isMessageBoxShown = False
                SendKeys.Send("{ENTER}")
                PictureBoxConnectionStatus.BackColor = Color.LightGreen
            Catch ex As Exception
                'MessageBox.Show("Error opening the serial port: " & ex.Message)
            End Try

        End If
        '----------------------------------------------------------------------------------'


        Form2.Height = Form2.SerialDataLabel.Height + 40
        'Form2.Width = Form2.SerialDataLabel.Width + 40
        RpmProgress.Text = CStr(RPM)
        RpmChartLabel.Text = "RPM:" + CStr(RPM)

        Try
            RpmProgress.Value = CMap(RPM, 0, 14500, 0, 52)
        Catch ex As Exception

        End Try

        If SPEED < 100 Then
            SpeedProgress.Font = New Font("Consolas", 17, FontStyle.Regular)
        Else
            SpeedProgress.Font = New Font("Consolas", 15.5, FontStyle.Regular)
        End If
        SpeedProgress.Text = CStr(SPEED) + "km/h"
        If CHASSIS_TEMP > 60 Then
            ChassisTempLabel.ForeColor = System.Drawing.Color.Red
            BrakeDiscPictureBox.BackColor = System.Drawing.Color.Red
            ChassisTempValueLabel.ForeColor = System.Drawing.Color.Red
        End If

        If ENGINE_TEMP > 95 Then
            EngineTempLabel.ForeColor = System.Drawing.Color.Red
        End If
        If OIL_PRESS < 220 Then
            Label1.ForeColor = System.Drawing.Color.Red
            Manometer.BackColor = System.Drawing.Color.Red
            OilPressLabel.ForeColor = System.Drawing.Color.Red
        End If





        EngineTempProgress.Text = CStr(ENGINE_TEMP) + "oC"

        OilTempProgress.Text = CStr(OIL_TEMP) + "oC"
        OilPressLabel.Text = CStr(OIL_PRESS) + "kPa"
        OilPressChartLabel.Text = "Oil Pressure:" + CStr(OIL_PRESS) + "kPa"
        FL_TYRE_TEMP = (InnerFLIR + CenterFLIR + OuterFLIR) / 3
        FR_TYRE_TEMP = (InnerFRIR + CenterFRIR + OuterFRIR) / 3
        RL_TYRE_TEMP = (InnerRLIR + CenterRLIR + OuterRLIR) / 3
        RR_TYRE_TEMP = (InnerRRIR + CenterRRIR + OuterRRIR) / 3
        FLTempLabel.Text = FL_TYRE_TEMP.ToString("F0") + "oC"
        FRTempLabel.Text = FR_TYRE_TEMP.ToString("F0") + "oC"
        RLTempLabel.Text = RL_TYRE_TEMP.ToString("F0") + "oC"
        RRTempLabel.Text = RR_TYRE_TEMP.ToString("F0") + "oC"
        FLOuterLabel.Text = CStr(OuterFLIR) + "oC"
        FLMiddleLabel.Text = CStr(CenterFLIR) + "oC"
        FLInnerLabel.Text = CStr(InnerFLIR) + "oC"
        FROuterLabel.Text = CStr(OuterFRIR) + "oC"
        FRMiddleLabel.Text = CStr(CenterFRIR) + "oC"
        FRInnerLabel.Text = CStr(InnerFRIR) + "oC"
        RROuterLabel.Text = CStr(OuterRRIR) + "oC"
        RRMiddleLabel.Text = CStr(CenterRRIR) + "oC"
        RRInnerLabel.Text = CStr(InnerRRIR) + "oC"
        RLOuterLabel.Text = CStr(OuterRLIR) + "oC"
        RLMiddleLabel.Text = CStr(CenterRLIR) + "oC"
        RLInnerLabel.Text = CStr(InnerRLIR) + "oC"
        GearValueLabel.Text = GEAR
        ChassisTempValueLabel.Text = CStr(CHASSIS_TEMP) + "oC"
        MAPLabel.Text = "MAP:" + CStr(MAP) + "kPa"
        TPSLabel.Text = "TPS:" + CStr(TPS) + "%"
        FuelPressLabel.Text = "Fuel Pressure:" + CStr(FUEL_PRESS) + "kPa"
        BatteryLabel.Text = "Battery:" + CStr(BATTERY) + "V"
        LambdaLabel.Text = "Lambda:" + CStr(LAMBDA)
        'If (FUEL_USED < FUEL_USED_SHOWN And ECU_TURNED_OFF = True) Then
        '    ECU_TURNED_OFF = False
        '    FUEL_USED_TEMP = FUEL_USED_SHOWN
        'End If

        'If (ECU_TURNED_OFF = True) Then
        '    FUEL_USED_SHOWN = FUEL_USED_TEMP + FUEL_USED
        'End If


        FuelValueLabel.Text = CStr(FUEL_USED) + "ml"
        AirTempValueLabel.Text = CStr(INTAKE_TEMP) + "oC"
        SignalStrengthValueLabel.Text = SIGNAL_STRENGTH
        TimeLabel.Text = "Time: " + CStr(TIME)

        Try
            RpmColorGValue = CMap(RPM, 0, 19000, 255, 0)
            RpmProgress.ProgressColor = Color.FromArgb(235, RpmColorGValue, 50)
            EngineTempRValue = CMap(ENGINE_TEMP, 0, 140, 0, 255)
            EngineTempProgress.ProgressColor = Color.FromArgb(EngineTempRValue, 255 - EngineTempRValue, 255 - EngineTempRValue)
            OilTempRValue = CMap(OIL_TEMP, 0, 140, 0, 255)
            OilTempProgress.ProgressColor = Color.FromArgb(EngineTempRValue, 255 - OilTempRValue, 255 - OilTempRValue)
            EngineTempProgress.Value = CMap(ENGINE_TEMP, 0, 150, 0, 50)
            OilTempProgress.Value = CMap(OIL_TEMP, 0, 150, 0, 50)
            SpeedProgress.Value = CMap(SPEED, 0, 151, 0, 50)
        Catch ex As Exception

        End Try

        MAPTPSChart.Series("MAP").Points.AddY(MAP)
        If MAPTPSChart.Series(0).Points.Count = ChartLimit Then
            MAPTPSChart.Series(0).Points.RemoveAt(0)
        End If

        MAPTPSChart.Series("TPS").Points.AddY(TPS)
        If MAPTPSChart.Series(1).Points.Count = ChartLimit Then
            MAPTPSChart.Series(1).Points.RemoveAt(0)
        End If

        FuelPressChart.Series("FuelPressure").Points.AddY(FUEL_PRESS)
        If FuelPressChart.Series(0).Points.Count = ChartLimit Then
            FuelPressChart.Series(0).Points.RemoveAt(0)
        End If

        FuelPressChart.Series("Battery").Points.AddY(BATTERY)
        If FuelPressChart.Series(1).Points.Count = ChartLimit Then
            FuelPressChart.Series(1).Points.RemoveAt(0)
        End If

        LambdaChart.Series("Lambda").Points.AddY(LAMBDA)
        If LambdaChart.Series(0).Points.Count = ChartLimit Then
            LambdaChart.Series(0).Points.RemoveAt(0)
        End If
        RpmOilPressChart.Series("RPM").Points.AddY(RPM)
        If RpmOilPressChart.Series(0).Points.Count = ChartLimit Then
            RpmOilPressChart.Series(0).Points.RemoveAt(0)
        End If

        RpmOilPressChart.Series("OilPress").Points.AddY(OIL_PRESS)
        If RpmOilPressChart.Series(1).Points.Count = ChartLimit Then
            RpmOilPressChart.Series(1).Points.RemoveAt(0)
        End If
        ''----------------------------------------------------------------------------------'

        If (LAUNCHRAM <> LAUNCH) Then
            LaunchComboBox.SelectedIndex = LAUNCH
            LAUNCHRAM = LAUNCH
        End If

        If ENGINE_MAP = 0 Then
            EngineMapButtonA.BackColor = Color.GreenYellow
            EngineMapButtonB.BackColor = Color.Gainsboro
        Else
            EngineMapButtonA.BackColor = Color.Gainsboro

        End If

        If ENGINE_MAP = 1 Then
            EngineMapButtonA.BackColor = Color.Gainsboro
            EngineMapButtonB.BackColor = Color.GreenYellow
        Else
            EngineMapButtonB.BackColor = Color.Gainsboro
        End If

        If LAUNCH = LaunchComboBox.SelectedIndex Then
            LaunchComboBox.BackColor = Color.GreenYellow
        Else
            LaunchComboBox.BackColor = Color.Gainsboro

        End If

        If Form2.Visible Then
            ShowSerialDataButton.SendToBack()
            HideSerialDataButton.BringToFront()

        Else
            HideSerialDataButton.SendToBack()
            ShowSerialDataButton.BringToFront()

        End If

    End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    ' Write "j" to the serial port every tick (5 seconds)
    '    If SerialPort1.IsOpen Then
    '        SerialPort1.Write("j")
    '    Else
    '        MessageBox.Show("Serial port is not open.")
    '    End If
    'End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Dim l As Integer
        For l = 0 To 5 Step 1
            If SerialPort1.IsOpen() Then
                SerialPort1.Write("n")
            End If
        Next


    End Sub

    Private Sub BrakeTempLabel_Click(sender As Object, e As EventArgs) Handles ChassisTempLabel.Click

    End Sub

    Private Sub HideSerialDataButton_Click(sender As Object, e As EventArgs) Handles HideSerialDataButton.Click
        Form2.Hide()
        HideSerialDataButton.SendToBack()
        ShowSerialDataButton.BringToFront()
    End Sub

    Private Sub ShowSerialDataButton_Click(sender As Object, e As EventArgs) Handles ShowSerialDataButton.Click
        Form2.Show()
        ShowSerialDataButton.SendToBack()
        HideSerialDataButton.BringToFront()
    End Sub

    Private Sub Page1Button_Click(sender As Object, e As EventArgs) Handles Page1Button.Click
        ChartPanel1.BringToFront()
        ChartPanel2.SendToBack()
        Page1Button.Enabled = 0
        Page2Button.Enabled = 1
        ChartButtonsPanel.BringToFront()
    End Sub

    Private Sub Page2Button_Click(sender As Object, e As EventArgs) Handles Page2Button.Click
        ChartPanel2.BringToFront()
        ChartPanel1.SendToBack()
        Page1Button.Enabled = 1
        Page2Button.Enabled = 0
        ChartButtonsPanel.BringToFront()
    End Sub

    Private Sub LaunchComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LaunchComboBox.SelectionChangeCommitted
        CarControlPanel.Focus()
        If CarControlComboBox.SelectedIndex = 1 Then

            Try
                SerialPort1.Write(LaunchComboBox.SelectedIndex)
            Catch ex As Exception

            End Try

        End If


    End Sub

    Private Sub LaunchComboBox_DropDown(sender As Object, e As EventArgs) Handles LaunchComboBox.DropDown
        CarControlPanel.Focus()
    End Sub

    Private Sub CarControlComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CarControlComboBox.SelectedIndexChanged
        CarControlPanel.Focus()
        If CarControlComboBox.SelectedIndex = 0 Then
            CarControlComboBox.BackColor = Color.OrangeRed
            EngineMapButtonA.Enabled = 0
            EngineMapButtonB.Enabled = 0
            LaunchComboBox.Enabled = 0
        Else
            CarControlComboBox.BackColor = Color.LimeGreen
            EngineMapButtonA.Enabled = 1
            EngineMapButtonB.Enabled = 1
            LaunchComboBox.Enabled = 1

        End If
    End Sub

    Private Sub CarControlComboBox_DropDown(sender As Object, e As EventArgs) Handles CarControlComboBox.DropDown
        CarControlPanel.Focus()
    End Sub

    Private Sub ScanButton_Click(sender As Object, e As EventArgs) Handles ScanButton.Click
        ConnectionPanel.Focus()
        If LabelStatus.Text = "Status : Connected" Then
            MsgBox("Conncetion in progress, please Disconnect to scan the new port.", MsgBoxStyle.Critical, "Warning !!!")
            Return
        End If

        ComboBoxPort.Items.Clear()
        Dim myPort As Array
        Dim i As Integer
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBoxPort.Items.AddRange(myPort)
        i = ComboBoxPort.Items.Count
        i = i - 1

        Try
            ComboBoxPort.SelectedIndex = i
            ConnectionButton.Enabled = True

        Catch ex As Exception
            MsgBox("Com port not detected", MsgBoxStyle.Critical, "Warning !!!")
            ComboBoxPort.Text = ""
            ComboBoxPort.Items.Clear()
            Return
        End Try
        ComboBoxPort.DroppedDown = True
    End Sub

    Private Sub TyreTempButton_Click(sender As Object, e As EventArgs) Handles TyreTempButton.Click
        TyreTempPanel.Focus()
        TyreTempPanel.SendToBack()
        TyreTempDetailPanel.BringToFront()
    End Sub

    Private Sub TyreTempBackButton_Click(sender As Object, e As EventArgs) Handles TyreTempBackButton.Click
        TyreTempDetailPanel.Focus()
        TyreTempDetailPanel.SendToBack()
        TyreTempPanel.BringToFront()
    End Sub

    Private Sub EngineMapButtonA_Click(sender As Object, e As EventArgs) Handles EngineMapButtonA.Click
        CarControlPanel.Focus()

        If CarControlComboBox.SelectedIndex = 1 Then

            If ENGINE_MAP <> 0 Then

                Do
                    Try
                        SerialPort1.Write("A")
                    Catch ex As Exception

                    End Try
                Loop While ENGINE_MAP = 0

            End If

        End If


    End Sub

    Private Sub EngineMapButtonB_Click(sender As Object, e As EventArgs) Handles EngineMapButtonB.Click
        CarControlPanel.Focus()
        If CarControlComboBox.SelectedIndex = 1 Then
            If ENGINE_MAP <> 1 Then
                Do
                    Try
                        SerialPort1.Write("B")
                    Catch ex As Exception

                    End Try
                Loop While ENGINE_MAP = 1
            End If


        End If


    End Sub

    Private Sub ComboBoxPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPort.SelectedIndexChanged
        ConnectionPanel.Focus()
    End Sub


    Private Sub ComboBoxPort_DropDown(sender As Object, e As EventArgs) Handles ComboBoxPort.DropDown
        ConnectionPanel.Focus()
    End Sub


    Private Sub ComboBoxPort_Click(sender As Object, e As EventArgs) Handles ComboBoxPort.Click
        If LabelStatus.Text = "Status : Connected" Then
            MsgBox("Connection in progress, please Disconnect to change COM.", MsgBoxStyle.Critical, "Warning !!!")
            Return
        End If
    End Sub


    Private Sub ComboBoxBaudRate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxBaudRate.SelectedIndexChanged
        ConnectionPanel.Focus()
    End Sub


    Private Sub ComboBoxBaudRate_DropDown(sender As Object, e As EventArgs) Handles ComboBoxBaudRate.DropDown
        ConnectionPanel.Focus()
    End Sub



    Private Sub ComboBoxBaudRate_Click(sender As Object, e As EventArgs) Handles ComboBoxBaudRate.Click
        If LabelStatus.Text = "Status : Connected" Then
            MsgBox("Conncetion in progress, please Disconnect to change Baud Rate.", MsgBoxStyle.Critical, "Warning !!!")
            Return
        End If
    End Sub

    Private Sub RefuelButton_Click(sender As Object, e As EventArgs) Handles RefuelButton.Click

        FUEL_USED_SHOWN = 0
        FUEL_USED_TEMP = 0
        ECU_TURNED_OFF = False
    End Sub



    Private Sub ConnectionButton_Click(sender As Object, e As EventArgs) Handles ConnectionButton.Click
        ConnectionPanel.Focus()

        Try
            SerialPort1.BaudRate = ComboBoxBaudRate.SelectedItem
            SerialPort1.PortName = ComboBoxPort.SelectedItem
            SerialPort1.Open()
            TimerSerial.Start()
            LabelStatus.Text = "Status : Connected"
            ConnectionButton.SendToBack()
            DisconnectButton.BringToFront()
            PictureBoxConnectionStatus.BackColor = Color.LightGreen
            ScanButton.Enabled = 0
            ComboBoxPort.Enabled = 0
            ComboBoxBaudRate.Enabled = 0
            startTime = DateTime.Now
            While received = False Or received1 = False And (DateTime.Now - startTime).TotalSeconds < durationInSeconds
                'ask for titles of first package'
                If received = False Then
                    SerialPort1.Write("l")
                    System.Threading.Thread.Sleep(300)
                    StrSerialIn = SerialPort1.ReadExisting
                    InpLabelArray = Split(StrSerialIn, ",")
                    If InpLabelArray(0) = "~" And InpLabelArray.Last = "`" And CountStringOccurrences(InpLabelArray, "Time/1000") = 1 Then
                        titles.Clear()
                        multipliers.Clear()
                        Dim i As Integer
                        i = 0
                        While i < InpLabelArray.Length
                            titles.Add(ExtractString(InpLabelArray(i)))
                            Dim temp As Integer
                            Integer.TryParse(ExtractMultiplierFromString(InpLabelArray(i)), temp)
                            multipliers.Add(temp)
                            values.Add(0)
                            i = i + 1

                        End While
                        If titles(1) = "Time" Then
                            received = True
                            'SerialPort1.Write("k")
                        End If
                    End If
                End If
                'ask for titles of second package'
                If received1 = False Then
                    SerialPort1.Write("m")
                    System.Threading.Thread.Sleep(300)
                    StrSerialIn = SerialPort1.ReadExisting
                    InpLabelArray = Split(StrSerialIn, ",")
                    If InpLabelArray(0) = "$" And InpLabelArray.Last = "#" And CountStringOccurrences(InpLabelArray, "Time/1000") = 1 Then
                        titles1.Clear()
                        multipliers1.Clear()
                        Dim j As Integer
                        j = 0
                        While j < InpLabelArray.Length
                            titles1.Add(ExtractString(InpLabelArray(j)))
                            Dim temp As Integer
                            Integer.TryParse(ExtractMultiplierFromString(InpLabelArray(j)), temp)
                            multipliers1.Add(temp)
                            values1.Add(0)
                            j = j + 1

                        End While
                        If titles1(1) = "Time" Then
                            received1 = True
                            'SerialPort1.Write("k")
                        End If


                    End If
                End If

                System.Threading.Thread.Sleep(100) ' Sleep for 100 milliseconds
            End While


        Catch ex As Exception
            MsgBox("Please check the Hardware, COM, Baud Rate and try again.", MsgBoxStyle.Critical, "Connection failed !!!")
        End Try
    End Sub


    Private Sub DisconnectButton_Click(sender As Object, e As EventArgs) Handles DisconnectButton.Click
        ConnectionPanel.Focus()
        TimerSerial.Stop()
        SerialPort1.Close()
        DisconnectButton.SendToBack()
        ConnectionButton.BringToFront()
        LabelStatus.Text = "Status : Disconnected"
        PictureBoxConnectionStatus.BackColor = Color.Tomato
        ScanButton.Enabled = 1
        ComboBoxPort.Enabled = 1
        ComboBoxBaudRate.Enabled = 1
        received = False
        received1 = False
    End Sub


    Function ExtractMultiplierFromString(inputString As String) As Double
        ' Find the position of the colon in the input string
        Dim parts() As String = inputString.Split("/"c)
        Dim extractedNumber As Double

        If parts.Length > 1 Then
            If Double.TryParse(parts(1), extractedNumber) Then
                ' Return the parsed numerical value
                Return extractedNumber
            End If
        End If

        ' Return NaN (Not-a-Number) if the extraction or parsing fails
        Return 1
    End Function

    Function ExtractString(inputString As String) As String
        Dim parts() As String = inputString.Split("/"c)
        If parts.Length > 1 Then
            Return parts(0)
        Else
            Return inputString
        End If
    End Function

    Public Function CMap(ByVal value As Double, ByVal fromLow As Double, ByVal fromHigh As Double,
                    ByVal toLow As Double, ByVal toHigh As Double) As Double
        ' Map the value from the input range to the output range.
        Return (value - fromLow) * (toHigh - toLow) / (fromHigh - fromLow) + toLow
    End Function


    Private Sub ChangePictureBoxHeight(ByVal pictureBox As PictureBox, ByVal newHeight As Integer)
        ' Calculate the difference between the new height and the current height
        Dim heightDifference As Integer = newHeight - pictureBox.Height

        ' Adjust the Top property to keep the Bottom edge stable
        pictureBox.Top -= heightDifference

        ' Set the new height
        pictureBox.Height = newHeight
    End Sub

    Function FindObjectIndex(list As ArrayList, searchObject As Object) As Integer
        If list IsNot Nothing AndAlso list.Contains(searchObject) Then
            Return list.IndexOf(searchObject)
        Else
            Return -1 ' Object not found or list is null/empty
        End If
    End Function

    Function ValueOfTitle(titles As ArrayList, values As ArrayList, multipliers As ArrayList, ByRef Variable As Object, Title As Object)
        Dim ind As Integer = FindObjectIndex(titles, Title)
        If ind >= 0 Then
            Variable = values(ind) / multipliers(ind)
        End If
    End Function

    Function CountStringOccurrences(arr() As String, target As String) As Integer
        Dim count As Integer = 0

        For Each str As String In arr
            If str.Equals(target) Then
                count += 1
            End If
        Next

        Return count
    End Function




End Class


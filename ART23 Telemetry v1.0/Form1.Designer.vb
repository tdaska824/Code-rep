Imports System.Drawing.Configuration

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series10 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ConnectionPanel = New System.Windows.Forms.Panel()
        Me.SignalStrengthLabel = New System.Windows.Forms.Label()
        Me.TimerLabel = New System.Windows.Forms.Label()
        Me.TimerComboBox = New System.Windows.Forms.ComboBox()
        Me.PictureBoxConnectionStatus = New System.Windows.Forms.PictureBox()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.ComboBoxBaudRate = New System.Windows.Forms.ComboBox()
        Me.BaudRateLabel = New System.Windows.Forms.Label()
        Me.ConnectionLabel = New System.Windows.Forms.Label()
        Me.ComboBoxPort = New System.Windows.Forms.ComboBox()
        Me.ScanButton = New System.Windows.Forms.Button()
        Me.ShowSerialDataButton = New System.Windows.Forms.Button()
        Me.HideSerialDataButton = New System.Windows.Forms.Button()
        Me.SignalStrengthValueLabel = New System.Windows.Forms.Label()
        Me.ConnectionButton = New System.Windows.Forms.Button()
        Me.DisconnectButton = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerSerial = New System.Windows.Forms.Timer(Me.components)
        Me.BrakeTempPanel = New System.Windows.Forms.Panel()
        Me.BrakeDiscPictureBox = New System.Windows.Forms.PictureBox()
        Me.ChassisTempLabel = New System.Windows.Forms.Label()
        Me.ChassisTempValueLabel = New System.Windows.Forms.Label()
        Me.SpeedPanel = New System.Windows.Forms.Panel()
        Me.SpeedLabel = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.SpeedProgress = New CircularProgressBar.CircularProgressBar()
        Me.EngineTempPanel = New System.Windows.Forms.Panel()
        Me.EngineTempLabel = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.EngineTempProgress = New CircularProgressBar.CircularProgressBar()
        Me.OilTempPanel = New System.Windows.Forms.Panel()
        Me.OilTempLabel = New System.Windows.Forms.Label()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.OilTempProgress = New CircularProgressBar.CircularProgressBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Manometer = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OilPressLabel = New System.Windows.Forms.Label()
        Me.CarLayout = New System.Windows.Forms.PictureBox()
        Me.TyreTempPanel = New System.Windows.Forms.Panel()
        Me.RLTempLabel = New System.Windows.Forms.Label()
        Me.RRTempLabel = New System.Windows.Forms.Label()
        Me.FRTempLabel = New System.Windows.Forms.Label()
        Me.FLTempLabel = New System.Windows.Forms.Label()
        Me.RRTyrePictureBox = New System.Windows.Forms.PictureBox()
        Me.RLTyrePictureBox = New System.Windows.Forms.PictureBox()
        Me.FRTyrePictureBox = New System.Windows.Forms.PictureBox()
        Me.FLTyrePictureBox = New System.Windows.Forms.PictureBox()
        Me.TyreTempButton = New System.Windows.Forms.Button()
        Me.TyreTempDetailPanel = New System.Windows.Forms.Panel()
        Me.TyreTempBackButton = New System.Windows.Forms.Button()
        Me.RROuterLabel = New System.Windows.Forms.Label()
        Me.RRInnerLabel = New System.Windows.Forms.Label()
        Me.RRLabel = New System.Windows.Forms.Label()
        Me.PictureBox19 = New System.Windows.Forms.PictureBox()
        Me.PictureBox20 = New System.Windows.Forms.PictureBox()
        Me.PictureBox21 = New System.Windows.Forms.PictureBox()
        Me.RRMiddleLabel = New System.Windows.Forms.Label()
        Me.RLInnerLabel = New System.Windows.Forms.Label()
        Me.RLOuterLabel = New System.Windows.Forms.Label()
        Me.RLLabel = New System.Windows.Forms.Label()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.RLMiddleLabel = New System.Windows.Forms.Label()
        Me.FROuterLabel = New System.Windows.Forms.Label()
        Me.FRInnerLabel = New System.Windows.Forms.Label()
        Me.FRLabel = New System.Windows.Forms.Label()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.FRMiddleLabel = New System.Windows.Forms.Label()
        Me.FLInnerLabel = New System.Windows.Forms.Label()
        Me.FLOuterLabel = New System.Windows.Forms.Label()
        Me.FLInnerPictureBox = New System.Windows.Forms.PictureBox()
        Me.FLMiddlePictureBox = New System.Windows.Forms.PictureBox()
        Me.FLOuterPictureBox = New System.Windows.Forms.PictureBox()
        Me.FLMiddleLabel = New System.Windows.Forms.Label()
        Me.FLLabel = New System.Windows.Forms.Label()
        Me.EngineMapButtonA = New System.Windows.Forms.Button()
        Me.EngineMapButtonB = New System.Windows.Forms.Button()
        Me.CarControlPanel = New System.Windows.Forms.Panel()
        Me.AvailabilityLabel = New System.Windows.Forms.Label()
        Me.CarControlLabel = New System.Windows.Forms.Label()
        Me.CarControlComboBox = New System.Windows.Forms.ComboBox()
        Me.LaunchComboBox = New System.Windows.Forms.ComboBox()
        Me.LaunchLabel = New System.Windows.Forms.Label()
        Me.EngineMapLabel = New System.Windows.Forms.Label()
        Me.PictureBox23 = New System.Windows.Forms.PictureBox()
        Me.GearPanel = New System.Windows.Forms.Panel()
        Me.GearLabel = New System.Windows.Forms.Label()
        Me.GearValueLabel = New System.Windows.Forms.Label()
        Me.FuelPressChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.RpmProgress = New CircularProgressBar.CircularProgressBar()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.EngineRpmLabel = New System.Windows.Forms.Label()
        Me.RpmPanel = New System.Windows.Forms.Panel()
        Me.BatteryLabel = New System.Windows.Forms.Label()
        Me.FuelPressLabel = New System.Windows.Forms.Label()
        Me.FuelPanel = New System.Windows.Forms.Panel()
        Me.FuelPictureBox = New System.Windows.Forms.PictureBox()
        Me.FuelUsedLabel = New System.Windows.Forms.Label()
        Me.FuelValueLabel = New System.Windows.Forms.Label()
        Me.LambdaLabel = New System.Windows.Forms.Label()
        Me.LambdaChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.AirTempPanel = New System.Windows.Forms.Panel()
        Me.AirTempPictureBox = New System.Windows.Forms.PictureBox()
        Me.AirTempLabel = New System.Windows.Forms.Label()
        Me.AirTempValueLabel = New System.Windows.Forms.Label()
        Me.ChartPanel1 = New System.Windows.Forms.Panel()
        Me.OilPressChartLabel = New System.Windows.Forms.Label()
        Me.RpmChartLabel = New System.Windows.Forms.Label()
        Me.RpmOilPressChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TPSLabel = New System.Windows.Forms.Label()
        Me.MAPLabel = New System.Windows.Forms.Label()
        Me.ChartButtonsPanel = New System.Windows.Forms.Panel()
        Me.Page2Button = New System.Windows.Forms.Button()
        Me.Page1Button = New System.Windows.Forms.Button()
        Me.ChartPanel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.MAPTPSChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.ARTPictureBox = New System.Windows.Forms.PictureBox()
        Me.RefuelButton = New System.Windows.Forms.Button()
        Me.ConnectionPanel.SuspendLayout()
        CType(Me.PictureBoxConnectionStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BrakeTempPanel.SuspendLayout()
        CType(Me.BrakeDiscPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SpeedPanel.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EngineTempPanel.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OilTempPanel.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Manometer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TyreTempPanel.SuspendLayout()
        CType(Me.RRTyrePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RLTyrePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FRTyrePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLTyrePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TyreTempDetailPanel.SuspendLayout()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLInnerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLMiddlePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLOuterPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CarControlPanel.SuspendLayout()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GearPanel.SuspendLayout()
        CType(Me.FuelPressChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RpmPanel.SuspendLayout()
        Me.FuelPanel.SuspendLayout()
        CType(Me.FuelPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LambdaChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AirTempPanel.SuspendLayout()
        CType(Me.AirTempPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ChartPanel1.SuspendLayout()
        CType(Me.RpmOilPressChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ChartButtonsPanel.SuspendLayout()
        Me.ChartPanel2.SuspendLayout()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MAPTPSChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARTPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConnectionPanel
        '
        Me.ConnectionPanel.Controls.Add(Me.SignalStrengthLabel)
        Me.ConnectionPanel.Controls.Add(Me.TimerLabel)
        Me.ConnectionPanel.Controls.Add(Me.TimerComboBox)
        Me.ConnectionPanel.Controls.Add(Me.PictureBoxConnectionStatus)
        Me.ConnectionPanel.Controls.Add(Me.LabelStatus)
        Me.ConnectionPanel.Controls.Add(Me.ComboBoxBaudRate)
        Me.ConnectionPanel.Controls.Add(Me.BaudRateLabel)
        Me.ConnectionPanel.Controls.Add(Me.ConnectionLabel)
        Me.ConnectionPanel.Controls.Add(Me.ComboBoxPort)
        Me.ConnectionPanel.Controls.Add(Me.ScanButton)
        Me.ConnectionPanel.Controls.Add(Me.ShowSerialDataButton)
        Me.ConnectionPanel.Controls.Add(Me.HideSerialDataButton)
        Me.ConnectionPanel.Controls.Add(Me.SignalStrengthValueLabel)
        Me.ConnectionPanel.Controls.Add(Me.ConnectionButton)
        Me.ConnectionPanel.Controls.Add(Me.DisconnectButton)
        Me.ConnectionPanel.Location = New System.Drawing.Point(1, 2)
        Me.ConnectionPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ConnectionPanel.Name = "ConnectionPanel"
        Me.ConnectionPanel.Size = New System.Drawing.Size(388, 291)
        Me.ConnectionPanel.TabIndex = 0
        '
        'SignalStrengthLabel
        '
        Me.SignalStrengthLabel.AutoSize = True
        Me.SignalStrengthLabel.Location = New System.Drawing.Point(6, 199)
        Me.SignalStrengthLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SignalStrengthLabel.Name = "SignalStrengthLabel"
        Me.SignalStrengthLabel.Size = New System.Drawing.Size(123, 20)
        Me.SignalStrengthLabel.TabIndex = 61
        Me.SignalStrengthLabel.Text = "Signal Strength:"
        '
        'TimerLabel
        '
        Me.TimerLabel.AutoSize = True
        Me.TimerLabel.Font = New System.Drawing.Font("Consolas", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.TimerLabel.Location = New System.Drawing.Point(82, 242)
        Me.TimerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TimerLabel.Name = "TimerLabel"
        Me.TimerLabel.Size = New System.Drawing.Size(70, 22)
        Me.TimerLabel.TabIndex = 53
        Me.TimerLabel.Text = "Timer:"
        '
        'TimerComboBox
        '
        Me.TimerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TimerComboBox.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.TimerComboBox.FormattingEnabled = True
        Me.TimerComboBox.Items.AddRange(New Object() {"1", "10", "20", "30", "40", "50", "60", "70", "80", "90", "100", "125", "150", "200", "250", "300", "350", "400", "450", "550"})
        Me.TimerComboBox.Location = New System.Drawing.Point(179, 239)
        Me.TimerComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TimerComboBox.Name = "TimerComboBox"
        Me.TimerComboBox.Size = New System.Drawing.Size(180, 30)
        Me.TimerComboBox.TabIndex = 52
        '
        'PictureBoxConnectionStatus
        '
        Me.PictureBoxConnectionStatus.BackColor = System.Drawing.Color.Tomato
        Me.PictureBoxConnectionStatus.Location = New System.Drawing.Point(330, 159)
        Me.PictureBoxConnectionStatus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBoxConnectionStatus.Name = "PictureBoxConnectionStatus"
        Me.PictureBoxConnectionStatus.Size = New System.Drawing.Size(22, 22)
        Me.PictureBoxConnectionStatus.TabIndex = 2
        Me.PictureBoxConnectionStatus.TabStop = False
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(163, 159)
        Me.LabelStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(166, 20)
        Me.LabelStatus.TabIndex = 8
        Me.LabelStatus.Text = "Status : Disconnected"
        '
        'ComboBoxBaudRate
        '
        Me.ComboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBaudRate.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.ComboBoxBaudRate.FormattingEnabled = True
        Me.ComboBoxBaudRate.Items.AddRange(New Object() {"9600", "14400", "19200", "38400", "57600", "115200"})
        Me.ComboBoxBaudRate.Location = New System.Drawing.Point(179, 102)
        Me.ComboBoxBaudRate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBoxBaudRate.Name = "ComboBoxBaudRate"
        Me.ComboBoxBaudRate.Size = New System.Drawing.Size(180, 30)
        Me.ComboBoxBaudRate.TabIndex = 5
        '
        'BaudRateLabel
        '
        Me.BaudRateLabel.AutoSize = True
        Me.BaudRateLabel.Font = New System.Drawing.Font("Consolas", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.BaudRateLabel.Location = New System.Drawing.Point(40, 108)
        Me.BaudRateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BaudRateLabel.Name = "BaudRateLabel"
        Me.BaudRateLabel.Size = New System.Drawing.Size(110, 22)
        Me.BaudRateLabel.TabIndex = 4
        Me.BaudRateLabel.Text = "Baud Rate:"
        '
        'ConnectionLabel
        '
        Me.ConnectionLabel.AutoSize = True
        Me.ConnectionLabel.Font = New System.Drawing.Font("Consolas", 12.5!, System.Drawing.FontStyle.Bold)
        Me.ConnectionLabel.Location = New System.Drawing.Point(82, 14)
        Me.ConnectionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ConnectionLabel.Name = "ConnectionLabel"
        Me.ConnectionLabel.Size = New System.Drawing.Size(237, 29)
        Me.ConnectionLabel.TabIndex = 3
        Me.ConnectionLabel.Text = "Connection Panel"
        '
        'ComboBoxPort
        '
        Me.ComboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPort.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.ComboBoxPort.FormattingEnabled = True
        Me.ComboBoxPort.Location = New System.Drawing.Point(179, 52)
        Me.ComboBoxPort.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBoxPort.Name = "ComboBoxPort"
        Me.ComboBoxPort.Size = New System.Drawing.Size(180, 30)
        Me.ComboBoxPort.TabIndex = 2
        '
        'ScanButton
        '
        Me.ScanButton.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.ScanButton.Location = New System.Drawing.Point(33, 51)
        Me.ScanButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ScanButton.Name = "ScanButton"
        Me.ScanButton.Size = New System.Drawing.Size(127, 35)
        Me.ScanButton.TabIndex = 1
        Me.ScanButton.Text = "Scan Port"
        Me.ScanButton.UseVisualStyleBackColor = True
        '
        'ShowSerialDataButton
        '
        Me.ShowSerialDataButton.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.ShowSerialDataButton.Location = New System.Drawing.Point(179, 192)
        Me.ShowSerialDataButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ShowSerialDataButton.Name = "ShowSerialDataButton"
        Me.ShowSerialDataButton.Size = New System.Drawing.Size(181, 34)
        Me.ShowSerialDataButton.TabIndex = 50
        Me.ShowSerialDataButton.Text = "Show Serial Data"
        Me.ShowSerialDataButton.UseVisualStyleBackColor = True
        '
        'HideSerialDataButton
        '
        Me.HideSerialDataButton.Font = New System.Drawing.Font("Consolas", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.HideSerialDataButton.Location = New System.Drawing.Point(179, 191)
        Me.HideSerialDataButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.HideSerialDataButton.Name = "HideSerialDataButton"
        Me.HideSerialDataButton.Size = New System.Drawing.Size(181, 34)
        Me.HideSerialDataButton.TabIndex = 51
        Me.HideSerialDataButton.Text = "Hide Serial Data"
        Me.HideSerialDataButton.UseVisualStyleBackColor = True
        '
        'SignalStrengthValueLabel
        '
        Me.SignalStrengthValueLabel.AutoSize = True
        Me.SignalStrengthValueLabel.BackColor = System.Drawing.Color.Transparent
        Me.SignalStrengthValueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.SignalStrengthValueLabel.Location = New System.Drawing.Point(125, 195)
        Me.SignalStrengthValueLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SignalStrengthValueLabel.Name = "SignalStrengthValueLabel"
        Me.SignalStrengthValueLabel.Size = New System.Drawing.Size(50, 22)
        Me.SignalStrengthValueLabel.TabIndex = 62
        Me.SignalStrengthValueLabel.Text = "-999"
        '
        'ConnectionButton
        '
        Me.ConnectionButton.BackColor = System.Drawing.Color.LightGreen
        Me.ConnectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConnectionButton.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.ConnectionButton.Location = New System.Drawing.Point(33, 148)
        Me.ConnectionButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ConnectionButton.Name = "ConnectionButton"
        Me.ConnectionButton.Size = New System.Drawing.Size(127, 35)
        Me.ConnectionButton.TabIndex = 6
        Me.ConnectionButton.Text = "Connect"
        Me.ConnectionButton.UseVisualStyleBackColor = False
        '
        'DisconnectButton
        '
        Me.DisconnectButton.BackColor = System.Drawing.Color.Tomato
        Me.DisconnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DisconnectButton.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.DisconnectButton.Location = New System.Drawing.Point(33, 148)
        Me.DisconnectButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DisconnectButton.Name = "DisconnectButton"
        Me.DisconnectButton.Size = New System.Drawing.Size(127, 35)
        Me.DisconnectButton.TabIndex = 7
        Me.DisconnectButton.Text = "Disconnect"
        Me.DisconnectButton.UseVisualStyleBackColor = False
        '
        'TimerSerial
        '
        '
        'BrakeTempPanel
        '
        Me.BrakeTempPanel.Controls.Add(Me.BrakeDiscPictureBox)
        Me.BrakeTempPanel.Controls.Add(Me.ChassisTempLabel)
        Me.BrakeTempPanel.Controls.Add(Me.ChassisTempValueLabel)
        Me.BrakeTempPanel.Location = New System.Drawing.Point(1277, 218)
        Me.BrakeTempPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BrakeTempPanel.Name = "BrakeTempPanel"
        Me.BrakeTempPanel.Size = New System.Drawing.Size(280, 99)
        Me.BrakeTempPanel.TabIndex = 35
        '
        'BrakeDiscPictureBox
        '
        Me.BrakeDiscPictureBox.Image = CType(resources.GetObject("BrakeDiscPictureBox.Image"), System.Drawing.Image)
        Me.BrakeDiscPictureBox.Location = New System.Drawing.Point(6, 1)
        Me.BrakeDiscPictureBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BrakeDiscPictureBox.Name = "BrakeDiscPictureBox"
        Me.BrakeDiscPictureBox.Size = New System.Drawing.Size(90, 92)
        Me.BrakeDiscPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BrakeDiscPictureBox.TabIndex = 32
        Me.BrakeDiscPictureBox.TabStop = False
        '
        'ChassisTempLabel
        '
        Me.ChassisTempLabel.AutoSize = True
        Me.ChassisTempLabel.BackColor = System.Drawing.Color.Transparent
        Me.ChassisTempLabel.Font = New System.Drawing.Font("Consolas", 12.5!, System.Drawing.FontStyle.Bold)
        Me.ChassisTempLabel.Location = New System.Drawing.Point(96, 2)
        Me.ChassisTempLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ChassisTempLabel.Name = "ChassisTempLabel"
        Me.ChassisTempLabel.Size = New System.Drawing.Size(167, 58)
        Me.ChassisTempLabel.TabIndex = 33
        Me.ChassisTempLabel.Text = "Chassis " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Temperature" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ChassisTempValueLabel
        '
        Me.ChassisTempValueLabel.AutoSize = True
        Me.ChassisTempValueLabel.Font = New System.Drawing.Font("Consolas", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChassisTempValueLabel.Location = New System.Drawing.Point(96, 55)
        Me.ChassisTempValueLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ChassisTempValueLabel.Name = "ChassisTempValueLabel"
        Me.ChassisTempValueLabel.Size = New System.Drawing.Size(56, 31)
        Me.ChassisTempValueLabel.TabIndex = 25
        Me.ChassisTempValueLabel.Text = "0oC"
        Me.ChassisTempValueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SpeedPanel
        '
        Me.SpeedPanel.Controls.Add(Me.SpeedLabel)
        Me.SpeedPanel.Controls.Add(Me.PictureBox5)
        Me.SpeedPanel.Controls.Add(Me.PictureBox6)
        Me.SpeedPanel.Controls.Add(Me.SpeedProgress)
        Me.SpeedPanel.Location = New System.Drawing.Point(678, 2)
        Me.SpeedPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SpeedPanel.Name = "SpeedPanel"
        Me.SpeedPanel.Size = New System.Drawing.Size(255, 194)
        Me.SpeedPanel.TabIndex = 19
        '
        'SpeedLabel
        '
        Me.SpeedLabel.AutoSize = True
        Me.SpeedLabel.BackColor = System.Drawing.Color.Transparent
        Me.SpeedLabel.Font = New System.Drawing.Font("Consolas", 12.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpeedLabel.Location = New System.Drawing.Point(89, 15)
        Me.SpeedLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SpeedLabel.Name = "SpeedLabel"
        Me.SpeedLabel.Size = New System.Drawing.Size(83, 29)
        Me.SpeedLabel.TabIndex = 32
        Me.SpeedLabel.Text = "Speed"
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(192, 165)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(45, 78)
        Me.PictureBox5.TabIndex = 13
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Location = New System.Drawing.Point(15, 162)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(45, 78)
        Me.PictureBox6.TabIndex = 12
        Me.PictureBox6.TabStop = False
        '
        'SpeedProgress
        '
        Me.SpeedProgress.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.SpeedProgress.AnimationSpeed = 100
        Me.SpeedProgress.BackColor = System.Drawing.Color.Transparent
        Me.SpeedProgress.Font = New System.Drawing.Font("Consolas", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpeedProgress.ForeColor = System.Drawing.Color.Black
        Me.SpeedProgress.InnerColor = System.Drawing.Color.White
        Me.SpeedProgress.InnerMargin = 2
        Me.SpeedProgress.InnerWidth = -1
        Me.SpeedProgress.Location = New System.Drawing.Point(12, 48)
        Me.SpeedProgress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SpeedProgress.MarqueeAnimationSpeed = 2000
        Me.SpeedProgress.Name = "SpeedProgress"
        Me.SpeedProgress.OuterColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SpeedProgress.OuterMargin = -25
        Me.SpeedProgress.OuterWidth = 26
        Me.SpeedProgress.ProgressColor = System.Drawing.Color.Aqua
        Me.SpeedProgress.ProgressWidth = 25
        Me.SpeedProgress.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.SpeedProgress.Size = New System.Drawing.Size(225, 231)
        Me.SpeedProgress.StartAngle = 180
        Me.SpeedProgress.Step = 1
        Me.SpeedProgress.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.SpeedProgress.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.SpeedProgress.SubscriptText = " "
        Me.SpeedProgress.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.SpeedProgress.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.SpeedProgress.SuperscriptText = " "
        Me.SpeedProgress.TabIndex = 10
        Me.SpeedProgress.Text = "0"
        Me.SpeedProgress.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.SpeedProgress.Value = 20
        '
        'EngineTempPanel
        '
        Me.EngineTempPanel.Controls.Add(Me.EngineTempLabel)
        Me.EngineTempPanel.Controls.Add(Me.PictureBox8)
        Me.EngineTempPanel.Controls.Add(Me.PictureBox9)
        Me.EngineTempPanel.Controls.Add(Me.EngineTempProgress)
        Me.EngineTempPanel.Location = New System.Drawing.Point(960, 2)
        Me.EngineTempPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EngineTempPanel.Name = "EngineTempPanel"
        Me.EngineTempPanel.Size = New System.Drawing.Size(255, 194)
        Me.EngineTempPanel.TabIndex = 20
        '
        'EngineTempLabel
        '
        Me.EngineTempLabel.AutoSize = True
        Me.EngineTempLabel.BackColor = System.Drawing.Color.Transparent
        Me.EngineTempLabel.Font = New System.Drawing.Font("Consolas", 12.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EngineTempLabel.Location = New System.Drawing.Point(-1, 14)
        Me.EngineTempLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EngineTempLabel.Name = "EngineTempLabel"
        Me.EngineTempLabel.Size = New System.Drawing.Size(265, 29)
        Me.EngineTempLabel.TabIndex = 21
        Me.EngineTempLabel.Text = "Engine Temperature"
        '
        'PictureBox8
        '
        Me.PictureBox8.Location = New System.Drawing.Point(190, 165)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(45, 78)
        Me.PictureBox8.TabIndex = 13
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Location = New System.Drawing.Point(15, 165)
        Me.PictureBox9.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(45, 78)
        Me.PictureBox9.TabIndex = 12
        Me.PictureBox9.TabStop = False
        '
        'EngineTempProgress
        '
        Me.EngineTempProgress.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.EngineTempProgress.AnimationSpeed = 100
        Me.EngineTempProgress.BackColor = System.Drawing.Color.Transparent
        Me.EngineTempProgress.Font = New System.Drawing.Font("Consolas", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.EngineTempProgress.ForeColor = System.Drawing.Color.Black
        Me.EngineTempProgress.InnerColor = System.Drawing.Color.White
        Me.EngineTempProgress.InnerMargin = 2
        Me.EngineTempProgress.InnerWidth = -1
        Me.EngineTempProgress.Location = New System.Drawing.Point(12, 49)
        Me.EngineTempProgress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EngineTempProgress.MarqueeAnimationSpeed = 2000
        Me.EngineTempProgress.Name = "EngineTempProgress"
        Me.EngineTempProgress.OuterColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EngineTempProgress.OuterMargin = -25
        Me.EngineTempProgress.OuterWidth = 26
        Me.EngineTempProgress.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.EngineTempProgress.ProgressWidth = 25
        Me.EngineTempProgress.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.EngineTempProgress.Size = New System.Drawing.Size(225, 231)
        Me.EngineTempProgress.StartAngle = 180
        Me.EngineTempProgress.Step = 1
        Me.EngineTempProgress.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.EngineTempProgress.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.EngineTempProgress.SubscriptText = " "
        Me.EngineTempProgress.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.EngineTempProgress.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.EngineTempProgress.SuperscriptText = " "
        Me.EngineTempProgress.TabIndex = 10
        Me.EngineTempProgress.Text = "0oC"
        Me.EngineTempProgress.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.EngineTempProgress.Value = 20
        '
        'OilTempPanel
        '
        Me.OilTempPanel.Controls.Add(Me.OilTempLabel)
        Me.OilTempPanel.Controls.Add(Me.PictureBox11)
        Me.OilTempPanel.Controls.Add(Me.PictureBox12)
        Me.OilTempPanel.Controls.Add(Me.OilTempProgress)
        Me.OilTempPanel.Location = New System.Drawing.Point(1239, 2)
        Me.OilTempPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OilTempPanel.Name = "OilTempPanel"
        Me.OilTempPanel.Size = New System.Drawing.Size(255, 194)
        Me.OilTempPanel.TabIndex = 22
        '
        'OilTempLabel
        '
        Me.OilTempLabel.AutoSize = True
        Me.OilTempLabel.BackColor = System.Drawing.Color.Transparent
        Me.OilTempLabel.Font = New System.Drawing.Font("Consolas", 12.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OilTempLabel.Location = New System.Drawing.Point(26, 15)
        Me.OilTempLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.OilTempLabel.Name = "OilTempLabel"
        Me.OilTempLabel.Size = New System.Drawing.Size(223, 29)
        Me.OilTempLabel.TabIndex = 21
        Me.OilTempLabel.Text = "Oil Temperature"
        '
        'PictureBox11
        '
        Me.PictureBox11.Location = New System.Drawing.Point(190, 165)
        Me.PictureBox11.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(45, 78)
        Me.PictureBox11.TabIndex = 13
        Me.PictureBox11.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.Location = New System.Drawing.Point(15, 165)
        Me.PictureBox12.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(45, 78)
        Me.PictureBox12.TabIndex = 12
        Me.PictureBox12.TabStop = False
        '
        'OilTempProgress
        '
        Me.OilTempProgress.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.OilTempProgress.AnimationSpeed = 100
        Me.OilTempProgress.BackColor = System.Drawing.Color.Transparent
        Me.OilTempProgress.Font = New System.Drawing.Font("Consolas", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.OilTempProgress.ForeColor = System.Drawing.Color.Black
        Me.OilTempProgress.InnerColor = System.Drawing.Color.White
        Me.OilTempProgress.InnerMargin = 2
        Me.OilTempProgress.InnerWidth = -1
        Me.OilTempProgress.Location = New System.Drawing.Point(12, 49)
        Me.OilTempProgress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OilTempProgress.MarqueeAnimationSpeed = 2000
        Me.OilTempProgress.Name = "OilTempProgress"
        Me.OilTempProgress.OuterColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OilTempProgress.OuterMargin = -25
        Me.OilTempProgress.OuterWidth = 26
        Me.OilTempProgress.ProgressColor = System.Drawing.Color.SkyBlue
        Me.OilTempProgress.ProgressWidth = 25
        Me.OilTempProgress.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.OilTempProgress.Size = New System.Drawing.Size(225, 231)
        Me.OilTempProgress.StartAngle = 180
        Me.OilTempProgress.Step = 1
        Me.OilTempProgress.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.OilTempProgress.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.OilTempProgress.SubscriptText = " "
        Me.OilTempProgress.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.OilTempProgress.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.OilTempProgress.SuperscriptText = " "
        Me.OilTempProgress.TabIndex = 10
        Me.OilTempProgress.Text = "0oC"
        Me.OilTempProgress.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.OilTempProgress.Value = 20
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Manometer)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.OilPressLabel)
        Me.Panel2.Location = New System.Drawing.Point(582, 218)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(242, 99)
        Me.Panel2.TabIndex = 23
        '
        'Manometer
        '
        Me.Manometer.Image = CType(resources.GetObject("Manometer.Image"), System.Drawing.Image)
        Me.Manometer.Location = New System.Drawing.Point(0, 0)
        Me.Manometer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Manometer.Name = "Manometer"
        Me.Manometer.Size = New System.Drawing.Size(90, 92)
        Me.Manometer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Manometer.TabIndex = 24
        Me.Manometer.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Consolas", 12.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 58)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Oil" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pressure"
        '
        'OilPressLabel
        '
        Me.OilPressLabel.AutoSize = True
        Me.OilPressLabel.Font = New System.Drawing.Font("Consolas", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OilPressLabel.Location = New System.Drawing.Point(84, 55)
        Me.OilPressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.OilPressLabel.Name = "OilPressLabel"
        Me.OilPressLabel.Size = New System.Drawing.Size(70, 31)
        Me.OilPressLabel.TabIndex = 14
        Me.OilPressLabel.Text = "0kPa"
        Me.OilPressLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CarLayout
        '
        Me.CarLayout.Image = CType(resources.GetObject("CarLayout.Image"), System.Drawing.Image)
        Me.CarLayout.Location = New System.Drawing.Point(75, 5)
        Me.CarLayout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CarLayout.Name = "CarLayout"
        Me.CarLayout.Size = New System.Drawing.Size(212, 300)
        Me.CarLayout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CarLayout.TabIndex = 25
        Me.CarLayout.TabStop = False
        '
        'TyreTempPanel
        '
        Me.TyreTempPanel.Controls.Add(Me.RLTempLabel)
        Me.TyreTempPanel.Controls.Add(Me.RRTempLabel)
        Me.TyreTempPanel.Controls.Add(Me.FRTempLabel)
        Me.TyreTempPanel.Controls.Add(Me.FLTempLabel)
        Me.TyreTempPanel.Controls.Add(Me.RRTyrePictureBox)
        Me.TyreTempPanel.Controls.Add(Me.RLTyrePictureBox)
        Me.TyreTempPanel.Controls.Add(Me.FRTyrePictureBox)
        Me.TyreTempPanel.Controls.Add(Me.FLTyrePictureBox)
        Me.TyreTempPanel.Controls.Add(Me.CarLayout)
        Me.TyreTempPanel.Controls.Add(Me.TyreTempButton)
        Me.TyreTempPanel.Location = New System.Drawing.Point(1239, 331)
        Me.TyreTempPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TyreTempPanel.Name = "TyreTempPanel"
        Me.TyreTempPanel.Size = New System.Drawing.Size(359, 354)
        Me.TyreTempPanel.TabIndex = 26
        '
        'RLTempLabel
        '
        Me.RLTempLabel.AutoSize = True
        Me.RLTempLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.RLTempLabel.Location = New System.Drawing.Point(9, 222)
        Me.RLTempLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RLTempLabel.Name = "RLTempLabel"
        Me.RLTempLabel.Size = New System.Drawing.Size(51, 28)
        Me.RLTempLabel.TabIndex = 31
        Me.RLTempLabel.Text = "0oC"
        '
        'RRTempLabel
        '
        Me.RRTempLabel.AutoSize = True
        Me.RRTempLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.RRTempLabel.Location = New System.Drawing.Point(287, 222)
        Me.RRTempLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RRTempLabel.Name = "RRTempLabel"
        Me.RRTempLabel.Size = New System.Drawing.Size(51, 28)
        Me.RRTempLabel.TabIndex = 28
        Me.RRTempLabel.Text = "0oC"
        '
        'FRTempLabel
        '
        Me.FRTempLabel.AutoSize = True
        Me.FRTempLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.FRTempLabel.Location = New System.Drawing.Point(280, 62)
        Me.FRTempLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FRTempLabel.Name = "FRTempLabel"
        Me.FRTempLabel.Size = New System.Drawing.Size(51, 28)
        Me.FRTempLabel.TabIndex = 30
        Me.FRTempLabel.Text = "0oC"
        '
        'FLTempLabel
        '
        Me.FLTempLabel.AutoSize = True
        Me.FLTempLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.FLTempLabel.Location = New System.Drawing.Point(17, 62)
        Me.FLTempLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FLTempLabel.Name = "FLTempLabel"
        Me.FLTempLabel.Size = New System.Drawing.Size(51, 28)
        Me.FLTempLabel.TabIndex = 27
        Me.FLTempLabel.Text = "0oC"
        '
        'RRTyrePictureBox
        '
        Me.RRTyrePictureBox.BackColor = System.Drawing.Color.GreenYellow
        Me.RRTyrePictureBox.Location = New System.Drawing.Point(237, 212)
        Me.RRTyrePictureBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RRTyrePictureBox.Name = "RRTyrePictureBox"
        Me.RRTyrePictureBox.Size = New System.Drawing.Size(37, 52)
        Me.RRTyrePictureBox.TabIndex = 29
        Me.RRTyrePictureBox.TabStop = False
        '
        'RLTyrePictureBox
        '
        Me.RLTyrePictureBox.BackColor = System.Drawing.Color.GreenYellow
        Me.RLTyrePictureBox.Location = New System.Drawing.Point(87, 212)
        Me.RLTyrePictureBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RLTyrePictureBox.Name = "RLTyrePictureBox"
        Me.RLTyrePictureBox.Size = New System.Drawing.Size(37, 52)
        Me.RLTyrePictureBox.TabIndex = 28
        Me.RLTyrePictureBox.TabStop = False
        '
        'FRTyrePictureBox
        '
        Me.FRTyrePictureBox.BackColor = System.Drawing.Color.GreenYellow
        Me.FRTyrePictureBox.Location = New System.Drawing.Point(235, 58)
        Me.FRTyrePictureBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FRTyrePictureBox.Name = "FRTyrePictureBox"
        Me.FRTyrePictureBox.Size = New System.Drawing.Size(33, 49)
        Me.FRTyrePictureBox.TabIndex = 28
        Me.FRTyrePictureBox.TabStop = False
        '
        'FLTyrePictureBox
        '
        Me.FLTyrePictureBox.BackColor = System.Drawing.Color.GreenYellow
        Me.FLTyrePictureBox.Location = New System.Drawing.Point(93, 58)
        Me.FLTyrePictureBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FLTyrePictureBox.Name = "FLTyrePictureBox"
        Me.FLTyrePictureBox.Size = New System.Drawing.Size(33, 49)
        Me.FLTyrePictureBox.TabIndex = 27
        Me.FLTyrePictureBox.TabStop = False
        '
        'TyreTempButton
        '
        Me.TyreTempButton.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.TyreTempButton.Location = New System.Drawing.Point(125, 314)
        Me.TyreTempButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TyreTempButton.Name = "TyreTempButton"
        Me.TyreTempButton.Size = New System.Drawing.Size(112, 35)
        Me.TyreTempButton.TabIndex = 32
        Me.TyreTempButton.Text = "Details"
        Me.TyreTempButton.UseVisualStyleBackColor = True
        '
        'TyreTempDetailPanel
        '
        Me.TyreTempDetailPanel.Controls.Add(Me.TyreTempBackButton)
        Me.TyreTempDetailPanel.Controls.Add(Me.RROuterLabel)
        Me.TyreTempDetailPanel.Controls.Add(Me.RRInnerLabel)
        Me.TyreTempDetailPanel.Controls.Add(Me.RRLabel)
        Me.TyreTempDetailPanel.Controls.Add(Me.PictureBox19)
        Me.TyreTempDetailPanel.Controls.Add(Me.PictureBox20)
        Me.TyreTempDetailPanel.Controls.Add(Me.PictureBox21)
        Me.TyreTempDetailPanel.Controls.Add(Me.RRMiddleLabel)
        Me.TyreTempDetailPanel.Controls.Add(Me.RLInnerLabel)
        Me.TyreTempDetailPanel.Controls.Add(Me.RLOuterLabel)
        Me.TyreTempDetailPanel.Controls.Add(Me.RLLabel)
        Me.TyreTempDetailPanel.Controls.Add(Me.PictureBox16)
        Me.TyreTempDetailPanel.Controls.Add(Me.PictureBox17)
        Me.TyreTempDetailPanel.Controls.Add(Me.PictureBox18)
        Me.TyreTempDetailPanel.Controls.Add(Me.RLMiddleLabel)
        Me.TyreTempDetailPanel.Controls.Add(Me.FROuterLabel)
        Me.TyreTempDetailPanel.Controls.Add(Me.FRInnerLabel)
        Me.TyreTempDetailPanel.Controls.Add(Me.FRLabel)
        Me.TyreTempDetailPanel.Controls.Add(Me.PictureBox13)
        Me.TyreTempDetailPanel.Controls.Add(Me.PictureBox14)
        Me.TyreTempDetailPanel.Controls.Add(Me.PictureBox15)
        Me.TyreTempDetailPanel.Controls.Add(Me.FRMiddleLabel)
        Me.TyreTempDetailPanel.Controls.Add(Me.FLInnerLabel)
        Me.TyreTempDetailPanel.Controls.Add(Me.FLOuterLabel)
        Me.TyreTempDetailPanel.Controls.Add(Me.FLInnerPictureBox)
        Me.TyreTempDetailPanel.Controls.Add(Me.FLMiddlePictureBox)
        Me.TyreTempDetailPanel.Controls.Add(Me.FLOuterPictureBox)
        Me.TyreTempDetailPanel.Controls.Add(Me.FLMiddleLabel)
        Me.TyreTempDetailPanel.Controls.Add(Me.FLLabel)
        Me.TyreTempDetailPanel.Location = New System.Drawing.Point(1230, 334)
        Me.TyreTempDetailPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TyreTempDetailPanel.Name = "TyreTempDetailPanel"
        Me.TyreTempDetailPanel.Size = New System.Drawing.Size(359, 354)
        Me.TyreTempDetailPanel.TabIndex = 27
        '
        'TyreTempBackButton
        '
        Me.TyreTempBackButton.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.TyreTempBackButton.Location = New System.Drawing.Point(125, 314)
        Me.TyreTempBackButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TyreTempBackButton.Name = "TyreTempBackButton"
        Me.TyreTempBackButton.Size = New System.Drawing.Size(112, 35)
        Me.TyreTempBackButton.TabIndex = 33
        Me.TyreTempBackButton.Text = "Back"
        Me.TyreTempBackButton.UseVisualStyleBackColor = True
        '
        'RROuterLabel
        '
        Me.RROuterLabel.AutoSize = True
        Me.RROuterLabel.Location = New System.Drawing.Point(300, 291)
        Me.RROuterLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RROuterLabel.Name = "RROuterLabel"
        Me.RROuterLabel.Size = New System.Drawing.Size(38, 20)
        Me.RROuterLabel.TabIndex = 53
        Me.RROuterLabel.Text = "0oC"
        '
        'RRInnerLabel
        '
        Me.RRInnerLabel.AutoSize = True
        Me.RRInnerLabel.BackColor = System.Drawing.Color.Transparent
        Me.RRInnerLabel.Location = New System.Drawing.Point(214, 291)
        Me.RRInnerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RRInnerLabel.Name = "RRInnerLabel"
        Me.RRInnerLabel.Size = New System.Drawing.Size(38, 20)
        Me.RRInnerLabel.TabIndex = 51
        Me.RRInnerLabel.Text = "0oC"
        '
        'RRLabel
        '
        Me.RRLabel.AutoSize = True
        Me.RRLabel.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.RRLabel.Location = New System.Drawing.Point(255, 165)
        Me.RRLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RRLabel.Name = "RRLabel"
        Me.RRLabel.Size = New System.Drawing.Size(47, 36)
        Me.RRLabel.TabIndex = 48
        Me.RRLabel.Text = "RR"
        '
        'PictureBox19
        '
        Me.PictureBox19.BackColor = System.Drawing.Color.OrangeRed
        Me.PictureBox19.Location = New System.Drawing.Point(294, 205)
        Me.PictureBox19.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox19.Name = "PictureBox19"
        Me.PictureBox19.Size = New System.Drawing.Size(30, 78)
        Me.PictureBox19.TabIndex = 50
        Me.PictureBox19.TabStop = False
        '
        'PictureBox20
        '
        Me.PictureBox20.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox20.Location = New System.Drawing.Point(264, 205)
        Me.PictureBox20.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox20.Name = "PictureBox20"
        Me.PictureBox20.Size = New System.Drawing.Size(30, 78)
        Me.PictureBox20.TabIndex = 49
        Me.PictureBox20.TabStop = False
        '
        'PictureBox21
        '
        Me.PictureBox21.BackColor = System.Drawing.Color.GreenYellow
        Me.PictureBox21.Location = New System.Drawing.Point(235, 205)
        Me.PictureBox21.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox21.Name = "PictureBox21"
        Me.PictureBox21.Size = New System.Drawing.Size(30, 78)
        Me.PictureBox21.TabIndex = 47
        Me.PictureBox21.TabStop = False
        '
        'RRMiddleLabel
        '
        Me.RRMiddleLabel.AutoSize = True
        Me.RRMiddleLabel.Location = New System.Drawing.Point(259, 291)
        Me.RRMiddleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RRMiddleLabel.Name = "RRMiddleLabel"
        Me.RRMiddleLabel.Size = New System.Drawing.Size(38, 20)
        Me.RRMiddleLabel.TabIndex = 52
        Me.RRMiddleLabel.Text = "0oC"
        '
        'RLInnerLabel
        '
        Me.RLInnerLabel.AutoSize = True
        Me.RLInnerLabel.Location = New System.Drawing.Point(101, 291)
        Me.RLInnerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RLInnerLabel.Name = "RLInnerLabel"
        Me.RLInnerLabel.Size = New System.Drawing.Size(38, 20)
        Me.RLInnerLabel.TabIndex = 46
        Me.RLInnerLabel.Text = "0oC"
        '
        'RLOuterLabel
        '
        Me.RLOuterLabel.AutoSize = True
        Me.RLOuterLabel.BackColor = System.Drawing.Color.Transparent
        Me.RLOuterLabel.Location = New System.Drawing.Point(15, 291)
        Me.RLOuterLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RLOuterLabel.Name = "RLOuterLabel"
        Me.RLOuterLabel.Size = New System.Drawing.Size(38, 20)
        Me.RLOuterLabel.TabIndex = 44
        Me.RLOuterLabel.Text = "0oC"
        '
        'RLLabel
        '
        Me.RLLabel.AutoSize = True
        Me.RLLabel.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.RLLabel.Location = New System.Drawing.Point(50, 165)
        Me.RLLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RLLabel.Name = "RLLabel"
        Me.RLLabel.Size = New System.Drawing.Size(47, 36)
        Me.RLLabel.TabIndex = 41
        Me.RLLabel.Text = "RL"
        '
        'PictureBox16
        '
        Me.PictureBox16.BackColor = System.Drawing.Color.OrangeRed
        Me.PictureBox16.Location = New System.Drawing.Point(89, 205)
        Me.PictureBox16.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(30, 78)
        Me.PictureBox16.TabIndex = 43
        Me.PictureBox16.TabStop = False
        '
        'PictureBox17
        '
        Me.PictureBox17.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox17.Location = New System.Drawing.Point(58, 205)
        Me.PictureBox17.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(30, 78)
        Me.PictureBox17.TabIndex = 42
        Me.PictureBox17.TabStop = False
        '
        'PictureBox18
        '
        Me.PictureBox18.BackColor = System.Drawing.Color.GreenYellow
        Me.PictureBox18.Location = New System.Drawing.Point(30, 205)
        Me.PictureBox18.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(30, 78)
        Me.PictureBox18.TabIndex = 40
        Me.PictureBox18.TabStop = False
        '
        'RLMiddleLabel
        '
        Me.RLMiddleLabel.AutoSize = True
        Me.RLMiddleLabel.Location = New System.Drawing.Point(58, 291)
        Me.RLMiddleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RLMiddleLabel.Name = "RLMiddleLabel"
        Me.RLMiddleLabel.Size = New System.Drawing.Size(38, 20)
        Me.RLMiddleLabel.TabIndex = 45
        Me.RLMiddleLabel.Text = "0oC"
        '
        'FROuterLabel
        '
        Me.FROuterLabel.AutoSize = True
        Me.FROuterLabel.Location = New System.Drawing.Point(300, 139)
        Me.FROuterLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FROuterLabel.Name = "FROuterLabel"
        Me.FROuterLabel.Size = New System.Drawing.Size(38, 20)
        Me.FROuterLabel.TabIndex = 39
        Me.FROuterLabel.Text = "0oC"
        '
        'FRInnerLabel
        '
        Me.FRInnerLabel.AutoSize = True
        Me.FRInnerLabel.BackColor = System.Drawing.Color.Transparent
        Me.FRInnerLabel.Location = New System.Drawing.Point(213, 139)
        Me.FRInnerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FRInnerLabel.Name = "FRInnerLabel"
        Me.FRInnerLabel.Size = New System.Drawing.Size(38, 20)
        Me.FRInnerLabel.TabIndex = 37
        Me.FRInnerLabel.Text = "0oC"
        '
        'FRLabel
        '
        Me.FRLabel.AutoSize = True
        Me.FRLabel.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.FRLabel.Location = New System.Drawing.Point(255, 12)
        Me.FRLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FRLabel.Name = "FRLabel"
        Me.FRLabel.Size = New System.Drawing.Size(47, 36)
        Me.FRLabel.TabIndex = 34
        Me.FRLabel.Text = "FR"
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.OrangeRed
        Me.PictureBox13.Location = New System.Drawing.Point(294, 52)
        Me.PictureBox13.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(30, 78)
        Me.PictureBox13.TabIndex = 36
        Me.PictureBox13.TabStop = False
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox14.Location = New System.Drawing.Point(264, 52)
        Me.PictureBox14.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(30, 78)
        Me.PictureBox14.TabIndex = 35
        Me.PictureBox14.TabStop = False
        '
        'PictureBox15
        '
        Me.PictureBox15.BackColor = System.Drawing.Color.GreenYellow
        Me.PictureBox15.Location = New System.Drawing.Point(235, 52)
        Me.PictureBox15.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(30, 78)
        Me.PictureBox15.TabIndex = 33
        Me.PictureBox15.TabStop = False
        '
        'FRMiddleLabel
        '
        Me.FRMiddleLabel.AutoSize = True
        Me.FRMiddleLabel.Location = New System.Drawing.Point(258, 139)
        Me.FRMiddleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FRMiddleLabel.Name = "FRMiddleLabel"
        Me.FRMiddleLabel.Size = New System.Drawing.Size(38, 20)
        Me.FRMiddleLabel.TabIndex = 38
        Me.FRMiddleLabel.Text = "0oC"
        '
        'FLInnerLabel
        '
        Me.FLInnerLabel.AutoSize = True
        Me.FLInnerLabel.Location = New System.Drawing.Point(108, 139)
        Me.FLInnerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FLInnerLabel.Name = "FLInnerLabel"
        Me.FLInnerLabel.Size = New System.Drawing.Size(38, 20)
        Me.FLInnerLabel.TabIndex = 32
        Me.FLInnerLabel.Text = "0oC"
        '
        'FLOuterLabel
        '
        Me.FLOuterLabel.AutoSize = True
        Me.FLOuterLabel.BackColor = System.Drawing.Color.Transparent
        Me.FLOuterLabel.Location = New System.Drawing.Point(15, 139)
        Me.FLOuterLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FLOuterLabel.Name = "FLOuterLabel"
        Me.FLOuterLabel.Size = New System.Drawing.Size(38, 20)
        Me.FLOuterLabel.TabIndex = 30
        Me.FLOuterLabel.Text = "0oC"
        '
        'FLInnerPictureBox
        '
        Me.FLInnerPictureBox.BackColor = System.Drawing.Color.OrangeRed
        Me.FLInnerPictureBox.Location = New System.Drawing.Point(89, 52)
        Me.FLInnerPictureBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FLInnerPictureBox.Name = "FLInnerPictureBox"
        Me.FLInnerPictureBox.Size = New System.Drawing.Size(30, 78)
        Me.FLInnerPictureBox.TabIndex = 29
        Me.FLInnerPictureBox.TabStop = False
        '
        'FLMiddlePictureBox
        '
        Me.FLMiddlePictureBox.BackColor = System.Drawing.Color.Yellow
        Me.FLMiddlePictureBox.Location = New System.Drawing.Point(58, 52)
        Me.FLMiddlePictureBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FLMiddlePictureBox.Name = "FLMiddlePictureBox"
        Me.FLMiddlePictureBox.Size = New System.Drawing.Size(30, 78)
        Me.FLMiddlePictureBox.TabIndex = 28
        Me.FLMiddlePictureBox.TabStop = False
        '
        'FLOuterPictureBox
        '
        Me.FLOuterPictureBox.BackColor = System.Drawing.Color.GreenYellow
        Me.FLOuterPictureBox.Location = New System.Drawing.Point(30, 52)
        Me.FLOuterPictureBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FLOuterPictureBox.Name = "FLOuterPictureBox"
        Me.FLOuterPictureBox.Size = New System.Drawing.Size(30, 78)
        Me.FLOuterPictureBox.TabIndex = 0
        Me.FLOuterPictureBox.TabStop = False
        '
        'FLMiddleLabel
        '
        Me.FLMiddleLabel.AutoSize = True
        Me.FLMiddleLabel.Location = New System.Drawing.Point(58, 139)
        Me.FLMiddleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FLMiddleLabel.Name = "FLMiddleLabel"
        Me.FLMiddleLabel.Size = New System.Drawing.Size(38, 20)
        Me.FLMiddleLabel.TabIndex = 31
        Me.FLMiddleLabel.Text = "0oC"
        '
        'FLLabel
        '
        Me.FLLabel.AutoSize = True
        Me.FLLabel.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.FLLabel.Location = New System.Drawing.Point(50, 12)
        Me.FLLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FLLabel.Name = "FLLabel"
        Me.FLLabel.Size = New System.Drawing.Size(47, 36)
        Me.FLLabel.TabIndex = 28
        Me.FLLabel.Text = "FL"
        '
        'EngineMapButtonA
        '
        Me.EngineMapButtonA.BackColor = System.Drawing.Color.Gainsboro
        Me.EngineMapButtonA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EngineMapButtonA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.EngineMapButtonA.Location = New System.Drawing.Point(197, 51)
        Me.EngineMapButtonA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EngineMapButtonA.Name = "EngineMapButtonA"
        Me.EngineMapButtonA.Size = New System.Drawing.Size(68, 35)
        Me.EngineMapButtonA.TabIndex = 28
        Me.EngineMapButtonA.Text = "A"
        Me.EngineMapButtonA.UseVisualStyleBackColor = False
        '
        'EngineMapButtonB
        '
        Me.EngineMapButtonB.BackColor = System.Drawing.Color.Gainsboro
        Me.EngineMapButtonB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EngineMapButtonB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.EngineMapButtonB.Location = New System.Drawing.Point(262, 51)
        Me.EngineMapButtonB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EngineMapButtonB.Name = "EngineMapButtonB"
        Me.EngineMapButtonB.Size = New System.Drawing.Size(68, 35)
        Me.EngineMapButtonB.TabIndex = 29
        Me.EngineMapButtonB.Text = "B"
        Me.EngineMapButtonB.UseVisualStyleBackColor = False
        '
        'CarControlPanel
        '
        Me.CarControlPanel.Controls.Add(Me.AvailabilityLabel)
        Me.CarControlPanel.Controls.Add(Me.CarControlLabel)
        Me.CarControlPanel.Controls.Add(Me.CarControlComboBox)
        Me.CarControlPanel.Controls.Add(Me.LaunchComboBox)
        Me.CarControlPanel.Controls.Add(Me.LaunchLabel)
        Me.CarControlPanel.Controls.Add(Me.EngineMapButtonA)
        Me.CarControlPanel.Controls.Add(Me.EngineMapButtonB)
        Me.CarControlPanel.Controls.Add(Me.EngineMapLabel)
        Me.CarControlPanel.Location = New System.Drawing.Point(1228, 711)
        Me.CarControlPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CarControlPanel.Name = "CarControlPanel"
        Me.CarControlPanel.Size = New System.Drawing.Size(360, 199)
        Me.CarControlPanel.TabIndex = 30
        '
        'AvailabilityLabel
        '
        Me.AvailabilityLabel.ForeColor = System.Drawing.Color.OrangeRed
        Me.AvailabilityLabel.Location = New System.Drawing.Point(17, 35)
        Me.AvailabilityLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AvailabilityLabel.Name = "AvailabilityLabel"
        Me.AvailabilityLabel.Size = New System.Drawing.Size(177, 20)
        Me.AvailabilityLabel.TabIndex = 33
        Me.AvailabilityLabel.Text = "(Currently Unavailable)"
        '
        'CarControlLabel
        '
        Me.CarControlLabel.AutoSize = True
        Me.CarControlLabel.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.CarControlLabel.Location = New System.Drawing.Point(12, 6)
        Me.CarControlLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CarControlLabel.Name = "CarControlLabel"
        Me.CarControlLabel.Size = New System.Drawing.Size(180, 33)
        Me.CarControlLabel.TabIndex = 32
        Me.CarControlLabel.Text = "Car Control"
        '
        'CarControlComboBox
        '
        Me.CarControlComboBox.BackColor = System.Drawing.Color.OrangeRed
        Me.CarControlComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CarControlComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CarControlComboBox.FormattingEnabled = True
        Me.CarControlComboBox.Items.AddRange(New Object() {"OFF", "ON"})
        Me.CarControlComboBox.Location = New System.Drawing.Point(197, 8)
        Me.CarControlComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CarControlComboBox.Name = "CarControlComboBox"
        Me.CarControlComboBox.Size = New System.Drawing.Size(80, 28)
        Me.CarControlComboBox.TabIndex = 32
        '
        'LaunchComboBox
        '
        Me.LaunchComboBox.BackColor = System.Drawing.Color.Gainsboro
        Me.LaunchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LaunchComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LaunchComboBox.FormattingEnabled = True
        Me.LaunchComboBox.Items.AddRange(New Object() {"OFF", "1", "2", "3", "4", "5", "6", "7", "8"})
        Me.LaunchComboBox.Location = New System.Drawing.Point(197, 101)
        Me.LaunchComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LaunchComboBox.Name = "LaunchComboBox"
        Me.LaunchComboBox.Size = New System.Drawing.Size(80, 28)
        Me.LaunchComboBox.TabIndex = 31
        '
        'LaunchLabel
        '
        Me.LaunchLabel.AutoSize = True
        Me.LaunchLabel.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LaunchLabel.Location = New System.Drawing.Point(10, 101)
        Me.LaunchLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LaunchLabel.Name = "LaunchLabel"
        Me.LaunchLabel.Size = New System.Drawing.Size(180, 33)
        Me.LaunchLabel.TabIndex = 32
        Me.LaunchLabel.Text = "Launch Mode"
        '
        'EngineMapLabel
        '
        Me.EngineMapLabel.AutoSize = True
        Me.EngineMapLabel.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.EngineMapLabel.Location = New System.Drawing.Point(10, 51)
        Me.EngineMapLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EngineMapLabel.Name = "EngineMapLabel"
        Me.EngineMapLabel.Size = New System.Drawing.Size(165, 33)
        Me.EngineMapLabel.TabIndex = 31
        Me.EngineMapLabel.Text = "Engine Map"
        '
        'PictureBox23
        '
        Me.PictureBox23.Image = CType(resources.GetObject("PictureBox23.Image"), System.Drawing.Image)
        Me.PictureBox23.Location = New System.Drawing.Point(6, 1)
        Me.PictureBox23.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox23.Name = "PictureBox23"
        Me.PictureBox23.Size = New System.Drawing.Size(90, 92)
        Me.PictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox23.TabIndex = 32
        Me.PictureBox23.TabStop = False
        '
        'GearPanel
        '
        Me.GearPanel.Controls.Add(Me.GearLabel)
        Me.GearPanel.Controls.Add(Me.PictureBox23)
        Me.GearPanel.Controls.Add(Me.GearValueLabel)
        Me.GearPanel.Location = New System.Drawing.Point(411, 218)
        Me.GearPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GearPanel.Name = "GearPanel"
        Me.GearPanel.Size = New System.Drawing.Size(168, 99)
        Me.GearPanel.TabIndex = 33
        '
        'GearLabel
        '
        Me.GearLabel.AutoSize = True
        Me.GearLabel.BackColor = System.Drawing.Color.Transparent
        Me.GearLabel.Font = New System.Drawing.Font("Consolas", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GearLabel.Location = New System.Drawing.Point(81, 5)
        Me.GearLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GearLabel.Name = "GearLabel"
        Me.GearLabel.Size = New System.Drawing.Size(70, 31)
        Me.GearLabel.TabIndex = 33
        Me.GearLabel.Text = "Gear"
        '
        'GearValueLabel
        '
        Me.GearValueLabel.AutoSize = True
        Me.GearValueLabel.Font = New System.Drawing.Font("Consolas", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GearValueLabel.Location = New System.Drawing.Point(91, 22)
        Me.GearValueLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GearValueLabel.Name = "GearValueLabel"
        Me.GearValueLabel.Size = New System.Drawing.Size(63, 70)
        Me.GearValueLabel.TabIndex = 34
        Me.GearValueLabel.Text = "0"
        Me.GearValueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FuelPressChart
        '
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea1.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.Orange
        ChartArea1.AxisY.InterlacedColor = System.Drawing.Color.Transparent
        ChartArea1.AxisY.IsLabelAutoFit = False
        ChartArea1.AxisY.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        ChartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Green
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea1.AxisY2.IsLabelAutoFit = False
        ChartArea1.AxisY2.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        ChartArea1.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.DarkRed
        ChartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea1.Name = "ChartArea1"
        Me.FuelPressChart.ChartAreas.Add(ChartArea1)
        Me.FuelPressChart.Cursor = System.Windows.Forms.Cursors.Default
        Legend1.Enabled = False
        Legend1.Name = "Legend1"
        Legend1.Position.Auto = False
        Legend1.Position.Height = 8.0!
        Legend1.Position.Width = 20.0!
        Legend1.Position.Y = 92.0!
        Me.FuelPressChart.Legends.Add(Legend1)
        Me.FuelPressChart.Location = New System.Drawing.Point(-51, 221)
        Me.FuelPressChart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FuelPressChart.Name = "FuelPressChart"
        Series1.BorderWidth = 2
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Color = System.Drawing.Color.Green
        Series1.Legend = "Legend1"
        Series1.Name = "FuelPressure"
        Series2.BorderWidth = 2
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.Color = System.Drawing.Color.DarkRed
        Series2.Legend = "Legend1"
        Series2.Name = "Battery"
        Series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Me.FuelPressChart.Series.Add(Series1)
        Me.FuelPressChart.Series.Add(Series2)
        Me.FuelPressChart.Size = New System.Drawing.Size(901, 186)
        Me.FuelPressChart.TabIndex = 37
        Me.FuelPressChart.Text = "Chart1"
        '
        'RpmProgress
        '
        Me.RpmProgress.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.RpmProgress.AnimationSpeed = 100
        Me.RpmProgress.BackColor = System.Drawing.Color.Transparent
        Me.RpmProgress.Font = New System.Drawing.Font("Consolas", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RpmProgress.ForeColor = System.Drawing.Color.Black
        Me.RpmProgress.InnerColor = System.Drawing.Color.White
        Me.RpmProgress.InnerMargin = 2
        Me.RpmProgress.InnerWidth = -1
        Me.RpmProgress.Location = New System.Drawing.Point(12, 48)
        Me.RpmProgress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RpmProgress.MarqueeAnimationSpeed = 2000
        Me.RpmProgress.Name = "RpmProgress"
        Me.RpmProgress.OuterColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RpmProgress.OuterMargin = -25
        Me.RpmProgress.OuterWidth = 26
        Me.RpmProgress.ProgressColor = System.Drawing.Color.Coral
        Me.RpmProgress.ProgressWidth = 25
        Me.RpmProgress.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.RpmProgress.Size = New System.Drawing.Size(225, 231)
        Me.RpmProgress.StartAngle = 180
        Me.RpmProgress.Step = 1
        Me.RpmProgress.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.RpmProgress.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.RpmProgress.SubscriptText = " "
        Me.RpmProgress.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.RpmProgress.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.RpmProgress.SuperscriptText = " "
        Me.RpmProgress.TabIndex = 10
        Me.RpmProgress.Text = "0"
        Me.RpmProgress.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.RpmProgress.Value = 10
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(15, 162)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 46)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(189, 162)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(53, 46)
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'EngineRpmLabel
        '
        Me.EngineRpmLabel.AutoSize = True
        Me.EngineRpmLabel.BackColor = System.Drawing.Color.Transparent
        Me.EngineRpmLabel.Font = New System.Drawing.Font("Consolas", 12.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EngineRpmLabel.Location = New System.Drawing.Point(54, 14)
        Me.EngineRpmLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EngineRpmLabel.Name = "EngineRpmLabel"
        Me.EngineRpmLabel.Size = New System.Drawing.Size(153, 29)
        Me.EngineRpmLabel.TabIndex = 31
        Me.EngineRpmLabel.Text = "Engine Rpm"
        '
        'RpmPanel
        '
        Me.RpmPanel.Controls.Add(Me.EngineRpmLabel)
        Me.RpmPanel.Controls.Add(Me.PictureBox3)
        Me.RpmPanel.Controls.Add(Me.PictureBox2)
        Me.RpmPanel.Controls.Add(Me.RpmProgress)
        Me.RpmPanel.Location = New System.Drawing.Point(399, 2)
        Me.RpmPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RpmPanel.Name = "RpmPanel"
        Me.RpmPanel.Size = New System.Drawing.Size(255, 194)
        Me.RpmPanel.TabIndex = 18
        '
        'BatteryLabel
        '
        Me.BatteryLabel.AutoSize = True
        Me.BatteryLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.BatteryLabel.ForeColor = System.Drawing.Color.DarkRed
        Me.BatteryLabel.Location = New System.Drawing.Point(633, 198)
        Me.BatteryLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BatteryLabel.Name = "BatteryLabel"
        Me.BatteryLabel.Size = New System.Drawing.Size(155, 28)
        Me.BatteryLabel.TabIndex = 42
        Me.BatteryLabel.Text = "Battery:0V "
        Me.BatteryLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FuelPressLabel
        '
        Me.FuelPressLabel.AutoSize = True
        Me.FuelPressLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.FuelPressLabel.ForeColor = System.Drawing.Color.Green
        Me.FuelPressLabel.Location = New System.Drawing.Point(-1, 192)
        Me.FuelPressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FuelPressLabel.Name = "FuelPressLabel"
        Me.FuelPressLabel.Size = New System.Drawing.Size(259, 28)
        Me.FuelPressLabel.TabIndex = 41
        Me.FuelPressLabel.Text = "Fuel Pressure:0kPa "
        '
        'FuelPanel
        '
        Me.FuelPanel.Controls.Add(Me.FuelPictureBox)
        Me.FuelPanel.Controls.Add(Me.FuelUsedLabel)
        Me.FuelPanel.Controls.Add(Me.FuelValueLabel)
        Me.FuelPanel.Location = New System.Drawing.Point(827, 218)
        Me.FuelPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FuelPanel.Name = "FuelPanel"
        Me.FuelPanel.Size = New System.Drawing.Size(220, 99)
        Me.FuelPanel.TabIndex = 44
        '
        'FuelPictureBox
        '
        Me.FuelPictureBox.Image = CType(resources.GetObject("FuelPictureBox.Image"), System.Drawing.Image)
        Me.FuelPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.FuelPictureBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FuelPictureBox.Name = "FuelPictureBox"
        Me.FuelPictureBox.Size = New System.Drawing.Size(90, 92)
        Me.FuelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FuelPictureBox.TabIndex = 24
        Me.FuelPictureBox.TabStop = False
        '
        'FuelUsedLabel
        '
        Me.FuelUsedLabel.AutoSize = True
        Me.FuelUsedLabel.BackColor = System.Drawing.Color.Transparent
        Me.FuelUsedLabel.Font = New System.Drawing.Font("Consolas", 12.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FuelUsedLabel.Location = New System.Drawing.Point(84, 18)
        Me.FuelUsedLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FuelUsedLabel.Name = "FuelUsedLabel"
        Me.FuelUsedLabel.Size = New System.Drawing.Size(139, 29)
        Me.FuelUsedLabel.TabIndex = 21
        Me.FuelUsedLabel.Text = "Fuel Used"
        '
        'FuelValueLabel
        '
        Me.FuelValueLabel.AutoSize = True
        Me.FuelValueLabel.Font = New System.Drawing.Font("Consolas", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FuelValueLabel.Location = New System.Drawing.Point(84, 42)
        Me.FuelValueLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FuelValueLabel.Name = "FuelValueLabel"
        Me.FuelValueLabel.Size = New System.Drawing.Size(56, 31)
        Me.FuelValueLabel.TabIndex = 14
        Me.FuelValueLabel.Text = "0ml"
        Me.FuelValueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LambdaLabel
        '
        Me.LambdaLabel.AutoSize = True
        Me.LambdaLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LambdaLabel.ForeColor = System.Drawing.Color.Magenta
        Me.LambdaLabel.Location = New System.Drawing.Point(1, 389)
        Me.LambdaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LambdaLabel.Name = "LambdaLabel"
        Me.LambdaLabel.Size = New System.Drawing.Size(129, 28)
        Me.LambdaLabel.TabIndex = 43
        Me.LambdaLabel.Text = "Lambda:0 "
        '
        'LambdaChart
        '
        ChartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea2.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.Orange
        ChartArea2.AxisY.IsLabelAutoFit = False
        ChartArea2.AxisY.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        ChartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Magenta
        ChartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea2.AxisY2.IsLabelAutoFit = False
        ChartArea2.AxisY2.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        ChartArea2.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.Orange
        ChartArea2.Name = "ChartArea1"
        Me.LambdaChart.ChartAreas.Add(ChartArea2)
        Me.LambdaChart.Cursor = System.Windows.Forms.Cursors.Default
        Legend2.Enabled = False
        Legend2.Name = "Legend1"
        Legend2.Position.Auto = False
        Legend2.Position.Height = 10.0!
        Legend2.Position.Width = 20.0!
        Legend2.Position.Y = 90.0!
        Me.LambdaChart.Legends.Add(Legend2)
        Me.LambdaChart.Location = New System.Drawing.Point(-30, 409)
        Me.LambdaChart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LambdaChart.Name = "LambdaChart"
        Series3.BorderWidth = 2
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series3.Color = System.Drawing.Color.Magenta
        Series3.Legend = "Legend1"
        Series3.Name = "Lambda"
        Me.LambdaChart.Series.Add(Series3)
        Me.LambdaChart.Size = New System.Drawing.Size(845, 186)
        Me.LambdaChart.TabIndex = 38
        Me.LambdaChart.Text = "Chart1"
        '
        'AirTempPanel
        '
        Me.AirTempPanel.Controls.Add(Me.AirTempPictureBox)
        Me.AirTempPanel.Controls.Add(Me.AirTempLabel)
        Me.AirTempPanel.Controls.Add(Me.AirTempValueLabel)
        Me.AirTempPanel.Location = New System.Drawing.Point(1052, 218)
        Me.AirTempPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AirTempPanel.Name = "AirTempPanel"
        Me.AirTempPanel.Size = New System.Drawing.Size(220, 99)
        Me.AirTempPanel.TabIndex = 49
        '
        'AirTempPictureBox
        '
        Me.AirTempPictureBox.Image = CType(resources.GetObject("AirTempPictureBox.Image"), System.Drawing.Image)
        Me.AirTempPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.AirTempPictureBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AirTempPictureBox.Name = "AirTempPictureBox"
        Me.AirTempPictureBox.Size = New System.Drawing.Size(42, 92)
        Me.AirTempPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AirTempPictureBox.TabIndex = 24
        Me.AirTempPictureBox.TabStop = False
        '
        'AirTempLabel
        '
        Me.AirTempLabel.AutoSize = True
        Me.AirTempLabel.BackColor = System.Drawing.Color.Transparent
        Me.AirTempLabel.Font = New System.Drawing.Font("Consolas", 12.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AirTempLabel.Location = New System.Drawing.Point(44, 2)
        Me.AirTempLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AirTempLabel.Name = "AirTempLabel"
        Me.AirTempLabel.Size = New System.Drawing.Size(167, 58)
        Me.AirTempLabel.TabIndex = 21
        Me.AirTempLabel.Text = "Air" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Temperature"
        '
        'AirTempValueLabel
        '
        Me.AirTempValueLabel.AutoSize = True
        Me.AirTempValueLabel.Font = New System.Drawing.Font("Consolas", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AirTempValueLabel.Location = New System.Drawing.Point(48, 55)
        Me.AirTempValueLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AirTempValueLabel.Name = "AirTempValueLabel"
        Me.AirTempValueLabel.Size = New System.Drawing.Size(56, 31)
        Me.AirTempValueLabel.TabIndex = 14
        Me.AirTempValueLabel.Text = "0oC"
        Me.AirTempValueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ChartPanel1
        '
        Me.ChartPanel1.Controls.Add(Me.LambdaLabel)
        Me.ChartPanel1.Controls.Add(Me.BatteryLabel)
        Me.ChartPanel1.Controls.Add(Me.FuelPressLabel)
        Me.ChartPanel1.Controls.Add(Me.LambdaChart)
        Me.ChartPanel1.Controls.Add(Me.FuelPressChart)
        Me.ChartPanel1.Controls.Add(Me.OilPressChartLabel)
        Me.ChartPanel1.Controls.Add(Me.RpmChartLabel)
        Me.ChartPanel1.Controls.Add(Me.RpmOilPressChart)
        Me.ChartPanel1.Location = New System.Drawing.Point(400, 332)
        Me.ChartPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChartPanel1.Name = "ChartPanel1"
        Me.ChartPanel1.Size = New System.Drawing.Size(840, 728)
        Me.ChartPanel1.TabIndex = 51
        '
        'OilPressChartLabel
        '
        Me.OilPressChartLabel.AutoSize = True
        Me.OilPressChartLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.OilPressChartLabel.ForeColor = System.Drawing.Color.Orange
        Me.OilPressChartLabel.Location = New System.Drawing.Point(555, 0)
        Me.OilPressChartLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.OilPressChartLabel.Name = "OilPressChartLabel"
        Me.OilPressChartLabel.Size = New System.Drawing.Size(233, 28)
        Me.OilPressChartLabel.TabIndex = 57
        Me.OilPressChartLabel.Text = "Oil Pressure:0kPa"
        Me.OilPressChartLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'RpmChartLabel
        '
        Me.RpmChartLabel.AutoSize = True
        Me.RpmChartLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.RpmChartLabel.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.RpmChartLabel.Location = New System.Drawing.Point(18, 0)
        Me.RpmChartLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RpmChartLabel.Name = "RpmChartLabel"
        Me.RpmChartLabel.Size = New System.Drawing.Size(77, 28)
        Me.RpmChartLabel.TabIndex = 54
        Me.RpmChartLabel.Text = "RPM:0"
        '
        'RpmOilPressChart
        '
        ChartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea3.AxisY.IsLabelAutoFit = False
        ChartArea3.AxisY.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        ChartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.CornflowerBlue
        ChartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea3.AxisY2.IsLabelAutoFit = False
        ChartArea3.AxisY2.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        ChartArea3.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.Orange
        ChartArea3.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea3.Name = "ChartArea1"
        Me.RpmOilPressChart.ChartAreas.Add(ChartArea3)
        Me.RpmOilPressChart.Cursor = System.Windows.Forms.Cursors.Default
        Legend3.Enabled = False
        Legend3.Name = "Legend1"
        Legend3.Position.Auto = False
        Legend3.Position.Height = 8.0!
        Legend3.Position.Width = 20.0!
        Legend3.Position.Y = 92.0!
        Me.RpmOilPressChart.Legends.Add(Legend3)
        Me.RpmOilPressChart.Location = New System.Drawing.Point(-51, 20)
        Me.RpmOilPressChart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RpmOilPressChart.Name = "RpmOilPressChart"
        Series4.BorderWidth = 2
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series4.Legend = "Legend1"
        Series4.Name = "RPM"
        Series5.BorderWidth = 2
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series5.Legend = "Legend1"
        Series5.Name = "OilPress"
        Series5.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Me.RpmOilPressChart.Series.Add(Series4)
        Me.RpmOilPressChart.Series.Add(Series5)
        Me.RpmOilPressChart.Size = New System.Drawing.Size(901, 186)
        Me.RpmOilPressChart.TabIndex = 54
        '
        'TPSLabel
        '
        Me.TPSLabel.AutoSize = True
        Me.TPSLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.TPSLabel.ForeColor = System.Drawing.Color.Orange
        Me.TPSLabel.Location = New System.Drawing.Point(673, 5)
        Me.TPSLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TPSLabel.Name = "TPSLabel"
        Me.TPSLabel.Size = New System.Drawing.Size(103, 28)
        Me.TPSLabel.TabIndex = 40
        Me.TPSLabel.Text = "TPS:0% "
        Me.TPSLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MAPLabel
        '
        Me.MAPLabel.AutoSize = True
        Me.MAPLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.MAPLabel.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.MAPLabel.Location = New System.Drawing.Point(3, 1)
        Me.MAPLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MAPLabel.Name = "MAPLabel"
        Me.MAPLabel.Size = New System.Drawing.Size(116, 28)
        Me.MAPLabel.TabIndex = 39
        Me.MAPLabel.Text = "MAP:0kPa"
        '
        'ChartButtonsPanel
        '
        Me.ChartButtonsPanel.Controls.Add(Me.Page2Button)
        Me.ChartButtonsPanel.Controls.Add(Me.Page1Button)
        Me.ChartButtonsPanel.Location = New System.Drawing.Point(705, 318)
        Me.ChartButtonsPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChartButtonsPanel.Name = "ChartButtonsPanel"
        Me.ChartButtonsPanel.Size = New System.Drawing.Size(233, 41)
        Me.ChartButtonsPanel.TabIndex = 52
        '
        'Page2Button
        '
        Me.Page2Button.BackColor = System.Drawing.Color.Gainsboro
        Me.Page2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Page2Button.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Page2Button.Location = New System.Drawing.Point(116, 2)
        Me.Page2Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Page2Button.Name = "Page2Button"
        Me.Page2Button.Size = New System.Drawing.Size(112, 35)
        Me.Page2Button.TabIndex = 54
        Me.Page2Button.Text = "Page2"
        Me.Page2Button.UseVisualStyleBackColor = False
        '
        'Page1Button
        '
        Me.Page1Button.BackColor = System.Drawing.Color.Gainsboro
        Me.Page1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Page1Button.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Page1Button.Location = New System.Drawing.Point(4, 2)
        Me.Page1Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Page1Button.Name = "Page1Button"
        Me.Page1Button.Size = New System.Drawing.Size(112, 35)
        Me.Page1Button.TabIndex = 53
        Me.Page1Button.Text = "Page1"
        Me.Page1Button.UseVisualStyleBackColor = False
        '
        'ChartPanel2
        '
        Me.ChartPanel2.BackColor = System.Drawing.Color.White
        Me.ChartPanel2.Controls.Add(Me.Label7)
        Me.ChartPanel2.Controls.Add(Me.Label6)
        Me.ChartPanel2.Controls.Add(Me.Label5)
        Me.ChartPanel2.Controls.Add(Me.Chart3)
        Me.ChartPanel2.Controls.Add(Me.Chart2)
        Me.ChartPanel2.Controls.Add(Me.MAPLabel)
        Me.ChartPanel2.Controls.Add(Me.TPSLabel)
        Me.ChartPanel2.Controls.Add(Me.MAPTPSChart)
        Me.ChartPanel2.Location = New System.Drawing.Point(399, 329)
        Me.ChartPanel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChartPanel2.Name = "ChartPanel2"
        Me.ChartPanel2.Size = New System.Drawing.Size(840, 600)
        Me.ChartPanel2.TabIndex = 53
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Magenta
        Me.Label7.Location = New System.Drawing.Point(17, 386)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 28)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "NaN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(665, 198)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 28)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "NaN"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(14, 192)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 28)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "NaN"
        '
        'Chart3
        '
        ChartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea4.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.Orange
        ChartArea4.AxisY.IsLabelAutoFit = False
        ChartArea4.AxisY.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        ChartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Magenta
        ChartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea4.AxisY2.IsLabelAutoFit = False
        ChartArea4.AxisY2.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        ChartArea4.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.Orange
        ChartArea4.Name = "ChartArea1"
        Me.Chart3.ChartAreas.Add(ChartArea4)
        Me.Chart3.Cursor = System.Windows.Forms.Cursors.Default
        Legend4.Enabled = False
        Legend4.Name = "Legend1"
        Legend4.Position.Auto = False
        Legend4.Position.Height = 10.0!
        Legend4.Position.Width = 20.0!
        Legend4.Position.Y = 90.0!
        Me.Chart3.Legends.Add(Legend4)
        Me.Chart3.Location = New System.Drawing.Point(-30, 409)
        Me.Chart3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Chart3.Name = "Chart3"
        Series6.BorderWidth = 2
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series6.Color = System.Drawing.Color.Magenta
        Series6.Legend = "Legend1"
        Series6.Name = "Lambda"
        Me.Chart3.Series.Add(Series6)
        Me.Chart3.Size = New System.Drawing.Size(845, 186)
        Me.Chart3.TabIndex = 56
        Me.Chart3.Text = "Chart1"
        '
        'Chart2
        '
        ChartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea5.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.Orange
        ChartArea5.AxisY.InterlacedColor = System.Drawing.Color.Transparent
        ChartArea5.AxisY.IsLabelAutoFit = False
        ChartArea5.AxisY.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        ChartArea5.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Green
        ChartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea5.AxisY2.IsLabelAutoFit = False
        ChartArea5.AxisY2.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        ChartArea5.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.Red
        ChartArea5.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea5.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea5)
        Me.Chart2.Cursor = System.Windows.Forms.Cursors.Default
        Legend5.Enabled = False
        Legend5.Name = "Legend1"
        Legend5.Position.Auto = False
        Legend5.Position.Height = 8.0!
        Legend5.Position.Width = 20.0!
        Legend5.Position.Y = 92.0!
        Me.Chart2.Legends.Add(Legend5)
        Me.Chart2.Location = New System.Drawing.Point(-30, 215)
        Me.Chart2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Chart2.Name = "Chart2"
        Series7.BorderWidth = 2
        Series7.ChartArea = "ChartArea1"
        Series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series7.Color = System.Drawing.Color.Green
        Series7.Legend = "Legend1"
        Series7.Name = "FuelPressure"
        Series8.BorderWidth = 2
        Series8.ChartArea = "ChartArea1"
        Series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series8.Color = System.Drawing.Color.Red
        Series8.Legend = "Legend1"
        Series8.Name = "Battery"
        Series8.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Me.Chart2.Series.Add(Series7)
        Me.Chart2.Series.Add(Series8)
        Me.Chart2.Size = New System.Drawing.Size(901, 186)
        Me.Chart2.TabIndex = 55
        Me.Chart2.Text = "Chart1"
        '
        'MAPTPSChart
        '
        ChartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea6.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.Orange
        ChartArea6.AxisY.IsLabelAutoFit = False
        ChartArea6.AxisY.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        ChartArea6.AxisY.LabelStyle.ForeColor = System.Drawing.Color.CornflowerBlue
        ChartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea6.AxisY2.IsLabelAutoFit = False
        ChartArea6.AxisY2.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        ChartArea6.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.Orange
        ChartArea6.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea6.Name = "ChartArea1"
        Me.MAPTPSChart.ChartAreas.Add(ChartArea6)
        Me.MAPTPSChart.Cursor = System.Windows.Forms.Cursors.Default
        Legend6.Enabled = False
        Legend6.Name = "Legend1"
        Legend6.Position.Auto = False
        Legend6.Position.Height = 8.0!
        Legend6.Position.Width = 20.0!
        Legend6.Position.Y = 92.0!
        Me.MAPTPSChart.Legends.Add(Legend6)
        Me.MAPTPSChart.Location = New System.Drawing.Point(-26, 20)
        Me.MAPTPSChart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MAPTPSChart.Name = "MAPTPSChart"
        Series9.BorderWidth = 2
        Series9.ChartArea = "ChartArea1"
        Series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series9.Legend = "Legend1"
        Series9.Name = "MAP"
        Series10.BorderWidth = 2
        Series10.ChartArea = "ChartArea1"
        Series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series10.Legend = "Legend1"
        Series10.Name = "TPS"
        Series10.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Me.MAPTPSChart.Series.Add(Series9)
        Me.MAPTPSChart.Series.Add(Series10)
        Me.MAPTPSChart.Size = New System.Drawing.Size(901, 186)
        Me.MAPTPSChart.TabIndex = 36
        Me.MAPTPSChart.Text = "Chart1"
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Font = New System.Drawing.Font("Consolas", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.Location = New System.Drawing.Point(82, 299)
        Me.TimeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(112, 31)
        Me.TimeLabel.TabIndex = 54
        Me.TimeLabel.Text = "Time: 0"
        Me.TimeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ARTPictureBox
        '
        Me.ARTPictureBox.Image = CType(resources.GetObject("ARTPictureBox.Image"), System.Drawing.Image)
        Me.ARTPictureBox.Location = New System.Drawing.Point(3, 686)
        Me.ARTPictureBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ARTPictureBox.Name = "ARTPictureBox"
        Me.ARTPictureBox.Size = New System.Drawing.Size(225, 231)
        Me.ARTPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ARTPictureBox.TabIndex = 25
        Me.ARTPictureBox.TabStop = False
        '
        'RefuelButton
        '
        Me.RefuelButton.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.RefuelButton.Location = New System.Drawing.Point(88, 429)
        Me.RefuelButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RefuelButton.Name = "RefuelButton"
        Me.RefuelButton.Size = New System.Drawing.Size(112, 35)
        Me.RefuelButton.TabIndex = 55
        Me.RefuelButton.Text = "Refuel"
        Me.RefuelButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1593, 956)
        Me.Controls.Add(Me.RefuelButton)
        Me.Controls.Add(Me.TyreTempPanel)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.ChartButtonsPanel)
        Me.Controls.Add(Me.ARTPictureBox)
        Me.Controls.Add(Me.AirTempPanel)
        Me.Controls.Add(Me.CarControlPanel)
        Me.Controls.Add(Me.FuelPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ChartPanel1)
        Me.Controls.Add(Me.BrakeTempPanel)
        Me.Controls.Add(Me.GearPanel)
        Me.Controls.Add(Me.OilTempPanel)
        Me.Controls.Add(Me.EngineTempPanel)
        Me.Controls.Add(Me.RpmPanel)
        Me.Controls.Add(Me.ConnectionPanel)
        Me.Controls.Add(Me.SpeedPanel)
        Me.Controls.Add(Me.ChartPanel2)
        Me.Controls.Add(Me.TyreTempDetailPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "ARTelemetry"
        Me.ConnectionPanel.ResumeLayout(False)
        Me.ConnectionPanel.PerformLayout()
        CType(Me.PictureBoxConnectionStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BrakeTempPanel.ResumeLayout(False)
        Me.BrakeTempPanel.PerformLayout()
        CType(Me.BrakeDiscPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SpeedPanel.ResumeLayout(False)
        Me.SpeedPanel.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EngineTempPanel.ResumeLayout(False)
        Me.EngineTempPanel.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OilTempPanel.ResumeLayout(False)
        Me.OilTempPanel.PerformLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Manometer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TyreTempPanel.ResumeLayout(False)
        Me.TyreTempPanel.PerformLayout()
        CType(Me.RRTyrePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RLTyrePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FRTyrePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLTyrePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TyreTempDetailPanel.ResumeLayout(False)
        Me.TyreTempDetailPanel.PerformLayout()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLInnerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLMiddlePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLOuterPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CarControlPanel.ResumeLayout(False)
        Me.CarControlPanel.PerformLayout()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GearPanel.ResumeLayout(False)
        Me.GearPanel.PerformLayout()
        CType(Me.FuelPressChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RpmPanel.ResumeLayout(False)
        Me.RpmPanel.PerformLayout()
        Me.FuelPanel.ResumeLayout(False)
        Me.FuelPanel.PerformLayout()
        CType(Me.FuelPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LambdaChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AirTempPanel.ResumeLayout(False)
        Me.AirTempPanel.PerformLayout()
        CType(Me.AirTempPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ChartPanel1.ResumeLayout(False)
        Me.ChartPanel1.PerformLayout()
        CType(Me.RpmOilPressChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ChartButtonsPanel.ResumeLayout(False)
        Me.ChartPanel2.ResumeLayout(False)
        Me.ChartPanel2.PerformLayout()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MAPTPSChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARTPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConnectionPanel As Panel
    Friend WithEvents DisconnectButton As Button
    Friend WithEvents ConnectionButton As Button
    Friend WithEvents ComboBoxBaudRate As ComboBox
    Friend WithEvents BaudRateLabel As Label
    Friend WithEvents ConnectionLabel As Label
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents ScanButton As Button
    Friend WithEvents LabelStatus As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents TimerSerial As Timer
    Friend WithEvents PictureBoxConnectionStatus As PictureBox
    Friend WithEvents SpeedPanel As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents SpeedProgress As CircularProgressBar.CircularProgressBar
    Friend WithEvents EngineTempPanel As Panel
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents EngineTempProgress As CircularProgressBar.CircularProgressBar
    Friend WithEvents EngineTempLabel As Label
    Friend WithEvents OilTempPanel As Panel
    Friend WithEvents OilTempLabel As Label
    Friend WithEvents OilTempProgress As CircularProgressBar.CircularProgressBar
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Manometer As PictureBox
    Friend WithEvents OilPressLabel As Label
    Friend WithEvents CarLayout As PictureBox
    Friend WithEvents TyreTempPanel As Panel
    Friend WithEvents FLTyrePictureBox As PictureBox
    Friend WithEvents RLTyrePictureBox As PictureBox
    Friend WithEvents FRTyrePictureBox As PictureBox
    Friend WithEvents RRTyrePictureBox As PictureBox
    Friend WithEvents FLTempLabel As Label
    Friend WithEvents RLTempLabel As Label
    Friend WithEvents RRTempLabel As Label
    Friend WithEvents FRTempLabel As Label
    Friend WithEvents TyreTempDetailPanel As Panel
    Friend WithEvents FLInnerPictureBox As PictureBox
    Friend WithEvents FLMiddlePictureBox As PictureBox
    Friend WithEvents FLOuterPictureBox As PictureBox
    Friend WithEvents FLLabel As Label
    Friend WithEvents FLOuterLabel As Label
    Friend WithEvents RROuterLabel As Label
    Friend WithEvents RRInnerLabel As Label
    Friend WithEvents RRLabel As Label
    Friend WithEvents PictureBox19 As PictureBox
    Friend WithEvents PictureBox20 As PictureBox
    Friend WithEvents PictureBox21 As PictureBox
    Friend WithEvents RRMiddleLabel As Label
    Friend WithEvents RLInnerLabel As Label
    Friend WithEvents RLOuterLabel As Label
    Friend WithEvents RLLabel As Label
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents PictureBox18 As PictureBox
    Friend WithEvents RLMiddleLabel As Label
    Friend WithEvents FROuterLabel As Label
    Friend WithEvents FRInnerLabel As Label
    Friend WithEvents FRLabel As Label
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents FRMiddleLabel As Label
    Friend WithEvents FLInnerLabel As Label
    Friend WithEvents FLMiddleLabel As Label
    Friend WithEvents TyreTempButton As Button
    Friend WithEvents TyreTempBackButton As Button
    Friend WithEvents EngineMapButtonA As Button
    Friend WithEvents EngineMapButtonB As Button
    Friend WithEvents CarControlPanel As Panel
    Friend WithEvents EngineMapLabel As Label
    Friend WithEvents LaunchLabel As Label
    Friend WithEvents LaunchComboBox As ComboBox
    Friend WithEvents SpeedLabel As Label
    Friend WithEvents CarControlComboBox As ComboBox
    Friend WithEvents CarControlLabel As Label
    Friend WithEvents PictureBox23 As PictureBox
    Friend WithEvents GearPanel As Panel
    Friend WithEvents GearLabel As Label
    Friend WithEvents GearValueLabel As Label
    Friend WithEvents BrakeTempPanel As Panel
    Friend WithEvents BrakeDiscPictureBox As PictureBox
    Friend WithEvents ChassisTempLabel As Label
    Friend WithEvents ChassisTempValueLabel As Label
    Friend WithEvents FuelPressChart As DataVisualization.Charting.Chart
    Friend WithEvents RpmProgress As CircularProgressBar.CircularProgressBar
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents EngineRpmLabel As Label
    Friend WithEvents RpmPanel As Panel
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents BatteryLabel As Label
    Friend WithEvents FuelPressLabel As Label
    Friend WithEvents FuelPanel As Panel
    Friend WithEvents FuelPictureBox As PictureBox
    Friend WithEvents FuelUsedLabel As Label
    Friend WithEvents FuelValueLabel As Label
    Friend WithEvents LambdaLabel As Label
    Friend WithEvents LambdaChart As DataVisualization.Charting.Chart
    Friend WithEvents AirTempPanel As Panel
    Friend WithEvents AirTempPictureBox As PictureBox
    Friend WithEvents AirTempLabel As Label
    Friend WithEvents AirTempValueLabel As Label
    Friend WithEvents ShowSerialDataButton As Button
    Friend WithEvents HideSerialDataButton As Button
    Friend WithEvents TimerComboBox As ComboBox
    Friend WithEvents TimerLabel As Label
    Friend WithEvents ChartPanel1 As Panel
    Friend WithEvents TPSLabel As Label
    Friend WithEvents MAPLabel As Label
    Friend WithEvents ChartButtonsPanel As Panel
    Friend WithEvents Page2Button As Button
    Friend WithEvents Page1Button As Button
    Friend WithEvents ChartPanel2 As Panel
    Friend WithEvents RpmOilPressChart As DataVisualization.Charting.Chart
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents OilPressChartLabel As Label
    Friend WithEvents RpmChartLabel As Label
    Friend WithEvents Chart3 As DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents SignalStrengthLabel As Label
    Friend WithEvents SignalStrengthValueLabel As Label
    Friend WithEvents AvailabilityLabel As Label
    Friend WithEvents MAPTPSChart As DataVisualization.Charting.Chart
    Friend WithEvents TimeLabel As Label
    Friend WithEvents ARTPictureBox As PictureBox
    Friend WithEvents RefuelButton As Button
End Class
